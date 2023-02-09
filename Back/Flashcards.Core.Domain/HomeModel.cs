namespace Flashcards.Core.Domain
{
    public class HomeModel
    {
        public HomeModel(string home)
        {
            Home= home;
        }
        public string? Home { get; set; }

        public override string ToString()
        {
            return Home!;
        }
    }
}
