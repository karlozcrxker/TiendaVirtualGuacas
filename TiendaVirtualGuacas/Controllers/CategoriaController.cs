using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TiendaVirtualGuacas.Data;
using TiendaVirtualGuacas.Models;

namespace TiendaVirtualGuacas.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly TiendaContext _context;

        public CategoriaController(TiendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Usuario") == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var categorias = _context.Categorias.ToList();

            return View(categorias);
        }

        //Guardar producto

        public IActionResult Create()
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Formulario editar
        public IActionResult Edit(int id)
        {
            var categoria = _context.Categorias.Find(id);

            return View(categoria);
        }

        public IActionResult Edit(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Eliminar producto
        public IActionResult Delete(int id)
        {
            var categoria = _context.Categorias.Find(id);

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
