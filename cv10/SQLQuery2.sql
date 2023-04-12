SELECT firstname as [First name], secondname as [Second name], born_date as [Born], shortcut, subject_name as [Name of subject] FROM Students st LEFT JOIN
Student_subject ss ON st.studentID = ss.studentID LEFT JOIN Subjects sb ON sb.subjectID = ss.subjectId


SELECT secondname as [Second name] , count(secondname) as ocurencies FROM Students GROUP BY secondname


SELECT subject_name as [Name of subject], count(Student_subject.subjectId) as ocurencies 
FROM Student_subject 
LEFT JOIN Subjects st ON Student_subject.subjectId = st.subjectID 
GROUP BY subject_name HAVING COUNT(Student_subject.studentID) < 3

SELECT subject_name as [Name of subject], MIN(NULLIF(mark,0)) as [Best mark], MAX(mark) as [Worst mark], 
CAST(AVG(CAST(NULLIF(mark,0) AS DECIMAL(10,2))) AS DECIMAL(10,2)) as [Average mark],
count(NULLIF(mark,0)) as [Number of marked students]
FROM Student_subject 
LEFT JOIN Subjects st ON Student_subject.subjectId = st.subjectID
GROUP BY subject_name
