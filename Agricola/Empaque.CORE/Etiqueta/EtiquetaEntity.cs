using Empaque.CORE.Producto;
using Empaque.Enumeradores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empaque.Entidades
{
    [Table("Etiqueta")]
    public class EtiquetaEntity
    {
        [Key]
        public int IdEtiqueta { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
       
        [Required]
        public TipoCalidadEnum TipoCalidad { get; set; }


        [Required]
        public bool EstaActivo { get; set; }

        public virtual List<ProductoEntity> Productos { get; set; }
    }

}
