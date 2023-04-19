DROP Table IF EXISTS Trainees;

CREATE TABLE Trainees(
	TraineeID int,
	FirstName VARCHAR(20),
	Age int
)

INSERT INTO Trainees 
VALUES (1, 'Alex', 23), (2, 'Bea', 20), (3, 'Crash', 19)