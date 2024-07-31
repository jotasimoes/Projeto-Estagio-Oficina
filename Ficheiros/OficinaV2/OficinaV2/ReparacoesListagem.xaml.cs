using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;
using OficinaV2.Models;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.Native;
using static OficinaV2.ReparacoesListagem;

namespace OficinaV2
{
   /// <summary>
   /// Interaction logic for ReparacoesListagem.xaml
   /// </summary>
   public partial class ReparacoesListagem : Window
   {
      public List<ReparacaoComPecas> dados = new List<ReparacaoComPecas>();
      public ReparacoesListagem()
      {
         InitializeComponent();

      }

      private async void Window_Loaded(object sender, RoutedEventArgs e)
      {
         var api = new WebApi();

         var _reparacoes = await api.GetReparacoesAsync();
         var t = JsonConvert.SerializeObject(_reparacoes);
         dados = JsonConvert.DeserializeObject<List<ReparacaoComPecas>>(t);
         foreach (var item in dados)
         {
            var _pecasreparacoes = await api.GetPecasReparacoesDTOPorReparacao(item.Id_reparacao);
            item.listapecas.AddRange(_pecasreparacoes);
         }

         ReparacoesGrid.ItemsSource = dados;
         DataContext = dados;
      }

      public class ReparacaoComPecas : Reparacao
      {
         public List<Peca_reparacaoDTO> listapecas { get; set; }
         public ReparacaoComPecas()
         {
            listapecas = new List<Peca_reparacaoDTO>();
         }
      }


   }



}
