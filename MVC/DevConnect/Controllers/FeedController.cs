using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Models;
using DevConnect.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Controllers
{
    public class FeedController : Controller
    {
        private readonly ILogger<FeedController> _logger;
        private readonly DevConnectContext _context;
        public FeedController(ILogger<FeedController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;


        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<TabelaPublicacao> publicacaos = await _context.TabelaPublicacao.Include(p => p.IdUsuarioNavigation).ToListAsync();
                return View(publicacaos);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            // List<TabelaPublicacao> publicados = await _context.TabelaPublicacao.ToListAsync();
            
        }
        [HttpPost]

        public async Task<IActionResult> Index(IFormCollection form)
        {
           TabelaPublicacao novoTabelaPublicacao = new TabelaPublicacao
            {
                Descricao = form["Descricao"].ToString(),
                DataPubli =  DateOnly.FromDateTime(DateTime.Now)
            };
            if(form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoTabelaPublicacao.ImagemUrl = file.FileName;
            }
            else
            {
                novoTabelaPublicacao.ImagemUrl = "";
                
            }

            try
            {
                _context.TabelaPublicacao.Add(novoTabelaPublicacao);
                await _context.SaveChangesAsync();
                
                ViewBag.postNovoPublicado = "Publicado";
                // TempData["postNovoPublicado"] = "";

                // return RedirectToAction("Index", "Feed");
                // return RedirectToAction(nameof(Index));
                return View();

            }
            catch (System.Exception)
            {
                ViewBag.postNovoPublicado = "Nao Publicado";
                // TempData["postNovoPublicado"] = "";
                //vamos pedir para a view falar ao usuário que não foi cadastrado
                // return RedirectToAction(nameof(Index));               
                return View();
            }
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}