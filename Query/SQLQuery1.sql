create database quizDB;

CREATE TABLE questions (
    id INT IDENTITY(1,1) PRIMARY KEY,
    qSet VARCHAR(10) NOT NULL,
    qNo INT,
    question VARCHAR(350) NOT NULL,
    optionA VARCHAR(250) NOT NULL,
    optionB VARCHAR(250) NOT NULL,
    optionC VARCHAR(250) NOT NULL,
    optionD VARCHAR(250) NOT NULL,
    answer VARCHAR(250) NOT NULL
);

INSERT INTO questions (qSet, qNo, question, optionA, optionB, optionC, optionD, answer) VALUES
('Set1', 1, 'What is the capital of France?', 'Berlin', 'Madrid', 'Paris', 'Rome', 'Paris'),
('Set1', 2, 'What is the largest planet in our solar system?', 'Earth', 'Mars', 'Jupiter', 'Saturn', 'Jupiter'),
('Set1', 3, 'Who wrote "To Kill a Mockingbird"?', 'Harper Lee', 'J.K. Rowling', 'Mark Twain', 'Jane Austen', 'Harper Lee'),
('Set1', 4, 'What is the chemical symbol for water?', 'H2O', 'O2', 'CO2', 'NaCl', 'H2O'),
('Set1', 5, 'Which element has the atomic number 1?', 'Oxygen', 'Hydrogen', 'Carbon', 'Nitrogen', 'Hydrogen');

select* from questions;