namespace Tarea01.Web.Models
{
    public class OrdenCompraDetalle
    {
        #region Propiedades
        /// <summary>
        /// Articulo que se vendio.
        /// </summary>
        public Articulo? Articulo { get; set; }
        /// <summary>
        /// Cantidad vendida.
        /// </summary>
        public int Cantidad { get; set; }
        #endregion

    }
}
