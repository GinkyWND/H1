using BoardGameStore.Models;

namespace BoardGameStore.Repositories
{
    public class MockBoardGameRepository : IBoardGameRepository
    {
        public IEnumerable<BoardGame> GetAllGames()
        {
            return new List<BoardGame>
            {
                new BoardGame { Id = 1, Name = "Catan", Price = 3500, Description = "Стратегия о колонизации острова.", ImageUrl = "https://placeholder.com/150" },
                new BoardGame { Id = 2, Name = "Carcassonne", Price = 2400, Description = "Классика о строительстве средневековых замков.", ImageUrl = "https://placeholder.com/150" },
                new BoardGame { Id = 3, Name = "Dune: Imperium", Price = 5800, Description = "Борьба за ресурсы на пустынной планете.", ImageUrl = "https://placeholder.com/150" },
                new BoardGame { Id = 4, Name = "Ticket to Ride", Price = 3900, Description = "Увлекательное железнодорожное приключение.", ImageUrl = "https://placeholder.com/150" }
            };
        }
    }
}
