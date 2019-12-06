
Use [UsersAndRewards]
Go
CREATE PROCEDURE GetUsers
As
	RETURN SELECT idUser, FirstName, LastName, Birthdate
		FROM Users
Go
CREATE PROCEDURE GetUserByID(@id int)
As
	RETURN SELECT idUser, FirstName, LastName, Birthdate
		FROM Users
			WHERE idUser = @id
Go

CREATE PROCEDURE AddUser(
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Birthdate datetime)
As
	--DECLARE @insertedUsers TABLE (idUser int);
	INSERT INTO Users(FirstName, LastName, Birthdate)
		--OUTPUT INSERTED.ID INTO @insertedUsers(UserId)
			VALUES(@FirstName, @LastName, @Birthdate)
	--RETURN SELECT idUser FROM @insertedUsers

Go

CREATE PROCEDURE DeleteUser(@idUser int)
As
	DELETE FROM Users WHERE idUser = @idUser;
Go

CREATE PROCEDURE UpdatePersonByID(@idUser int, @newFirstName nvarchar(50), @newLastName nvarchar(50), @newBirthdate datetime)
AS
  UPDATE Users
   SET FirstName = @newFirstName, LastName=@newLastName, Birthdate = @newBirthdate
   WHERE idUser = @idUser
GO

CREATE PROCEDURE GetRewards
As
	RETURN SELECT idReward, Title, Description
		FROM Rewards
Go

CREATE PROCEDURE AddReward (@idReward int, @Title nvarchar(50), @Description nvarchar(50))
As
	INSERT INTO Rewards
		 VALUES (@idReward, @Title, @Description);
Go

CREATE PROCEDURE DeleteAward(@idReward int)
AS
  DELETE FROM UsersAndRewards WHERE idReward = @idReward
   DELETE FROM Rewards WHERE idReward = @idReward
GO

CREATE PROCEDURE GetAwardsForPerson(@idUser int)
AS
	RETURN SELECT Rewards.*
			FROM UsersAndRewards INNER JOIN Rewards ON Rewards.idReward = UsersAndRewards.idReward
			WHERE idUser = @idUser;
GO
