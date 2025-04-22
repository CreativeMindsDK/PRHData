using System.Text.Json.Serialization;

namespace CreativeMinds.PRHData.RestApi.Dtos {

	public class SearchResponse {
		[JsonPropertyName("results")] 
		public CompanyEntity[] Results { get; set; }
	}

	/*
	   "type": "fi.prh.opendata.bis",
  "version": "1",
  "totalResults": -1,
  "resultsFrom": 0,
  "previousResultsUri": null,
  "nextResultsUri": null,
  "exceptionNoticeUri": null,
  "results":
	 
	 */
}
