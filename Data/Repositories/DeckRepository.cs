using Flashcards.Domain.Entities;
using Flashcards.Domain.Repositories;

namespace Flashcards.Data.Repositories;

public class DeckRepository : IDeckRepository
{
    public Task<IEnumerable<DeckEntity>> GetDecks()
    {
        return Task.FromResult<IEnumerable<DeckEntity>>(new List<DeckEntity>
        {
            new()
            {
                Id = 1,
                Title = "Greetings"
            },
            new()
            {
                Id = 2,
                Title = "Welcome"
            }
        });
    }
}