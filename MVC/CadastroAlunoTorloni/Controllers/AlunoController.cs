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
    public class AlunoController : Controller
    {

        public static List<Aluno> Alunos = new List<Aluno>
        {
          new Aluno { Id = 1, Nome = "Matheus", Idade = 16},  
          new Aluno { Id = 2, Nome = "Eduardo", Idade = 17},  
        };

        private readonly CadastroAlunoTorloniContext _context;

        private readonly ILogger<AlunoController> _logger;

        
        public AlunoController(ILogger<AlunoController> logger, CadastroAlunoTorloniContext context)
        {
            _logger = logger;
            _context = context;
        }

        // private static List<Aluno> alunos = new List<Aluno>
        // {
        //     new Aluno{ Id = 1, Nome = "Matheus", Idade = 16, Cpf = "00011169231"},
        //     new Aluno{ Id = 2, Nome = "Eduardo", Idade = 16, Cpf = "000333378291"},
        //     new Aluno{ Id = 3, Nome = "Júlia", Idade = 17, Cpf = "000112937639"},
        //     new Aluno{ Id = 4, Nome = "Maria", Idade = 17, Cpf = "0001129485633"},
        //     new Aluno{ Id = 5, Nome = "Stephani", Idade = 16, Cpf = "00011223587"},
        // };

        // public IActionResult Index()
        // {
        //     return View(alunos);
        // }
        public async Task<IActionResult> Index()
        {
            var alunos = await _context.Alunos.ToListAsync();
            return View(alunos);
        }
        
        // public AlunoController(ILogger<AlunoController> logger)
        // {
        //     return View(alunos);
        // }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Aluno aluno)
        {
        //     // salvar no array
        // //     // redirecionar o usuário para Index
            // aluno.Id = alunos.Max(f => f.Id) + 1;
             _context.Add(aluno);
             await _context.SaveChangesAsync();// salva no Banco De Dados
        //     // redirecionar o usuário para a Index
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}