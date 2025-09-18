using System.ComponentModel.DataAnnotations;

namespace Tarea01.Web.Models
{
    public class Articulo
    {
        #region Propiedades
        /// <summary>
        /// Identificación del artículo. Debe ser único.
        /// </summary>
        [Required(ErrorMessage = "Por favor, ingrese un identificador")]
        public int Id { get; set; }
        /// <summary>
        /// Descripción del artículo.
        /// </summary>
        [Required(ErrorMessage = "Por favor, ingrese un descripcion")]
        public string? Descripcion{ get; set; }
        /// <summary>
        /// El artículo está activo o inactivo.
        /// </summary>
        [Required(ErrorMessage = "Por favor, indique si el articulo esta activo o inactivo")]
        public bool? Activo { get; set; }
        /// <summary>
        /// Precio al que el vendedor adquiere el artículo.
        /// </summary>
        public decimal PrecioVendedor { get; set; }
        /// <summary>
        /// Precio al que se vende el artículo al cliente final.
        /// </summary>
        public decimal PrecioFinal { get; set; }
        /// <summary>
        /// Cantidad disponible del artículo en inventario.
        /// </summary>
        public int CantidadDisponible { get; set; }
        #endregion
    }
}
