using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using APIGSB.Controllers;
using APIGSB.Models;
using Newtonsoft.Json;
using Xunit;

namespace APIGSB.Tests.Controller
{
	/// <summary>
	/// Classe de test pour le controller <see cref="ExcipientController"/>
	/// </summary>
	public class ExcipientController_Test
	{
		/// <summary>
		/// Obtient la réponse d'une requête à l'API de GSBMobile
		/// </summary>
		/// <returns>The response from http request.</returns>
		public string GetResponseFromHttpRequest(string request)
		{
			HttpClient Client_Test = new HttpClient();
			var result = Client_Test.GetAsync($"http://localhost:8100/api/{request}").Result;

			return result.Content.ReadAsStringAsync().Result;
		}


		[Fact(DisplayName = "GetAll()")]
		public void ExcipientControllerGetAll_ShouldReturnAllExcipient()
		{
			// HTTP Resquest: http://localhost:8100/api/excipient
			List<Excipient> convert = JsonConvert.DeserializeObject<List<Excipient>>(GetResponseFromHttpRequest("excipient"));

			// Teste si la requête HTTP au webservice renvoie bien 2 excipients, ce qui est actuellement le cas dans la base de données
			Assert.Equal(convert.Count, 2);
		}

		[Fact(DisplayName = "DeleteFromMedicament()")]
		public void ExcipientControllerGetAll_ShouldDeleteExcipientFromAMedicament()
		{
			// HTTP Resquest: http://localhost:8100/api/excipient
			List<Excipient> convert = JsonConvert.DeserializeObject<List<Excipient>>(GetResponseFromHttpRequest("excipient"));
			
			HttpClient Client_Test = new HttpClient();

			var result = Client_Test.PostAsync("http://localhost:8100/api/excipient" , new StringContent(JsonConvert.SerializeObject(convert[0]), Encoding.UTF8, "application/json"));
		}
	}
}
