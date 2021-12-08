using Microsoft.AspNetCore.Mvc;

[Route("pokemon")]
[ApiController]
public class PokemonController: ControllerBase
{

  [HttpGet]
  public ActionResult GimmePokemon()
  {
    Pokemon poke = new Pokemon();
    poke.Name = "Snorlax";
    poke.Hp = 2000;
    poke.Type = "very sleepy";

    return Ok(poke);
  }

}