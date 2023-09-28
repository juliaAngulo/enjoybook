using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Publicar
    {
        [Key]
        public int IdPublicar { get; set; }
   
        public string NombreLibro { get; set; }

        public string AutorLibro { get; set; }

        public string EditorialLibro { get; set; }

        public int NumPag { get; set; }

        public string Caracteristicas { get; set; }
    }
}