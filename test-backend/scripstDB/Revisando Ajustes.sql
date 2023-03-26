select c.ClienteId, p.PagoId, a.AjusteId, c.nombre, c.MontoSolicitud, c.Estatus, c.Aprobación, c.FechaAlta, sum(p.MontoPagado) as MontoPagado, p.FechaPago, p.Aplicado, a.MontoTotal, a.Adeudo
from tblclientes c right join tblPagos p on c.ClienteId = p.ClienteId
inner join tblAjustes a on c.ClienteId = a.ClienteId
group by c.ClienteId, p.MontoPagado, p.PagoId, a.AjusteId, a.MontoTotal, a.Adeudo, c.nombre, c.MontoSolicitud, c.Estatus, c.Aprobación, c.FechaAlta, p.FechaPago, p.Aplicado
