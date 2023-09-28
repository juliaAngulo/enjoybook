using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Alquilar
    {
        [Key]
        public int IdAlquilar { get; set; }
        
        public string Nombre { get; set; }

        public string Departamento { get; set; }

        public string Municipio { get; set; }

        public string Barrio { get; set; }

        public string Direccion { get; set; }

        public int CodigoPostal { get; set; }

        public int NumDias { get; set; }

        public int NumCuenta { get; set; }
    }
}