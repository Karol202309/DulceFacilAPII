using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelo.Abstracciones
{
    public interface IDetallePedidoRepository : IRepository<DetallePedido>
    {
        IEnumerable<DetallePedido> buscarDetallePedido(String nombre);
    }
}
