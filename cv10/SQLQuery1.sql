DBCC CHECKIDENT([Students],RESEED, 0)
SELECT * FROM [Students]
INSERT INTO Students VALUES ('Jan', 'Kozoroh', '2002-01-19')
INSERT INTO Students VALUES ('Eva', 'Vodnarova', '2003-02-09')
INSERT INTO Students VALUES ('Dan', 'Ryba', '2000-03-01')
INSERT INTO Students VALUES ('Lukas', 'Beran', '2006-04-25')
INSERT INTO Students VALUES ('Alena', 'Bycivarle', '2008-05-15')
INSERT INTO Students VALUES ('Pavel', 'Strelec', '2001-12-07')


DBCC CHECKIDENT([Subjects],RESEED, 0)
SELECT * FROM Subjects
INSERT INTO Subjects VALUES ('BPC-OOP', 'Object-Oriented Programming')
INSERT INTO Subjects VALUES ('BPC-MA3', 'Mathematics 2')
INSERT INTO Subjects VALUES ('BPC-PC2T', 'Computers and Programming 2')



SELECT * FROM Student_subject
INSERT INTO Student_subject VALUES (0,1, '2021-04-14', 1)
INSERT INTO Student_subject VALUES (1,1, '2021-04-14', 3)
INSERT INTO Student_subject VALUES (3,1, '2021-04-14', 5)

INSERT INTO Student_subject VALUES (2,2, '2022-04-14', 1)
INSERT INTO Student_subject VALUES (3,2, '2022-04-14', 2)
INSERT INTO Student_subject VALUES (4,2, '2022-04-14', 3)
INSERT INTO Student_subject VALUES (5,2, '2022-04-14', 4)

INSERT INTO Student_subject VALUES (4,3, '2023-04-14', 2)
INSERT INTO Student_subject VALUES (5,3, '2023-04-14', 6)

