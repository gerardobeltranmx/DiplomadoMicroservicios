using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIClientes.Models;

namespace WebAPIClientes.Db
{
    public class Datos: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } // tabla Clientes la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Conexion = @"Server = dockersqlserver001.southcentralus.azurecontainer.io;
                                Database = ventasdb;
                                User = sa;
                                Password = 12AB34cd*;";


            optionsBuilder.UseSqlServer(Conexion);
        }
    }
}
