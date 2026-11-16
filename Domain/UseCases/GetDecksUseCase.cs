using Flashcards.Domain.Entities;
using Flashcards.Domain.Repositories;

namespace Flashcards.Domain.UseCases;

public class GetDecksUseCase(
    IDeckRepository deckRepository
)
{
    public async Task<IEnumerable<DeckEntity>> GetDecks() =>
        await deckRepository.GetDecks();
}