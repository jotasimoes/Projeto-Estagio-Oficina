using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Net.Http;
using OficinaV2.Models;
using Newtonsoft.Json;

namespace OficinaV2
{
   /// <summary>
   /// Interaction logic for EcraPeca.xaml
   /// </summary>
   public partial class EcraPeca : Window
   {
      Peca Entidade = new Peca();
      public EcraPeca()
      {
         InitializeComponent();
         pecasControlTeste.LoadPecas();

      }   
     

      //click event para detetar peça selecionada
      private void PecasControlTeste_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
      {
         var pecaselecionada = pecasControlTeste.selectedPeca;
         Entidade = pecaselecionada;
         DataContext = Entidade;
      }
      private async void Gravar_Click(object sender, RoutedEventArgs e)
      {
         var peca = new Peca
         {
            Id_peca = pecasControlTeste.selectedPeca.Id_peca,
            Descricao_peca = descricao_peca_txt.Text,
            Preco_peca = decimal.Parse(preco_peca_txt.Text)
         };

         var apiClient = new WebApi();
         await apiClient.UpdatePeca(peca);

         pecasControlTeste.LoadPecas();         
      }

      private async void Remover_Click(object sender, RoutedEventArgs e)
      {         
         var peca = new Peca
         {
            Id_peca = pecasControlTeste.selectedPeca.Id_peca        
         };

         var apiClient = new WebApi();
         await apiClient.RemoverPeca(peca);

         pecasControlTeste.LoadPecas();        
      }
   }


}
