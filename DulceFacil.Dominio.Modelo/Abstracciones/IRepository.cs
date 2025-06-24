using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelo.Abstracciones
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T TEntity); //insertar
        Task UpdateAsync(T Entity); //actualizar
        Task DeleteAsync(int id); //eliminar por id
        Task<IEnumerable<T>> GetAllAsync(); //listar todo
        Task<T> GetById(int id); //buscar por id
    }
}
