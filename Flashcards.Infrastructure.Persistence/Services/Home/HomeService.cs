using Flashcards.Core.Domain;
using Flashcards.Infrastructure.Persistence.Repositories.Home;

namespace Flashcards.Infrastructure.Persistence.Services.Home
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;
        public HomeService(IHomeRepository homeRepository) 
        {
            _homeRepository = homeRepository;
        }
        public HomeModel GetHome()
        {
            return new HomeModel($"Service {_homeRepository.GetHome()}".ToString());
        }
    }
}
