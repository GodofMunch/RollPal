DROP TABLE PAY_MULTIPLIERS;
DROP TABLE PRSI;
DROP TABLE PAYE;
DROP TABLE USC;
DROP TABLE SIPTU;
DROP TABLE RATE;
DROP TABLE TAXATION;
DROP TABLE STAFF_PAID;
DROP TABLE CONTACT;
DROP TABLE BANKING;
DROP TABLE STAFF;

CREATE TABLE STAFF
(StaffId numeric(3),
Forename varchar2(20) NOT NULL,
Surname varchar2(20) NOT NULL,
DateOfBirth Date NOT NULL,
Gender char(1) NOT NULL,
MaritalStatus char(1) NOT NULL,
Children numeric(2) NOT NULL,
Active char(1) NOT NULL,
PayGrade char(1) NOT NULL,
CONSTRAINT pk_Staff PRIMARY KEY(StaffId));

CREATE TABLE CONTACT
(StaffId numeric(3),
Email varchar(30) NOT NULL,
Phone varchar2(10) NOT NULL,
Street char(20) NOT NULL,
Town char(20) NOT NULL,
County char(20),
Eircode char(7),
CONSTRAINT pk_Contact PRIMARY KEY(StaffId),
CONSTRAINT fk_Contact_Staff FOREIGN KEY (StaffId) REFERENCES Staff(StaffId));

CREATE TABLE BANKING
(StaffId numeric(3),
Iban varchar2(34) UNIQUE NOT NULL,
CONSTRAINT pk_Banking PRIMARY KEY (StaffId),
CONSTRAINT fk_Banking_Staff FOREIGN KEY (StaffId) REFERENCES Staff(StaffId));

CREATE TABLE STAFF_PAID(
STAFFID NUMERIC(3),
WEEK1 CHAR(1),
WEEK2 CHAR(1),
WEEK3 CHAR(1),
WEEK4 CHAR(1),
WEEK5 CHAR(1),
WEEK6 CHAR(1),
WEEK7 CHAR(1),
WEEK8 CHAR(1),
WEEK9 CHAR(1),
WEEK10 CHAR(1),
WEEK11 CHAR(1),
WEEK12 CHAR(1),
WEEK13 CHAR(1),
WEEK14 CHAR(1),
WEEK15 CHAR(1),
WEEK16 CHAR(1),
WEEK17 CHAR(1),
WEEK18 CHAR(1),
WEEK19 CHAR(1),
WEEK20 CHAR(1),
WEEK21 CHAR(1),
WEEK22 CHAR(1),
WEEK23 CHAR(1),
WEEK24 CHAR(1),
WEEK25 CHAR(1),
WEEK26 CHAR(1),
WEEK27 CHAR(1),
WEEK28 CHAR(1),
WEEK29 CHAR(1),
WEEK30 CHAR(1),
WEEK31 CHAR(1),
WEEK32 CHAR(1),
WEEK33 CHAR(1),
WEEK34 CHAR(1),
WEEK35 CHAR(1),
WEEK36 CHAR(1),
WEEK37 CHAR(1),
WEEK38 CHAR(1),
WEEK39 CHAR(1),
WEEK40 CHAR(1),
WEEK41 CHAR(1),
WEEK42 CHAR(1),
WEEK43 CHAR(1),
WEEK44 CHAR(1),
WEEK45 CHAR(1),
WEEK46 CHAR(1),
WEEK47 CHAR(1),
WEEK48 CHAR(1),
WEEK49 CHAR(1),
WEEK50 CHAR(1),
WEEK51 CHAR(1),
WEEK52 CHAR(1),
CONSTRAINT pk_StaffPaid PRIMARY KEY (StaffId),
CONSTRAINT fk_StaffPaid_Staff FOREIGN KEY (StaffId) REFERENCES Staff(StaffId)
);

CREATE TABLE TAXATION (
StaffId numeric(3),
PayeGrade char(1) UNIQUE, 
PrsiGrade char(1) UNIQUE,
SiptuGrade char(1) UNIQUE,
UscGrade char(1) UNIQUE,
HourlyRate char(1) UNIQUE,
CONSTRAINT pk_Taxation PRIMARY KEY(StaffId),
CONSTRAINT fk_Taxation_Staff FOREIGN KEY(StaffId) REFERENCES Staff(StaffId)
);

CREATE TABLE RATE (
HourlyRate char (1),
Value numeric (5,2),
CONSTRAINT pk_Rate PRIMARY KEY(HourlyRate));

CREATE TABLE SIPTU (
SiptuGrade char(1),
Value numeric(4,2),
CONSTRAINT pk_Siptu PRIMARY KEY(SiptuGrade));

CREATE TABLE USC (
UscGrade char(1),
Percentage numeric(2,1),
LowerLimit numeric(7,2),
UpperLimit numeric(8,2),
CONSTRAINT pk_Usc PRIMARY KEY (UscGrade));

CREATE TABLE PAYE (
PayeGrade char(1),
CutOff numeric(7,2),
LowerPercentage numeric(2),
UpperPercentage numeric(2),
CONSTRAINT pk_Paye PRIMARY KEY (PayeGrade));

CREATE TABLE PRSI (
PrsiGrade char(1),
Percentage numeric(2),
CONSTRAINT pk_Prsi PRIMARY KEY(PrsiGrade));

CREATE TABLE PAY_MULTIPLIERS (
OverTime numeric(3,2),
Sunday numeric(3,2),
DriverTravel numeric(3,2),
PassengerTravel numeric(3,2));

COMMIT;