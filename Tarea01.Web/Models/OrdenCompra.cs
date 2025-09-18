namespace Tarea01.Web.Models
{
    public class OrdenCompra
    {
        #region Propiedades
        /// <summary>
        /// Identifcador de la Orden de Compra
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Fecha de la Orden de Compra
        /// </summary>
        public DateTime Fecha { get; set; }
        /// <summary>
        /// Vendedor que realizo la Orden de Compra
        /// </summary>
        public Vendedor? Vendedor { get; set; }
        /// <summary>
        /// Articulos que integran la Orden de Compra
        /// </summary>
        public IEnumerable<OrdenCompraDetalle>? Detalles { get; set; }
        #endregion
    }
}
