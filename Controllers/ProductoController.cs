using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistemadeventa.Models;
using SistemaDeVenta.Models;

namespace SistemaDeVenta.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductoController(ApplicationDbContext db)
        {
            _db = db;
        }


        //Agregar producto

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _db.Add(producto);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Producto));
            }
            return View(producto);
        }
        public IActionResult Producto()
        {
            ViewBag.ListaProducto = _db.Productos.ToList();

            return View();
        }

        //Delete 
        public async Task<IActionResult> DeleteProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _db.Productos.SingleOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpPost, ActionName("DeleteProducto")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> RemoveProducto(int id)
        {
            var producto = await _db.Productos.SingleOrDefaultAsync(m => m.id == id);
            _db.Productos.Remove(producto);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Producto));
        }


        //Detalles

            public async Task<IActionResult> Detalle(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var producto = await _db.Productos.SingleOrDefaultAsync(m => m.id == id);
            if(producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }
        
        //Editar
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _db.Productos.SingleOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Producto producto)
        {
           if(id != producto.id)
            {
                return NotFound();
            }
           if(ModelState.IsValid)
            {
                _db.Update(producto);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Producto));
            }
            return View(producto);

            
        }

      



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }
    }
    }



