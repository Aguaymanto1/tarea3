using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tarea3.Models;

namespace tarea3.Controllers;

public class ProductoController : Controller
{
    private static List<ProductoMascota> productos = new()
    {
        new ProductoMascota { Nombre = "Collar para perro", Categoria = "Accesorios", Precio = 25.50m, Descripcion = "Collar ajustable para perros medianos." },
        new ProductoMascota { Nombre = "Comida para gato", Categoria = "Alimento", Precio = 15.00m, Descripcion = "Bolsa de 2kg de comida seca para gatos adultos." },
        new ProductoMascota { Nombre = "Cama para mascota", Categoria = "Accesorios", Precio = 60.00m, Descripcion = "Cama suave y lavable para mascotas pequeñas." },
        new ProductoMascota { Nombre = "Pelota de goma", Categoria = "Juguetes", Precio = 10.00m, Descripcion = "Pelota resistente para perros activos." }
    };
    public ActionResult Index()
    { 
        return View(productos);
    }
}