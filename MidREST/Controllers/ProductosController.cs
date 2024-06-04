using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
// NOMBRE APELLIDOS: Sebastián Alejandro Ojeda Tanai
// PARALELO: 
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 2024/06/03
// PRÁCTICA No. # 7

namespace MidREST.Controllers
{
    public class ProductosController : ApiController
    {
        MiddlewareProductos midProductos = new MiddlewareProductos();
        // GET: Productos
        public IHttpActionResult Get()
        {
            return Ok(midProductos.ListaProductosREST());
        }
        public IHttpActionResult Get(string nombre)
        {
            return Ok(midProductos.ListaProductosREST(nombre));
        }
    }
}