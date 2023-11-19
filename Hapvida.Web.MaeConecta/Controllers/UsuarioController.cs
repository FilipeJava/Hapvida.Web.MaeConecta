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

        // Incluir  Procedimentos
        [HttpPost]
        public IActionResult Incluir(Procedimentos procedimentos) 

        {
            _context.Procedimentos.Add(procedimentos);
            _context.SaveChanges();
            TempData["msg"] = "Procedimento Cadastrado";
            return RedirectToAction("Procedimentos", new { id = procedimentos.UsuarioId });
        }

        [HttpGet]
        public IActionResult Procedimentos(int id)
        {
            ViewBag.procedimentos = _context.Procedimentos
                .Where(p => p.UsuarioId==id).ToList();

            ViewBag.usuario = _context.Usuarios.Find(id);


            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var procedimento = _context.Procedimentos.Find(id);
            _context.Procedimentos.Remove(procedimento);
            _context.SaveChanges();
           return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult Alterar(Procedimentos procedimentos)
        {
            _context.Procedimentos.Update(procedimentos);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            // Lógica para obter o procedimento e o usuário associado
            var procedimento = _context.Procedimentos
                .Include(p => p.Usuario)
                .FirstOrDefault(p => p.ProcedimentosId == id);

            // Verifica se o procedimento foi encontrado
            if (procedimento == null)
            {
                return NotFound();
            }

            // Define o usuário na ViewBag
            ViewBag.Usuario = procedimento.Usuario;

            return View(procedimento);
        }


    }
}
