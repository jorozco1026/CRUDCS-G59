using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoG59.App.Dominio.Entidades;

namespace ProyectoG59.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFormador
    {       
        Formador AddFormador(Formador formador);
        IEnumerable<Formador> GetAllFormadores();
        Formador GetFormador(int idFormador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador);
    }
}
