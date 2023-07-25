--PROYECTO F2
--MODULO:POO
--PROFESOR:LUIS_ALONSO_BOGANTES_RODRIGUEZ
--ESTUDIANTE:JOSE_CAMPOS_CHAVES

--***BORRAR LA BASE DE DATOS***
--DROP DATABASE CLINICA_PRIVADA

--SE CREA LA DB

CREATE DATABASE CLINICA_PRIVADA;
GO

--SE USA LA BD
USE CLINICA_PRIVADA;
GO

-- Creación de la tabla PACIENTES
CREATE TABLE PACIENTES (
  ID_PACIENTE INT PRIMARY KEY IDENTITY(1,1),
  NOMBRE_PACIENTE VARCHAR(50),
  APELLIDOS_PACIENTE VARCHAR(100),
  CEDULA_PACIENTE VARCHAR(9),--UNIQUE,
  TELEFONO_PACIENTE VARCHAR(8) NULL,
  CORREO_PACIENTE VARCHAR(50) NULL,
  DIRECCION_PACIENTE VARCHAR(255) NULL,
  FECHA_NACIMIENTO_PACIENTE DATE
);

-- Creación de la tabla PUESTOS_DE_TRABAJO
CREATE TABLE PUESTOS_DE_TRABAJO (
  ID_PUESTO INT PRIMARY KEY IDENTITY(1,1),
  NOMBRE_PUESTO VARCHAR(255),
  DESCRIPCION_PUESTO VARCHAR(255)
);

-- Creación de la tabla ESPECIALIDADES
CREATE TABLE ESPECIALIDADES (
  ID_ESPECIALIDAD INT PRIMARY KEY IDENTITY(1,1),
  NOMBRE_ESPECIALIDAD VARCHAR(255),
  DESCRIPCION_ESPECIALIDAD VARCHAR(255)
);

-- Creación de la tabla FUNCIONARIOS
CREATE TABLE FUNCIONARIOS (
  ID_FUNCIONARIO INT PRIMARY KEY IDENTITY(1,1),
  ID_PUESTO INT,
  ID_ESPECIALIDAD INT,
  NOMBRE_FUNCIONARIO VARCHAR(50),
  APELLIDOS_FUNCIONARIO VARCHAR(100),
  CEDULA_FUNCIONARIO VARCHAR(9),--UNIQUE,
  TELEFONO_FUNCIONARIO VARCHAR(8) NULL,
  CORREO_FUNCIONARIO VARCHAR(50) NULL,
  DIRECCION_FUNCIONARIO VARCHAR(255) NULL,
  FECHA_NACIMIENTO_FUNCIONARIO DATE  
);

-- Creación de la tabla AGENDA
CREATE TABLE AGENDA (
  ID_AGENDA INT PRIMARY KEY IDENTITY(1,1),
  ID_FUNCIONARIO INT,
  FECHA DATE,
  HORA_INICIO TIME,
  HORA_FIN TIME  
);

-- Creación de la tabla AGENDA
CREATE TABLE CITAS (
  ID_CITA INT PRIMARY KEY IDENTITY(1,1),
  ID_PACIENTE INT,
  ID_FUNCIONARIO INT,
--ID_USUARIO_SISTEMA INT,
  MOTIVO VARCHAR(255),
  FECHA DATE,
  HORA_INICIO TIME,
  HORA_FIN TIME,
  ESTADO VARCHAR(3) DEFAULT 'ACT'
);

--NO IMPLEMENTADO AUN

-- Creación de la tabla USUARIOS_SISTEMA
CREATE TABLE USUARIOS_SISTEMA (
  ID_USUARIO_SISTEMA INT PRIMARY KEY IDENTITY(1,1),
  ID_FUNCIONARIO INT,
  CORREO VARCHAR(50),
  USUARIO VARCHAR(255), --UNIQUE,
  CONTRASENA VARCHAR(255),  
);

-- Creación de la tabla BITACORA
CREATE TABLE BITACORA (
  ID_BITACORA INT PRIMARY KEY IDENTITY(1,1),
  ID_USUARIO_SISTEMA INT,  
  FECHA_BITACORA DATETIME,
  ORIGEN VARCHAR(255),
  ACCION_REALIZADA VARCHAR(255),  
);

