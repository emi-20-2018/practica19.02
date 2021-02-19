using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica19._02.Models
{
    public class avionesDbContext : DbContext
    {
        public DbSet<aviones> lista_de_aviones { get; set; }
        
    private void LoadDefaultUsers()
        {
            lista_de_aviones.Add(new aviones { codigo = "2345db", base1 = "BOA" });
            lista_de_aviones.Add(new aviones { codigo = "6789ae", base1 = "Gol" });

        }
        public
        avionesDbContext(DbContextOptions<avionesDbContext>options):base(options)
        {
            LoadDefaultUsers();
        }

        public List<aviones> GetAviones() => lista_de_aviones.Local.ToList<aviones>();

    }
}
