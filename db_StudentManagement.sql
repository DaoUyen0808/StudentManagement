CREATE DATABASE Student_Management;
USE Student_Management;

CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY AUTO_INCREMENT,
    SubjectName NVARCHAR(100) NOT NULL,
    Description TEXT,
    IsDeleted BOOLEAN DEFAULT FALSE
);

CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY AUTO_INCREMENT,
    FullName NVARCHAR(100) NOT NULL,
    SubjectID INT,
    PhoneNumber VARCHAR(10),
    IsDeleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

CREATE TABLE Classes (
    ClassID INT PRIMARY KEY AUTO_INCREMENT,
    ClassName VARCHAR(10) NOT NULL,
    TeacherID INT,
    IsDeleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

CREATE TABLE Students (
    StudentID INT PRIMARY KEY AUTO_INCREMENT,
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender BOOLEAN NOT NULL,
    Address NVARCHAR(100),
    PhoneNumber VARCHAR(10),
    Email VARCHAR(50) UNIQUE,
    ClassID INT,
    IsDeleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

CREATE TABLE Grades (
    GradeID INT PRIMARY KEY AUTO_INCREMENT,
    StudentID INT,
    SubjectID INT,
    Semester ENUM('1', '2'),
    Grade DECIMAL(3, 2),
    IsDeleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

-- Thêm dữ liệu vào các bảng
INSERT INTO Subjects (SubjectName, Description) VALUES 
    ('Toán', 'Môn học về số học và đại số'),
    ('Văn', 'Môn học về ngôn ngữ và văn chương'),
    ('Tiếng Anh', 'Môn học về ngôn ngữ Anh và giao tiếp');

INSERT INTO Teachers (FullName, SubjectID, PhoneNumber) VALUES 
    ('Nguyễn Phan Thành Công', 1, '0123456789'),
    ('Nguyễn Thị Huyền Trang', 2, '0987654321'),
    ('Hoàng Thị Vân', 3, '0112233445');

INSERT INTO Classes (ClassName, TeacherID) VALUES 
    ('6A', 1),
    ('7B', 2),
    ('8C', 3);

INSERT INTO Students (FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, ClassID) VALUES 
    ('Nguyễn Thị Thùy Trang', '2002-04-01', 1, '123 Đường A', '0123456789', 'an.nguyen@example.com', 1),
    ('Vũ Thị Hải Yến', '2002-05-02', 1, '456 Đường B', '0987654321', 'binh.tran@example.com', 2),
    ('Tô Thị Anh', '2002-06-03', 1, '789 Đường C', '0112233445', 'cuong.le@example.com', 3);

INSERT INTO Grades (StudentID, SubjectID, Semester, Grade) VALUES 
    (1, 1, '1', 8.50),
    (2, 2, '1', 9.00),
    (3, 3, '2', 7.75);
