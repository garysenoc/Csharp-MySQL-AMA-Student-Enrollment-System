-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.16


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema dbenrollment
--

CREATE DATABASE IF NOT EXISTS dbenrollment;
USE dbenrollment;

--
-- Definition of table `tbadmin`
--

DROP TABLE IF EXISTS `tbadmin`;
CREATE TABLE `tbadmin` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbadmin`
--

/*!40000 ALTER TABLE `tbadmin` DISABLE KEYS */;
INSERT INTO `tbadmin` (`id`,`username`,`password`) VALUES 
 (1,'admin','admin');
/*!40000 ALTER TABLE `tbadmin` ENABLE KEYS */;


--
-- Definition of table `tbstudent`
--

DROP TABLE IF EXISTS `tbstudent`;
CREATE TABLE `tbstudent` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fname` varchar(200) NOT NULL,
  `mname` varchar(200) NOT NULL,
  `lname` varchar(200) NOT NULL,
  `telno` varchar(200) NOT NULL,
  `age` varchar(200) NOT NULL,
  `sex` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `height` varchar(200) NOT NULL,
  `weght` varchar(200) NOT NULL,
  `citizenship` varchar(200) NOT NULL,
  `birthday` varchar(200) NOT NULL,
  `birthplace` varchar(200) NOT NULL,
  `fathername` varchar(200) NOT NULL,
  `fage` varchar(200) NOT NULL,
  `foccupation` varchar(200) NOT NULL,
  `mothername` varchar(200) NOT NULL,
  `mage` varchar(200) NOT NULL,
  `moccupation` varchar(200) NOT NULL,
  `province` varchar(200) NOT NULL,
  `cityadd` varchar(200) NOT NULL,
  `nameguardian` varchar(200) NOT NULL,
  `gaddress` varchar(200) NOT NULL,
  `persontocontact` varchar(200) NOT NULL,
  `persontocontactaddress` varchar(200) NOT NULL,
  `persontocontactadd` varchar(200) NOT NULL,
  `studentno` varchar(200) NOT NULL,
  `lrnno` varchar(200) NOT NULL,
  `studentclass` varchar(200) NOT NULL,
  `semester` varchar(200) NOT NULL,
  `schoolyear` varchar(200) NOT NULL,
  `pic` varchar(4500) NOT NULL,
  `gradelevel` varchar(45) NOT NULL,
  `strand` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbstudent`
--

/*!40000 ALTER TABLE `tbstudent` DISABLE KEYS */;
INSERT INTO `tbstudent` (`id`,`fname`,`mname`,`lname`,`telno`,`age`,`sex`,`status`,`height`,`weght`,`citizenship`,`birthday`,`birthplace`,`fathername`,`fage`,`foccupation`,`mothername`,`mage`,`moccupation`,`province`,`cityadd`,`nameguardian`,`gaddress`,`persontocontact`,`persontocontactaddress`,`persontocontactadd`,`studentno`,`lrnno`,`studentclass`,`semester`,`schoolyear`,`pic`,`gradelevel`,`strand`) VALUES 
 (1,'','','','','','','','','','','Sunday, October 28, 2018','','','','','','','','','','','','','','','','','','1st','2018-2019','C:\\Users\\Gary Lloyd Senoc\\Documents\\20181015_161000.jpg','11',''),
 (2,'ga','gaaga','','','','Female','','','','','Saturday, October 27, 2018','','','','','','','','','','','','','','','','','','1st','2018-2019','C:\\Users\\Gary Lloyd Senoc\\Documents\\20181015_161000.jpg','11',''),
 (3,'','','','','','','','','','','Saturday, October 27, 2018','','','','','','','','','','','','','','','','','','2nd','2017-2018','C:\\Users\\Gary Lloyd Senoc\\Documents\\20181015_160921.jpg','11',''),
 (4,'','','','','','','','','','','Saturday, October 27, 2018','','','','','','','','','','','','','','','','','','','','C:\\Users\\Gary Lloyd Senoc\\Documents\\20181015_160917.jpg','12','');
INSERT INTO `tbstudent` (`id`,`fname`,`mname`,`lname`,`telno`,`age`,`sex`,`status`,`height`,`weght`,`citizenship`,`birthday`,`birthplace`,`fathername`,`fage`,`foccupation`,`mothername`,`mage`,`moccupation`,`province`,`cityadd`,`nameguardian`,`gaddress`,`persontocontact`,`persontocontactaddress`,`persontocontactadd`,`studentno`,`lrnno`,`studentclass`,`semester`,`schoolyear`,`pic`,`gradelevel`,`strand`) VALUES 
 (5,'','','','','','','','','','','Saturday, October 27, 2018','','','','','','','','','','','','','','','','','','','','C:\\Users\\Gary Lloyd Senoc\\Documents\\received_1841114849315327.jpeg','',''),
 (6,'','','','','','','','','','','Saturday, October 27, 2018','','','','','','','','','','','','','','','','','','','','C:\\Users\\Gary Lloyd Senoc\\Documents\\20181015_160921.jpg','',''),
 (9,'','','','','','','','','','','Sunday, October 28, 2018','','','','','','','','','','','','','','','','','','1st','2018-2019','','12','');
/*!40000 ALTER TABLE `tbstudent` ENABLE KEYS */;


--
-- Definition of table `tbsubject`
--

DROP TABLE IF EXISTS `tbsubject`;
CREATE TABLE `tbsubject` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `code` varchar(200) NOT NULL,
  `coursedesc` varchar(200) DEFAULT NULL,
  `section` varchar(200) NOT NULL,
  `unit` varchar(200) NOT NULL,
  `day` varchar(200) NOT NULL,
  `time` varchar(200) NOT NULL,
  `room` varchar(200) NOT NULL,
  `sem` varchar(200) NOT NULL,
  `gradelevel` varchar(45) DEFAULT NULL,
  `strand` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbsubject`
--

/*!40000 ALTER TABLE `tbsubject` DISABLE KEYS */;
INSERT INTO `tbsubject` (`id`,`code`,`coursedesc`,`section`,`unit`,`day`,`time`,`room`,`sem`,`gradelevel`,`strand`) VALUES 
 (1,'PEDH','Physica Educa','A','3','10:30 - 11:30','Thursday','201','1st Sem','Grade 11','ICT');
/*!40000 ALTER TABLE `tbsubject` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
