using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class EntregaRepositoryImpl : RepositoryImpl<Entrega>, IEntregaRepository
    {
        public EntregaRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Entrega> buscarEntrega(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
