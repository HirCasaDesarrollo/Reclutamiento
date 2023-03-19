# Prueba Técnica - Programador (Back-end Jr.)
La siguiente es una prueba para evaluar a los postulantes a programador **Back-end Jr.**.

## INTRODUCCIÓN

Se busca evaluar las capacidades técnicas del candidato con respecto a las principales funciones y responsabilidades que se requieren dentro del área de Desarrollo de _HirCasa_.

#### ¿Qué se busca evaluar?
Principalmente los siguientes aspectos:
  + Creatividad para resolver los requerimientos,
  + Calidad del código entregado (estructura y buenas prácticas),
  + Eficiencia de los algoritmos entregados,
  + Familiaridad con Frameworks y plataformas de desarrollo backend,
  + Utilizar herramientas para versionar código fuente.

## IMPORTANTE
1. Se solicita materializar la solución de los requerimientos del siguiente ejercicio utilizando la tecnología y lenguaje de su elección, se dará preferencia a los candidatos que utilicen **C# .NET** + **Entity Framework Code-First**.
2. Recomendamos emplear un máximo de **2 (dos) días** y enviar todo lo que puedas.
3. Se requiere de una **cuenta de GitHub** para realizar este ejercicio.
4. **Antes de comenzar a programar:**
    * Realizar un `Fork` de este repositorio (https://github.com/HirCasaDesarrollo/Reclutamiento).
    * Clonar el fork a su máquina local  `git clone git@github.com:USERNAME/FORKED-PROJECT.git`
    * Crear un `branch` en su cuenta de GitHub utilizando su nombre completo.
5. **Al finalizar**, para entregar su proyecto, deberán realizar un `Commit` de su proyecto, **enviar un `Pull Request` al branch con su NOMBRE**, y notificar a la siguiente dirección de correo electrónico  [licenciasdev@hircasa.com](mailto:licenciasdev@hircasa.com).
  * Recuerda adjuntar los scripts, diagramas y anexar la información necesaria para ejecutar tu proyecto.

## EJERCICIO PRÁCTICO
**Objetivo:** Resolver los requerimientos en base a la información dada en el excel datosClientes.xls de registros DEMO de clientes.

#### Resolver requerimientos:


**DATOS:** 
1. Construir los modelos que vas a necesitar para cargar los registros del archivo de Excel proporcionado.
2. Crear la base de datos a partir de los modelos
3. Insertar los registros que vienen en el Excel datosClientes.xls en la base de datos creada.
  * Se espera que se inserten los registros con sintaxis de SQL

**REQUERIMIENTOS:** 
1. Se debe obtener todos los nombres de los clientes y actualizar los registros en la BD quitando los espacios adicionales por medio de un método (de manera que sean a espacio simple).
2. Dadas las fechas de pago se debe de actualizar el MontoTotal de la tabla Ajuste a partir de los 
pagos aplicados de la tabla Pagos.
3. Una vez obtenidos estos datos, hacer un cruce de información con la tabla Ajuste para tener los totales reales colocándolo en la columna de Adeudo tomando en cuenta el MontoPagado de los pagos de los clientes y el MontoSolicitud
4. Actualizar el estatus de todos los clientes de acuerdo con los siguientes criterios:
 * Si el residuo de los totales es igual a la suma de los pagos del cliente se considera un cliente “Al corriente”.
 * Si el total es menor a la suma de los pagos se considera al cliente como “Adeudo”
 * Si la suma de los pagos es igual a 0 se considera al cliente como “Cancelación”
5. Actualizar la columna de aprobación con los siguientes criterios:
 * Si el cliente tiene estatus de” Al corriente” y “Adeudo” a 1 
 * Si el cliente tiene estatus de “Cancelación” a 0

 **ADICIONAL:** 
1. Documenta de forma general tu lógica, usando diagramas de flujo para representar los métodos construidos en tu aplicación.
2. No olvides adjuntar los scripts realizados para insertar la información en tu base de datos.