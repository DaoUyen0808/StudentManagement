create database Student_Management;
use Student_Management;

create table Subjects(
SubjectID int primary key AUTO_INCREMENT,
SubjectName nvarchar(100) not null,
Description text
);

create table Teachers(
TeacherID int primary key AUTO_INCREMENT,
FullName nvarchar(100) not null,
SubjectID int,
PhoneNumber varchar(10),
foreign key(SubjectID) references Subjects(SubjectID)
);

create table Classes(
ClassID int primary key AUTO_INCREMENT,
ClassName varchar(10) not null,
TeacherID int,
foreign key(TeacherID) references Teachers(TeacherID)
);

create table Students(
StudentID int primary key auto_increment,
FullName nvarchar(100) not null,
DateOfBirth  date not null,
Gender boolean not null,
Address nvarchar(100),
PhoneNumber varchar(10),
Email varchar(50) unique,
ClassID int ,
foreign key(ClassID) references Classes(ClassID)
);

create table Grades(
GradeID int primary key auto_increment,
StudentID int,
SubjectID int,
/*Semester : học kỳ 1-2*/
Semester enum('1','2'),
/*Khai báo DECIMAL(3, 2) phù hợp cho điểm số vì nó cho phép lưu trữ một giá trị nhỏ với độ chính xác cao, chẳng hạn như 8.50 hoặc 9.75.*/
Grade decimal(3,2),
foreign key(StudentID) references Students(StudentID),
foreign key(SubjectID) references Subjects(SubjectID)
);

INSERT INTO Subjects (SubjectName, Description) VALUES 
('Toán','ôn học về số học và đại số'),
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


