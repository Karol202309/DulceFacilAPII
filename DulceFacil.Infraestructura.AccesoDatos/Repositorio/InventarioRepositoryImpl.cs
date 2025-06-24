using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class InventarioRepositoryImpl : RepositoryImpl<Inventario>, IInventarioRepository
    {
        public InventarioRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Inventario> buscarInventario(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
