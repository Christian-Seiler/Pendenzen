-- phpMyAdmin SQL Dump
-- version 2.11.11.1
-- http://www.phpmyadmin.net
--
-- Generation Time: Jul 26, 2017 at 08:12 PM
-- Server version: 5.6.19
-- PHP Version: 5.3.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db351322_541`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `idadmin` varchar(45) NOT NULL,
  `AdminOption` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idadmin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE IF NOT EXISTS `company` (
  `company_id` varchar(6) NOT NULL,
  `company_name` varchar(45) NOT NULL,
  `company_street` varchar(45) DEFAULT NULL,
  `company_pobox` varchar(45) DEFAULT NULL,
  `company_plz` varchar(10) DEFAULT NULL,
  `company_city` varchar(45) DEFAULT NULL,
  `company_country` varchar(45) DEFAULT NULL,
  `company_phone` varchar(45) DEFAULT NULL,
  `company_website` varchar(45) DEFAULT NULL,
  `company_verkaufmail` varchar(45) DEFAULT NULL,
  `company_einkaufmail` varchar(45) DEFAULT NULL,
  `company_verkaufkontakt` varchar(4) NOT NULL DEFAULT 'Nein',
  `company_einkaufkontakt` varchar(4) NOT NULL DEFAULT 'Nein',
  `company_verkaufBuspro` varchar(4) NOT NULL DEFAULT 'Nein',
  `company_einkaufBuspro` varchar(4) DEFAULT 'Nein',
  `company_clientsince` date DEFAULT NULL,
  `company_sellersince` date DEFAULT NULL,
  `company_history` longtext,
  PRIMARY KEY (`company_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `country`
--

CREATE TABLE IF NOT EXISTS `country` (
  `idcountry` varchar(6) NOT NULL,
  `countryname` varchar(45) DEFAULT NULL,
  `countryISO2` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`idcountry`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pendenz`
--

CREATE TABLE IF NOT EXISTS `pendenz` (
  `idpendenz` int(11) NOT NULL AUTO_INCREMENT,
  `lieferant` varchar(10) NOT NULL,
  `referenz` longtext,
  `document` longtext,
  `erfasst_am` datetime NOT NULL,
  `erfasst_von` varchar(5) NOT NULL,
  `sachbearbeiter` varchar(5) DEFAULT NULL,
  `due` date DEFAULT NULL,
  `detail` longtext,
  `finalized` date DEFAULT NULL,
  `state` varchar(45) DEFAULT 'open',
  `department` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idpendenz`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `reason`
--

CREATE TABLE IF NOT EXISTS `reason` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `department` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `stats`
--

CREATE TABLE IF NOT EXISTS `stats` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `invoice` varchar(45) NOT NULL,
  `credit` varchar(45) NOT NULL,
  `company` varchar(45) DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `user` varchar(5) DEFAULT NULL,
  `date` datetime NOT NULL,
  `reason` varchar(45) DEFAULT NULL,
  `department` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
