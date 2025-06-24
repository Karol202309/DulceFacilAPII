using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class PuntoVentaRepositoryImpl : RepositoryImpl<PuntoVenta>, IPuntoVentaRepository
    {
        public PuntoVentaRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<PuntoVenta> buscarPuntoVenta(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
