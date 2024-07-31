using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OficinaV2.Models;

namespace OficinaV2
{
   
   public partial class EcraReparacoes2 : Window
   {
      public Reparacao reparacao = new Reparacao();
      public List<Peca> _pecas = new List<Peca>();
      public ObservableCollection<Peca_reparacao> _pecasUtilizadas = new ObservableCollection<Peca_reparacao>();
      public EcraReparacoes2()
      {
         InitializeComponent();
         LoadPecas();
         reparacao.Id_reparacao = 0;
         PecasGridControl.ItemsSource = _pecasUtilizadas;         
         DataContext = reparacao;         
      }
           

      public async void LoadPecas()
      {
         var api = new WebApi();
         _pecas = await api.GetPecasAsync();
         PecasCombobox.ItemsSource = _pecas;
      }
      
      private void Nova_Peca_Click(object sender, RoutedEventArgs e)
      {
         Peca_reparacao novaPeca = new Peca_reparacao
         {
            Id_peca = 0,
            Descricao_peca = "",
            Quantidade_pecas_reparacoes = 0
         };

         _pecasUtilizadas.Add(novaPeca);

         int newRowHandle = PecasGridControl.GetRowHandleByListIndex(_pecasUtilizadas.Count - 1);
         PecasGridControl.View.FocusedRowHandle = newRowHandle;
         int selectedRowHandle = PecasGridControl.View.FocusedRowHandle;
         PecasGridControl.View.ScrollIntoView(selectedRowHandle);
      }

      private void Vista_ValidateRow(object sender, DevExpress.Xpf.Grid.GridRowValidationEventArgs e)
      {
         //Get peca editada
         Peca_reparacao pecaEditada = e.Row as Peca_reparacao;

         //first é um método linq que retorna o primeiro elemento que satisfaz a condição de ter a mesma descrição        
         string descricao = pecaEditada.Descricao_peca;
         pecaEditada.Id_peca = _pecas.First(p => p.Descricao_peca == descricao).Id_peca;         
      }

      private async void Gravar_CLick(object sender, RoutedEventArgs e)
      {
         if(matricula_txt.Text=="" || marca_txt.Text == "" || cor_txt.Text == "" || data_txt.Text=="" ) {
            MessageBox.Show("Insira todos os campos acerca da reparação!");
         }
         else if (_pecasUtilizadas.Count == 0)
         {
            MessageBox.Show("Insira peças na lista!");
         }
         else
         {           
            string selectedDate = data_txt.SelectedDate.Value.ToString("yyyy-MM-dd");    
            DateTime parsedDate = DateTime.ParseExact(selectedDate, "yyyy-MM-dd", null);
           
            reparacao.Matricula= matricula_txt.Text;
            reparacao.Marca= marca_txt.Text;
            reparacao.Cor= cor_txt.Text;
            reparacao.Data_reparacao = parsedDate;
            reparacao.Estado = "Em reparação";

            var api = new WebApi();
            await api.AdicionarReparacao(reparacao);
            reparacao.Id_reparacao= await api.GetLastReparacao();

            matricula_txt.IsReadOnly=true;
            marca_txt.IsReadOnly=true;
            cor_txt.IsReadOnly=true;
            data_txt.IsEnabled = false;
            estado_txt.Visibility = Visibility.Visible;
            estado_txt.Text = "Em reparação";
         }
      }

      private async void Anular_Click(object sender, RoutedEventArgs e)
      {
         if (reparacao.Id_reparacao != 0)
         {
            matricula_txt.Text = "";
            marca_txt.Text = "";
            cor_txt.Text = "";
            data_txt.Text = "";           

            matricula_txt.IsReadOnly = false;
            marca_txt.IsReadOnly = false;
            cor_txt.IsReadOnly = false;
            data_txt.IsEnabled = true;
            reparacao.Estado = "Anulado";
            estado_txt.Text = "Anulado";
            _pecasUtilizadas.Clear();            

            var api = new WebApi();
            await api.AtualizarReparacao(reparacao);

            reparacao.Id_reparacao = 0;            
         }
         else
         {
            MessageBox.Show("Não existe reparação em progresso!");
         }           
      }

      private async void Finalizar_Click(object sender, RoutedEventArgs e)
      {
         var api = new WebApi();

         if (reparacao.Id_reparacao==0 && _pecasUtilizadas.Count !=0)
         {
            MessageBox.Show("Inicie a reparação antes de finalizar!");
         }
         else if (_pecasUtilizadas.Any(p => p.Id_peca == 0))
         {
            MessageBox.Show("Escolha uma peça antes de finalizar!");
         }
         else
         {
           
            foreach (Peca_reparacao pecaUtilizada in _pecasUtilizadas)
            {
             
               var novoMovimento = new Movimento { Id_peca = pecaUtilizada.Id_peca, Quantidade_movimento = pecaUtilizada.Quantidade_pecas_reparacoes, Data_movimento = reparacao.Data_reparacao, Descricao_movimento = "Reparação", Operacao=-1 };
               await api.AdicionarMovimento(pecaUtilizada.Id_peca, novoMovimento);
             
               var novaPecaReparacao = new Peca_reparacao { Id_reparacao = reparacao.Id_reparacao, Id_peca = pecaUtilizada.Id_peca,Id_movimento= await api.GetLastMovimento() , Quantidade_pecas_reparacoes = pecaUtilizada.Quantidade_pecas_reparacoes };
               await api.AdicionarPeca_reparacao(novaPecaReparacao);
              
               MessageBox.Show(pecaUtilizada.Descricao_peca + " dada como saída!");
            }
            reparacao.Estado = "Finalizada";
            await api.AtualizarReparacao(reparacao);
            MessageBox.Show("Reparação finalizada!");

            reparacao.Id_reparacao = 0;
            matricula_txt.Text = "";
            marca_txt.Text = "";
            cor_txt.Text = "";
            data_txt.Text = "";
            estado_txt.Text = "Finalizada";
            matricula_txt.IsReadOnly = false;
            marca_txt.IsReadOnly = false;
            cor_txt.IsReadOnly = false;
            data_txt.IsEnabled = true;           
            _pecasUtilizadas.Clear();
         }
         
      }
   }
}
