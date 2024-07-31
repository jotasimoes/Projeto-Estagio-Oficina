using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.Native;
using System.Windows;
using OficinaV2.Models;
using System.Runtime.Remoting.Channels;
using System.Net.Http.Json;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace OficinaV2 { 
public class WebApi
   {
      private readonly HttpClient _httpClient;

      public WebApi()
      {
         _httpClient = new HttpClient();
         _httpClient.BaseAddress = new Uri("https://localhost:7055/");         
         _httpClient.DefaultRequestHeaders.Accept.Clear();
         _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      }

//////////////////////////////////////////////////---PECAS----//////////////////////////////////////////////////////////////////////////////////////////////

      public async Task<List<Peca>> GetPecasAsync()
      {
         HttpResponseMessage response = await _httpClient.GetAsync("api/pecas");
         response.EnsureSuccessStatusCode();

         var responseContent = await response.Content.ReadAsStringAsync();
         var lista = JsonConvert.DeserializeObject<List<Peca>>(responseContent);

         return lista;
      }

      public async Task UpdatePeca(Peca peca)
      {        
         HttpResponseMessage response = await _httpClient.PutAsJsonAsync("api/pecas/" + peca.Id_peca, peca);
         response.EnsureSuccessStatusCode();
      }

      public async Task RemoverPeca(Peca peca)
      {
         HttpResponseMessage response = await _httpClient.DeleteAsync($"api/pecas/{peca.Id_peca}");
         response.EnsureSuccessStatusCode();
      }
      /////////////////////////////////////////---MOVIMENTOS---//////////////////////////////////////////////////////////////////////
      public async Task<List<Movimento>> GetMovimentosAsync()
      {
         HttpResponseMessage response = await _httpClient.GetAsync($"api/movimentos");
         response.EnsureSuccessStatusCode();

         var responseContent = await response.Content.ReadAsStringAsync();
         var lista = JsonConvert.DeserializeObject<List<Movimento>>(responseContent);

         return lista;
      }

      public async Task<List<Movimento>> GetMovimentosPorPecaAsync(int id_peca)
      {
         HttpResponseMessage response = await _httpClient.GetAsync($"api/movimentos/pecas/{id_peca}");
         response.EnsureSuccessStatusCode();

         var responseContent = await response.Content.ReadAsStringAsync();
         var lista = JsonConvert.DeserializeObject<List<Movimento>>(responseContent);

         return lista;
      }

      public async Task RemoverMovimento(int id_peca ,int id_movimento)
      {
         HttpResponseMessage response = await _httpClient.DeleteAsync($"api/movimentos/{id_movimento}/pecas/{id_peca}");
         response.EnsureSuccessStatusCode();
      }

      public async Task AdicionarMovimento(int id_peca, Movimento movimento)
      {
         var json = JsonConvert.SerializeObject(movimento);
         var content = new StringContent(json, Encoding.UTF8, "application/json");

         HttpResponseMessage response = await _httpClient.PostAsync($"api/movimentos/pecas/{id_peca}/movimentos", content);
         response.EnsureSuccessStatusCode();
      }

      public async Task AtualizarMovimento(Movimento movimento)
      {
         HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/movimentos/" + movimento.Id_movimento, movimento);
         response.EnsureSuccessStatusCode();
      }

      public async Task<int> GetLastMovimento()
      {
         var response = await _httpClient.GetAsync($"api/movimentos?orderby=Id_movimento desc");
         response.EnsureSuccessStatusCode();

         var content = await response.Content.ReadAsStringAsync();
         var movimentos = JsonConvert.DeserializeObject<List<Movimento>>(content);

         return movimentos.Last().Id_movimento;
      }

      /////////////////////////////////////////---REPARAÇÕES---//////////////////////////////////////////////////////////////////////

      public async Task<List<Reparacao>> GetReparacoesAsync()
      {
         HttpResponseMessage response = await _httpClient.GetAsync("api/reparacoes");
         response.EnsureSuccessStatusCode();

         var responseContent = await response.Content.ReadAsStringAsync();
         var lista = JsonConvert.DeserializeObject<List<Reparacao>>(responseContent);

         return lista;
      }

     

      public async Task<int> GetLastReparacao()
      {
         var response = await _httpClient.GetAsync($"api/reparacoes?orderby=Id_reparacao desc");
         response.EnsureSuccessStatusCode();

         var content = await response.Content.ReadAsStringAsync();
         var reparacoes = JsonConvert.DeserializeObject<List<Reparacao>>(content);

         return reparacoes.Last().Id_reparacao;
      }

      public async Task AdicionarReparacao(Reparacao reparacao)
      {
         var json = JsonConvert.SerializeObject(reparacao);
         var content = new StringContent(json, Encoding.UTF8, "application/json");

         HttpResponseMessage response = await _httpClient.PostAsync($"api/reparacoes/", content);
         response.EnsureSuccessStatusCode();
      }

      public async Task AtualizarReparacao(Reparacao reparacao)
      {
         HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/reparacoes/" + reparacao.Id_reparacao, reparacao);
         response.EnsureSuccessStatusCode();
      }

      ///////////////////////////////--PECAS_REPARACOES--//////////////////////////////////////////////////////////////////////////////////
      
      public async Task AdicionarPeca_reparacao(Peca_reparacao pecaUtilizada )
      {
         HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/pecas_reparacoes", pecaUtilizada);         
         response.EnsureSuccessStatusCode();
      }

      public async Task<List<Peca_reparacao>> GetPecas_reparacoes()
      {
         HttpResponseMessage response = await _httpClient.GetAsync($"api/pecas_reparacoes");
         response.EnsureSuccessStatusCode();

         var responseContent = await response.Content.ReadAsStringAsync();
         var lista = JsonConvert.DeserializeObject<List<Peca_reparacao>>(responseContent);

         return lista;
      }

      public async Task<List<Peca_reparacaoDTO>> GetPecasReparacoesDTOPorReparacao(int id_reparacao)
      {
         HttpResponseMessage response = await _httpClient.GetAsync($"api/pecas_reparacoesdto/reparacoes/{id_reparacao}");
         response.EnsureSuccessStatusCode();

         var responseContent = await response.Content.ReadAsStringAsync();
         var lista = JsonConvert.DeserializeObject<List<Peca_reparacaoDTO>>(responseContent);

         return lista;
      }
   }
}
