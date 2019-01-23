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
    public class EmpleadoController : Controller
    {

        private readonly ApplicationDbContext _db;
        public EmpleadoController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Agregar Empleados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarEmpleados(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _db.Add(empleado);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Empleado));
            }
            return View(empleado);
        }
        public IActionResult Empleado()
        {
            ViewBag.EmployeesList = _db.Empleados.ToList();

            return View();
        }

      


        //Delete

        public async Task<IActionResult> DeleteEmpleado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var empleado = await _db.Empleados.SingleOrDefaultAsync(m => m.id == id);
            if (empleado== null)
            {
                return NotFound();
            }
            return View(empleado);
        }

        [HttpPost, ActionName("DeleteEmpleado")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> RemoveEmpleado(int id)
        {
            var empleado = await _db.Empleados.SingleOrDefaultAsync(m => m.id == id);
            _db.Empleados.Remove(empleado);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Empleado));
        }


        //Edit 

        
        public async Task<IActionResult> EditEmpleado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var empleado = await _db.Empleados.SingleOrDefaultAsync(m => m.id == id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }
       public IActionResult Edit()
        {
            return View();
        }
       
        //Post:
        [HttpPost ]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEmpleado(int id, Empleado empleado)
        {
            if (id != empleado.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(empleado);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Empleado));
            }
            return View (empleado);          
        }


        //Detalle


        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var empleado = await _db.Empleados.SingleOrDefaultAsync(m => m.id == id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
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
