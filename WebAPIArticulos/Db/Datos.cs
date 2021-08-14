using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIArticulos.Models;

namespace WebAPIArticulos.Db
{
    public class Datos: DbContext
    {
        public DbSet<Articulo> Articulos { get; set; } // tabla Articulos la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Conexion = @"Server = surtidor.database.windows.net;
                                Database = surtidordb;
                                User = admindb;
                                Password = 12AB34cd*;";


            optionsBuilder.UseSqlServer(Conexion);
        }

    }
}
