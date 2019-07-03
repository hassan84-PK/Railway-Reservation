-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2019 at 12:08 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `railwayreservationsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `fares`
--

CREATE TABLE `fares` (
  `trainid` int(2) NOT NULL,
  `trackid` int(2) NOT NULL,
  `class` int(1) NOT NULL,
  `farerate` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fares`
--

INSERT INTO `fares` (`trainid`, `trackid`, `class`, `farerate`) VALUES
(1, 2, 1, 500),
(1, 2, 2, 800),
(1, 5, 1, 500),
(1, 5, 2, 800),
(2, 1, 1, 1000),
(2, 1, 2, 1500),
(2, 2, 1, 600),
(2, 2, 2, 900),
(2, 3, 1, 1000),
(2, 3, 2, 1500),
(2, 4, 1, 300),
(2, 4, 2, 500),
(2, 5, 1, 300),
(2, 5, 2, 500),
(2, 6, 1, 500),
(2, 6, 2, 900),
(3, 1, 1, 2000),
(3, 1, 2, 25000);

-- --------------------------------------------------------

--
-- Table structure for table `routes`
--

CREATE TABLE `routes` (
  `id` int(2) NOT NULL,
  `name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `routes`
--

INSERT INTO `routes` (`id`, `name`) VALUES
(1, 'Lahore'),
(2, 'Karachi'),
(3, 'Rawalpindi');

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `ticketnumber` int(4) NOT NULL,
  `Status` varchar(10) NOT NULL,
  `Dates` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`ticketnumber`, `Status`, `Dates`) VALUES
(1, 'Confirm', '2019-06-28'),
(2, 'Confirm', '2019-06-28'),
(3, 'Confirm', '2019-06-29'),
(4, 'Confirm', '2019-06-29'),
(5, 'Confirm', '2019-06-29'),
(14, 'Confirm', '2019-07-06'),
(16, 'Confirm', '2019-06-29'),
(17, 'Confirm', '2019-06-29');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fares`
--
ALTER TABLE `fares`
  ADD PRIMARY KEY (`trainid`,`trackid`,`class`),
  ADD KEY `trackid` (`trackid`),
  ADD KEY `class` (`class`);

--
-- Indexes for table `routes`
--
ALTER TABLE `routes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`ticketnumber`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `fares`
--
ALTER TABLE `fares`
  ADD CONSTRAINT `fares_ibfk_1` FOREIGN KEY (`trainid`) REFERENCES `traininfo` (`id`),
  ADD CONSTRAINT `fares_ibfk_2` FOREIGN KEY (`trackid`) REFERENCES `tracks` (`trackid`),
  ADD CONSTRAINT `fares_ibfk_3` FOREIGN KEY (`class`) REFERENCES `classes` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
