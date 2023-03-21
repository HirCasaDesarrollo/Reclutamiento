BEGIN

	SET IDENTITY_INSERT dbo.Clientes ON;

	INSERT INTO Clientes (Id, Nombre, Telefono, Correo, Edad, MontoSolicitud, Estatus, Aprobación, FechaAlta)
	SELECT	c.ClienteId,	RTrim(LTrim(Replace(Replace(c.Nombre,'   ',' '),'  ',' '))) Nombre,	
			RTrim(LTrim(c.Telefono)) Telefono,	RTrim(Trim(c.Correo)) Correo,	c.Edad, c.MontoSolicitud, 
			CASE WHEN c.Estatus = 'Adeudo' THEN 3 WHEN c.Estatus = '?' THEN 0 END Estatus, 
			CASE WHEN c.Aprobación = '?' THEN 0 ELSE c.Aprobación END Aprobación,	
			Parse(c.FechaAlta as Date) FechaAlta
	FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 
					'Excel 12.0 Xml;Database=C:\Users\pumam\source\repos\pumamay\Reclutamiento\Requeimientos\datosClientes.xlsx;', Clientes$) c
	WHERE c.ClienteId is not null;

	SET IDENTITY_INSERT dbo.Clientes OFF;
	   
	SET IDENTITY_INSERT dbo.Ajustes ON;

	INSERT INTO Ajustes (Id, ClienteId, MontoTotal, Adeudo)
	SELECT	AjusteId, ClienteId, PARSE(Replace(Replace(Replace(MontoTotal,'$',''),'?','0'),',','') AS NUMERIC(15,2)  USING 'es-ES') MontoTotal, 
			PARSE(Replace(Replace(Replace(Adeudo,'$',''),'?','0'),',','') AS NUMERIC(15,2)  USING 'es-ES') Adeudo
	FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 
	   'Excel 12.0 Xml;Database=C:\Users\pumam\source\repos\pumamay\Reclutamiento\Requeimientos\datosClientes.xlsx;', Ajuste$);
	   
	SET IDENTITY_INSERT dbo.Ajustes OFF;

	SET IDENTITY_INSERT dbo.Pagos ON;

	INSERT INTO Pagos (Id, ClienteId, MontoPagado, Aplicado, FechaPago)
	SELECT	PagoId, ClienteId, MontoPagado, Aplicado, Parse(FechaPago as Date) FechaPago
	FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 
	   'Excel 12.0 Xml;Database=C:\Users\pumam\source\repos\pumamay\Reclutamiento\Requeimientos\datosClientes.xlsx;', Pagos$);

	SET IDENTITY_INSERT dbo.Pagos OFF;
END