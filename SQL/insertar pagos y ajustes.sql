BULK INSERT Pagos
FROM 'C:\Users\alfredo M\Downloads\Back end jr\Reclutamiento\pagosClientes2.csv'
WITH (FIELDTERMINATOR = ',',
ROWTERMINATOR='\n',
FIRSTROW=2);



BULK INSERT Ajuste
FROM 'C:\Users\alfredo M\Downloads\Back end jr\Reclutamiento\AJUSTECLIENTE.csv'
WITH (FIELDTERMINATOR = ',',
ROWTERMINATOR='\n',
FIRSTROW=2);