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
  PRIMARY KEY (`CSESSION`,`FNAME`,`BUNK`)
);

DROP TABLE IF EXISTS `regact`;
CREATE TABLE `regact` (
  `CDATE` date NOT NULL,
  `SUB1` varchar(45) NOT NULL,
  `SUB2` varchar(45) NOT NULL,
  `SUB3` varchar(45) NOT NULL,
  `SUB4` varchar(45) NOT NULL,
  `SUB5` varchar(45) NOT NULL,
  PRIMARY KEY (`CDATE`)
);

DROP TABLE IF EXISTS `choices`;
CREATE TABLE `choices` (
  `BUNK` varchar(20) NOT NULL,
  `FNAME` varchar(40) NOT NULL,
  `CDATE` date NOT NULL,
  `SUB1` varchar(45) NOT NULL,
  `SUB2` varchar(45) NOT NULL,
  `SUB3` varchar(45) NOT NULL,
  `SUB4` varchar(45) NOT NULL,
  `SUB5` varchar(45) NOT NULL
  -- FOREIGN KEY (`BUNK`) REFERENCES `camper`(`BUNK`),
--   FOREIGN KEY (`FNAME`) REFERENCES `camper`(`FNAME`),
--   FOREIGN KEY (`CDATE`) REFERENCES `regact`(`CDATE`),
--   FOREIGN KEY (`SUB1`) REFERENCES `regact`(`SUB1`),
--   FOREIGN KEY (`SUB2`) REFERENCES `regact`(`SUB2`),
--   FOREIGN KEY (`SUB3`) REFERENCES `regact`(`SUB3`),
--   FOREIGN KEY (`SUB4`) REFERENCES `regact`(`SUB4`),
--   FOREIGN KEY (`SUB5`) REFERENCES `regact`(`SUB5`)
);