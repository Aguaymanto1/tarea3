using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tarea3.Models;

namespace tarea3.Controllers;

public class MascotaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Enviar(Mascota mascota)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Mensaje = "Formulario enviado correctamente";
            return View("Index");
        }
        else
        { 
            return View("Index", mascota);
        }
    }
}