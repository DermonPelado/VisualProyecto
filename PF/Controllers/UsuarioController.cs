using PF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PF.Controllers
{
    public class UsuarioController : System.Web.Http.ApiController
    {
        List<Usuarios> listaUsuarios = new List<Usuarios>();

        //Como no tenemos BBDD, declaramos en el constructor las Usuarioss que estarían en //nuestra BBDD

        public UsuarioController()

        {

            Usuarios p = new Usuarios { IdUsuarios = 1, Nombre = "Lucia", Email = "lucia@gmail.com", Edad = 19 };

            this.listaUsuarios.Add(p);

            p = new Usuarios { IdUsuarios = 2, Nombre = "Adrian", Email = "adrian@gmail.com", Edad = 24 };

            this.listaUsuarios.Add(p);

            p = new Usuarios { IdUsuarios = 3, Nombre = "Alejandro", Email = "alejandro@gmail.com", Edad = 21 };

            this.listaUsuarios.Add(p);

            p = new Usuarios { IdUsuarios = 4, Nombre = "Sara", Email = "sara@gmail.com", Edad = 17 };

            this.listaUsuarios.Add(p);

        }

        // GET api/<controller>

        public List<Usuarios> GetUsuarioss()

        {

            return this.listaUsuarios;

        }

        // GET api/<controller>/9

        public Usuarios GetUsuarios(int id)

        {



            Usuarios p = this.listaUsuarios.Find(z => z.IdUsuarios == id);

            return p;

        }

    }

}
