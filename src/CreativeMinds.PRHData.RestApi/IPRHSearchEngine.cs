using CreativeMinds.PRHData.RestApi.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.PRHData.RestApi {

	public interface IPRHSearchEngine {
		Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
	}
}
