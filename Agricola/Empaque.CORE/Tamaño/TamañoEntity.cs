using Empaque.CORE.Producto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empaque.Entidades
{
    [Table("Tamaño")]
    public class TamañoEntity
    {
        [Key]
        public int IdTamaño { get; set; }
        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        [Required]
        public bool EstaActivo { get; set; }

        public virtual List<ProductoEntity> productos { get; set; }
    }
}
