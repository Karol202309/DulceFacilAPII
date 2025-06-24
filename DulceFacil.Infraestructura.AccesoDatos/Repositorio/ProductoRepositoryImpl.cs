using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoRepositoryImpl : RepositoryImpl<Producto>, IProductoRepository
    {
        public ProductoRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Producto> buscarProducto(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
