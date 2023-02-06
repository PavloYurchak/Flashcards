using Flashcards.Core.Domain;

namespace Flashcards.Infrastructure.Persistence.Repositories.Home
{
    public class HomeRepository : IHomeRepository
    {
        public HomeModel GetHome()
        {
            return new HomeModel("<- Repository <- Home ");
        }
    }
}
