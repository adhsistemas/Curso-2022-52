using Empaque.CORE.Producto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empaque.Entidades
{
    [Table("Cultivo")]
    public class CultivoEntity
    {
        [Key]//define el campo como llave primaria
        public int IdCultivo { get; set; }

        [Required]//poner el campo como not null
        [StringLength(20)]// define el tamaño de los string
        public string Nombre { get; set; }

        [Required]
        public bool EstaActivo { get; set; }


        public virtual List<ProductoEntity> Productos { get; set; }
    }
}
