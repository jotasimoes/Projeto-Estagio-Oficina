using OficinaV2.Models;
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

namespace OficinaV2
{
   public partial class ExistenciasStock : Window
   {
      public List<Peca> _pecas = new List<Peca>();
      public List<Movimento> _movimentos = new List<Movimento>();
      public List<PecaStock> _pecasStock = new List<PecaStock>();


      public ExistenciasStock()
      {
         InitializeComponent();               
      }

      private async void Window_Loaded(object sender, RoutedEventArgs e)
      {
         var api = new WebApi();

         _pecas = await api.GetPecasAsync();
         _movimentos = await api.GetMovimentosAsync();

         _pecasStock = _pecas.Select(peca =>
         {
            var quantidadeMovimentos = _movimentos.Where(movimento => movimento.Id_peca == peca.Id_peca).Sum(movimento => movimento.Quantidade_movimento * movimento.Operacao);
            return new PecaStock { Peca = peca, Descricao_peca=peca.Descricao_peca, Stock = quantidadeMovimentos };
         }).ToList();               

         PecasStock.ItemsSource = _pecasStock;
      }
   }
}
