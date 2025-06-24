using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RepartidorRepositoryImpl : RepositoryImpl<Repartidor>, IRepartidorRepository
    {
        public RepartidorRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Repartidor> buscarRepartidor(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
