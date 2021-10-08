using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProyectoG59.App.Dominio.Entidades;
using ProyectoG59.App.Persistencia.AppRepositorios;

namespace ProyectoG59.App.Presentacion
{
    public class ListModel : PageModel
    {
       private readonly IRepositorioFormador repositorioFormadores;
       public IEnumerable<Formador> Formadores {get;set;}

       public ListModel(IRepositorioFormador repositorioFormadores)
       {
            this.repositorioFormadores = repositorioFormadores;
       }

        public void OnGet()
        {
            //Formadores = repositorioFormadores. GetAllFormadores();
            List<Formador> formadores;
            formadores= new List<Formador>()
            {
                new Formador{id=1, nombre="Jhon Jairo Orozco"},
                new Formador{id=2, nombre="Luz Dary Martinez"},
                new Formador{id=3, nombre="Mateo Orozco"}
            };  
        }
    }
}
