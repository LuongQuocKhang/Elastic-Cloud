using VSS.Models;

namespace VSS.Repositories;

public interface ISearchRepository
{
    public Task<IReadOnlyCollection<Candidate>> SearchCandidate(string query);

    public Task<int> CreateCandidate(Candidate query);

    public Task<bool> DeleteCandidate(string query);

    public Task<bool> UpdateCandidate(Candidate query);
}
