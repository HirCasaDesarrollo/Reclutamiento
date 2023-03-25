CREATE TABLE tblPagos(
	PagoId int NOT NULL,
	ClienteId int NOT NULL,
	MontoPagado decimal(9, 2) NOT NULL,
	Aplicado nvarchar (20) NOT NULL,
	FechaPago nvarchar (20) NOT NULL,
 CONSTRAINT PK_Pagos PRIMARY KEY CLUSTERED 
(
	PagoId ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO tblPagos (PagoId, ClienteId, MontoPagado, Aplicado, FechaPago)
SELECT PagoId
	  ,ClienteId
      ,MontoPagado
      ,Aplicado
      ,FechaPago
FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 'Excel 12.0;Database=G:\Documentos\datosClientes.xlsx;HDR=YES', 'SELECT * FROM [Pagos$] WHERE PagoId is not NULL')