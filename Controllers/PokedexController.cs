using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonHouse.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonHouse.Controllers
{
    public class PokedexController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Number(int id)
		{
			Pokedex poke = PokedexMgr.GetPokemon(id);

			if (poke == null)
			{
				ViewData["Num"] = id.ToString();
				return View("NotFound");

			}

			else

			{
				ViewData["Pokemon"] = poke;
				return View();
			}
		}
	}
}
