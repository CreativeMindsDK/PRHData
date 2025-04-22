using CreativeMinds.PRHData.RestApi.Dtos;

namespace CreativeMinds.PRHData.RestApi {

	public interface IPRHSearchEngine {
		Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
	}
}
