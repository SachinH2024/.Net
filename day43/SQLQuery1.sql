CREATE TABLE Appuser (
    userid VARCHAR(50) PRIMARY KEY, 
    password VARCHAR(50) NOT NULL,
);

INSERT INTO Appuser (userid, password) VALUES ('testuser', 'password123');

select * from Appuser