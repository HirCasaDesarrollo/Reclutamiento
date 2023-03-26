/****** Script para el comando SelectTopNRows de SSMS  ******/
CREATE TABLE tblAjustes(
	AjusteId int NOT NULL,
	ClienteId int NOT NULL,
	MontoTotal nvarchar(25) NOT NULL,
	Adeudo nvarchar(25) NOT NULL
) ON [PRIMARY]
GO

INSERT INTO tblAjustes (AjusteId, ClienteId, MontoTotal, Adeudo)
SELECT AjusteId
	, ClienteId
	, MontoTotal
	, Adeudo
FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 'Excel 12.0;Database=G:\Documentos\datosClientes.xlsx;HDR=YES', 'SELECT * FROM [Ajuste$] WHERE AjusteId is not NULL')