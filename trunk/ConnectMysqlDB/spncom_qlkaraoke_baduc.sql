-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 21, 2014 at 11:59 PM
-- Server version: 5.5.37-35.1
-- PHP Version: 5.4.23

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `spncom_qlkaraoke_baduc`
--

-- --------------------------------------------------------

--
-- Table structure for table `k3d_app`
--

CREATE TABLE IF NOT EXISTS `k3d_app` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `address` varchar(125) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(50) CHARACTER SET utf8 NOT NULL,
  `banner` varchar(125) CHARACTER SET utf8 NOT NULL,
  `prefix` varchar(50) CHARACTER SET utf8 NOT NULL,
  `alias` varchar(256) CHARACTER SET utf8 NOT NULL,
  `date_created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `date_modified` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `date_activity` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `type` tinyint(4) NOT NULL,
  `page_view` bigint(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=2 ;

--
-- Dumping data for table `k3d_app`
--

INSERT INTO `k3d_app` (`id`, `name`, `phone`, `address`, `email`, `banner`, `prefix`, `alias`, `date_created`, `date_modified`, `date_activity`, `type`, `page_view`) VALUES
(1, 'Karaoke Ba Đức', '0945 03 07 09', 'Phó Cơ Điều P3 - TPVL', '', 'data/images/banner/logo.png', 'k3d_', 'k3d_', '2012-06-30 10:00:00', '0000-00-00 00:00:00', '2012-12-26 00:28:02', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_category`
--

