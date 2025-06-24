using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelo.Abstracciones
{
    public interface IEntregaRepository : IRepository<Entrega>
    {
        IEnumerable<Entrega> buscarEntrega(String nombre);
    }
}
