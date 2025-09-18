using Microsoft.Extensions.Primitives;

namespace Tarea01.Web.Models
{
    public class Vendedor
    {
        #region Propiedades
        /// <summary>
        /// Identificación del vendedor del vendedor. Debe ser único.
        /// </summary>
        public string? Idendtificacion { get; set; }
        /// <summary>
        /// Nombre del vendedor.
        /// </summary>
        public string? Nombre { get; set; }
        /// <summary>
        /// Primer apellido del vendedor.
        /// </summary>
        public string? PrimerApellido { get; set; }
        /// <summary>
        /// Segundo apellido del vendedor.
        /// </summary>
        public string? SegundoApellido { get; set; }
        /// <summary>
        /// Fecha de ingreso del vendedor a la empresa.
        /// </summary>
        public DateTime FechaIngreso { get; set; }
        /// <summary>
        /// Genero del vendedor. 'M' para masculino, 'F' para femenino, 'O' para otro.
        /// </summary>
        public char? Genero { get; set; }
        /// <summary>
        /// Fecha de nacimiento del vendedor.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        #endregion
    }
}
