# 00830-Programacion Avanzada-Tarea 1
Aplicar los conceptos generales de ASP.NET Core Web App MVC con C#, mediante la elaboracion de una practia anterior.

## Desarrollo
La empresa el Faro se dedica a la venta por catálogo, sus productos son principalmente de uso domestico y estilo de vida. Están en una etapa de crecimiento para el negocio y la cantidad de productos que tienen crece cada vez más en variedad y cantidad. Actualmente no cuentan con un sistema que les
permita llevar un control de inventario y venta de productos, por lo que muchas veces controlar los productos existentes y ventas realizadas es muy complicado. Es por esa razón que le han contratado a usted para que diseñe y programe un sistema en C# que cumpla con lo siguiente:

El sistema debe contar con un menú principal con las siguientes opciones:
* Registrar artículos
* Registrar vendedores
* Realizar venta de artículos
* Consultar ventas
* Actualizar inventario
* Consultar inventario

### Registrar Artículo
Está opción del menú le permite al usuario registrar o agregar los artículos que se venden en el catálogo. Se debe poder registrar la siguiente información:
* Id del artículo (int) Se debe validar que no existan ids repetidos
* Descripción (string)
* Activo (bool)
* Precio vendedor (decimal)
* Precio final (decimal)
* Cantidad disponible (int) Se debe validar que no se un número negativo
* Una vez capturada la información se debe agregar a un arreglo de objetos de tipo Articulo. **El arreglo debe ser de 20 posiciones**

### Registrar Vendedor
Le permite al usuario registrar los vendedores de la empresa. Se debe poder registrar la siguiente información:
* Identificación (string) se debe validar que no existan identificaciones repetidas
* Nombre (string)
* Primer apellido (string)
* Segundo apellido (string)
* Fecha de nacimiento (DateTime)
* Genero (char)
* Fecha de ingreso (DateTime)
* Una vez capturada la información se debe agregar a un arreglo de objetos de tipo Vendedor. **El arreglo debe ser de 20 posiciones**

### Realizar venta de artículos
Le permite al usuario registrar la venta de los artículos del catalogo realizados por un vendedor. Para esto el sistema debe crear una orden de compra (OrdenCompra) y la orden de compra debe contener un detalle (arreglo) de los artículos vendidos. Para esto se debe realizar lo siguiente:
* Imprimir en pantalla la lista de vendedores disponibles.
  * Se debe validar que al menos exista un vendedor registrado para realizar la venta
  * Para cada vendedor de la lista se muestran los datos siguientes datos Identificación, Nombre, Primer apellido, Segundo apellido
* Solicitar al usuario que digite la identificación del vendedor de la lista disponible
* Imprimir en pantalla la lista de artículos disponibles para la venta
  * Se debe validar que al menos exista un artículo registrado para realizar la venta
  * Para cada artículo de la lista se muestran los datos siguientes id, descripción, precio vendedor, precio final, cantidad disponible
* Solicitar al usuario el id del artículo de la lista que se desea vender y seguidamente la cantidad que desea agregar a la orden de compra
* La clase OrdenCompra debe tener un arreglo de 15 posiciones donde se agreguen los artículos
* Se debe preguntar al usuario si desea agregar más artículos a la orden de compra. Si sí, entonces se vuelve a mostrar nuevamente la lista de artículos para que el usuario nuevamente seleccione e indique un id.
* Se debe validar la cantidad de artículos disponibles, no se puede agregar a la orden de compra el
artículo si la cantidad existente no lo permite.
* Se debe actualizar la cantidad existente en el inventario de artículos. Se debe validar que no queden valores negativos.
* **Validar los datos** en todos los pasos y las posibles excepciones
* Imprimir en pantalla si la orden de compra se creó de forma exitosa y además mostrar el total de venta precio vendedor y total precio final

Para esta opción se debe poder registrar la siguiente información para OrdenCompra:
* Id de la orden de compra (int)
* Fecha (DateTime)
* Vendedor (Objeto Vendedor)
* Detalle (Arreglo de objeto OrdenCompraDetalle de 15 posiciones) con la siguiente información:
  * Articulo (Objeto Articulo)
  * Cantidad

**Las ordenes de compra se deben agregar en un arreglo de tipo OrdenCompra de 20 posiciones**

### Consultar ventas
Esta opción permite consultar las órdenes de compra realizadas. Debe imprimir en pantalla la información de cada orden de compra así como la fecha, la información del vendedor, la información de los artículos asociados a la orden de compra y el total del precio vendedor y el precio final.
 

### Actualizar inventario
Permite al usuario actualizar las propiedades de los artículos disponibles, debe realizar lo siguiente:

* Imprimir en pantalla la lista de artículos
  * Se debe validar que al menos exista un artículo registrado actualizar el inventario
  * Para cada artículo de la lista se muestran los datos siguientes id, descripción, activo, precio vendedor, precio final, cantidad disponible
* Solicitar al usuario el id del artículo de la lista que se desea actualizar
* De momento solo se permite actualizar la cantidad disponible, por lo que se le solicita al usuario la cantidad
* Se valida que la cantidad no sea negativa y se actualiza el artículo con la nueva cantidad
* Preguntar al usuario si desea actualizar otro artículo del inventario. Si sí, se repite el proceso antes descrito, si no, se devuelve al menú principal.
* Validar los datos en todos los pasos y las posibles excepciones

### Consultar Inventario
Esta opción imprime en pantalla todos los artículos, para cada artículo se debe mostrar todas las propiedades, así como la cantidad disponible. La cantidad disponible debe mostrar actualizada si el artículo ha sido vendido o actualizado desde la opción actualizar inventario.

### Consideraciones técnicas
Debe utilizar POO (Programación orientada a objetos) para resolver el problema
* Las clases de objetos (Articulo, Vendedor, OrdenCompra, OrdenCompraDetalle) no deben contener lógica para solicitar información al usuario, solo debe tener la estructura de la clase y sus propiedades

Debe implementar el manejo de excepciones
* Si ocurre una excepción, el sistema no debe cerrarse, se debe mostrar un mensaje al usuario y manejar la excepción de forma apropiada.

Uso de arreglos
* No deben ser arreglos de string ni int, deben ser arreglos de objetos
* Cada vez que se agrega un objeto al arreglo se debe preguntar al usuario si desea agregar otro y no obligar al usuario a ingresar los 20 registros de una vez
* No debe utilizar colecciones, solo se permite el uso de arreglos para esta tarea