-- Creación de la tabla HISTORIAL_CLINICO
CREATE TABLE HISTORIAL_CLINICO (
  ID_HISTORIAL_CLINICO INT PRIMARY KEY IDENTITY(1,1),
  ID_PACIENTE INT,
  FECHA_HISTORIAL DATETIME,  
  OBSERVACIONES VARCHAR(1000) NULL,  
);

-- Creación de la tabla DIAGNOSTICOS
CREATE TABLE DIAGNOSTICOS (
  ID_DIAGNOSTICO INT PRIMARY KEY IDENTITY,
  DIAGNOSTICO VARCHAR(100),
  DESCRIPCION_DIAGNOSTICO VARCHAR(1000) NULL,
  INDICACIONES_DIAGNOSTICO VARCHAR(300) NULL, 
  FECHA_DIAGNOSTICO DATETIME,    
  ID_HISTORIAL_CLINICO INT,
  ID_CITA INT
);


-- Creación de la tabla MEDICAMENTOS
CREATE TABLE MEDICAMENTOS (
  ID_MEDICAMENTO INT PRIMARY KEY IDENTITY(1,1),
  ID_CITA INT,
  NOMBRE VARCHAR(50),  
  DOSIS VARCHAR(255)   
);

-- Creación de la tabla FACTURAS
CREATE TABLE FACTURAS (
  ID_FACTURA INT PRIMARY KEY IDENTITY(1,1),
  ID_CITA INT,
--ID_USUARIO_SISTEMA INT,
  FECHA DATETIME,  
  FORMA_DE_PAGO VARCHAR(20), --DEFAULT 'EFECTIVO',
  TOTAL DECIMAL(10, 2),
  IMPUESTO DECIMAL(10, 2),
  DESCUENTO DECIMAL(10, 2),  
  ESTADO VARCHAR(3) DEFAULT 'ACT'  
);

-- Creación de la tabla DETALLE_FACTURA
CREATE TABLE DETALLE_FACTURA (
  ID_DETALLE_FACTURA INT PRIMARY KEY IDENTITY(1,1),
  ID_FACTURA INT,
  CONCEPTO VARCHAR(255), -- DEFAULT 'PAGO DE CITA',
  CANTIDAD INT 
);


-- Creación de las foreign keys
ALTER TABLE FUNCIONARIOS ADD CONSTRAINT FK_FUNCIONARIOS_PUESTOS_DE_TRABAJO
  FOREIGN KEY (ID_PUESTO) REFERENCES PUESTOS_DE_TRABAJO(ID_PUESTO);

ALTER TABLE FUNCIONARIOS ADD CONSTRAINT FK_FUNCIONARIOS_ESPECIALIDADES
  FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES ESPECIALIDADES(ID_ESPECIALIDAD);

ALTER TABLE AGENDA ADD CONSTRAINT FK_AGENDA_FUNCIONARIOS
  FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIOS(ID_FUNCIONARIO);

ALTER TABLE CITAS
ADD CONSTRAINT FK_CITAS_PACIENTES
FOREIGN KEY (ID_PACIENTE) REFERENCES PACIENTES(ID_PACIENTE);

ALTER TABLE CITAS
ADD CONSTRAINT FK_CITAS_FUNCIONARIOS
FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIOS(ID_FUNCIONARIO);

ALTER TABLE USUARIOS_SISTEMA
ADD CONSTRAINT FK_USUARIOS_SISTEMA_FUNCIONARIO
FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIOS(ID_FUNCIONARIO);


