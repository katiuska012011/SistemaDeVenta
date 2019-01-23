using Microsoft.AspNetCore.Mvc;
using Sistemadeventa.Models;
using SistemaDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVenta.Controllers
{
    public class VentaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VentaController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult RegistrarVenta()
        {
            ViewBag.ListaProductos = _db.Productos.ToList();
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addVenta(Venta venta)
        {
            if (ModelState.IsValid)
            {
                _db.Add(venta);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(RegistrarVenta));
            }
            return View(); 
        }
        
    }
}
