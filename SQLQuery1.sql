Create table Users(

	UserId BIGINT IDENTITY(1,1) PRIMARY KEY,
	UserName NVARCHAR (50) UNIQUE NOT NULL,
	Email NVARCHAR(100) UNIQUE NOT NULL,
	Age INT CHECK(Age >= 18),
	Country NVARCHAR (50) DEFAULT 'Uzbekistan' 
)

INSERT INTO Users (Username, Email, Age, Country)  
VALUES  
('john_doe', 'john@example.com', 25, 'USA'),  
('alice_smith', 'alice@example.com', 30, 'UK'),  
('bekzod_92', 'bekzod@example.com', 22, DEFAULT),  
('sara_k', 'sara@example.com', 28, 'CAN');  





select * from Users