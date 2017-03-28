using System;
using System.Collections.Generic;
using System.Net.Http;
using APIGSB.Controllers;
using APIGSB.Models;
using Newtonsoft.Json;
using Xunit;

namespace APIGSB.Tests
{
	/// <summary>
	/// Classe de test pour le controller <see cref="ExcipientController"/>
	/// </summary>
	public class ExcipientController_Test
	{
		public HttpClient Client_Test { get; set; }

		public ExcipientController_Test()
		{
			Client_Test = new HttpClient() { BaseAddress = new Uri("http://localhost:8100/api/") };
		}

		[Fact(DisplayName = "Retour des excipients")]
		public void ExcipientControllerGetAll_ShouldReturnAllExcipient()
		{
			string result = Client_Test.GetAsync("excipient").Result.ToString();
			List<Excipient> excipients = JsonConvert.DeserializeObject<List<Excipient>>(result);

			// Test si la réponse est null ou non
			Assert.NotNull(excipients);

			// Test si la requête HTTP au webservice renvoie bien 2 excipient, ce qui est actuellement le cas dans la base de données
			Assert.Equal(2, excipients.Count);
		}
	}
}
