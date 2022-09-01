using Empaque.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empaque.CORE.Producto
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        public int IdCultivo { get; set; }
        [Required]
        public int IdEtiqueta { get; set; }
        [Required]
        public int IdEnvase { get; set; }
        [Required]
        public int IdTamaño { get; set; }
        [Required]
        public int CantidadCajas { get; set; }
        [Required]
        public int PesoKilogramos { get; set; }
      
        public string CveGuia { get; set; }
        public string CveProductoServicio { get; set; }
        public string CveUnidadMedida { get; set; }
        public string CveFraccionArancelaria { get; set; }

        [Required]
        public bool EstaActivo { get; set; }

        [ForeignKey("IdCultivo")]
        public virtual CultivoEntity Cultivo { get; set; }

        [ForeignKey("IdEtiqueta")]
        public virtual EtiquetaEntity Etiqueta { get; set; }

        [ForeignKey("IdEnvase")]
        public virtual EnvaseEntity Envase { get; set; }

        [ForeignKey("IdTamaño")]
        public virtual TamañoEntity Tamaño { get; set; }

    }
}
