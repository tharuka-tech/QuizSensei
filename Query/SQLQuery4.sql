CREATE TABLE studentAnswers (
    id INT PRIMARY KEY IDENTITY(1,1),
    studentId NVARCHAR(10) NOT NULL,
    qSet NVARCHAR(50) NOT NULL,
    teacherId NVARCHAR(10) NOT NULL,
    question NVARCHAR(MAX) NOT NULL,
    studentAnswer NVARCHAR(100) NOT NULL,
    correctAnswer NVARCHAR(100) NOT NULL,
    result NVARCHAR(10) NOT NULL,
    numberOfCorrectAnswers INT NOT NULL
);

select*from studentAnswers;


select*from questions;

select*from Students;




SELECT studentId, qSet, question, correctAnswer, result FROM studentAnswers WHERE studentId ='UGC0122031' AND qSet = '1-koisumi';





SELECT studentId, qSet, numberOfCorrectAnswers
FROM studentAnswers
WHERE teacherId = 'JPN2'
AND id IN (
		SELECT MAX(id)
        FROM studentAnswers
        WHERE teacherId = 'JPN2'
        GROUP BY studentId, qSet
 )
 AND numberOfCorrectAnswers IS NOT NULL;

		
		
		





