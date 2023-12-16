SELECT * FROM sampleTable;

INSERT INTO sampleTable (FirstName, StudentId) VALUES ('EYA', 3);
UPDATE sampleTable SET FirstName = 'lala', MiddleName = 'eya', LastName = 'grey' WHERE StudentId = 3;
DELETE FROM sampleTable WHERE StudentId = 2;

SELECT FirstName, LastName FROM sampleTable WHERE StudentId=1;