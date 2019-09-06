using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BDDModels;
using Newtonsoft.Json;

namespace PF.Controllers
{
    public class ApisController : ApiController
    {
        [Route("api/Productos")]
        public IEnumerable<sp_DevolverProductos_Result> Get()
        {
            using (BDDEntities producto = new BDDEntities())
            {
                return producto.sp_DevolverProductos().ToList();
            }
        }


        [Route("api/Comentarios/GetByID/{id}")]
        public IEnumerable<sp_ComentariosPorID_Result> GetByIDComentarios(int id)
        {
            using (BDDEntities producto = new BDDEntities())
            {
                return producto.sp_ComentariosPorID(id).ToList();
            }
        }

        [Route("api/Materias")]
        public IEnumerable<sp_DevolverMaterias_Result> GetMaterias()
        {
            using (BDDEntities materias = new BDDEntities())
            {
                return materias.sp_DevolverMaterias().ToList();
            }
        }

        [HttpPost]
        [Route("api/IngresarProducto")]
        public int InsertarProducto (Producto p)
        {
            using (BDDEntities producto = new BDDEntities())
            {
                return producto.sp_IngresarProducto(p.IDVendedor, p.Titulo, p.Descripcion, p.IDAnio, p.IDMateria, p.Fecha, p.Foto, p.Precio);
            }
        }

        [HttpPost]
        [Route("api/ModificarProducto")]
        public int ModificarProducto(Producto p)
        {
            using (BDDEntities producto = new BDDEntities())
            {
                return producto.sp_ModificarProducto(p.IDProducto, p.Titulo, p.Descripcion, p.IDAnio, p.IDMateria, p.Foto, p.Precio);
            }
        }

        [Route("api/Producto/GetByID/{id}")]
        public IEnumerable<sp_TraerTodoProductos_Result> GetByID(int id)
        {
            using (BDDEntities producto = new BDDEntities())
            {
                return producto.sp_TraerTodoProductos(id).ToList();
            }
        }

        
        /*[Route("api/Producto/Insertar")]
        public int Insertar(Producto p)
        //public int Insertar(Producto p)
        {
            //var jsonString = p.ToString();
            //Producto result = JsonConvert.DeserializeObject<Producto>(jsonString);

            return 1;
        }*/

        /*
        public IEnumerable<sp_DevolverProducto_Result> GetProducto()
        {
            using (BDDEntitie producto = new BDDEntitie())
            {
                return producto.sp_DevolverProducto(1);
            }
        }*/

        /*public Producto Get(int id)
        {
            using (BDDEntities entities = new BDDEntities())
            {
                return entities.Producto.FirstOrDefault(e => e.IDProducto == id);
            }
        }*/


        /*public HttpResponseMessage PostProducto([FromBody] sp_DevolverProducto_Result Producto)
        {
            using (var context = new BDDEntities())
            {
                var response = context.sp_DevolverProductos();

                var message = Request.CreateResponse(HttpStatusCode.Created, Producto);
                message.Headers.Location = new Uri(Request.RequestUri + response.ToString());
                return message;
            }

        }*/

    }
}