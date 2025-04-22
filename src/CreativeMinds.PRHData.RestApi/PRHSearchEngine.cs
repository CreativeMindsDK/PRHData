using CreativeMinds.PRHData.RestApi.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Web;

namespace CreativeMinds.PRHData.RestApi {

	public class PRHSearchEngine : IPRHSearchEngine {
		private readonly IHttpClientFactory httpClientFactory;

		public PRHSearchEngine(IHttpClientFactory httpClientFactory) {
			this.httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
		}

		public async Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			HttpClient client = this.httpClientFactory.CreateClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri("https://avoindata.prh.fi");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			//ttps://avoindata.prh.fi/bis/v1?totalResults=false&maxResults=10&resultsFrom=0&name=Food%20Folk%20Suomi%20Oy&companyRegistrationFrom=2014-02-28

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"/bis/v1?totalResults=false&maxResults=10&resultsFrom=0name={HttpUtility.UrlEncode(query)}&companyRegistrationFrom=2014-02-28");
				//request.Headers.Add("apikey", this.apiKey);
				//request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
				//request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String data = await response.Content.ReadAsStringAsync();

				response.EnsureSuccessStatusCode();

				return await response.Content.ReadFromJsonAsync<SearchResponse>();
			}
			catch (Exception ex) {
				throw ex;
			}
		}
	}
}
