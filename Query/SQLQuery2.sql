select*from Students;
select*from questions;

ALTER TABLE questions
ADD subject varchar(10);

ALTER TABLE questions
ADD teacherId varchar(10);

select qSet from questions where subject ='N1';
select qSet from questions where subject ='N2';
select qSet from questions where subject ='N3';
select qSet from questions where subject ='N4';
select qSet from questions where subject ='N5';



SELECT qNo, question, optionA, optionB, optionC, optionD, answer
FROM questions
WHERE qSet = '1-Maleesha' AND qNo = 1;

SELECT qNo, question, optionA, optionB, optionC, optionD, answer
FROM questions
WHERE qSet = '1-Maleesha' AND qNo = 2;