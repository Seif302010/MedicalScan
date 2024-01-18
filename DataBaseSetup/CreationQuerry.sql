CREATE DATABASE medical_scan
  ON 
  (NAME = YourDataFileName, FILENAME = 'D:\dotnet_projects\DataBases\medical_scanmedical_scan.mdf', SIZE = 8MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
  LOG ON 
  (NAME = YourLogFileName, FILENAME = 'D:\dotnet_projects\DataBases\medical_scanmedical_scan.ldf', SIZE = 8MB, MAXSIZE = UNLIMITED, FILEGROWTH = 5MB);

use medical_scan
create table doctors (
	ID int primary key IDENTITY(1,1),
	[Name] varchar(50) unique NOT NULL
)

create table specialities (
	ID int primary key IDENTITY(1,1),
	Code varchar(50) unique NOT NULL,
	[Name] varchar(50) unique NOT NULL
)

create table doctors_specialities (
	DoctorID int NOT NULL,
	SpecialityID int NOT NULL,
	PRIMARY KEY (DoctorID, SpecialityID),
    FOREIGN KEY (DoctorID) REFERENCES doctors(ID),
    FOREIGN KEY (SpecialityID) REFERENCES specialities(ID)
)

INSERT INTO doctors ([Name]) VALUES
('Dr. Gipsz Jakab'),
('Dr. Teszt Elek'),
('Dr. Kedvező Áron'),
('Dr. Gipsz Elek'),
('Dr. Doktor Doloróza');

INSERT INTO specialities (Code, [Name]) VALUES
('GP', 'Háziorvos'),
('INT', 'Belgyógyász'),
('CAR', 'Kardiológus'),
('SEB', 'Sebész'),
('DER', 'Bőrgyógyász');

INSERT INTO doctors_specialities (DoctorID, SpecialityID) VALUES
(1, 1),
(1, 2),
(2, 5),
(3, 2),
(3, 4),
(4, 3),
(5, 2),
(5, 5);

--drop table doctors_specialities
--drop table specialties
--drop table doctors
--drop database medical_scan