using Elasticsearch.Net;
using Nest;
using VSS.Models;

namespace VSS.Repositories;

public class SearchRepository : ISearchRepository
{
    public Task<int> CreateCandidate(Candidate query)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCandidate(string query)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyCollection<Candidate>> SearchCandidate(string query)
    {
        ElasticClient client = ElasticClientFactory.Create();

        var response = await client.SearchAsync<Candidate>(s => s
            .Index(Index.SearchCandidates)
            .From(0)
            .Size(10)
            .Query(q => q
                .Match(m => m
                    .Field(f => f.NameLastFirst)
                    .Query(query)
                )
            ))
            .ConfigureAwait(false);

        if (response.IsValid)
        {
            var candidates = response.Documents;

            return candidates;
        }

        return new List<Candidate>();
    }

    public Task<bool> UpdateCandidate(Candidate query)
    {
        throw new NotImplementedException();
    }
}
