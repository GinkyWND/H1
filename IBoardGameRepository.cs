using BoardGameStore.Models;

namespace BoardGameStore.Repositories
{
    public interface IBoardGameRepository
    {
        IEnumerable<BoardGame> GetAllGames();
    }
}
