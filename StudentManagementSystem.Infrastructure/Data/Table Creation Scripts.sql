
CREATE TABLE Student
(
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    EmailAddress NVARCHAR(100) NOT NULL,
    IdNumber INT NOT NULL,
    ContactNumber NVARCHAR(100) NOT NULL,
    [Address] NVARCHAR(100) NOT NULL, --Move to its own table
	PreferredContactMethod NVARCHAR(100) NOT NULL, --move to its own table
	ProfileImage VARBINARY(MAX) NOT NULL --pending
	
)

CREATE TABLE Enrolment
(
	EnrolmentId INT PRIMARY KEY IDENTITY(1,1),
	Institution NVARCHAR(100) NOT NULL, --Move to its own table
	Qualification NVARCHAR(100) NOT NULL,
	QualificationType NVARCHAR(100) NOT NULL, --Move to its own table
	DateRegistered DATETIME NOT NULL,
	GraduationDate DATETIME NOT NULL,
	AverageToDate INT NOT NULL,
	StudentId INT NOT NULL,
	FOREIGN KEY (StudentId) REFERENCES Student(StudentId)
)

