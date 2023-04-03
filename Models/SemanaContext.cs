using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace exercicio_semana9.Models
{
    
    public class SemanaContext : DbContext
    {

        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {

        }

        public DbSet<SemanaModel> Semana { get; set; }
    }




}

