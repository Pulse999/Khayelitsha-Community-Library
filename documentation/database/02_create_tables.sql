-- ============================================================================
-- Khayelitsha Community Library Database
-- ============================================================================

-- Create Member Table

-- CREATE TABLE Member (
--     MemberID SERIAL PRIMARY KEY,
--     FirstName VARCHAR(50) NOT NULL,
--     LastName VARCHAR(50) NOT NULL,
--     Email VARCHAR(100) NOT NULL UNIQUE,
--     Age INTEGER NOT NULL,
--     Gender VARCHAR(20) NOT NULL,
--     Address VARCHAR(255) NOT NULL,
--     PhoneNumber VARCHAR(10) NOT NULL,
--     JoinDate DATE NOT NULL,

--     CONSTRAINT chk_member_age
--         CHECK (Age >= 8 AND Age <= 65),

--     CONSTRAINT chk_member_gender
--         CHECK (
--             Gender IN (
--                 'Male',
--                 'Female',
--                 'Other',
--                 'Prefer not to say'
--             )
--         )
-- );

-- Create BookTitle Table

-- CREATE TABLE BookTitle (
--     BookTitleID SERIAL PRIMARY KEY,
--     Title VARCHAR(200) NOT NULL,
--     Author VARCHAR(100) NOT NULL,
--     ISBN VARCHAR(20) NOT NULL UNIQUE,
--     Category VARCHAR(50) NOT NULL
-- );

-- Create Staff Table 

-- CREATE TABLE Staff (
--     StaffID SERIAL PRIMARY KEY,
--     FirstName VARCHAR(50) NOT NULL,
--     LastName VARCHAR(50) NOT NULL,
--     PhoneNumber VARCHAR(10) NOT NULL,
--     Email VARCHAR(100) NOT NULL UNIQUE
-- );

-- Create BookCopy Table

-- CREATE TABLE BookCopy (
--     CopyID SERIAL PRIMARY KEY,
--     BookTitleID INTEGER NOT NULL,
--     Status VARCHAR(20) NOT NULL,

--     CONSTRAINT fk_bookcopy_booktitle
--         FOREIGN KEY (BookTitleID)
--         REFERENCES BookTitle(BookTitleID),

--     CONSTRAINT chk_bookcopy_status
--         CHECK (
--             Status IN (
--                 'Available',
--                 'On Loan',
--                 'Lost',
--                 'Damaged'
--             )
--         )
-- );

-- Create Loan Table

-- CREATE TABLE Loan (
--     LoanID SERIAL PRIMARY KEY,

--     MemberID INTEGER NOT NULL,
--     CopyID INTEGER NOT NULL,
--     StaffID INTEGER NOT NULL,

--     LoanDate DATE NOT NULL,
--     DueDate DATE NOT NULL,
--     ReturnDate DATE NULL,

--     CONSTRAINT fk_loan_member
--         FOREIGN KEY (MemberID)
--         REFERENCES Member(MemberID),

--     CONSTRAINT fk_loan_copy
--         FOREIGN KEY (CopyID)
--         REFERENCES BookCopy(CopyID),

--     CONSTRAINT fk_loan_staff
--         FOREIGN KEY (StaffID)
--         REFERENCES Staff(StaffID),

--     CONSTRAINT chk_loan_dates
--         CHECK (DueDate >= LoanDate)
-- );






























