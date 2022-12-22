# Prueba para Backend Jr

Aplicacion web creada en ASP.Net 6 y Entity Framework 6 (Code First) y realizada para una prueba del puesto de trabajo de Backend Jr en la empresa [Hir Casa Financiamiento Inmobiliario](https://hircasa.com/). La base de datos usada fue SQLServer 2022 LocalDB

  
![Home de la app](https://i.pinimg.com/originals/dc/b3/bf/dcb3bfc4ee8ce4556f503b134a526cdd.jpg)
![Requerimiento 2 prueba Backend Jr ](https://i.pinimg.com/originals/9e/2e/06/9e2e06976436572994484ff46ccb64a3.jpg)

  

## Tecnologias

* Microsoft Visual Studio Community 2022

* ASP.Net Core 6 MVC

* Entity Framework 6 (Code First)

* SqlServer 2022 - versión LocalDB (cambia la cadena de conexión en appsettings.json para utilizar el SQL Server de su preferencia)

Paquetes NuGet utilizados:

* Microsoft.EntityFrameworkCore (6.0.12)

* Microsoft.EntityFrameworkCore.SqlServer (6.0.12)

* Microsoft.EntityFrameworkCore.Tools (6.0.12)

## Instalación

1. Clone el repositorio del proyecto.
```
 git clone <url_repo>
```

2. Abra Visual Studio 2022 (se recomienda usar esta versión) y abra el proyecto que está adentro de la carpeta Prueba-Backend-Jr

3. Asegúrese que los paquetes NuGet listados arriba estén instalados, sino instálelos en su versión 6.0.12 (por defecto, la versión 7 de lospaquetes es la que se instala en VS 2022, así que debe de señalarle a NuGet que es la versión 6.0.12 la que quiere instalar) 

4. Las migraciones de la Base de datos ya están agregadas, solos falta aplicarlas, y para ello debe de abrir una "consola de administrador de paquetes" que se encuentra desde Visual Studio en ***Herramientas > Administrador de paquetes NuGet > Consola de administrador de paquetes*** y ejecutar el comando Update-Database (este comando no funciona en una terminal normal)
```
 Update-Database
```

5. Si no hubo ningún error, ya podrá ejecutar la aplicación web, ya sea desde el modo debug o desde el modo sin depurar de Visual Studio.

## Creación de la Base de Datos
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