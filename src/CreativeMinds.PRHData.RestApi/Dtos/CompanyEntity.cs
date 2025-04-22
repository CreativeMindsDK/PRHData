using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.PRHData.RestApi.Dtos {

	public class CompanyEntity {
		[JsonPropertyName("businessId")]
		public String Id { get; set; }
		[JsonPropertyName("name")]
		public String Name { get; set; }
		[JsonPropertyName("registrationDate")]
		public String RegistrationDate { get; set; }
		[JsonPropertyName("companyForm")]
		public String Form { get; set; }
	}

	/*
	 
	 
	  "businessId": "2779836-6",
      "name": "Food Folk Suomi Oy",
      "registrationDate": "2016-09-01",
      "companyForm": "OY",
      "detailsUri": null,
      "liquidations": [],
      "names": [
        {
          "order": 0,
          "version": 1,
          "name": "Food Folk Suomi Oy",
          "registrationDate": "2017-12-22",
          "endDate": null,
          "source": 1
        },
	 */
}
