using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class PedidoRepositoryImpl : RepositoryImpl<Pedido>, IPedidoRepository
    {
        public PedidoRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Pedido> buscarPedido(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
