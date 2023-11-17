using Hapvida.Web.MaeConecta.Models;
using Hapvida.Web.MaeConecta.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hapvida.Web.MaeConecta.Controllers
{
    public class UsuarioController : Controller
    {
        private MaeContext _context;

        public UsuarioController(MaeContext context)
        {
            _context = context;
        }


        // Usuario

        public ActionResult Index(String filtro = "")
        {
            var lista = _context.Usuarios
                .Where(u => u.Nome.Contains(filtro) || string.IsNullOrEmpty(filtro))
                .Include(u => u.Endereco)
                .ToList();
            return View(lista);
        }

        // Cadastro de Usuario - Mae 

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario) 
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            TempData["msg"] = "Usuario Cadastrado";

            return RedirectToAction("cadastrar");
        }

        // Editar Usuario

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            TempData["msg"] = "Usuario atualizado";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var usuario = _context.Usuarios
                .Include(p => p.Endereco).First(p => p.UsuarioId == id);
            return View(usuario);
        }


        //Excluir Usuario
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            TempData["msg"] = "Usuario removido!";
            return RedirectToAction("Index");
        }


    }
}
