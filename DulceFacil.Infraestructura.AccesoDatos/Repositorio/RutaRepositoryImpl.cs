using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RutaRepositoryImpl : RepositoryImpl<Ruta>, IRutaRepository
    {
        public RutaRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Ruta> buscarRuta(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
