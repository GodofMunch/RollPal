--DOSullivan
--t00139303

DROP TABLE BANKING;
DROP TABLE CONTACT;
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


--COMMIT;