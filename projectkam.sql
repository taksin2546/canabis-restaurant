-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 05, 2022 at 04:09 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectkam`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `ID` int(11) NOT NULL,
  `เมนู` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `จำนวน` int(11) NOT NULL,
  `ราคา` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `inputmenu`
--

CREATE TABLE `inputmenu` (
  `ID` int(11) NOT NULL,
  `เมนู` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `ราคา` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `inputmenu`
--

INSERT INTO `inputmenu` (`ID`, `เมนู`, `ราคา`) VALUES
(11, 'แกงไข่มดแดง', 120);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `ID` int(11) NOT NULL,
  `User` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Password` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `ID` int(11) NOT NULL,
  `วันที่` text COLLATE utf8_unicode_ci NOT NULL,
  `โต๊ะ` text COLLATE utf8_unicode_ci NOT NULL,
  `ชื่อ` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `รายการ` text COLLATE utf8_unicode_ci NOT NULL,
  `จำนวน` int(11) NOT NULL,
  `ราคา` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`ID`, `วันที่`, `โต๊ะ`, `ชื่อ`, `รายการ`, `จำนวน`, `ราคา`) VALUES
(19, '', 'A3', 'ทดลอง  ระบบ', 'ผัดไข่ใบกัญชา [3]\n แกงเขียวหวานใบกัญชา [2]\n ', 5, 300),
(20, '', 'A3', 'ทดลอง  ระบบ', 'ผัดไข่ใบกัญชา [3]\n แกงเขียวหวานใบกัญชา [2]\n ', 5, 300),
(21, '', 'A5', 'ทดลอง  ระบบ', 'ผัดไข่ใบกัญชา [2]\n ', 2, 120),
(22, '', 'A4', 'ทดสอบ  ระบบ', 'ยำใบกัญชากรอบ [1]\n', 0, -10),
(23, '', 'A3', 'ทดสอบ  ระบบ', 'ยำใบกัญชากรอบ [1]\n', 1, 50),
(24, '', 'A2', 'qwertyui  qwertyu', 'ยำใบกัญชากรอบ [1]\n', 1, 50),
(25, '', 'A3', 'ทดสอบระบบ  ครั้งที่ 1', 'ผัดไข่ใบกัญชา [2]\n ไข่ข้นกัญชาไก่กรอบ [1]\n', 3, 170),
(26, '', 'A4', 'ศิวดล  หีบแก้ว', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 2, 110),
(27, '', 'A1', 'ทดสอบระบบ  ทดสอบระบบ', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(28, '', 'A1', 'ทดสอบระบบ  ทดสอบระบบ', 'แกงเขียวหวานใบกัญชา [2]\n ', 2, 120),
(29, '', 'A1', 'กุสุมา  ก่อประศาสน์วิทย์', 'ผัดไข่ใบกัญชา [1]\n ปังหน้ากัญชา [1]\nต้มแซบกัญชา [1]\n', 3, 170),
(30, '', 'A1', 'กุสุมา  ก่อประศาสน์วิทย์', 'ผัดไข่ใบกัญชา [2]\n แกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 4, 240),
(31, '', 'A4', 'ทดสอบระบบ  ก้าม', 'ผัดไข่ใบกัญชา [1]\n แกงเขียวหวานใบกัญชา [1]\n ', 2, 120),
(32, '', 'A4', 'ทดสอบระบบ  ก้าม', 'ยำใบกัญชากรอบ [2]\nแกงเขียวหวานใบกัญชา [2]\n ลาบหมู x กัญชา [2]\n ', 6, 340),
(34, '', 'A4', 'ทักษิณ  มัตวงษ์', 'แกงเขียวหวานใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(35, '', 'A4', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [2]\n แกงเขียวหวานใบกัญชา [1]\n ', 3, 180),
(36, '', 'A3', 'ชาคริต   ทิพวัฒน์', 'ไข่เข้นกัญชาหมูกรอบ [1]\nต้มไก่กัญชา [1]\nยำใบกัญชากรอบ [1]\nกัญชากรอบ [1]\nต้มแซบกัญชา [1]\n', 5, 300),
(37, '', 'A3', 'ทดสอบระบบ  ทดสอบระบบ', 'แกงเขียวหวานใบกัญชา [2]\n ลาบหมู x กัญชา [2]\n ', 4, 240),
(38, '0', 'A4', 'วุฒิกร  อัดโดดดร', 'ลาบหมู x กัญชา [2]\n ', 2, 120),
(39, '0', 'A5', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n แกงเขียวหวานใบกัญชา [1]\n ', 2, 120),
(40, '', 'A4', 'เล่  เล่', 'ลาบหมู x กัญชา [1]\n ', 1, 60),
(41, '', 'A3', 'er  sdd', 'ลาบหมู x กัญชา [1]\n ', 1, 60),
(42, '17/7/2565', 'A4', 'g  se', 'ลาบหมู x กัญชา [1]\n ', 1, 60),
(43, '20/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 2, 110),
(44, '20/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'แกงเขียวหวานใบกัญชา [2]\n ลาบหมู x กัญชา [2]\n ', 4, 240),
(45, '21/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [2]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 5, 290),
(46, '21/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ไข่ข้นกัญชาไก่กรอบ [1]\n', 2, 110),
(47, '21/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ไข่ข้นกัญชาไก่กรอบ [1]\n', 1, 60),
(48, '21/7/2565', 'A4', 'ทักษิณ  มัตวงษ์', 'ไข่ข้นกัญชาไก่กรอบ [1]\n', 1, 50),
(49, '21/7/2565', 'A4', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(50, '21/7/2565', 'A4', 'ทักษิณ  มัตวงษ์', 'ไข่ข้นกัญชาไก่กรอบ [1]\n', 1, 50),
(51, '21/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'กัญชากรอบ [1]\nปังหน้ากัญชา [1]\nต้มแซบกัญชา [1]\n', 3, 110),
(52, '21/7/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 2, 120),
(53, '21/7/2565', 'A2', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(54, '21/7/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(55, '21/7/2565', 'A2', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(56, '22/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(57, '22/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(58, '22/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(59, '22/7/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(60, '22/7/2565', 'A2', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(61, '23/7/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\n', 1, 50),
(62, '23/7/2565', 'A4', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 4, 220),
(63, '23/7/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(64, '24/7/2565', 'A2', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(65, '24/7/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(66, '7/8/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(67, '7/8/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [0]\nแกงเขียวหวานใบกัญชา [1]\n ', 2, 120),
(68, '7/8/2565', 'A5', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(69, '7/8/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(70, '7/8/2565', 'A1', 'ทักษิณ  ทดสอบ', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(71, '7/8/2565', 'A1', 'ทดลอง  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 4, 230),
(72, '7/8/2565', 'A1', 'ทักษิณ  ทดลอง', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(73, '7/8/2565', 'A1', 'ทดลอง  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 4, 230),
(74, '7/8/2565', 'A1', 'ทดลอง  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 4, 230),
(75, '7/8/2565', 'A5', 'ทดลอง  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n กัญชากรอบ [1]\nปังหน้ากัญชา [1]\nต้มแซบกัญชา [1]\n', 4, 230),
(76, '7/8/2565', 'A1', 'ทดสอบ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 4, 230),
(77, '7/8/2565', 'A2', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 4, 230),
(78, '7/8/2565', 'A5', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ไข่เข้นกัญชาหมูกรอบ [1]\nไข่ข้นกัญชาไก่กรอบ [1]\n', 3, 160),
(79, '7/8/2565', 'A4', 'ทดสอบ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(80, '7/8/2565', 'A4', 'ทดสอบ  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ผัดไข่ใบกัญชา [2]\n ', 4, 230),
(81, '7/8/2565', 'A4', 'ทดสอบ  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ผัดไข่ใบกัญชา [2]\n ', 4, 230),
(82, '7/8/2565', 'A3', 'กุสุมา  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\n', 2, 110),
(83, '7/8/2565', 'A1', 'ก้อว  มัตวงษ์', 'แกงเขียวหวานใบกัญชา [1]\n กัญชากรอบ [1]\n', 2, 120),
(84, '9/8/2565', 'A1', 'ทดสอบระบบ  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ลาบหมู x กัญชา [1]\n ', 3, 170),
(85, '12/9/2565', 'A1', 'ปอน  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 2, 110),
(86, '12/9/2565', 'A1', 'ปอน  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 2, 110),
(87, '14/9/2565', 'A1', 'ทดลอง  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 3, 170),
(88, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', '', 0, 0),
(89, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(90, '14/9/2565', 'A1', 'ปอน  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\n', 1, 50),
(91, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\n', 1, 50),
(92, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\nแกงเขียวหวานใบกัญชา [1]\n ', 2, 110),
(93, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(94, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(95, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(96, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(97, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(98, '14/9/2565', 'A5', 'ปอนทดลอง  มัตวงษ์', 'ยำใบกัญชากรอบ [1]\n', 1, 50),
(99, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(100, '14/9/2565', 'A1', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(101, '19/9/2565', 'A4', 'เล่  มัตวงษ์', 'ผัดไข่ใบกัญชา [1]\n ', 1, 60),
(102, '19/9/2565', 'A5', 'ทักษิณ  มัตวงษ์', 'ต้มแซบกัญชา [1] (70)\n', 1, 70),
(103, '20/9/2565', 'A5', 'ก้าม  มัตวงษ์', 'ผัดไข่ใบกัญชา [1] 60 บาท\n ยำใบกัญชากรอบ [1] 50 บาท\nไข่ข้นกัญชาไก่กรอบ [1] 50 บาท\n', 2, 110),
(104, '20/9/2565', 'A3', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1] 60 บาท\n ยำใบกัญชากรอบ [1] 50 บาท\nแกงเขียวหวานใบกัญชา [1] 60 บาท\n ', 2, 110),
(105, '20/9/2565', 'A4', 'ทักษิณ  มัตวงษ์', 'ผัดไข่ใบกัญชา [1] 60 บาท\n ยำใบกัญชากรอบ [1] 50 บาท\n', 2, 110),
(106, '20/9/2565', 'A1', 'กันดั้ม  มัตวงษ์', 'ผัดไข่ใบกัญชา [1] 60 บาท\n ยำใบกัญชากรอบ [1] 50 บาท\n', 1, 60),
(107, '20/9/2565', 'A5', 'ปอน  มัตวงษ์', 'ผัดไข่ใบกัญชา [1] 60 บาท\n แกงเขียวหวานใบกัญชา [1] 60 บาท\n ลาบหมู x กัญชา [1] 60 บาท\n ', 2, 120),
(108, '20/9/2565', 'A5', 'กรกนก  ศีรโสภา', 'ผัดไข่ใบกัญชา [1] 60 บาท\n ยำใบกัญชากรอบ [1] 50 บาท\nแกงเขียวหวานใบกัญชา [1] 60 บาท\n ', 2, 120),
(109, '21/9/2565', 'A2', 'กุสุมา  ก่อประศาสน์วิทย์', 'ผัดไข่ใบกัญชา [1] 60 บาท\n ', 1, 60),
(110, '21/9/2565', 'A3', 'ณัฐชนน  สินเจริญเลิศ', 'แกงเขียวหวานใบกัญชา [1] 60 บาท\n ลาบหมู x กัญชา [1] 60 บาท\n ต้มแซบกัญชา [1] 70 บาท\nไข่เจียวกัญชากรอบ [1] 50 บาท\n', 4, 240);

-- --------------------------------------------------------

--
-- Table structure for table `regis`
--

CREATE TABLE `regis` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Lastname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Phone` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `regis`
--

INSERT INTO `regis` (`ID`, `Name`, `Lastname`, `Phone`) VALUES
(29, 'ทดลอง', 'ระบบ', '0981451855'),
(30, 'ทดลอง', 'ระบบ', '0981451855'),
(31, 'ทดสอบ', 'ระบบ', '0981451855'),
(32, 'ทดสอบ', 'ระบบ', '0981451855'),
(33, 'qwertyui', 'qwertyu', '1234567890'),
(34, 'ทดสอบระบบ', 'ครั้งที่ 1', '0987654321'),
(35, 'ศิวดล', 'หีบแก้ว', '0987654321'),
(36, 'ทดสอบระบบ', 'ทดสอบระบบ', '0981451855'),
(37, 'กุสุมา', 'ก่อประศาสน์วิทย์', '0610359860'),
(38, 'ทดสอบระบบ', 'ก้าม', '0987654321'),
(39, 'ทดสอบระบบ', 'ทักษิณ', '0981451855'),
(40, 'taksin', 'Matawong', '0981451855'),
(41, 'ทดสอบ', 'ระบบ', '0987654321'),
(42, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(43, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(44, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(45, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(46, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(47, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(48, 'ชาคริต ', 'ทิพวัฒน์', '0930592001'),
(49, 'ทดสอบระบบ', 'ทดสอบระบบ', '0981451855'),
(50, 'วุฒิกร', 'อัดโดดดร', '0858841593'),
(51, 'หลิว', 'เลห์', '0987654321'),
(52, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(53, 'เล่', 'เล่', '1234567890'),
(54, 'er', 'sdd', '1234567890'),
(55, 'g', 'se', '1234567890'),
(56, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(57, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(58, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(59, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(60, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(61, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(62, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(63, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(64, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(65, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(66, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(67, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(68, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(69, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(70, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(71, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(72, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(73, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(74, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(75, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(76, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(77, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(78, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(79, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(80, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(81, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(82, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(83, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(84, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(85, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(86, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(87, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(88, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(89, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(90, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(91, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(92, 'ทักษิณ', 'ทดสอบ', '0981451855'),
(93, 'ทดลอง', 'มัตวงษ์', '0981451855'),
(94, 'ทักษิณ', 'ทดลอง', '0981451855'),
(95, 'ก้าม', 'มัตวงษ์', '0981451855'),
(96, 'ก้าม', 'มัตวงษ์', '0981451855'),
(97, 'ทดลอง', 'มัตวงษ์', '0981451855'),
(98, 'ทดลอง', 'มัตวงษ์', '0981451855'),
(99, 'ทดสอบ', 'มัตวงษ์', '0981451855'),
(100, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(101, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(102, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(103, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(104, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(105, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(106, 'ทดสอบ', 'มัตวงษ์', '0981451855'),
(107, 'กุสุมา', 'มัตวงษ์', '0981451855'),
(108, 'ก้อว', 'มัตวงษ์', '0981451855'),
(109, 'ทดสอบระบบ', 'มัตวงษ์', '0981451855'),
(110, 'ปอน', 'มัตวงษ์', '0981451855'),
(111, 'ทดลอง', 'มัตวงษ์', '0981451855'),
(112, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(113, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(114, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(115, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(116, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(117, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(118, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(119, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(120, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(121, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(122, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(123, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(124, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(125, 'ปอน', 'มัตวงษ์', '0981451855'),
(126, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(127, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(128, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(129, 'ปอนทดลอง', 'มัตวงษ์', '0981451855'),
(130, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(131, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(132, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(133, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(134, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(135, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(136, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(137, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(138, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(139, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(140, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(141, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(142, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(143, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(144, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(145, 'เล่', 'มัตวงษ์', '0981451855'),
(146, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(147, 'ก้าม', 'มัตวงษ์', '0981451855'),
(148, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(149, 'ทักษิณ', 'มัตวงษ์', '0981451855'),
(150, 'กันดั้ม', 'มัตวงษ์', '0981451855'),
(151, 'ปอน', 'มัตวงษ์', '0981451855'),
(152, 'กรกนก', 'ศีรโสภา', '0987654321'),
(153, 'กุสุมา', 'ก่อประศาสน์วิทย์', '0610359860'),
(154, 'ณัฐชนน', 'สินเจริญเลิศ', '0851632706'),
(155, 'ทักษิณ', 'มัตวงษ์', '0981451855');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `inputmenu`
--
ALTER TABLE `inputmenu`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `regis`
--
ALTER TABLE `regis`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=156;

--
-- AUTO_INCREMENT for table `inputmenu`
--
ALTER TABLE `inputmenu`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;

--
-- AUTO_INCREMENT for table `regis`
--
ALTER TABLE `regis`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=156;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
