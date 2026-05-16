CREATE TABLE eemployees (
    EmployeeID   INT IDENTITY(1,1) PRIMARY KEY,  
    FirstName    NVARCHAR(50) NOT NULL,         
    LastName     NVARCHAR(50) NOT NULL,         
    Email        NVARCHAR(100) UNIQUE,          
    PhoneNumber  VARCHAR(20) NULL,             
    Department   VARCHAR(50) NOT NULL,         
    Salary       DECIMAL(10,2), 
    BirthDate    DATE NOT NULL,  -- Added to support Age computation
    Age          AS DATEDIFF(YEAR, BirthDate, GETDATE())  
);


INSERT INTO eemployees (FirstName, LastName, Email, PhoneNumber, Department, Salary, BirthDate)
VALUES
('John', 'Doe', 'johndoe@email.com', '123-456-7890', 'IT', 60000.00, '1990-05-15'),
('Jane', 'Smith', 'janesmith@email.com', '987-654-3210', 'HR', 55000.00, '1988-09-22'),
('Michael', 'Johnson', 'michaelj@email.com', '456-789-1234', 'Finance', 70000.00, '1985-07-10'),
('Emily', 'Brown', 'emilyb@email.com', '321-654-9870', 'Marketing', 50000.00, '1993-03-18'),
('Daniel', 'White', 'danielw@email.com', '789-123-4567', 'IT', 75000.00, '1980-11-30'),
('Sarah', 'Miller', 'sarahm@email.com', '159-357-4862', 'Sales', 65000.00, '1995-06-25'),
('David', 'Wilson', 'davidw@email.com', '852-963-7410', 'Finance', 72000.00, '1983-12-05'),
('Olivia', 'Anderson', 'oliviaa@email.com', '951-753-8524', 'HR', 57000.00, '1992-04-08'),
('James', 'Thomas', 'jamest@email.com', '357-159-4862', 'Marketing', 48000.00, '1997-01-14'),
('Sophia', 'Martinez', 'sophiam@email.com', '852-456-1597', 'Sales', 68000.00, '1986-08-20'),

-- Add 40 more rows with diverse names and departments
('Ethan', 'Garcia', 'ethang@email.com', '963-741-8520', 'IT', 73000.00, '1991-02-28'),
('Isabella', 'Rodriguez', 'isabellar@email.com', '741-852-9630', 'HR', 54000.00, '1989-10-12'),
('Mason', 'Martinez', 'masonm@email.com', '159-753-4862', 'Finance', 71000.00, '1984-07-07'),
('Mia', 'Hernandez', 'miah@email.com', '753-159-4862', 'Marketing', 52000.00, '1996-05-03'),
('Alexander', 'Lopez', 'alexl@email.com', '123-852-4567', 'Sales', 69000.00, '1987-09-15'),
('Charlotte', 'Gonzalez', 'charlotteg@email.com', '852-963-1597', 'IT', 77000.00, '1982-06-22'),
('Benjamin', 'Perez', 'benjaminp@email.com', '963-159-7530', 'HR', 56000.00, '1994-11-09'),
('Amelia', 'Taylor', 'ameliat@email.com', '741-123-8524', 'Finance', 74000.00, '1981-03-30'),
('Lucas', 'Torres', 'lucast@email.com', '951-852-1597', 'Marketing', 49000.00, '1998-12-14'),
('Harper', 'Nguyen', 'harpern@email.com', '357-486-1597', 'Sales', 67000.00, '1985-08-01'),

('William', 'Rivera', 'williamr@email.com', '789-654-3210', 'IT', 76000.00, '1990-07-21'),
('Ella', 'Clark', 'ellac@email.com', '654-789-1230', 'HR', 53000.00, '1989-05-18'),
('Henry', 'Lewis', 'henryl@email.com', '321-456-9870', 'Finance', 73000.00, '1983-01-10'),
('Ava', 'Robinson', 'avar@email.com', '789-321-6540', 'Marketing', 51000.00, '1997-06-12'),
('Jack', 'Walker', 'jackw@email.com', '951-357-1597', 'Sales', 66000.00, '1986-10-24'),
('Lucas', 'Hall', 'lucash@email.com', '654-321-7890', 'IT', 78000.00, '1981-04-03'),
('Evelyn', 'Allen', 'evelyna@email.com', '123-789-6540', 'HR', 58000.00, '1995-08-27'),
('Sebastian', 'Young', 'sebastiany@email.com', '852-357-1230', 'Finance', 72000.00, '1982-11-08'),
('Chloe', 'King', 'chloek@email.com', '789-654-1597', 'Marketing', 49500.00, '1998-09-02'),
('Dylan', 'Wright', 'dylanw@email.com', '321-852-4567', 'Sales', 69000.00, '1987-03-19'),

('Grace', 'Scott', 'graces@email.com', '753-159-8520', 'IT', 77000.00, '1991-06-14'),
('Nathan', 'Green', 'nathang@email.com', '456-123-7890', 'HR', 55000.00, '1989-12-22'),
('Zoey', 'Adams', 'zoeya@email.com', '159-357-8520', 'Finance', 73500.00, '1984-09-30'),
('Liam', 'Baker', 'liamb@email.com', '741-963-2580', 'Marketing', 50500.00, '1996-07-25'),
('Scarlett', 'Nelson', 'scarlettn@email.com', '852-951-7530', 'Sales', 67500.00, '1985-04-17'),
('Owen', 'Carter', 'owenc@email.com', '789-357-8520', 'IT', 76500.00, '1980-02-14'),
('Madison', 'Mitchell', 'madisonm@email.com', '963-852-1597', 'HR', 56500.00, '1993-11-01'),
('Eli', 'Perez', 'elip@email.com', '753-741-8520', 'Finance', 72500.00, '1981-08-05'),
('Victoria', 'Evans', 'victoriae@email.com', '951-753-1597', 'Marketing', 52000.00, '1998-01-20'),
('Leo', 'Collins', 'leoc@email.com', '357-456-8520', 'Sales', 70000.00, '1986-05-10');


select * from eemployees

----------------------------------------------

Select Department , count(*) as ECount

from eemployees
group by Department
having count(*) > 8


-----------------------------------------------


Select Department , AVG(Salary) as OrtacaOylik
from eemployees
group by Department



-------------------------------------------------


Select count(*)
from eemployees
where Age > 30 

--------------------------------------------------

SELECT AVG(Salary) AS AvgSalary
FROM eemployees
WHERE Age > 30;












