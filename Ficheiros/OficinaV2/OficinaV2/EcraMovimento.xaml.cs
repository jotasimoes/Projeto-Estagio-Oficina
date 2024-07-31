using DevExpress.Mvvm.Native;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;
using OficinaV2.Models;
using System.ComponentModel.DataAnnotations;

namespace OficinaV2
{
   /// <summary>
   /// Interaction logic for EcraMovimento.xaml
   /// </summary>
   public partial class EcraMovimento : Window
   {
      Peca selectedPeca = null;

      public List<Movimento> _movimentos = new List<Movimento>();
      public List<Peca> _pecas = new List<Peca>();
      public ObservableCollection<int> OperacaoItems { get; set; }

      public EcraMovimento()
      {
         InitializeComponent();         
         LoadPecas();        
         OperacaoItems = new ObservableCollection<int> { 1, -1 };         
         Vista.DataContext= this;         
      }      

      public async void LoadPecas()
      {
         ComboBoxIdPeca.ItemsSource = null;
         _pecas.Clear();

         var api = new WebApi();
         _pecas = await api.GetPecasAsync();

         ComboBoxIdPeca.ItemsSource = _pecas;             
      }

      private void ComboBoxIdPeca_SelectionChanged(object sender, EventArgs e)
      {            
         LoadMovimento();
         descricao_peca_txt.DataContext = selectedPeca;
      }      

      public async void LoadMovimento()
      {
         _movimentos.Clear();

         selectedPeca = (Peca)ComboBoxIdPeca.SelectedItem;

         var api = new WebApi();
         _movimentos = await api.GetMovimentosPorPecaAsync(selectedPeca.Id_peca);
         MovimentosGridControl.ItemsSource = _movimentos;
      }
         
      private async void RemoverMenuItem_Click(object sender, RoutedEventArgs e)
      {
         var selectedMovimento = (Movimento)MovimentosGridControl.GetRow(Vista.FocusedRowHandle);

         int selectedIdPeca = selectedPeca.Id_peca;

         var api = new WebApi();
         await api.RemoverMovimento(selectedIdPeca, selectedMovimento.Id_movimento);

         LoadMovimento();         
      }

      private async void Novo_Movimento_Click(object sender, RoutedEventArgs e)
      {
         Movimento novoMovimento = new Movimento
         {
            Descricao_movimento = "Novo Movimento",
            Quantidade_movimento = 0,
            Data_movimento = DateTime.Now,
            Operacao = 0
         };

         _movimentos.Add(novoMovimento);

         var api = new WebApi();
         await api.AdicionarMovimento(selectedPeca.Id_peca, novoMovimento);
         
         LoadMovimento();         
      }

      private async void Vista_ValidateRow(object sender, GridRowValidationEventArgs e)
      {
         Movimento movimentoEditado = e.Row as Movimento;

         var api = new WebApi();
         await api.AtualizarMovimento(movimentoEditado);
         
         LoadMovimento();
      }
   }
}

