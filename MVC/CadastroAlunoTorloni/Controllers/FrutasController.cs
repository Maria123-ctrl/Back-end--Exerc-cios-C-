using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CadastroAlunoTorloni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CadastroAlunoTorloni.Controllers
{
    
    public class FrutasController : Controller
    {
        public readonly ILogger<FrutasController> _logger;
        
        private readonly CadastroAlunoTorloniContext _context;

        public FrutasController(ILogger<FrutasController> logger, CadastroAlunoTorloniContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Criar uma lista de Frutas
        // private static List<Fruta> frutas = new List<Fruta>
        // {
        //     new Fruta{ Id = 1, Nome = "Maça", Cor = "Vermelha", Categoria = "Tropical"},
        //     new Fruta{ Id = 2, Nome = "Banana", Cor = "Amarela", Categoria = "Tropical"},
        //     new Fruta{ Id = 3, Nome = "Uva", Cor = "Roxa", Categoria = "Tropical"},
        //     new Fruta{ Id = 4, Nome = "Limão", Cor = "Verde", Categoria = "Cítrica"},
        //     new Fruta{ Id = 5, Nome = "Abacaxi", Cor = "Amarela", Categoria = "Cítrica"},
        // };

        public async Task<IActionResult> Index()
        {
            var frutas = await _context.Fruta.ToListAsync();
            return View(frutas);
        }
        public IActionResult Create()
        {
            return View();
        }
        // Método para salvar uma fruta, sem uma View
        [HttpPost]
        // public IActionResult Create(Fruta fruta)
        // {
        //     // salvar no array
        //     // redirecionar o usuário para Index
        //     fruta.Id = frutas.Max(f => f.Id) + 1;
        //     frutas.Add(fruta);
        //     // redirecionar o usuário para a Index
        //     return RedirectToAction("Index");
        // }
        public IActionResult FrutasCítricas()
        {
            return View();
        }

        public IActionResult FrutasTropícais()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}