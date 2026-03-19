using Microsoft.AspNetCore.Mvc;
using TiendaVirtualGuacas.Models;

namespace TiendaVirtualGuacas.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var categorias = new List<Categoria>
            {
                new Categoria {Nombre = "Tecnología", Descripcion = "Productos tecnológicos"},
                new Categoria {Nombre = "Ropa", Descripcion = "Prendas de vestir"},
                new Categoria {Nombre = "", Descripcion = "Sin nombre definido"}
            };
            //Holaaa

            //Uno
            return View(categorias);
        }
    }
}
