--* CREACIÓN DE TABLAS
CREATE TABLE Users(
    idUser INT PRIMARY KEY AUTO_INCREMENT,
    userName VARCHAR(255),
    firstName VARCHAR(255),
    lastName VARCHAR(255),
    level VARCHAR(3),
    password varchar(10)
);

CREATE TABLE Sensores(
    idSensor INT PRIMARY KEY,
    temperatura VARCHAR(255),
    dateRegistered TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    stateSensor BOOLEAN
);

--! CREACIÓN DE CRUD
--*Validar usuarios
