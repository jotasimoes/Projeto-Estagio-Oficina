using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using OficinaV2.Models;


namespace OficinaV2
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {

      public MainWindow()
      {
         InitializeComponent();
         
      }

      private void Pecas_Click(object sender, RoutedEventArgs e)
      {
         EcraPeca window = new EcraPeca();
         window.Show();         
      }

      private void ControloStock_Click(object sender, RoutedEventArgs e)
      {
         EcraMovimento window = new EcraMovimento();
         window.Show();         
      }

      private void NovaReparacao_Click(object sender, RoutedEventArgs e)
      {
         EcraReparacoes2 window = new EcraReparacoes2();
         window.Show();
      }
      
      private void Sair_Click(object sender, RoutedEventArgs e)
      {
         var api = new WebApi();
      }

      private void ExistenciasStock_Click(object sender, RoutedEventArgs e)
      {
        ExistenciasStock window = new ExistenciasStock();
         window.Show();
      }

      private void Reparacoes_Click(object sender, RoutedEventArgs e)
      {
         ReparacoesListagem window = new ReparacoesListagem();
         window.Show();
      }
   }
}
