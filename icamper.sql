DROP SCHEMA IF EXISTS `icamper`;
CREATE SCHEMA IF NOT EXISTS `icamper`;
USE `icamper`;

DROP TABLE IF EXISTS `camper`;
CREATE TABLE `camper` (
  `FNAME` varchar(40) NOT NULL,
  `NNAME` varchar(20) DEFAULT NULL,
  `BUNK` varchar(20) NOT NULL,
  `AGE` int(11) DEFAULT NULL,
  `NATIONALITY` varchar(20) NOT NULL,
  `RESTRICTION` varchar(30) DEFAULT NULL,
  `START_DATE` date NOT NULL,
  `LEAVE_DATE` date NOT NULL,
  `TRANSPORTATION` varchar(25) NOT NULL,
  `PNAME` varchar(45) NOT NULL,
  `PHONE` char(15) NOT NULL,
  `EMAIL` varchar(30) NOT NULL,
  `PPNAME` varchar(45) DEFAULT NULL,
  `PPHONE` char(15) DEFAULT NULL,
  `PEMAIL` varchar(30) DEFAULT NULL,
  `CSESSION` char(30) NOT NULL,
  PRIMARY KEY (`CSESSION`)
);

DROP TABLE IF EXISTS `regact`;
CREATE TABLE `regact` (
  `CDATE` date NOT NULL,
  `SUB1` varchar(45) NOT NULL,
  `SUB2` varchar(45) NOT NULL,
  `SUB3` varchar(45) NOT NULL,
  `SUB4` varchar(45) NOT NULL,
  `SUB5` varchar(45) NOT NULL
);