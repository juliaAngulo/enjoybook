using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Proyecto1.Models
{
    public partial class LibrosContext : DbContext
    {

        public LibrosContext(DbContextOptions<LibrosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alquilar> Alquilars { get; set; }

        public virtual DbSet<Comprar> Comprars { get; set; }

        public virtual DbSet<Publicar> Publicars { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }
            
        public virtual DbSet<Usuario> Usuarios1 { get; set; }


    }
}

       