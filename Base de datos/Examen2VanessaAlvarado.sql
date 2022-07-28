select *from Facturacion

Create proc sp_AgregarCliente
   as
      begin 
	      select *from Facturacion  
	  end

Create proc sp_ConsultarCliente
as 
 begin 
      select *from Facturacion  
 end

exec sp_AgregarCliente
exec sp_ConsultarCliente