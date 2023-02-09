using Flashcards.Core.Domain;
using Flashcards.Infrastructure.Persistence.Services.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flashcards.WebApi.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetHome()
        {
            return Ok(await Task.FromResult(new HomeModel($"Controller <- {_homeService.GetHome()}")));
        }
    }
}
