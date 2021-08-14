using Microsoft.EntityFrameworkCore;
using Proyecto_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Demo.Db
{
    public class Datos: DbContext
    {
        // Tabla Clientes 
        public DbSet<Producto> Productos { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Conexion = @"Server = midemodb.database.windows.net;
                                Database = demodb;
                                User = userdb;
                                Password = 12AB34cd*;";
            optionsBuilder.UseSqlServer(Conexion);

        }


    }
}
