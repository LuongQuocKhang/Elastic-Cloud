using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VSS.Models;
using VSS.Repositories;

namespace VSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ISearchRepository _searchRepository;

        public CandidateController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository ?? throw new ArgumentNullException(nameof(searchRepository));
        }

        [HttpGet(Name = "Search")]
        public async Task<IReadOnlyCollection<Candidate>> Search(string query)
        {
            return await _searchRepository.SearchCandidate(query).ConfigureAwait(false);
        }
    }
}
