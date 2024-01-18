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

--drop table specialties
--drop table doctors