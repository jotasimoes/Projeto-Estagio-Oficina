using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OficinaV2.Models;

namespace OficinaV2
{
   /// <summary>
   /// Interaction logic for PecaControl.xaml
   /// </summary>
   public partial class PecaControl : UserControl
   {
      public Peca selectedPeca = new Peca();
      public List<Peca> _pecas = new List<Peca>();

      public PecaControl()
      {
         InitializeComponent();
         LoadPecas();
         DataContext = selectedPeca;
      }   

      public Border selectedBorder;

      public async void LoadPecas()
      {
         PecasItemsControl.ItemsSource = null;
         _pecas.Clear();

         var apiClient = new WebApi();
         _pecas = await apiClient.GetPecasAsync();        

         PecasItemsControl.ItemsSource = _pecas;
      }

      private void OnRowClick(object sender, RoutedEventArgs e)
      {
         // Reset background color do item selecionado anteriormente
         if (selectedBorder != null)
         {
            selectedBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEE"));

         }

         // Set background color do item clickado para indicar seleção
         var clickedBorder = sender as Border;
         if (clickedBorder != null)
         {
            clickedBorder.Background = Brushes.LightBlue;
            selectedBorder = clickedBorder;
            selectedPeca = (Peca)clickedBorder.DataContext; // Objeto tipo 'Peca' selecionado


         }
      }


   }
}
