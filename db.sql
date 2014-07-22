create database facilventasoft;
use facilventasoft;

create table articulo(
	IdArticulo varchar(20) primary key comment 'Clave primaria de articulo o Código de barras',
	IdDepartamento int not null comment 'Clave foranea Departamento',
	IdProveedor int null comment 'Clave foranea Proveedor',
	Descripcion varchar(40) comment 'Descripcion del articulo',
	Existencia varchar(5) comment 'Existencia del articulo',
	NivelCritico int comment 'Nivel minimo permitido de un articulo',
	UnidadMedida varchar(15) comment 'Indica la unidad de medida del articulo',
	FechaCaducidad varchar(11) comment 'Fecha de caducidad del articulo',
	FechaRegistro varchar(11) comment 'Fecha en que se registro el articulo',
	PrecioCompra decimal comment 'Precio al que se compra a los proveedoores',
	PrecioVenta decimal comment 'Precio al que se vende el articulo a los clientes'
);

create table cliente(
	IdCliente int auto_increment primary key comment 'Clava unica para cada cliente',
	Nombre varchar(30) comment 'Nombre del Cliente',
	Apellidos varchar(30) comment 'Apellidos del cliente',
	Direccion varchar(150) comment 'Diereccion del cliente',
	RFC varchar(20) comment 'Registro Federal de Constribuyente del cliente',
	RazonSocial varchar(50) comment 'Razon social por el cual facturar',
	DireccionFacturacion varchar(150) comment 'Direccion de facturacion',
	PuntosAcumulados int comment 'Puntos acumulados del cliente por causa de promociones',
	FechaUltimaCompra varchar(11) comment 'Fecha en la que el cliente realizo su ultima compra',
	FechaRegistro varchar(11) comment 'Fecha en la que se registro el cliente',
	CreditoAdeudo decimal comment 'Aqui se almacena el monto total de adeudo por causa de compras a credito del cliente',
	CreditoAbono decimal comment 'Cantidad total abonada al aduedo del cliente' 
);

create table credito(
	IdRegistro int auto_increment primary key comment 'Clave unica para cada credito',
	IdCliente int comment 'Clave foranea Cliente',
	IdVenta int comment 'Cleva foranea Venta',
	CantidadEfectivo decimal comment 'Cantidad en efectivo del credito',
	FechaRegistro varchar(11) comment 'Fecha de registro del credito',
	HoraRegistro varchar(11) comment 'Hora de registro del credito'
);

create table departamento(
	IdDepartamento int auto_increment primary key comment 'Clave unica para cada departamento',
	Nombre varchar(20) comment 'Nombre del departamento',
	Descripcion varchar(100) comment 'Descripcion del departamento',
	FechaRegistro varchar(11) comment 'Fecha en que se registra el departamento'
);

create table efectivoegreso(
	IdEfectivoEgreso int auto_increment primary key comment 'Clave unica para cada egreso de efectivo',
	IdUsuario varchar(20) comment 'Clave foranea Usuario',
	Motivo text comment 'Motivo que justifica el egreso de efectivo',
	CanttidadEfectivo decimal comment 'Cantidad de efectivo que esta egresando',
	FechaRegistro varchar(11) comment 'Fecha en la que se registro el egreso de efectivo',
	HoraRegistro varchar(11) comment 'Hora en la que se registro el egreso de efectivo'
);

create table efectivoingreso(
	IdEfectivoIngreso int auto_increment primary key comment 'Clave unica para cada ingreso de efectivo',
	IdUsuario varchar(20) comment 'Clave foranea Usuario',
	Motivo text comment 'Motivo que justifica el ingreso de efectivo',
	CanttidadEfectivo decimal comment 'Cantidad de efectivo que esta ingresando',
	FechaRegistro varchar(11) comment 'Fecha en la que se registro el ingreso de efectivo',
	HoraRegistro varchar(11) comment 'Hora en la que se registro el ingreso de efectivo'
);

create table historialventa(
	IdHistorialVenta int auto_increment primary key comment 'Clave unica para cada historial de venta',
	IdVenta int comment 'Clave foranea venta',
	IdArticulo varchar(20) comment 'Clave foranea articulo',
	IdPromocion int comment 'Clave foranea promocion',
	PrecioReal decimal comment 'Precio real al consumidor',
	PrecioDescuento decimal comment 'Precio a pagar ya con descuento aplicado',
	PromocionPorcentaje int comment 'porcentaje del descuento que se esta aplicando'
);

