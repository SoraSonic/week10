CREATE DATABASE QUESTION

USE QUESTION

CREATE TABLE QUESTIONS(
	STT_CAU_HOI INT PRIMARY KEY,
	
);

CREATE TABLE ANSWERS(
	DAP_AN NVARCHAR NOT NULL,
	STT_CAU_HOI INT FOREIGN KEY REFERENCES QUESTIONS(STT_CAU_HOI)
);

ALTER TABLE QUESTIONS
ADD DAP_AN_D NVARCHAR(50)
ALTER COLUMN QUESTION_CONTENT NVARCHAR(50)

