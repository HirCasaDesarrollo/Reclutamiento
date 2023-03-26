CREATE TABLE tblClientes(
	ClienteId int NOT NULL,
	Nombre nvarchar(50) NOT NULL,
	Telefono nvarchar (50) NOT NULL,
	Correo nvarchar(50) NOT NULL,
	Edad int NOT NULL,
	MontoSolicitud decimal(9, 2) NOT NULL,
	Estatus nvarchar(20) NOT NULL,
	Aprobación nvarchar (20) NOT NULL,
	FechaAlta nvarchar (20) NOT NULL,
 CONSTRAINT PK_tblClientes PRIMARY KEY CLUSTERED 
(
	ClienteId ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


INSERT INTO tblClientes (ClienteId, Nombre, Telefono, Correo, Edad, MontoSolicitud, Estatus, Aprobación, FechaAlta)
SELECT ClienteId
	  ,trim(REPLACE(REPLACE(REPLACE(Nombre, CHAR(9), ' '), CHAR(10), ' '), CHAR(13), ' '))
      ,trim(Telefono)
      ,trim(Correo)
      ,Edad
      ,MontoSolicitud
      ,Estatus
      ,Aprobación
      ,FechaAlta
FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 'Excel 12.0;Database=G:\Documentos\datosClientes.xlsx;HDR=YES', 'SELECT * FROM [Clientes$] WHERE ClienteID is not NULL')