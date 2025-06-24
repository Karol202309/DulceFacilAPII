using DulceFacil.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositoryImpl<T> : IRepository<T> where T : class
    {
        private readonly DulceFacilDBContext _dulceFacilDBContext;
        private readonly DbSet<T> _dbSet;

        //constructor
        public RepositoryImpl(DulceFacilDBContext contexto)
        {
            _dulceFacilDBContext = contexto;
            _dbSet = contexto.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _dulceFacilDBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genénerica: No se pudo insertar Datos" + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                _dbSet.Remove(entity);
                await _dulceFacilDBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo eliminar Datos" + ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo traer los Datos" + ex.Message);
            }
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo encontrar el dato" + ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _dulceFacilDBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo actualizar el dato" + ex.Message);
            }
        }
    }
}
