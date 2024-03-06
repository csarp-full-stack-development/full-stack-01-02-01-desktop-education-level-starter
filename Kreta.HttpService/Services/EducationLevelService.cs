using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Services
{
    public class EducationLevelService : BaseService<EducationLevel, EducationLevelDto>, IEducationLevelService
    {
        public EducationLevelService(IHttpClientFactory? httpClientFactory, EducationLevelAssambler assambler, StudentAssambler studentAssambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