CREATE TABLE IF NOT EXISTS `k3d_category` (
  `id` int(25) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `picture` binary(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=14 ;

--
-- Dumping data for table `k3d_category`
--

INSERT INTO `k3d_category` (`id`, `name`, `picture`) VALUES
(3, 'BEER', NULL),
(8, 'NƯỚC GIẢI KHÁT', NULL),
(11, 'THUỐC HÚT', NULL),
(12, 'THỨC ĂN', NULL),
(13, 'KHÁC', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_collect_customer`
--

CREATE TABLE IF NOT EXISTS `k3d_collect_customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idcustomer` int(11) NOT NULL,
  `date` date NOT NULL,
  `value` int(11) NOT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_customer_collect_1` (`idcustomer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_collect_general`
--

CREATE TABLE IF NOT EXISTS `k3d_collect_general` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_term` int(11) NOT NULL,
  `date` date NOT NULL,
  `value` int(11) NOT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_collect_1` (`id_term`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_config`
--

CREATE TABLE IF NOT EXISTS `k3d_config` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `param` varchar(125) COLLATE utf8_unicode_ci NOT NULL,
  `value` varchar(256) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=11 ;

--
-- Dumping data for table `k3d_config`
--

INSERT INTO `k3d_config` (`id`, `param`, `value`) VALUES
(1, 'PRICE_HOUR_NORMAL_1', '70000'),
(2, 'PRICE_HOUR_NORMAL_2', '90000'),
(3, 'PRICE_HOUR_VIP_1', '80000'),
(4, 'PRICE_HOUR_VIP_2', '100000'),
(5, 'DISCOUNT', '0'),
(6, 'ROW_PER_PAGE', '8'),
(7, 'GUEST_VISIT', '9247'),
(8, 'THEME', 'grey'),
(9, 'CATEGORY_AUTO', '3'),
(10, 'EVERY_5_MINUTES', '2000');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_course`
--

CREATE TABLE IF NOT EXISTS `k3d_course` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idcategory` int(25) DEFAULT NULL,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `shortname` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `unit` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `price1` bigint(20) NOT NULL,
  `price2` bigint(20) NOT NULL,
  `price3` bigint(20) NOT NULL,
  `price4` bigint(20) NOT NULL,
  `picture` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prepare` int(11) NOT NULL,
  `is_discount` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `foreign_field` (`idcategory`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=165 ;

--
-- Dumping data for table `k3d_course`
--

INSERT INTO `k3d_course` (`id`, `idcategory`, `name`, `shortname`, `unit`, `price1`, `price2`, `price3`, `price4`, `picture`, `prepare`, `is_discount`) VALUES
(15, 11, 'Thuốc hút', 'Thuốc hút', 'Gói', 25000, 0, 0, 0, NULL, 0, 0),
(53, 8, 'Trà xanh', 'Trà xanh', 'Chai', 15000, 0, 0, 0, NULL, 0, 0),
(54, 8, 'C2', 'C2', 'Chai', 15000, 0, 0, 0, NULL, 0, 0),
(55, 8, 'Dr Thanh', 'Dr Thanh', 'Chai', 15000, 0, 0, 0, NULL, 0, 0),
(56, 8, 'Nước yến', 'Nước yến', 'Lon', 15000, 0, 0, 0, NULL, 0, 0),
(107, 3, 'Heniken', 'Heniken CAHI', 'Chai', 18000, 18000, 18000, 18000, '', 0, 0),
(108, 3, 'Heniken Lon', 'Heniken Lon', 'Lon', 20000, 20000, 20000, 20000, '', 0, 0),
(110, 12, 'Trái cây', 'Trái cây', 'Dĩa', 50000, 0, 0, 0, '', 0, 0),
(111, 3, 'Sài gòn đỏ', 'Sài gòn đỏ', 'Chai', 12000, 0, 0, 0, '', 0, 0),
(112, 3, 'Sài gòn special', 'Sài gòn special', 'Chai', 15000, 0, 0, 0, '', 0, 0),
(113, 3, 'Sài gòn special.', 'Sài gòn special.', 'Lon', 17000, 0, 0, 0, '', 0, 0),
(114, 3, 'Bia 333', 'Bia 333', 'Lon', 16000, 0, 0, 0, '', 0, 0),
(115, 11, 'Thuốc 555', 'Thuốc 555', 'Gói', 30000, 0, 0, 0, '', 0, 0),
(116, 11, 'Thuốc Craven', 'Thuốc Craven', 'Gói', 25000, 0, 0, 0, '', 0, 0),
(117, 12, 'Oshi', 'Oshi', 'Gói', 10000, 0, 0, 0, '', 0, 0),
(118, 12, 'Chả giò', 'Chả giò', 'Gói', 15000, 0, 0, 0, '', 0, 0),
(119, 12, 'Khô bò', 'Khô bò', 'Gói', 10000, 0, 0, 0, '', 0, 0),
(120, 12, 'Mít sấy', 'Mít sấy', 'Gói', 15000, 0, 0, 0, '', 0, 0),
(121, 12, 'Xúc xích', 'Xúc xích', 'Gói', 35000, 0, 0, 0, '', 0, 0),
(122, 12, 'CW Doublemin', 'CW Doublemin', 'Cây', 6000, 0, 0, 0, '', 0, 0),
(123, 12, 'Đậu phộng chiên', 'Đậu phộng chiên', 'Gói', 10000, 0, 0, 0, '', 0, 0),
(124, 12, 'Đậu phộng sấy', 'Đậu phộng sấy', 'Gói', 10000, 0, 0, 0, '', 0, 0),
(125, 12, 'Đậu phộng da cá', 'Đậu phộng da cá', 'Gói', 12000, 0, 0, 0, '', 0, 0),
(126, 8, 'Lavie 500ml', 'Lavie 500ml', 'Chai', 10000, 0, 0, 0, '', 0, 0),
(127, 8, 'Pepsi', 'Pepsi', 'Lon', 15000, 0, 0, 0, '', 0, 0),
(128, 8, '7 Up', '7 Up', 'Lon', 15000, 0, 0, 0, '', 0, 0),
(129, 8, 'Mirinda cam', 'Mirinda cam', 'Lon', 15000, 0, 0, 0, '', 0, 0),
(134, 12, 'Khô mực N', 'Khô mực N', 'Con', 50000, 0, 0, 0, '', 0, 0),
(135, 12, 'Chả lụa', 'Chả lụa', 'Dĩa', 50000, 0, 0, 0, '', 0, 0),
(136, 8, 'Red bull', 'Red bull', 'Lon', 15000, 0, 0, 0, '', 0, 0),
(137, 3, 'Tiger', 'Tiger', 'Chai', 14000, 0, 0, 0, '', 0, 0),
(138, 3, 'Tiger bạc', 'Tiger bạc', 'Chai', 15000, 0, 0, 0, '', 0, 0),
(139, 12, 'Đậu nành rang', 'Đậu nành rang', 'Gói', 10000, 0, 0, 0, '', 0, 0),
(140, 3, 'Tiger.', 'Tiger.', 'Lon', 19000, 0, 0, 0, '', 0, 0),
(141, 12, 'Cơm cháy', 'Cơm cháy', 'Gói', 17000, 0, 0, 0, '', 0, 0),
(142, 12, 'Cá cơm', 'Cá cơm', 'Gói', 12000, 0, 0, 0, '', 0, 0),
(143, 8, 'Sting', 'Sting', 'Chai', 15000, 0, 0, 0, '', 0, 0),
(144, 12, 'Khô mực', 'Khô mực', 'Con', 60000, 0, 0, 0, '', 0, 0),
(145, 12, 'Chà giò rế', 'Chà giò rế', 'Dĩa', 60000, 0, 0, 0, '', 0, 0),
(146, 12, 'Nhái chiên giòn', 'Nhái', 'Dĩa', 60000, 0, 0, 0, '', 0, 0),
(147, 12, 'Đậu nành sấy', 'Đậu nành sấy', 'Gói', 12000, 0, 0, 0, '', 0, 0),
(149, 13, 'Nước đá viên', 'Nước đá viên', 'Kg', 1000, 0, 0, 0, '', 0, 0),
(150, 12, 'Xoài thêm', '', 'Dĩa', 30000, 0, 0, 0, '', 0, 0),
(151, 12, 'Ổi thêm', '', 'Dĩa', 30000, 0, 0, 0, '', 0, 0),
(152, 12, 'Dưa hấu thêm', 'Dưa hấu thêm', 'Dĩa', 30000, 0, 0, 0, '', 0, 0),
(153, 12, 'Mận thêm', '', 'Dĩa', 30000, 0, 0, 0, '', 0, 0),
(154, 12, 'Sơ ri thêm', '', 'Dĩa', 30000, 0, 0, 0, '', 0, 0),
(155, 3, 'Sagota.', 'Sagota.', 'Lon', 15000, 0, 0, 0, '', 0, 0),
(156, 12, 'Mít', '', 'Dĩa', 50000, 0, 0, 0, '', 0, 0),
(157, 12, 'Hột điều', 'Hột điều', 'Gói', 12000, 0, 0, 0, '', 0, 0),
(158, 12, 'Xúc xích N', 'Xúc xích N', 'Gói', 25000, 0, 0, 0, '', 0, 0),
(159, 12, 'Chả cá chiên giòn', 'Chả cá chiên giòn', 'Dĩa', 45000, 0, 0, 0, '', 0, 0),
(160, 12, 'Phô mai', 'Phô mai', 'Hộp', 25000, 0, 0, 0, '', 0, 0),
(161, 13, 'Khăn giấy', '', 'Gói', 5000, 0, 0, 0, '', 0, 0),
(162, 13, 'Khăn Lạnh', '', 'Cái', 2000, 0, 0, 0, '', 0, 0),
(163, 13, 'Quẹt gas', '', 'Cái', 4000, 0, 0, 0, '', 0, 0),
(164, 12, 'Đậu Hà lan', 'Đậu Hà lan', 'Gói', 30000, 0, 0, 0, '', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_course_log`
--

CREATE TABLE IF NOT EXISTS `k3d_course_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_table` int(11) NOT NULL,
  `id_course` int(11) NOT NULL,
  `date_time` datetime NOT NULL,
  `count` int(11) NOT NULL,
  `state` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_customer`
--

CREATE TABLE IF NOT EXISTS `k3d_customer` (
  `id` int(9) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `type` int(11) NOT NULL,
  `card` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `address` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `note` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `discount` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=28 ;

--
-- Dumping data for table `k3d_customer`
--

INSERT INTO `k3d_customer` (`id`, `name`, `type`, `card`, `phone`, `address`, `note`, `discount`) VALUES
(1, 'KHÁCH VÃNG LAI', 0, '893970784300', '', '', '', 0),
(12, 'LÊ HỒNG ĐỨC', 1, '893970784301', '0918585203', 'Cty TNHH MTV Ba Đức Vĩnh Long', 'Giám Đốc', 0),
(13, 'NGUYỄN QUANG MINH (NV)', 0, '893970784302', '', '', 'NV Karaoke', 0),
(14, 'PHAN THANH PHONG', 0, '893970784303', '', '', 'Toàn', 0),
(15, 'PHẠM MINH TUẤN ANH (NV)', 0, '893970784304', '', 'Vĩnh Long', 'Kế Toán', 0),
(16, 'LÊ NGUYỄN ĐÔNG KHOA', 1, '893970784305', '0945030709', 'Cty TNHH MTV Ba Đức Vĩnh Long', 'P. GĐ', 0),
(17, 'LÊ THÀNH TÂM', 0, '893970784306', '', '', '', 0),
(18, 'CƯỜNG (Cầu Đôi)', 0, '893970784307', '', 'Cầu Đôi', '', 0),
(19, 'LÊ NGUYỄN THANH TRUNG', 0, '', '', '', '', 0),
(20, 'ANH TRÍ CAVL', 0, '', '', 'CSKT VL', '', 0),
(21, 'Nhí', 0, '', '', '', '', 0),
(22, 'NGUYỄN VĂN HIẾU', 0, '', '', 'NV Karaoke', '', 0),
(23, 'TRƯƠNG PHƯỚC SANG', 0, '', '', 'NV Khách sạn', '', 0),
(24, 'HUỲNH PHAN HỒNG NGỌC', 0, '', '', 'NV Khách sạn', '', 0),
(25, 'KHÁCH HÀNG NỢ', 0, '', '', '', 'Khách vãng lai nợ', 0),
(26, 'THẮNG', 1, '', '', 'CAVL', 'CAVL', 0),
(27, 'PHAN HOÀNG THÁI', 0, '', '', '', 'Kế Toán', 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_domain`
--

CREATE TABLE IF NOT EXISTS `k3d_domain` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `k3d_domain`
--

INSERT INTO `k3d_domain` (`id`, `name`) VALUES
(1, 'KHU A'),
(2, 'KHU B'),
(3, 'KHU VIP');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_employee`
--

CREATE TABLE IF NOT EXISTS `k3d_employee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `job` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `gender` tinyint(2) NOT NULL,
  `phone` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  `address` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `salary_base` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `k3d_employee`
--

INSERT INTO `k3d_employee` (`id`, `name`, `job`, `gender`, `phone`, `address`, `salary_base`) VALUES
(1, 'Phan Xuân Mai', 'Phó tư lệnh', 1, '0946 915 700', 'Cao Lãnh - Đồng Tháp', 2000000),
(2, 'Nguyễn Quang Minh', 'Phục vụ', 0, '0932502838', 'Châu Thành, Đồng Tháp', 0),
(3, 'Nguyễn Văn Hiếu', 'Phục vụ', 0, '0', 'Sóc Trăng', 0),
(4, 'Trần Thanh Chỉ', 'Phục vụ&Bếp ăn', 1, '', 'Châu Thành, Đồng Tháp', 0),
(5, 'Phạm Minh Tuấn Anh', 'Kế Toán', 0, '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_guest`
--

CREATE TABLE IF NOT EXISTS `k3d_guest` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(16) CHARACTER SET latin1 NOT NULL,
  `entry_time` varchar(32) CHARACTER SET latin1 NOT NULL,
  `exit_time` varchar(32) CHARACTER SET latin1 NOT NULL,
  `agent` varchar(16) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_order_import`
--

CREATE TABLE IF NOT EXISTS `k3d_order_import` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idsupplier` int(11) NOT NULL,
  `date` date NOT NULL,
  `description` varchar(50) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_order_import_1` (`idsupplier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_order_import_detail`
--

CREATE TABLE IF NOT EXISTS `k3d_order_import_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idorder` int(11) NOT NULL,
  `idresource` int(11) NOT NULL,
  `count` float NOT NULL,
  `price` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_order_import_detail_1` (`idorder`),
  KEY `k3d_order_import_detail_2` (`idresource`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_paid_customer`
--

CREATE TABLE IF NOT EXISTS `k3d_paid_customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idcustomer` int(11) NOT NULL,
  `date` date NOT NULL,
  `value` int(11) NOT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_customer_paid_1` (`idcustomer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_paid_general`
--

CREATE TABLE IF NOT EXISTS `k3d_paid_general` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_term` int(11) NOT NULL,
  `date` date NOT NULL,
  `value` int(11) NOT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_paid_1` (`id_term`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_paid_pay_roll`
--

CREATE TABLE IF NOT EXISTS `k3d_paid_pay_roll` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idemployee` int(11) NOT NULL,
  `date` date NOT NULL,
  `value_base` int(11) NOT NULL,
  `value_sub` int(11) NOT NULL,
  `value_pre` int(11) NOT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_paid_pay_roll_1` (`idemployee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_paid_supplier`
--

CREATE TABLE IF NOT EXISTS `k3d_paid_supplier` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idsupplier` int(11) NOT NULL,
  `date` date NOT NULL,
  `value` int(11) NOT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_supplier_paid_1` (`idsupplier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_pay_roll`
--

CREATE TABLE IF NOT EXISTS `k3d_pay_roll` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_employee` int(11) NOT NULL,
  `date` date NOT NULL,
  `state` int(11) NOT NULL,
  `extra` int(11) NOT NULL,
  `late` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_employee` (`id_employee`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_r2c`
--

CREATE TABLE IF NOT EXISTS `k3d_r2c` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_course` int(11) NOT NULL,
  `id_resource` int(11) NOT NULL,
  `value1` double NOT NULL,
  `value2` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_r2c_1` (`id_course`),
  KEY `k3d_r2c_2` (`id_resource`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=154 ;

--
-- Dumping data for table `k3d_r2c`
--

INSERT INTO `k3d_r2c` (`id`, `id_course`, `id_resource`, `value1`, `value2`) VALUES
(103, 107, 19, 1, 1),
(104, 107, 86, 1, 1),
(105, 111, 21, 1, 1),
(106, 108, 20, 1, 1),
(107, 108, 87, 1, 1),
(108, 111, 89, 1, 1),
(109, 112, 22, 1, 1),
(110, 112, 90, 1, 1),
(111, 113, 23, 1, 1),
(112, 114, 24, 1, 1),
(113, 137, 26, 1, 1),
(114, 138, 25, 1, 1),
(115, 140, 62, 1, 1),
(116, 53, 70, 1, 1),
(117, 54, 64, 1, 1),
(118, 55, 74, 1, 1),
(119, 56, 75, 1, 1),
(120, 126, 63, 1, 1),
(121, 127, 72, 1, 1),
(122, 128, 69, 1, 1),
(123, 129, 73, 1, 1),
(124, 136, 71, 1, 1),
(125, 143, 60, 1, 1),
(126, 15, 65, 1, 1),
(127, 115, 40, 1, 1),
(128, 116, 39, 1, 1),
(129, 161, 95, 1, 1),
(130, 162, 85, 1, 1),
(131, 163, 43, 1, 1),
(132, 111, 97, 1, 1),
(133, 112, 98, 1, 1),
(134, 155, 83, 1, 1),
(135, 118, 29, 1, 1),
(136, 119, 30, 1, 1),
(137, 120, 31, 1, 1),
(138, 121, 27, 1, 1),
(139, 122, 28, 1, 1),
(140, 123, 36, 1, 1),
(141, 124, 35, 1, 1),
(142, 125, 32, 1, 1),
(143, 134, 58, 1, 1),
(144, 139, 44, 1, 1),
(145, 141, 45, 1, 1),
(146, 142, 46, 1, 1),
(147, 144, 59, 1, 1),
(148, 147, 76, 1, 1),
(149, 158, 80, 1, 1),
(150, 160, 92, 1, 1),
(151, 164, 96, 1, 1),
(152, 157, 100, 1, 1),
(153, 162, 61, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_resource`
--

CREATE TABLE IF NOT EXISTS `k3d_resource` (
  `id` int(9) NOT NULL AUTO_INCREMENT,
  `idsupplier` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `unit` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `price` int(10) NOT NULL,
  `description` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `k3d_resource_1` (`idsupplier`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=101 ;

--
-- Dumping data for table `k3d_resource`
--

INSERT INTO `k3d_resource` (`id`, `idsupplier`, `name`, `unit`, `price`, `description`) VALUES
(2, 1, 'Đá viên lớn', 'Kg', 800, 'Nước đá cưa - Bao 20kg'),
(14, 1, 'Nước đá ướp', 'Kg', 800, 'Đá cây ướp bia'),
(17, 6, 'Bánh', 'Gói', 5000, ''),
(19, 8, 'Heniken', 'Chai', 13042, ''),
(20, 8, 'Heniken.', 'Lon', 15084, 'Thùng 24 lon'),
(21, 8, 'Sài gòn đỏ', 'Chai', 6600, 'Két 20 chai'),
(22, 8, 'Sài gòn special', 'Chai', 8900, 'Két 20 chai'),
(23, 8, 'Sài gòn special.', 'Lon', 10896, 'Thùng 24 lon'),
(24, 8, 'Bia 333', 'Lon', 8625, 'Thùng 24 lon'),
(25, 8, 'Tiger bạc', 'Chai', 10834, 'Két 24 chai'),
(26, 8, 'Tiger', 'Chai', 9917, 'Két 24 chai'),
(27, 6, 'Xúc xích', 'Gói', 17000, ''),
(28, 6, 'CW Doublemin', 'Cây', 2000, ''),
(29, 6, 'Chả giò', 'Gói', 10300, ''),
(30, 6, 'Khô bò', 'Gói', 5500, ''),
(31, 6, 'Mít sấy', 'Gói', 6200, ''),
(32, 6, 'Đậu phộng da cá', 'Gói', 7000, ''),
(35, 9, 'Đậu phộng sấy', 'Gói', 5000, '5000'),
(36, 9, 'Đậu phộng chiên', 'Gói', 5000, ''),
(39, 9, 'Thuốc Craven', 'Gói', 16500, ''),
(40, 9, 'Thuốc 555', 'Gói', 23500, ''),
(43, 9, 'Quẹt gas', 'Cái', 1700, ''),
(44, 9, 'Đậu nành rang', 'Gói', 3000, 'Mua ngoài'),
(45, 11, 'Cơm cháy', 'Gói', 7000, ''),
(46, 11, 'Cá cơm', 'Gói', 7000, '0'),
(47, 12, 'Ổi', 'Kg', 9000, ''),
(48, 12, 'Củ sắn', 'Kg', 15000, ''),
(49, 12, 'Mít', 'Kg', 18000, ''),
(50, 12, 'Chôm chôm', 'Kg', 10000, ''),
(51, 12, 'Xoài Thái', 'Kg', 15000, ''),
(52, 12, 'Xoài Đài Loan', 'Kg', 15000, ''),
(53, 12, 'Xoài chua', 'Kg', 15000, ''),
(54, 12, 'Mận', 'Kg', 10000, ''),
(55, 12, 'Sơ ri', 'Kg', 12000, ''),
(56, 12, 'Thơm', 'Kg', 12000, ''),
(57, 12, 'Khóm', 'Kg', 10000, ''),
(58, 9, 'Khô mực N', 'Con', 22000, ''),
(59, 9, 'Khô mực', 'Con', 30000, ''),
(60, 8, 'Sting', 'Lon', 7208, 'Thùng 24 lon'),
(61, 9, 'Khăn lạnh', 'Cái', 800, ''),
(62, 8, 'Tiger.', 'Lon', 11667, 'Thùng 24 lon'),
(63, 8, 'Lavie 500ml', 'Chai', 3584, 'Thùng 24 chai'),
(64, 8, 'C2', 'Chai', 4500, 'Thùng 24 chai'),
(65, 9, 'Thuốc hút', 'Gói', 15500, ''),
(66, 9, 'Bánh tráng rế', 'Gói', 15000, 'Bánh tráng gói chả giò rế'),
(67, 9, 'Thịt ghẹ', 'Kg', 80000, 'Thịt ghẹ gói chả giò rế'),
(68, 9, 'Khoai cao', 'Kg', 30000, 'Khoai cao gói chả giò rế'),
(69, 8, '7 Up', 'Lon', 6375, 'Thùng 24 lon'),
(70, 8, 'Trà xanh', 'Chai', 6583, 'Thùng 24 chai'),
(71, 8, 'Red bull', 'Lon', 6200, 'Thùng 30 lon'),
(72, 8, 'Pepsi', 'Lon', 6375, 'Thùng 24 lon'),
(73, 8, 'Mirinda cam', 'Lon', 5417, 'Thùng 24 lon'),
(74, 8, 'Dr Thanh', 'Chai', 7750, 'Thùng 24 chai'),
(75, 8, 'Nước yến', 'Lon', 5917, 'Thùng 24 lon'),
(76, 9, 'Đậu nành sấy', 'Gói', 5000, ''),
(77, 9, 'Nhái khô', 'Kg', 600000, ''),
(78, 6, 'Oshi', 'Gói', 5000, ''),
(79, 12, 'Dưa hấu', 'Kg', 10000, ''),
(80, 6, 'Xúc xích N', 'Gói', 11500, ''),
(81, 6, 'Tương ớt', 'Chai', 9700, ''),
(82, 12, 'Táo', 'Kg', 10000, ''),
(83, 15, 'SAGOTA', 'Lon', 8000, ''),
(84, 12, 'Cóc', 'Kg', 6000, ''),
(85, 14, 'Khăn lạnh', 'Cái', 550, ''),
(86, 13, 'Heniken', 'Chai', 13083, ''),
(87, 13, 'Heniken.', 'Lon', 10834, ''),
(88, 16, 'Gạo', 'Kg', 11000, ''),
(89, 13, 'Sài gòn đỏ', 'Chai', 6600, 'Két 20 chai'),
(90, 13, 'Sài gòn special', 'Chai', 9000, 'Két 20 chai'),
(91, 1, 'Đá ống viên lớn', 'Kg', 800, 'Bao 20kg'),
(92, 17, 'Phô mai', 'Hộp', 14334, '0'),
(93, 17, 'Xúc xích N', 'Gói', 10500, 'Xúc xích nhỏ'),
(94, 17, 'Xúc xích', 'Gói', 17800, ''),
(95, 17, 'Khăn giấy', 'Gói', 1800, ''),
(96, 11, 'Đậu Hà lan', 'Gói', 16000, ''),
(97, 18, 'Sài gòn đỏ', 'Chai', 6400, ''),
(98, 18, 'Sài gòn special', 'Chai', 9200, ''),
(99, 12, 'Bưởi', 'Kg', 10000, ''),
(100, 11, 'Hột điều', 'Gói', 6000, '');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_session`
--

CREATE TABLE IF NOT EXISTS `k3d_session` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idtable` int(11) NOT NULL,
  `iduser` int(11) NOT NULL,
  `idcustomer` int(11) NOT NULL,
  `idemployee` int(11) NOT NULL,
  `datetime` datetime NOT NULL,
  `datetimeend` datetime DEFAULT NULL,
  `note` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `status` int(11) NOT NULL,
  `discount_value` int(11) NOT NULL,
  `discount_percent` int(11) NOT NULL,
  `surtax` int(11) NOT NULL,
  `payment` int(11) NOT NULL,
  `value` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idtable` (`idtable`),
  KEY `iduser` (`iduser`),
  KEY `k3d_session_3` (`idcustomer`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=13 ;

--
-- Dumping data for table `k3d_session`
--

INSERT INTO `k3d_session` (`id`, `idtable`, `iduser`, `idcustomer`, `idemployee`, `datetime`, `datetimeend`, `note`, `status`, `discount_value`, `discount_percent`, `surtax`, `payment`, `value`) VALUES
(1, 17, 1, 1, 1, '2014-05-10 16:29:28', '2014-05-10 19:35:00', '', 2, 0, 0, 0, 0, 0),
(2, 27, 1, 1, 1, '2014-05-10 19:31:25', '2014-05-10 19:31:25', '', 1, 0, 0, 0, 0, 0),
(3, 1, 1, 1, 1, '2014-05-11 17:40:00', '2014-05-11 18:45:00', '', 1, 0, 0, 0, 0, 0),
(4, 2, 1, 1, 1, '2014-05-13 15:40:00', '2014-05-13 16:05:00', '', 1, 0, 0, 0, 0, 0),
(5, 27, 1, 1, 1, '2014-05-13 23:05:00', '2014-05-13 23:40:00', '', 1, 0, 0, 0, 0, 0),
(6, 27, 1, 1, 1, '2014-05-14 00:05:09', '2014-05-14 02:00:00', '', 1, 0, 0, 0, 0, 0),
(7, 17, 1, 1, 1, '2014-05-16 22:05:00', '2014-05-17 00:00:00', '', 1, 0, 0, 0, 0, 0),
(8, 2, 1, 1, 1, '2014-05-17 13:00:00', '2014-05-17 14:45:00', '', 1, 0, 0, 0, 0, 0),
(10, 1, 1, 1, 1, '2014-05-20 13:50:00', '2014-05-20 14:40:00', '', 2, 0, 0, 0, 0, 0),
(11, 27, 1, 1, 1, '2014-05-20 20:51:55', '2014-05-20 21:30:00', '', 1, 0, 0, 0, 0, 0),
(12, 2, 1, 1, 1, '2014-05-28 22:50:00', '2014-05-29 00:40:00', '', 1, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_session_detail`
--

CREATE TABLE IF NOT EXISTS `k3d_session_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idsession` int(11) NOT NULL,
  `idcourse` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  `price` bigint(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idsession` (`idsession`),
  KEY `idcourse` (`idcourse`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=39 ;

--
-- Dumping data for table `k3d_session_detail`
--

INSERT INTO `k3d_session_detail` (`id`, `idsession`, `idcourse`, `count`, `price`) VALUES
(1, 1, 112, 20, 15000),
(2, 1, 110, 2, 50000),
(3, 1, 162, 5, 2000),
(4, 2, 112, 32, 15000),
(5, 1, 150, 1, 30000),
(6, 1, 15, 1, 25000),
(7, 2, 110, 1, 0),
(8, 2, 126, 2, 8000),
(9, 3, 107, 3, 18000),
(10, 3, 110, 1, 50000),
(11, 4, 112, 1, 15000),
(12, 4, 162, 1, 2000),
(13, 4, 110, 1, 50000),
(14, 5, 112, 4, 15000),
(15, 5, 110, 2, 50000),
(17, 6, 112, 16, 15000),
(18, 6, 110, 1, 50000),
(19, 6, 162, 8, 2000),
(20, 6, 150, 1, 30000),
(21, 6, 143, 1, 15000),
(22, 7, 112, 20, 15000),
(23, 7, 110, 2, 50000),
(24, 7, 162, 2, 2000),
(25, 8, 110, 1, 50000),
(26, 8, 162, 9, 2000),
(28, 10, 107, 7, 18000),
(29, 10, 110, 1, 50000),
(30, 10, 116, 1, 25000),
(31, 11, 112, 6, 15000),
(32, 11, 110, 1, 50000),
(33, 11, 162, 3, 2000),
(34, 11, 15, 1, 25000),
(35, 12, 112, 17, 15000),
(36, 12, 110, 2, 50000),
(37, 12, 162, 7, 2000),
(38, 12, 126, 1, 10000);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_store`
--

CREATE TABLE IF NOT EXISTS `k3d_store` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `note` varchar(125) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=2 ;

--
-- Dumping data for table `k3d_store`
--

INSERT INTO `k3d_store` (`id`, `name`, `note`) VALUES
(1, 'Kho nhà', '');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_supplier`
--

CREATE TABLE IF NOT EXISTS `k3d_supplier` (
  `id` int(9) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `address` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `note` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `debt` bigint(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=19 ;

--
-- Dumping data for table `k3d_supplier`
--

INSERT INTO `k3d_supplier` (`id`, `name`, `phone`, `address`, `note`, `debt`) VALUES
(1, 'ĐL NƯỚC ĐÁ TRÍ', '0703456456', 'Trí Phường 4', 'Cung cấp nước đá', 0),
(6, 'COOP MART', 'chưa cập nhật', 'Vĩnh Long', '', 0),
(8, 'NPP ĐOAN TRANG', '0703 822 227', '64/6N Trần Phú P4 TP Vĩnh Long', '', 0),
(9, 'TẠP HÓA 01', '', '', '', 0),
(11, 'CH TUẤN', '0902 612 434', 'P4, TPVL', 'Cung cấp thực phẩm khô đóng gói', 0),
(12, 'VỰA TRÁI CÂY', '', '', '', 0),
(13, 'CTY CP DU LỊCH CỬU LONG', '0703828042', 'Vĩnh Long', 'c/c Bia', 0),
(14, 'CH THANH SƠN', '0703 823 842', 'Vĩnh Long', 'Cung cấp khăn lạnh', 0),
(15, 'Bia SAGOTA', '', '', '', 0),
(16, 'CHỢ VĨNH LONG', '', '', '', 0),
(17, 'TẠP HÓA 02', '', '', '', 0),
(18, 'ĐL BIA 01', '', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_table`
--

CREATE TABLE IF NOT EXISTS `k3d_table` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `iddomain` int(11) NOT NULL,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `iduser` int(11) DEFAULT NULL,
  `type` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `iddomain` (`iddomain`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=28 ;

--
-- Dumping data for table `k3d_table`
--

INSERT INTO `k3d_table` (`id`, `iddomain`, `name`, `iduser`, `type`) VALUES
(1, 1, 'Phòng 01', 0, '0'),
(2, 1, 'Phòng 02', 0, '0'),
(3, 1, 'Phòng 03', 0, '0'),
(4, 1, 'Phòng 04', 0, '0'),
(14, 2, 'Phòng 07', 0, '0'),
(15, 2, 'Phòng 08', 0, '0'),
(16, 2, 'Phòng 09', 0, '0'),
(17, 2, 'Phòng 10', 0, '0'),
(26, 3, 'Phòng 05', 0, '1'),
(27, 3, 'Phòng 06', 0, '1');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_term`
--

CREATE TABLE IF NOT EXISTS `k3d_term` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `type` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=12 ;

--
-- Dumping data for table `k3d_term`
--

INSERT INTO `k3d_term` (`id`, `name`, `type`) VALUES
(1, 'Tiền Điện', 0),
(2, 'Tiền Nước', 0),
(3, 'Thuế', 0),
(10, 'Tiền Ăn Nhân Viên', 0),
(11, 'CP Khác', 0);

-- --------------------------------------------------------

--
-- Table structure for table `k3d_term_collect`
--

CREATE TABLE IF NOT EXISTS `k3d_term_collect` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `k3d_term_collect`
--

INSERT INTO `k3d_term_collect` (`id`, `name`) VALUES
(2, 'Phụ Phẩm'),
(3, 'Đặc Biệt');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_tracking`
--

CREATE TABLE IF NOT EXISTS `k3d_tracking` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date_start` date NOT NULL,
  `date_end` date NOT NULL,
  `paid_general` int(11) NOT NULL,
  `paid_pay_roll` int(11) NOT NULL,
  `paid_import` int(11) NOT NULL,
  `collect_general` int(11) NOT NULL,
  `collect_customer` int(11) NOT NULL,
  `collect_selling_debt` int(11) NOT NULL,
  `collect_selling_nodebt` int(11) NOT NULL,
  `estate_rate` int(11) NOT NULL,
  `store_value` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_tracking_store`
--

CREATE TABLE IF NOT EXISTS `k3d_tracking_store` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_tracking` int(11) NOT NULL,
  `id_course` int(11) NOT NULL,
  `count_old` float NOT NULL,
  `count_import` float NOT NULL,
  `count_export` float NOT NULL,
  `price` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `k3d_unit`
--

CREATE TABLE IF NOT EXISTS `k3d_unit` (
  `id` int(25) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=20 ;

--
-- Dumping data for table `k3d_unit`
--

INSERT INTO `k3d_unit` (`id`, `name`) VALUES
(1, 'Ly'),
(2, 'Điếu'),
(3, 'Chai'),
(4, 'Lon'),
(5, 'Dĩa'),
(6, 'Thùng'),
(7, 'Két'),
(9, 'Bịch'),
(10, 'Gói'),
(11, 'Cái'),
(12, 'Cây'),
(13, 'Giờ'),
(14, 'Bao 20Kg'),
(15, 'Con'),
(16, 'Kg'),
(17, 'Hộp'),
(18, 'Bao 25Kg'),
(19, 'Lốc');

-- --------------------------------------------------------

--
-- Table structure for table `k3d_user`
--

CREATE TABLE IF NOT EXISTS `k3d_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pass` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `gender` int(11) NOT NULL,
  `note` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `datecreate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `dateupdate` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `dateactivity` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `type` tinyint(4) NOT NULL,
  `code` varchar(13) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `k3d_user`
--

INSERT INTO `k3d_user` (`id`, `name`, `email`, `pass`, `gender`, `note`, `datecreate`, `dateupdate`, `dateactivity`, `type`, `code`) VALUES
(1, 'B.T.Tuấn', 'tuanbuithanh@gmail.com', 'admin068368', 0, ' ', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', 4, ''),
(2, 'Khoa', 'lekhoa.bdc@gmail.com', 'lenguyen0945030709...', 0, '', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', 4, ''),
(3, 'Mai Phan', 'maiphan.bdc@gmail.com', 'admin123456', 1, '', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', 2, '123456');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `k3d_collect_customer`
--
ALTER TABLE `k3d_collect_customer`
  ADD CONSTRAINT `k3d_customer_collect_1` FOREIGN KEY (`idcustomer`) REFERENCES `k3d_customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_collect_general`
--
ALTER TABLE `k3d_collect_general`
  ADD CONSTRAINT `k3d_collect_general_1` FOREIGN KEY (`id_term`) REFERENCES `k3d_term_collect` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_course`
--
ALTER TABLE `k3d_course`
  ADD CONSTRAINT `k3d_course_1` FOREIGN KEY (`idcategory`) REFERENCES `k3d_category` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_order_import`
--
ALTER TABLE `k3d_order_import`
  ADD CONSTRAINT `k3d_order_import_1` FOREIGN KEY (`idsupplier`) REFERENCES `k3d_supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_order_import_detail`
--
ALTER TABLE `k3d_order_import_detail`
  ADD CONSTRAINT `k3d_order_import_detail_1` FOREIGN KEY (`idorder`) REFERENCES `k3d_order_import` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `k3d_order_import_detail_2` FOREIGN KEY (`idresource`) REFERENCES `k3d_resource` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_paid_customer`
--
ALTER TABLE `k3d_paid_customer`
  ADD CONSTRAINT `k3d_customer_paid_1` FOREIGN KEY (`idcustomer`) REFERENCES `k3d_customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_paid_general`
--
ALTER TABLE `k3d_paid_general`
  ADD CONSTRAINT `k3d_paid_general_1` FOREIGN KEY (`id_term`) REFERENCES `k3d_term` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_paid_pay_roll`
--
ALTER TABLE `k3d_paid_pay_roll`
  ADD CONSTRAINT `k3d_paid_pay_roll_1` FOREIGN KEY (`idemployee`) REFERENCES `k3d_employee` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_paid_supplier`
--
ALTER TABLE `k3d_paid_supplier`
  ADD CONSTRAINT `k3d_supplier_paid_1` FOREIGN KEY (`idsupplier`) REFERENCES `k3d_supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_pay_roll`
--
ALTER TABLE `k3d_pay_roll`
  ADD CONSTRAINT `k3d_pay_roll_ibfk_1` FOREIGN KEY (`id_employee`) REFERENCES `k3d_employee` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_r2c`
--
ALTER TABLE `k3d_r2c`
  ADD CONSTRAINT `k3d_r2c_1` FOREIGN KEY (`id_course`) REFERENCES `k3d_course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `k3d_r2c_2` FOREIGN KEY (`id_resource`) REFERENCES `k3d_resource` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_resource`
--
ALTER TABLE `k3d_resource`
  ADD CONSTRAINT `k3d_resource_1` FOREIGN KEY (`idsupplier`) REFERENCES `k3d_supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_session`
--
ALTER TABLE `k3d_session`
  ADD CONSTRAINT `k3d_session_1` FOREIGN KEY (`idtable`) REFERENCES `k3d_table` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `k3d_session_2` FOREIGN KEY (`iduser`) REFERENCES `k3d_user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `k3d_session_3` FOREIGN KEY (`idcustomer`) REFERENCES `k3d_customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_session_detail`
--
ALTER TABLE `k3d_session_detail`
  ADD CONSTRAINT `k3d_session_detail_1` FOREIGN KEY (`idsession`) REFERENCES `k3d_session` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `k3d_session_detail_2` FOREIGN KEY (`idcourse`) REFERENCES `k3d_course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `k3d_table`
--
ALTER TABLE `k3d_table`
  ADD CONSTRAINT `k3d_table_1` FOREIGN KEY (`iddomain`) REFERENCES `k3d_domain` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
