using APIWebEmpleados.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebEmpleados.Db
{
    public class Datos:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; } // tabla Articulos la base de datos

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
