/*
Para crear la base de datos, se uso Entity framework 6 con el método *CodeFirst* realizando los siguiente procedimiento:

1. Instale  los paquete NuGet necesarios en sus respectivas versiones para coincidir con ASP.Net 6:
* Microsoft.EntityFrameworkCore (6.0.12)
* Microsoft.EntityFrameworkCore.SqlServer (6.0.12)
* Microsoft.EntityFrameworkCore.Tools (6.0.12)

2. Cree los modelos en la carpeta *Models* con base en las tablas y columnas proporcionados en el archivo Excel, dejándolos con sus respectivos nombres y atributos, agregando algunos *Data nnotations* para mejorar la esquematización de la base de datos

3. Cree el DbContext para relacionar todas las tablas de datos al contexto, llamándose *DataBaseContext* en la carpeta *DAL* (Data Access Layer)


4. Inserte el StringConnection de la Base de datos (LocalDB) en appsettings.json y la agregué en forma de servicio al Program.cs.

5. Comencé las migraciones agregando la migración inicial y aplicarla con los siguientes comandos ejecutados en la *Consola de administrador de paquetes* de Visual Studio: 
```
Add-Migration InitDB
Update-Database
```

6.  Una vez comprobado que si se conectaba a la base de datos, tocaba subir los datos, los subí desde una clase llamada *DbInitializer.cs* en la carpeta *DAL*

¡ Y listo!, la base de datos ya esta hecha y funcional.
*/


context.Clientes.AddRange(
    new Cliente {Nombre = "	Alyssa   Macdonald  King	",  Telefono = "477-1943",	Correo= "magnis.dis@yahoo.couk", Edad = 24, MontoSolicitado = 74_300.04M, FechaAlta= DateTime.Parse(" Dec 4, 2021")},
    new Cliente {Nombre = "	Irene   Carey    Spears	",      Telefono = "1-153-173-1315",	Correo= "donec.feugiat@protonmail.com", Edad = 18,MontoSolicitado = 1_213_748.20M, FechaAlta= DateTime.Parse(" Sep 16, 2022")},
    new Cliente {Nombre = "	Hope          Best Charity	",  Telefono = "1-810-927-0758",	Correo= "sed.neque@yahoo.edu", Edad = 45,MontoSolicitado = 378_121.58M, FechaAlta= DateTime.Parse(" Sep 18, 2021")},
    new Cliente {Nombre = "	  Kirsten   Glover   Carrison	", Telefono = "488-7837",	Correo= "ipsum.ac.mi@google.edu", Edad = 39,MontoSolicitado = 22_430.14M	, FechaAlta= DateTime.Parse(" Feb 6, 2022")},
    new Cliente {Nombre = "	Cheyenne Norton       Mcdonald	", Telefono = "1-638-481-3863",	Correo= "nulla.eu@yahoo.ca", Edad = 28,MontoSolicitado = 664_419.39M	, FechaAlta= DateTime.Parse(" Apr 1, 2022")},
    new Cliente {Nombre = "	 Kirk Nichols Douglas	",      Telefono = "348-0176",	Correo= "donec@yahoo.edu", Edad = 25,MontoSolicitado = 980_000.50M, FechaAlta= DateTime.Parse(" Sep 24, 2022")},
    new Cliente {Nombre = "	Blaze  Massey    Adams  	",  Telefono = "1-483-678-4909",	Correo= "sed@aol.edu", Edad = 56,MontoSolicitado = 276_899.83M ,FechaAlta= DateTime.Parse(" Jul 9, 2022")},
    new Cliente {Nombre = "	Raphael    Wright Allen	",      Telefono = "942-4114",	Correo= "dolor.donec.fringilla@aol.", Edad = 83,MontoSolicitado = 778_564.00M, Estatus = "Adeudo", Aprobacion =	"1"	,FechaAlta= DateTime.Parse(" Jul 28, 2022")},
    new Cliente {Nombre = "	   Pamela   Hanson  Love	",  Telefono = "1-760-505-0882",	Correo= "sed@yahoo.org", Edad = 60,MontoSolicitado = 331_876.00M, FechaAlta= DateTime.Parse(" Jan 13, 2022")},
    new Cliente {Nombre = "	Lois  Byers                Parson	", Telefono = "1-773-637-7287",	Correo= "eu.eleifend.nec@yahoo.com", Edad = 37,MontoSolicitado = 634_567.20M, FechaAlta= DateTime.Parse(" Sep 10, 2022")}

);