create table merma(
	IdMerma int auto_increment primary key comment 'Clave unica para cada merma',
	IdUsuario varchar(20) comment 'Clave foranea usuario',
	IdArticulo varchar(20) comment 'Clave foranea articulo',
	Motivo text comment 'Motivo por el cual se esta registrando la merma',
	CantidadArticulo decimal comment 'Cantidad de articulos',
	FechaRegistro varchar(11) comment 'Fecha en que se esta registrando la merma',
	HoraRegistro varchar(11) comment 'Hora en que se esta registrando la merma'
);

create table promocion(
	IdPromocion int auto_increment primary key comment 'Clave unica para cada promocion',
	Nombre varchar(30) comment 'Nombre de la promocion',
	Descripcion text comment 'Descripcion de la promocion',
	PorcentajeDescuento int comment 'Porcentaje de descuento',
	FechaInicio varchar(11) comment 'Dia en que se activara la promocion',
	FechaFin varchar(11) comment 'Dia en que se desactivara la promocion',
	TipoPromocion int comment 'Tipo promocion: 1- Venta mayor a/2- Productos especificos/3- Ambos',
	VentaMayorA decimal comment 'Promocion aplica si venta mayor a cantidad especificada',
	VentaMenorA decimal comment 'Promocion aplica si venta menor a cantidad especificada',
	EstadoPromocion boolean comment '0- Desactivada  / 1- Activada',
	FechaRegistro varchar(11) comment 'Fecha en que se creo promocion'
);

create table promocionRequiere(
	IdPromocionRequiere int auto_increment primary key comment 'Clave unica para cada registro',
	IdPromocion int comment 'Clave foranea promocion',
	IdArticulo text comment 'Clave foranea articulo',
	CantidadMin int comment 'Cantidad minima de articulos para que aplique promocion',
	CantidadMax int comment 'Cantidad maxima de articulos para que aplique promocion'
);

create table proveedor(
	IdProveedor int auto_increment primary key comment 'Clave unica para cada proveedor',
	Nombre varchar(20) comment 'Nombre del proveedor',
	Telefono varchar(15) comment 'Telefono del proveedor',
	CorreoElectronico varchar(25) comment 'Correo electronico del proveedor',
	FechaRegistro varchar(11) comment 'Fecha en que se registro el proveedor'
);

create table usuario(
	IdUsuario varchar(20) primary key comment 'Clave unica para cada usuario',
	Pass varchar(20) comment 'Cantraseña del usuario',
	Nombre varchar(30) comment 'Nombre del usuario',
	Apellidos varchar(30) comment 'Apellidos del usuario',
	FechaNacimiento varchar(11) comment 'Fecha de nacimiento del usuario',
	Sexo varchar(10) comment 'Sexo',
	Direccion text comment 'Direccion del usuario',
	Telefono varchar(15) comment 'Telefono del usuario',
	Tipo varchar(15) comment 'Tipo de usuario',
	FechaRegistro varchar(11) comment 'Fecha en que se registro el usuario'
);

create table venta(
	IdVenta int auto_increment primary key comment 'Clave unica para cada venta',
	IdUsuario varchar(20) comment 'Clave foranea usuario',
	IdCliente int comment 'Clave foranea cliente',
	NumeroArticulos int comment 'Total de articulos de la venta',
	NumeroTicket int comment 'numero  de ticket',
	TipoPago varchar(15) comment 'Tipo de pago',
	TotalVenta decimal comment 'Total de la venta',
	Importe decimal comment 'Importe del cliente: Total de efectivo pagado',
	FechaRegistro varchar(11) comment 'Fecha en que se registro la venta',
	HoraRegistro varchar(11) comment 'Hora en que se registro la venta'
);

create table tipousuario(
	IdTipoUsuario varchar(20) primary key comment 'Identificador unico para cada tipo de usuario',
	Descripcion text comment 'Descripcion del tipo de usuario',
	FechaRegistro varchar(11) comment 'Fecha en la que se registro el tipo de usuario'
);

create table permisos(
	IdPermiso int auto_increment primary key comment 'Clave unica para cada permiso',
	Descripcion text comment 'Descripcion del permiso'
);

create table usuariopermiso(
	IdUsuarioPermiso int auto_increment primary key comment 'Clave unica para cada registro',
	IdTipoUsuario varchar(20) comment 'Clave forannea usuario',
	IdPermiso int comment 'Clave foranea permiso'
);




