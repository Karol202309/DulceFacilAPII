using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class DetallePedidoRepositoryImpl : RepositoryImpl<DetallePedido>, IDetallePedidoRepository
    {
        public DetallePedidoRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<DetallePedido> buscarDetallePedido(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