context.Pagos.AddRange(
    new Pago { PagoID = 1, ClienteID = 8,    MontoPagado = 898960.61M,  Aplicado = 1,   FechaPago = DateTime.Parse("Oct 11, 2021")},
    new Pago { PagoID = 2, ClienteID = 10,   MontoPagado = 498882.82M,  Aplicado = 1,   FechaPago = DateTime.Parse("Aug 14, 2021")},
    new Pago { PagoID = 3, ClienteID = 2,    MontoPagado = 631239.40M,  Aplicado = 1,   FechaPago = DateTime.Parse("Dec 26, 2022")},
    new Pago { PagoID = 4, ClienteID = 1,    MontoPagado = 43000.00M,   Aplicado = 1,   FechaPago = DateTime.Parse("Oct 18, 2021")},
    new Pago { PagoID = 5, ClienteID = 5,    MontoPagado = 88656.60M,   Aplicado = 0,   FechaPago = DateTime.Parse("Sep 6, 2021")},
    new Pago { PagoID = 6, ClienteID = 6,    MontoPagado = 254661.68M,  Aplicado = 1,   FechaPago = DateTime.Parse("Jun 14, 2022")},
    new Pago { PagoID = 7, ClienteID = 2,    MontoPagado = 50846.04M,   Aplicado = 1,   FechaPago = DateTime.Parse("Jul 20, 2022")},
    new Pago { PagoID = 8, ClienteID = 7,    MontoPagado = 67764.01M,   Aplicado = 1,   FechaPago = DateTime.Parse("Sep 16, 2022")},
    new Pago { PagoID = 9, ClienteID = 6,    MontoPagado = 669890.82M,  Aplicado = 1,   FechaPago = DateTime.Parse("Oct 3, 2022")},
    new Pago { PagoID = 10, ClienteID = 1,   MontoPagado = 2700.00M,    Aplicado = 1,   FechaPago = DateTime.Parse("Oct 27, 2021")},
    new Pago { PagoID = 11, ClienteID = 9,   MontoPagado = 331876.00M,  Aplicado = 1,   FechaPago = DateTime.Parse("Jan 24, 2022")},
    new Pago { PagoID = 12, ClienteID = 8,   MontoPagado = 787879.68M,  Aplicado = 0,   FechaPago = DateTime.Parse("Jan 27, 2022")},
    new Pago { PagoID = 13, ClienteID = 8,   MontoPagado = 13777.71M,   Aplicado = 1,   FechaPago = DateTime.Parse("Sep 14, 2022")},
    new Pago { PagoID = 14, ClienteID = 4,   MontoPagado = 8372.77M,    Aplicado = 1,   FechaPago = DateTime.Parse("Feb 7, 2022")},
    new Pago { PagoID = 15, ClienteID = 1,   MontoPagado = 7298.00M,    Aplicado = 1,   FechaPago = DateTime.Parse("Sep 6, 2022")},
    new Pago { PagoID = 16, ClienteID = 4,   MontoPagado = 2572.31M,    Aplicado = 1,   FechaPago = DateTime.Parse("May 6, 2022")},
    new Pago { PagoID = 17, ClienteID = 10,  MontoPagado = 447671.39M,  Aplicado = 1,   FechaPago = DateTime.Parse("Nov 25, 2021")},
    new Pago { PagoID = 18, ClienteID = 6,   MontoPagado = 197670.40M,  Aplicado = 1,   FechaPago = DateTime.Parse("Oct 14, 2022")},
    new Pago { PagoID = 19, ClienteID = 10,  MontoPagado = 490376.34M,  Aplicado = 1,   FechaPago = DateTime.Parse("Oct 14, 2022")},
    new Pago { PagoID = 20, ClienteID = 2,   MontoPagado = 326830.23M,  Aplicado = 1,   FechaPago = DateTime.Parse("Dec 21, 2022")},
    new Pago { PagoID = 21, ClienteID = 3,   MontoPagado = 1713.89M,    Aplicado = 0,   FechaPago = DateTime.Parse("May 7, 2022")},
    new Pago { PagoID = 22, ClienteID = 1,   MontoPagado = 1000.04M,    Aplicado = 1,   FechaPago = DateTime.Parse("Apr 29, 2022")},
    new Pago { PagoID = 23, ClienteID = 3,   MontoPagado = 66661.37M,   Aplicado = 1,   FechaPago = DateTime.Parse("Dec 6, 2021")},
    new Pago { PagoID = 24, ClienteID = 2,   MontoPagado = 238787.18M,  Aplicado = 0,   FechaPago = DateTime.Parse("Feb 22, 2022")},
    new Pago { PagoID = 25, ClienteID = 5,   MontoPagado = 255220.05M,  Aplicado = 1,   FechaPago = DateTime.Parse("Mar 15, 2022")},
    new Pago { PagoID = 26, ClienteID = 3,   MontoPagado = 68767.62M,   Aplicado = 1,   FechaPago = DateTime.Parse("Oct 28, 2021")},
    new Pago { PagoID = 27, ClienteID = 7,   MontoPagado = 137308.50M,  Aplicado = 1,   FechaPago = DateTime.Parse("Dec 13, 2022")},
    new Pago { PagoID = 28, ClienteID = 1,   MontoPagado = 20000.00M,   Aplicado = 1,   FechaPago = DateTime.Parse("Aug 3, 2022")},
    new Pago { PagoID = 29, ClienteID = 2,   MontoPagado = 14578.38M,   Aplicado = 1,   FechaPago = DateTime.Parse("Oct 22, 2021")},
    new Pago { PagoID = 30, ClienteID = 6,   MontoPagado = 64488.01M,   Aplicado = 0,   FechaPago = DateTime.Parse("Dec 24, 2022")},
    new Pago { PagoID = 31, ClienteID = 4,   MontoPagado = 8264.72M,    Aplicado = 1,   FechaPago = DateTime.Parse("May 25, 2022")},
    new Pago { PagoID = 32, ClienteID = 3,   MontoPagado = 348887.74M,  Aplicado = 1,   FechaPago = DateTime.Parse("Dec 6, 2022")},
    new Pago { PagoID = 33, ClienteID = 2,   MontoPagado = 555687.92M,  Aplicado = 1,   FechaPago = DateTime.Parse("Oct 9, 2021")},
    new Pago { PagoID = 34, ClienteID = 6,   MontoPagado = 537766.32M,  Aplicado = 0,   FechaPago = DateTime.Parse("Oct 19, 2022")},
    new Pago { PagoID = 35, ClienteID = 10,  MontoPagado = 327769.86M,  Aplicado = 1,   FechaPago = DateTime.Parse("Nov 22, 2021")},
    new Pago { PagoID = 36, ClienteID = 2,   MontoPagado = 31543.76M,   Aplicado = 0,   FechaPago = DateTime.Parse("Aug 12, 2022")},
    new Pago { PagoID = 37, ClienteID = 2,   MontoPagado = 255678.57M,  Aplicado = 1,   FechaPago = DateTime.Parse("Sep 22, 2022")},
    new Pago { PagoID = 38, ClienteID = 5,   MontoPagado = 366888.15M , Aplicado = 1,   FechaPago = DateTime.Parse("Apr 9, 2022")}
);

context.Ajustes.AddRange(
    new Ajuste {ClienteID = 8, MontoTotal = 912_738, Adeudo = -13_4174},
    new Ajuste {ClienteID = 2},
    new Ajuste {ClienteID = 9},
    new Ajuste {ClienteID = 7},
    new Ajuste {ClienteID = 3},
    new Ajuste {ClienteID = 4},
    new Ajuste {ClienteID = 6},
    new Ajuste {ClienteID = 10},
    new Ajuste {ClienteID = 1},
    new Ajuste {ClienteID = 5}
);