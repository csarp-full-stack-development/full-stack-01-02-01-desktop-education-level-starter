using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectController : BaseController<Subject, SubjectDto>
    {
        public SubjectController(SubjectAssambler assembler, ISubjectRepo repo) : base(assembler, repo)
        {
        }
    }
}
