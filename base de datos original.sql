
CREATE TABLE empresa(
    emp_id  INT PRIMARY KEY  IDENTITY(1,1),
    emp_nombre varchar(30),
    emp_direccion varchar(45),
    emp_telefono varchar(8)

);

CREATE TABLE origen(
    ori_id INT PRIMARY KEY IDENTITY(1,1),
    ori_nombre varchar(30),
    ori_direccion varchar(45)    
);

CREATE TABLE  bodega(
    bod_id INT PRIMARY KEY IDENTITY(1,1),
    bod_nombre varchar(30),
    bod_direccion varchar(45),
    emp_id  int,
    ori_id int,
    FOREIGN KEY(emp_id) REFERENCES empresa(emp_id),
    FOREIGN KEY(ori_id) REFERENCES origen(ori_id)

);


CREATE TABLE tipo_documento(
    tip_id INT PRIMARY KEY IDENTITY(1,1),
    tip_nombre varchar(45)
  
);

CREATE TABLE  documento(
    doc_id INT PRIMARY KEY IDENTITY(1,1),
    doc_fecha date,
    tip_id int,
    bod_id int,
    
    FOREIGN KEY(tip_id ) REFERENCES tipo_documento(tip_id ),
    FOREIGN KEY(bod_id) REFERENCES bodega(bod_id)
);

CREATE TABLE  productos(
    pro_id INT PRIMARY KEY IDENTITY(1,1),
    pro_nombre varchar(30),
    pro_stock int,
    pro_precio float,
    pro_descripcion varchar(45),
    pro_marca varchar(30)
);

CREATE TABLE traslado(
    tra_id INT PRIMARY KEY IDENTITY(1,1),
    tra_bodegaEntrada varchar(45),
    bod_id int,
    
    FOREIGN KEY(bod_id) REFERENCES bodega(bod_id)
);

CREATE TABLE detalle_traslado(
    detras_id INT PRIMARY KEY  IDENTITY(1,1),
    detras_cantidad int,
    pro_id int,
    tra_id int,
    
    FOREIGN KEY(pro_id) REFERENCES productos(pro_id),
    FOREIGN KEY(tra_id) REFERENCES traslado(tra_id)

);

CREATE TABLE  inventario(
    inv_id INT PRIMARY KEY IDENTITY(1,1),
    inv_cantidad int,
    inv_costo_promedio float,
    pro_id int,
    bod_id int,
    
    FOREIGN KEY(pro_id) REFERENCES productos(pro_id),
    FOREIGN KEY(bod_id) REFERENCES bodega(bod_id)

);

CREATE TABLE orden_compra(
    ord_id  INT PRIMARY KEY IDENTITY(1,1),
    ord_nombre varchar(30),
    ord_fecha date,
    bod_id int,

    FOREIGN KEY(bod_id) REFERENCES bodega(bod_id)
);



CREATE TABLE  detalle_orden(
    det_id INT PRIMARY KEY IDENTITY(1,1), 
    det_cantidad int,
    det_precio float,
    det_total float,
    ord_id int,
    pro_id int,
    FOREIGN KEY(ord_id) REFERENCES orden_compra(ord_id),
    FOREIGN KEY(pro_id) REFERENCES productos(pro_id)
);


