-- Inserción de datos en la tabla PACIENTES
INSERT INTO PACIENTES (NOMBRE_PACIENTE, APELLIDOS_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE)
VALUES
  ('Juan', 'Pérez Gómez', '123456789', '12345678', 'juan@example.com', 'San José, Costa Rica', '1990-05-10'),
  ('María', 'López Torres', '987654321', '87654321', 'maria@example.com', 'Heredia, Costa Rica', '1985-12-15'),
  ('Carlos', 'González Soto', '456789123', '65432198', 'carlos@example.com', 'Alajuela, Costa Rica', '1988-09-20'),
  ('Ana', 'Ramírez Rodríguez', '789123456', '32198765', 'ana@example.com', 'Cartago, Costa Rica', '1992-07-05'),
  ('Luis', 'Fernández Chaves', '654321987', '98765432', 'luis@example.com', 'Puntarenas, Costa Rica', '1983-03-12'),
  ('Laura', 'Gutiérrez Mora', '654987321', '98765432', 'laura@example.com', 'Guanacaste, Costa Rica', '1991-08-25'),
  ('Pedro', 'Hernández Rodríguez', '258741369', '74136985', 'pedro@example.com', 'Limón, Costa Rica', '1987-04-18'),
  ('Sofía', 'Vargas López', '753951486', '36985214', 'sofia@example.com', 'San José, Costa Rica', '1995-11-02'),
  ('David', 'Castro Solano', '147852369', '25874136', 'david@example.com', 'Alajuela, Costa Rica', '1986-06-09'),
  ('Alejandra', 'Chacón Jiménez', '369258147', '95175382', 'alejandra@example.com', 'Cartago, Costa Rica', '1993-09-15');

-- Inserción de datos en la tabla PUESTOS_DE_TRABAJO
INSERT INTO PUESTOS_DE_TRABAJO (NOMBRE_PUESTO, DESCRIPCION_PUESTO)
VALUES
  ('Médico', 'Encargado de brindar atención médica y diagnóstico a los pacientes'),
  ('Administrativo', 'Responsable de las tareas administrativas y gestión de la clínica'),
  ('Recepcionista', 'Encargado/a de recibir y atender a los pacientes en la recepción'),
  ('Enfermero/a', 'Responsable de brindar atención y cuidados de enfermería a los pacientes'),
  ('Farmacéutico/a', 'Encargado/a de la gestión y dispensación de medicamentos'),
  ('Laboratorista', 'Realiza análisis de laboratorio para el diagnóstico médico'),
  ('Fisioterapeuta', 'Brinda terapias físicas y rehabilitación a los pacientes'),
  ('Psicólogo/a', 'Especialista en salud mental y terapias psicológicas');

-- Inserción de datos en la tabla ESPECIALIDADES
INSERT INTO ESPECIALIDADES (NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD)
VALUES
  ('Sin Especialidad', 'Empleado que no es del area de medicina'),
  ('Medicina General', 'Especialidad médica que se encarga del cuidado integral de la salud de los pacientes'),
  ('Pediatría', 'Especialidad médica que se enfoca en la atención y cuidado de los niños y adolescentes'),
  ('Ginecología', 'Especialidad médica que se ocupa de la salud del aparato reproductor femenino'),
  ('Dermatología', 'Especialidad médica enfocada en enfermedades de la piel'),
  ('Oftalmología', 'Especialidad médica dedicada al estudio y tratamiento de los trastornos oculares'),
  ('Cardiología', 'Especialidad médica que se ocupa de los trastornos del corazón y el sistema circulatorio'),
  ('Neurología', 'Especialidad médica que se encarga de los trastornos del sistema nervioso'),
  ('Endocrinología', 'Especialidad médica que se enfoca en los trastornos hormonales');

-- Inserción de datos en la tabla FUNCIONARIOS
--DELETE FUNCIONARIOS
INSERT INTO FUNCIONARIOS (ID_PUESTO, ID_ESPECIALIDAD, NOMBRE_FUNCIONARIO, APELLIDOS_FUNCIONARIO, CEDULA_FUNCIONARIO, TELEFONO_FUNCIONARIO, CORREO_FUNCIONARIO, DIRECCION_FUNCIONARIO, FECHA_NACIMIENTO_FUNCIONARIO)
VALUES
  (2, 1, 'Juana', 'Gonzales', '123456777', '12345777', 'juana@example.com', 'San José', '1990-05-15'),
  (1, 2, 'Juan', 'Pérez', '123456789', '12345678', 'juan@example.com', 'San José', '1990-05-10'),
  (1, 2, 'María', 'López', '987654321', '87654321', 'maria@example.com', 'Heredia', '1985-12-15'),
  (1, 3, 'Carlos', 'González', '456789123', '65432198', 'carlos@example.com', 'Alajuela', '1988-09-20'),
  (1, 1, 'Ana', 'Ramírez', '789123456', '32198765', 'ana@example.com', 'Cartago', '1992-07-05'),
  (1, 2, 'Luis', 'Fernández', '654321987', '98765432', 'luis@example.com', 'Puntarenas', '1983-03-12'),
  (2, 1, 'Fernando', 'Navarro', '369852147', '25874136', 'fernando@example.com', 'San José', '1989-07-12'),
  (3, 2, 'Carolina', 'Sánchez', '456789123', '65432198', 'carolina@example.com', 'Heredia', '1992-01-28'),
  (4, 3, 'Jorge', 'Campos', '789123456', '32198765', 'jorge@example.com', 'Cartago', '1987-03-08'),
  (5, 4, 'Mariana', 'Morales', '654321987', '98765432', 'mariana@example.com', 'Alajuela', '1994-10-05'),
  (2, 1, 'Jose Joaquin', 'Campos Chaves', '206730045', '88990849', 'joacachavez20@gmail.com', 'Alajuela,Naranjo,Palmitos', '1990-04-20'),
  (1, 5, 'Alejandro', 'Vega', '987654321', '87654321', 'alejandro@example.com', 'Puntarenas', '1984-12-30');

