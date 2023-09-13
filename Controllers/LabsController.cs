using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using atendimentoAlunos.Models;

namespace atendimentoAlunos.Controllers
{
    public class LabsController : Controller
    {
        private readonly Contexto _context;

        public LabsController(Contexto context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index() {
                return View(await _context.Salas.ToListAsync());
            
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
