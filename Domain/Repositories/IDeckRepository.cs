using Flashcards.Domain.Entities;

namespace Flashcards.Domain.Repositories;

public interface IDeckRepository
{
    Task<IEnumerable<DeckEntity>> GetDecks();
}