-- Inserción de datos en la tabla AGENDA_TRABAJO
INSERT INTO AGENDA (ID_FUNCIONARIO, FECHA, HORA_INICIO, HORA_FIN)
VALUES
  (2, '2023-06-20', '08:00:00', '12:00:00'),
  (2, '2023-06-21', '14:00:00', '18:00:00'),
  (2, '2023-06-22', '09:00:00', '13:00:00'),
  (3, '2023-06-23', '10:00:00', '14:00:00'),
  (4, '2023-06-24', '13:00:00', '17:00:00'),
  (5, '2023-06-25', '08:30:00', '12:30:00'),
  (2, '2023-06-26', '15:00:00', '19:00:00'),
  (1, '2023-06-27', '09:30:00', '13:30:00');

-- Insertar datos de ejemplo en la tabla CITAS
INSERT INTO CITAS (ID_PACIENTE, ID_FUNCIONARIO, MOTIVO, FECHA, HORA_INICIO, HORA_FIN)
VALUES
  (1, 2, 'Consulta médica', '2023-06-20', '09:00:00', '09:30:00'),
  (2, 1, 'Examen de rutina', '2023-06-21', '14:30:00', '15:00:00'),
  (3, 3, 'Control prenatal', '2023-06-22', '10:00:00', '10:30:00'),
  (4, 5, 'Terapia de rehabilitación', '2023-06-23', '11:00:00', '11:30:00'),
  (3, 3, 'Control cardiológico', '2023-06-24', '14:30:00', '15:00:00'),
  (5, 4, 'Consulta neurológica', '2023-06-25', '10:30:00', '11:00:00'),
  (2, 2, 'Examen oftalmológico', '2023-06-26', '15:30:00', '16:00:00'),
  (1, 1, 'Terapia psicológica', '2023-06-27', '10:30:00', '11:30:00');

INSERT INTO USUARIOS_SISTEMA (ID_FUNCIONARIO,CORREO,USUARIO,CONTRASENA)
VALUES
	(11,'joacachavez20@gmail.com','admin','admin');

-- Verificación de los datos insertados en la tabla PACIENTES
SELECT * FROM PACIENTES;

-- Verificación de los datos insertados en la tabla FUNCIONARIOS
SELECT * FROM FUNCIONARIOS;

-- Verificación de los datos insertados en la tabla PUESTOS_DE_TRABAJO
SELECT * FROM PUESTOS_DE_TRABAJO;

-- Verificación de los datos insertados en la tabla ESPECIALIDADES
SELECT * FROM ESPECIALIDADES;

-- Verificación de los datos insertados en la tabla AGENDA_TRABAJO
SELECT * FROM AGENDA;

-- Verificación de los datos insertados en la tabla CITAS
SELECT * FROM CITAS;

SELECT * FROM USUARIOS_SISTEMA;


--SELECT E.NOMBRE_ESPECIALIDAD,F.ID_FUNCIONARIO, F.NOMBRE_FUNCIONARIO, F.APELLIDOS_FUNCIONARIO 
--FROM FUNCIONARIOS F

--INNER JOIN ESPECIALIDADES E ON F.ID_ESPECIALIDAD = E.ID_ESPECIALIDAD
--WHERE E.ID_ESPECIALIDAD != 1;





