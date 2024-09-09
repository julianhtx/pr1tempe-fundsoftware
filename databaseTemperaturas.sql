--db: practicatemperatura

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
DROP PROCEDURE IF EXISTS p_ValidarUsuario;
CREATE PROCEDURE p_ValidarUsuario(
    IN _userName VARCHAR(255),
    IN _password VARCHAR(255)
)
BEGIN
    DECLARE x INT;
	SELECT COUNT(*) FROM Users WHERE userName = _userName AND Password = _password INTO x;
	if x > 0 then
		SELECT 'Correcto' AS rs, (SELECT level FROM Users WHERE userName = _userName) AS Nivel;
	ELSE
		SELECT 'Error' AS rs, 0 AS Nivel;
	END if;
END;

INSERT INTO Users ( userName, firstName, lastName, level, password ) VALUES(
     'User1', 'Julian', 'Hernandez', '1', sha1('2004')
),
(
     'User2', 'Luis', 'Trejo', '2', sha1('2004')
),
(
     'User3', 'Juan', 'Perez', '3', sha1('1234')
);

create view v_Users AS select idUser, userName, password, firstName, lastName, level from Users;
