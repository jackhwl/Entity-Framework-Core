USE TestData;
 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED; 

BEGIN TRANSACTION; 

SELECT ID, TestValue  FROM TestItems WHERE Id=1;

COMMIT TRANSACTION;