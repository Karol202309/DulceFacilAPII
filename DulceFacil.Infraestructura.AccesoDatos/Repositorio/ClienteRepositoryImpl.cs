﻿using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ClienteRepositoryImpl : RepositoryImpl<Cliente>, IClienteRepository
    {
        public ClienteRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Cliente> buscarCLiente(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
