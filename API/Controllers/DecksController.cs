using Flashcards.API.DTOs;
using Flashcards.Domain.UseCases;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Flashcards.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DecksController(
    GetDecksUseCase getDecksUseCase
) : ControllerBase
{
    [HttpGet]
    public async Task<Ok<IEnumerable<DeckDto>>> GetDecks()
    {
        var deckEntities = await getDecksUseCase.GetDecks();
        var deckDtos = deckEntities.Select(deck => new DeckDto()
        {
            Id = deck.Id,
            Title = deck.Title,
        });
        return TypedResults.Ok(deckDtos);
    }
}