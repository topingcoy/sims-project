/*
Navicat MySQL Data Transfer

Source Server         : 127.0.0.1
Source Server Version : 50141
Source Host           : 127.0.0.1:3306
Source Database       : sims

Target Server Type    : MYSQL
Target Server Version : 50141
File Encoding         : 65001

Date: 2022-09-04 21:48:42
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for area
-- ----------------------------
DROP TABLE IF EXISTS `area`;
CREATE TABLE `area` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `areacode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `areaname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`areacode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of area
-- ----------------------------
INSERT INTO `area` VALUES ('1', 'OZA', 'OZAMIZ CITY', null, '2020-09-03 07:52:03');
INSERT INTO `area` VALUES ('2', 'CLA', 'CLARIN', null, '2020-09-03 07:52:08');
INSERT INTO `area` VALUES ('3', 'TUD', 'TUDELA', null, '2020-09-03 07:48:03');
INSERT INTO `area` VALUES ('4', 'SIN', 'SINACABAN', null, '2020-09-03 07:48:20');
INSERT INTO `area` VALUES ('5', 'JIM', 'JIMENEZ', null, '2020-09-03 07:48:40');
INSERT INTO `area` VALUES ('6', 'TAN', 'TANGUB', null, '2020-09-03 07:48:53');
INSERT INTO `area` VALUES ('7', 'ORO', 'OROQUIETA CITY', null, '2020-09-03 07:51:52');
INSERT INTO `area` VALUES ('8', 'PAN', 'PANAON', null, '2020-09-03 07:52:22');
INSERT INTO `area` VALUES ('9', 'ALO', 'ALORAN', null, '2020-09-03 07:52:41');
INSERT INTO `area` VALUES ('10', 'BON', 'BONIFACIO', null, '2020-09-03 07:52:55');
INSERT INTO `area` VALUES ('12', 'PAG', 'PAGADIAN CITY', null, '2020-09-23 06:26:11');

-- ----------------------------
-- Table structure for areadb
-- ----------------------------
DROP TABLE IF EXISTS `areadb`;
CREATE TABLE `areadb` (
  `pkno` int(5) NOT NULL AUTO_INCREMENT,
  `AREACODE` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `AREANAME` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`AREACODE`)
) ENGINE=MyISAM AUTO_INCREMENT=100 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of areadb
-- ----------------------------
INSERT INTO `areadb` VALUES ('1', 'OZA', 'OZAMIZ CITY');
INSERT INTO `areadb` VALUES ('2', 'YLK-CLARIN', 'CLARIN');
INSERT INTO `areadb` VALUES ('3', 'YLK-TANGUB', 'TANGUB');
INSERT INTO `areadb` VALUES ('4', 'YLK-PAGADI', 'PAGADIAN CITY');
INSERT INTO `areadb` VALUES ('5', 'YLK-DIPOLO', 'DIPOLOG CITY');
INSERT INTO `areadb` VALUES ('6', 'YLK-CALAMB', 'CALAMBA');
INSERT INTO `areadb` VALUES ('7', 'YLK-ALICIA', 'ALICIA');
INSERT INTO `areadb` VALUES ('8', 'YLK-LILOY', 'LILOY');
INSERT INTO `areadb` VALUES ('9', 'YLK-KABASA', 'KABASALAN ');
INSERT INTO `areadb` VALUES ('10', 'YLK-SINDAN', 'SINDANGAN');
INSERT INTO `areadb` VALUES ('11', 'YLK-OROQUI', 'OROQUIETA CITY');
INSERT INTO `areadb` VALUES ('12', 'YLK-DAPITA', 'DAPITAN CITY');
INSERT INTO `areadb` VALUES ('13', 'YLK-IPIL', 'IPIL');
INSERT INTO `areadb` VALUES ('14', 'YLK-LABASO', 'LABASON ');
INSERT INTO `areadb` VALUES ('15', 'YLK-MANUKA', 'MANUKAN ');
INSERT INTO `areadb` VALUES ('16', 'YLK-ALORAN', 'ALORAN');
INSERT INTO `areadb` VALUES ('17', 'YLK-AURORA', 'AURORA');
INSERT INTO `areadb` VALUES ('18', 'YLK-MARGUS', 'MARGUS SA TUBIG');
INSERT INTO `areadb` VALUES ('19', 'YLK-MOLAVE', 'MOLAVE');
INSERT INTO `areadb` VALUES ('20', 'YLK-JIMENE', 'JIMENEZ');
INSERT INTO `areadb` VALUES ('21', 'YLK-DUMING', 'DUMINGAG ');
INSERT INTO `areadb` VALUES ('22', 'YLK-TUKURA', 'TUKURAN ');
INSERT INTO `areadb` VALUES ('23', 'YLK-LEON', 'LEON POSTEGO ');
INSERT INTO `areadb` VALUES ('24', 'YLK-BALIAN', 'BALIANGAO ');
INSERT INTO `areadb` VALUES ('25', 'YLK-BAYOG', 'BAYOG ');
INSERT INTO `areadb` VALUES ('26', 'YLK-BUUG', 'BUUG ');
INSERT INTO `areadb` VALUES ('27', 'YLK-BONIFA', 'BONIFACIO ');
INSERT INTO `areadb` VALUES ('28', 'YLK-DIPLAH', 'DIPLAHAN ');
INSERT INTO `areadb` VALUES ('29', 'YLK-DIPLO', 'DIPLO ');
INSERT INTO `areadb` VALUES ('30', 'YLK-DUMALI', 'DUMALINAO ');
INSERT INTO `areadb` VALUES ('31', 'YLK-GUTALA', 'GUTALAC ');
INSERT INTO `areadb` VALUES ('32', 'YLK-IMELDA', 'IMELDA ');
INSERT INTO `areadb` VALUES ('33', 'YLK-GUIPOS', 'GUIPOS ');
INSERT INTO `areadb` VALUES ('34', 'YLK-JOSE', 'JOSE DALMAN ');
INSERT INTO `areadb` VALUES ('35', 'YLK-JOSEFI', 'JOSEFINA ');
INSERT INTO `areadb` VALUES ('36', 'YLK-KATIPU', 'KATIPUNAN ');
INSERT INTO `areadb` VALUES ('37', 'YLK-KUM', 'KUMALARANG ');
INSERT INTO `areadb` VALUES ('38', 'YLK-LABANG', 'LABANGAN ');
INSERT INTO `areadb` VALUES ('39', 'YLK-LOPEZ', 'LOPEZ JAENA ');
INSERT INTO `areadb` VALUES ('40', 'YLK-MAHAYA', 'MAHAYAG ');
INSERT INTO `areadb` VALUES ('41', 'YLK-MALANG', 'MALANGAS ');
INSERT INTO `areadb` VALUES ('42', 'YLK-MIDSAL', 'MIDSALIP ');
INSERT INTO `areadb` VALUES ('43', 'YLK-MUTIA', 'MUTIA ');
INSERT INTO `areadb` VALUES ('44', 'YLK-NAGA', 'NAGA ');
INSERT INTO `areadb` VALUES ('45', 'YLK-PANA-O', 'PANA-ON ');
INSERT INTO `areadb` VALUES ('46', 'YLK-PAYAO', 'PAYAO ');
INSERT INTO `areadb` VALUES ('47', 'YLK-PIÑAN', 'PIÑAN ');
INSERT INTO `areadb` VALUES ('48', 'YLK-PITOGO', 'PITOGO ');
INSERT INTO `areadb` VALUES ('49', 'YLK-PLARID', 'PLARIDEL ');
INSERT INTO `areadb` VALUES ('50', 'YLK-RIZAL', 'RIZAL ');
INSERT INTO `areadb` VALUES ('51', 'YLK-RT.LIM', 'ROSELLER LIM ');
INSERT INTO `areadb` VALUES ('52', 'YLK-ROXAS', 'ROXAS ');
INSERT INTO `areadb` VALUES ('53', 'YLK-SALUG', 'SALUG ');
INSERT INTO `areadb` VALUES ('54', 'YLK-SAPANG', 'SAPANG DALAGA ');
INSERT INTO `areadb` VALUES ('55', 'YLK-SIAY', 'SIAY');
INSERT INTO `areadb` VALUES ('56', 'YLK-SIAYAN', 'SIAYAN ');
INSERT INTO `areadb` VALUES ('57', 'YLK-SIBUTA', 'SIBUTAD ');
INSERT INTO `areadb` VALUES ('58', 'YLK-SINACA', 'SINACABAN ');
INSERT INTO `areadb` VALUES ('59', 'YLK-TABINA', 'TABINA ');
INSERT INTO `areadb` VALUES ('60', 'YLK-TALUSA', 'TALUSAN ');
INSERT INTO `areadb` VALUES ('61', 'YLK-TAMBUL', 'TAMBULIG ');
INSERT INTO `areadb` VALUES ('62', 'YLK-TAMPI', 'TAMPILISAN ');
INSERT INTO `areadb` VALUES ('63', 'YLK-TIGBAO', 'TIGBAO');
INSERT INTO `areadb` VALUES ('64', 'YLK-TITAY', 'TITAY');
INSERT INTO `areadb` VALUES ('65', 'YLK-TUDELA', 'TUDELA ');
INSERT INTO `areadb` VALUES ('66', 'YLK-TUNGAW', 'TUNGAWAN ');
INSERT INTO `areadb` VALUES ('67', 'YLK-POLANC', 'POLANCO ');
INSERT INTO `areadb` VALUES ('68', 'YLK-SUMINO', 'SUMINOT');
INSERT INTO `areadb` VALUES ('69', 'YLK-KALAWI', 'KALAWIT');
INSERT INTO `areadb` VALUES ('70', 'YLK-LA LI', 'LA LIBERTAD ');
INSERT INTO `areadb` VALUES ('71', 'YLK-DINAS', 'DINAS');
INSERT INTO `areadb` VALUES ('72', 'YLK-LKWD', 'LAKEWOOD');
INSERT INTO `areadb` VALUES ('73', 'YLK-SAN M', 'SAN MIGUEL');
INSERT INTO `areadb` VALUES ('74', 'YLK-SAN P', 'SAN PABLO');
INSERT INTO `areadb` VALUES ('75', 'YLK-MABU', 'MABUHAY ');
INSERT INTO `areadb` VALUES ('76', 'YLK-DIMATA', 'DIMATALING ');
INSERT INTO `areadb` VALUES ('77', 'YLK-RAMON', 'RAMON MAGSAYSAY ');
INSERT INTO `areadb` VALUES ('78', 'YLK-OSMEÑA', 'OSMEÑA ');
INSERT INTO `areadb` VALUES ('79', 'YLK-OLUTAN', 'OLUTANGA');
INSERT INTO `areadb` VALUES ('80', 'YLK-SIOCON', 'SIOCON');
INSERT INTO `areadb` VALUES ('81', 'YLK-GUICAM', 'GUICAM');
INSERT INTO `areadb` VALUES ('82', 'YLK-SAMPUL', 'SAMPULI ');
INSERT INTO `areadb` VALUES ('83', 'YLK-LAPUY', 'LAPUYAN ');
INSERT INTO `areadb` VALUES ('84', 'YLK-DONVIC', 'DON VICTORIANO');
INSERT INTO `areadb` VALUES ('85', 'YLK-LANAO', 'LANAO DEL NORTE');
INSERT INTO `areadb` VALUES ('86', 'YLK-MARAND', 'MARANDING');
INSERT INTO `areadb` VALUES ('87', 'YLK-KAPATA', 'KAPATAGAN');
INSERT INTO `areadb` VALUES ('88', 'YLK-TUBOD', 'TUBOD');
INSERT INTO `areadb` VALUES ('89', 'YLK-BUAYAN', 'BUAYAN');
INSERT INTO `areadb` VALUES ('90', 'YLK-BACU', 'BACUNGAN');
INSERT INTO `areadb` VALUES ('91', 'YLK-CDO', 'YLK-CDO');
INSERT INTO `areadb` VALUES ('93', 'SAGUN', 'SAGUN');
INSERT INTO `areadb` VALUES ('94', 'SAG', 'SAGUN ');
INSERT INTO `areadb` VALUES ('95', 'BAR', 'BAROY');
INSERT INTO `areadb` VALUES ('96', 'SAP', 'SAPAD');
INSERT INTO `areadb` VALUES ('97', 'SAL', 'SALVADOR');
INSERT INTO `areadb` VALUES ('98', 'LALA', 'LALA');
INSERT INTO `areadb` VALUES ('99', 'SND', 'SULTAN NAGA DIMAPORO');

-- ----------------------------
-- Table structure for audittrail
-- ----------------------------
DROP TABLE IF EXISTS `audittrail`;
CREATE TABLE `audittrail` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `user` varchar(10) CHARACTER SET utf8 NOT NULL,
  `transactions` varchar(350) CHARACTER SET utf8 DEFAULT NULL,
  `module` varchar(200) CHARACTER SET utf8 DEFAULT '0',
  `sdate` date DEFAULT NULL,
  `stime` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`user`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=928 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of audittrail
-- ----------------------------
INSERT INTO `audittrail` VALUES ('1', '1', 'Trans No.:R000000001  PO. No.:A  Invoice No.:A  Supplier:GSPI', 'Save&Print Receiving', '2022-03-16', '10:03:46 PM', '2022-03-16 14:03:22');
INSERT INTO `audittrail` VALUES ('2', '1', 'Login', 'Login', '2022-03-16', '10:11:02 PM', '2022-03-16 14:10:38');
INSERT INTO `audittrail` VALUES ('3', '1', 'Login', 'Login', '2022-03-16', '10:13:37 PM', '2022-03-16 14:13:13');
INSERT INTO `audittrail` VALUES ('4', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-16', '10:14:54 PM', '2022-03-16 14:14:30');
INSERT INTO `audittrail` VALUES ('5', '1', 'Logout', 'Logout', '2022-03-16', '10:15:37 PM', '2022-03-16 14:15:13');
INSERT INTO `audittrail` VALUES ('6', 'toping', 'Login', 'Login', '2022-03-17', '9:10:20 AM', '2022-03-17 01:09:56');
INSERT INTO `audittrail` VALUES ('7', 'toping', 'Trans No.:R000000001  PO. No.:A  Invoice No.:A  Supplier:GSPI', 'Save&Print Receiving', '2022-03-17', '9:11:25 AM', '2022-03-17 01:11:01');
INSERT INTO `audittrail` VALUES ('8', 'toping', 'Login', 'Login', '2022-03-17', '9:12:54 AM', '2022-03-17 01:12:30');
INSERT INTO `audittrail` VALUES ('9', '1', 'Login', 'Login', '2022-03-17', '9:14:20 AM', '2022-03-17 01:13:56');
INSERT INTO `audittrail` VALUES ('10', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Add Receiving', '2022-03-17', '9:16:46 AM', '2022-03-17 01:16:22');
INSERT INTO `audittrail` VALUES ('11', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B', 'Delete Receiving', '2022-03-17', '9:17:31 AM', '2022-03-17 01:17:07');
INSERT INTO `audittrail` VALUES ('12', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-17', '9:18:42 AM', '2022-03-17 01:18:18');
INSERT INTO `audittrail` VALUES ('13', '1', 'Logout', 'Logout', '2022-03-17', '9:22:04 AM', '2022-03-17 01:21:40');
INSERT INTO `audittrail` VALUES ('14', '1', 'Login', 'Login', '2022-03-17', '2:31:08 PM', '2022-03-17 06:30:44');
INSERT INTO `audittrail` VALUES ('15', '1', 'Code.: 3180223261  Description: MAGNOLIA CHEEZEE BLOCK 48/165G  Supplier: GSPI  Category: BF', 'Add New Item', '2022-03-17', '2:32:22 PM', '2022-03-17 06:31:58');
INSERT INTO `audittrail` VALUES ('16', '1', 'Login', 'Login', '2022-03-18', '10:20:32 AM', '2022-03-18 02:20:08');
INSERT INTO `audittrail` VALUES ('17', '1', 'Code: 3180223261  Description: 3180223261  Supplier: GSPI  Category: BF', 'Delete Item', '2022-03-18', '10:21:16 AM', '2022-03-18 02:20:52');
INSERT INTO `audittrail` VALUES ('18', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-03-18', '10:21:56 AM', '2022-03-18 02:21:32');
INSERT INTO `audittrail` VALUES ('19', '1', 'Code.: GIV  Category name: GIV BEAUTY SOAP', 'Add Category', '2022-03-18', '10:24:01 AM', '2022-03-18 02:23:37');
INSERT INTO `audittrail` VALUES ('20', '1', 'Code.: GB80  Description: GIV BEAUTY SOAP BLUE 80GX72  Supplier: GSPI  Category: GIV', 'Add New Item', '2022-03-18', '10:24:45 AM', '2022-03-18 02:24:21');
INSERT INTO `audittrail` VALUES ('21', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-18', '10:25:34 AM', '2022-03-18 02:25:10');
INSERT INTO `audittrail` VALUES ('22', '1', 'Login', 'Login', '2022-03-18', '2:37:55 PM', '2022-03-18 06:37:31');
INSERT INTO `audittrail` VALUES ('23', '1', 'Logout', 'Logout', '2022-03-18', '2:43:49 PM', '2022-03-18 06:43:25');
INSERT INTO `audittrail` VALUES ('24', '1', 'Login', 'Login', '2022-03-18', '4:40:03 PM', '2022-03-18 08:39:39');
INSERT INTO `audittrail` VALUES ('25', '1', 'Logout', 'Logout', '2022-03-18', '4:48:44 PM', '2022-03-18 08:48:20');
INSERT INTO `audittrail` VALUES ('26', '1', 'Login', 'Login', '2022-03-18', '7:27:57 PM', '2022-03-18 11:27:33');
INSERT INTO `audittrail` VALUES ('27', '1', 'Login', 'Login', '2022-03-18', '7:30:08 PM', '2022-03-18 11:29:44');
INSERT INTO `audittrail` VALUES ('28', '1', 'Login', 'Login', '2022-03-18', '7:31:03 PM', '2022-03-18 11:30:39');
INSERT INTO `audittrail` VALUES ('29', '1', 'Login', 'Login', '2022-03-18', '7:33:22 PM', '2022-03-18 11:32:58');
INSERT INTO `audittrail` VALUES ('30', '1', 'Login', 'Login', '2022-03-18', '8:01:37 PM', '2022-03-18 12:01:13');
INSERT INTO `audittrail` VALUES ('31', '1', 'Login', 'Login', '2022-03-18', '8:02:34 PM', '2022-03-18 12:02:10');
INSERT INTO `audittrail` VALUES ('32', '1', 'Login', 'Login', '2022-03-18', '8:21:16 PM', '2022-03-18 12:20:52');
INSERT INTO `audittrail` VALUES ('33', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-18', '8:35:10 PM', '2022-03-18 12:34:46');
INSERT INTO `audittrail` VALUES ('34', '1', 'Login', 'Login', '2022-03-18', '9:24:40 PM', '2022-03-18 13:24:16');
INSERT INTO `audittrail` VALUES ('35', '1', 'Login', 'Login', '2022-03-18', '9:31:39 PM', '2022-03-18 13:31:15');
INSERT INTO `audittrail` VALUES ('36', '1', 'Login', 'Login', '2022-03-18', '9:33:42 PM', '2022-03-18 13:33:18');
INSERT INTO `audittrail` VALUES ('37', '1', 'Login', 'Login', '2022-03-18', '9:35:15 PM', '2022-03-18 13:34:51');
INSERT INTO `audittrail` VALUES ('38', '1', 'Login', 'Login', '2022-03-18', '9:36:37 PM', '2022-03-18 13:36:13');
INSERT INTO `audittrail` VALUES ('39', '1', 'Login', 'Login', '2022-03-18', '9:38:10 PM', '2022-03-18 13:37:46');
INSERT INTO `audittrail` VALUES ('40', '1', 'Login', 'Login', '2022-03-18', '10:08:36 PM', '2022-03-18 14:08:12');
INSERT INTO `audittrail` VALUES ('41', '1', 'Login', 'Login', '2022-03-19', '8:31:41 AM', '2022-03-19 00:31:17');
INSERT INTO `audittrail` VALUES ('42', '1', 'Code.: GP80  Description: GIV BEAUTY SOAP PINK 80GX72  Supplier: GSPI  Category: GIV', 'Add New Item', '2022-03-19', '8:32:33 AM', '2022-03-19 00:32:09');
INSERT INTO `audittrail` VALUES ('43', '1', 'Code.: GW80  Description: GIV BEAUTY SOAP WHITE 80GX72  Supplier: GSPI  Category: GIV', 'Add New Item', '2022-03-19', '8:33:21 AM', '2022-03-19 00:32:57');
INSERT INTO `audittrail` VALUES ('44', '1', 'Code.: MSD  Description: MISEDAAP NOODLES 40X5  Supplier: GSPI  Category: BF', 'Update Item', '2022-03-19', '8:33:53 AM', '2022-03-19 00:33:29');
INSERT INTO `audittrail` VALUES ('45', '1', 'Code.: MSK  Description: MISEDAAP KALAMANSI 40X5  Supplier: GSPI  Category: BF', 'Update Item', '2022-03-19', '8:34:13 AM', '2022-03-19 00:33:49');
INSERT INTO `audittrail` VALUES ('46', '1', 'Code.: MSD  Description: MISEDAAP NOODLES 40X5  Supplier: GSPI  Category: BF', 'Update Item', '2022-03-19', '8:34:28 AM', '2022-03-19 00:34:04');
INSERT INTO `audittrail` VALUES ('47', '1', 'Login', 'Login', '2022-03-19', '8:38:41 AM', '2022-03-19 00:38:17');
INSERT INTO `audittrail` VALUES ('48', '1', 'Login', 'Login', '2022-03-19', '8:40:13 AM', '2022-03-19 00:39:49');
INSERT INTO `audittrail` VALUES ('49', '1', 'Code.: GBR80  Description: GIV BEAUTY SOAP BROWN 80GX72  Supplier: GSPI  Category: GIV', 'Add New Item', '2022-03-19', '8:41:12 AM', '2022-03-19 00:40:48');
INSERT INTO `audittrail` VALUES ('50', '1', 'Login', 'Login', '2022-03-19', '8:46:53 AM', '2022-03-19 00:46:29');
INSERT INTO `audittrail` VALUES ('51', '1', 'Code.: MKS  Description: MISEDAAP KOREAN SPICY CHICKEN 87G 40X5  Supplier: GSPI  Category: MD', 'Add New Item', '2022-03-19', '8:49:55 AM', '2022-03-19 00:49:31');
INSERT INTO `audittrail` VALUES ('52', '1', 'Login', 'Login', '2022-03-19', '8:51:08 AM', '2022-03-19 00:50:44');
INSERT INTO `audittrail` VALUES ('53', '1', 'Code.: MMA  Description: MISEDAAP MIGORENG ASLI 91G 40X5  Supplier: GSPI  Category: MD', 'Add New Item', '2022-03-19', '9:00:28 AM', '2022-03-19 01:00:04');
INSERT INTO `audittrail` VALUES ('54', '1', 'Code.: MAB  Description: MISEDAAP MISUP AYAMBAWANG 70G 40X5  Supplier: GSPI  Category: MD', 'Add New Item', '2022-03-19', '9:01:54 AM', '2022-03-19 01:01:30');
INSERT INTO `audittrail` VALUES ('55', '1', 'Code.: MSK  Description: MISEDAAP KALAMANSI 70G 40X5  Supplier: GSPI  Category: BF', 'Update Item', '2022-03-19', '9:02:30 AM', '2022-03-19 01:02:06');
INSERT INTO `audittrail` VALUES ('56', '1', 'Login', 'Login', '2022-03-19', '9:04:50 AM', '2022-03-19 01:04:26');
INSERT INTO `audittrail` VALUES ('57', '1', 'Code.: MPS  Description: MISEDAAP MISUP PERISASOTO 70G 40X5  Supplier: GSPI  Category: MD', 'Add New Item', '2022-03-19', '9:05:46 AM', '2022-03-19 01:05:22');
INSERT INTO `audittrail` VALUES ('58', '1', 'Code.: MSD  Description: MISEDAAP NOODLES 70G 40X5  Supplier: GSPI  Category: BF', 'Update Item', '2022-03-19', '9:06:08 AM', '2022-03-19 01:05:44');
INSERT INTO `audittrail` VALUES ('59', '1', 'Login', 'Login', '2022-03-19', '9:08:34 AM', '2022-03-19 01:08:10');
INSERT INTO `audittrail` VALUES ('60', '1', 'Login', 'Login', '2022-03-19', '9:11:24 AM', '2022-03-19 01:11:00');
INSERT INTO `audittrail` VALUES ('61', '1', 'Login', 'Login', '2022-03-19', '9:12:29 AM', '2022-03-19 01:12:05');
INSERT INTO `audittrail` VALUES ('62', '1', 'Login', 'Login', '2022-03-19', '9:16:15 AM', '2022-03-19 01:15:51');
INSERT INTO `audittrail` VALUES ('63', '1', 'Login', 'Login', '2022-03-19', '9:17:37 AM', '2022-03-19 01:17:13');
INSERT INTO `audittrail` VALUES ('64', '1', 'Login', 'Login', '2022-03-19', '9:19:15 AM', '2022-03-19 01:18:51');
INSERT INTO `audittrail` VALUES ('65', '1', 'Code.: W100  Description: WINGS BAR WHITE 100GX36  Supplier: GSPI  Category: PD', 'Add New Item', '2022-03-19', '9:21:18 AM', '2022-03-19 01:20:54');
INSERT INTO `audittrail` VALUES ('66', '1', 'Login', 'Login', '2022-03-19', '9:24:21 AM', '2022-03-19 01:23:57');
INSERT INTO `audittrail` VALUES ('67', '1', 'Code.: W420  Description: WINGS WHITE BAR 36X420G  Supplier: GSPI  Category: PD', 'Add New Item', '2022-03-19', '9:25:49 AM', '2022-03-19 01:25:25');
INSERT INTO `audittrail` VALUES ('68', '1', 'Login', 'Login', '2022-03-19', '9:27:00 AM', '2022-03-19 01:26:36');
INSERT INTO `audittrail` VALUES ('69', '1', 'Login', 'Login', '2022-03-19', '9:28:08 AM', '2022-03-19 01:27:44');
INSERT INTO `audittrail` VALUES ('70', '1', 'Code.: W390  Description: WINGS BAR WGITE DETERGENT 150GX96  Supplier: GSPI  Category: PD', 'Add New Item', '2022-03-19', '9:30:43 AM', '2022-03-19 01:30:19');
INSERT INTO `audittrail` VALUES ('71', '1', 'Login', 'Login', '2022-03-19', '10:09:03 AM', '2022-03-19 02:08:39');
INSERT INTO `audittrail` VALUES ('72', '1', 'Trans No.: R000000001  PO. No.: TES1  Invoice No.:  TEST1  Supplier: GSPI', 'Add Receiving', '2022-03-19', '10:10:47 AM', '2022-03-19 02:10:23');
INSERT INTO `audittrail` VALUES ('73', '1', 'Login', 'Login', '2022-03-19', '10:15:26 AM', '2022-03-19 02:15:02');
INSERT INTO `audittrail` VALUES ('74', '1', 'Login', 'Login', '2022-03-19', '10:16:35 AM', '2022-03-19 02:16:11');
INSERT INTO `audittrail` VALUES ('75', '1', 'Login', 'Login', '2022-03-19', '10:33:46 AM', '2022-03-19 02:33:22');
INSERT INTO `audittrail` VALUES ('76', '1', 'Code.: MSD  Description: MISEDAAP NOODLES REGULAR 70G 40X5  Supplier: GSPI  Category: MD', 'Update Item', '2022-03-19', '10:34:48 AM', '2022-03-19 02:34:24');
INSERT INTO `audittrail` VALUES ('77', '1', 'Login', 'Login', '2022-03-19', '10:49:14 AM', '2022-03-19 02:48:50');
INSERT INTO `audittrail` VALUES ('78', '1', 'Customer Code:20220101  Customer Name:GAISANO CITIMALL OZAMIZ ', 'Customer Entry', '2022-03-19', '10:50:39 AM', '2022-03-19 02:50:15');
INSERT INTO `audittrail` VALUES ('79', '1', 'Login', 'Login', '2022-03-19', '10:51:50 AM', '2022-03-19 02:51:26');
INSERT INTO `audittrail` VALUES ('80', '1', 'Code.: BAR  Category name: BAR DETERGENT', 'Add Category', '2022-03-19', '10:52:41 AM', '2022-03-19 02:52:17');
INSERT INTO `audittrail` VALUES ('81', '1', 'Code.: W390  Description: WINGS BAR WGITE DETERGENT 150GX96  Supplier: GSPI  Category: BAR', 'Update Item', '2022-03-19', '10:52:59 AM', '2022-03-19 02:52:35');
INSERT INTO `audittrail` VALUES ('82', '1', 'Code.: W100  Description: WINGS BAR WHITE 100GX36  Supplier: GSPI  Category: BAR', 'Update Item', '2022-03-19', '10:53:08 AM', '2022-03-19 02:52:44');
INSERT INTO `audittrail` VALUES ('83', '1', 'Code.: MSK  Description: MISEDAAP KALAMANSI 70G 40X5  Supplier: GSPI  Category: MD', 'Update Item', '2022-03-19', '10:53:35 AM', '2022-03-19 02:53:11');
INSERT INTO `audittrail` VALUES ('84', '1', 'Trans No.: R000000001  PO. No.: TES1  Invoice No.:  TEST1  Supplier: GSPI', 'Update Receiving', '2022-03-19', '10:54:02 AM', '2022-03-19 02:53:38');
INSERT INTO `audittrail` VALUES ('85', '1', 'Customer Code:20220102  Customer Name:UNITOP OZAMIZ', 'Customer Entry', '2022-03-19', '10:56:55 AM', '2022-03-19 02:56:31');
INSERT INTO `audittrail` VALUES ('86', '1', 'Login', 'Login', '2022-03-19', '12:50:42 PM', '2022-03-19 04:50:18');
INSERT INTO `audittrail` VALUES ('87', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-03-19', '12:50:59 PM', '2022-03-19 04:50:35');
INSERT INTO `audittrail` VALUES ('88', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-19', '12:51:22 PM', '2022-03-19 04:50:58');
INSERT INTO `audittrail` VALUES ('89', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-19', '12:52:56 PM', '2022-03-19 04:52:32');
INSERT INTO `audittrail` VALUES ('90', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-19', '12:53:31 PM', '2022-03-19 04:53:07');
INSERT INTO `audittrail` VALUES ('91', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-19', '12:53:54 PM', '2022-03-19 04:53:30');
INSERT INTO `audittrail` VALUES ('92', '1', 'Login', 'Login', '2022-03-19', '2:22:41 PM', '2022-03-19 06:22:17');
INSERT INTO `audittrail` VALUES ('93', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-03-19', '2:23:49 PM', '2022-03-19 06:23:25');
INSERT INTO `audittrail` VALUES ('94', '1', 'Login', 'Login', '2022-03-19', '3:14:46 PM', '2022-03-19 07:14:22');
INSERT INTO `audittrail` VALUES ('95', '1', 'Trans No.: R000000002  PO. No.: AB  Invoice No.:  AB  Supplier: GSPI', 'Add Receiving', '2022-03-19', '3:18:59 PM', '2022-03-19 07:18:35');
INSERT INTO `audittrail` VALUES ('96', '1', 'Login', 'Login', '2022-03-19', '3:21:18 PM', '2022-03-19 07:20:54');
INSERT INTO `audittrail` VALUES ('97', '1', 'Login', 'Login', '2022-03-19', '3:41:23 PM', '2022-03-19 07:40:59');
INSERT INTO `audittrail` VALUES ('98', '1', 'Login', 'Login', '2022-03-19', '3:54:24 PM', '2022-03-19 07:54:00');
INSERT INTO `audittrail` VALUES ('99', '1', 'Login', 'Login', '2022-03-19', '4:28:12 PM', '2022-03-19 08:27:48');
INSERT INTO `audittrail` VALUES ('100', '1', 'Login', 'Login', '2022-03-19', '4:34:47 PM', '2022-03-19 08:34:23');
INSERT INTO `audittrail` VALUES ('101', '1', 'Login', 'Login', '2022-03-19', '4:45:43 PM', '2022-03-19 08:45:19');
INSERT INTO `audittrail` VALUES ('102', '1', 'Login', 'Login', '2022-03-19', '4:48:08 PM', '2022-03-19 08:47:44');
INSERT INTO `audittrail` VALUES ('103', '1', 'Logout', 'Logout', '2022-03-19', '4:49:19 PM', '2022-03-19 08:48:55');
INSERT INTO `audittrail` VALUES ('104', '1', 'Login', 'Login', '2022-03-24', '2:36:43 PM', '2022-03-24 06:36:19');
INSERT INTO `audittrail` VALUES ('105', '1', 'Trans No.: O000000004  Date:  3/24/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-03-24', '2:51:35 PM', '2022-03-24 06:51:11');
INSERT INTO `audittrail` VALUES ('106', '1', 'Logout', 'Logout', '2022-03-24', '2:52:38 PM', '2022-03-24 06:52:14');
INSERT INTO `audittrail` VALUES ('107', '1', 'Login', 'Login', '2022-03-24', '3:02:54 PM', '2022-03-24 07:02:30');
INSERT INTO `audittrail` VALUES ('108', '1', 'Login', 'Login', '2022-03-24', '3:21:46 PM', '2022-03-24 07:21:22');
INSERT INTO `audittrail` VALUES ('109', '1', 'Login', 'Login', '2022-03-24', '3:25:00 PM', '2022-03-24 07:24:36');
INSERT INTO `audittrail` VALUES ('110', '1', 'Trans No.: O000000004  Date:   3/24/2022Warehouse: YU LINKON JR. GEN. MDSE.', 'Delete Misc. Stock Out', '2022-03-24', '3:25:04 PM', '2022-03-24 07:24:40');
INSERT INTO `audittrail` VALUES ('111', '1', 'Trans No.: O000000005  Date:  3/24/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-03-24', '4:05:05 PM', '2022-03-24 08:04:41');
INSERT INTO `audittrail` VALUES ('112', '1', 'Login', 'Login', '2022-03-25', '3:29:31 PM', '2022-03-25 07:29:07');
INSERT INTO `audittrail` VALUES ('113', '1', 'Trans No.: O000000006  Date:  3/25/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-03-25', '4:10:09 PM', '2022-03-25 08:09:45');
INSERT INTO `audittrail` VALUES ('114', '1', 'Trans No.: O000000008  Date:  3/25/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-03-25', '4:38:35 PM', '2022-03-25 08:38:11');
INSERT INTO `audittrail` VALUES ('115', '1', 'Logout', 'Logout', '2022-03-25', '4:46:52 PM', '2022-03-25 08:46:28');
INSERT INTO `audittrail` VALUES ('116', '1', 'Login', 'Login', '2022-03-27', '4:31:10 PM', '2022-03-27 08:30:46');
INSERT INTO `audittrail` VALUES ('117', '1', 'Login', 'Login', '2022-03-30', '7:32:31 PM', '2022-03-30 19:32:31');
INSERT INTO `audittrail` VALUES ('118', '1', 'Login', 'Login', '2022-03-30', '7:41:56 PM', '2022-03-30 19:41:56');
INSERT INTO `audittrail` VALUES ('119', '1', 'Login', 'Login', '2022-03-30', '8:06:54 PM', '2022-03-30 20:06:54');
INSERT INTO `audittrail` VALUES ('120', '1', 'Login', 'Login', '2022-03-30', '8:16:57 PM', '2022-03-30 20:16:57');
INSERT INTO `audittrail` VALUES ('121', '1', 'Logout', 'Logout', '2022-03-30', '8:35:57 PM', '2022-03-30 20:35:57');
INSERT INTO `audittrail` VALUES ('122', '1', 'Login', 'Login', '2022-03-30', '8:36:47 PM', '2022-03-30 20:36:47');
INSERT INTO `audittrail` VALUES ('123', '1', 'Login', 'Login', '2022-03-30', '8:43:20 PM', '2022-03-30 20:43:20');
INSERT INTO `audittrail` VALUES ('124', '1', 'Login', 'Login', '2022-03-30', '8:54:05 PM', '2022-03-30 20:54:05');
INSERT INTO `audittrail` VALUES ('125', '1', 'Login', 'Login', '2022-03-30', '9:04:29 PM', '2022-03-30 21:04:29');
INSERT INTO `audittrail` VALUES ('126', '1', 'Login', 'Login', '2022-03-30', '9:18:26 PM', '2022-03-30 21:18:26');
INSERT INTO `audittrail` VALUES ('127', '1', 'Login', 'Login', '2022-03-30', '9:21:30 PM', '2022-03-30 21:21:30');
INSERT INTO `audittrail` VALUES ('128', '1', 'Login', 'Login', '2022-03-30', '9:23:50 PM', '2022-03-30 21:23:50');
INSERT INTO `audittrail` VALUES ('129', '1', 'Login', 'Login', '2022-03-30', '9:40:42 PM', '2022-03-30 21:40:42');
INSERT INTO `audittrail` VALUES ('130', '1', 'Logout', 'Logout', '2022-03-30', '9:43:27 PM', '2022-03-30 21:43:27');
INSERT INTO `audittrail` VALUES ('131', '1', 'Login', 'Login', '2022-03-30', '9:48:20 PM', '2022-03-30 21:48:20');
INSERT INTO `audittrail` VALUES ('132', '1', 'Logout', 'Logout', '2022-03-30', '9:50:50 PM', '2022-03-30 21:50:50');
INSERT INTO `audittrail` VALUES ('133', '1', 'Login', 'Login', '2022-03-30', '9:51:28 PM', '2022-03-30 21:51:28');
INSERT INTO `audittrail` VALUES ('134', '1', 'Login', 'Login', '2022-03-30', '9:56:21 PM', '2022-03-30 21:56:21');
INSERT INTO `audittrail` VALUES ('135', '1', 'Login', 'Login', '2022-03-30', '10:04:27 PM', '2022-03-30 22:04:27');
INSERT INTO `audittrail` VALUES ('136', '1', 'Login', 'Login', '2022-03-30', '10:07:43 PM', '2022-03-30 22:07:43');
INSERT INTO `audittrail` VALUES ('137', '1', 'Login', 'Login', '2022-03-30', '10:10:03 PM', '2022-03-30 22:10:03');
INSERT INTO `audittrail` VALUES ('138', '1', 'Login', 'Login', '2022-03-30', '10:11:40 PM', '2022-03-30 22:11:40');
INSERT INTO `audittrail` VALUES ('139', '1', 'Login', 'Login', '2022-03-30', '10:18:37 PM', '2022-03-30 22:18:37');
INSERT INTO `audittrail` VALUES ('140', '1', 'Login', 'Login', '2022-03-30', '10:24:13 PM', '2022-03-30 22:24:13');
INSERT INTO `audittrail` VALUES ('141', '1', 'Logout', 'Logout', '2022-03-30', '10:25:35 PM', '2022-03-30 22:25:35');
INSERT INTO `audittrail` VALUES ('142', '1', 'Login', 'Login', '2022-04-12', '9:06:20 PM', '2022-04-12 21:06:20');
INSERT INTO `audittrail` VALUES ('143', '1', 'Login', 'Login', '2022-04-12', '9:29:56 PM', '2022-04-12 21:29:56');
INSERT INTO `audittrail` VALUES ('144', '1', 'Login', 'Login', '2022-04-12', '9:45:43 PM', '2022-04-12 21:45:43');
INSERT INTO `audittrail` VALUES ('145', '1', 'Logout', 'Logout', '2022-04-12', '10:19:30 PM', '2022-04-12 22:19:30');
INSERT INTO `audittrail` VALUES ('146', '1', 'Login', 'Login', '2022-04-12', '10:28:06 PM', '2022-04-12 22:28:06');
INSERT INTO `audittrail` VALUES ('147', '1', 'Login', 'Login', '2022-04-12', '10:51:05 PM', '2022-04-12 22:51:05');
INSERT INTO `audittrail` VALUES ('148', '1', 'Login', 'Login', '2022-04-12', '10:59:16 PM', '2022-04-12 22:59:16');
INSERT INTO `audittrail` VALUES ('149', '1', 'Logout', 'Logout', '2022-04-12', '10:59:28 PM', '2022-04-12 22:59:28');
INSERT INTO `audittrail` VALUES ('150', '1', 'Login', 'Login', '2022-04-12', '11:00:20 PM', '2022-04-12 23:00:20');
INSERT INTO `audittrail` VALUES ('151', '1', 'Login', 'Login', '2022-04-12', '11:05:04 PM', '2022-04-12 23:05:04');
INSERT INTO `audittrail` VALUES ('152', '1', 'Login', 'Login', '2022-04-12', '11:14:02 PM', '2022-04-12 23:14:02');
INSERT INTO `audittrail` VALUES ('153', '1', 'Login', 'Login', '2022-04-12', '11:22:34 PM', '2022-04-12 23:22:34');
INSERT INTO `audittrail` VALUES ('154', '1', 'Login', 'Login', '2022-04-12', '11:36:26 PM', '2022-04-12 23:36:26');
INSERT INTO `audittrail` VALUES ('155', '1', 'Login', 'Login', '2022-04-12', '11:38:49 PM', '2022-04-12 23:38:49');
INSERT INTO `audittrail` VALUES ('156', '1', 'Login', 'Login', '2022-04-12', '11:57:33 PM', '2022-04-12 23:57:33');
INSERT INTO `audittrail` VALUES ('157', '1', 'Login', 'Login', '2022-04-12', '11:59:00 PM', '2022-04-12 23:59:00');
INSERT INTO `audittrail` VALUES ('158', '1', 'Logout', 'Logout', '2022-04-12', '11:59:19 PM', '2022-04-12 23:59:19');
INSERT INTO `audittrail` VALUES ('159', '1', 'Login', 'Login', '2022-04-12', '11:59:56 PM', '2022-04-12 23:59:56');
INSERT INTO `audittrail` VALUES ('160', '1', 'Login', 'Login', '2022-04-13', '12:09:04 AM', '2022-04-13 00:09:04');
INSERT INTO `audittrail` VALUES ('161', '1', 'Login', 'Login', '2022-04-13', '12:21:11 AM', '2022-04-13 00:21:11');
INSERT INTO `audittrail` VALUES ('162', '1', 'Code.: A  Description: AMPROLLIUM(ORAL)1LTR  Supplier: MD  Category: LSA', 'Update Item', '2022-04-13', '12:21:30 AM', '2022-04-13 00:21:30');
INSERT INTO `audittrail` VALUES ('163', '1', 'Code.: A  Description: AMPROLLIUM(ORAL)1LTR  Supplier: MD  Category: LSA', 'Update Item', '2022-04-13', '12:22:51 AM', '2022-04-13 00:22:51');
INSERT INTO `audittrail` VALUES ('164', '1', 'Logout', 'Logout', '2022-04-13', '12:36:01 AM', '2022-04-13 00:36:01');
INSERT INTO `audittrail` VALUES ('165', '1', 'Login', 'Login', '2022-04-14', '1:28:28 PM', '2022-04-14 05:28:04');
INSERT INTO `audittrail` VALUES ('166', '1', 'Login', 'Login', '2022-04-14', '1:34:52 PM', '2022-04-14 05:34:28');
INSERT INTO `audittrail` VALUES ('167', '1', 'Login', 'Login', '2022-04-14', '1:42:47 PM', '2022-04-14 05:42:23');
INSERT INTO `audittrail` VALUES ('168', '1', 'Code.: GBR80  Description: GIV BEAUTY SOAP BROWN 80GX72  Supplier: GSPI  Category: GIV', 'Update Item', '2022-04-14', '1:44:32 PM', '2022-04-14 05:44:08');
INSERT INTO `audittrail` VALUES ('169', '1', 'Code.: GBR80  Description: GIV BEAUTY SOAP BROWN 80GX72  Supplier: GSPI  Category: GIV', 'Update Item', '2022-04-14', '1:44:52 PM', '2022-04-14 05:44:28');
INSERT INTO `audittrail` VALUES ('170', '1', 'Trans No.:R000000001  PO. No.:PO1  Invoice No.:INV1  Supplier:GSPI', 'Save&Print Receiving', '2022-04-14', '1:53:08 PM', '2022-04-14 05:52:44');
INSERT INTO `audittrail` VALUES ('171', '1', 'Login', 'Login', '2022-04-14', '2:00:09 PM', '2022-04-14 05:59:45');
INSERT INTO `audittrail` VALUES ('172', '1', 'Trans No.: R000000001  PO. No.: PO1  Invoice No.:  INV1  Supplier: GSPI', 'Print Receiving', '2022-04-14', '2:00:13 PM', '2022-04-14 05:59:49');
INSERT INTO `audittrail` VALUES ('173', '1', 'Code.: W52  Description: WINGS POWDER DETERGENT 52GX150  Supplier: GSPI  Category: PD', 'Update Item', '2022-04-14', '2:01:20 PM', '2022-04-14 06:00:56');
INSERT INTO `audittrail` VALUES ('174', '1', 'Code.: WW52  Description: WINGS POWDER WHITE DETERGENT 52GX150  Supplier: GSPI  Category: PD', 'Update Item', '2022-04-14', '2:01:54 PM', '2022-04-14 06:01:30');
INSERT INTO `audittrail` VALUES ('175', '1', 'Trans No.: R000000001  PO. No.: PO1  Invoice No.:  INV1  Supplier: GSPI', 'Update Receiving', '2022-04-14', '2:02:28 PM', '2022-04-14 06:02:04');
INSERT INTO `audittrail` VALUES ('176', '1', 'Logout', 'Logout', '2022-04-14', '2:03:16 PM', '2022-04-14 06:02:52');
INSERT INTO `audittrail` VALUES ('177', '1', 'Login', 'Login', '2022-04-14', '2:06:43 PM', '2022-04-14 06:06:19');
INSERT INTO `audittrail` VALUES ('178', '1', 'Login', 'Login', '2022-04-14', '2:08:19 PM', '2022-04-14 06:07:55');
INSERT INTO `audittrail` VALUES ('179', '1', 'Login', 'Login', '2022-04-14', '2:25:21 PM', '2022-04-14 06:24:57');
INSERT INTO `audittrail` VALUES ('180', '1', 'Login', 'Login', '2022-04-14', '2:43:37 PM', '2022-04-14 06:43:13');
INSERT INTO `audittrail` VALUES ('181', '1', 'Login', 'Login', '2022-04-14', '3:06:06 PM', '2022-04-14 07:05:42');
INSERT INTO `audittrail` VALUES ('182', '1', 'Login', 'Login', '2022-04-14', '3:32:02 PM', '2022-04-14 07:31:38');
INSERT INTO `audittrail` VALUES ('183', '1', 'Login', 'Login', '2022-04-14', '3:45:31 PM', '2022-04-14 07:45:07');
INSERT INTO `audittrail` VALUES ('184', '1', 'Login', 'Login', '2022-04-14', '3:53:07 PM', '2022-04-14 07:52:43');
INSERT INTO `audittrail` VALUES ('185', '1', 'Trans No.: O000000001  Date:  4/14/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-04-14', '3:54:55 PM', '2022-04-14 07:54:31');
INSERT INTO `audittrail` VALUES ('186', '1', 'Login', 'Login', '2022-04-16', '11:07:00 AM', '2022-04-16 03:06:36');
INSERT INTO `audittrail` VALUES ('187', '1', 'Login', 'Login', '2022-04-16', '12:23:44 PM', '2022-04-16 04:23:20');
INSERT INTO `audittrail` VALUES ('188', '1', 'Login', 'Login', '2022-04-16', '12:27:56 PM', '2022-04-16 04:27:32');
INSERT INTO `audittrail` VALUES ('189', '1', 'Login', 'Login', '2022-04-16', '12:31:36 PM', '2022-04-16 04:31:12');
INSERT INTO `audittrail` VALUES ('190', '1', 'Login', 'Login', '2022-04-16', '12:33:54 PM', '2022-04-16 04:33:30');
INSERT INTO `audittrail` VALUES ('191', '1', 'Login', 'Login', '2022-04-16', '12:41:39 PM', '2022-04-16 04:41:15');
INSERT INTO `audittrail` VALUES ('192', '1', 'Login', 'Login', '2022-04-16', '12:50:47 PM', '2022-04-16 04:50:23');
INSERT INTO `audittrail` VALUES ('193', '1', 'Login', 'Login', '2022-04-16', '12:53:53 PM', '2022-04-16 04:53:29');
INSERT INTO `audittrail` VALUES ('194', '1', 'Login', 'Login', '2022-04-16', '12:59:26 PM', '2022-04-16 04:59:02');
INSERT INTO `audittrail` VALUES ('195', '1', 'Login', 'Login', '2022-04-16', '1:01:52 PM', '2022-04-16 05:01:28');
INSERT INTO `audittrail` VALUES ('196', '1', 'Login', 'Login', '2022-04-16', '1:17:20 PM', '2022-04-16 05:16:56');
INSERT INTO `audittrail` VALUES ('197', '1', 'Login', 'Login', '2022-04-16', '1:19:00 PM', '2022-04-16 05:18:36');
INSERT INTO `audittrail` VALUES ('198', '1', 'Login', 'Login', '2022-04-16', '1:22:03 PM', '2022-04-16 05:21:39');
INSERT INTO `audittrail` VALUES ('199', '1', 'Login', 'Login', '2022-04-16', '1:34:41 PM', '2022-04-16 05:34:17');
INSERT INTO `audittrail` VALUES ('200', '1', 'Login', 'Login', '2022-04-16', '1:35:52 PM', '2022-04-16 05:35:28');
INSERT INTO `audittrail` VALUES ('201', '1', 'Login', 'Login', '2022-04-16', '1:46:15 PM', '2022-04-16 05:45:51');
INSERT INTO `audittrail` VALUES ('202', '1', 'Login', 'Login', '2022-04-16', '1:52:41 PM', '2022-04-16 05:52:17');
INSERT INTO `audittrail` VALUES ('203', '1', 'Trans No.:R000000002  PO. No.:A  Invoice No.:A  Supplier:GSPI', 'Save&Print Receiving', '2022-04-16', '2:27:22 PM', '2022-04-16 06:26:58');
INSERT INTO `audittrail` VALUES ('204', '1', 'Login', 'Login', '2022-04-16', '2:32:22 PM', '2022-04-16 06:31:58');
INSERT INTO `audittrail` VALUES ('205', '1', 'Login', 'Login', '2022-04-16', '2:36:02 PM', '2022-04-16 06:35:38');
INSERT INTO `audittrail` VALUES ('206', '1', 'Logout', 'Logout', '2022-04-16', '2:37:14 PM', '2022-04-16 06:36:50');
INSERT INTO `audittrail` VALUES ('207', '1', 'Login', 'Login', '2022-04-16', '2:40:37 PM', '2022-04-16 06:40:13');
INSERT INTO `audittrail` VALUES ('208', '1', 'Login', 'Login', '2022-04-16', '2:44:09 PM', '2022-04-16 06:43:45');
INSERT INTO `audittrail` VALUES ('209', '1', 'Login', 'Login', '2022-04-16', '2:46:23 PM', '2022-04-16 06:45:59');
INSERT INTO `audittrail` VALUES ('210', '1', 'Login', 'Login', '2022-04-16', '2:47:25 PM', '2022-04-16 06:47:01');
INSERT INTO `audittrail` VALUES ('211', '1', 'Login', 'Login', '2022-04-16', '2:51:29 PM', '2022-04-16 06:51:05');
INSERT INTO `audittrail` VALUES ('212', '1', 'Login', 'Login', '2022-04-16', '2:53:43 PM', '2022-04-16 06:53:19');
INSERT INTO `audittrail` VALUES ('213', '1', 'Login', 'Login', '2022-04-16', '2:57:49 PM', '2022-04-16 06:57:25');
INSERT INTO `audittrail` VALUES ('214', '1', 'Login', 'Login', '2022-04-16', '3:01:11 PM', '2022-04-16 07:00:47');
INSERT INTO `audittrail` VALUES ('215', '1', 'Login', 'Login', '2022-04-16', '3:09:50 PM', '2022-04-16 07:09:26');
INSERT INTO `audittrail` VALUES ('216', '1', 'Login', 'Login', '2022-04-16', '3:12:11 PM', '2022-04-16 07:11:47');
INSERT INTO `audittrail` VALUES ('217', '1', 'Login', 'Login', '2022-04-16', '3:49:38 PM', '2022-04-16 07:49:14');
INSERT INTO `audittrail` VALUES ('218', '1', 'Login', 'Login', '2022-04-16', '3:50:48 PM', '2022-04-16 07:50:24');
INSERT INTO `audittrail` VALUES ('219', '1', 'Login', 'Login', '2022-04-16', '3:57:23 PM', '2022-04-16 07:56:59');
INSERT INTO `audittrail` VALUES ('220', '1', 'Login', 'Login', '2022-04-16', '3:59:09 PM', '2022-04-16 07:58:45');
INSERT INTO `audittrail` VALUES ('221', '1', 'Login', 'Login', '2022-04-16', '4:01:50 PM', '2022-04-16 08:01:26');
INSERT INTO `audittrail` VALUES ('222', '1', 'Login', 'Login', '2022-04-16', '4:03:07 PM', '2022-04-16 08:02:43');
INSERT INTO `audittrail` VALUES ('223', '1', 'Login', 'Login', '2022-04-16', '4:05:09 PM', '2022-04-16 08:04:45');
INSERT INTO `audittrail` VALUES ('224', '1', 'Trans No.: R000000003  PO. No.: 1  Invoice No.:  11  Supplier: GSPI', 'Add Receiving', '2022-04-16', '4:05:50 PM', '2022-04-16 08:05:26');
INSERT INTO `audittrail` VALUES ('225', '1', 'Login', 'Login', '2022-04-16', '4:09:35 PM', '2022-04-16 08:09:11');
INSERT INTO `audittrail` VALUES ('226', '1', 'Trans No.: R000000004  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Add Receiving', '2022-04-16', '4:10:11 PM', '2022-04-16 08:09:47');
INSERT INTO `audittrail` VALUES ('227', '1', 'Login', 'Login', '2022-04-16', '4:12:59 PM', '2022-04-16 08:12:35');
INSERT INTO `audittrail` VALUES ('228', '1', 'Login', 'Login', '2022-04-16', '4:16:14 PM', '2022-04-16 08:15:50');
INSERT INTO `audittrail` VALUES ('229', '1', 'Trans No.: R000000006  PO. No.: 13  Invoice No.:  13  Supplier: GSPI', 'Add Receiving', '2022-04-16', '4:16:35 PM', '2022-04-16 08:16:11');
INSERT INTO `audittrail` VALUES ('230', '1', 'Login', 'Login', '2022-04-16', '4:19:21 PM', '2022-04-16 08:18:57');
INSERT INTO `audittrail` VALUES ('231', '1', 'Logout', 'Logout', '2022-04-16', '4:24:26 PM', '2022-04-16 08:24:02');
INSERT INTO `audittrail` VALUES ('232', '1', 'Login', 'Login', '2022-04-16', '6:55:38 PM', '2022-04-16 10:55:14');
INSERT INTO `audittrail` VALUES ('233', '1', 'Login', 'Login', '2022-04-16', '7:06:36 PM', '2022-04-16 11:06:12');
INSERT INTO `audittrail` VALUES ('234', '1', 'Trans No.: R000000006  PO. No.: 13  Invoice No.:  13  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:07:03 PM', '2022-04-16 11:06:39');
INSERT INTO `audittrail` VALUES ('235', '1', 'Login', 'Login', '2022-04-16', '7:11:03 PM', '2022-04-16 11:10:39');
INSERT INTO `audittrail` VALUES ('236', '1', 'Login', 'Login', '2022-04-16', '7:13:57 PM', '2022-04-16 11:13:33');
INSERT INTO `audittrail` VALUES ('237', '1', 'Login', 'Login', '2022-04-16', '7:14:18 PM', '2022-04-16 11:13:54');
INSERT INTO `audittrail` VALUES ('238', '1', 'Login', 'Login', '2022-04-16', '7:18:05 PM', '2022-04-16 11:17:41');
INSERT INTO `audittrail` VALUES ('239', '1', 'Login', 'Login', '2022-04-16', '7:20:05 PM', '2022-04-16 11:19:41');
INSERT INTO `audittrail` VALUES ('240', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-04-16', '7:21:21 PM', '2022-04-16 11:20:57');
INSERT INTO `audittrail` VALUES ('241', '1', 'Login', 'Login', '2022-04-16', '7:22:29 PM', '2022-04-16 11:22:05');
INSERT INTO `audittrail` VALUES ('242', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update&Print Receiving', '2022-04-16', '7:24:27 PM', '2022-04-16 11:24:03');
INSERT INTO `audittrail` VALUES ('243', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:25:11 PM', '2022-04-16 11:24:47');
INSERT INTO `audittrail` VALUES ('244', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:26:08 PM', '2022-04-16 11:25:44');
INSERT INTO `audittrail` VALUES ('245', '1', 'Login', 'Login', '2022-04-16', '7:30:32 PM', '2022-04-16 11:30:08');
INSERT INTO `audittrail` VALUES ('246', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:33:07 PM', '2022-04-16 11:32:43');
INSERT INTO `audittrail` VALUES ('247', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:34:58 PM', '2022-04-16 11:34:34');
INSERT INTO `audittrail` VALUES ('248', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:35:23 PM', '2022-04-16 11:34:59');
INSERT INTO `audittrail` VALUES ('249', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A', 'Delete Receiving', '2022-04-16', '7:35:37 PM', '2022-04-16 11:35:13');
INSERT INTO `audittrail` VALUES ('250', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-04-16', '7:37:28 PM', '2022-04-16 11:37:04');
INSERT INTO `audittrail` VALUES ('251', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '7:38:17 PM', '2022-04-16 11:37:53');
INSERT INTO `audittrail` VALUES ('252', '1', 'Login', 'Login', '2022-04-16', '8:06:15 PM', '2022-04-16 12:05:51');
INSERT INTO `audittrail` VALUES ('253', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-16', '8:48:23 PM', '2022-04-16 12:47:59');
INSERT INTO `audittrail` VALUES ('254', '1', 'Trans No.:R000000001  PO. No.:Q  Invoice No.:Q  Supplier:GSPI', 'Receiving Entry', '2022-04-16', '8:59:12 PM', '2022-04-16 12:58:48');
INSERT INTO `audittrail` VALUES ('255', '1', 'Trans No.:R000000001  PO. No.:Q  Invoice No.:Q  Supplier:GSPI', 'Receiving Update', '2022-04-16', '9:02:36 PM', '2022-04-16 13:02:12');
INSERT INTO `audittrail` VALUES ('256', '1', 'Trans No.:R000000001  PO. No.:Q  Invoice No.:Q  Supplier:GSPI', 'Receiving Update', '2022-04-16', '9:04:11 PM', '2022-04-16 13:03:47');
INSERT INTO `audittrail` VALUES ('257', '1', 'Trans No.:R000000002  PO. No.:1  Invoice No.:1  Supplier:GSPI', 'Receiving Entry', '2022-04-16', '9:06:17 PM', '2022-04-16 13:05:53');
INSERT INTO `audittrail` VALUES ('258', '1', 'Trans No.:R000000001  PO. No.:Q  Invoice No.:Q  Supplier:GSPI', 'Receiving Update', '2022-04-16', '9:22:34 PM', '2022-04-16 13:22:10');
INSERT INTO `audittrail` VALUES ('259', '1', 'Trans No.:R000000001  PO. No.:Q  Invoice No.:Q  Supplier:GSPI', 'Receiving Update', '2022-04-16', '9:24:23 PM', '2022-04-16 13:23:59');
INSERT INTO `audittrail` VALUES ('260', '1', 'Trans No.:R000000002  PO. No.:1  Invoice No.:1  Supplier:GSPI', 'Receiving Update', '2022-04-16', '9:26:20 PM', '2022-04-16 13:25:56');
INSERT INTO `audittrail` VALUES ('261', '1', 'Trans No.:R000000003  PO. No.:A  Invoice No.:A  Supplier:GSPI', 'Receiving Entry', '2022-04-16', '9:30:25 PM', '2022-04-16 13:30:01');
INSERT INTO `audittrail` VALUES ('262', '1', 'Trans No.:R000000003  ', 'Delete Receiving Module', '2022-04-16', '9:31:55 PM', '2022-04-16 13:31:31');
INSERT INTO `audittrail` VALUES ('263', '1', 'Login', 'Login', '2022-04-17', '12:52:23 PM', '2022-04-17 04:51:59');
INSERT INTO `audittrail` VALUES ('264', '1', 'Login', 'Login', '2022-04-17', '12:57:09 PM', '2022-04-17 04:56:45');
INSERT INTO `audittrail` VALUES ('265', '1', 'Trans No.: R000000002  PO. No.: 1  Invoice No.:  1  Supplier: GSPI', 'Update Receiving', '2022-04-17', '12:57:25 PM', '2022-04-17 04:57:01');
INSERT INTO `audittrail` VALUES ('266', '1', 'Login', 'Login', '2022-04-17', '1:02:13 PM', '2022-04-17 05:01:49');
INSERT INTO `audittrail` VALUES ('267', '1', 'Trans No.: R000000002  PO. No.: 1  Invoice No.:  1  Supplier: GSPI', 'Update Receiving', '2022-04-17', '1:02:49 PM', '2022-04-17 05:02:25');
INSERT INTO `audittrail` VALUES ('268', '1', 'Login', 'Login', '2022-04-17', '1:04:30 PM', '2022-04-17 05:04:06');
INSERT INTO `audittrail` VALUES ('269', '1', 'Trans No.: R000000002  PO. No.: 1  Invoice No.:  1  Supplier: GSPI', 'Update Receiving', '2022-04-17', '1:04:45 PM', '2022-04-17 05:04:21');
INSERT INTO `audittrail` VALUES ('270', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-04-17', '1:10:05 PM', '2022-04-17 05:09:41');
INSERT INTO `audittrail` VALUES ('271', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '1:11:18 PM', '2022-04-17 05:10:54');
INSERT INTO `audittrail` VALUES ('272', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Add Receiving', '2022-04-17', '1:13:59 PM', '2022-04-17 05:13:35');
INSERT INTO `audittrail` VALUES ('273', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-04-17', '1:14:57 PM', '2022-04-17 05:14:33');
INSERT INTO `audittrail` VALUES ('274', '1', 'Login', 'Login', '2022-04-17', '1:56:48 PM', '2022-04-17 05:56:24');
INSERT INTO `audittrail` VALUES ('275', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-04-17', '1:58:50 PM', '2022-04-17 05:58:26');
INSERT INTO `audittrail` VALUES ('276', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-04-17', '2:02:06 PM', '2022-04-17 06:01:42');
INSERT INTO `audittrail` VALUES ('277', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '2:09:41 PM', '2022-04-17 06:09:17');
INSERT INTO `audittrail` VALUES ('278', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '2:14:26 PM', '2022-04-17 06:14:02');
INSERT INTO `audittrail` VALUES ('279', '1', 'Login', 'Login', '2022-04-17', '2:15:44 PM', '2022-04-17 06:15:20');
INSERT INTO `audittrail` VALUES ('280', '1', 'Login', 'Login', '2022-04-17', '2:39:27 PM', '2022-04-17 06:39:03');
INSERT INTO `audittrail` VALUES ('281', '1', 'Login', 'Login', '2022-04-17', '2:43:46 PM', '2022-04-17 06:43:22');
INSERT INTO `audittrail` VALUES ('282', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '2:44:23 PM', '2022-04-17 06:43:59');
INSERT INTO `audittrail` VALUES ('283', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '2:44:53 PM', '2022-04-17 06:44:29');
INSERT INTO `audittrail` VALUES ('284', '1', 'Login', 'Login', '2022-04-17', '3:06:23 PM', '2022-04-17 07:05:59');
INSERT INTO `audittrail` VALUES ('285', '1', 'Trans No.: O000000002  Date:  4/17/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-04-17', '3:07:35 PM', '2022-04-17 07:07:11');
INSERT INTO `audittrail` VALUES ('286', '1', 'Login', 'Login', '2022-04-17', '3:23:28 PM', '2022-04-17 07:23:04');
INSERT INTO `audittrail` VALUES ('287', '1', 'Trans No.: O000000003  Date:  4/17/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-04-17', '3:26:31 PM', '2022-04-17 07:26:07');
INSERT INTO `audittrail` VALUES ('288', '1', 'Login', 'Login', '2022-04-17', '3:51:52 PM', '2022-04-17 07:51:28');
INSERT INTO `audittrail` VALUES ('289', '1', 'Login', 'Login', '2022-04-17', '4:19:23 PM', '2022-04-17 08:18:59');
INSERT INTO `audittrail` VALUES ('290', '1', 'Login', 'Login', '2022-04-17', '8:51:45 PM', '2022-04-17 12:51:21');
INSERT INTO `audittrail` VALUES ('291', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '8:55:26 PM', '2022-04-17 12:55:02');
INSERT INTO `audittrail` VALUES ('292', '1', 'Login', 'Login', '2022-04-17', '9:04:07 PM', '2022-04-17 13:03:43');
INSERT INTO `audittrail` VALUES ('293', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '9:07:31 PM', '2022-04-17 13:07:07');
INSERT INTO `audittrail` VALUES ('294', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '9:09:27 PM', '2022-04-17 13:09:03');
INSERT INTO `audittrail` VALUES ('295', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '9:10:12 PM', '2022-04-17 13:09:48');
INSERT INTO `audittrail` VALUES ('296', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-17', '9:10:38 PM', '2022-04-17 13:10:14');
INSERT INTO `audittrail` VALUES ('297', '1', 'Login', 'Login', '2022-04-17', '9:19:21 PM', '2022-04-17 13:18:57');
INSERT INTO `audittrail` VALUES ('298', '1', 'Login', 'Login', '2022-04-18', '7:45:35 PM', '2022-04-18 11:45:11');
INSERT INTO `audittrail` VALUES ('299', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-18', '7:46:07 PM', '2022-04-18 11:45:43');
INSERT INTO `audittrail` VALUES ('300', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-18', '7:48:01 PM', '2022-04-18 11:47:37');
INSERT INTO `audittrail` VALUES ('301', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-04-18', '7:49:48 PM', '2022-04-18 11:49:24');
INSERT INTO `audittrail` VALUES ('302', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-04-18', '7:56:06 PM', '2022-04-18 11:55:42');
INSERT INTO `audittrail` VALUES ('303', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-04-18', '7:59:48 PM', '2022-04-18 11:59:24');
INSERT INTO `audittrail` VALUES ('304', '1', 'Login', 'Login', '2022-04-18', '8:08:47 PM', '2022-04-18 12:08:23');
INSERT INTO `audittrail` VALUES ('305', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-04-18', '8:10:11 PM', '2022-04-18 12:09:47');
INSERT INTO `audittrail` VALUES ('306', '1', 'Transno.: T000000001  Date:   4/18/2022From: YLK  To:  WHS1', 'Save & Print Stock Transfer', '2022-04-18', '8:12:12 PM', '2022-04-18 12:11:48');
INSERT INTO `audittrail` VALUES ('307', '1', 'Login', 'Login', '2022-04-18', '8:20:17 PM', '2022-04-18 12:19:53');
INSERT INTO `audittrail` VALUES ('308', '1', 'Transno.: T000000001  Date:  4/18/2022  From: YLK  To:  WHS1', 'Update Stock Transfer', '2022-04-18', '8:20:29 PM', '2022-04-18 12:20:05');
INSERT INTO `audittrail` VALUES ('309', '1', 'Transno.: T000000001  Date:  4/18/2022  From: YLK  To:  WHS1', 'Delete Stock Transfer', '2022-04-18', '8:36:01 PM', '2022-04-18 12:35:37');
INSERT INTO `audittrail` VALUES ('310', '1', 'Login', 'Login', '2022-04-18', '8:43:50 PM', '2022-04-18 12:43:26');
INSERT INTO `audittrail` VALUES ('311', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-04-18', '8:44:36 PM', '2022-04-18 12:44:12');
INSERT INTO `audittrail` VALUES ('312', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Add Receiving', '2022-04-18', '8:46:31 PM', '2022-04-18 12:46:07');
INSERT INTO `audittrail` VALUES ('313', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-04-18', '8:51:01 PM', '2022-04-18 12:50:37');
INSERT INTO `audittrail` VALUES ('314', '1', 'Trans No.: R000000003  PO. No.: C  Invoice No.:  C  Supplier: GSPI', 'Add Receiving', '2022-04-18', '9:17:35 PM', '2022-04-18 13:17:11');
INSERT INTO `audittrail` VALUES ('315', '1', 'Logout', 'Logout', '2022-04-18', '9:49:16 PM', '2022-04-18 13:48:52');
INSERT INTO `audittrail` VALUES ('316', '1', 'Login', 'Login', '2022-04-18', '9:56:19 PM', '2022-04-18 13:55:55');
INSERT INTO `audittrail` VALUES ('317', '1', 'Login', 'Login', '2022-04-29', '8:16:28 PM', '2022-04-29 12:16:04');
INSERT INTO `audittrail` VALUES ('318', '1', 'Login', 'Login', '2022-04-29', '8:19:25 PM', '2022-04-29 12:19:01');
INSERT INTO `audittrail` VALUES ('319', '1', 'Login', 'Login', '2022-04-29', '8:20:02 PM', '2022-04-29 12:19:38');
INSERT INTO `audittrail` VALUES ('320', '1', 'Login', 'Login', '2022-04-29', '8:54:08 PM', '2022-04-29 12:53:44');
INSERT INTO `audittrail` VALUES ('321', '1', 'Logout', 'Logout', '2022-04-29', '8:59:12 PM', '2022-04-29 12:58:48');
INSERT INTO `audittrail` VALUES ('322', '1', 'Trans No.:R000000001  PO. No.:A  Invoice No.:A  Supplier:GSPI', 'Receiving Update', '2022-05-01', '3:09:33 PM', '2022-05-01 07:09:09');
INSERT INTO `audittrail` VALUES ('323', '1', 'Login', 'Login', '2022-05-01', '3:12:05 PM', '2022-05-01 07:11:41');
INSERT INTO `audittrail` VALUES ('324', '1', 'Login', 'Login', '2022-05-22', '10:21:00 AM', '2022-05-22 02:20:36');
INSERT INTO `audittrail` VALUES ('325', '1', 'Login', 'Login', '2022-05-22', '10:25:17 AM', '2022-05-22 02:24:53');
INSERT INTO `audittrail` VALUES ('326', '1', 'Login', 'Login', '2022-05-22', '10:26:38 AM', '2022-05-22 02:26:14');
INSERT INTO `audittrail` VALUES ('327', '1', 'Trans No.: R000000003  PO. No.: C  Invoice No.:  C  Supplier: GSPI', 'Update Receiving', '2022-05-22', '10:29:33 AM', '2022-05-22 02:29:09');
INSERT INTO `audittrail` VALUES ('328', '1', 'Trans No.:   Date:  5/22/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-05-22', '10:30:07 AM', '2022-05-22 02:29:43');
INSERT INTO `audittrail` VALUES ('329', '1', 'Login', 'Login', '2022-05-23', '10:26:18 AM', '2022-05-23 02:25:54');
INSERT INTO `audittrail` VALUES ('330', '1', 'Login', 'Login', '2022-05-24', '2:41:28 PM', '2022-05-24 06:41:04');
INSERT INTO `audittrail` VALUES ('331', '1', 'Logout', 'Logout', '2022-05-24', '2:48:08 PM', '2022-05-24 06:47:44');
INSERT INTO `audittrail` VALUES ('332', '1', 'Login', 'Login', '2022-05-26', '3:13:09 PM', '2022-05-26 07:12:45');
INSERT INTO `audittrail` VALUES ('333', '1', 'Login', 'Login', '2022-05-26', '3:14:46 PM', '2022-05-26 07:14:22');
INSERT INTO `audittrail` VALUES ('334', '1', 'Login', 'Login', '2022-05-26', '3:20:20 PM', '2022-05-26 07:19:56');
INSERT INTO `audittrail` VALUES ('335', '1', 'Login', 'Login', '2022-05-26', '3:21:21 PM', '2022-05-26 07:20:57');
INSERT INTO `audittrail` VALUES ('336', '1', 'Login', 'Login', '2022-05-26', '3:41:39 PM', '2022-05-26 07:41:15');
INSERT INTO `audittrail` VALUES ('337', '1', 'Login', 'Login', '2022-05-26', '3:49:31 PM', '2022-05-26 07:49:07');
INSERT INTO `audittrail` VALUES ('338', '1', 'Login', 'Login', '2022-05-26', '3:53:15 PM', '2022-05-26 07:52:51');
INSERT INTO `audittrail` VALUES ('339', '1', 'Login', 'Login', '2022-05-26', '3:54:19 PM', '2022-05-26 07:53:55');
INSERT INTO `audittrail` VALUES ('340', '1', 'Login', 'Login', '2022-05-26', '3:55:18 PM', '2022-05-26 07:54:54');
INSERT INTO `audittrail` VALUES ('341', '1', 'Login', 'Login', '2022-05-26', '3:55:54 PM', '2022-05-26 07:55:30');
INSERT INTO `audittrail` VALUES ('342', '1', 'Logout', 'Logout', '2022-05-26', '4:06:46 PM', '2022-05-26 08:06:22');
INSERT INTO `audittrail` VALUES ('343', '1', 'Login', 'Login', '2022-05-26', '4:49:19 PM', '2022-05-26 08:48:55');
INSERT INTO `audittrail` VALUES ('344', '1', 'Logout', 'Logout', '2022-05-26', '4:51:18 PM', '2022-05-26 08:50:54');
INSERT INTO `audittrail` VALUES ('345', '1', 'Login', 'Login', '2022-05-28', '9:17:56 AM', '2022-05-28 01:17:32');
INSERT INTO `audittrail` VALUES ('346', '1', 'Login', 'Login', '2022-05-28', '9:21:59 AM', '2022-05-28 01:21:35');
INSERT INTO `audittrail` VALUES ('347', '1', 'Login', 'Login', '2022-05-28', '9:23:47 AM', '2022-05-28 01:23:23');
INSERT INTO `audittrail` VALUES ('348', '1', 'Login', 'Login', '2022-05-28', '9:34:45 AM', '2022-05-28 01:34:21');
INSERT INTO `audittrail` VALUES ('349', '1', 'Login', 'Login', '2022-05-28', '9:39:36 AM', '2022-05-28 01:39:12');
INSERT INTO `audittrail` VALUES ('350', '1', 'Login', 'Login', '2022-05-28', '9:43:00 AM', '2022-05-28 01:42:36');
INSERT INTO `audittrail` VALUES ('351', '1', 'Login', 'Login', '2022-05-28', '9:47:02 AM', '2022-05-28 01:46:38');
INSERT INTO `audittrail` VALUES ('352', '1', 'Login', 'Login', '2022-05-28', '9:52:37 AM', '2022-05-28 01:52:13');
INSERT INTO `audittrail` VALUES ('353', '1', 'Login', 'Login', '2022-05-28', '9:53:06 AM', '2022-05-28 01:52:42');
INSERT INTO `audittrail` VALUES ('354', '1', 'Login', 'Login', '2022-05-28', '9:58:37 AM', '2022-05-28 01:58:13');
INSERT INTO `audittrail` VALUES ('355', '1', 'Login', 'Login', '2022-05-28', '9:59:37 AM', '2022-05-28 01:59:13');
INSERT INTO `audittrail` VALUES ('356', '1', 'Login', 'Login', '2022-05-28', '10:01:40 AM', '2022-05-28 02:01:16');
INSERT INTO `audittrail` VALUES ('357', '1', 'Login', 'Login', '2022-05-28', '10:26:40 AM', '2022-05-28 02:26:16');
INSERT INTO `audittrail` VALUES ('358', '1', 'Login', 'Login', '2022-05-28', '10:28:19 AM', '2022-05-28 02:27:55');
INSERT INTO `audittrail` VALUES ('359', '1', 'Login', 'Login', '2022-05-28', '10:29:58 AM', '2022-05-28 02:29:34');
INSERT INTO `audittrail` VALUES ('360', '1', 'Login', 'Login', '2022-05-28', '4:14:58 PM', '2022-05-28 08:14:34');
INSERT INTO `audittrail` VALUES ('361', '1', 'Logout', 'Logout', '2022-05-28', '4:15:57 PM', '2022-05-28 08:15:33');
INSERT INTO `audittrail` VALUES ('362', '1', 'Login', 'Login', '2022-05-28', '4:17:30 PM', '2022-05-28 08:17:06');
INSERT INTO `audittrail` VALUES ('363', '1', 'Login', 'Login', '2022-05-28', '4:19:07 PM', '2022-05-28 08:18:43');
INSERT INTO `audittrail` VALUES ('364', '1', 'Login', 'Login', '2022-05-28', '4:22:10 PM', '2022-05-28 08:21:46');
INSERT INTO `audittrail` VALUES ('365', '1', 'Login', 'Login', '2022-05-28', '4:23:48 PM', '2022-05-28 08:23:24');
INSERT INTO `audittrail` VALUES ('366', '1', 'Login', 'Login', '2022-05-28', '4:25:12 PM', '2022-05-28 08:24:48');
INSERT INTO `audittrail` VALUES ('367', '1', 'Login', 'Login', '2022-05-28', '4:34:00 PM', '2022-05-28 08:33:36');
INSERT INTO `audittrail` VALUES ('368', '1', 'Login', 'Login', '2022-05-28', '4:35:43 PM', '2022-05-28 08:35:19');
INSERT INTO `audittrail` VALUES ('369', '1', 'Login', 'Login', '2022-05-28', '4:37:22 PM', '2022-05-28 08:36:58');
INSERT INTO `audittrail` VALUES ('370', '1', 'Login', 'Login', '2022-05-30', '2:53:39 PM', '2022-05-30 06:53:15');
INSERT INTO `audittrail` VALUES ('371', '1', 'Login', 'Login', '2022-05-30', '2:56:54 PM', '2022-05-30 06:56:30');
INSERT INTO `audittrail` VALUES ('372', '1', 'Login', 'Login', '2022-05-30', '2:59:31 PM', '2022-05-30 06:59:07');
INSERT INTO `audittrail` VALUES ('373', '1', 'Login', 'Login', '2022-05-30', '3:02:16 PM', '2022-05-30 07:01:52');
INSERT INTO `audittrail` VALUES ('374', '1', 'Login', 'Login', '2022-05-30', '3:02:39 PM', '2022-05-30 07:02:15');
INSERT INTO `audittrail` VALUES ('375', '1', 'Login', 'Login', '2022-05-30', '3:06:13 PM', '2022-05-30 07:05:49');
INSERT INTO `audittrail` VALUES ('376', '1', 'Login', 'Login', '2022-05-30', '3:13:20 PM', '2022-05-30 07:12:56');
INSERT INTO `audittrail` VALUES ('377', '1', 'Login', 'Login', '2022-05-30', '3:13:54 PM', '2022-05-30 07:13:30');
INSERT INTO `audittrail` VALUES ('378', '1', 'Login', 'Login', '2022-05-30', '3:14:34 PM', '2022-05-30 07:14:10');
INSERT INTO `audittrail` VALUES ('379', '1', 'Login', 'Login', '2022-05-30', '3:26:54 PM', '2022-05-30 07:26:30');
INSERT INTO `audittrail` VALUES ('380', '1', 'Login', 'Login', '2022-05-30', '3:50:35 PM', '2022-05-30 07:50:11');
INSERT INTO `audittrail` VALUES ('381', '1', 'Login', 'Login', '2022-05-30', '4:14:15 PM', '2022-05-30 08:13:51');
INSERT INTO `audittrail` VALUES ('382', '1', 'Login', 'Login', '2022-05-30', '4:17:46 PM', '2022-05-30 08:17:22');
INSERT INTO `audittrail` VALUES ('383', '1', 'Login', 'Login', '2022-05-31', '9:16:06 AM', '2022-05-31 01:15:42');
INSERT INTO `audittrail` VALUES ('384', '1', 'Login', 'Login', '2022-05-31', '9:43:21 AM', '2022-05-31 01:42:57');
INSERT INTO `audittrail` VALUES ('385', '1', 'Login', 'Login', '2022-05-31', '9:48:51 AM', '2022-05-31 01:48:27');
INSERT INTO `audittrail` VALUES ('386', '1', 'Login', 'Login', '2022-05-31', '9:52:49 AM', '2022-05-31 01:52:25');
INSERT INTO `audittrail` VALUES ('387', '1', 'Login', 'Login', '2022-05-31', '9:58:44 AM', '2022-05-31 01:58:20');
INSERT INTO `audittrail` VALUES ('388', '1', 'Login', 'Login', '2022-05-31', '10:01:55 AM', '2022-05-31 02:01:31');
INSERT INTO `audittrail` VALUES ('389', '1', 'Login', 'Login', '2022-05-31', '10:03:12 AM', '2022-05-31 02:02:48');
INSERT INTO `audittrail` VALUES ('390', '1', 'Login', 'Login', '2022-05-31', '10:05:04 AM', '2022-05-31 02:04:40');
INSERT INTO `audittrail` VALUES ('391', '1', 'Login', 'Login', '2022-05-31', '10:06:09 AM', '2022-05-31 02:05:45');
INSERT INTO `audittrail` VALUES ('392', '1', 'Login', 'Login', '2022-05-31', '10:09:08 AM', '2022-05-31 02:08:44');
INSERT INTO `audittrail` VALUES ('393', '1', 'Login', 'Login', '2022-05-31', '10:10:09 AM', '2022-05-31 02:09:45');
INSERT INTO `audittrail` VALUES ('394', '1', 'Login', 'Login', '2022-05-31', '10:11:02 AM', '2022-05-31 02:10:38');
INSERT INTO `audittrail` VALUES ('395', '1', 'Login', 'Login', '2022-05-31', '10:13:37 AM', '2022-05-31 02:13:13');
INSERT INTO `audittrail` VALUES ('396', '1', 'Login', 'Login', '2022-05-31', '10:15:05 AM', '2022-05-31 02:14:41');
INSERT INTO `audittrail` VALUES ('397', '1', 'Transno.:   Date:   5/31/2022  From:  YLK  To:  WHS1', 'Add New Stock Transfer', '2022-05-31', '10:15:56 AM', '2022-05-31 02:15:32');
INSERT INTO `audittrail` VALUES ('398', '1', 'Transno.:   Date:   5/31/2022  From:  YLK  To:  WHS2', 'Add New Stock Transfer', '2022-05-31', '10:16:28 AM', '2022-05-31 02:16:04');
INSERT INTO `audittrail` VALUES ('399', '1', 'Transno.: T000000001  Date:  5/31/2022  From: YLK  To:  WHS1', 'Update Stock Transfer', '2022-05-31', '10:16:39 AM', '2022-05-31 02:16:15');
INSERT INTO `audittrail` VALUES ('400', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-05-31', '10:16:51 AM', '2022-05-31 02:16:27');
INSERT INTO `audittrail` VALUES ('401', '1', 'Login', 'Login', '2022-06-04', '10:16:32 AM', '2022-06-04 02:16:08');
INSERT INTO `audittrail` VALUES ('402', '1', 'Login', 'Login', '2022-06-04', '10:18:43 AM', '2022-06-04 02:18:19');
INSERT INTO `audittrail` VALUES ('403', '1', 'Login', 'Login', '2022-06-04', '10:20:15 AM', '2022-06-04 02:19:51');
INSERT INTO `audittrail` VALUES ('404', '1', 'Login', 'Login', '2022-06-04', '10:23:18 AM', '2022-06-04 02:22:54');
INSERT INTO `audittrail` VALUES ('405', '1', 'Login', 'Login', '2022-06-04', '10:28:12 AM', '2022-06-04 02:27:48');
INSERT INTO `audittrail` VALUES ('406', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-06-04', '10:30:54 AM', '2022-06-04 02:30:30');
INSERT INTO `audittrail` VALUES ('407', '1', 'Login', 'Login', '2022-06-04', '10:39:56 AM', '2022-06-04 02:39:32');
INSERT INTO `audittrail` VALUES ('408', '1', 'Login', 'Login', '2022-06-04', '10:41:24 AM', '2022-06-04 02:41:00');
INSERT INTO `audittrail` VALUES ('409', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-06-04', '10:42:33 AM', '2022-06-04 02:42:09');
INSERT INTO `audittrail` VALUES ('410', '1', 'Login', 'Login', '2022-06-04', '10:44:53 AM', '2022-06-04 02:44:29');
INSERT INTO `audittrail` VALUES ('411', '1', 'Login', 'Login', '2022-06-04', '2:16:02 PM', '2022-06-04 06:15:38');
INSERT INTO `audittrail` VALUES ('412', '1', 'Login', 'Login', '2022-06-04', '2:27:22 PM', '2022-06-04 06:26:58');
INSERT INTO `audittrail` VALUES ('413', '1', 'Login', 'Login', '2022-06-04', '2:28:14 PM', '2022-06-04 06:27:50');
INSERT INTO `audittrail` VALUES ('414', '1', 'Login', 'Login', '2022-06-04', '2:29:10 PM', '2022-06-04 06:28:46');
INSERT INTO `audittrail` VALUES ('415', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-06-04', '2:30:06 PM', '2022-06-04 06:29:42');
INSERT INTO `audittrail` VALUES ('416', '1', 'Login', 'Login', '2022-06-04', '3:26:05 PM', '2022-06-04 07:25:41');
INSERT INTO `audittrail` VALUES ('417', '1', 'Trans No.:   Date:  6/4/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-06-04', '3:27:16 PM', '2022-06-04 07:26:52');
INSERT INTO `audittrail` VALUES ('418', '1', 'Login', 'Login', '2022-06-04', '3:28:35 PM', '2022-06-04 07:28:11');
INSERT INTO `audittrail` VALUES ('419', '1', 'Login', 'Login', '2022-06-04', '3:30:25 PM', '2022-06-04 07:30:01');
INSERT INTO `audittrail` VALUES ('420', '1', 'Login', 'Login', '2022-06-04', '3:33:49 PM', '2022-06-04 07:33:25');
INSERT INTO `audittrail` VALUES ('421', '1', 'Login', 'Login', '2022-06-04', '3:38:21 PM', '2022-06-04 07:37:57');
INSERT INTO `audittrail` VALUES ('422', '1', 'Login', 'Login', '2022-06-04', '3:40:43 PM', '2022-06-04 07:40:19');
INSERT INTO `audittrail` VALUES ('423', '1', 'Login', 'Login', '2022-06-04', '3:56:24 PM', '2022-06-04 07:56:00');
INSERT INTO `audittrail` VALUES ('424', '1', 'Trans No.: R000000002  PO. No.: B  Invoice No.:  B  Supplier: GSPI', 'Update Receiving', '2022-06-04', '3:58:21 PM', '2022-06-04 07:57:57');
INSERT INTO `audittrail` VALUES ('425', '1', 'Login', 'Login', '2022-06-04', '4:09:12 PM', '2022-06-04 08:08:48');
INSERT INTO `audittrail` VALUES ('426', '1', 'Login', 'Login', '2022-06-06', '2:31:19 PM', '2022-06-06 06:30:55');
INSERT INTO `audittrail` VALUES ('427', '1', 'Login', 'Login', '2022-06-06', '2:35:42 PM', '2022-06-06 06:35:18');
INSERT INTO `audittrail` VALUES ('428', '1', 'Login', 'Login', '2022-06-06', '2:37:45 PM', '2022-06-06 06:37:21');
INSERT INTO `audittrail` VALUES ('429', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-06-06', '2:41:03 PM', '2022-06-06 06:40:39');
INSERT INTO `audittrail` VALUES ('430', '1', 'Trans No.: R000000003  PO. No.: C  Invoice No.:  C  Supplier: GSPI', 'Update Receiving', '2022-06-06', '2:42:53 PM', '2022-06-06 06:42:29');
INSERT INTO `audittrail` VALUES ('431', '1', 'Trans No.: R000000003  PO. No.: C  Invoice No.:  C  Supplier: GSPI', 'Update Receiving', '2022-06-06', '2:43:49 PM', '2022-06-06 06:43:25');
INSERT INTO `audittrail` VALUES ('432', '1', 'Login', 'Login', '2022-06-06', '2:47:06 PM', '2022-06-06 06:46:42');
INSERT INTO `audittrail` VALUES ('433', '1', 'Trans No.: R000000001  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Update Receiving', '2022-06-06', '2:48:28 PM', '2022-06-06 06:48:04');
INSERT INTO `audittrail` VALUES ('434', '1', 'Login', 'Login', '2022-06-06', '2:53:08 PM', '2022-06-06 06:52:44');
INSERT INTO `audittrail` VALUES ('435', '1', 'Code.: MSD  Description: MISEDAAP NOODLES REGULAR 70G 40X5  Supplier: GSPI  Category: MD', 'Update Item', '2022-06-06', '2:55:20 PM', '2022-06-06 06:54:56');
INSERT INTO `audittrail` VALUES ('436', '1', 'Login', 'Login', '2022-06-06', '2:56:27 PM', '2022-06-06 06:56:03');
INSERT INTO `audittrail` VALUES ('437', '1', 'Login', 'Login', '2022-06-06', '2:57:24 PM', '2022-06-06 06:57:00');
INSERT INTO `audittrail` VALUES ('438', '1', 'Trans No.: R000000003  PO. No.: C  Invoice No.:  C  Supplier: GSPI', 'Update Receiving', '2022-06-06', '2:58:37 PM', '2022-06-06 06:58:13');
INSERT INTO `audittrail` VALUES ('439', '1', 'Trans No.: R000000003  PO. No.: 1000000000000C  Invoice No.:  1000000000000C  Supplier: GSPI', 'Update Receiving', '2022-06-06', '2:59:07 PM', '2022-06-06 06:58:43');
INSERT INTO `audittrail` VALUES ('440', '1', 'Login', 'Login', '2022-06-06', '3:00:22 PM', '2022-06-06 06:59:58');
INSERT INTO `audittrail` VALUES ('441', '1', 'Trans No.: R000000002  PO. No.: 1000000000000B  Invoice No.:  1000000000000B  Supplier: GSPI', 'Update Receiving', '2022-06-06', '3:00:44 PM', '2022-06-06 07:00:20');
INSERT INTO `audittrail` VALUES ('442', '1', 'Trans No.: R000000001  PO. No.: 1000000000000A  Invoice No.:  1000000000000A  Supplier: GSPI', 'Update Receiving', '2022-06-06', '3:00:55 PM', '2022-06-06 07:00:31');
INSERT INTO `audittrail` VALUES ('443', '1', 'Trans No.: R000000004  PO. No.: 1000000000000D  Invoice No.:  1000000000000D  Supplier: BL', 'Add Receiving', '2022-06-06', '3:02:09 PM', '2022-06-06 07:01:45');
INSERT INTO `audittrail` VALUES ('444', '1', 'Login', 'Login', '2022-06-06', '3:02:56 PM', '2022-06-06 07:02:32');
INSERT INTO `audittrail` VALUES ('445', '1', 'Login', 'Login', '2022-06-06', '3:08:00 PM', '2022-06-06 07:07:36');
INSERT INTO `audittrail` VALUES ('446', '1', 'Login', 'Login', '2022-06-06', '3:09:06 PM', '2022-06-06 07:08:42');
INSERT INTO `audittrail` VALUES ('447', '1', 'Login', 'Login', '2022-06-06', '3:21:39 PM', '2022-06-06 07:21:15');
INSERT INTO `audittrail` VALUES ('448', '1', 'Login', 'Login', '2022-06-06', '3:25:43 PM', '2022-06-06 07:25:19');
INSERT INTO `audittrail` VALUES ('449', '1', 'Login', 'Login', '2022-06-06', '3:27:05 PM', '2022-06-06 07:26:41');
INSERT INTO `audittrail` VALUES ('450', '1', 'Login', 'Login', '2022-06-06', '3:29:37 PM', '2022-06-06 07:29:13');
INSERT INTO `audittrail` VALUES ('451', '1', 'Login', 'Login', '2022-06-06', '3:42:48 PM', '2022-06-06 07:42:24');
INSERT INTO `audittrail` VALUES ('452', '1', 'Login', 'Login', '2022-06-06', '3:44:51 PM', '2022-06-06 07:44:27');
INSERT INTO `audittrail` VALUES ('453', '1', 'Login', 'Login', '2022-06-06', '3:47:46 PM', '2022-06-06 07:47:22');
INSERT INTO `audittrail` VALUES ('454', '1', 'Login', 'Login', '2022-06-07', '3:45:46 PM', '2022-06-07 07:45:22');
INSERT INTO `audittrail` VALUES ('455', '1', 'Login', 'Login', '2022-06-07', '3:48:20 PM', '2022-06-07 07:47:56');
INSERT INTO `audittrail` VALUES ('456', '1', 'Logout', 'Logout', '2022-06-07', '3:48:42 PM', '2022-06-07 07:48:18');
INSERT INTO `audittrail` VALUES ('457', '1', 'Login', 'Login', '2022-06-07', '3:50:21 PM', '2022-06-07 07:49:57');
INSERT INTO `audittrail` VALUES ('458', '1', 'Login', 'Login', '2022-06-07', '3:54:07 PM', '2022-06-07 07:53:43');
INSERT INTO `audittrail` VALUES ('459', '1', 'Login', 'Login', '2022-06-07', '4:12:36 PM', '2022-06-07 08:12:12');
INSERT INTO `audittrail` VALUES ('460', '1', 'Login', 'Login', '2022-06-07', '4:18:26 PM', '2022-06-07 08:18:02');
INSERT INTO `audittrail` VALUES ('461', '1', 'Trans No.: R000000002  PO. No.: 1000000000000B  Invoice No.:  1000000000000B  Supplier: GSPI', 'Update Receiving', '2022-06-07', '4:36:33 PM', '2022-06-07 08:36:09');
INSERT INTO `audittrail` VALUES ('462', '1', 'Login', 'Login', '2022-06-07', '4:37:16 PM', '2022-06-07 08:36:52');
INSERT INTO `audittrail` VALUES ('463', '1', 'Logout', 'Logout', '2022-06-07', '4:42:34 PM', '2022-06-07 08:42:10');
INSERT INTO `audittrail` VALUES ('464', '1', 'Login', 'Login', '2022-06-08', '2:17:10 PM', '2022-06-08 06:16:46');
INSERT INTO `audittrail` VALUES ('465', '1', 'Trans No.:R000000005  PO. No.:AA  Invoice No.:AA  Supplier:GSPI', 'Save&Print Receiving', '2022-06-08', '2:18:09 PM', '2022-06-08 06:17:45');
INSERT INTO `audittrail` VALUES ('466', '1', 'Trans No.: R000000005  PO. No.: 1000000000000E  Invoice No.:  1000000000000E  Supplier: GSPI', 'Update Receiving', '2022-06-08', '2:19:02 PM', '2022-06-08 06:18:38');
INSERT INTO `audittrail` VALUES ('467', '1', 'Transno.:   Date:   6/8/2022  From:  YLK  To:  3AW', 'Add New Stock Transfer', '2022-06-08', '2:24:49 PM', '2022-06-08 06:24:25');
INSERT INTO `audittrail` VALUES ('468', '1', 'Transno.: T000000003  Date:  6/8/2022  From: YLK  To:  3AW', 'Update Stock Transfer', '2022-06-08', '2:25:45 PM', '2022-06-08 06:25:21');
INSERT INTO `audittrail` VALUES ('469', '1', 'Transno.: T000000003  Date:  6/8/2022  From: YLK  To:  3AW', 'Update Stock Transfer', '2022-06-08', '2:27:31 PM', '2022-06-08 06:27:07');
INSERT INTO `audittrail` VALUES ('470', '1', 'Transno.: T000000003  Date:  6/8/2022  From: YLK  To:  3AW', 'Update Stock Transfer', '2022-06-08', '2:28:02 PM', '2022-06-08 06:27:38');
INSERT INTO `audittrail` VALUES ('471', '1', 'Login', 'Login', '2022-06-08', '2:34:14 PM', '2022-06-08 06:33:50');
INSERT INTO `audittrail` VALUES ('472', '1', 'Login', 'Login', '2022-06-08', '2:35:43 PM', '2022-06-08 06:35:19');
INSERT INTO `audittrail` VALUES ('473', '1', 'Login', 'Login', '2022-06-08', '2:37:07 PM', '2022-06-08 06:36:43');
INSERT INTO `audittrail` VALUES ('474', '1', 'Login', 'Login', '2022-06-08', '3:15:27 PM', '2022-06-08 07:15:03');
INSERT INTO `audittrail` VALUES ('475', '1', 'Login', 'Login', '2022-06-08', '3:19:00 PM', '2022-06-08 07:18:36');
INSERT INTO `audittrail` VALUES ('476', '1', 'Login', 'Login', '2022-06-08', '3:20:34 PM', '2022-06-08 07:20:10');
INSERT INTO `audittrail` VALUES ('477', '1', 'Login', 'Login', '2022-06-08', '3:32:01 PM', '2022-06-08 07:31:37');
INSERT INTO `audittrail` VALUES ('478', '1', 'Login', 'Login', '2022-06-08', '3:39:02 PM', '2022-06-08 07:38:38');
INSERT INTO `audittrail` VALUES ('479', '1', 'Login', 'Login', '2022-06-08', '3:40:15 PM', '2022-06-08 07:39:51');
INSERT INTO `audittrail` VALUES ('480', '1', 'Login', 'Login', '2022-06-08', '3:51:33 PM', '2022-06-08 07:51:09');
INSERT INTO `audittrail` VALUES ('481', '1', 'Login', 'Login', '2022-06-08', '3:53:44 PM', '2022-06-08 07:53:20');
INSERT INTO `audittrail` VALUES ('482', '1', 'Login', 'Login', '2022-06-08', '4:12:28 PM', '2022-06-08 08:12:04');
INSERT INTO `audittrail` VALUES ('483', '1', 'Login', 'Login', '2022-06-10', '4:05:35 PM', '2022-06-10 08:05:11');
INSERT INTO `audittrail` VALUES ('484', '1', 'Trans No.: R000000004  PO. No.: 1000000000000D  Invoice No.:  1000000000000D  Supplier: BL', 'Update Receiving', '2022-06-10', '4:06:32 PM', '2022-06-10 08:06:08');
INSERT INTO `audittrail` VALUES ('485', '1', 'Trans No.: R000000003  PO. No.: 1000000000000C  Invoice No.:  1000000000000C  Supplier: GSPI', 'Update Receiving', '2022-06-10', '4:16:51 PM', '2022-06-10 08:16:27');
INSERT INTO `audittrail` VALUES ('486', '1', 'Login', 'Login', '2022-06-11', '9:20:23 AM', '2022-06-11 01:19:59');
INSERT INTO `audittrail` VALUES ('487', '1', 'Trans No.:   Date:  6/11/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-06-11', '9:21:37 AM', '2022-06-11 01:21:13');
INSERT INTO `audittrail` VALUES ('488', '1', 'Logout', 'Logout', '2022-06-11', '9:21:51 AM', '2022-06-11 01:21:27');
INSERT INTO `audittrail` VALUES ('489', '1', 'Login', 'Login', '2022-06-12', '9:50:47 AM', '2022-06-12 01:50:23');
INSERT INTO `audittrail` VALUES ('490', '1', 'Trans No.: R000000001  PO. No.: 10000000000000A  Invoice No.:  10000000000000A  Supplier: GSPI', 'Add Receiving', '2022-06-12', '9:54:40 AM', '2022-06-12 01:54:16');
INSERT INTO `audittrail` VALUES ('491', '1', 'Trans No.: R000000001  PO. No.: 10000000000000A  Invoice No.:  10000000000000A  Supplier: GSPI', 'Update Receiving', '2022-06-12', '9:56:36 AM', '2022-06-12 01:56:12');
INSERT INTO `audittrail` VALUES ('492', '1', 'Trans No.: R000000002  PO. No.: 10000000000000B  Invoice No.:  10000000000000B  Supplier: GSPI', 'Add Receiving', '2022-06-12', '9:59:56 AM', '2022-06-12 01:59:32');
INSERT INTO `audittrail` VALUES ('493', '1', 'Trans No.: R000000002  PO. No.: 10000000000000B  Invoice No.:  10000000000000B  Supplier: GSPI', 'Update Receiving', '2022-06-12', '10:05:42 AM', '2022-06-12 02:05:18');
INSERT INTO `audittrail` VALUES ('494', '1', 'Trans No.: R000000002  PO. No.: 10000000000000B  Invoice No.:  10000000000000B  Supplier: GSPI', 'Update Receiving', '2022-06-12', '10:19:07 AM', '2022-06-12 02:18:43');
INSERT INTO `audittrail` VALUES ('495', '1', 'Trans No.:   Date:  6/12/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-06-12', '10:23:24 AM', '2022-06-12 02:23:00');
INSERT INTO `audittrail` VALUES ('496', '1', 'Trans No.:   Date:  6/12/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-06-12', '10:24:54 AM', '2022-06-12 02:24:30');
INSERT INTO `audittrail` VALUES ('497', '1', 'Login', 'Login', '2022-06-12', '10:59:32 AM', '2022-06-12 02:59:08');
INSERT INTO `audittrail` VALUES ('498', '1', 'Login', 'Login', '2022-06-12', '11:04:48 AM', '2022-06-12 03:04:24');
INSERT INTO `audittrail` VALUES ('499', '1', 'Login', 'Login', '2022-06-12', '11:08:16 AM', '2022-06-12 03:07:52');
INSERT INTO `audittrail` VALUES ('500', '1', 'Login', 'Login', '2022-06-12', '1:11:04 PM', '2022-06-12 05:10:40');
INSERT INTO `audittrail` VALUES ('501', '1', 'Login', 'Login', '2022-06-12', '1:13:13 PM', '2022-06-12 05:12:49');
INSERT INTO `audittrail` VALUES ('502', '1', 'Login', 'Login', '2022-06-12', '1:14:31 PM', '2022-06-12 05:14:07');
INSERT INTO `audittrail` VALUES ('503', '1', 'Login', 'Login', '2022-06-12', '1:17:09 PM', '2022-06-12 05:16:45');
INSERT INTO `audittrail` VALUES ('504', '1', 'Logout', 'Logout', '2022-06-12', '1:18:14 PM', '2022-06-12 05:17:50');
INSERT INTO `audittrail` VALUES ('505', '1', 'Login', 'Login', '2022-06-12', '7:48:47 PM', '2022-06-12 11:48:23');
INSERT INTO `audittrail` VALUES ('506', '1', 'Login', 'Login', '2022-06-12', '7:58:29 PM', '2022-06-12 11:58:05');
INSERT INTO `audittrail` VALUES ('507', '1', 'Login', 'Login', '2022-06-12', '8:42:33 PM', '2022-06-12 12:42:09');
INSERT INTO `audittrail` VALUES ('508', '1', 'Login', 'Login', '2022-06-12', '8:44:37 PM', '2022-06-12 12:44:13');
INSERT INTO `audittrail` VALUES ('509', '1', 'Login', 'Login', '2022-06-12', '8:46:42 PM', '2022-06-12 12:46:18');
INSERT INTO `audittrail` VALUES ('510', '1', 'Login', 'Login', '2022-06-12', '9:03:41 PM', '2022-06-12 13:03:17');
INSERT INTO `audittrail` VALUES ('511', '1', 'Login', 'Login', '2022-06-12', '9:26:41 PM', '2022-06-12 13:26:17');
INSERT INTO `audittrail` VALUES ('512', '1', 'Login', 'Login', '2022-06-12', '9:49:44 PM', '2022-06-12 13:49:20');
INSERT INTO `audittrail` VALUES ('513', '1', 'Login', 'Login', '2022-06-12', '9:59:38 PM', '2022-06-12 13:59:14');
INSERT INTO `audittrail` VALUES ('514', '1', 'Login', 'Login', '2022-06-12', '10:02:02 PM', '2022-06-12 14:01:38');
INSERT INTO `audittrail` VALUES ('515', '1', 'Login', 'Login', '2022-06-12', '10:24:47 PM', '2022-06-12 14:24:23');
INSERT INTO `audittrail` VALUES ('516', '1', 'Login', 'Login', '2022-06-12', '10:31:39 PM', '2022-06-12 14:31:15');
INSERT INTO `audittrail` VALUES ('517', '1', 'Login', 'Login', '2022-06-12', '10:32:12 PM', '2022-06-12 14:31:48');
INSERT INTO `audittrail` VALUES ('518', '1', 'Login', 'Login', '2022-06-12', '10:35:10 PM', '2022-06-12 14:34:46');
INSERT INTO `audittrail` VALUES ('519', '1', 'Login', 'Login', '2022-06-12', '10:41:01 PM', '2022-06-12 14:40:37');
INSERT INTO `audittrail` VALUES ('520', '1', 'Login', 'Login', '2022-06-12', '11:03:50 PM', '2022-06-12 15:03:26');
INSERT INTO `audittrail` VALUES ('521', '1', 'Login', 'Login', '2022-06-12', '11:05:44 PM', '2022-06-12 15:05:20');
INSERT INTO `audittrail` VALUES ('522', '1', 'Login', 'Login', '2022-06-12', '11:09:06 PM', '2022-06-12 15:08:42');
INSERT INTO `audittrail` VALUES ('523', '1', 'Login', 'Login', '2022-06-13', '10:17:50 AM', '2022-06-13 02:17:26');
INSERT INTO `audittrail` VALUES ('524', '1', 'Trans No.: R000000001  PO. No.: 10000000000000A  Invoice No.:  10000000000000A  Supplier: GSPI', 'Update Receiving', '2022-06-13', '10:21:39 AM', '2022-06-13 02:21:15');
INSERT INTO `audittrail` VALUES ('525', '1', 'Login', 'Login', '2022-06-13', '10:23:43 AM', '2022-06-13 02:23:19');
INSERT INTO `audittrail` VALUES ('526', '1', 'Login', 'Login', '2022-06-13', '2:26:42 PM', '2022-06-13 06:26:18');
INSERT INTO `audittrail` VALUES ('527', '1', 'Login', 'Login', '2022-06-13', '2:47:54 PM', '2022-06-13 06:47:30');
INSERT INTO `audittrail` VALUES ('528', '1', 'Login', 'Login', '2022-06-13', '2:53:46 PM', '2022-06-13 06:53:22');
INSERT INTO `audittrail` VALUES ('529', '1', 'Trans No.:   Date:  6/13/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-06-13', '3:16:24 PM', '2022-06-13 07:16:00');
INSERT INTO `audittrail` VALUES ('530', '1', 'Whs code.: WHS3  Warehouse name: WAREHOUSE 3', 'Add New Warehouse', '2022-06-13', '3:17:54 PM', '2022-06-13 07:17:30');
INSERT INTO `audittrail` VALUES ('531', '1', 'Login', 'Login', '2022-06-13', '3:24:10 PM', '2022-06-13 07:23:46');
INSERT INTO `audittrail` VALUES ('532', '1', 'Login', 'Login', '2022-06-13', '3:43:53 PM', '2022-06-13 07:43:29');
INSERT INTO `audittrail` VALUES ('533', '1', 'Trans No.: R000000003  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-06-13', '3:44:27 PM', '2022-06-13 07:44:03');
INSERT INTO `audittrail` VALUES ('534', '1', 'Trans No.: R000000003  PO. No.: 10000000000000C  Invoice No.:  10000000000000C  Supplier: GSPI', 'Update Receiving', '2022-06-13', '3:45:25 PM', '2022-06-13 07:45:01');
INSERT INTO `audittrail` VALUES ('535', '1', 'Whs code.: WHS4  Warehouse name: WAREHOUSE 4', 'Add New Warehouse', '2022-06-13', '3:45:59 PM', '2022-06-13 07:45:35');
INSERT INTO `audittrail` VALUES ('536', '1', 'Trans No.: R000000003  PO. No.: 10000000000000C  Invoice No.:  10000000000000C  Supplier: GSPI', 'Update Receiving', '2022-06-13', '3:46:27 PM', '2022-06-13 07:46:03');
INSERT INTO `audittrail` VALUES ('537', '1', 'Login', 'Login', '2022-06-13', '4:10:32 PM', '2022-06-13 08:10:08');
INSERT INTO `audittrail` VALUES ('538', '1', 'Trans No.: R000000003  PO. No.: 10000000000000C  Invoice No.:  10000000000000C  Supplier: GSPI', 'Update Receiving', '2022-06-13', '4:10:53 PM', '2022-06-13 08:10:29');
INSERT INTO `audittrail` VALUES ('539', '1', 'Login', 'Login', '2022-06-14', '9:40:33 AM', '2022-06-14 01:40:09');
INSERT INTO `audittrail` VALUES ('540', '1', 'Login', 'Login', '2022-06-14', '9:53:28 AM', '2022-06-14 01:53:04');
INSERT INTO `audittrail` VALUES ('541', '1', 'Login', 'Login', '2022-06-14', '10:11:29 AM', '2022-06-14 02:11:05');
INSERT INTO `audittrail` VALUES ('542', '1', 'Login', 'Login', '2022-06-15', '9:08:07 AM', '2022-06-15 01:07:43');
INSERT INTO `audittrail` VALUES ('543', '1', 'Logout', 'Logout', '2022-06-15', '9:10:53 AM', '2022-06-15 01:10:29');
INSERT INTO `audittrail` VALUES ('544', '1', 'Login', 'Login', '2022-06-15', '9:11:34 AM', '2022-06-15 01:11:10');
INSERT INTO `audittrail` VALUES ('545', '1', 'Logout', 'Logout', '2022-06-15', '9:12:31 AM', '2022-06-15 01:12:07');
INSERT INTO `audittrail` VALUES ('546', '1', 'Login', 'Login', '2022-06-15', '9:25:22 AM', '2022-06-15 01:24:58');
INSERT INTO `audittrail` VALUES ('547', '1', 'Logout', 'Logout', '2022-06-15', '10:28:52 AM', '2022-06-15 02:28:28');
INSERT INTO `audittrail` VALUES ('548', '1', 'Login', 'Login', '2022-06-15', '3:13:10 PM', '2022-06-15 07:12:46');
INSERT INTO `audittrail` VALUES ('549', '1', 'Login', 'Login', '2022-06-17', '3:48:06 PM', '2022-06-17 07:47:42');
INSERT INTO `audittrail` VALUES ('550', '1', 'Login', 'Login', '2022-06-17', '4:02:53 PM', '2022-06-17 08:02:29');
INSERT INTO `audittrail` VALUES ('551', '1', 'Login', 'Login', '2022-06-18', '10:14:25 AM', '2022-06-18 02:14:01');
INSERT INTO `audittrail` VALUES ('552', '1', 'Login', 'Login', '2022-06-18', '2:24:28 PM', '2022-06-18 06:24:04');
INSERT INTO `audittrail` VALUES ('553', '1', 'Login', 'Login', '2022-06-20', '9:40:43 AM', '2022-06-20 01:40:19');
INSERT INTO `audittrail` VALUES ('554', '1', 'Whs code.: WHS5  Warehouse name: WAREHOUSE 5', 'Add New Warehouse', '2022-06-20', '9:40:58 AM', '2022-06-20 01:40:34');
INSERT INTO `audittrail` VALUES ('555', '1', 'Login', 'Login', '2022-06-20', '10:20:32 AM', '2022-06-20 02:20:08');
INSERT INTO `audittrail` VALUES ('556', '1', 'Login', 'Login', '2022-06-20', '10:22:05 AM', '2022-06-20 02:21:41');
INSERT INTO `audittrail` VALUES ('557', '1', 'Login', 'Login', '2022-06-20', '10:39:09 AM', '2022-06-20 02:38:45');
INSERT INTO `audittrail` VALUES ('558', '1', 'Login', 'Login', '2022-06-20', '10:55:31 AM', '2022-06-20 02:55:07');
INSERT INTO `audittrail` VALUES ('559', '1', 'Login', 'Login', '2022-06-20', '11:03:23 AM', '2022-06-20 03:02:59');
INSERT INTO `audittrail` VALUES ('560', '1', 'Login', 'Login', '2022-06-20', '11:10:24 AM', '2022-06-20 03:10:00');
INSERT INTO `audittrail` VALUES ('561', '1', 'Login', 'Login', '2022-06-20', '11:16:34 AM', '2022-06-20 03:16:10');
INSERT INTO `audittrail` VALUES ('562', '1', 'Login', 'Login', '2022-06-20', '11:19:49 AM', '2022-06-20 03:19:25');
INSERT INTO `audittrail` VALUES ('563', '1', 'Login', 'Login', '2022-06-20', '4:40:23 PM', '2022-06-20 08:39:59');
INSERT INTO `audittrail` VALUES ('564', '1', 'Logout', 'Logout', '2022-06-20', '4:44:17 PM', '2022-06-20 08:43:53');
INSERT INTO `audittrail` VALUES ('565', '1', 'Login', 'Login', '2022-06-21', '9:57:27 AM', '2022-06-21 01:57:03');
INSERT INTO `audittrail` VALUES ('566', '1', 'Logout', 'Logout', '2022-06-21', '9:57:46 AM', '2022-06-21 01:57:22');
INSERT INTO `audittrail` VALUES ('567', '1', 'Trans No.:R000000001  PO. No.:10000000000000A  Invoice No.:10000000000000A  Supplier:GSPI', 'Receiving Update', '2022-06-21', '3:00:04 PM', '2022-06-21 06:59:40');
INSERT INTO `audittrail` VALUES ('568', '1', 'Trans No.:R000000001  PO. No.:10000000000000A  Invoice No.:10000000000000A  Supplier:GSPI', 'Receiving Entry', '2022-06-21', '3:22:34 PM', '2022-06-21 07:22:10');
INSERT INTO `audittrail` VALUES ('569', '1', 'Trans No.:R000000001  PO. No.:10000000000000A  Invoice No.:10000000000000A  Supplier:GSPI', 'Receiving Update', '2022-06-21', '3:25:45 PM', '2022-06-21 07:25:21');
INSERT INTO `audittrail` VALUES ('570', '1', 'Trans No.:R000000001  PO. No.:10000000000000A  Invoice No.:10000000000000A  Supplier:GSPI', 'Receiving Update', '2022-06-21', '3:27:23 PM', '2022-06-21 07:26:59');
INSERT INTO `audittrail` VALUES ('571', '1', 'Login', 'Login', '2022-06-22', '10:03:53 AM', '2022-06-22 02:03:29');
INSERT INTO `audittrail` VALUES ('572', '1', 'Logout', 'Logout', '2022-06-22', '10:04:27 AM', '2022-06-22 02:04:03');
INSERT INTO `audittrail` VALUES ('573', '1', 'Login', 'Login', '2022-06-22', '10:04:57 AM', '2022-06-22 02:04:33');
INSERT INTO `audittrail` VALUES ('574', '1', 'Login', 'Login', '2022-06-22', '10:10:41 AM', '2022-06-22 02:10:17');
INSERT INTO `audittrail` VALUES ('575', '1', 'Login', 'Login', '2022-06-22', '10:12:59 AM', '2022-06-22 02:12:35');
INSERT INTO `audittrail` VALUES ('576', '1', 'Login', 'Login', '2022-06-22', '11:12:49 AM', '2022-06-22 03:12:25');
INSERT INTO `audittrail` VALUES ('577', '1', 'Trans No.:R000000002  PO. No.:A  Invoice No.:A  Supplier:GSPI', 'Receiving Entry', '2022-06-28', '3:11:19 PM', '2022-06-28 07:10:55');
INSERT INTO `audittrail` VALUES ('578', '1', 'Trans No.:R000000002  PO. No.:10000000000000B  Invoice No.:10000000000000B  Supplier:GSPI', 'Receiving Update', '2022-06-28', '3:11:51 PM', '2022-06-28 07:11:27');
INSERT INTO `audittrail` VALUES ('579', '1', 'Login', 'Login', '2022-06-30', '2:34:19 PM', '2022-06-30 06:33:55');
INSERT INTO `audittrail` VALUES ('580', '1', 'Logout', 'Logout', '2022-06-30', '2:37:30 PM', '2022-06-30 06:37:06');
INSERT INTO `audittrail` VALUES ('581', '1', 'Login', 'Login', '2022-06-30', '2:39:24 PM', '2022-06-30 06:39:00');
INSERT INTO `audittrail` VALUES ('582', '1', 'Login', 'Login', '2022-06-30', '2:40:03 PM', '2022-06-30 06:39:39');
INSERT INTO `audittrail` VALUES ('583', '1', 'Login', 'Login', '2022-06-30', '2:41:03 PM', '2022-06-30 06:40:39');
INSERT INTO `audittrail` VALUES ('584', '1', 'Logout', 'Logout', '2022-06-30', '2:41:22 PM', '2022-06-30 06:40:58');
INSERT INTO `audittrail` VALUES ('585', '1', 'Login', 'Login', '2022-06-30', '2:47:35 PM', '2022-06-30 06:47:11');
INSERT INTO `audittrail` VALUES ('586', '1', 'Login', 'Login', '2022-06-30', '2:51:15 PM', '2022-06-30 06:50:51');
INSERT INTO `audittrail` VALUES ('587', '1', 'Login', 'Login', '2022-06-30', '2:53:27 PM', '2022-06-30 06:53:03');
INSERT INTO `audittrail` VALUES ('588', '1', 'Login', 'Login', '2022-06-30', '4:27:23 PM', '2022-06-30 08:26:59');
INSERT INTO `audittrail` VALUES ('589', '1', 'Login', 'Login', '2022-06-30', '4:28:48 PM', '2022-06-30 08:28:24');
INSERT INTO `audittrail` VALUES ('590', '1', 'Login', 'Login', '2022-06-30', '4:29:43 PM', '2022-06-30 08:29:19');
INSERT INTO `audittrail` VALUES ('591', '1', 'Login', 'Login', '2022-06-30', '4:40:10 PM', '2022-06-30 08:39:46');
INSERT INTO `audittrail` VALUES ('592', '1', 'Logout', 'Logout', '2022-06-30', '4:41:05 PM', '2022-06-30 08:40:41');
INSERT INTO `audittrail` VALUES ('593', '1', 'Login', 'Login', '2022-07-01', '4:07:35 PM', '2022-07-01 08:07:11');
INSERT INTO `audittrail` VALUES ('594', '1', 'Login', 'Login', '2022-07-01', '4:15:07 PM', '2022-07-01 08:14:43');
INSERT INTO `audittrail` VALUES ('595', '1', 'Login', 'Login', '2022-07-01', '4:21:10 PM', '2022-07-01 08:20:46');
INSERT INTO `audittrail` VALUES ('596', '1', 'Login', 'Login', '2022-07-01', '4:21:48 PM', '2022-07-01 08:21:24');
INSERT INTO `audittrail` VALUES ('597', '1', 'Login', 'Login', '2022-07-01', '4:23:57 PM', '2022-07-01 08:23:33');
INSERT INTO `audittrail` VALUES ('598', '1', 'Login', 'Login', '2022-07-01', '4:25:11 PM', '2022-07-01 08:24:47');
INSERT INTO `audittrail` VALUES ('599', '1', 'Login', 'Login', '2022-07-01', '4:40:30 PM', '2022-07-01 08:40:06');
INSERT INTO `audittrail` VALUES ('600', '1', 'Login', 'Login', '2022-07-01', '4:41:43 PM', '2022-07-01 08:41:19');
INSERT INTO `audittrail` VALUES ('601', '1', 'Login', 'Login', '2022-07-01', '4:42:52 PM', '2022-07-01 08:42:28');
INSERT INTO `audittrail` VALUES ('602', '1', 'Login', 'Login', '2022-07-01', '4:44:20 PM', '2022-07-01 08:43:56');
INSERT INTO `audittrail` VALUES ('603', '1', 'Logout', 'Logout', '2022-07-01', '4:44:30 PM', '2022-07-01 08:44:06');
INSERT INTO `audittrail` VALUES ('604', '1', 'Login', 'Login', '2022-07-15', '2:37:22 PM', '2022-07-15 06:36:58');
INSERT INTO `audittrail` VALUES ('605', '1', 'Login', 'Login', '2022-07-15', '3:22:48 PM', '2022-07-15 07:22:24');
INSERT INTO `audittrail` VALUES ('606', '1', 'Trans No.: R000000001  PO. No.: 10000000000000A  Invoice No.:  10000000000000A  Supplier: GSPI', 'Update Receiving', '2022-07-15', '3:25:34 PM', '2022-07-15 07:25:10');
INSERT INTO `audittrail` VALUES ('607', '1', 'Trans No.: R000000003  PO. No.: TEST  Invoice No.:  TEST  Supplier: GSPI', 'Add Receiving', '2022-07-15', '3:37:07 PM', '2022-07-15 07:36:43');
INSERT INTO `audittrail` VALUES ('608', '1', 'Trans No.: R000000004  PO. No.: ASDF  Invoice No.:  ASDF  Supplier: GSPI', 'Add Receiving', '2022-07-15', '3:37:24 PM', '2022-07-15 07:37:00');
INSERT INTO `audittrail` VALUES ('609', '1', 'Trans No.: R000000003  PO. No.: TEST  Invoice No.:  TEST  Supplier: GSPI', 'Update Receiving', '2022-07-15', '3:38:37 PM', '2022-07-15 07:38:13');
INSERT INTO `audittrail` VALUES ('610', '1', 'Trans No.: R000000005  PO. No.: TESTA  Invoice No.:  TESTA  Supplier: GSPI', 'Add Receiving', '2022-07-15', '3:58:36 PM', '2022-07-15 07:58:12');
INSERT INTO `audittrail` VALUES ('611', '1', 'Trans No.: R000000006  PO. No.: ASDFA   Invoice No.:  SDFA  Supplier: GSPI', 'Add Receiving', '2022-07-15', '3:58:54 PM', '2022-07-15 07:58:30');
INSERT INTO `audittrail` VALUES ('612', '1', 'Trans No.: R000000006  PO. No.: ASDFA   Invoice No.:  SDFA  Supplier: GSPI', 'Update Receiving', '2022-07-15', '3:59:29 PM', '2022-07-15 07:59:05');
INSERT INTO `audittrail` VALUES ('613', '1', 'Trans No.: R000000007  PO. No.: ASDFDFD  Invoice No.:  DFDFDF  Supplier: GSPI', 'Add Receiving', '2022-07-15', '4:01:25 PM', '2022-07-15 08:01:01');
INSERT INTO `audittrail` VALUES ('614', '1', 'Trans No.: R000000007  PO. No.: ASDFDFD  Invoice No.:  DFDFDF  Supplier: GSPI', 'Update Receiving', '2022-07-15', '4:02:41 PM', '2022-07-15 08:02:17');
INSERT INTO `audittrail` VALUES ('615', '1', 'Trans No.: R000000007  PO. No.: ASDFDFD  Invoice No.:  DFDFDF  Supplier: GSPI', 'Update Receiving', '2022-07-15', '4:04:03 PM', '2022-07-15 08:03:39');
INSERT INTO `audittrail` VALUES ('616', '1', 'Login', 'Login', '2022-07-15', '4:09:26 PM', '2022-07-15 08:09:02');
INSERT INTO `audittrail` VALUES ('617', '1', 'Trans No.: R000000007  PO. No.: ASDFDFD  Invoice No.:  DFDFDF  Supplier: GSPI', 'Update Receiving', '2022-07-15', '4:11:30 PM', '2022-07-15 08:11:06');
INSERT INTO `audittrail` VALUES ('618', '1', 'Trans No.: R000000008  PO. No.: ASDFADSFDF  Invoice No.:  DFSDAFAS  Supplier: GSPI', 'Add Receiving', '2022-07-15', '4:13:52 PM', '2022-07-15 08:13:28');
INSERT INTO `audittrail` VALUES ('619', '1', 'Trans No.: R000000008  PO. No.: ASDFADSFDF  Invoice No.:  DFSDAFAS  Supplier: GSPI', 'Update Receiving', '2022-07-15', '4:15:45 PM', '2022-07-15 08:15:21');
INSERT INTO `audittrail` VALUES ('620', '1', 'Whs code.: WHS7  Warehouse name: WAREHOUSE 7', 'Add New Warehouse', '2022-07-15', '4:16:55 PM', '2022-07-15 08:16:31');
INSERT INTO `audittrail` VALUES ('621', '1', 'Trans No.: R000000008  PO. No.: ASDFADSFDF  Invoice No.:  DFSDAFAS  Supplier: GSPI', 'Update Receiving', '2022-07-15', '4:21:45 PM', '2022-07-15 08:21:21');
INSERT INTO `audittrail` VALUES ('622', '1', 'Login', 'Login', '2022-07-16', '10:42:19 AM', '2022-07-16 02:41:55');
INSERT INTO `audittrail` VALUES ('623', '1', 'Trans No.: R000000003  PO. No.: TEST  Invoice No.:  TEST  Supplier: GSPI', 'Update Receiving', '2022-07-16', '10:47:20 AM', '2022-07-16 02:46:56');
INSERT INTO `audittrail` VALUES ('624', '1', 'Trans No.: R000000009  PO. No.: ASDFDF  Invoice No.:  DFDSF  Supplier: GSPI', 'Add Receiving', '2022-07-16', '10:58:08 AM', '2022-07-16 02:57:44');
INSERT INTO `audittrail` VALUES ('625', '1', 'Trans No.: R000000009  PO. No.: ASDFDF  Invoice No.:  DFDSF  Supplier: GSPI', 'Update Receiving', '2022-07-16', '10:59:00 AM', '2022-07-16 02:58:36');
INSERT INTO `audittrail` VALUES ('626', '1', 'Trans No.: R000000010  PO. No.: FDFDFDF  Invoice No.:  DFDF  Supplier: GSPI', 'Add Receiving', '2022-07-16', '11:08:47 AM', '2022-07-16 03:08:23');
INSERT INTO `audittrail` VALUES ('627', '1', 'Trans No.: R000000010  PO. No.: FDFDFDF  Invoice No.:  DFDF  Supplier: GSPI', 'Update Receiving', '2022-07-16', '11:09:16 AM', '2022-07-16 03:08:52');
INSERT INTO `audittrail` VALUES ('628', '1', 'Trans No.: R000000011  PO. No.: FDFDDD  Invoice No.:  DFDFDD  Supplier: GSPI', 'Add Receiving', '2022-07-16', '11:20:09 AM', '2022-07-16 03:19:45');
INSERT INTO `audittrail` VALUES ('629', '1', 'Trans No.: R000000011  PO. No.: FDFDDD  Invoice No.:  DFDFDD  Supplier: GSPI', 'Update Receiving', '2022-07-16', '11:21:35 AM', '2022-07-16 03:21:11');
INSERT INTO `audittrail` VALUES ('630', '1', 'Logout', 'Logout', '2022-07-16', '11:25:32 AM', '2022-07-16 03:25:08');
INSERT INTO `audittrail` VALUES ('631', '1', 'Login', 'Login', '2022-07-16', '1:58:13 PM', '2022-07-16 05:57:49');
INSERT INTO `audittrail` VALUES ('632', '1', 'Code.: TTT  Description: TEST TEST TEST  Supplier: GSPI  Category: BAR', 'Add New Item', '2022-07-16', '1:58:57 PM', '2022-07-16 05:58:33');
INSERT INTO `audittrail` VALUES ('633', '1', 'Code.: TTT  New code.: MKSP  Description: MISEDAAP KOREAN CITY NOODLES 87G 40X5  Supplier: GSPI  Category: BAR', 'Change Item Code', '2022-07-16', '2:00:53 PM', '2022-07-16 06:00:29');
INSERT INTO `audittrail` VALUES ('634', '1', 'Logout', 'Logout', '2022-07-16', '4:03:36 PM', '2022-07-16 08:03:12');
INSERT INTO `audittrail` VALUES ('635', '1', 'Login', 'Login', '2022-07-18', '1:52:30 PM', '2022-07-18 05:52:06');
INSERT INTO `audittrail` VALUES ('636', '1', 'Whs code.: WHS8  Warehouse name: WAREHOUSE 8', 'Add New Warehouse', '2022-07-18', '1:53:18 PM', '2022-07-18 05:52:54');
INSERT INTO `audittrail` VALUES ('637', '1', 'Whs code.: WHS9  Warehouse name: WAREHOUSE 9', 'Add New Warehouse', '2022-07-18', '1:53:24 PM', '2022-07-18 05:53:00');
INSERT INTO `audittrail` VALUES ('638', '1', 'Whs code.: WH10  Warehouse name: WAREHOUSE 10', 'Add New Warehouse', '2022-07-18', '1:53:32 PM', '2022-07-18 05:53:08');
INSERT INTO `audittrail` VALUES ('639', '1', 'Trans No.:   Date:  7/18/2022  Warehouse: WHS8  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-18', '1:59:03 PM', '2022-07-18 05:58:39');
INSERT INTO `audittrail` VALUES ('640', '1', 'Login', 'Login', '2022-07-18', '2:29:49 PM', '2022-07-18 06:29:25');
INSERT INTO `audittrail` VALUES ('641', '1', 'Logout', 'Logout', '2022-07-18', '2:57:33 PM', '2022-07-18 06:57:09');
INSERT INTO `audittrail` VALUES ('642', '1', 'Login', 'Login', '2022-07-18', '3:11:09 PM', '2022-07-18 07:10:45');
INSERT INTO `audittrail` VALUES ('643', '1', 'Login', 'Login', '2022-07-18', '3:13:12 PM', '2022-07-18 07:12:48');
INSERT INTO `audittrail` VALUES ('644', '1', 'Transno.:   Date:   7/18/2022  From:  WHS8  To:  WHS9', 'Add New Stock Transfer', '2022-07-18', '3:16:49 PM', '2022-07-18 07:16:25');
INSERT INTO `audittrail` VALUES ('645', '1', 'Transno.:   Date:   7/18/2022  From:  YLK  To:  WHS9', 'Add New Stock Transfer', '2022-07-18', '3:19:43 PM', '2022-07-18 07:19:19');
INSERT INTO `audittrail` VALUES ('646', '1', 'Login', 'Login', '2022-07-18', '3:23:12 PM', '2022-07-18 07:22:48');
INSERT INTO `audittrail` VALUES ('647', '1', 'Login', 'Login', '2022-07-18', '3:39:13 PM', '2022-07-18 07:38:49');
INSERT INTO `audittrail` VALUES ('648', '1', 'Transno.:   Date:   7/18/2022  From:  WHS8  To:  WHS9', 'Add New Stock Transfer', '2022-07-18', '3:41:08 PM', '2022-07-18 07:40:44');
INSERT INTO `audittrail` VALUES ('649', '1', 'Trans No.:   Date:  7/18/2022  Warehouse: YLK  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-18', '3:44:23 PM', '2022-07-18 07:43:59');
INSERT INTO `audittrail` VALUES ('650', '1', 'Login', 'Login', '2022-07-18', '3:45:49 PM', '2022-07-18 07:45:25');
INSERT INTO `audittrail` VALUES ('651', '1', 'Login', 'Login', '2022-07-18', '3:47:13 PM', '2022-07-18 07:46:49');
INSERT INTO `audittrail` VALUES ('652', '1', 'Transno.: T000000001  Date:  7/18/2022  From: WHS8  To:  WHS9', 'Delete Stock Transfer', '2022-07-18', '3:48:46 PM', '2022-07-18 07:48:22');
INSERT INTO `audittrail` VALUES ('653', '1', 'Transno.:   Date:   7/18/2022  From:  YLK  To:  WHS9', 'Add New Stock Transfer', '2022-07-18', '3:55:01 PM', '2022-07-18 07:54:37');
INSERT INTO `audittrail` VALUES ('654', '1', 'Transno.: T000000004  Date:  7/18/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-18', '3:57:53 PM', '2022-07-18 07:57:29');
INSERT INTO `audittrail` VALUES ('655', '1', 'Transno.: T000000004  Date:  7/18/2022  From: YLK  To:  WH10', 'Update Stock Transfer', '2022-07-18', '4:03:35 PM', '2022-07-18 08:03:11');
INSERT INTO `audittrail` VALUES ('656', '1', 'Whs code.: WHS11  Warehouse name: WAREHOUSE 11', 'Add New Warehouse', '2022-07-18', '4:08:37 PM', '2022-07-18 08:08:13');
INSERT INTO `audittrail` VALUES ('657', '1', 'Transno.: T000000004  Date:  7/18/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-18', '4:09:49 PM', '2022-07-18 08:09:25');
INSERT INTO `audittrail` VALUES ('658', '1', 'Whs code.: WHS12  Warehouse name: WAREHOUSE 12', 'Add New Warehouse', '2022-07-18', '4:11:31 PM', '2022-07-18 08:11:07');
INSERT INTO `audittrail` VALUES ('659', '1', 'Transno.:   Date:   7/18/2022  From:  WHS11  To:  WHS12', 'Add New Stock Transfer', '2022-07-18', '4:12:38 PM', '2022-07-18 08:12:14');
INSERT INTO `audittrail` VALUES ('660', '1', 'Transno.: T000000005  Date:  7/18/2022  From: WHS11  To:  WHS9', 'Update Stock Transfer', '2022-07-18', '4:21:32 PM', '2022-07-18 08:21:08');
INSERT INTO `audittrail` VALUES ('661', '1', 'Whs code.: WHS13  Warehouse name: WAREHOUSE 13', 'Add New Warehouse', '2022-07-18', '4:23:04 PM', '2022-07-18 08:22:40');
INSERT INTO `audittrail` VALUES ('662', '1', 'Whs code.: WHS14  Warehouse name: WAREHOUSE 14', 'Add New Warehouse', '2022-07-18', '4:25:14 PM', '2022-07-18 08:24:50');
INSERT INTO `audittrail` VALUES ('663', '1', 'Transno.:   Date:   7/18/2022  From:  YLK  To:  WHS13', 'Add New Stock Transfer', '2022-07-18', '4:25:57 PM', '2022-07-18 08:25:33');
INSERT INTO `audittrail` VALUES ('664', '1', 'Transno.: T000000006  Date:  7/18/2022  From: YLK  To:  WHS14', 'Update Stock Transfer', '2022-07-18', '4:27:41 PM', '2022-07-18 08:27:17');
INSERT INTO `audittrail` VALUES ('665', '1', 'Transno.:   Date:   7/18/2022  From:  YLK  To:  WHS13', 'Add New Stock Transfer', '2022-07-18', '4:32:04 PM', '2022-07-18 08:31:40');
INSERT INTO `audittrail` VALUES ('666', '1', 'Transno.: T000000007  Date:  7/18/2022  From: YLK  To:  WHS14', 'Update Stock Transfer', '2022-07-18', '4:32:33 PM', '2022-07-18 08:32:09');
INSERT INTO `audittrail` VALUES ('667', '1', 'Logout', 'Logout', '2022-07-18', '4:40:31 PM', '2022-07-18 08:40:07');
INSERT INTO `audittrail` VALUES ('668', '1', 'Login', 'Login', '2022-07-19', '9:23:15 AM', '2022-07-19 01:22:51');
INSERT INTO `audittrail` VALUES ('669', '1', 'Trans No.: R000000012  PO. No.: ASDFF  Invoice No.:  SDFF  Supplier: GSPI', 'Add Receiving', '2022-07-19', '9:30:16 AM', '2022-07-19 01:29:52');
INSERT INTO `audittrail` VALUES ('670', '1', 'Trans No.: R000000012  PO. No.: ASDFF  Invoice No.:  SDFF  Supplier: GSPI', 'Update Receiving', '2022-07-19', '9:31:25 AM', '2022-07-19 01:31:01');
INSERT INTO `audittrail` VALUES ('671', '1', 'Login', 'Login', '2022-07-19', '9:35:08 AM', '2022-07-19 01:34:44');
INSERT INTO `audittrail` VALUES ('672', '1', 'Login', 'Login', '2022-07-19', '9:37:00 AM', '2022-07-19 01:36:36');
INSERT INTO `audittrail` VALUES ('673', '1', 'Login', 'Login', '2022-07-19', '10:11:47 AM', '2022-07-19 02:11:23');
INSERT INTO `audittrail` VALUES ('674', '1', 'Trans No.: R000000002  PO. No.: 10000000000000B  Invoice No.:  10000000000000B  Supplier: GSPI', 'Update Receiving', '2022-07-19', '10:13:10 AM', '2022-07-19 02:12:46');
INSERT INTO `audittrail` VALUES ('675', '1', 'Trans No.: R000000002  PO. No.: 10000000000000B  Invoice No.:  10000000000000B  Supplier: GSPI', 'Update Receiving', '2022-07-19', '10:31:06 AM', '2022-07-19 02:30:42');
INSERT INTO `audittrail` VALUES ('676', '1', 'Login', 'Login', '2022-07-19', '10:32:26 AM', '2022-07-19 02:32:02');
INSERT INTO `audittrail` VALUES ('677', '1', 'Login', 'Login', '2022-07-19', '10:34:59 AM', '2022-07-19 02:34:35');
INSERT INTO `audittrail` VALUES ('678', '1', 'Login', 'Login', '2022-07-19', '10:37:09 AM', '2022-07-19 02:36:45');
INSERT INTO `audittrail` VALUES ('679', '1', 'Login', 'Login', '2022-07-19', '10:40:43 AM', '2022-07-19 02:40:19');
INSERT INTO `audittrail` VALUES ('680', '1', 'Login', 'Login', '2022-07-19', '10:50:21 AM', '2022-07-19 02:49:57');
INSERT INTO `audittrail` VALUES ('681', '1', 'Login', 'Login', '2022-07-19', '11:11:05 AM', '2022-07-19 03:10:41');
INSERT INTO `audittrail` VALUES ('682', '1', 'Login', 'Login', '2022-07-19', '11:29:41 AM', '2022-07-19 03:29:17');
INSERT INTO `audittrail` VALUES ('683', '1', 'Login', 'Login', '2022-07-19', '11:31:06 AM', '2022-07-19 03:30:42');
INSERT INTO `audittrail` VALUES ('684', '1', 'Login', 'Login', '2022-07-19', '11:34:16 AM', '2022-07-19 03:33:52');
INSERT INTO `audittrail` VALUES ('685', '1', 'Login', 'Login', '2022-07-19', '11:35:31 AM', '2022-07-19 03:35:07');
INSERT INTO `audittrail` VALUES ('686', '1', 'Login', 'Login', '2022-07-19', '1:58:27 PM', '2022-07-19 05:58:03');
INSERT INTO `audittrail` VALUES ('687', '1', 'Login', 'Login', '2022-07-19', '2:03:45 PM', '2022-07-19 06:03:21');
INSERT INTO `audittrail` VALUES ('688', '1', 'Login', 'Login', '2022-07-19', '2:08:32 PM', '2022-07-19 06:08:08');
INSERT INTO `audittrail` VALUES ('689', '1', 'Whs code.: WHS15  Warehouse name: WAREHOUSE 15', 'Add New Warehouse', '2022-07-19', '2:59:56 PM', '2022-07-19 06:59:32');
INSERT INTO `audittrail` VALUES ('690', '1', 'Login', 'Login', '2022-07-19', '4:25:25 PM', '2022-07-19 08:25:01');
INSERT INTO `audittrail` VALUES ('691', '1', 'Login', 'Login', '2022-07-19', '4:49:29 PM', '2022-07-19 08:49:05');
INSERT INTO `audittrail` VALUES ('692', '1', 'Trans No.: R000000012  PO. No.: ASDFF  Invoice No.:  SDFF  Supplier: GSPI', 'Update Receiving', '2022-07-19', '4:50:22 PM', '2022-07-19 08:49:58');
INSERT INTO `audittrail` VALUES ('693', '1', 'Transno.: T000000003  Date:  7/18/2022  From: WHS8  To:  WHS14', 'Update Stock Transfer', '2022-07-19', '4:58:01 PM', '2022-07-19 08:57:37');
INSERT INTO `audittrail` VALUES ('694', '1', 'Login', 'Login', '2022-07-20', '8:31:51 AM', '2022-07-20 00:31:27');
INSERT INTO `audittrail` VALUES ('695', '1', 'Whs code.: WHS16  Warehouse name: WAREHOUSE 16', 'Add New Warehouse', '2022-07-20', '8:40:17 AM', '2022-07-20 00:39:53');
INSERT INTO `audittrail` VALUES ('696', '1', 'Trans No.: R000000013  PO. No.: FDFD  Invoice No.:  DFD  Supplier: GSPI', 'Add Receiving', '2022-07-20', '8:49:57 AM', '2022-07-20 00:49:33');
INSERT INTO `audittrail` VALUES ('697', '1', 'Trans No.: R000000013  PO. No.: FDFD  Invoice No.:  DFD  Supplier: GSPI', 'Update Receiving', '2022-07-20', '8:51:44 AM', '2022-07-20 00:51:20');
INSERT INTO `audittrail` VALUES ('698', '1', 'Trans No.: R000000013  PO. No.: FDFD  Invoice No.:  DFD  Supplier: GSPI', 'Update Receiving', '2022-07-20', '8:54:39 AM', '2022-07-20 00:54:15');
INSERT INTO `audittrail` VALUES ('699', '1', 'Login', 'Login', '2022-07-20', '9:02:07 AM', '2022-07-20 01:01:43');
INSERT INTO `audittrail` VALUES ('700', '1', 'Trans No.: R000000013  PO. No.: FDFD  Invoice No.:  DFD  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:03:18 AM', '2022-07-20 01:02:54');
INSERT INTO `audittrail` VALUES ('701', '1', 'Trans No.: R000000014  PO. No.: FCCC  Invoice No.:  VCCC  Supplier: GSPI', 'Add Receiving', '2022-07-20', '9:05:28 AM', '2022-07-20 01:05:04');
INSERT INTO `audittrail` VALUES ('702', '1', 'Trans No.: R000000003  PO. No.: 10000000000000C  Invoice No.:  10000000000000C  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:19:47 AM', '2022-07-20 01:19:23');
INSERT INTO `audittrail` VALUES ('703', '1', 'Trans No.: R000000004  PO. No.: 10000000000000E  Invoice No.:  10000000000000E  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:20:01 AM', '2022-07-20 01:19:37');
INSERT INTO `audittrail` VALUES ('704', '1', 'Trans No.: R000000005  PO. No.: 10000000000000F  Invoice No.:  10000000000000F  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:20:15 AM', '2022-07-20 01:19:51');
INSERT INTO `audittrail` VALUES ('705', '1', 'Trans No.: R000000006  PO. No.: 10000000000000G  Invoice No.:  10000000000000G  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:20:29 AM', '2022-07-20 01:20:05');
INSERT INTO `audittrail` VALUES ('706', '1', 'Trans No.: R000000007  PO. No.: 10000000000000H  Invoice No.:  10000000000000H  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:20:40 AM', '2022-07-20 01:20:16');
INSERT INTO `audittrail` VALUES ('707', '1', 'Trans No.: R000000008  PO. No.: 10000000000000I  Invoice No.:  10000000000000I  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:20:51 AM', '2022-07-20 01:20:27');
INSERT INTO `audittrail` VALUES ('708', '1', 'Trans No.: R000000009  PO. No.: 10000000000000J  Invoice No.:  10000000000000J  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:21:00 AM', '2022-07-20 01:20:36');
INSERT INTO `audittrail` VALUES ('709', '1', 'Trans No.: R000000007  PO. No.: 10000000000000D  Invoice No.:  10000000000000D  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:21:19 AM', '2022-07-20 01:20:55');
INSERT INTO `audittrail` VALUES ('710', '1', 'Trans No.: R000000010  PO. No.: 10000000000000H  Invoice No.:  10000000000000H  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:21:32 AM', '2022-07-20 01:21:08');
INSERT INTO `audittrail` VALUES ('711', '1', 'Trans No.: R000000011  PO. No.: 10000000000000K  Invoice No.:  10000000000000K  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:22:01 AM', '2022-07-20 01:21:37');
INSERT INTO `audittrail` VALUES ('712', '1', 'Trans No.: R000000012  PO. No.: 10000000000000L  Invoice No.:  10000000000000L  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:22:13 AM', '2022-07-20 01:21:49');
INSERT INTO `audittrail` VALUES ('713', '1', 'Trans No.: R000000013  PO. No.: 10000000000000M  Invoice No.:  10000000000000M  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:22:24 AM', '2022-07-20 01:22:00');
INSERT INTO `audittrail` VALUES ('714', '1', 'Trans No.: R000000014  PO. No.: 10000000000000O  Invoice No.:  10000000000000O  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:22:36 AM', '2022-07-20 01:22:12');
INSERT INTO `audittrail` VALUES ('715', '1', 'Trans No.: R000000015  PO. No.: 10000000000000P  Invoice No.:  10000000000000P  Supplier: GSPI', 'Add Receiving', '2022-07-20', '9:24:02 AM', '2022-07-20 01:23:38');
INSERT INTO `audittrail` VALUES ('716', '1', 'Login', 'Login', '2022-07-20', '9:25:07 AM', '2022-07-20 01:24:43');
INSERT INTO `audittrail` VALUES ('717', '1', 'Whs code.: WHS17  Warehouse name: WAREHOUSE 17', 'Add New Warehouse', '2022-07-20', '9:36:18 AM', '2022-07-20 01:35:54');
INSERT INTO `audittrail` VALUES ('718', '1', 'Trans No.: R000000014  PO. No.: 10000000000000O  Invoice No.:  10000000000000O  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:50:57 AM', '2022-07-20 01:50:33');
INSERT INTO `audittrail` VALUES ('719', '1', 'Trans No.: R000000013  PO. No.: 10000000000000M  Invoice No.:  10000000000000M  Supplier: GSPI', 'Update Receiving', '2022-07-20', '9:53:08 AM', '2022-07-20 01:52:44');
INSERT INTO `audittrail` VALUES ('720', '1', 'Trans No.: R000000005  PO. No.: 10000000000000F  Invoice No.:  10000000000000F  Supplier: GSPI', 'Update Receiving', '2022-07-20', '10:00:47 AM', '2022-07-20 02:00:23');
INSERT INTO `audittrail` VALUES ('721', '1', 'Trans No.: R000000005  PO. No.: 10000000000000F  Invoice No.:  10000000000000F  Supplier: GSPI', 'Update Receiving', '2022-07-20', '10:01:40 AM', '2022-07-20 02:01:16');
INSERT INTO `audittrail` VALUES ('722', '1', 'Login', 'Login', '2022-07-20', '11:09:56 AM', '2022-07-20 03:09:32');
INSERT INTO `audittrail` VALUES ('723', '1', 'Trans No.: R000000006  PO. No.: 10000000000000G  Invoice No.:  10000000000000G  Supplier: GSPI', 'Update Receiving', '2022-07-20', '11:11:54 AM', '2022-07-20 03:11:30');
INSERT INTO `audittrail` VALUES ('724', '1', 'Trans No.: R000000006  PO. No.: 10000000000000G  Invoice No.:  10000000000000G  Supplier: GSPI', 'Update Receiving', '2022-07-20', '11:12:36 AM', '2022-07-20 03:12:12');
INSERT INTO `audittrail` VALUES ('725', '1', 'Trans No.: R000000006  PO. No.: 10000000000000G  Invoice No.:  10000000000000G  Supplier: GSPI', 'Update Receiving', '2022-07-20', '11:14:17 AM', '2022-07-20 03:13:53');
INSERT INTO `audittrail` VALUES ('726', '1', 'Login', 'Login', '2022-07-20', '2:09:03 PM', '2022-07-20 06:08:39');
INSERT INTO `audittrail` VALUES ('727', '1', 'Trans No.:   Date:  7/20/2022  Warehouse: WHS9  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-20', '2:24:47 PM', '2022-07-20 06:24:23');
INSERT INTO `audittrail` VALUES ('728', '1', 'Logout', 'Logout', '2022-07-20', '2:27:25 PM', '2022-07-20 06:27:01');
INSERT INTO `audittrail` VALUES ('729', '1', 'Login', 'Login', '2022-07-20', '3:00:01 PM', '2022-07-20 06:59:37');
INSERT INTO `audittrail` VALUES ('730', '1', 'Login', 'Login', '2022-07-20', '3:25:58 PM', '2022-07-20 07:25:34');
INSERT INTO `audittrail` VALUES ('731', '1', 'Transno.:   Date:   7/20/2022  From:  YLK  To:  WHS17', 'Add New Stock Transfer', '2022-07-20', '3:28:29 PM', '2022-07-20 07:28:05');
INSERT INTO `audittrail` VALUES ('732', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS17', 'Update Stock Transfer', '2022-07-20', '3:29:33 PM', '2022-07-20 07:29:09');
INSERT INTO `audittrail` VALUES ('733', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS17', 'Update Stock Transfer', '2022-07-20', '3:38:33 PM', '2022-07-20 07:38:09');
INSERT INTO `audittrail` VALUES ('734', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS17', 'Update Stock Transfer', '2022-07-20', '3:39:35 PM', '2022-07-20 07:39:11');
INSERT INTO `audittrail` VALUES ('735', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS17', 'Update Stock Transfer', '2022-07-20', '3:41:36 PM', '2022-07-20 07:41:12');
INSERT INTO `audittrail` VALUES ('736', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS17', 'Update Stock Transfer', '2022-07-20', '3:45:48 PM', '2022-07-20 07:45:24');
INSERT INTO `audittrail` VALUES ('737', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS17', 'Update Stock Transfer', '2022-07-20', '3:48:00 PM', '2022-07-20 07:47:36');
INSERT INTO `audittrail` VALUES ('738', '1', 'Whs code.: WHS18  Warehouse name: WAREHOUSE 18', 'Add New Warehouse', '2022-07-20', '3:49:05 PM', '2022-07-20 07:48:41');
INSERT INTO `audittrail` VALUES ('739', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS18', 'Update Stock Transfer', '2022-07-20', '3:52:30 PM', '2022-07-20 07:52:06');
INSERT INTO `audittrail` VALUES ('740', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS18', 'Update Stock Transfer', '2022-07-20', '4:05:48 PM', '2022-07-20 08:05:24');
INSERT INTO `audittrail` VALUES ('741', '1', 'Transno.: T000000008  Date:  7/20/2022  From: YLK  To:  WHS18', 'Delete Stock Transfer', '2022-07-20', '4:10:15 PM', '2022-07-20 08:09:51');
INSERT INTO `audittrail` VALUES ('742', '1', 'Login', 'Login', '2022-07-20', '4:33:57 PM', '2022-07-20 08:33:33');
INSERT INTO `audittrail` VALUES ('743', '1', 'Trans No.: R000000015  PO. No.: 10000000000000P  Invoice No.:  10000000000000P  Supplier: GSPI', 'Update Receiving', '2022-07-20', '4:36:02 PM', '2022-07-20 08:35:38');
INSERT INTO `audittrail` VALUES ('744', '1', 'Trans No.: R000000014  PO. No.: 10000000000000O  Invoice No.:  10000000000000O  Supplier: GSPI', 'Update Receiving', '2022-07-20', '4:48:59 PM', '2022-07-20 08:48:35');
INSERT INTO `audittrail` VALUES ('745', '1', 'Whs code.: WHS19  Warehouse name: WAREHOUSE 19', 'Add New Warehouse', '2022-07-20', '4:50:39 PM', '2022-07-20 08:50:15');
INSERT INTO `audittrail` VALUES ('746', '1', 'Whs code.: WHS20  Warehouse name: WAREHOUSE 20', 'Add New Warehouse', '2022-07-20', '4:50:44 PM', '2022-07-20 08:50:20');
INSERT INTO `audittrail` VALUES ('747', '1', 'Trans No.: R000000016  PO. No.: FDFDFDFDFD  Invoice No.:  DFDFDFDF  Supplier: GSPI', 'Add Receiving', '2022-07-20', '4:51:11 PM', '2022-07-20 08:50:47');
INSERT INTO `audittrail` VALUES ('748', '1', 'Trans No.: R000000017  PO. No.: FDFC  Invoice No.:  VCVCV  Supplier: GSPI', 'Add Receiving', '2022-07-20', '4:54:24 PM', '2022-07-20 08:54:00');
INSERT INTO `audittrail` VALUES ('749', '1', 'Trans No.: R000000017  PO. No.: FDFC  Invoice No.:  VCVCV  Supplier: GSPI', 'Update Receiving', '2022-07-20', '4:54:46 PM', '2022-07-20 08:54:22');
INSERT INTO `audittrail` VALUES ('750', '1', 'Trans No.: R000000017  PO. No.: FDFC  Invoice No.:  VCVCV  Supplier: GSPI', 'Update Receiving', '2022-07-20', '4:57:47 PM', '2022-07-20 08:57:23');
INSERT INTO `audittrail` VALUES ('751', '1', 'Trans No.: R000000017  PO. No.: FDFC  Invoice No.:  VCVCV  Supplier: GSPI', 'Update Receiving', '2022-07-20', '4:59:08 PM', '2022-07-20 08:58:44');
INSERT INTO `audittrail` VALUES ('752', '1', 'Login', 'Login', '2022-07-21', '8:54:31 AM', '2022-07-21 00:54:07');
INSERT INTO `audittrail` VALUES ('753', '1', 'Logout', 'Logout', '2022-07-21', '9:22:18 AM', '2022-07-21 01:21:54');
INSERT INTO `audittrail` VALUES ('754', '1', 'Login', 'Login', '2022-07-21', '9:23:30 AM', '2022-07-21 01:23:06');
INSERT INTO `audittrail` VALUES ('755', '1', 'Login', 'Login', '2022-07-21', '1:31:26 PM', '2022-07-21 05:31:02');
INSERT INTO `audittrail` VALUES ('756', '1', 'Trans No.: R000000016  PO. No.: 10000000000000Q  Invoice No.:  10000000000000Q  Supplier: GSPI', 'Update Receiving', '2022-07-21', '1:39:50 PM', '2022-07-21 05:39:26');
INSERT INTO `audittrail` VALUES ('757', '1', 'Transno.: T000000003  Date:  7/18/2022  From: WHS8  To:  WHS14', 'Update Stock Transfer', '2022-07-21', '1:47:28 PM', '2022-07-21 05:47:04');
INSERT INTO `audittrail` VALUES ('758', '1', 'Whs code.: WHS21  Warehouse name: WAREHOUSE 21', 'Add New Warehouse', '2022-07-21', '1:55:58 PM', '2022-07-21 05:55:34');
INSERT INTO `audittrail` VALUES ('759', '1', 'Whs code.: WHS22  Warehouse name: WAREHOUSE 22', 'Add New Warehouse', '2022-07-21', '1:56:05 PM', '2022-07-21 05:55:41');
INSERT INTO `audittrail` VALUES ('760', '1', 'Transno.: T000000002  Date:  7/18/2022  From: YLK  To:  WHS20', 'Update Stock Transfer', '2022-07-21', '2:12:02 PM', '2022-07-21 06:11:38');
INSERT INTO `audittrail` VALUES ('761', '1', 'Transno.: T000000002  Date:  7/18/2022  From: YLK  To:  WHS21', 'Update Stock Transfer', '2022-07-21', '2:17:15 PM', '2022-07-21 06:16:51');
INSERT INTO `audittrail` VALUES ('762', '1', 'Transno.: T000000002  Date:  7/18/2022  From: YLK  To:  WHS21', 'Update Stock Transfer', '2022-07-21', '2:18:49 PM', '2022-07-21 06:18:25');
INSERT INTO `audittrail` VALUES ('763', '1', 'Transno.: T000000002  Date:  7/18/2022  From: YLK  To:  WHS21', 'Update Stock Transfer', '2022-07-21', '2:19:37 PM', '2022-07-21 06:19:13');
INSERT INTO `audittrail` VALUES ('764', '1', 'Transno.: T000000005  Date:  7/18/2022  From: WHS11  To:  WHS9', 'Update Stock Transfer', '2022-07-21', '2:22:53 PM', '2022-07-21 06:22:29');
INSERT INTO `audittrail` VALUES ('765', '1', 'Transno.: T000000005  Date:  7/18/2022  From: WHS11  To:  WHS9', 'Update Stock Transfer', '2022-07-21', '2:24:14 PM', '2022-07-21 06:23:50');
INSERT INTO `audittrail` VALUES ('766', '1', 'Login', 'Login', '2022-07-21', '2:26:21 PM', '2022-07-21 06:25:57');
INSERT INTO `audittrail` VALUES ('767', '1', 'Login', 'Login', '2022-07-21', '2:47:45 PM', '2022-07-21 06:47:21');
INSERT INTO `audittrail` VALUES ('768', '1', 'Transno.: T000000005  Date:  7/18/2022  From: WHS11  To:  WHS9', 'Update Stock Transfer', '2022-07-21', '2:48:07 PM', '2022-07-21 06:47:43');
INSERT INTO `audittrail` VALUES ('769', '1', 'Login', 'Login', '2022-07-21', '3:01:27 PM', '2022-07-21 07:01:03');
INSERT INTO `audittrail` VALUES ('770', '1', 'Transno.: T000000005  Date:  7/18/2022  From: WHS11  To:  WHS9', 'Update Stock Transfer', '2022-07-21', '3:02:15 PM', '2022-07-21 07:01:51');
INSERT INTO `audittrail` VALUES ('771', '1', 'Login', 'Login', '2022-07-21', '3:08:41 PM', '2022-07-21 07:08:17');
INSERT INTO `audittrail` VALUES ('772', '1', 'Login', 'Login', '2022-07-21', '4:17:53 PM', '2022-07-21 08:17:29');
INSERT INTO `audittrail` VALUES ('773', '1', 'Login', 'Login', '2022-07-21', '4:19:43 PM', '2022-07-21 08:19:19');
INSERT INTO `audittrail` VALUES ('774', '1', 'Login', 'Login', '2022-07-22', '10:02:33 AM', '2022-07-22 02:02:09');
INSERT INTO `audittrail` VALUES ('775', '1', 'Transno.: T000000004  Date:  7/18/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-22', '10:04:53 AM', '2022-07-22 02:04:29');
INSERT INTO `audittrail` VALUES ('776', '1', 'Transno.:   Date:   7/22/2022  From:  YLK  To:  WHS9', 'Add New Stock Transfer', '2022-07-22', '10:20:30 AM', '2022-07-22 02:20:06');
INSERT INTO `audittrail` VALUES ('777', '1', 'Transno.: T000000009  Date:  7/22/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-22', '10:21:31 AM', '2022-07-22 02:21:07');
INSERT INTO `audittrail` VALUES ('778', '1', 'Login', 'Login', '2022-07-22', '10:32:27 AM', '2022-07-22 02:32:03');
INSERT INTO `audittrail` VALUES ('779', '1', 'Transno.:   Date:   7/22/2022  From:  YLK  To:  WHS9', 'Add New Stock Transfer', '2022-07-22', '10:33:10 AM', '2022-07-22 02:32:46');
INSERT INTO `audittrail` VALUES ('780', '1', 'Login', 'Login', '2022-07-22', '10:36:19 AM', '2022-07-22 02:35:55');
INSERT INTO `audittrail` VALUES ('781', '1', 'Transno.: T000000010  Date:  7/22/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-22', '10:37:40 AM', '2022-07-22 02:37:16');
INSERT INTO `audittrail` VALUES ('782', '1', 'Logout', 'Logout', '2022-07-22', '11:29:38 AM', '2022-07-22 03:29:14');
INSERT INTO `audittrail` VALUES ('783', '1', 'Login', 'Login', '2022-07-22', '1:42:55 PM', '2022-07-22 05:42:31');
INSERT INTO `audittrail` VALUES ('784', '1', 'Transno.: T000000010  Date:  7/22/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-22', '1:45:05 PM', '2022-07-22 05:44:41');
INSERT INTO `audittrail` VALUES ('785', '1', 'Transno.: T000000009  Date:  7/22/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-22', '1:46:47 PM', '2022-07-22 05:46:23');
INSERT INTO `audittrail` VALUES ('786', '1', 'Login', 'Login', '2022-07-22', '2:06:56 PM', '2022-07-22 06:06:32');
INSERT INTO `audittrail` VALUES ('787', '1', 'Transno.: T000000002  Date:  7/18/2022  From: YLK  To:  WHS21', 'Update Stock Transfer', '2022-07-22', '2:08:57 PM', '2022-07-22 06:08:33');
INSERT INTO `audittrail` VALUES ('788', '1', 'Login', 'Login', '2022-07-22', '3:58:10 PM', '2022-07-22 07:57:46');
INSERT INTO `audittrail` VALUES ('789', '1', 'Login', 'Login', '2022-07-22', '4:03:44 PM', '2022-07-22 08:03:20');
INSERT INTO `audittrail` VALUES ('790', '1', 'Transno.: T000000010  Date:  7/22/2022  From: YLK  To:  WHS9', 'Update Stock Transfer', '2022-07-22', '4:06:03 PM', '2022-07-22 08:05:39');
INSERT INTO `audittrail` VALUES ('791', '1', 'Login', 'Login', '2022-07-22', '4:14:18 PM', '2022-07-22 08:13:54');
INSERT INTO `audittrail` VALUES ('792', '1', 'Login', 'Login', '2022-07-22', '4:38:00 PM', '2022-07-22 08:37:36');
INSERT INTO `audittrail` VALUES ('793', '1', 'Trans No.:   Date:  7/22/2022  Warehouse: WHS17  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-22', '4:47:17 PM', '2022-07-22 08:46:53');
INSERT INTO `audittrail` VALUES ('794', '1', 'Whs code.: WHS23  Warehouse name: WAREHOUSE 23', 'Add New Warehouse', '2022-07-22', '4:50:26 PM', '2022-07-22 08:50:02');
INSERT INTO `audittrail` VALUES ('795', '1', 'Transno.:   Date:   7/22/2022  From:  WHS17  To:  WHS23', 'Add New Stock Transfer', '2022-07-22', '4:56:17 PM', '2022-07-22 08:55:53');
INSERT INTO `audittrail` VALUES ('796', '1', 'Transno.: T000000011  Date:  7/22/2022  From: WHS17  To:  WHS23', 'Update Stock Transfer', '2022-07-22', '5:03:10 PM', '2022-07-22 09:02:46');
INSERT INTO `audittrail` VALUES ('797', '1', 'Logout', 'Logout', '2022-07-22', '5:03:34 PM', '2022-07-22 09:03:10');
INSERT INTO `audittrail` VALUES ('798', '1', 'Login', 'Login', '2022-07-23', '9:15:03 AM', '2022-07-23 01:14:39');
INSERT INTO `audittrail` VALUES ('799', '1', 'Login', 'Login', '2022-07-23', '9:27:09 AM', '2022-07-23 01:26:45');
INSERT INTO `audittrail` VALUES ('800', '1', 'Login', 'Login', '2022-07-23', '9:46:37 AM', '2022-07-23 01:46:13');
INSERT INTO `audittrail` VALUES ('801', '1', 'Login', 'Login', '2022-07-26', '3:24:03 PM', '2022-07-26 07:23:39');
INSERT INTO `audittrail` VALUES ('802', '1', 'Code.: W52  Description: WINGS POWDER DETERGENT 52GX150\'S  Supplier: GSPI  Category: PD', 'Update Item', '2022-07-26', '3:24:16 PM', '2022-07-26 07:23:52');
INSERT INTO `audittrail` VALUES ('803', '1', 'Code.: W52  Description: WINGS POWDER DETERGENT 52GX150\'S  Supplier: GSPI  Category: PD', 'Update Item', '2022-07-26', '3:24:28 PM', '2022-07-26 07:24:04');
INSERT INTO `audittrail` VALUES ('804', '1', 'Login', 'Login', '2022-07-27', '10:09:35 AM', '2022-07-27 02:09:11');
INSERT INTO `audittrail` VALUES ('805', '1', 'Code.: GS  Supplier name: GLOBAL SOURCE  Address:  CEBU CITY', 'Add New Supplier', '2022-07-27', '10:10:17 AM', '2022-07-27 02:09:53');
INSERT INTO `audittrail` VALUES ('806', '1', 'Code.: LMC  Supplier name: LIMKITKAI MANUFACTURING  Address:  CAGAYAN DE ORO', 'Add New Supplier', '2022-07-27', '10:11:00 AM', '2022-07-27 02:10:36');
INSERT INTO `audittrail` VALUES ('807', '1', 'Code.: MON  Supplier name: MONTOSCO  Address:  MANILA', 'Add New Supplier', '2022-07-27', '10:12:10 AM', '2022-07-27 02:11:46');
INSERT INTO `audittrail` VALUES ('808', '1', 'Code.: SL  Supplier name: SEANLUC INC  Address:  MANILA', 'Add New Supplier', '2022-07-27', '10:12:55 AM', '2022-07-27 02:12:31');
INSERT INTO `audittrail` VALUES ('809', '1', 'Code.: RG  Supplier name: REGENT CORP.  Address:  MANILA', 'Add New Supplier', '2022-07-27', '10:13:08 AM', '2022-07-27 02:12:44');
INSERT INTO `audittrail` VALUES ('810', '1', 'Code.: GSPI  Supplier name: ALSDK  Address:  ', 'Update Supplier', '2022-07-27', '10:13:21 AM', '2022-07-27 02:12:57');
INSERT INTO `audittrail` VALUES ('811', '1', 'Code.: GSPI  Supplier name: GENTLE SUPPREME PHILS.  Address:  MAKATI CITY', 'Update Supplier', '2022-07-27', '10:13:48 AM', '2022-07-27 02:13:24');
INSERT INTO `audittrail` VALUES ('812', '1', 'Login', 'Login', '2022-07-27', '10:16:28 AM', '2022-07-27 02:16:04');
INSERT INTO `audittrail` VALUES ('813', '1', 'Code.: LMC  Supplier name: LIMKETKAI MANUFACTURING  Address:  CAGAYAN DE ORO', 'Update Supplier', '2022-07-27', '10:17:06 AM', '2022-07-27 02:16:42');
INSERT INTO `audittrail` VALUES ('814', '1', 'Login', 'Login', '2022-07-27', '10:18:27 AM', '2022-07-27 02:18:03');
INSERT INTO `audittrail` VALUES ('815', '1', 'Login', 'Login', '2022-07-27', '10:19:41 AM', '2022-07-27 02:19:17');
INSERT INTO `audittrail` VALUES ('816', '1', 'Login', 'Login', '2022-07-27', '10:21:01 AM', '2022-07-27 02:20:37');
INSERT INTO `audittrail` VALUES ('817', '1', 'Login', 'Login', '2022-07-27', '10:21:45 AM', '2022-07-27 02:21:21');
INSERT INTO `audittrail` VALUES ('818', '1', 'Login', 'Login', '2022-07-27', '10:22:51 AM', '2022-07-27 02:22:27');
INSERT INTO `audittrail` VALUES ('819', '1', 'Login', 'Login', '2022-07-27', '10:23:26 AM', '2022-07-27 02:23:02');
INSERT INTO `audittrail` VALUES ('820', '1', 'Login', 'Login', '2022-07-27', '10:23:51 AM', '2022-07-27 02:23:27');
INSERT INTO `audittrail` VALUES ('821', '1', 'Code.: PO  Category name: PALM OIL', 'Add Category', '2022-07-27', '10:25:59 AM', '2022-07-27 02:25:35');
INSERT INTO `audittrail` VALUES ('822', '1', 'Code.: MG  Category name: MASTER GULAMAN', 'Add Category', '2022-07-27', '10:26:49 AM', '2022-07-27 02:26:25');
INSERT INTO `audittrail` VALUES ('823', '1', 'Code.: RPP  Category name: REGENT PISO PACK', 'Add Category', '2022-07-27', '10:27:35 AM', '2022-07-27 02:27:11');
INSERT INTO `audittrail` VALUES ('824', '1', 'Code.: DC  Category name: DAIRY CHAMP CONDENSE MILK', 'Add Category', '2022-07-27', '10:28:08 AM', '2022-07-27 02:27:44');
INSERT INTO `audittrail` VALUES ('825', '1', 'Code.: JW  Category name: JOHNNIE WALKER', 'Add Category', '2022-07-27', '10:29:33 AM', '2022-07-27 02:29:09');
INSERT INTO `audittrail` VALUES ('826', '1', 'Code.: AL  Category name: ALFONSO LIGHT', 'Add Category', '2022-07-27', '10:29:50 AM', '2022-07-27 02:29:26');
INSERT INTO `audittrail` VALUES ('827', '1', 'Code.: DC3  Description: DAIRY CHAMP CONDENSE 390MLX24  Supplier: GS  Category: DC', 'Add New Item', '2022-07-27', '10:36:49 AM', '2022-07-27 02:36:25');
INSERT INTO `audittrail` VALUES ('828', '1', 'Code.: DC1  Description: DAIRY CHAMP CONDENSED 1KGX24  Supplier: GS  Category: DC', 'Add New Item', '2022-07-27', '10:38:19 AM', '2022-07-27 02:37:55');
INSERT INTO `audittrail` VALUES ('829', '1', 'Code.: GSPI  Supplier name: GENTLE SUPPREME PHILS.  Address:  MANILA ', 'Update Supplier', '2022-07-27', '10:41:03 AM', '2022-07-27 02:40:39');
INSERT INTO `audittrail` VALUES ('830', '1', 'Code.: GS  Supplier name: GLOBAL SOURCE  Address:  CEBU CITY', 'Update Supplier', '2022-07-27', '10:41:08 AM', '2022-07-27 02:40:44');
INSERT INTO `audittrail` VALUES ('831', '1', 'Code.: DC3  Description: DAIRY CHAMP CONDENSE 390MLX24  Supplier: DM  Category: DC', 'Update Item', '2022-07-27', '10:42:45 AM', '2022-07-27 02:42:21');
INSERT INTO `audittrail` VALUES ('832', '1', 'Code.: DC1  Description: DAIRY CHAMP CONDENSED 1KGX24  Supplier: DM  Category: DC', 'Add New Item', '2022-07-27', '10:44:17 AM', '2022-07-27 02:43:53');
INSERT INTO `audittrail` VALUES ('833', '1', 'Login', 'Login', '2022-07-27', '2:47:31 PM', '2022-07-27 06:47:07');
INSERT INTO `audittrail` VALUES ('834', '1', 'Trans No.:   Date:  7/27/2022  Warehouse: WHS15  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-27', '3:01:49 PM', '2022-07-27 07:01:25');
INSERT INTO `audittrail` VALUES ('835', '1', 'Trans No.: O000000008  Date:   7/27/2022Warehouse: WAREHOUSE 15', 'Delete Misc. Stock Out', '2022-07-27', '3:02:24 PM', '2022-07-27 07:02:00');
INSERT INTO `audittrail` VALUES ('836', '1', 'Trans No.:   Date:  7/27/2022  Warehouse: WHS15  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-27', '3:07:24 PM', '2022-07-27 07:07:00');
INSERT INTO `audittrail` VALUES ('837', '1', 'Login', 'Login', '2022-07-27', '3:17:14 PM', '2022-07-27 07:16:50');
INSERT INTO `audittrail` VALUES ('838', '1', 'Trans No.: O000000009  Date:   7/27/2022Warehouse: WAREHOUSE 15', 'Delete Misc. Stock Out', '2022-07-27', '3:17:20 PM', '2022-07-27 07:16:56');
INSERT INTO `audittrail` VALUES ('839', '1', 'Login', 'Login', '2022-07-27', '3:24:11 PM', '2022-07-27 07:23:47');
INSERT INTO `audittrail` VALUES ('840', '1', 'Trans No.:   Date:  7/27/2022  Warehouse: WHS15  Supplier: GSPI', 'Add Misc. Stock Out', '2022-07-27', '3:25:28 PM', '2022-07-27 07:25:04');
INSERT INTO `audittrail` VALUES ('841', '1', 'Trans No.: O000000010  Date:   7/27/2022Warehouse: WAREHOUSE 15', 'Delete Misc. Stock Out', '2022-07-27', '3:46:03 PM', '2022-07-27 07:45:39');
INSERT INTO `audittrail` VALUES ('842', '1', 'Login', 'Login', '2022-07-27', '4:18:26 PM', '2022-07-27 08:18:02');
INSERT INTO `audittrail` VALUES ('843', '1', 'Login', 'Login', '2022-07-27', '4:22:30 PM', '2022-07-27 08:22:06');
INSERT INTO `audittrail` VALUES ('844', '1', 'Logout', 'Logout', '2022-07-27', '4:29:47 PM', '2022-07-27 08:29:23');
INSERT INTO `audittrail` VALUES ('845', '1', 'Login', 'Login', '2022-07-28', '3:07:07 PM', '2022-07-28 07:06:43');
INSERT INTO `audittrail` VALUES ('846', '1', 'Login', 'Login', '2022-07-28', '3:13:18 PM', '2022-07-28 07:12:54');
INSERT INTO `audittrail` VALUES ('847', '1', 'Login', 'Login', '2022-07-28', '3:24:32 PM', '2022-07-28 07:24:08');
INSERT INTO `audittrail` VALUES ('848', '1', 'Login', 'Login', '2022-08-02', '9:54:49 AM', '2022-08-02 01:54:25');
INSERT INTO `audittrail` VALUES ('849', '1', 'Login', 'Login', '2022-08-02', '10:48:55 AM', '2022-08-02 02:48:31');
INSERT INTO `audittrail` VALUES ('850', '1', 'Login', 'Login', '2022-08-02', '10:51:53 AM', '2022-08-02 02:51:29');
INSERT INTO `audittrail` VALUES ('851', '1', 'Login', 'Login', '2022-08-02', '11:36:34 AM', '2022-08-02 03:36:10');
INSERT INTO `audittrail` VALUES ('852', '1', 'Login', 'Login', '2022-08-02', '2:22:34 PM', '2022-08-02 06:22:10');
INSERT INTO `audittrail` VALUES ('853', '1', 'Trans No.:   Date:  8/2/2022  Warehouse: WHS15  Supplier: GSPI', 'Add Misc. Stock Out', '2022-08-02', '2:23:39 PM', '2022-08-02 06:23:15');
INSERT INTO `audittrail` VALUES ('854', '1', 'Trans No.: O000000011  Date:   8/2/2022Warehouse: WAREHOUSE 15', 'Delete Misc. Stock Out', '2022-08-02', '2:24:27 PM', '2022-08-02 06:24:03');
INSERT INTO `audittrail` VALUES ('855', '1', 'Trans No.:   Date:  8/2/2022  Warehouse: WHS15  Supplier: GSPI', 'Add Misc. Stock Out', '2022-08-02', '2:24:55 PM', '2022-08-02 06:24:31');
INSERT INTO `audittrail` VALUES ('856', '1', 'Login', 'Login', '2022-08-03', '10:31:10 AM', '2022-08-03 02:30:46');
INSERT INTO `audittrail` VALUES ('857', '1', 'Login', 'Login', '2022-08-03', '10:32:33 AM', '2022-08-03 02:32:09');
INSERT INTO `audittrail` VALUES ('858', '1', 'Trans No.: R000000017  PO. No.: 10000000000000R  Invoice No.:  10000000000000R  Supplier: GSPI', 'Update Receiving', '2022-08-03', '10:33:06 AM', '2022-08-03 02:32:42');
INSERT INTO `audittrail` VALUES ('859', '1', 'Trans No.: R000000018  PO. No.: A  Invoice No.:  A  Supplier: GSPI', 'Add Receiving', '2022-08-03', '11:13:13 AM', '2022-08-03 03:12:49');
INSERT INTO `audittrail` VALUES ('860', '1', 'Trans No.: R000000018  PO. No.: 10000000000000S  Invoice No.:  10000000000000S  Supplier: GSPI', 'Update Receiving', '2022-08-03', '11:13:38 AM', '2022-08-03 03:13:14');
INSERT INTO `audittrail` VALUES ('861', '1', 'Trans No.: R000000018  PO. No.: 10000000000000S  Invoice No.:  10000000000000S  Supplier: GSPI', 'Update Receiving', '2022-08-03', '11:24:19 AM', '2022-08-03 03:23:55');
INSERT INTO `audittrail` VALUES ('862', '1', 'Trans No.: R000000019  PO. No.:   Invoice No.:  ASDF  Supplier: GSPI', 'Add Receiving', '2022-08-03', '11:25:10 AM', '2022-08-03 03:24:46');
INSERT INTO `audittrail` VALUES ('863', '1', 'Trans No.: R000000019  PO. No.: 10000000000000T  Invoice No.:  10000000000000T  Supplier: GSPI', 'Update Receiving', '2022-08-03', '11:26:08 AM', '2022-08-03 03:25:44');
INSERT INTO `audittrail` VALUES ('864', '1', 'Login', 'Login', '2022-08-03', '11:29:00 AM', '2022-08-03 03:28:36');
INSERT INTO `audittrail` VALUES ('865', 'toping', 'Login', 'Login', '2022-08-03', '3:54:41 PM', '2022-08-03 07:54:17');
INSERT INTO `audittrail` VALUES ('866', 'toping', 'Logout', 'Logout', '2022-08-03', '4:03:17 PM', '2022-08-03 08:02:53');
INSERT INTO `audittrail` VALUES ('867', '1', 'Login', 'Login', '2022-08-03', '4:03:19 PM', '2022-08-03 08:02:55');
INSERT INTO `audittrail` VALUES ('868', '1', 'Trans No.: R000000019  PO. No.: 10000000000000T  Invoice No.:  10000000000000T  Supplier: GSPI', 'Update Receiving', '2022-08-03', '4:05:35 PM', '2022-08-03 08:05:11');
INSERT INTO `audittrail` VALUES ('869', '1', 'Trans No.: R000000019  PO. No.: 10000000000000T  Invoice No.:  10000000000000T  Supplier: GSPI', 'Update Receiving', '2022-08-03', '4:07:22 PM', '2022-08-03 08:06:58');
INSERT INTO `audittrail` VALUES ('870', '1', 'Trans No.: R000000019  PO. No.: 10000000000000T  Invoice No.:  10000000000000T  Supplier: GSPI', 'Update Receiving', '2022-08-03', '4:11:50 PM', '2022-08-03 08:11:26');
INSERT INTO `audittrail` VALUES ('871', '1', 'Login', 'Login', '2022-08-03', '4:16:27 PM', '2022-08-03 08:16:03');
INSERT INTO `audittrail` VALUES ('872', '1', 'Login', 'Login', '2022-08-03', '4:20:27 PM', '2022-08-03 08:20:03');
INSERT INTO `audittrail` VALUES ('873', '1', 'Login', 'Login', '2022-08-03', '4:21:10 PM', '2022-08-03 08:20:46');
INSERT INTO `audittrail` VALUES ('874', '1', 'Login', 'Login', '2022-08-03', '4:22:19 PM', '2022-08-03 08:21:55');
INSERT INTO `audittrail` VALUES ('875', '1', 'Login', 'Login', '2022-08-03', '4:31:06 PM', '2022-08-03 08:30:42');
INSERT INTO `audittrail` VALUES ('876', '1', 'Login', 'Login', '2022-08-03', '4:32:41 PM', '2022-08-03 08:32:17');
INSERT INTO `audittrail` VALUES ('877', '1', 'Login', 'Login', '2022-08-03', '4:33:53 PM', '2022-08-03 08:33:29');
INSERT INTO `audittrail` VALUES ('878', '1', 'Login', 'Login', '2022-08-04', '9:11:44 AM', '2022-08-04 01:11:20');
INSERT INTO `audittrail` VALUES ('879', '1', 'Transno.: T000000011  Date:  7/22/2022  From: WHS17  To:  WHS23', 'Update Stock Transfer', '2022-08-04', '10:55:37 AM', '2022-08-04 02:55:13');
INSERT INTO `audittrail` VALUES ('880', '1', 'Logout', 'Logout', '2022-08-04', '11:45:16 AM', '2022-08-04 03:44:52');
INSERT INTO `audittrail` VALUES ('881', '1', 'Login', 'Login', '2022-08-04', '2:32:19 PM', '2022-08-04 06:31:55');
INSERT INTO `audittrail` VALUES ('882', '1', 'Code.: TW10S  New code.: TW10\'S  Description: TOP CAFE WHITE 30G 10\'S (36 STRNGS)  Supplier: GSPI  Category: TC', 'Change Item Code', '2022-08-04', '2:32:31 PM', '2022-08-04 06:32:07');
INSERT INTO `audittrail` VALUES ('883', '1', 'Code.: TBR10S  New code.: TBR10\'S  Description: TOP CAFE BROWN 25G 10\'S (36 STRNGS)  Supplier: GSPI  Category: TC', 'Change Item Code', '2022-08-04', '2:32:55 PM', '2022-08-04 06:32:31');
INSERT INTO `audittrail` VALUES ('884', '1', 'Code.: TBD10S  New code.: TBD10\'S  Description: TOP CAFE BREWED 22G 10\'S (36 STRNGS)  Supplier: GSPI  Category: TC', 'Change Item Code', '2022-08-04', '2:33:21 PM', '2022-08-04 06:32:57');
INSERT INTO `audittrail` VALUES ('885', '1', 'Logout', 'Logout', '2022-08-04', '3:01:00 PM', '2022-08-04 07:00:36');
INSERT INTO `audittrail` VALUES ('886', '1', 'Login', 'Login', '2022-09-03', '2:10:53 PM', '2022-09-03 06:10:29');
INSERT INTO `audittrail` VALUES ('887', '1', 'Login', 'Login', '2022-09-03', '2:35:42 PM', '2022-09-03 06:35:18');
INSERT INTO `audittrail` VALUES ('888', '1', 'Login', 'Login', '2022-09-03', '2:39:23 PM', '2022-09-03 06:38:59');
INSERT INTO `audittrail` VALUES ('889', '1', 'Login', 'Login', '2022-09-03', '4:18:40 PM', '2022-09-03 08:18:16');
INSERT INTO `audittrail` VALUES ('890', '1', 'Login', 'Login', '2022-09-03', '4:27:54 PM', '2022-09-03 08:27:30');
INSERT INTO `audittrail` VALUES ('891', '1', 'Login', 'Login', '2022-09-03', '4:31:32 PM', '2022-09-03 08:31:08');
INSERT INTO `audittrail` VALUES ('892', '1', 'Login', 'Login', '2022-09-03', '4:32:43 PM', '2022-09-03 08:32:19');
INSERT INTO `audittrail` VALUES ('893', '1', 'Login', 'Login', '2022-09-03', '4:33:56 PM', '2022-09-03 08:33:32');
INSERT INTO `audittrail` VALUES ('894', '1', 'Login', 'Login', '2022-09-03', '4:38:43 PM', '2022-09-03 08:38:19');
INSERT INTO `audittrail` VALUES ('895', '1', 'Logout', 'Logout', '2022-09-03', '4:41:21 PM', '2022-09-03 08:40:57');
INSERT INTO `audittrail` VALUES ('896', '1', 'Login', 'Login', '2022-09-03', '9:38:51 PM', '2022-09-03 13:38:27');
INSERT INTO `audittrail` VALUES ('897', '1', 'Login', 'Login', '2022-09-03', '9:44:37 PM', '2022-09-03 13:44:13');
INSERT INTO `audittrail` VALUES ('898', '1', 'Login', 'Login', '2022-09-03', '10:00:29 PM', '2022-09-03 14:00:05');
INSERT INTO `audittrail` VALUES ('899', '1', 'Transno.:   Date:   9/3/2022  From:  YLK  To:  WHS1', 'Add New Stock Transfer', '2022-09-03', '10:01:46 PM', '2022-09-03 14:01:22');
INSERT INTO `audittrail` VALUES ('900', '1', 'Login', 'Login', '2022-09-03', '10:02:16 PM', '2022-09-03 14:01:52');
INSERT INTO `audittrail` VALUES ('901', '1', 'Login', 'Login', '2022-09-03', '10:04:33 PM', '2022-09-03 14:04:09');
INSERT INTO `audittrail` VALUES ('902', '1', 'Login', 'Login', '2022-09-03', '10:06:46 PM', '2022-09-03 14:06:22');
INSERT INTO `audittrail` VALUES ('903', '1', 'Login', 'Login', '2022-09-03', '10:09:04 PM', '2022-09-03 14:08:40');
INSERT INTO `audittrail` VALUES ('904', '1', 'Login', 'Login', '2022-09-03', '10:10:13 PM', '2022-09-03 14:09:49');
INSERT INTO `audittrail` VALUES ('905', '1', 'Login', 'Login', '2022-09-03', '10:17:15 PM', '2022-09-03 14:16:51');
INSERT INTO `audittrail` VALUES ('906', '1', 'Trans No.: R000000015  PO. No.: 10000000000000P  Invoice No.:  10000000000000P  Supplier: GSPI', 'Print Receiving', '2022-09-03', '10:17:51 PM', '2022-09-03 14:17:27');
INSERT INTO `audittrail` VALUES ('907', '1', 'Logout', 'Logout', '2022-09-03', '10:18:16 PM', '2022-09-03 14:17:52');
INSERT INTO `audittrail` VALUES ('908', '1', 'Login', 'Login', '2022-09-03', '10:19:48 PM', '2022-09-03 14:19:24');
INSERT INTO `audittrail` VALUES ('909', '1', 'Logout', 'Logout', '2022-09-03', '10:21:00 PM', '2022-09-03 14:20:36');
INSERT INTO `audittrail` VALUES ('910', '1', 'Login', 'Login', '2022-09-04', '8:16:36 AM', '2022-09-04 00:16:12');
INSERT INTO `audittrail` VALUES ('911', '1', 'Login', 'Login', '2022-09-04', '8:20:50 AM', '2022-09-04 00:20:26');
INSERT INTO `audittrail` VALUES ('912', '1', 'Login', 'Login', '2022-09-04', '8:22:07 AM', '2022-09-04 00:21:43');
INSERT INTO `audittrail` VALUES ('913', '1', 'Login', 'Login', '2022-09-04', '8:24:50 AM', '2022-09-04 00:24:26');
INSERT INTO `audittrail` VALUES ('914', '1', 'Login', 'Login', '2022-09-04', '8:43:20 AM', '2022-09-04 00:42:56');
INSERT INTO `audittrail` VALUES ('915', '1', 'Login', 'Login', '2022-09-04', '8:55:04 AM', '2022-09-04 00:54:40');
INSERT INTO `audittrail` VALUES ('916', '1', 'Login', 'Login', '2022-09-04', '9:16:42 AM', '2022-09-04 01:16:18');
INSERT INTO `audittrail` VALUES ('917', '1', 'Login', 'Login', '2022-09-04', '9:34:14 AM', '2022-09-04 01:33:50');
INSERT INTO `audittrail` VALUES ('918', '1', 'Login', 'Login', '2022-09-04', '9:35:00 AM', '2022-09-04 01:34:36');
INSERT INTO `audittrail` VALUES ('919', '1', 'Login', 'Login', '2022-09-04', '9:37:47 AM', '2022-09-04 01:37:23');
INSERT INTO `audittrail` VALUES ('920', '1', 'Login', 'Login', '2022-09-04', '9:48:05 AM', '2022-09-04 01:47:41');
INSERT INTO `audittrail` VALUES ('921', '1', 'Login', 'Login', '2022-09-04', '10:43:16 AM', '2022-09-04 02:42:52');
INSERT INTO `audittrail` VALUES ('922', '1', 'Login', 'Login', '2022-09-04', '10:44:38 AM', '2022-09-04 02:44:14');
INSERT INTO `audittrail` VALUES ('923', '1', 'Login', 'Login', '2022-09-04', '10:46:15 AM', '2022-09-04 02:45:51');
INSERT INTO `audittrail` VALUES ('924', '1', 'Login', 'Login', '2022-09-04', '10:50:00 AM', '2022-09-04 02:49:36');
INSERT INTO `audittrail` VALUES ('925', '1', 'Login', 'Login', '2022-09-04', '10:52:14 AM', '2022-09-04 02:51:50');
INSERT INTO `audittrail` VALUES ('926', '1', 'Login', 'Login', '2022-09-04', '10:57:01 AM', '2022-09-04 02:56:37');
INSERT INTO `audittrail` VALUES ('927', '1', 'Logout', 'Logout', '2022-09-04', '10:57:24 AM', '2022-09-04 02:57:00');

-- ----------------------------
-- Table structure for brand
-- ----------------------------
DROP TABLE IF EXISTS `brand`;
CREATE TABLE `brand` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `brcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `brandname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`brcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of brand
-- ----------------------------
INSERT INTO `brand` VALUES ('1', 'BR1', 'BRAND NAME 1', null, '2020-08-19 21:15:43');
INSERT INTO `brand` VALUES ('2', 'BR2', 'BRAND NAME 2', null, '2020-08-19 21:15:54');
INSERT INTO `brand` VALUES ('3', 'BR3', 'BRAND NAME 3', null, '2020-08-19 21:16:01');
INSERT INTO `brand` VALUES ('4', 'BR4', 'BRAND NAME 4', null, '2020-08-19 21:33:47');
INSERT INTO `brand` VALUES ('6', 'BR5', 'BRAND NAME 5', null, '2020-08-20 20:33:27');
INSERT INTO `brand` VALUES ('7', 'BR6', 'BRAND NAME 6', null, '2020-08-20 20:33:43');
INSERT INTO `brand` VALUES ('8', 'BR7', 'BRAND NAME 7', null, '2020-08-20 20:34:06');
INSERT INTO `brand` VALUES ('9', 'BR8', 'BRAND NAME 8', null, '2020-08-20 20:34:17');
INSERT INTO `brand` VALUES ('10', 'BR9', 'BRAND NAME 9', null, '2020-08-20 20:34:50');
INSERT INTO `brand` VALUES ('11', 'BR10', 'BRAND NAME 10', null, '2021-04-10 06:36:08');

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `catcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `categoryname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`catcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES ('1', 'HF', 'HOG FEED', '0', '2021-09-26 08:38:36');
INSERT INTO `category` VALUES ('2', 'CF', 'CHICKEN FEED', '0', '2021-09-26 08:53:05');
INSERT INTO `category` VALUES ('3', 'DF', 'DUCK FEED', '0', '2021-09-26 08:53:50');
INSERT INTO `category` VALUES ('4', 'LSV', 'LIVE STOCK VITAMINS', '0', '2021-09-26 12:38:37');
INSERT INTO `category` VALUES ('5', 'LSA', 'LIVE STOCK ANTIBIOTICS', '0', '2021-09-26 12:39:07');
INSERT INTO `category` VALUES ('6', 'FA', 'FEED ADDITIVE', '0', '2021-09-26 12:39:30');
INSERT INTO `category` VALUES ('8', 'LSS', 'LIVE STOCK STIMULANT', '0', '2021-09-26 23:54:17');
INSERT INTO `category` VALUES ('9', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', '0', '2021-09-27 00:05:43');
INSERT INTO `category` VALUES ('10', 'LSFBM', 'LIVE STOCK FEED BASE MIX', '0', '2021-09-27 00:06:16');
INSERT INTO `category` VALUES ('11', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', '0', '2021-09-27 00:25:17');
INSERT INTO `category` VALUES ('12', 'PI', 'PESTICIDE AND INSECTICIDE', '0', '2021-09-27 00:26:12');
INSERT INTO `category` VALUES ('13', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', '0', '2021-09-27 00:45:51');
INSERT INTO `category` VALUES ('14', 'FRM', 'FEED RAW MAATERIAL ', '0', '2021-10-08 11:09:05');
INSERT INTO `category` VALUES ('15', 'FF', 'FISH FEED', '0', '2021-10-25 12:59:29');
INSERT INTO `category` VALUES ('16', 'LF ', 'LAYER FEED', '0', '2021-10-25 13:34:40');
INSERT INTO `category` VALUES ('17', 'BF', 'BROILER FEED', '0', '2021-10-25 13:34:51');
INSERT INTO `category` VALUES ('18', 'CS', 'CORN SEED', '0', '2021-10-27 01:30:15');
INSERT INTO `category` VALUES ('20', 'DI', 'DISINFECTANT', '0', '2021-10-27 02:57:33');
INSERT INTO `category` VALUES ('22', 'PD', 'POWDER DETERGENT', '0', '2022-03-02 08:03:37');
INSERT INTO `category` VALUES ('23', 'MD', 'MISEDAAP NODLES', '0', '2022-03-12 14:51:20');
INSERT INTO `category` VALUES ('24', 'TC', 'TOP CAFE', '0', '2022-03-12 14:51:45');
INSERT INTO `category` VALUES ('25', 'GIV', 'GIV BEAUTY SOAP', '0', '2022-03-18 02:23:37');
INSERT INTO `category` VALUES ('26', 'BAR', 'BAR DETERGENT', '0', '2022-03-19 02:52:17');
INSERT INTO `category` VALUES ('27', 'PO', 'PALM OIL', '0', '2022-07-27 02:25:35');
INSERT INTO `category` VALUES ('28', 'MG', 'MASTER GULAMAN', '0', '2022-07-27 02:26:25');
INSERT INTO `category` VALUES ('29', 'RPP', 'REGENT PISO PACK', '0', '2022-07-27 02:27:11');
INSERT INTO `category` VALUES ('30', 'DC', 'DAIRY CHAMP CONDENSE MILK', '0', '2022-07-27 02:27:44');
INSERT INTO `category` VALUES ('31', 'JW', 'JOHNNIE WALKER', '0', '2022-07-27 02:29:09');
INSERT INTO `category` VALUES ('32', 'AL', 'ALFONSO LIGHT', '0', '2022-07-27 02:29:26');

-- ----------------------------
-- Table structure for category_old
-- ----------------------------
DROP TABLE IF EXISTS `category_old`;
CREATE TABLE `category_old` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `catcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `categoryname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`catcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of category_old
-- ----------------------------
INSERT INTO `category_old` VALUES ('1', 'HF', 'HOG FEED', '0', '2021-09-26 08:38:36');
INSERT INTO `category_old` VALUES ('2', 'CF', 'CHICKEN FEED', '0', '2021-09-26 08:53:05');
INSERT INTO `category_old` VALUES ('3', 'DF', 'DUCK FEED', '0', '2021-09-26 08:53:50');
INSERT INTO `category_old` VALUES ('4', 'LSV', 'LIVE STOCK VITAMINS', '0', '2021-09-26 12:38:37');
INSERT INTO `category_old` VALUES ('5', 'LSA', 'LIVE STOCK ANTIBIOTICS', '0', '2021-09-26 12:39:07');
INSERT INTO `category_old` VALUES ('6', 'FA', 'FEED ADDITIVE', '0', '2021-09-26 12:39:30');
INSERT INTO `category_old` VALUES ('8', 'LSS', 'LIVE STOCK STIMULANT', '0', '2021-09-26 23:54:17');
INSERT INTO `category_old` VALUES ('9', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', '0', '2021-09-27 00:05:43');
INSERT INTO `category_old` VALUES ('10', 'LSFBM', 'LIVE STOCK FEED BASE MIX', '0', '2021-09-27 00:06:16');
INSERT INTO `category_old` VALUES ('11', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', '0', '2021-09-27 00:25:17');
INSERT INTO `category_old` VALUES ('12', 'PI', 'PESTICIDE AND INSECTICIDE', '0', '2021-09-27 00:26:12');
INSERT INTO `category_old` VALUES ('13', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', '0', '2021-09-27 00:45:51');

-- ----------------------------
-- Table structure for ccatdb
-- ----------------------------
DROP TABLE IF EXISTS `ccatdb`;
CREATE TABLE `ccatdb` (
  `pkno` int(5) NOT NULL AUTO_INCREMENT,
  `CCATCODE` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `CCATNAME` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`CCATCODE`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ccatdb
-- ----------------------------
INSERT INTO `ccatdb` VALUES ('1', 'DRUG', 'DRUG STORE');
INSERT INTO `ccatdb` VALUES ('2', 'CON', 'CONVENIENT STORE');
INSERT INTO `ccatdb` VALUES ('3', 'DEPT', 'DEPARTMENT STORE');
INSERT INTO `ccatdb` VALUES ('4', 'SUPER', 'SUPERMARKET');
INSERT INTO `ccatdb` VALUES ('5', 'GRO', 'GROCERY');
INSERT INTO `ccatdb` VALUES ('6', 'SSS', 'SARI-SARI STORE');
INSERT INTO `ccatdb` VALUES ('7', 'WHOLE', 'WHOLESALER');
INSERT INTO `ccatdb` VALUES ('8', 'COOP', 'COOPERATIVE');
INSERT INTO `ccatdb` VALUES ('9', 'MKS', 'MARKET STALL');
INSERT INTO `ccatdb` VALUES ('10', 'RES', 'RESTAURANT');
INSERT INTO `ccatdb` VALUES ('11', 'INS', 'INSTITUTIONAL');
INSERT INTO `ccatdb` VALUES ('12', 'GS', 'GASOLINE STATION');

-- ----------------------------
-- Table structure for chaindb
-- ----------------------------
DROP TABLE IF EXISTS `chaindb`;
CREATE TABLE `chaindb` (
  `pkno` int(5) NOT NULL AUTO_INCREMENT,
  `CHAINCODE` varchar(7) CHARACTER SET utf8 DEFAULT NULL,
  `CHAINNAME` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`CHAINCODE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of chaindb
-- ----------------------------

-- ----------------------------
-- Table structure for check
-- ----------------------------
DROP TABLE IF EXISTS `check`;
CREATE TABLE `check` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `date` date DEFAULT NULL,
  `custcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `slmncode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `bank` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `checkno` varchar(11) CHARACTER SET utf8 DEFAULT NULL,
  `checkdate` date DEFAULT NULL,
  `checkamt` decimal(15,2) DEFAULT NULL,
  `terms` decimal(15,2) DEFAULT NULL,
  `bouncef` tinyint(4) DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT NULL,
  `reason` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in2` (`transno`) USING BTREE,
  KEY `in1` (`custcode`,`date`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of check
-- ----------------------------

-- ----------------------------
-- Table structure for ck
-- ----------------------------
DROP TABLE IF EXISTS `ck`;
CREATE TABLE `ck` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `T_NO` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `T_TYP` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `DATE` date DEFAULT NULL,
  `CUSTCODE` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `SALEMNCD` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `CK_BANK` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `CK_NO` varchar(11) CHARACTER SET utf8 DEFAULT NULL,
  `CK_DT` date DEFAULT NULL,
  `CK_AMT` decimal(15,2) DEFAULT NULL,
  `TERMS` decimal(15,2) DEFAULT NULL,
  `BOUNCEF` tinyint(4) DEFAULT NULL,
  `APPLIED` decimal(15,2) DEFAULT NULL,
  `REASON` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in2` (`T_NO`) USING BTREE,
  KEY `in1` (`CUSTCODE`,`DATE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ck
-- ----------------------------

-- ----------------------------
-- Table structure for cmdm
-- ----------------------------
DROP TABLE IF EXISTS `cmdm`;
CREATE TABLE `cmdm` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL,
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `docno` varchar(10) DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `slmncode` varchar(10) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT '0.00',
  `balance` decimal(15,2) DEFAULT NULL,
  `remarks1` varchar(50) DEFAULT NULL,
  `remarks2` varchar(50) DEFAULT NULL,
  `remarks3` varchar(50) DEFAULT NULL,
  `remarks4` varchar(50) DEFAULT NULL,
  `user` varchar(50) DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of cmdm
-- ----------------------------
INSERT INTO `cmdm` VALUES ('1', 'C000000001', 'C', '2021-09-06', 'TEST1', '20200001', 'REN01', '2315.00', '2315.00', '0.00', 'ASDF', 'ASDF', 'ASDF', 'ASDF', null, '0', '2021-09-16 12:59:01');
INSERT INTO `cmdm` VALUES ('2', 'C000000002', 'C', '2021-09-06', 'TEST2', '20200002', 'REY01', '3426.00', '3426.00', '0.00', 'TEST1', 'TEST2', 'TEST3', 'TEST4', null, '0', '2021-09-16 12:59:01');
INSERT INTO `cmdm` VALUES ('3', 'C000000003', 'C', '2021-09-07', 'TEST3', '20200003', 'REN01', '500.00', '0.00', '500.00', 'REMARKS1', 'REMARKS2', 'REMARKS3', 'REMARKS4', null, '0', '2021-09-16 12:59:01');
INSERT INTO `cmdm` VALUES ('4', 'C000000004', 'C', '2021-09-08', 'TEST4', '20200008', 'REN01', '650.00', '0.00', '650.00', 'ADS', 'ASDF', 'ASDF', 'ASDF', null, '0', '2021-09-16 12:59:02');
INSERT INTO `cmdm` VALUES ('5', 'C000000005', 'C', '2021-09-08', 'TEST5', '20200009', 'REY01', '450.00', '0.00', '450.00', 'CVZXCV', 'ZXCVZXC', 'ZXVZXC', 'ZXVCZX', null, '0', '2021-09-16 12:59:02');
INSERT INTO `cmdm` VALUES ('6', 'C000000006', 'C', '2021-09-13', 'TEST6', '20200002', 'REN01', '585.00', '0.00', '585.00', 'ERER', 'ERE', 'ERER', 'ERER', null, '0', '2021-09-16 12:59:02');
INSERT INTO `cmdm` VALUES ('7', 'C000000007', 'C', '2021-09-13', 'TES1', '20200003', 'REY01', '898.00', '0.00', '898.00', 'ERE', 'READS', 'ASDF', 'ASDF', null, '0', '2021-09-16 12:59:02');
INSERT INTO `cmdm` VALUES ('8', 'C000000008', 'C', '2021-09-13', 'TEST7', '20200008', 'AT', '3432.00', '0.00', '3432.00', 'DFD', 'DF', '', '', null, '0', '2021-09-16 12:59:02');

-- ----------------------------
-- Table structure for cmdmc
-- ----------------------------
DROP TABLE IF EXISTS `cmdmc`;
CREATE TABLE `cmdmc` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `T_NO` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `T_TYP` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `DATE` date DEFAULT NULL,
  `CUSTCODE` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `SALEMNCD` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `DOCNO` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `TOTAMT` decimal(15,2) DEFAULT NULL,
  `APPLIED` decimal(15,2) DEFAULT NULL,
  `LPRINT` tinyint(4) DEFAULT NULL,
  `REMARK1` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK2` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK3` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK4` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK5` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK6` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK7` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  `REMARK8` varchar(60) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`CUSTCODE`,`DATE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cmdmc
-- ----------------------------

-- ----------------------------
-- Table structure for cmdmd
-- ----------------------------
DROP TABLE IF EXISTS `cmdmd`;
CREATE TABLE `cmdmd` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `tno` int(11) NOT NULL DEFAULT '0',
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `docno` varchar(10) DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `slsmancode` varchar(10) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `remarks1` varchar(30) DEFAULT NULL,
  `remarks2` varchar(30) DEFAULT NULL,
  `remarks3` varchar(30) DEFAULT NULL,
  `remarks4` varchar(30) DEFAULT NULL,
  `isdelete` tinyint(4) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`tno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of cmdmd
-- ----------------------------

-- ----------------------------
-- Table structure for cmdmh
-- ----------------------------
DROP TABLE IF EXISTS `cmdmh`;
CREATE TABLE `cmdmh` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `tno` int(11) NOT NULL DEFAULT '0',
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `docno` varchar(10) DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `slsmancode` varchar(10) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `balance` decimal(15,2) DEFAULT NULL,
  `isdelete` tinyint(4) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`tno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of cmdmh
-- ----------------------------

-- ----------------------------
-- Table structure for cnc
-- ----------------------------
DROP TABLE IF EXISTS `cnc`;
CREATE TABLE `cnc` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `T_NO` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `T_TYP` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `DATE` date DEFAULT NULL,
  `CUSTCODE` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `SALEMNCD` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `WHSE` varchar(3) CHARACTER SET utf8 DEFAULT NULL,
  `DOCNO` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `ITEM` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `QTY` int(11) DEFAULT NULL,
  `QUNIT` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `PCKG` int(11) DEFAULT NULL,
  `PRICE` decimal(15,2) DEFAULT NULL,
  `DISC_PCT` decimal(15,2) DEFAULT NULL,
  `BO_FD` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `COST` decimal(20,5) DEFAULT NULL,
  `LGUM` tinyint(4) DEFAULT NULL,
  `DISC_PCT1` int(11) DEFAULT NULL,
  `USRID` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`T_NO`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cnc
-- ----------------------------

-- ----------------------------
-- Table structure for cocensus
-- ----------------------------
DROP TABLE IF EXISTS `cocensus`;
CREATE TABLE `cocensus` (
  `PROVINCE` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `TOWN` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `POPULATION` int(11) DEFAULT NULL,
  `HOUSEHOLD` int(11) DEFAULT NULL,
  `REGION` varchar(2) CHARACTER SET utf8 DEFAULT NULL,
  `NSO_REGION` varchar(4) CHARACTER SET utf8 DEFAULT NULL,
  `AREACODE` varchar(10) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cocensus
-- ----------------------------

-- ----------------------------
-- Table structure for colld
-- ----------------------------
DROP TABLE IF EXISTS `colld`;
CREATE TABLE `colld` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `reftype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `refno` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `refamt` decimal(15,2) DEFAULT NULL,
  `refdate` date DEFAULT NULL,
  `refdoc` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`transno`),
  KEY `in2` (`refno`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of colld
-- ----------------------------

-- ----------------------------
-- Table structure for collh
-- ----------------------------
DROP TABLE IF EXISTS `collh`;
CREATE TABLE `collh` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(12) CHARACTER SET utf8 DEFAULT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `orno` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `date` date DEFAULT NULL,
  `custcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `slmncode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `totalamt` decimal(15,2) DEFAULT NULL,
  `totcode` decimal(15,2) DEFAULT NULL,
  `updated` tinyint(4) DEFAULT NULL,
  `lsummary` tinyint(4) DEFAULT NULL,
  `user` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `lconsign` tinyint(4) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`transno`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of collh
-- ----------------------------

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `custcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `custname` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `address` varchar(300) CHARACTER SET utf8 DEFAULT NULL,
  `shipto` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `areacode` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `areaname` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `outletcode` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `outlettype` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `provcode` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `province` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `maincode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `mainp` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `tinno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `mobileno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `telno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `payterms` varchar(3) CHARACTER SET utf8 DEFAULT NULL,
  `creditlimit` decimal(15,2) DEFAULT NULL,
  `spdiscount` int(10) DEFAULT NULL,
  `allowpd` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`custcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=193 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of customers
-- ----------------------------
INSERT INTO `customers` VALUES ('40', '20210026', 'AILEEN CANETE\'S', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-07-26 07:26:18');
INSERT INTO `customers` VALUES ('92', '20220002', 'ARCAYRA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:04:05');
INSERT INTO `customers` VALUES ('42', '20210028', 'BONIFACIO FARM', 'BONIFACIO', '', 'BON', 'BONIFACIO', 'FPI', 'FARM PIGGERY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-26 13:35:17');
INSERT INTO `customers` VALUES ('43', '20210029', 'ENGR. TATOY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:15:41');
INSERT INTO `customers` VALUES ('44', '20210030', 'BAGIO', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-26 13:34:58');
INSERT INTO `customers` VALUES ('45', '20210031', 'TABALBA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:16:53');
INSERT INTO `customers` VALUES ('46', '20210032', 'OMETEN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:17:33');
INSERT INTO `customers` VALUES ('47', '20210033', 'DESQITADO', 'DIPOLOG', '', '', 'TUDELA', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:18:34');
INSERT INTO `customers` VALUES ('48', '20210034', 'SENADOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:19:31');
INSERT INTO `customers` VALUES ('25', '20210011', 'DULA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:01:46');
INSERT INTO `customers` VALUES ('26', '20210012', 'JUN MAALAM', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:02:53');
INSERT INTO `customers` VALUES ('27', '20210013', 'CLIFFORD', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:03:34');
INSERT INTO `customers` VALUES ('28', '20210014', 'MEJORADA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:04:22');
INSERT INTO `customers` VALUES ('29', '20210015', 'SALIG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:05:24');
INSERT INTO `customers` VALUES ('30', '20210016', 'EDU', 'CLARIN\r\n\r\n', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:06:02');
INSERT INTO `customers` VALUES ('31', '20210017', 'DACKLESS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:06:46');
INSERT INTO `customers` VALUES ('32', '20210018', 'JIMBOY', 'OROQUIETA', '', 'ORO', 'OROQUIETA CITY', '', '', '', '', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:07:49');
INSERT INTO `customers` VALUES ('33', '20210019', 'TUBIGON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-26 13:32:05');
INSERT INTO `customers` VALUES ('34', '20210020', 'MANTUA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:09:04');
INSERT INTO `customers` VALUES ('35', '20210021', 'JUNNY SIAREZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:09:51');
INSERT INTO `customers` VALUES ('36', '20210022', 'FRANCISCO', '', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:10:29');
INSERT INTO `customers` VALUES ('37', '20210023', 'PRECY CARAMBA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:11:00');
INSERT INTO `customers` VALUES ('38', '20210024', 'LISEL BARRIENTOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:11:35');
INSERT INTO `customers` VALUES ('39', '20210025', 'KINTOY HERALDE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:12:14');
INSERT INTO `customers` VALUES ('23', '20210009', 'RAMIL DOKO', 'OZAMIZ CITY', 'RAMIL', 'OZA', 'OZAMIZ CITY', 'CON ', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-12 08:15:58');
INSERT INTO `customers` VALUES ('24', '20210010', 'IAN DELAPAZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', '', '', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:00:01');
INSERT INTO `customers` VALUES ('49', '20210035', 'LOMO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:20:18');
INSERT INTO `customers` VALUES ('50', '20210036', 'QIMBO', '', '', '', '', '', '', '', '', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:20:53');
INSERT INTO `customers` VALUES ('51', '20210037', 'SHEILA ACAS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:23:31');
INSERT INTO `customers` VALUES ('52', '20210038', 'STEVA', 'CLARIN\r\n', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:24:20');
INSERT INTO `customers` VALUES ('53', '20210039', 'M.U', 'OZAMIS CITY', '', 'OZA', 'OZAMIZ CITY', 'CON ', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:30:19');
INSERT INTO `customers` VALUES ('54', '20210040', 'COTAMORA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:33:40');
INSERT INTO `customers` VALUES ('55', '20210041', 'NILO REVEVELO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:35:15');
INSERT INTO `customers` VALUES ('56', '20210042', 'RONDEL', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:35:56');
INSERT INTO `customers` VALUES ('57', '20210043', 'LUTONG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:37:09');
INSERT INTO `customers` VALUES ('58', '20210044', 'GUIRRE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:37:50');
INSERT INTO `customers` VALUES ('59', '20210045', 'ELLEN BARAGON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:38:42');
INSERT INTO `customers` VALUES ('60', '20210046', 'DYLNDA CLARN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:40:01');
INSERT INTO `customers` VALUES ('61', '20210047', 'MENDEZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:41:15');
INSERT INTO `customers` VALUES ('62', '20210048', 'ESTIVA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:42:07');
INSERT INTO `customers` VALUES ('63', '20210049', 'SALAMANCA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:43:28');
INSERT INTO `customers` VALUES ('64', '20210050', 'MARY-ANN TAN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:45:05');
INSERT INTO `customers` VALUES ('65', '20210051', 'MENDIOLA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:47:44');
INSERT INTO `customers` VALUES ('66', '20210052', 'ELSE EMMA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:48:55');
INSERT INTO `customers` VALUES ('67', '20210053', 'SUSAN BAADIANG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:50:56');
INSERT INTO `customers` VALUES ('68', '20210054', 'BAUL', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-26 13:35:11');
INSERT INTO `customers` VALUES ('69', '20210055', 'DR. CHAD', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-15 00:53:02');
INSERT INTO `customers` VALUES ('70', '20210056', 'JL GARAY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:53:58');
INSERT INTO `customers` VALUES ('72', '20210058', 'ROY MURO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 00:56:26');
INSERT INTO `customers` VALUES ('73', '20210059', 'DAWIS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:00:17');
INSERT INTO `customers` VALUES ('74', '20210060', 'BUGAS', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-26 13:35:32');
INSERT INTO `customers` VALUES ('75', '20210061', 'J. TAN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:05:18');
INSERT INTO `customers` VALUES ('76', '20210062', 'GERIC. R', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:06:58');
INSERT INTO `customers` VALUES ('77', '20210063', 'BORHE', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-26 13:35:22');
INSERT INTO `customers` VALUES ('78', '20210064', 'TONX2 SARABIA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:09:10');
INSERT INTO `customers` VALUES ('79', '20210065', 'HODS VALLEY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:17:52');
INSERT INTO `customers` VALUES ('80', '20210066', 'MARTINEZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:18:41');
INSERT INTO `customers` VALUES ('81', '20210067', 'PALAHANG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'Y', 'Y', '2021-10-15 01:21:13');
INSERT INTO `customers` VALUES ('82', '20210068', 'AGUSTIN', 'GOMBIL TUDELA MIS.OCC,', '', 'TUD', 'TUDELA', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-10-31 10:54:16');
INSERT INTO `customers` VALUES ('83', '20210069', 'JUMAR REMIZ', 'CLARIN', '', 'OZA', 'OZAMIZ CITY', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-11-09 00:10:17');
INSERT INTO `customers` VALUES ('84', '20210070', 'SARINOGON', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-11-09 12:12:07');
INSERT INTO `customers` VALUES ('85', '20210071', 'OZARAGA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-11-12 00:58:27');
INSERT INTO `customers` VALUES ('86', '20210072', 'LEVI FARM', 'CLARIN', '', 'OZA', 'OZAMIZ CITY', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-11-29 05:54:41');
INSERT INTO `customers` VALUES ('87', '20210073', 'UNKNOWN', 'UNKOWN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-12-01 11:36:08');
INSERT INTO `customers` VALUES ('88', '20210074', 'FILIPE', 'MISS OCC', '', 'CLA', '', 'T', 'TECHNICIAN', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-12-03 10:26:44');
INSERT INTO `customers` VALUES ('89', '20210075', 'LOMUNTOD', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-12-09 02:46:15');
INSERT INTO `customers` VALUES ('90', '20210076', 'ROY MONTEALTO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-12-30 00:54:49');
INSERT INTO `customers` VALUES ('91', '20220001', 'HAGANOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:00:03');
INSERT INTO `customers` VALUES ('93', '20220003', 'YONGX2', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:13:02');
INSERT INTO `customers` VALUES ('94', '20220004', 'MELODY AUGUST', '', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:14:39');
INSERT INTO `customers` VALUES ('95', '20220005', 'GESEL TAN', 'CLARIN\r\n', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:16:40');
INSERT INTO `customers` VALUES ('96', '20220006', 'LABADESUS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:18:30');
INSERT INTO `customers` VALUES ('97', '20220007', 'MEJORADA BROTHER', 'CLARIN\r\n', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:24:57');
INSERT INTO `customers` VALUES ('98', '20220008', 'BAZAN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:28:25');
INSERT INTO `customers` VALUES ('99', '20220009', 'EDUARDO CAPAO', 'DIPOLOG\r\n', '', 'ORO', 'OROQUIETA CITY', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:30:21');
INSERT INTO `customers` VALUES ('100', '20220010', 'REGGIE QUIMBO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:32:22');
INSERT INTO `customers` VALUES ('101', '20220011', 'OSHE FARM', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:32:52');
INSERT INTO `customers` VALUES ('102', '20220012', 'METILLIO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 10:37:20');
INSERT INTO `customers` VALUES ('103', '20220013', 'M. TAN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 22:44:56');
INSERT INTO `customers` VALUES ('104', '20220014', 'JERICK REDOBLADO', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-03 23:48:57');
INSERT INTO `customers` VALUES ('105', '20220015', 'MIKE SAQUIN JR.', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-04 00:41:45');
INSERT INTO `customers` VALUES ('106', '20220016', 'ARNEL CALIAW', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-04 09:25:49');
INSERT INTO `customers` VALUES ('107', '20220017', 'SINDA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-04 09:27:15');
INSERT INTO `customers` VALUES ('108', '20220018', 'ROGER', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-04 09:28:56');
INSERT INTO `customers` VALUES ('109', '20220019', 'ARIEL', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-04 09:37:33');
INSERT INTO `customers` VALUES ('110', '20220020', 'EDNA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-04 14:22:15');
INSERT INTO `customers` VALUES ('111', '20220021', 'PBL HARO', 'CLARIN', '', 'CLA', 'CLARIN', 'M', 'MEGA DEALER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-05 03:55:51');
INSERT INTO `customers` VALUES ('112', '20220022', 'JOBEN DOLDOLIE', 'CLAIRN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-05 09:20:42');
INSERT INTO `customers` VALUES ('113', '20220023', 'JESSEL', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-06 10:49:46');
INSERT INTO `customers` VALUES ('114', '20220024', 'MAGDALES', 'AURORA', '', 'ALO', 'ALORAN', 'FPO', 'FARM POULTRY', 'ZDS', 'ZABOANGA DEL SUR', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-06 11:12:19');
INSERT INTO `customers` VALUES ('115', '20220025', 'MIO AGRIVET', 'CLARIN', '', 'CLA', 'CLARIN', 'M', 'MEGA DEALER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-06 11:14:24');
INSERT INTO `customers` VALUES ('116', '20220026', 'ELLACONE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-07 10:03:14');
INSERT INTO `customers` VALUES ('117', '20220027', 'SABUELO', 'PANA-ON\r\n', '', 'ALO', 'ALORAN', 'FPI', 'FARM PIGGERY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-07 10:06:58');
INSERT INTO `customers` VALUES ('118', '20220028', 'SENDO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-08 10:20:41');
INSERT INTO `customers` VALUES ('119', '20220029', 'OTCHATE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-08 10:23:07');
INSERT INTO `customers` VALUES ('120', '20220030', 'MARILYN BAYLON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-08 10:25:37');
INSERT INTO `customers` VALUES ('121', '20220031', 'BANGKONG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-08 10:27:18');
INSERT INTO `customers` VALUES ('122', '20220032', 'JEBOY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-08 11:34:28');
INSERT INTO `customers` VALUES ('123', '20220033', 'CROSTY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-10 13:41:11');
INSERT INTO `customers` VALUES ('124', '20220034', 'JOPE M. GALLETO', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-10 13:43:52');
INSERT INTO `customers` VALUES ('125', '20220035', 'DIMINEGA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-11 00:39:29');
INSERT INTO `customers` VALUES ('126', '20220036', 'HENRRY BARON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-11 00:15:59');
INSERT INTO `customers` VALUES ('127', '20220037', 'CELECIUS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-11 10:08:09');
INSERT INTO `customers` VALUES ('128', '20220038', 'DUSTIN TAN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-11 11:35:50');
INSERT INTO `customers` VALUES ('129', '20220039', 'JUNA ROSIE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-12 12:05:58');
INSERT INTO `customers` VALUES ('130', '20220040', 'IAN MESAGRANDE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-12 12:06:31');
INSERT INTO `customers` VALUES ('131', '20220041', 'NILO REVELO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-12 12:32:24');
INSERT INTO `customers` VALUES ('132', '20220042', 'JOSE DRAGOON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-13 14:50:31');
INSERT INTO `customers` VALUES ('133', '20220043', 'AMNESTAD', 'GANGO', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-18 11:08:14');
INSERT INTO `customers` VALUES ('134', '20220044', 'MANLIGIS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-14 14:38:17');
INSERT INTO `customers` VALUES ('135', '20220045', 'JULIUS FRANCISCO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-15 12:52:55');
INSERT INTO `customers` VALUES ('136', '20220046', 'ACOPE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-15 13:11:07');
INSERT INTO `customers` VALUES ('137', '20220047', 'BONIFACIO', 'BONIFACIO', '', 'BON', 'BONIFACIO', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-15 13:34:29');
INSERT INTO `customers` VALUES ('138', '20220048', 'ALBARO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-17 10:07:18');
INSERT INTO `customers` VALUES ('139', '20220049', 'MERNA GAJANE', 'CLARIN ', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-17 10:13:43');
INSERT INTO `customers` VALUES ('140', '20220050', 'REVELO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-17 10:17:32');
INSERT INTO `customers` VALUES ('141', '20220051', 'JUNX2 GARLIT', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-17 15:02:37');
INSERT INTO `customers` VALUES ('142', '20220052', 'ALVIN BALABAG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-18 11:05:03');
INSERT INTO `customers` VALUES ('143', '20220053', 'MAYA LABASTIDA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-18 12:04:34');
INSERT INTO `customers` VALUES ('144', '20220054', 'RENE DUMANHOG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-19 10:15:01');
INSERT INTO `customers` VALUES ('145', '20220055', 'TATA LOMOLOY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-19 10:44:29');
INSERT INTO `customers` VALUES ('146', '20220056', 'DAGOL', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-23 23:43:42');
INSERT INTO `customers` VALUES ('147', '20220057', 'RAMAYRAT', 'CLARIN\r\n', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-24 10:11:57');
INSERT INTO `customers` VALUES ('148', '20220058', 'RODRIGUEZ MRYNA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', '', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-25 10:57:30');
INSERT INTO `customers` VALUES ('149', '20220059', 'JONGX2', 'SEGATIC DAKU', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-28 01:19:55');
INSERT INTO `customers` VALUES ('150', '20220060', 'CHRISTOPHER J. TAGALA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-22 06:31:12');
INSERT INTO `customers` VALUES ('151', '20220061', 'CANTO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-28 05:45:31');
INSERT INTO `customers` VALUES ('152', '20220062', 'BALITON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-28 14:32:50');
INSERT INTO `customers` VALUES ('153', '20220063', 'OCAMPOS STORE', 'CABATUAN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-28 14:41:32');
INSERT INTO `customers` VALUES ('154', '20220064', 'CELESTE DAISON STORE', 'BACOLOD', '', 'ALO', 'ALORAN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-28 14:42:34');
INSERT INTO `customers` VALUES ('155', '20220065', 'DORES STORE', 'LIPOSONG', '', 'TUD', 'TUDELA', 'M', 'MEGA DEALER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-28 14:43:17');
INSERT INTO `customers` VALUES ('156', '20220066', 'ABS AGRIVET\'S', 'BANADERO, OZAMIS', '', 'OZA', 'OZAMIZ CITY', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-07-26 07:24:36');
INSERT INTO `customers` VALUES ('157', '20220067', 'PRINCE GARLIT', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-30 13:42:54');
INSERT INTO `customers` VALUES ('158', '20220068', 'ANTIQUE PUESTO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-30 14:05:21');
INSERT INTO `customers` VALUES ('159', '20220069', 'DUMINGAG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-30 14:28:15');
INSERT INTO `customers` VALUES ('160', '20220070', 'TC AGRIVET', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-01-31 12:35:15');
INSERT INTO `customers` VALUES ('161', '20220071', 'GO-GO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-01 11:49:28');
INSERT INTO `customers` VALUES ('162', '20220072', 'BIKOY STORE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-01 12:21:24');
INSERT INTO `customers` VALUES ('163', '20220073', 'REMY SUMINGIT', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-01 12:22:16');
INSERT INTO `customers` VALUES ('164', '20220074', 'JUBEN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-04 22:39:35');
INSERT INTO `customers` VALUES ('165', '20220075', 'HANZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-06 12:48:55');
INSERT INTO `customers` VALUES ('166', '20220076', 'BEACON M. GANADEN', 'CLARIN', '', 'CLA', 'CLARIN', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-06 13:17:20');
INSERT INTO `customers` VALUES ('167', '20220077', 'LOSICA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-08 07:37:52');
INSERT INTO `customers` VALUES ('168', '20220078', 'RAY MALIPOWNON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-08 13:57:05');
INSERT INTO `customers` VALUES ('169', '20220079', 'NELSON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MR', 'MISAMIS ORIENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-08 13:59:36');
INSERT INTO `customers` VALUES ('170', '20220080', 'DONX2 BARROGA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-12 00:38:43');
INSERT INTO `customers` VALUES ('171', '20220081', 'SANDE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-12 00:48:22');
INSERT INTO `customers` VALUES ('172', '20220082', 'ELLE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-12 01:14:12');
INSERT INTO `customers` VALUES ('173', '20220083', 'JUNJIE MINTALAR', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-12 01:19:01');
INSERT INTO `customers` VALUES ('174', '20220084', 'YANX2 MEJORADA', 'CLARIN ', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-15 06:46:12');
INSERT INTO `customers` VALUES ('175', '20220085', 'ARNOLD TAN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-15 08:09:54');
INSERT INTO `customers` VALUES ('176', '20220086', 'BARRON', 'CLARIN\r\n', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-15 08:12:55');
INSERT INTO `customers` VALUES ('177', '20220087', 'DANTES', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-16 13:29:05');
INSERT INTO `customers` VALUES ('178', '20220088', 'TORENOGBA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-16 13:30:31');
INSERT INTO `customers` VALUES ('179', '20220089', 'AMISLAY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-18 13:46:34');
INSERT INTO `customers` VALUES ('180', '20220090', 'CAJETA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-18 13:49:09');
INSERT INTO `customers` VALUES ('181', '20220091', 'CARTAJENAS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-18 13:54:58');
INSERT INTO `customers` VALUES ('182', '20220092', 'CALAMBA', 'CALAMBA', '', 'ORO', 'OROQUIETA CITY', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-19 12:23:02');
INSERT INTO `customers` VALUES ('183', '20220093', 'CHRISPEL', 'CLARIN', '', 'CLA', 'CLARIN', 'FPI', 'FARM PIGGERY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-19 13:14:23');
INSERT INTO `customers` VALUES ('184', '20220094', 'JANETH ENRICOSO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-19 13:40:27');
INSERT INTO `customers` VALUES ('185', '20220095', 'JAPAY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-19 13:42:38');
INSERT INTO `customers` VALUES ('186', '20220096', 'TAGUBAR ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-21 23:51:24');
INSERT INTO `customers` VALUES ('187', '20220097', 'JAYLORD', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-22 06:20:30');
INSERT INTO `customers` VALUES ('188', '20220098', 'ANDRO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-22 13:35:15');
INSERT INTO `customers` VALUES ('189', '20220099', 'RAMENTOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-22 14:21:52');
INSERT INTO `customers` VALUES ('190', '20220100', 'SALIYAI', '', '', 'CLA', 'CLARIN', 'C', 'CONSUMER', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2022-02-23 09:52:06');
INSERT INTO `customers` VALUES ('191', '20220101', 'GAISANO CITIMALL OZAMIZ ', 'BAYBAY TRIUNFO PORT ROAD, OZAMIZ CITY', '', 'OZA', 'OZAMIZ CITY', 'FPO', 'FARM POULTRY', 'MO', 'MISAMIS OCCIDENTAL', '', '', '11-111-000-1111', '09550529855', '521-PLDT', '0', '0.00', '0', 'N', 'Y', '2022-06-24 08:27:50');
INSERT INTO `customers` VALUES ('192', '20220102', 'UNITOP OZAMIZ', 'GOMEZ STREET, OZAMIZ CITY', '', 'OZA', 'OZAMIZ CITY', 'SUP', 'SUPER MAKERT', 'MO', 'MISAMIS OCCIDENTAL', '', '', 'AAAAAAAAAAAAAAA', 'BBBBBBBBBBBBBBB', 'CCCCCCCCCCCCCCC', '0', '0.00', '0', 'N', 'Y', '2022-03-19 02:56:30');

-- ----------------------------
-- Table structure for customers_old
-- ----------------------------
DROP TABLE IF EXISTS `customers_old`;
CREATE TABLE `customers_old` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `custcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `custname` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `address` varchar(300) CHARACTER SET utf8 DEFAULT NULL,
  `shipto` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `areacode` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `areaname` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `outletcode` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `outlettype` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `provcode` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `province` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `maincode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `mainp` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `tinno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `mobileno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `telno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `payterms` varchar(3) CHARACTER SET utf8 DEFAULT NULL,
  `creditlimit` decimal(15,2) DEFAULT NULL,
  `spdiscount` int(10) DEFAULT NULL,
  `allowpd` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`custcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=51 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of customers_old
-- ----------------------------
INSERT INTO `customers_old` VALUES ('40', '20210026', 'AILEEN CANETE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:13:12');
INSERT INTO `customers_old` VALUES ('41', '20210027', 'HOGANOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:14:05');
INSERT INTO `customers_old` VALUES ('42', '20210028', 'BONIFACIO FARM', 'BONIFACIO', '', 'BON', 'BONIFACIO', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:15:01');
INSERT INTO `customers_old` VALUES ('43', '20210029', 'ENGR. TATOY', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:15:41');
INSERT INTO `customers_old` VALUES ('44', '20210030', 'BAGIO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:16:14');
INSERT INTO `customers_old` VALUES ('45', '20210031', 'TABALBA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:16:53');
INSERT INTO `customers_old` VALUES ('46', '20210032', 'OMETEN', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:17:33');
INSERT INTO `customers_old` VALUES ('47', '20210033', 'DESQITADO', 'DIPOLOG', '', '', 'TUDELA', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:18:34');
INSERT INTO `customers_old` VALUES ('48', '20210034', 'SENADOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:19:31');
INSERT INTO `customers_old` VALUES ('25', '20210011', 'DULA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:01:46');
INSERT INTO `customers_old` VALUES ('26', '20210012', 'JUN MAALAM', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:02:53');
INSERT INTO `customers_old` VALUES ('27', '20210013', 'CLIFFORD', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:03:34');
INSERT INTO `customers_old` VALUES ('28', '20210014', 'MEJORADA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:04:22');
INSERT INTO `customers_old` VALUES ('29', '20210015', 'SALIG', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:05:24');
INSERT INTO `customers_old` VALUES ('30', '20210016', 'EDU', 'CLARIN\r\n\r\n', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:06:02');
INSERT INTO `customers_old` VALUES ('31', '20210017', 'DACKLESS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:06:46');
INSERT INTO `customers_old` VALUES ('32', '20210018', 'JIMBOY', 'OROQUIETA', '', 'ORO', 'OROQUIETA CITY', '', '', '', '', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:07:49');
INSERT INTO `customers_old` VALUES ('33', '20210019', 'TUBIGON', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:08:22');
INSERT INTO `customers_old` VALUES ('34', '20210020', 'MANTUA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:09:04');
INSERT INTO `customers_old` VALUES ('35', '20210021', 'JUNNY SIAREZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:09:51');
INSERT INTO `customers_old` VALUES ('36', '20210022', 'FRANCISCO', '', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:10:29');
INSERT INTO `customers_old` VALUES ('37', '20210023', 'PRECY CARAMBA', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:11:00');
INSERT INTO `customers_old` VALUES ('38', '20210024', 'LISEL BARRIENTOS', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:11:35');
INSERT INTO `customers_old` VALUES ('39', '20210025', 'KINTOY HERALDE', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:12:14');
INSERT INTO `customers_old` VALUES ('23', '20210009', 'RAMIL DOKO', 'OZAMIZ CITY', 'RAMIL', 'OZA', 'OZAMIZ CITY', 'CON ', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-12 08:15:58');
INSERT INTO `customers_old` VALUES ('24', '20210010', 'IAN DELAPAZ', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', '', '', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:00:01');
INSERT INTO `customers_old` VALUES ('49', '20210035', 'LOMO', 'CLARIN', '', 'CLA', 'CLARIN', 'C', 'CONVENIENCE', 'MO', 'MISAMIS OCCIDENTAL', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:20:18');
INSERT INTO `customers_old` VALUES ('50', '20210036', 'QIMBO', '', '', '', '', '', '', '', '', '', '', '', '', '', '0', '0.00', '0', 'N', 'Y', '2021-09-29 12:20:53');

-- ----------------------------
-- Table structure for custsales
-- ----------------------------
DROP TABLE IF EXISTS `custsales`;
CREATE TABLE `custsales` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `custcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `slmncode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `slmnname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `whscode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `warehouse` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `opercode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `typeofoper` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `pricetype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`custcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=369 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of custsales
-- ----------------------------
INSERT INTO `custsales` VALUES ('146', '20210036', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:20:53');
INSERT INTO `custsales` VALUES ('139', '20210029', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:15:41');
INSERT INTO `custsales` VALUES ('221', '20210030', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-05 10:10:08');
INSERT INTO `custsales` VALUES ('141', '20210031', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:16:53');
INSERT INTO `custsales` VALUES ('142', '20210032', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:17:33');
INSERT INTO `custsales` VALUES ('143', '20210033', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:18:34');
INSERT INTO `custsales` VALUES ('144', '20210034', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:19:31');
INSERT INTO `custsales` VALUES ('145', '20210035', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:20:18');
INSERT INTO `custsales` VALUES ('124', '20210014', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:04:22');
INSERT INTO `custsales` VALUES ('125', '20210015', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:05:24');
INSERT INTO `custsales` VALUES ('126', '20210016', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:06:02');
INSERT INTO `custsales` VALUES ('127', '20210017', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:06:46');
INSERT INTO `custsales` VALUES ('128', '20210018', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:07:49');
INSERT INTO `custsales` VALUES ('182', '20210019', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:32:05');
INSERT INTO `custsales` VALUES ('130', '20210020', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:09:04');
INSERT INTO `custsales` VALUES ('131', '20210021', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:09:51');
INSERT INTO `custsales` VALUES ('132', '20210022', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:10:29');
INSERT INTO `custsales` VALUES ('133', '20210023', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:11:00');
INSERT INTO `custsales` VALUES ('134', '20210024', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:11:35');
INSERT INTO `custsales` VALUES ('135', '20210025', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:12:14');
INSERT INTO `custsales` VALUES ('356', '20210026', 'O', 'OPAW', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-26 07:26:18');
INSERT INTO `custsales` VALUES ('199', '20220002', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:04:05');
INSERT INTO `custsales` VALUES ('185', '20210028', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:35:17');
INSERT INTO `custsales` VALUES ('181', '20210009', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:28:02');
INSERT INTO `custsales` VALUES ('123', '20210013', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:03:34');
INSERT INTO `custsales` VALUES ('218', '20210010', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 14:22:33');
INSERT INTO `custsales` VALUES ('121', '20210011', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:01:46');
INSERT INTO `custsales` VALUES ('122', '20210012', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-09-29 12:02:53');
INSERT INTO `custsales` VALUES ('187', '20210060', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:35:32');
INSERT INTO `custsales` VALUES ('184', '20210054', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:35:11');
INSERT INTO `custsales` VALUES ('152', '20210048', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:06:06');
INSERT INTO `custsales` VALUES ('186', '20210063', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:35:22');
INSERT INTO `custsales` VALUES ('155', '20210040', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:07:48');
INSERT INTO `custsales` VALUES ('156', '20210059', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:08:03');
INSERT INTO `custsales` VALUES ('157', '20210055', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:08:19');
INSERT INTO `custsales` VALUES ('158', '20210046', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:08:43');
INSERT INTO `custsales` VALUES ('159', '20210062', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:08:58');
INSERT INTO `custsales` VALUES ('160', '20210045', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:09:13');
INSERT INTO `custsales` VALUES ('161', '20210052', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:09:29');
INSERT INTO `custsales` VALUES ('162', '20210041', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:09:56');
INSERT INTO `custsales` VALUES ('163', '20210044', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:21:33');
INSERT INTO `custsales` VALUES ('164', '20210065', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:21:58');
INSERT INTO `custsales` VALUES ('165', '20210056', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:22:13');
INSERT INTO `custsales` VALUES ('166', '20210039', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:22:37');
INSERT INTO `custsales` VALUES ('167', '20210061', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:22:58');
INSERT INTO `custsales` VALUES ('168', '20210043', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:23:15');
INSERT INTO `custsales` VALUES ('169', '20210050', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:23:34');
INSERT INTO `custsales` VALUES ('170', '20210066', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:23:58');
INSERT INTO `custsales` VALUES ('171', '20210064', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:24:11');
INSERT INTO `custsales` VALUES ('172', '20210037', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:24:30');
INSERT INTO `custsales` VALUES ('173', '20210049', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:24:45');
INSERT INTO `custsales` VALUES ('174', '20210047', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:25:03');
INSERT INTO `custsales` VALUES ('175', '20210051', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:25:21');
INSERT INTO `custsales` VALUES ('176', '20210067', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:25:34');
INSERT INTO `custsales` VALUES ('177', '20210053', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:26:37');
INSERT INTO `custsales` VALUES ('178', '20210042', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:26:53');
INSERT INTO `custsales` VALUES ('179', '20210038', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:27:18');
INSERT INTO `custsales` VALUES ('180', '20210058', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-10-26 13:27:34');
INSERT INTO `custsales` VALUES ('330', '20210068', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-06-21 07:29:36');
INSERT INTO `custsales` VALUES ('189', '20210069', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-11-09 00:10:17');
INSERT INTO `custsales` VALUES ('190', '20210070', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-11-09 12:12:07');
INSERT INTO `custsales` VALUES ('191', '20210071', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-11-12 00:58:27');
INSERT INTO `custsales` VALUES ('192', '20210072', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-11-29 05:54:41');
INSERT INTO `custsales` VALUES ('193', '20210073', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-12-01 11:36:08');
INSERT INTO `custsales` VALUES ('194', '20210074', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-12-03 10:26:44');
INSERT INTO `custsales` VALUES ('195', '20210075', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-12-09 02:46:15');
INSERT INTO `custsales` VALUES ('196', '20210076', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2021-12-30 00:54:49');
INSERT INTO `custsales` VALUES ('198', '20220001', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:00:37');
INSERT INTO `custsales` VALUES ('200', '20220003', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:13:02');
INSERT INTO `custsales` VALUES ('201', '20220004', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:14:39');
INSERT INTO `custsales` VALUES ('202', '20220005', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:16:40');
INSERT INTO `custsales` VALUES ('203', '20220006', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:18:30');
INSERT INTO `custsales` VALUES ('204', '20220007', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:24:57');
INSERT INTO `custsales` VALUES ('205', '20220008', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:28:25');
INSERT INTO `custsales` VALUES ('206', '20220009', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:30:21');
INSERT INTO `custsales` VALUES ('207', '20220010', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:32:22');
INSERT INTO `custsales` VALUES ('208', '20220011', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:32:52');
INSERT INTO `custsales` VALUES ('209', '20220012', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 10:37:20');
INSERT INTO `custsales` VALUES ('210', '20220013', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 22:44:56');
INSERT INTO `custsales` VALUES ('211', '20220014', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-03 23:48:57');
INSERT INTO `custsales` VALUES ('212', '20220015', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 00:41:45');
INSERT INTO `custsales` VALUES ('213', '20220016', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 09:25:49');
INSERT INTO `custsales` VALUES ('214', '20220017', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 09:27:15');
INSERT INTO `custsales` VALUES ('215', '20220018', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 09:28:56');
INSERT INTO `custsales` VALUES ('216', '20220019', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 09:37:33');
INSERT INTO `custsales` VALUES ('217', '20220020', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-04 14:22:15');
INSERT INTO `custsales` VALUES ('219', '20220021', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-05 03:55:51');
INSERT INTO `custsales` VALUES ('220', '20220022', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-05 09:20:42');
INSERT INTO `custsales` VALUES ('222', '20220023', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-06 10:49:46');
INSERT INTO `custsales` VALUES ('223', '20220024', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-06 11:12:19');
INSERT INTO `custsales` VALUES ('224', '20220025', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-06 11:14:24');
INSERT INTO `custsales` VALUES ('225', '20220026', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-07 10:03:14');
INSERT INTO `custsales` VALUES ('226', '20220027', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-07 10:06:58');
INSERT INTO `custsales` VALUES ('227', '20220028', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-08 10:20:41');
INSERT INTO `custsales` VALUES ('228', '20220029', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-08 10:23:07');
INSERT INTO `custsales` VALUES ('229', '20220030', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-08 10:25:37');
INSERT INTO `custsales` VALUES ('230', '20220031', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-08 10:27:18');
INSERT INTO `custsales` VALUES ('231', '20220032', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-08 11:34:28');
INSERT INTO `custsales` VALUES ('232', '20220033', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-10 13:41:11');
INSERT INTO `custsales` VALUES ('233', '20220034', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-10 13:43:52');
INSERT INTO `custsales` VALUES ('236', '20220035', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-11 00:39:29');
INSERT INTO `custsales` VALUES ('235', '20220036', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-11 00:15:59');
INSERT INTO `custsales` VALUES ('237', '20220037', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-11 10:08:09');
INSERT INTO `custsales` VALUES ('238', '20220038', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-11 11:35:50');
INSERT INTO `custsales` VALUES ('239', '20220039', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-12 12:05:58');
INSERT INTO `custsales` VALUES ('240', '20220040', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-12 12:06:31');
INSERT INTO `custsales` VALUES ('241', '20220041', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-12 12:32:24');
INSERT INTO `custsales` VALUES ('242', '20220042', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-13 14:50:31');
INSERT INTO `custsales` VALUES ('253', '20220043', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-18 11:08:14');
INSERT INTO `custsales` VALUES ('244', '20220044', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-14 14:38:17');
INSERT INTO `custsales` VALUES ('245', '20220045', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-15 12:52:55');
INSERT INTO `custsales` VALUES ('328', '20220046', 'B', 'SALESMAN B', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-06-20 06:04:59');
INSERT INTO `custsales` VALUES ('247', '20220047', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-15 13:34:29');
INSERT INTO `custsales` VALUES ('357', '20220048', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:18:59');
INSERT INTO `custsales` VALUES ('249', '20220049', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-17 10:13:43');
INSERT INTO `custsales` VALUES ('250', '20220050', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-17 10:17:32');
INSERT INTO `custsales` VALUES ('251', '20220051', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-17 15:02:37');
INSERT INTO `custsales` VALUES ('359', '20220052', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:19:23');
INSERT INTO `custsales` VALUES ('254', '20220053', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-18 12:04:34');
INSERT INTO `custsales` VALUES ('255', '20220054', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-19 10:15:01');
INSERT INTO `custsales` VALUES ('256', '20220055', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-19 10:44:29');
INSERT INTO `custsales` VALUES ('257', '20220056', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-23 23:43:42');
INSERT INTO `custsales` VALUES ('258', '20220057', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-24 10:11:57');
INSERT INTO `custsales` VALUES ('259', '20220058', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-25 10:57:30');
INSERT INTO `custsales` VALUES ('260', '20220059', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-28 01:19:55');
INSERT INTO `custsales` VALUES ('301', '20220060', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-22 06:31:12');
INSERT INTO `custsales` VALUES ('262', '20220061', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-28 05:45:31');
INSERT INTO `custsales` VALUES ('263', '20220062', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-28 14:32:50');
INSERT INTO `custsales` VALUES ('264', '20220063', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-28 14:41:32');
INSERT INTO `custsales` VALUES ('265', '20220064', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-28 14:42:34');
INSERT INTO `custsales` VALUES ('266', '20220065', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-28 14:43:17');
INSERT INTO `custsales` VALUES ('351', '20220066', 'B', 'SALESMAN B', 'WHS1', 'WAREHOUSE 1', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-26 07:24:41');
INSERT INTO `custsales` VALUES ('269', '20220067', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-30 13:42:54');
INSERT INTO `custsales` VALUES ('270', '20220068', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-30 14:05:21');
INSERT INTO `custsales` VALUES ('271', '20220069', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-30 14:28:15');
INSERT INTO `custsales` VALUES ('272', '20220070', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-01-31 12:35:15');
INSERT INTO `custsales` VALUES ('273', '20220071', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-01 11:49:28');
INSERT INTO `custsales` VALUES ('274', '20220072', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-01 12:21:24');
INSERT INTO `custsales` VALUES ('275', '20220073', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-01 12:22:16');
INSERT INTO `custsales` VALUES ('276', '20220074', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-04 22:39:35');
INSERT INTO `custsales` VALUES ('277', '20220075', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-06 12:48:55');
INSERT INTO `custsales` VALUES ('278', '20220076', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-06 13:17:20');
INSERT INTO `custsales` VALUES ('279', '20220077', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-08 07:37:52');
INSERT INTO `custsales` VALUES ('280', '20220078', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-08 13:57:05');
INSERT INTO `custsales` VALUES ('281', '20220079', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-08 13:59:36');
INSERT INTO `custsales` VALUES ('282', '20220080', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-12 00:38:43');
INSERT INTO `custsales` VALUES ('283', '20220081', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-12 00:48:22');
INSERT INTO `custsales` VALUES ('284', '20220082', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-12 01:14:12');
INSERT INTO `custsales` VALUES ('285', '20220083', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-12 01:19:01');
INSERT INTO `custsales` VALUES ('286', '20220084', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-15 06:46:12');
INSERT INTO `custsales` VALUES ('287', '20220085', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-15 08:09:54');
INSERT INTO `custsales` VALUES ('288', '20220086', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-15 08:12:55');
INSERT INTO `custsales` VALUES ('289', '20220087', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-16 13:29:05');
INSERT INTO `custsales` VALUES ('290', '20220088', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-16 13:30:31');
INSERT INTO `custsales` VALUES ('291', '20220089', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-18 13:46:34');
INSERT INTO `custsales` VALUES ('292', '20220090', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-18 13:49:09');
INSERT INTO `custsales` VALUES ('293', '20220091', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-18 13:54:58');
INSERT INTO `custsales` VALUES ('294', '20220092', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-19 12:23:02');
INSERT INTO `custsales` VALUES ('295', '20220093', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-19 13:14:23');
INSERT INTO `custsales` VALUES ('296', '20220094', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-19 13:40:27');
INSERT INTO `custsales` VALUES ('297', '20220095', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-19 13:42:38');
INSERT INTO `custsales` VALUES ('298', '20220096', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-21 23:51:24');
INSERT INTO `custsales` VALUES ('299', '20220097', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-22 06:20:30');
INSERT INTO `custsales` VALUES ('302', '20220098', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-22 13:35:15');
INSERT INTO `custsales` VALUES ('303', '20220099', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-22 14:21:52');
INSERT INTO `custsales` VALUES ('304', '20220100', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-02-23 09:52:06');
INSERT INTO `custsales` VALUES ('354', '20220066', 'E', 'SALESMAN WHS9', 'WHS9', 'WAREHOUSE 9', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-26 07:24:41');
INSERT INTO `custsales` VALUES ('367', '20220101', 'TC', 'TOPING MAGHANOY', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:22:25');
INSERT INTO `custsales` VALUES ('310', '20220102', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-03-19 02:56:30');
INSERT INTO `custsales` VALUES ('311', '20220102', 'O', 'OPAW', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'B', '2022-03-19 02:56:30');
INSERT INTO `custsales` VALUES ('327', '20220046', 'O', 'OPAW', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-06-20 06:04:59');
INSERT INTO `custsales` VALUES ('368', '20220101', 'RA', 'RICHEL ALCONTIN', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:22:25');
INSERT INTO `custsales` VALUES ('353', '20220066', 'O', 'OPAW', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-26 07:24:41');
INSERT INTO `custsales` VALUES ('329', '20220046', 'C', 'SALESMAN WHS 5', 'WHS5', 'WAREHOUSE 5', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-06-20 06:04:59');
INSERT INTO `custsales` VALUES ('331', '20210068', 'O', 'OPAW', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-06-21 07:29:36');
INSERT INTO `custsales` VALUES ('355', '20210026', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-26 07:26:18');
INSERT INTO `custsales` VALUES ('352', '20220066', 'D', 'SALESMAN WHS 15', 'WHS15', 'WAREHOUSE 15', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-26 07:24:41');
INSERT INTO `custsales` VALUES ('350', '20220066', 'A', 'ANTHONY M. FULLO III', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'B', '2022-07-26 07:24:41');
INSERT INTO `custsales` VALUES ('358', '20220048', 'E', 'SALESMAN WHS9', 'WHS9', 'WAREHOUSE 9', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:18:59');
INSERT INTO `custsales` VALUES ('360', '20220052', 'C', 'SALESMAN WHS 5', 'WHS5', 'WAREHOUSE 5', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:19:23');
INSERT INTO `custsales` VALUES ('366', '20220101', 'AY', 'ALBERTO YOLDAN JR', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-07-27 08:22:25');
INSERT INTO `custsales` VALUES ('365', '20220101', 'O', 'OPAW', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'B', '2022-07-27 08:22:25');

-- ----------------------------
-- Table structure for expdate
-- ----------------------------
DROP TABLE IF EXISTS `expdate`;
CREATE TABLE `expdate` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `item` varchar(12) NOT NULL DEFAULT '',
  `whs` varchar(5) DEFAULT NULL,
  `qty_good` int(11) DEFAULT NULL,
  `qty_bo` int(11) DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`item`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of expdate
-- ----------------------------

-- ----------------------------
-- Table structure for expresd
-- ----------------------------
DROP TABLE IF EXISTS `expresd`;
CREATE TABLE `expresd` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `edate` date DEFAULT NULL,
  `slmncode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `custcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `reftype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `refno` varchar(12) CHARACTER SET utf8 DEFAULT NULL,
  `refamt` decimal(15,2) DEFAULT NULL,
  `refdate` date DEFAULT NULL,
  `refdoc` varchar(21) CHARACTER SET utf8 DEFAULT NULL,
  `bank` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `checkno` varchar(11) CHARACTER SET utf8 DEFAULT NULL,
  `checkdate` date DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`transno`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of expresd
-- ----------------------------
INSERT INTO `expresd` VALUES ('1', 'E000000001', 'E', '2022-06-21', 'B', '20220066', 'R', 'R000000003', '-163.30', '2022-06-21', 'A', '', 'CASH', '2022-06-21', '0', '2022-06-21 02:25:17');
INSERT INTO `expresd` VALUES ('2', 'E000000001', 'E', '2022-06-21', 'B', '20220066', 'S', 'S000000001', '12783.30', '2022-06-17', '1', '', 'CASH', '2022-06-21', '0', '2022-06-21 02:25:17');
INSERT INTO `expresd` VALUES ('3', 'E000000002', 'E', '2022-09-03', 'O', '20210026', 'S', 'S000000003', '587.88', '2022-06-21', 'C', '', 'CASH', '2022-09-03', '0', '2022-09-03 14:20:29');

-- ----------------------------
-- Table structure for expresh
-- ----------------------------
DROP TABLE IF EXISTS `expresh`;
CREATE TABLE `expresh` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `edate` date DEFAULT NULL,
  `slmncode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `docno` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `totalamt` decimal(15,2) DEFAULT NULL,
  `lprint` tinyint(4) DEFAULT NULL,
  `lfinal` tinyint(4) DEFAULT NULL,
  `user` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`),
  KEY `in1` (`transno`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of expresh
-- ----------------------------
INSERT INTO `expresh` VALUES ('1', 'E000000001', 'E', '2022-06-21', 'B', '1234', '12620.00', null, null, '1', '0', '2022-06-21 02:25:17');
INSERT INTO `expresh` VALUES ('2', 'E000000002', 'E', '2022-09-03', 'O', '2322', '587.88', null, null, '1', '0', '2022-09-03 14:20:29');

-- ----------------------------
-- Table structure for itempricehis
-- ----------------------------
DROP TABLE IF EXISTS `itempricehis`;
CREATE TABLE `itempricehis` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `grscost` decimal(15,2) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `apricec` decimal(15,2) DEFAULT '0.00',
  `apriceb` decimal(15,2) DEFAULT '0.00',
  `apricep` decimal(15,2) DEFAULT '0.00',
  `bpricec` decimal(15,2) DEFAULT '0.00',
  `bpriceb` decimal(15,2) DEFAULT '0.00',
  `bpricep` decimal(15,2) DEFAULT '0.00',
  `cpricec` decimal(15,2) DEFAULT '0.00',
  `cpriceb` decimal(15,2) DEFAULT '0.00',
  `cpricep` decimal(15,2) DEFAULT '0.00',
  `dpricec` decimal(15,2) DEFAULT '0.00',
  `dpriceb` decimal(15,2) DEFAULT '0.00',
  `dpricep` decimal(15,2) DEFAULT '0.00',
  `epricec` decimal(15,2) DEFAULT '0.00',
  `epriceb` decimal(15,2) DEFAULT '0.00',
  `epricep` decimal(15,2) DEFAULT '0.00',
  `obsolet` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `lastpurc` date DEFAULT NULL,
  `discpct` int(10) DEFAULT NULL,
  `wtkg` decimal(15,2) DEFAULT NULL,
  `unitc` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitb` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitp` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `status` int(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of itempricehis
-- ----------------------------

-- ----------------------------
-- Table structure for itempricehistory
-- ----------------------------
DROP TABLE IF EXISTS `itempricehistory`;
CREATE TABLE `itempricehistory` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `grscost` decimal(15,2) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `apricec` decimal(15,2) DEFAULT '0.00',
  `apriceb` decimal(15,2) DEFAULT '0.00',
  `apricep` decimal(15,2) DEFAULT '0.00',
  `bpricec` decimal(15,2) DEFAULT '0.00',
  `bpriceb` decimal(15,2) DEFAULT '0.00',
  `bpricep` decimal(15,2) DEFAULT '0.00',
  `cpricec` decimal(15,2) DEFAULT '0.00',
  `cpriceb` decimal(15,2) DEFAULT '0.00',
  `cpricep` decimal(15,2) DEFAULT '0.00',
  `dpricec` decimal(15,2) DEFAULT '0.00',
  `dpriceb` decimal(15,2) DEFAULT '0.00',
  `dpricep` decimal(15,2) DEFAULT '0.00',
  `epricec` decimal(15,2) DEFAULT '0.00',
  `epriceb` decimal(15,2) DEFAULT '0.00',
  `epricep` decimal(15,2) DEFAULT '0.00',
  `obsolet` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `lastpurc` date DEFAULT NULL,
  `discpct` int(10) DEFAULT NULL,
  `wtkg` decimal(15,2) DEFAULT NULL,
  `unitc` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitb` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitp` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `status` int(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of itempricehistory
-- ----------------------------

-- ----------------------------
-- Table structure for item_price_history
-- ----------------------------
DROP TABLE IF EXISTS `item_price_history`;
CREATE TABLE `item_price_history` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `grscost` decimal(15,2) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `apricec` decimal(15,2) DEFAULT '0.00',
  `apriceb` decimal(15,2) DEFAULT '0.00',
  `apricep` decimal(15,2) DEFAULT '0.00',
  `bpricec` decimal(15,2) DEFAULT '0.00',
  `bpriceb` decimal(15,2) DEFAULT '0.00',
  `bpricep` decimal(15,2) DEFAULT '0.00',
  `cpricec` decimal(15,2) DEFAULT '0.00',
  `cpriceb` decimal(15,2) DEFAULT '0.00',
  `cpricep` decimal(15,2) DEFAULT '0.00',
  `dpricec` decimal(15,2) DEFAULT '0.00',
  `dpriceb` decimal(15,2) DEFAULT '0.00',
  `dpricep` decimal(15,2) DEFAULT '0.00',
  `epricec` decimal(15,2) DEFAULT '0.00',
  `epriceb` decimal(15,2) DEFAULT '0.00',
  `epricep` decimal(15,2) DEFAULT '0.00',
  `obsolet` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `lastpurc` date DEFAULT NULL,
  `discpct` int(10) DEFAULT NULL,
  `wtkg` decimal(15,2) DEFAULT NULL,
  `unitc` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitb` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitp` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `status` int(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of item_price_history
-- ----------------------------

-- ----------------------------
-- Table structure for ivalltrans
-- ----------------------------
DROP TABLE IF EXISTS `ivalltrans`;
CREATE TABLE `ivalltrans` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL DEFAULT '',
  `intrans` varchar(11) DEFAULT NULL,
  `outrans` varchar(11) DEFAULT NULL,
  `ttype` varchar(1) DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `whscode` varchar(5) DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(15) DEFAULT NULL,
  `itemcode` varchar(20) DEFAULT NULL,
  `qty` int(10) DEFAULT NULL,
  `qunit` varchar(1) DEFAULT '',
  `pckg` int(10) DEFAULT NULL,
  `pricetype` varchar(1) DEFAULT NULL,
  `uprice` decimal(15,2) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `rrindex` tinyint(4) DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivalltrans
-- ----------------------------

-- ----------------------------
-- Table structure for ivd
-- ----------------------------
DROP TABLE IF EXISTS `ivd`;
CREATE TABLE `ivd` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `transno` varchar(15) CHARACTER SET utf8 NOT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL COMMENT '''i'' - stockin, ''o'' - stock out, ''b'' - bad order, ''t'' - transfer',
  `tdate` date DEFAULT NULL,
  `whscode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `towhs` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `supcode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `supplier` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `itemcode` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `qty` int(10) DEFAULT NULL,
  `qunit` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `pckg` int(10) DEFAULT NULL,
  `cost` decimal(15,2) DEFAULT '0.00',
  `price` decimal(15,2) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `seqno` int(5) DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=138 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivd
-- ----------------------------
INSERT INTO `ivd` VALUES ('1', 'I000000001', 'I', '2022-06-21', 'YLK', null, 'GSPI', null, 'W52', '50', 'C', '150', '0.00', '900.00', '45000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('2', 'I000000001', 'I', '2022-06-21', 'YLK', null, 'GSPI', null, 'WW52', '100', 'C', '150', '0.00', '910.00', '91000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('3', 'I000000001', 'I', '2022-06-21', 'YLK', null, 'GSPI', null, 'WTC52', '150', 'C', '150', '0.00', '900.00', '135000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('4', 'O000000002', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GB80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('5', 'O000000002', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GBR80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('6', 'O000000002', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GP80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('7', 'O000000002', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GW80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('8', 'O000000002', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'MSK', '2', 'C', '40', '0.00', '480.00', '960.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('9', 'O000000002', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'MKS', '2', 'C', '40', '0.00', '480.00', '960.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('10', 'O000000003', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GB80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('11', 'O000000003', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GP80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('12', 'O000000003', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GBR80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('13', 'O000000003', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'GW80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('14', 'O000000003', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'MKS', '2', 'C', '40', '0.00', '480.00', '960.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('15', 'O000000003', 'O', '2022-06-24', 'YLK', null, 'GSPI', null, 'MSK', '2', 'C', '40', '0.00', '480.00', '960.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('16', 'I000000002', 'I', '2022-07-15', 'WHS2', null, 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('17', 'I000000003', 'I', '2022-07-15', 'WHS1', null, 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('18', 'I000000003', 'I', '2022-07-15', 'WHS1', null, 'GSPI', null, 'GBR80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('19', 'I000000003', 'I', '2022-07-15', 'WHS1', null, 'GSPI', null, 'GP80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('20', 'I000000004', 'I', '2022-07-18', 'WHS8', null, 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('21', 'I000000004', 'I', '2022-07-18', 'WHS8', null, 'GSPI', null, 'GBR80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('22', 'I000000004', 'I', '2022-07-18', 'WHS8', null, 'GSPI', null, 'GP80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('23', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'GB80', '6', 'C', '72', '0.00', '1176.00', '7056.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('24', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'GBR80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('25', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'GP80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('26', 'T000000001', 'T', '2022-07-18', 'WHS8', 'WHS9', 'GSPI', null, 'GB80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('27', 'T000000001', 'T', '2022-07-18', 'WHS8', 'WHS9', 'GSPI', null, 'GBR80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('28', 'T000000001', 'T', '2022-07-18', 'WHS8', 'WHS9', 'GSPI', null, 'GP80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('29', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'MSK', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('30', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'MKS', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('31', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'MMA', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('32', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'MAB', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('33', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'MPS', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('34', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'MSD', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('35', 'I000000005', 'I', '2022-07-18', '3AW', null, 'GSPI', null, 'W52', '12', 'C', '150', '0.00', '900.00', '10800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('36', 'T000000003', 'T', '2022-07-18', 'WHS8', 'WHS14', 'GSPI', null, 'GB80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('37', 'T000000003', 'T', '2022-07-18', 'WHS8', 'WHS14', 'GSPI', null, 'GBR80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('38', 'T000000003', 'T', '2022-07-18', 'WHS8', 'WHS14', 'GSPI', null, 'GP80', '5', 'P', '1', '0.00', '16.33', '81.65', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('39', 'O000000005', 'O', '2022-07-18', 'YLK', null, 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('40', 'T000000004', 'T', '2022-07-18', 'YLK', 'WHS9', 'GSPI', null, 'GB80', '5', 'C', '72', '0.00', '1176.00', '5880.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('41', 'T000000004', 'T', '2022-07-18', 'YLK', 'WHS9', 'GSPI', null, 'GBR80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('42', 'T000000004', 'T', '2022-07-18', 'YLK', 'WHS9', 'GSPI', null, 'GP80', '10', 'P', '1', '0.00', '16.33', '163.30', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('43', 'I000000006', 'I', '2022-07-18', 'WHS11', null, 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('44', 'I000000006', 'I', '2022-07-18', 'WHS11', null, 'GSPI', null, 'GBR80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('45', 'I000000006', 'I', '2022-07-18', 'WHS11', null, 'GSPI', null, 'GP80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('46', 'T000000005', 'T', '2022-07-18', 'WHS11', 'WHS9', 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('47', 'T000000005', 'T', '2022-07-18', 'WHS11', 'WHS9', 'GSPI', null, 'GBR80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('48', 'T000000005', 'T', '2022-07-18', 'WHS11', 'WHS9', 'GSPI', null, 'GP80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('49', 'I000000007', 'I', '2022-07-18', 'WHS13', null, 'GSPI', null, 'W52', '10', 'C', '150', '0.00', '900.00', '9000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('50', 'I000000007', 'I', '2022-07-18', 'WHS13', null, 'GSPI', null, 'WW52', '10', 'C', '150', '0.00', '910.00', '9100.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('51', 'I000000007', 'I', '2022-07-18', 'WHS13', null, 'GSPI', null, 'WTC52', '10', 'C', '150', '0.00', '900.00', '9000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('52', 'T000000006', 'T', '2022-07-18', 'YLK', 'WHS14', 'GSPI', null, 'MKS', '1', 'B', '5', '0.00', '60.00', '60.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('53', 'T000000006', 'T', '2022-07-18', 'YLK', 'WHS14', 'GSPI', null, 'MSK', '1', 'B', '5', '0.00', '60.00', '60.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('54', 'T000000007', 'T', '2022-07-18', 'YLK', 'WHS14', 'GSPI', null, 'W52', '10', 'C', '150', '0.00', '900.00', '9000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('55', 'I000000008', 'I', '2022-07-19', 'WHS15', null, 'GSPI', null, 'W52', '300', 'P', '1', '0.00', '6.00', '1800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('56', 'I000000008', 'I', '2022-07-19', 'WHS15', null, 'GSPI', null, 'WW52', '300', 'P', '1', '0.00', '6.07', '1821.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('57', 'I000000008', 'I', '2022-07-19', 'WHS15', null, 'GSPI', null, 'WTC52', '300', 'P', '1', '0.00', '6.00', '1800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('58', 'I000000008', 'I', '2022-07-19', 'WHS15', null, 'GSPI', null, 'GP80', '144', 'P', '1', '0.00', '16.33', '2351.52', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('59', 'I000000008', 'I', '2022-07-19', 'WHS15', null, 'GSPI', null, 'GW80', '144', 'P', '1', '0.00', '16.33', '2351.52', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('60', 'I000000009', 'I', '2022-07-19', 'WHS14', null, 'GSPI', null, 'MKS', '1', 'P', '1', '0.00', '12.00', '12.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('61', 'I000000009', 'I', '2022-07-19', 'WHS17', null, 'GSPI', null, 'MSK', '1', 'P', '1', '0.00', '12.00', '12.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('62', 'I000000009', 'I', '2022-07-19', 'WHS17', null, 'GSPI', null, 'MSD', '1', 'P', '1', '0.00', '12.00', '12.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('63', 'I000000010', 'I', '2022-07-20', 'WHS14', null, 'GSPI', null, 'W52', '140', 'C', '150', '0.00', '900.00', '126000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('64', 'I000000010', 'I', '2022-07-20', 'WHS14', null, 'GSPI', null, 'WW52', '1', 'C', '150', '0.00', '910.00', '910.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('65', 'I000000010', 'I', '2022-07-20', 'WHS14', null, 'GSPI', null, 'WTC52', '10', 'C', '150', '0.00', '900.00', '9000.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('66', 'I000000011', 'I', '2022-07-20', 'WHS15', null, 'GSPI', null, 'MAB', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('67', 'I000000011', 'I', '2022-07-20', 'WHS15', null, 'GSPI', null, 'MMA', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('68', 'I000000011', 'I', '2022-07-20', 'WHS15', null, 'GSPI', null, 'MSK', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('69', 'I000000011', 'I', '2022-07-20', 'WHS15', null, 'GSPI', null, 'MKS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('70', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'MAB', '1', 'B', '5', '0.00', '60.00', '60.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('71', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'MMA', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('72', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'MSK', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('73', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'MKS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('74', 'I000000009', 'I', '2022-07-19', 'WHS17', null, 'GSPI', null, 'MAB', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('75', 'I000000009', 'I', '2022-07-19', 'WHS17', null, 'GSPI', null, 'MMA', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('76', 'I000000009', 'I', '2022-07-19', 'WHS17', null, 'GSPI', null, 'MKS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('77', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'W52', '1', 'C', '150', '0.00', '900.00', '900.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('78', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'TW10\'S', '1', 'C', '360', '0.00', '1386.00', '1386.00', null, '0', null, '2022-08-04 06:32:07');
INSERT INTO `ivd` VALUES ('79', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'TBR10\'S', '1', 'C', '360', '0.00', '1386.00', '1386.00', null, '0', null, '2022-08-04 06:32:31');
INSERT INTO `ivd` VALUES ('80', 'I000000012', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'TBD10\'S', '2', 'C', '360', '0.00', '1386.00', '2772.00', null, '0', null, '2022-08-04 06:32:57');
INSERT INTO `ivd` VALUES ('81', 'I000000013', 'I', '2022-07-20', 'WHS21', null, 'GSPI', null, 'MAB', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('82', 'I000000013', 'I', '2022-07-20', 'WHS17', null, 'GSPI', null, 'MMA', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('83', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'MSD', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('84', 'O000000006', 'O', '2022-07-20', 'WHS17', null, 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('85', 'O000000006', 'O', '2022-07-20', 'WHS17', null, 'GSPI', null, 'GBR80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('86', 'O000000005', 'O', '2022-07-18', 'YLK', null, 'GSPI', null, 'GP80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('87', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS18', 'GSPI', null, 'W52', '2', 'C', '150', '0.00', '900.00', '1800.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('88', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS18', 'GSPI', null, 'WW52', '2', 'C', '150', '0.00', '910.00', '1820.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('89', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS18', 'GSPI', null, 'WTC52', '2', 'C', '150', '0.00', '900.00', '1800.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('90', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS17', 'GSPI', null, 'GB80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('91', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS18', 'GSPI', null, 'GBR80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('92', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS18', 'GSPI', null, 'GW80', '4', 'C', '72', '0.00', '1176.00', '4704.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('93', 'T000000008', 'T', '2022-07-20', 'YLK', 'WHS18', 'GSPI', null, 'TBR10\'S', '1', 'B', '10', '0.00', '38.50', '38.50', null, '1', null, '2022-08-04 06:32:31');
INSERT INTO `ivd` VALUES ('94', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'MAB', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('95', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'MPS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('96', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'MMA', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('97', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('98', 'I000000013', 'I', '2022-07-20', 'WHS21', null, 'GSPI', null, 'GB80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('99', 'I000000013', 'I', '2022-07-20', 'WHS21', null, 'GSPI', null, 'GBR80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('100', 'I000000013', 'I', '2022-07-20', 'WHS21', null, 'GSPI', null, 'GW80', '2', 'C', '72', '0.00', '1176.00', '2352.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('101', 'T000000003', 'T', '2022-07-18', 'WHS8', 'WHS14', 'GSPI', null, 'GP80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('102', 'T000000002', 'T', '2022-07-18', 'YLK', 'WHS21', 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('103', 'T000000009', 'T', '2022-07-22', 'YLK', 'WHS9', 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('104', 'T000000009', 'T', '2022-07-22', 'YLK', 'WHS9', 'GSPI', null, 'GBR80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('105', 'T000000009', 'T', '2022-07-22', 'YLK', 'WHS9', 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('106', 'T000000010', 'T', '2022-07-22', 'YLK', 'WHS9', 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('107', 'T000000010', 'T', '2022-07-22', 'YLK', 'WHS9', 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('108', 'T000000010', 'T', '2022-07-22', 'YLK', 'WHS9', 'GSPI', null, 'GB80', '1', 'C', '72', '0.00', '1176.00', '1176.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('109', 'O000000005', 'O', '2022-07-18', 'YLK', null, 'GSPI', null, 'GB80', '10', 'C', '72', '0.00', '1176.00', '11760.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('110', 'O000000004', 'O', '2022-07-18', 'WHS9', null, 'GSPI', null, 'MPS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('111', 'I000000013', 'I', '2022-07-20', 'WHS21', null, 'GSPI', null, 'MSK', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('112', 'I000000014', 'I', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MAB', '10', 'C', '40', '0.00', '480.00', '4800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('113', 'I000000014', 'I', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MSK', '10', 'C', '40', '0.00', '480.00', '4800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('114', 'I000000014', 'I', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MSD', '10', 'C', '40', '0.00', '480.00', '4800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('115', 'I000000014', 'I', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MKS', '10', 'C', '40', '0.00', '480.00', '4800.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('116', 'O000000007', 'O', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MAB', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('117', 'O000000007', 'O', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MSK', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('118', 'O000000007', 'O', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MSD', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('119', 'O000000007', 'O', '2022-07-22', 'WHS17', null, 'GSPI', null, 'MKS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('120', 'T000000011', 'T', '2022-07-22', 'WHS17', 'WHS23', 'GSPI', null, 'MAB', '2', 'C', '40', '0.00', '480.00', '960.00', null, '0', null, '2022-08-04 02:55:12');
INSERT INTO `ivd` VALUES ('121', 'T000000011', 'T', '2022-07-22', 'WHS17', 'WHS23', 'GSPI', null, 'MSD', '1', 'C', '40', '0.00', '480.00', '480.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('122', 'T000000011', 'T', '2022-07-22', 'WHS17', 'WHS23', 'GSPI', null, 'MKS', '1', 'C', '40', '0.00', '480.00', '480.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('123', 'I000000015', 'I', '2022-07-27', 'WHS15', null, 'GSPI', null, 'W52', '75', 'P', '1', '0.00', '6.00', '450.00', null, '0', null, '2022-08-04 02:45:09');
INSERT INTO `ivd` VALUES ('124', 'O000000008', 'O', '2022-07-27', 'WHS15', null, 'GSPI', null, 'WTC52', '1', 'C', '150', '0.00', '900.00', '900.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('125', 'O000000009', 'O', '2022-07-27', 'WHS15', null, 'GSPI', null, 'WTC52', '2', 'C', '150', '0.00', '900.00', '1800.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('126', 'O000000010', 'O', '2022-07-27', 'WHS15', null, 'GSPI', null, 'WTC52', '2', 'C', '150', '0.00', '900.00', '1800.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('127', 'O000000011', 'O', '2022-08-02', 'WHS15', null, 'GSPI', null, 'WW52', '150', 'P', '1', '0.00', '6.07', '910.50', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('128', 'O000000012', 'O', '2022-08-02', 'WHS15', null, 'GSPI', null, 'W52', '1', 'C', '150', '0.00', '900.00', '900.00', null, '0', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('129', 'O000000012', 'O', '2022-08-02', 'WHS15', null, 'GSPI', null, 'W52', '1', 'C', '150', '0.00', '900.00', '900.00', null, '1', null, '2022-08-03 02:41:43');
INSERT INTO `ivd` VALUES ('130', 'O000000007', 'O', '2022-07-22', 'WHS17', null, 'GSPI', null, 'TBR10\'S', '1', 'C', '360', '0.00', '1386.00', '1386.00', null, '0', null, '2022-08-04 06:32:31');
INSERT INTO `ivd` VALUES ('131', 'O000000007', 'O', '2022-07-22', 'WHS17', null, 'GSPI', null, 'TBR10\'S', '1', 'C', '360', '0.00', '1386.00', '1386.00', null, '0', null, '2022-08-04 06:32:31');
INSERT INTO `ivd` VALUES ('132', 'I000000016', 'I', '2022-08-04', 'WHS15', null, 'GSPI', null, 'W52', '10', 'C', '150', '0.00', '900.00', '9000.00', null, '1', null, '2022-08-04 02:45:56');
INSERT INTO `ivd` VALUES ('133', 'I000000017', 'I', '2022-08-04', 'WHS15', null, 'GSPI', null, 'W52', '10', 'C', '150', '0.00', '900.00', '9000.00', null, '1', null, '2022-08-04 02:46:34');
INSERT INTO `ivd` VALUES ('134', 'I000000017', 'I', '2022-08-04', 'WHS15', null, 'GSPI', null, 'WW52', '10', 'C', '150', '0.00', '910.00', '9100.00', null, '0', null, '2022-08-04 02:46:34');
INSERT INTO `ivd` VALUES ('135', 'T000000012', 'T', '2022-09-03', 'YLK', 'WHS1', 'GSPI', null, 'W52', '1', 'C', '150', '0.00', '900.00', '900.00', null, '0', null, '2022-09-03 14:01:22');
INSERT INTO `ivd` VALUES ('136', 'T000000012', 'T', '2022-09-03', 'YLK', 'WHS1', 'GSPI', null, 'WW52', '1', 'C', '150', '0.00', '910.00', '910.00', null, '0', null, '2022-09-03 14:01:22');
INSERT INTO `ivd` VALUES ('137', 'B000000014', 'B', '2022-09-04', 'YLK', null, 'GSPI', null, 'W52', '1', 'C', '150', '0.00', '900.00', '900.00', null, '0', null, '2022-09-04 02:46:27');

-- ----------------------------
-- Table structure for ivh
-- ----------------------------
DROP TABLE IF EXISTS `ivh`;
CREATE TABLE `ivh` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(15) CHARACTER SET utf8 NOT NULL,
  `ttype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `docno` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `whscode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `whsfromname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `towhs` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `whstoname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `supcode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `supplier` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `updated` tinyint(4) DEFAULT NULL,
  `lprint` tinyint(4) DEFAULT NULL,
  `lsummary` tinyint(4) DEFAULT NULL,
  `subtot` decimal(15,2) DEFAULT NULL,
  `discstr` decimal(15,2) DEFAULT NULL,
  `discamt` decimal(15,2) DEFAULT NULL,
  `total` decimal(15,2) DEFAULT NULL,
  `remarks` varchar(300) CHARACTER SET utf8 DEFAULT NULL,
  `pricetype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `userid` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT NULL,
  `isdeleted` varchar(1) CHARACTER SET utf8 DEFAULT '0',
  `isopen` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isopenby` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=44 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivh
-- ----------------------------
INSERT INTO `ivh` VALUES ('1', 'I000000001', 'I', null, '2022-06-21', 'YLK', null, null, null, 'GSPI', null, null, null, null, null, null, null, '271000.00', 'TEST1', 'A', '1', null, '0', null, null, '2022-06-21 07:28:19');
INSERT INTO `ivh` VALUES ('2', 'O000000002', 'O', null, '2022-06-24', 'YLK', null, null, null, 'GSPI', null, null, null, null, null, null, null, '11328.00', 'TEST', 'A', '1', null, '1', null, null, '2022-06-24 07:25:45');
INSERT INTO `ivh` VALUES ('3', 'O000000003', 'O', null, '2022-06-24', 'YLK', null, null, null, 'GSPI', null, null, null, null, null, null, null, '11328.00', 'TEST', 'A', '1', null, '1', null, null, '2022-06-24 07:28:26');
INSERT INTO `ivh` VALUES ('4', 'I000000002', 'I', null, '2022-07-15', 'WHS2', null, null, null, 'GSPI', null, null, null, null, null, null, null, '11760.00', 'TEST', 'A', '1', null, '0', null, null, '2022-07-15 07:55:39');
INSERT INTO `ivh` VALUES ('5', 'I000000003', 'I', null, '2022-07-15', 'WHS1', null, null, null, 'GSPI', null, null, null, null, null, null, null, '35280.00', 'TEST', 'A', '1', null, '0', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivh` VALUES ('6', 'I000000004', 'I', null, '2022-07-18', 'WHS8', null, null, null, 'GSPI', null, null, null, null, null, null, null, '23520.00', 'TEST', 'A', '1', null, '0', null, null, '2022-07-21 07:06:52');
INSERT INTO `ivh` VALUES ('7', 'O000000004', 'O', null, '2022-07-18', 'WHS9', null, null, null, 'GSPI', null, null, null, null, null, null, null, '14856.00', 'TEST', 'A', '1', null, '0', null, null, '2022-07-21 05:36:03');
INSERT INTO `ivh` VALUES ('8', 'T000000001', 'T', null, '2022-07-18', 'WHS8', 'WAREHOUSE 8', 'WHS9', 'WAREHOUSE 9', 'GSPI', null, null, null, null, null, null, null, '17640.00', null, 'A', '1', null, '1', null, null, '2022-07-18 07:48:22');
INSERT INTO `ivh` VALUES ('9', 'T000000002', 'T', null, '2022-07-18', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS21', 'WAREHOUSE 21', 'GSPI', null, null, null, null, null, null, null, '6936.00', 'TRANSFER-WHS21', 'A', '1', null, '0', null, null, '2022-07-22 06:08:32');
INSERT INTO `ivh` VALUES ('10', 'I000000005', 'I', null, '2022-07-18', '3AW', null, null, null, 'GSPI', null, null, null, null, null, null, null, '10800.00', 'DSTSD', 'A', '1', null, '0', null, null, '2022-07-18 07:22:36');
INSERT INTO `ivh` VALUES ('11', 'T000000003', 'T', null, '2022-07-18', 'WHS8', 'WAREHOUSE 8', 'WHS14', 'WAREHOUSE 14', 'GSPI', null, null, null, null, null, null, null, '7137.65', 'TRANSFER-WHS14', 'A', '1', null, '0', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivh` VALUES ('12', 'O000000005', 'O', null, '2022-07-18', 'YLK', null, null, null, 'GSPI', null, null, null, null, null, null, null, '11760.00', 'TEST', 'A', '1', null, '0', '0', '1', '2022-09-03 13:47:32');
INSERT INTO `ivh` VALUES ('13', 'T000000004', 'T', null, '2022-07-18', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS9', 'WAREHOUSE 9', 'GSPI', null, null, null, null, null, null, null, '11923.30', 'TRANSFER-WHS9', 'A', '1', null, '0', null, null, '2022-07-22 02:04:27');
INSERT INTO `ivh` VALUES ('14', 'I000000006', 'I', null, '2022-07-18', 'WHS11', null, null, null, 'GSPI', null, null, null, null, null, null, null, '35280.00', 'HH', 'A', '1', null, '0', null, null, '2022-07-18 08:10:27');
INSERT INTO `ivh` VALUES ('15', 'T000000005', 'T', null, '2022-07-18', 'WHS11', 'WAREHOUSE 11', 'WHS9', 'WAREHOUSE 9', 'GSPI', null, null, null, null, null, null, null, '23520.00', 'TRANSFER-WHS9', 'A', '1', null, '0', '1', '1', '2022-09-03 14:00:45');
INSERT INTO `ivh` VALUES ('16', 'I000000007', 'I', null, '2022-07-18', 'WHS13', null, null, null, 'GSPI', null, null, null, null, null, null, null, '27100.00', 'ASDF', 'A', '1', null, '0', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivh` VALUES ('17', 'T000000006', 'T', null, '2022-07-18', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS14', 'WAREHOUSE 14', 'GSPI', null, null, null, null, null, null, null, '120.00', 'TRANSFER-WHS14', 'A', '1', null, '0', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivh` VALUES ('18', 'T000000007', 'T', null, '2022-07-18', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS14', 'WAREHOUSE 14', 'GSPI', null, null, null, null, null, null, null, '9000.00', 'TRANSFER-WHS14', 'A', '1', null, '0', null, null, '2022-07-18 08:32:08');
INSERT INTO `ivh` VALUES ('19', 'I000000008', 'I', null, '2022-07-19', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '10124.04', 'DSFASD', 'A', '1', null, '0', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivh` VALUES ('20', 'I000000009', 'I', null, '2022-07-19', 'WHS17', null, null, null, 'GSPI', null, null, null, null, null, null, null, '1464.00', '', 'A', '1', null, '0', null, null, '2022-07-20 01:44:24');
INSERT INTO `ivh` VALUES ('21', 'I000000010', 'I', null, '2022-07-20', 'WHS14', null, null, null, 'GSPI', null, null, null, null, null, null, null, '135910.00', 'TEST TEST', 'A', '1', null, '0', null, null, '2022-07-20 01:34:14');
INSERT INTO `ivh` VALUES ('22', 'I000000011', 'I', null, '2022-07-20', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '1920.00', 'DFSD', 'A', '1', null, '0', null, null, '2022-07-20 01:41:52');
INSERT INTO `ivh` VALUES ('23', 'I000000012', 'I', null, '2022-07-20', 'WHS17', null, null, null, 'GSPI', null, null, null, null, null, null, null, '6984.00', 'FDFD', 'A', '1', null, '0', null, null, '2022-07-20 06:13:53');
INSERT INTO `ivh` VALUES ('24', 'I000000013', 'I', null, '2022-07-20', 'WHS21', null, null, null, 'GSPI', null, null, null, null, null, null, null, '7536.00', '', 'A', '1', null, '0', '1', '1', '2022-09-03 13:47:36');
INSERT INTO `ivh` VALUES ('25', 'O000000006', 'O', null, '2022-07-20', 'WHS17', null, null, null, 'GSPI', null, null, null, null, null, null, null, '2352.00', '', 'A', '1', null, '0', '0', '1', '2022-09-03 13:47:10');
INSERT INTO `ivh` VALUES ('26', 'T000000008', 'T', null, '2022-07-20', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS18', 'WAREHOUSE 18', 'GSPI', null, null, null, null, null, null, null, '12514.50', 'TRANSFER-WHS18', 'A', '1', null, '1', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivh` VALUES ('27', 'T000000009', 'T', null, '2022-07-22', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS9', 'WAREHOUSE 9', 'GSPI', null, null, null, null, null, null, null, '2352.00', 'TRANSFER-WHS9', 'A', '1', null, '0', null, null, '2022-07-22 02:21:07');
INSERT INTO `ivh` VALUES ('28', 'T000000010', 'T', null, '2022-07-22', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS9', 'WAREHOUSE 9', 'GSPI', null, null, null, null, null, null, null, '1176.00', 'TRANSFER-WHS9', 'A', '1', null, '0', null, null, '2022-07-22 08:05:38');
INSERT INTO `ivh` VALUES ('29', 'I000000014', 'I', null, '2022-07-22', 'WHS17', null, null, null, 'GSPI', null, null, null, null, null, null, null, '19200.00', '', 'A', '1', null, '0', '0', '1', '2022-09-03 14:17:46');
INSERT INTO `ivh` VALUES ('30', 'O000000007', 'O', null, '2022-07-22', 'WHS17', null, null, null, 'GSPI', null, null, null, null, null, null, null, '4212.00', '', 'A', '1', null, '0', '0', '1', '2022-09-03 13:47:06');
INSERT INTO `ivh` VALUES ('31', 'T000000011', 'T', null, '2022-07-22', 'WHS17', 'WAREHOUSE 17', 'WHS23', 'WAREHOUSE 23', 'GSPI', null, null, null, null, null, null, null, '1440.00', 'TRANSFER-WHS23', 'A', '1', null, '0', '1', '1', '2022-08-04 02:52:15');
INSERT INTO `ivh` VALUES ('32', 'I000000015', 'I', null, '2022-07-27', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '450.00', 'ASDF', 'A', '1', null, '0', '1', '1', '2022-08-04 02:45:09');
INSERT INTO `ivh` VALUES ('33', 'O000000008', 'O', null, '2022-07-27', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '900.00', 'ASDF', 'A', '1', null, '1', null, null, '2022-07-27 07:02:00');
INSERT INTO `ivh` VALUES ('34', 'O000000009', 'O', null, '2022-07-27', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '1800.00', 'TEST', 'A', '1', null, '1', null, null, '2022-07-27 07:16:56');
INSERT INTO `ivh` VALUES ('35', 'O000000010', 'O', null, '2022-07-27', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '1800.00', 'TEST', 'A', '1', null, '1', null, null, '2022-07-27 07:45:39');
INSERT INTO `ivh` VALUES ('36', 'O000000011', 'O', null, '2022-08-02', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '910.50', 'SDF', 'A', '1', null, '1', '1', '1', '2022-08-02 06:24:03');
INSERT INTO `ivh` VALUES ('37', 'O000000012', 'O', null, '2022-08-02', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '900.00', 'SADF', 'A', '1', null, '0', '0', '1', '2022-09-03 13:47:02');
INSERT INTO `ivh` VALUES ('38', 'I000000016', 'I', null, '2022-08-04', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '9000.00', 'ASDF', 'A', '1', null, '1', '1', '1', '2022-08-04 02:45:56');
INSERT INTO `ivh` VALUES ('39', 'I000000017', 'I', null, '2022-08-04', 'WHS15', null, null, null, 'GSPI', null, null, null, null, null, null, null, '9100.00', 'SDF', 'A', '1', null, '0', '0', '1', '2022-09-03 13:46:47');
INSERT INTO `ivh` VALUES ('40', 'T000000012', 'T', null, '2022-09-03', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'WHS1', 'WAREHOUSE 1', 'GSPI', null, null, null, null, null, null, null, '1810.00', null, 'A', '1', null, '0', null, null, '2022-09-03 14:01:22');
INSERT INTO `ivh` VALUES ('42', 'B000000013', 'B', null, '2022-09-04', 'YLK', null, null, null, 'GSPI', null, null, null, null, null, null, null, '900.00', 'TEST', 'A', '1', null, '1', null, null, '2022-09-04 02:46:02');
INSERT INTO `ivh` VALUES ('43', 'B000000014', 'B', null, '2022-09-04', 'YLK', null, null, null, 'GSPI', null, null, null, null, null, null, null, '900.00', 'TEST', 'A', '1', null, '0', null, null, '2022-09-04 02:46:27');

-- ----------------------------
-- Table structure for ivitem
-- ----------------------------
DROP TABLE IF EXISTS `ivitem`;
CREATE TABLE `ivitem` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `description` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `supcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `supplier` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `catcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `category` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `brcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `brand` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `unit` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `pckgc` int(10) DEFAULT NULL,
  `pckgb` int(10) DEFAULT NULL,
  `pckgp` int(10) DEFAULT NULL,
  `freeitem` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `grscost` decimal(15,2) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `apricec` decimal(15,2) DEFAULT '0.00',
  `apriceb` decimal(15,2) DEFAULT '0.00',
  `apricep` decimal(15,2) DEFAULT '0.00',
  `bpricec` decimal(15,2) DEFAULT '0.00',
  `bpriceb` decimal(15,2) DEFAULT '0.00',
  `bpricep` decimal(15,2) DEFAULT '0.00',
  `cpricec` decimal(15,2) DEFAULT '0.00',
  `cpriceb` decimal(15,2) DEFAULT '0.00',
  `cpricep` decimal(15,2) DEFAULT '0.00',
  `dpricec` decimal(15,2) DEFAULT '0.00',
  `dpriceb` decimal(15,2) DEFAULT '0.00',
  `dpricep` decimal(15,2) DEFAULT '0.00',
  `epricec` decimal(15,2) DEFAULT '0.00',
  `epriceb` decimal(15,2) DEFAULT '0.00',
  `epricep` decimal(15,2) DEFAULT '0.00',
  `obsolet` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `lastpurc` date DEFAULT NULL,
  `discpct` int(10) DEFAULT NULL,
  `wtkg` decimal(15,2) DEFAULT NULL,
  `unitc` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitb` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitp` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `status` int(1) DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=245 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivitem
-- ----------------------------
INSERT INTO `ivitem` VALUES ('1', 'HKG', 'KARGADO HOG GROWER 50KG', 'GM', 'GENERAL MILLING CORP.', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1465.00', '1465.00', '1465.00', '1465.00', '0.00', '1465.00', '1455.00', '0.00', '1455.00', '1445.00', '0.00', '1445.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('2', 'BCG', 'BOUNTY CHICK GROWER', 'GM', 'GENERAL MILLING CORP.', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1280.00', '0.00', '1280.00', '1270.00', '0.00', '1270.00', '1260.00', '0.00', '1260.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '500.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('3', 'KHPS', '[KARGADO] PRE STARTER PELLET 25KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1215.00', '1215.00', '1215.00', '1290.00', '0.00', '1290.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('4', 'KHS', '[KARGADO] HOG STARTER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1535.00', '1535.00', '1535.00', '1655.00', '0.00', '1655.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('5', 'KHG', '[KARGADO] HOG GROWER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1365.00', '1365.00', '1365.00', '1475.00', '0.00', '1475.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('6', 'KHF', '[KARGADO] HOG FINISHER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1340.00', '1340.00', '1340.00', '1465.00', '0.00', '1465.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('7', 'MMHL-GMC', 'MEGAMIX HOG LACTATING 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('8', 'MMHG-GMC', 'MEGAMIX HOG GESTATING 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('9', 'SPMHPS', 'S PIGGYMAX HOG PRE STARTER MINI PEL 25KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('10', 'MMHG', 'MEGAMIX HOG GESTATING PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1175.00', '1175.00', '1175.00', '1330.00', '0.00', '1330.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('11', 'MMHL', 'MEGAMIX HOG LACTAING PELLET 50GKG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '1385.00', '0.00', '1385.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('12', 'SMMHS', 'S MUSCLE MAX HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('13', 'SMMHG', 'S MUSCLE MAX HOG GROWER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('14', 'SMMHF', 'S MUSCLE MAX HOG FINISHER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1275.00', '1275.00', '1275.00', '1395.00', '0.00', '1395.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('15', 'SMMHP', 'S MUSCLE MAX HOG PREGGY PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1180.00', '1180.00', '1180.00', '1300.00', '0.00', '1300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('16', 'SMMHM', 'S MUCSLE MAX HOG MILKY PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1290.00', '1290.00', '1290.00', '1410.00', '0.00', '1410.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('17', 'PMJHS', 'P MEGA JACKPOT HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('18', 'PJMHG', 'P MEGA JACKPOT HOG GROWER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1165.00', '1165.00', '1165.00', '1285.00', '0.00', '1285.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('19', 'PMJHF', 'P MEGA JACKPOT HOG FINISHER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1125.00', '1125.00', '1125.00', '1245.00', '0.00', '1245.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('20', 'PMJHB', 'P MEGA JACKPOT HOG BROODSOW PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1075.00', '1075.00', '1075.00', '1195.00', '0.00', '1195.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('21', 'PMJHL', 'P MEGA JACKPOT HOG LACTATION PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('22', 'PMJHPDP', 'P MEGA JACKPOT HPDP PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '920.00', '0.00', '920.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('23', 'L1', 'LEGION 1 (CHICK BOOSTER) 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1440.00', '1440.00', '1440.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('24', 'L2', 'LEGION 2 (CHICK GROWER) 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1270.00', '1270.00', '1270.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('25', 'L3', 'LEGION 3 (MAINTENACE) PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1120.00', '1120.00', '1120.00', '1240.00', '0.00', '1240.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('26', 'CLMC', 'CHICKEN LAYER MAX CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'LF ', 'LAYER FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1310.00', '0.00', '1310.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('27', 'PDL', 'PREMIUM DUCK CJ LAYER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'DF', 'DUCK FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1185.00', '1185.00', '1185.00', '1235.00', '0.00', '1235.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('28', 'BMB', 'BROILERMAX BOOSTER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('29', 'BMS', 'BROILERMAX STARTER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('30', 'BMG', 'BROILER MAX GROWER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('31', 'B+CLM', '[BOUNTY] CHICKEN LAYER MASH 50KG', 'B+', 'BOUNTY PLUS', 'LF ', 'LAYER FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1240.00', '1240.00', '1240.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('32', 'B+CGM', '[BOUNTY] CHICK GROWER MASH 50KG', 'B+', 'BOUNTY PLUS', 'LF ', 'LAYER FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1151.00', '1151.00', '1151.00', '1290.00', '0.00', '1290.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('33', 'VBCAA', 'VITAMIN B COMLEX+AMINO ACID(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '400.00', '400.00', '400.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('34', 'CP', 'CALCIUM PHOSPHORUS(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '280.00', '280.00', '280.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('35', 'PE', 'PURE ELECTROLYTE(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('36', 'IO', 'IVERMECTINE(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '820.00', '820.00', '820.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('37', 'A', 'AMPROLLIUM(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', 'BRAND NAME 1', 'C', '50', '1', '1', 'N', '1000.00', '1000.00', '20.00', '1100.00', '0.00', '22.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('38', 'TTGS', 'TYLOSIN TARTRATE+GENTAMICIN(ORAL)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '3', '0', '0', 'N', '2480.00', '2480.00', '620.00', '2480.00', '1240.00', '620.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('39', 'TTG', 'TYLOSIN TARTRATE+GENTAMICIN(ORAL)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1975.00', '1975.00', '493.75', '2480.00', '0.00', '620.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('40', 'TMPS', 'TMPS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '830.00', '830.00', '830.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('41', 'B', 'BELMET-ANTIMALARIA(ORAL)1LTR', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '675.00', '675.00', '675.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '740.00', '0.00', '740.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('42', 'G', 'GLUTAMED(LIQUID DISIFECTANT)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '220.00', '220.00', '220.00', '220.00', '0.00', '220.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('43', 'EG', 'EGG BOOSTER(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '630.00', '630.00', '630.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('44', 'NBP', 'NUTRA-B PLUS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '380.00', '380.00', '380.00', '450.00', '0.00', '450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('45', 'VC', 'VITAMIN-C(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '770.00', '770.00', '770.00', '870.00', '0.00', '870.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('46', 'CPO', 'CALCIUM PHOSPHORUS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '380.00', '380.00', '380.00', '450.00', '0.00', '450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('47', 'PEO', 'PURE ELECTROLYTE(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '170.00', '170.00', '170.00', '220.00', '0.00', '220.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('48', 'PEC', 'PURE ELECTROLYTE.(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '120.00', '120.00', '120.00', '170.00', '0.00', '170.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('49', 'VBCI', 'VITAMIN-B COMPLEX (INJECTABLE)100ML', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '230.00', '230.00', '230.00', '300.00', '0.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('50', 'O', 'OXYTOCIN', 'MD', 'MEDLAND', 'LSS', 'LIVE STOCK STIMULANT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('51', 'II', 'IVERMECTIN(INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '320.00', '320.00', '320.00', '370.00', '0.00', '370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('52', 'E10%', 'ENROFLOXACIN10% (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('53', 'E20%', 'ENROFLOXACIN20% (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '340.00', '340.00', '340.00', '390.00', '0.00', '390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('54', 'LSB', 'LSB(INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('55', 'LH', 'LINCOMYCIN HYDROCHLORIDE', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('56', 'IPM', 'IVERMECTIN1% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('57', 'LSBPM', 'LSB1% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('58', 'CSFPM', 'COLISTIN SULFATE10% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('59', 'LSBFMP', 'LSB1%. (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '700.00', '700.00', '700.00', '800.00', '0.00', '800.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('60', 'IFPM ', 'IVERMECTIN1%. (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '510.00', '510.00', '510.00', '610.00', '0.00', '610.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('61', 'HC', 'HEXAMIDE CREAM (ANTI SEPTIC CREAM)', 'BL', 'BELMAN LABORATORIES', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '38.00', '38.00', '38.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('62', 'CPFS', 'CECICAL POWDER (FEED SUPPLEMENT)', 'BL', 'BELMAN LABORATORIES', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '20.00', '20.00', '20.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('63', 'PP', 'PIDRO POWDER', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '23.00', '23.00', '23.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('64', 'MVE', 'MULTI VITAMINS (FOIL) 1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '200.00', '200.00', '200.00', '250.00', '0.00', '250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('65', 'ID', 'IRON DEXTRANT ', 'BL', 'BELMAN LABORATORIES', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '272.00', '0.00', '0.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('66', 'BN', 'BIO-NUTRILYTES                          ', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '520.00', '520.00', '520.00', '600.00', '0.00', '600.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('67', 'WO', 'WASH OUT', 'LDI', 'LAKPUE DRUGS INC', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '11.00', '11.00', '11.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('68', 'ZP', 'ZINC PHOSPHIDE (RAT POISON)', 'LDI', 'LAKPUE DRUGS INC', 'PI', 'PESTICIDE AND INSECTICIDE', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '22.00', '22.00', '22.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('69', 'MVEO', 'MULTI VITAMINS (ORAL) 1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '620.00', '620.00', '620.00', '700.00', '0.00', '700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('70', 'CSP', 'CHLOR SP (FEED SUPPLEMENT)', 'BL', 'BELMAN LABORATORIES', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '123.00', '123.00', '123.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('71', 'C', 'COMBINEX ANTI SEPTIC SPRAY (AEROSOL)', 'MD', 'MEDLAND', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '250.00', '250.00', '250.00', '300.00', '0.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('72', 'N20%', 'NORFLOXACIN20% (ORAL) 1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '830.00', '830.00', '830.00', '930.00', '0.00', '930.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('73', 'AT20%', 'AMOXICILLIN TRIHYDRATE (INJECTABLE)100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('74', 'MMHGR', 'MEGAMIX HOG GROWER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('75', 'SMB', 'SOYA-MIL (BAG)', 'IFMC', 'INOZA FEED MILLING CORP', 'FRM', 'FEED RAW MAATERIAL ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '4.00', '4.00', '4.00', '44.00', '0.00', '4.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('76', 'SMKG', 'SOYA-MIL (KG)', 'IFMC', 'INOZA FEED MILLING CORP', 'FRM', 'FEED RAW MAATERIAL ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '29.50', '29.50', '29.50', '32.50', '0.00', '32.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('77', 'TEST1', 'TEST MIC ONE TWO THREE', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '360', '10', '10', 'N', '500.00', '500.00', '1.39', '600.00', '16.70', '1.67', '610.00', '16.90', '1.69', '615.00', '17.10', '1.71', '620.00', '16.90', '1.72', '625.00', '17.40', '1.74', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('78', 'TEST2', 'TEST2 ASDFASDFASDFASDF', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '360', '10', '10', 'N', '600.00', '600.00', '1.67', '610.00', '16.90', '1.69', '620.00', '17.20', '1.72', '630.00', '17.50', '1.75', '640.00', '17.80', '1.78', '650.00', '18.10', '1.81', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('79', 'TEST3', 'ASDFASDFASDFASDF', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '360', '10', '10', 'N', '10000.00', '0.00', '0.00', '11000.00', '305.60', '30.56', '12000.00', '333.30', '33.33', '13000.00', '361.10', '36.11', '14000.00', '388.90', '38.89', '15000.00', '416.70', '41.67', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('80', 'TEST4', 'TEST DESCRIPTION 4', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '24', '1', '1', 'N', '700.00', '680.00', '28.33', '710.00', '0.00', '29.58', '720.00', '0.00', '30.00', '730.00', '0.00', '30.42', '740.00', '0.00', '30.83', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('81', 'VPB', 'VIEPRO PIGLET BOOSTER MINI PEL 25KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1390.00', '1390.00', '1390.00', '1465.00', '0.00', '1465.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('82', 'VPPS', 'VIEPRO PIGLET PRE STARTER MINI PEL 25KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '988.00', '988.00', '988.00', '1165.00', '0.00', '1165.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('83', 'VP PRI HS', 'VIEPRO PRIME HOG STARTER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1273.00', '1273.00', '1273.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('84', 'VP PRI HG', 'VIEPRO PRIME HOG GROWER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1206.50', '1206.50', '1206.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('85', 'VP PRI HF', 'VIEPRO PRIME HOG FINISHER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1159.00', '1159.00', '1159.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('86', 'VP PRI HGE', 'VIEPRO PRIME HOG GESTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1093.50', '1093.50', '1093.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('87', 'VP PRI HL', 'VIEPRO PRIME HOG LACTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1254.00', '1254.00', '1254.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('88', 'VP PRE HS', 'VIEPRO PREMIUM HOG STARTER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('89', 'VP PRE HG', 'VIEPRO PREMUIM HOG GROWER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1254.00', '1254.00', '1254.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('90', 'VP PRE HF', 'VIEPRO PREMIUM HOG FINISHER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1206.50', '1206.50', '1206.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('91', 'VP PRE HGE', 'VIEPRO PREMIUM HOG GESTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1140.00', '1140.00', '1140.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('92', 'VP PRE HL', 'VIEPRO PREMIUM HOG LACTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1301.50', '1301.50', '1301.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('93', 'VPPB 1', 'VIEPRO 1000 SMALL CRUMBLE 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1372.75', '1372.75', '1372.75', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('94', 'VPPB 2', 'VIEPRO 2000 BIG CRUMBLE 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1220.75', '1220.75', '1220.75', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('95', 'VPPB 3', 'VIEPRO 3000 PELLET 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1192.25', '1192.25', '1192.25', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('96', 'VP BRO B', 'VIEPRO BROILER BOOSTER SMAL CRUMBLE 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1493.80', '1493.80', '1493.80', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('97', 'VP BRO S', 'VIEPRO BROILER STARTER BIG CRUMBLE 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1455.00', '1455.00', '1455.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('98', 'VP BRO G', 'VIEPRO BROILER GROWER PELLET 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1421.05', '1421.05', '1421.05', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('99', 'VP BRO F', 'VIEPRO BROILER FINISHER PELLET 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1401.65', '1401.65', '1401.65', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('100', 'VP LPB', 'VIEPRO LAYER PULLET BOOSTER MINI CRUMBLE', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1391.95', '1391.95', '1391.95', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('101', 'VP LPS', 'VIEPRO LAYER PULLET STARTER BIG CRUMBLE ', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1256.15', '1256.15', '1256.15', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('102', 'VP LPG', 'VIEPRO LAYER PULLET GROWER PELLET ', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1154.30', '1154.30', '1154.30', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('103', 'VP LPD', 'VIEPRO LAYER PULLET DEVELOPER MASH', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('104', 'VP L1', 'VIEPRO LAYER 1 MASH', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1173.70', '1173.70', '1173.70', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('105', 'VP L2', 'VIEPRO LAYER 2 MASH', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('106', 'VP DLP', 'VIEPRO DUCK LAYER PELLET', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1098.04', '1098.04', '1098.04', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('107', 'VP PDP', 'VIEPRO PDP PELLET', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '777.94', '777.94', '777.94', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('108', 'VP MFPS', 'VIEPRO MILKFISH PRESTARTER SMALL CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '790.88', '790.88', '790.88', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('109', 'VP MFS', 'VIEPRO MILKFISH STARTER BIG CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '719.63', '719.63', '719.63', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('110', 'VP MFG', 'VIEPRO MILKFISH GROWER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '686.38', '686.38', '686.38', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('111', 'VP MFF', 'VIEPRO MILKFISH FINISHER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '662.63', '662.63', '662.63', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('112', 'EGCS', 'EVO-GENE CORN SEEDS 25KG', '11', 'GENERAL', 'CS', 'CORN SEED', '', '', 'P', '1', '1', '1', 'N', '3000.00', '3000.00', '3000.00', '3000.00', '0.00', '3000.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('113', 'MCS', 'MAHARLIKA CORN SEED 25KG', '11', 'GENERAL', 'CS', 'CORN SEED', '', '', 'P', '1', '1', '1', 'N', '3000.00', '3000.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('114', 'MS', 'MARK STICK', 'MD', 'MEDLAND', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', '', '', 'C', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('115', 'AD', 'AQUADOX 48G', 'LDI', 'LAKPUE DRUGS INC', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('116', 'D', 'DOXYCYCLINE 1LTR ', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '1658.00', '1658.00', '1658.00', '1750.00', '0.00', '1750.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('117', 'GL', 'GLUTAMED 1LTR', 'MD', 'MEDLAND', 'DI', 'DISINFECTANT', '', '', 'P', '1', '1', '1', 'N', '230.00', '230.00', '230.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('118', 'G.', 'GLUTAMED 4LTR    ', 'MD', 'MEDLAND', 'DI', 'DISINFECTANT', '', '', 'P', '1', '1', '1', 'N', '880.00', '880.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('119', 'BS', 'BELMET-ANTI MALARIA 240ML', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '185.00', '185.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('120', 'DLPK', 'DUCK LAYER PULLET KARGADO 50KG', 'GMC', 'GENERAL MILLING CORP', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '1230.00', '0.00', '1230.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('121', 'IINJ', 'IVERMECTINE (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('122', 'TTG,', 'TYLOSIN TARTRATE + GENTAMICIN (1LTR)', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '493.75', '493.75', '493.75', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('123', 'B+CSM', '[BOUNTY] CHICK STARTER MASH 50KG', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1233.00', '1233.00', '1233.00', '1323.00', '0.00', '1323.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('124', 'B+CBC', '[BOUNTY] CHICK BOOSTER CRUMBLE', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '850.00', '0.00', '850.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('125', 'B+DLP', '[BOUNTY] DUCK LAYER PELLET', 'B+', 'BOUNTY PLUS', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1270.00', '1270.00', '1270.00', '1320.00', '0.00', '1320.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('126', 'CW-G', 'CARGILL WALNUT-GROWER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1779.00', '1799.00', '1799.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('127', 'CW-HS', 'CARGILL WALNUT- HOG STARTER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2360.00', '2360.00', '2360.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('128', 'CW-HGE', '[CARGILL WALNUT] HOG GESTATING', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1414.00', '1414.00', '1414.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('129', 'CW-CL 3%', 'CARGILL WALNUT- CHICKEN LAYER 3% 25KG', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2500.00', '2500.00', '2500.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('130', 'C- AA', '[CARGILL] ABSORB AFLA', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1625.00', '1625.00', '1625.00', '1626.00', '0.00', '1626.00', '1625.00', '0.00', '1625.00', '1625.00', '0.00', '1625.00', '1625.00', '0.00', '1625.00', '1625.00', '0.00', '1625.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('131', 'CU75-HF', '[CARGILL UTMOST] 75+HOG FINISHER 20KG', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2350.00', '2350.00', '2350.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', 'N', null, '0', '20.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('132', 'CW+HL', '[CARGILL WALNUT] HOG LACTATING ', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('133', 'ES+HCBP', '[EXCEL SUPER] HOG CREEP BOOSTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1357.00', '1357.00', '1357.00', '1357.00', '0.00', '1357.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('134', 'ES+HSPS', '[EXCEL SUPER] HOG PRE STARTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1147.00', '1147.00', '1147.00', '1147.00', '0.00', '1147.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('135', 'ES+HSP', '(ECXEL SUPER) HOG STARTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1590.00', '1590.00', '1590.00', '1590.00', '0.00', '1590.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('136', 'ES+HGP', '[EXCEL SUPER] HOG GROWER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1430.00', '1430.00', '1430.00', '1520.00', '0.00', '1520.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('137', 'ES+HPSP', '[ECXEL SUPER] HOG PRE STARTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1147.00', '1147.00', '1147.00', '1147.00', '0.00', '1147.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('138', 'ES+HFP', '[EXCEL SUPER] HOG FINISHER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1450.00', '1450.00', '1450.00', '1450.00', '0.00', '1450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('139', 'ES+HBP', '[EXCEL SUPER] HOG BROODSOW PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1240.00', '1240.00', '1240.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('140', 'ES+HLP', '[EXCEL SUPER] HOG LACTATING PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1560.00', '1560.00', '1560.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('141', 'ES+PPC', '[EXCEL SUPER] PIG PROTEIN CONCENTRATE', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '2140.00', '2140.00', '2140.00', '2140.00', '0.00', '2140.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('142', 'CW+CL 3%', '[CARGILL WALNUT] CHICKEN LAYER 3% ', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2550.00', '2550.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('143', 'CW+HG', '[CARGILL WALNUT] HOG GROWER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1779.00', '1779.00', '1779.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('144', 'CW+HGE', '[CARGILL WALNUT] HOG GESTATING-', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1414.00', '1414.00', '1414.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('145', 'CW+HS', '[CARGILL WALNUT] HOG STARTER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1360.00', '1360.00', '1360.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('146', 'CJ+HPSMP', ' [CJ MAX] HOG PRE STARTER MINI PEL', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('147', 'CL+HSP', '[CJ MAX] HOG STARTER PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('148', 'CJM+HGP', '[CJ MAX] HOG GROWER PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('149', 'CJM+HSP', '[CJ MAX] HOG STARTER PELLET=', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('150', 'CJM+HPSMP', '[CJ MAX] HOG PRE STARTER MINI PEL', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('151', 'CJM+HFP', '[CJ MAX] HOG FINISHER PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1275.00', '1275.00', '1275.00', '1395.00', '0.00', '1395.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('152', 'CJM+HPP', '[CJ MAX] HOG PREGGY/GESTATING PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1180.00', '1180.00', '1180.00', '1300.00', '0.00', '1300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('153', 'CJM+HMP', '[CJ MAX ]HOG MILKY/LACTATING PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1290.00', '1290.00', '1290.00', '1410.00', '0.00', '1410.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('154', 'CJM+CLC', '[CJ MAX] CHICKEN LAYER CRUMBLE ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1350.00', '1350.00', '1350.00', '1430.00', '0.00', '1430.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('155', 'CJJ+HSP', '[CJ JACKPOT] HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('156', 'CJJ+HGP', '[CJ JACKPOT] HOG GROWER PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1165.00', '1165.00', '1165.00', '1285.00', '0.00', '1285.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('157', 'CJJ+HFP', '[CJ JACKPOT] HOG FINISHER PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1125.00', '1125.00', '1125.00', '1245.00', '0.00', '1245.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('158', 'CJJ+HBP', '[CJ JACKPOT] HOG BROODSOW PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1075.00', '1075.00', '1075.00', '1195.00', '0.00', '1195.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('159', 'CJJ+HLP', '[CJ JACKPOT] HOG LACTATION PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('160', 'CJJ+HPDPP', '[CJ JACKPOT] HPDP PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '920.00', '0.00', '920.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('161', 'GMCM+HGP', '..[GMC MEGA] HOG GROWER PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '1370.00', '0.00', '1370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('162', 'GMCM+HLP', '..[GMC MEGA] HOG LACTAING PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '1415.00', '0.00', '1415.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('163', 'GMCM+HGEP', '..[GMC MEGA] HOG GESTATING PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1175.00', '1175.00', '1175.00', '1345.00', '0.00', '1345.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('164', 'GMCK+PSP', '.[GMC KARGADO] PRE STARTER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1215.00', '1215.00', '1215.00', '1337.00', '0.00', '1337.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('165', 'GMCK+HSP', '.[GMC KARGADO] HOG STARTER PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1535.00', '1535.00', '1535.00', '1650.00', '0.00', '1650.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('166', 'GMCK+HGP', '[GMC KARGADO] HOG GROWER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1365.00', '1365.00', '1365.00', '1500.00', '0.00', '1500.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('167', 'GMCK+HFP', '[GMC KARGADO] HOG FINISHER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1340.00', '1340.00', '1340.00', '1500.00', '0.00', '1500.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('168', 'GMCK+DLP', '[GMC KARGADO] DUCK LAYER PULLET', 'GMC', 'GENERAL MILLING CORP', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '1260.00', '0.00', '1260.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('169', 'VPMF+FPS', '[VIEPRO MILKFISH] FINISHER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '662.63', '0.00', '0.00', '772.50', '0.00', '772.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('170', 'VPM+GPS', '[VIEPRO MILKFISH] GROWER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '686.38', '686.38', '686.38', '797.50', '0.00', '797.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('171', 'VPM+SC', '[VIEPRO MILKFISH] STARTER CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '719.63', '719.63', '719.63', '832.50', '0.00', '832.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('172', 'VPMF+PSC', '[VIEPRO MILKFISH] PRE STARTER CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '780.88', '790.88', '790.88', '907.50', '0.00', '907.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('173', 'VP+PDPP', '[VIEPRO] PDP PELLET', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '777.94', '777.94', '777.94', '932.00', '0.00', '932.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('174', 'VP+DLP', '[VIEPRO] DUCK LAYER PELLET', 'VN', 'VIENOVO', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1098.04', '1098.04', '1098.04', '1292.00', '0.00', '1292.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('175', 'VP+CLM 2', '[VIEPRO] CHICKEN LAYER MASH 2', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('176', 'VP+CLM 1', '[VIEPRO] CLM 1', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1173.70', '1173.70', '1173.70', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('177', 'VP+LPD', '[VIEPRO]LAYER PULLET DEVELOPER MASH', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('178', 'VP+CDM', '[VIEPRO] CHICK DEVELOPER MASH', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('179', 'VP+CGP', '[VIEPRO] CHICK GROWER PELLET ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1154.30', '1154.30', '1154.30', '1350.00', '0.00', '1350.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('180', 'VPL+CSC', '[VIEPRO LAYER] CHICK STARTER CRUMBLE ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1256.15', '1256.15', '1256.15', '1455.00', '0.00', '1455.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('181', 'VPL+CGP', '[VIEPRO LAYER] CHICK GROWER PELLET ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1154.30', '1154.30', '1154.30', '1350.00', '0.00', '1350.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('182', 'VPL+CDM', '[VIEPRO LAYER] CHICK DEVELOPER MASH', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('183', 'VPL+CLM1', '[VIEPRO LAYER] CHICKEN LAYER MASH 1', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1173.70', '1173.70', '1173.70', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('184', 'VPL+CLM 2', '[VIEPRO LAYER] CHICKEN LAYER MASH 2', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('185', 'VPL+DLP', '[VIEPRO LAYER] DUCK LAYER PELLET', 'VN', 'VIENOVO', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1098.04', '1098.04', '1098.04', '1292.00', '0.00', '1292.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('186', 'VPL+CBC', '[VIEPRO LAYER] CHICK BOOSTER CRUMBLE', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1391.95', '1391.95', '1391.95', '1595.00', '0.00', '1595.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('187', 'VPB+FP', '[VIEPRO BROILER] FINISHER PELLET ', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1401.65', '1401.65', '1401.65', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('188', 'VPB+GP', '[VIEPRO BROILER] GROWER PELLET ', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1421.05', '1421.05', '1421.05', '1610.00', '0.00', '1610.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('189', 'VPB+SC', '[VIEPRO BROILER] STARTER CRUMBLE ', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1455.00', '1455.00', '1455.00', '1465.00', '0.00', '1465.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('190', 'VPB+BC', '[VIEPRO BROILER] BOOSTER CRUMBLE', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1493.80', '1493.80', '1493.80', '1685.00', '0.00', '1685.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('191', 'VP+3000P', '[VIEPRO BOOST] 3000 PELLET 50KG', 'VN', 'VIENOVO', 'CS', 'CORN SEED', '', '', 'P', '1', '1', '1', 'N', '1192.25', '1192.25', '1192.25', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('192', 'VP+2000P', '[VIEPRO BOOST] 2000 CRUMBLE ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1220.75', '1220.75', '1220.75', '1430.00', '0.00', '1430.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('193', 'VP+1000P', '[VIEPRO BOOST] 1000 CRUMBLE 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1372.75', '1372.75', '1372.75', '1590.00', '0.00', '1590.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('194', 'VPPRE+HLP', '[VIEPRO PREMIUM] HOG LACTATING PELLET ', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1301.50', '1301.50', '1301.50', '1535.00', '0.00', '1535.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('195', 'VPPRE+HGP', '[VIEPRO PREMIUM] HOG GESTATING PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1140.00', '1140.00', '1140.00', '1315.00', '0.00', '1315.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('196', 'VPPRE+HFP', '[VIEPRO PREMIUM] HOG FINISHER PELLET ', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1206.50', '1206.50', '1206.50', '1385.00', '0.00', '1385.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('197', 'VPPRE+HGEP', '[VIEPRO PREMIUM] HOG GESTATING PELLET=', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1140.00', '1140.00', '1140.00', '1315.00', '0.00', '1315.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('198', 'VPPRE+HGP=', '[VIEPRO PREMIUM] HOG GROWER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1254.00', '1254.00', '1254.00', '1435.00', '0.00', '1435.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('199', 'VPPRE+HSP', '[VIEPRO PREMIUM] HOG STARTER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1455.00', '1455.00', '1455.00', '1505.00', '0.00', '1505.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('200', 'GMC+P', '[GMC] POLLARD', 'GMC', 'GENERAL MILLING CORP', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('201', 'GMC+RP', '[GMC] RED PELLET', 'GMC', 'GENERAL MILLING CORP', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('202', 'GMCV+HGM', '[GMC VALUE] HOG GROWER MASH', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1250.00', '0.00', '1250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('203', 'GMCV+HGP', '[GMC VLAUE] HOG GROWER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1270.00', '0.00', '1270.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('204', 'B+CLC', '[BOUNTY CHICKEN LAYER MASH', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1220.00', '1220.00', '1220.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('205', ' BSS', 'BELMET-ANTI MALARIA 960ML', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '620.00', '620.00', '620.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('206', 'GMCM+HSP', '[GMC MEGAMIX] HOG STARTER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1250.00', '0.00', '1250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('207', 'GMC+PBP', '[GMC] PIGLET BOOSTER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '60.00', '60.00', '60.00', '80.00', '0.00', '80.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('208', 'B+CM', '[BOUNTY] COPRA MILL', 'B+', 'BOUNTY PLUS', 'FRM', 'FEED RAW MAATERIAL ', '', '', 'P', '1', '1', '1', 'N', '900.00', '900.00', '900.00', '1000.00', '0.00', '1000.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('209', 'B+CP', '[BOUNTY} COPRA PELLETS', 'B+', 'BOUNTY PLUS', 'FRM', 'FEED RAW MAATERIAL ', '', '', 'P', '1', '1', '1', 'N', '650.00', '650.00', '650.00', '700.00', '0.00', '700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('210', 'ES+CLC', '[EXCEL SUPER] CHICKEN LAYER CRUMBLE', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1505.00', '1505.00', '1505.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('211', 'VPPRI+HGEP', '[VIEPRO PRIME] HOG GESTATING PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1225.00', '1225.00', '1225.00', '1370.00', '0.00', '1370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('212', 'VPPRI+HLP', '[VIEPRO PRIME] HOG LACTATING PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1395.00', '1395.00', '1395.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('213', 'VPPRI+HFP', '[VIEPRO PRIME] HOG FIMISHER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1295.00', '1295.00', '1295.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('214', 'VPPRI+HGP', '[VIEPRO PRIME] HOG GROWER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'C', '1', '1', '1', 'N', '1345.00', '1345.00', '1345.00', '1490.00', '0.00', '1490.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('215', 'VPPRI+HSP', '[VIEPRO PRIME] HOG STARTER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1415.00', '1415.00', '1415.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('216', 'CJ+L3', 'CJ+LEGION 3 (MAINTENANCE)', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '5.00', '5.00', '5.00', '5.00', '0.00', '5.00', '6.00', '0.00', '6.00', '7.00', '0.00', '7.00', '8.00', '0.00', '8.00', '9.00', '0.00', '9.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('217', 'CJ+L2', '[CJ] LEGION 2 (CHICK GROWER)', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('218', 'CJ+L1', '[CJ] LEGION 1 (CHICK BOOSTER)', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('219', 'BS+BS', '[BOUNTY SILVER] BROOD SOW PELLET', 'B+', 'BOUNTY PLUS', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1300.00', '1300.00', '1300.00', '1350.00', '0.00', '1350.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('221', 'W52', 'WINGS POWDER DETERGENT 52GX150\'S', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '150', '1', '1', 'N', '900.00', '900.00', '6.00', '900.00', '0.00', '6.00', '910.00', '0.00', '6.07', '920.00', '0.00', '6.13', '930.00', '0.00', '6.20', '940.00', '0.00', '6.27', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-07-26 07:23:52');
INSERT INTO `ivitem` VALUES ('222', 'WW52', 'WINGS POWDER WHITE DETERGENT 52GX150', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '150', '1', '1', 'N', '900.00', '900.00', '6.00', '910.00', '0.00', '6.07', '920.00', '0.00', '6.13', '930.00', '0.00', '6.20', '940.00', '0.00', '6.27', '950.00', '0.00', '6.33', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('223', 'TW10\'S', 'TOP CAFE WHITE 30G 10\'S (36 STRNGS)', 'GSPI', 'GENTLE SUPPREME PHILS.', 'TC', 'TOP CAFE', '', '', 'C', '360', '10', '10', 'N', '1386.00', '1386.00', '3.85', '1386.00', '38.50', '3.85', '1396.00', '38.80', '3.88', '1400.00', '38.90', '3.89', '1405.00', '39.00', '3.90', '1410.00', '39.20', '3.92', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-08-04 06:32:07');
INSERT INTO `ivitem` VALUES ('224', 'TBR10\'S', 'TOP CAFE BROWN 25G 10\'S (36 STRNGS)', 'GSPI', 'GENTLE SUPPREME PHILS.', 'TC', 'TOP CAFE', '', '', 'C', '360', '10', '10', 'N', '1386.00', '1386.00', '3.85', '1386.00', '38.50', '3.85', '1396.00', '38.80', '3.88', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-08-04 06:32:31');
INSERT INTO `ivitem` VALUES ('225', 'TBD10\'S', 'TOP CAFE BREWED 22G 10\'S (36 STRNGS)', 'GSPI', 'GENTLE SUPPREME PHILS.', 'TC', 'TOP CAFE', '', '', 'C', '360', '10', '10', 'N', '1386.00', '1386.00', '3.85', '1386.00', '38.50', '3.85', '1396.00', '0.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-08-04 06:32:57');
INSERT INTO `ivitem` VALUES ('227', 'MSD', 'MISEDAAP NOODLES REGULAR 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '470.00', '11.75', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-07-16 03:05:44');
INSERT INTO `ivitem` VALUES ('228', 'MSK', 'MISEDAAP KALAMANSI 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-07-16 03:07:15');
INSERT INTO `ivitem` VALUES ('229', 'WTC52', 'WINGS WHITE POWDER 52X150', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '150', '1', '1', 'N', '900.00', '900.00', '6.00', '900.00', '0.00', '6.00', '900.00', '0.00', '6.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('231', 'GB80', 'GIV BEAUTY SOAP BLUE 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1180.00', '0.00', '16.39', '1185.00', '0.00', '16.46', '1190.00', '0.00', '16.53', '1195.00', '0.00', '16.60', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('232', 'GP80', 'GIV BEAUTY SOAP PINK 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('233', 'GW80', 'GIV BEAUTY SOAP WHITE 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('234', 'GBR80', 'GIV BEAUTY SOAP BROWN 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('235', 'MKS', 'MISEDAAP KOREAN SPICY CHICKEN 87G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('236', 'MMA', 'MISEDAAP MIGORENG ASLI 91G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('237', 'MAB', 'MISEDAAP MISUP AYAMBAWANG 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('238', 'MPS', 'MISEDAAP MISUP PERISASOTO 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('239', 'W100', 'WINGS BAR WHITE 100GX36', 'GSPI', 'GENTLE SUPPREME PHILS.', 'BAR', 'BAR DETERGENT', '', '', 'C', '36', '1', '1', 'N', '352.80', '352.80', '9.80', '352.80', '0.00', '9.80', '360.00', '0.00', '10.00', '365.50', '0.00', '10.15', '370.80', '0.00', '10.30', '400.00', '0.00', '11.11', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('240', 'W420', 'WINGS WHITE BAR 36X420G', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '36', '1', '1', 'N', '658.44', '658.44', '18.29', '658.44', '0.00', '18.29', '660.00', '0.00', '18.33', '670.00', '0.00', '18.61', '675.00', '0.00', '18.75', '680.00', '0.00', '18.89', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('241', 'W390', 'WINGS BAR WGITE DETERGENT 150GX96', 'GSPI', 'GENTLE SUPPREME PHILS.', 'BAR', 'BAR DETERGENT', '', '', 'C', '96', '1', '1', 'N', '647.04', '647.04', '6.74', '647.04', '0.00', '6.74', '660.50', '0.00', '6.88', '680.80', '0.00', '7.09', '700.00', '0.00', '7.29', '705.00', '0.00', '7.34', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem` VALUES ('242', 'MKSP', 'MISEDAAP KOREAN CITY NOODLES 87G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'BAR', 'BAR DETERGENT', '', '', 'C', '40', '5', '5', 'N', '500.00', '500.00', '12.50', '505.00', '63.15', '12.63', '510.00', '63.75', '12.75', '515.00', '64.40', '12.88', '520.00', '65.00', '13.00', '525.00', '65.65', '13.13', 'N', null, '0', '0.00', null, null, null, '0', null, null, '2022-07-16 06:00:29');
INSERT INTO `ivitem` VALUES ('243', 'DC3', 'DAIRY CHAMP CONDENSE 390MLX24', 'DM', 'DAIRY MILK PRODUCTS', 'DC', 'DAIRY CHAMP CONDENSE MILK', '', '', 'C', '48', '1', '1', 'N', '2022.00', '2022.00', '42.13', '2272.80', '0.00', '47.35', '2340.98', '0.00', '48.77', '2340.98', '0.00', '48.77', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, null, '2022-07-27 02:42:21');
INSERT INTO `ivitem` VALUES ('244', 'DC1', 'DAIRY CHAMP CONDENSED 1KGX24', 'DM', 'DAIRY MILK PRODUCTS', 'DC', 'DAIRY CHAMP CONDENSE MILK', '', '', 'C', '12', '1', '1', 'N', '2343.00', '2343.00', '195.25', '2632.80', '0.00', '219.40', '2711.78', '0.00', '225.98', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, null, '2022-07-27 02:43:53');

-- ----------------------------
-- Table structure for ivitem_copy
-- ----------------------------
DROP TABLE IF EXISTS `ivitem_copy`;
CREATE TABLE `ivitem_copy` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `description` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `supcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `supplier` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `catcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `category` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `brcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `brand` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `unit` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `pckgc` int(10) DEFAULT NULL,
  `pckgb` int(10) DEFAULT NULL,
  `pckgp` int(10) DEFAULT NULL,
  `freeitem` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `grscost` decimal(15,2) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `apricec` decimal(15,2) DEFAULT '0.00',
  `apriceb` decimal(15,2) DEFAULT '0.00',
  `apricep` decimal(15,2) DEFAULT '0.00',
  `bpricec` decimal(15,2) DEFAULT '0.00',
  `bpriceb` decimal(15,2) DEFAULT '0.00',
  `bpricep` decimal(15,2) DEFAULT '0.00',
  `cpricec` decimal(15,2) DEFAULT '0.00',
  `cpriceb` decimal(15,2) DEFAULT '0.00',
  `cpricep` decimal(15,2) DEFAULT '0.00',
  `dpricec` decimal(15,2) DEFAULT '0.00',
  `dpriceb` decimal(15,2) DEFAULT '0.00',
  `dpricep` decimal(15,2) DEFAULT '0.00',
  `epricec` decimal(15,2) DEFAULT '0.00',
  `epriceb` decimal(15,2) DEFAULT '0.00',
  `epricep` decimal(15,2) DEFAULT '0.00',
  `obsolet` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `lastpurc` date DEFAULT NULL,
  `discpct` int(10) DEFAULT NULL,
  `wtkg` decimal(15,2) DEFAULT NULL,
  `unitc` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitb` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitp` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `status` int(1) DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=242 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivitem_copy
-- ----------------------------
INSERT INTO `ivitem_copy` VALUES ('1', 'HKG', 'KARGADO HOG GROWER 50KG', 'GM', 'GENERAL MILLING CORP.', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1465.00', '1465.00', '1465.00', '1465.00', '0.00', '1465.00', '1455.00', '0.00', '1455.00', '1445.00', '0.00', '1445.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('2', 'BCG', 'BOUNTY CHICK GROWER', 'GM', 'GENERAL MILLING CORP.', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1280.00', '0.00', '1280.00', '1270.00', '0.00', '1270.00', '1260.00', '0.00', '1260.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '500.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('3', 'KHPS', '[KARGADO] PRE STARTER PELLET 25KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1215.00', '1215.00', '1215.00', '1290.00', '0.00', '1290.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('4', 'KHS', '[KARGADO] HOG STARTER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1535.00', '1535.00', '1535.00', '1655.00', '0.00', '1655.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('5', 'KHG', '[KARGADO] HOG GROWER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1365.00', '1365.00', '1365.00', '1475.00', '0.00', '1475.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('6', 'KHF', '[KARGADO] HOG FINISHER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1340.00', '1340.00', '1340.00', '1465.00', '0.00', '1465.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('7', 'MMHL-GMC', 'MEGAMIX HOG LACTATING 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('8', 'MMHG-GMC', 'MEGAMIX HOG GESTATING 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('9', 'SPMHPS', 'S PIGGYMAX HOG PRE STARTER MINI PEL 25KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('10', 'MMHG', 'MEGAMIX HOG GESTATING PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1175.00', '1175.00', '1175.00', '1330.00', '0.00', '1330.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('11', 'MMHL', 'MEGAMIX HOG LACTAING PELLET 50GKG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '1385.00', '0.00', '1385.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('12', 'SMMHS', 'S MUSCLE MAX HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('13', 'SMMHG', 'S MUSCLE MAX HOG GROWER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('14', 'SMMHF', 'S MUSCLE MAX HOG FINISHER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1275.00', '1275.00', '1275.00', '1395.00', '0.00', '1395.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('15', 'SMMHP', 'S MUSCLE MAX HOG PREGGY PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1180.00', '1180.00', '1180.00', '1300.00', '0.00', '1300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('16', 'SMMHM', 'S MUCSLE MAX HOG MILKY PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1290.00', '1290.00', '1290.00', '1410.00', '0.00', '1410.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('17', 'PMJHS', 'P MEGA JACKPOT HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('18', 'PJMHG', 'P MEGA JACKPOT HOG GROWER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1165.00', '1165.00', '1165.00', '1285.00', '0.00', '1285.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('19', 'PMJHF', 'P MEGA JACKPOT HOG FINISHER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1125.00', '1125.00', '1125.00', '1245.00', '0.00', '1245.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('20', 'PMJHB', 'P MEGA JACKPOT HOG BROODSOW PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1075.00', '1075.00', '1075.00', '1195.00', '0.00', '1195.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('21', 'PMJHL', 'P MEGA JACKPOT HOG LACTATION PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('22', 'PMJHPDP', 'P MEGA JACKPOT HPDP PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '920.00', '0.00', '920.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('23', 'L1', 'LEGION 1 (CHICK BOOSTER) 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1440.00', '1440.00', '1440.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('24', 'L2', 'LEGION 2 (CHICK GROWER) 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1270.00', '1270.00', '1270.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('25', 'L3', 'LEGION 3 (MAINTENACE) PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1120.00', '1120.00', '1120.00', '1240.00', '0.00', '1240.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('26', 'CLMC', 'CHICKEN LAYER MAX CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'LF ', 'LAYER FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1310.00', '0.00', '1310.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('27', 'PDL', 'PREMIUM DUCK CJ LAYER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'DF', 'DUCK FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1185.00', '1185.00', '1185.00', '1235.00', '0.00', '1235.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('28', 'BMB', 'BROILERMAX BOOSTER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('29', 'BMS', 'BROILERMAX STARTER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('30', 'BMG', 'BROILER MAX GROWER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('31', 'B+CLM', '[BOUNTY] CHICKEN LAYER MASH 50KG', 'B+', 'BOUNTY PLUS', 'LF ', 'LAYER FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1240.00', '1240.00', '1240.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('32', 'B+CGM', '[BOUNTY] CHICK GROWER MASH 50KG', 'B+', 'BOUNTY PLUS', 'LF ', 'LAYER FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1151.00', '1151.00', '1151.00', '1290.00', '0.00', '1290.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('33', 'VBCAA', 'VITAMIN B COMLEX+AMINO ACID(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '400.00', '400.00', '400.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('34', 'CP', 'CALCIUM PHOSPHORUS(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '280.00', '280.00', '280.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', '320.00', '0.00', '320.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('35', 'PE', 'PURE ELECTROLYTE(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('36', 'IO', 'IVERMECTINE(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '820.00', '820.00', '820.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('37', 'A', 'AMPROLLIUM(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', 'BRAND NAME 1', 'C', '50', '1', '1', 'N', '1000.00', '1000.00', '20.00', '1100.00', '0.00', '22.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('38', 'TTGS', 'TYLOSIN TARTRATE+GENTAMICIN(ORAL)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '3', '0', '0', 'N', '2480.00', '2480.00', '620.00', '2480.00', '1240.00', '620.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('39', 'TTG', 'TYLOSIN TARTRATE+GENTAMICIN(ORAL)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1975.00', '1975.00', '493.75', '2480.00', '0.00', '620.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('40', 'TMPS', 'TMPS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '830.00', '830.00', '830.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('41', 'B', 'BELMET-ANTIMALARIA(ORAL)1LTR', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '675.00', '675.00', '675.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '740.00', '0.00', '740.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('42', 'G', 'GLUTAMED(LIQUID DISIFECTANT)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '220.00', '220.00', '220.00', '220.00', '0.00', '220.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('43', 'EG', 'EGG BOOSTER(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '630.00', '630.00', '630.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', '700.00', '0.00', '700.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('44', 'NBP', 'NUTRA-B PLUS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '380.00', '380.00', '380.00', '450.00', '0.00', '450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('45', 'VC', 'VITAMIN-C(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '770.00', '770.00', '770.00', '870.00', '0.00', '870.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('46', 'CPO', 'CALCIUM PHOSPHORUS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '380.00', '380.00', '380.00', '450.00', '0.00', '450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('47', 'PEO', 'PURE ELECTROLYTE(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '170.00', '170.00', '170.00', '220.00', '0.00', '220.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('48', 'PEC', 'PURE ELECTROLYTE.(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '120.00', '120.00', '120.00', '170.00', '0.00', '170.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('49', 'VBCI', 'VITAMIN-B COMPLEX (INJECTABLE)100ML', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '230.00', '230.00', '230.00', '300.00', '0.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('50', 'O', 'OXYTOCIN', 'MD', 'MEDLAND', 'LSS', 'LIVE STOCK STIMULANT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('51', 'II', 'IVERMECTIN(INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '320.00', '320.00', '320.00', '370.00', '0.00', '370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('52', 'E10%', 'ENROFLOXACIN10% (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('53', 'E20%', 'ENROFLOXACIN20% (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '340.00', '340.00', '340.00', '390.00', '0.00', '390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('54', 'LSB', 'LSB(INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('55', 'LH', 'LINCOMYCIN HYDROCHLORIDE', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('56', 'IPM', 'IVERMECTIN1% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('57', 'LSBPM', 'LSB1% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('58', 'CSFPM', 'COLISTIN SULFATE10% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', '900.00', '0.00', '900.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('59', 'LSBFMP', 'LSB1%. (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '700.00', '700.00', '700.00', '800.00', '0.00', '800.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('60', 'IFPM ', 'IVERMECTIN1%. (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '510.00', '510.00', '510.00', '610.00', '0.00', '610.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('61', 'HC', 'HEXAMIDE CREAM (ANTI SEPTIC CREAM)', 'BL', 'BELMAN LABORATORIES', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '38.00', '38.00', '38.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', '50.00', '0.00', '50.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('62', 'CPFS', 'CECICAL POWDER (FEED SUPPLEMENT)', 'BL', 'BELMAN LABORATORIES', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '20.00', '20.00', '20.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('63', 'PP', 'PIDRO POWDER', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '23.00', '23.00', '23.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('64', 'MVE', 'MULTI VITAMINS (FOIL) 1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '200.00', '200.00', '200.00', '250.00', '0.00', '250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('65', 'ID', 'IRON DEXTRANT ', 'BL', 'BELMAN LABORATORIES', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '272.00', '0.00', '0.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', '400.00', '0.00', '400.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('66', 'BN', 'BIO-NUTRILYTES                          ', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '520.00', '520.00', '520.00', '600.00', '0.00', '600.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('67', 'WO', 'WASH OUT', 'LDI', 'LAKPUE DRUGS INC', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '11.00', '11.00', '11.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', '15.00', '0.00', '15.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('68', 'ZP', 'ZINC PHOSPHIDE (RAT POISON)', 'LDI', 'LAKPUE DRUGS INC', 'PI', 'PESTICIDE AND INSECTICIDE', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '22.00', '22.00', '22.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', '25.00', '0.00', '25.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('69', 'MVEO', 'MULTI VITAMINS (ORAL) 1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '620.00', '620.00', '620.00', '700.00', '0.00', '700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('70', 'CSP', 'CHLOR SP (FEED SUPPLEMENT)', 'BL', 'BELMAN LABORATORIES', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '123.00', '123.00', '123.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', '170.00', '0.00', '170.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('71', 'C', 'COMBINEX ANTI SEPTIC SPRAY (AEROSOL)', 'MD', 'MEDLAND', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '250.00', '250.00', '250.00', '300.00', '0.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('72', 'N20%', 'NORFLOXACIN20% (ORAL) 1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '830.00', '830.00', '830.00', '930.00', '0.00', '930.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('73', 'AT20%', 'AMOXICILLIN TRIHYDRATE (INJECTABLE)100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('74', 'MMHGR', 'MEGAMIX HOG GROWER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('75', 'SMB', 'SOYA-MIL (BAG)', 'IFMC', 'INOZA FEED MILLING CORP', 'FRM', 'FEED RAW MAATERIAL ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '4.00', '4.00', '4.00', '44.00', '0.00', '4.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('76', 'SMKG', 'SOYA-MIL (KG)', 'IFMC', 'INOZA FEED MILLING CORP', 'FRM', 'FEED RAW MAATERIAL ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '29.50', '29.50', '29.50', '32.50', '0.00', '32.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('77', 'TEST1', 'TEST MIC ONE TWO THREE', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '360', '10', '10', 'N', '500.00', '500.00', '1.39', '600.00', '16.70', '1.67', '610.00', '16.90', '1.69', '615.00', '17.10', '1.71', '620.00', '16.90', '1.72', '625.00', '17.40', '1.74', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('78', 'TEST2', 'TEST2 ASDFASDFASDFASDF', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '360', '10', '10', 'N', '600.00', '600.00', '1.67', '610.00', '16.90', '1.69', '620.00', '17.20', '1.72', '630.00', '17.50', '1.75', '640.00', '17.80', '1.78', '650.00', '18.10', '1.81', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('79', 'TEST3', 'ASDFASDFASDFASDF', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '360', '10', '10', 'N', '10000.00', '0.00', '0.00', '11000.00', '305.60', '30.56', '12000.00', '333.30', '33.33', '13000.00', '361.10', '36.11', '14000.00', '388.90', '38.89', '15000.00', '416.70', '41.67', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('80', 'TEST4', 'TEST DESCRIPTION 4', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'C', '24', '1', '1', 'N', '700.00', '680.00', '28.33', '710.00', '0.00', '29.58', '720.00', '0.00', '30.00', '730.00', '0.00', '30.42', '740.00', '0.00', '30.83', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('81', 'VPB', 'VIEPRO PIGLET BOOSTER MINI PEL 25KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1390.00', '1390.00', '1390.00', '1465.00', '0.00', '1465.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('82', 'VPPS', 'VIEPRO PIGLET PRE STARTER MINI PEL 25KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '988.00', '988.00', '988.00', '1165.00', '0.00', '1165.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('83', 'VP PRI HS', 'VIEPRO PRIME HOG STARTER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1273.00', '1273.00', '1273.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('84', 'VP PRI HG', 'VIEPRO PRIME HOG GROWER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1206.50', '1206.50', '1206.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('85', 'VP PRI HF', 'VIEPRO PRIME HOG FINISHER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1159.00', '1159.00', '1159.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('86', 'VP PRI HGE', 'VIEPRO PRIME HOG GESTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1093.50', '1093.50', '1093.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('87', 'VP PRI HL', 'VIEPRO PRIME HOG LACTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1254.00', '1254.00', '1254.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('88', 'VP PRE HS', 'VIEPRO PREMIUM HOG STARTER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('89', 'VP PRE HG', 'VIEPRO PREMUIM HOG GROWER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1254.00', '1254.00', '1254.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('90', 'VP PRE HF', 'VIEPRO PREMIUM HOG FINISHER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1206.50', '1206.50', '1206.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('91', 'VP PRE HGE', 'VIEPRO PREMIUM HOG GESTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1140.00', '1140.00', '1140.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('92', 'VP PRE HL', 'VIEPRO PREMIUM HOG LACTATING PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1301.50', '1301.50', '1301.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('93', 'VPPB 1', 'VIEPRO 1000 SMALL CRUMBLE 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1372.75', '1372.75', '1372.75', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('94', 'VPPB 2', 'VIEPRO 2000 BIG CRUMBLE 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1220.75', '1220.75', '1220.75', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('95', 'VPPB 3', 'VIEPRO 3000 PELLET 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1192.25', '1192.25', '1192.25', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('96', 'VP BRO B', 'VIEPRO BROILER BOOSTER SMAL CRUMBLE 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1493.80', '1493.80', '1493.80', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('97', 'VP BRO S', 'VIEPRO BROILER STARTER BIG CRUMBLE 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1455.00', '1455.00', '1455.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('98', 'VP BRO G', 'VIEPRO BROILER GROWER PELLET 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1421.05', '1421.05', '1421.05', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('99', 'VP BRO F', 'VIEPRO BROILER FINISHER PELLET 50KG', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1401.65', '1401.65', '1401.65', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('100', 'VP LPB', 'VIEPRO LAYER PULLET BOOSTER MINI CRUMBLE', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1391.95', '1391.95', '1391.95', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('101', 'VP LPS', 'VIEPRO LAYER PULLET STARTER BIG CRUMBLE ', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1256.15', '1256.15', '1256.15', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('102', 'VP LPG', 'VIEPRO LAYER PULLET GROWER PELLET ', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1154.30', '1154.30', '1154.30', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('103', 'VP LPD', 'VIEPRO LAYER PULLET DEVELOPER MASH', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('104', 'VP L1', 'VIEPRO LAYER 1 MASH', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1173.70', '1173.70', '1173.70', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('105', 'VP L2', 'VIEPRO LAYER 2 MASH', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('106', 'VP DLP', 'VIEPRO DUCK LAYER PELLET', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '1098.04', '1098.04', '1098.04', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('107', 'VP PDP', 'VIEPRO PDP PELLET', 'VN', 'VIENOVO', 'LF ', 'LAYER FEED', '', '', 'P', '1', '1', '1', 'N', '777.94', '777.94', '777.94', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('108', 'VP MFPS', 'VIEPRO MILKFISH PRESTARTER SMALL CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '790.88', '790.88', '790.88', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('109', 'VP MFS', 'VIEPRO MILKFISH STARTER BIG CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '719.63', '719.63', '719.63', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('110', 'VP MFG', 'VIEPRO MILKFISH GROWER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '686.38', '686.38', '686.38', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('111', 'VP MFF', 'VIEPRO MILKFISH FINISHER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '662.63', '662.63', '662.63', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('112', 'EGCS', 'EVO-GENE CORN SEEDS 25KG', '11', 'GENERAL', 'CS', 'CORN SEED', '', '', 'P', '1', '1', '1', 'N', '3000.00', '3000.00', '3000.00', '3000.00', '0.00', '3000.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('113', 'MCS', 'MAHARLIKA CORN SEED 25KG', '11', 'GENERAL', 'CS', 'CORN SEED', '', '', 'P', '1', '1', '1', 'N', '3000.00', '3000.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', '3000.00', '0.00', '3000.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('114', 'MS', 'MARK STICK', 'MD', 'MEDLAND', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', '', '', 'C', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('115', 'AD', 'AQUADOX 48G', 'LDI', 'LAKPUE DRUGS INC', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('116', 'D', 'DOXYCYCLINE 1LTR ', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '1658.00', '1658.00', '1658.00', '1750.00', '0.00', '1750.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('117', 'GL', 'GLUTAMED 1LTR', 'MD', 'MEDLAND', 'DI', 'DISINFECTANT', '', '', 'P', '1', '1', '1', 'N', '230.00', '230.00', '230.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', '250.00', '0.00', '250.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('118', 'G.', 'GLUTAMED 4LTR    ', 'MD', 'MEDLAND', 'DI', 'DISINFECTANT', '', '', 'P', '1', '1', '1', 'N', '880.00', '880.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', '880.00', '0.00', '880.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('119', 'BS', 'BELMET-ANTI MALARIA 240ML', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '185.00', '185.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', '185.00', '0.00', '185.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('120', 'DLPK', 'DUCK LAYER PULLET KARGADO 50KG', 'GMC', 'GENERAL MILLING CORP', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '1230.00', '0.00', '1230.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('121', 'IINJ', 'IVERMECTINE (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', '350.00', '0.00', '350.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('122', 'TTG,', 'TYLOSIN TARTRATE + GENTAMICIN (1LTR)', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '493.75', '493.75', '493.75', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', '620.00', '0.00', '620.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('123', 'B+CSM', '[BOUNTY] CHICK STARTER MASH 50KG', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1233.00', '1233.00', '1233.00', '1323.00', '0.00', '1323.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('124', 'B+CBC', '[BOUNTY] CHICK BOOSTER CRUMBLE', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '850.00', '0.00', '850.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('125', 'B+DLP', '[BOUNTY] DUCK LAYER PELLET', 'B+', 'BOUNTY PLUS', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1270.00', '1270.00', '1270.00', '1320.00', '0.00', '1320.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('126', 'CW-G', 'CARGILL WALNUT-GROWER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1779.00', '1799.00', '1799.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('127', 'CW-HS', 'CARGILL WALNUT- HOG STARTER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2360.00', '2360.00', '2360.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', '2410.00', '0.00', '2410.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('128', 'CW-HGE', '[CARGILL WALNUT] HOG GESTATING', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1414.00', '1414.00', '1414.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('129', 'CW-CL 3%', 'CARGILL WALNUT- CHICKEN LAYER 3% 25KG', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2500.00', '2500.00', '2500.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('130', 'C- AA', '[CARGILL] ABSORB AFLA', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1625.00', '1625.00', '1625.00', '1626.00', '0.00', '1626.00', '1625.00', '0.00', '1625.00', '1625.00', '0.00', '1625.00', '1625.00', '0.00', '1625.00', '1625.00', '0.00', '1625.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('131', 'CU75-HF', '[CARGILL UTMOST] 75+HOG FINISHER 20KG', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2350.00', '2350.00', '2350.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', '2400.00', '0.00', '2400.00', 'N', null, '0', '20.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('132', 'CW+HL', '[CARGILL WALNUT] HOG LACTATING ', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('133', 'ES+HCBP', '[EXCEL SUPER] HOG CREEP BOOSTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1357.00', '1357.00', '1357.00', '1357.00', '0.00', '1357.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('134', 'ES+HSPS', '[EXCEL SUPER] HOG PRE STARTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1147.00', '1147.00', '1147.00', '1147.00', '0.00', '1147.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('135', 'ES+HSP', '(ECXEL SUPER) HOG STARTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1590.00', '1590.00', '1590.00', '1590.00', '0.00', '1590.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('136', 'ES+HGP', '[EXCEL SUPER] HOG GROWER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1430.00', '1430.00', '1430.00', '1520.00', '0.00', '1520.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('137', 'ES+HPSP', '[ECXEL SUPER] HOG PRE STARTER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1147.00', '1147.00', '1147.00', '1147.00', '0.00', '1147.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('138', 'ES+HFP', '[EXCEL SUPER] HOG FINISHER PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1450.00', '1450.00', '1450.00', '1450.00', '0.00', '1450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('139', 'ES+HBP', '[EXCEL SUPER] HOG BROODSOW PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1240.00', '1240.00', '1240.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('140', 'ES+HLP', '[EXCEL SUPER] HOG LACTATING PELLET', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1560.00', '1560.00', '1560.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('141', 'ES+PPC', '[EXCEL SUPER] PIG PROTEIN CONCENTRATE', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '2140.00', '2140.00', '2140.00', '2140.00', '0.00', '2140.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('142', 'CW+CL 3%', '[CARGILL WALNUT] CHICKEN LAYER 3% ', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '2550.00', '2550.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', '2550.00', '0.00', '2550.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('143', 'CW+HG', '[CARGILL WALNUT] HOG GROWER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1779.00', '1779.00', '1779.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', '1829.00', '0.00', '1829.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('144', 'CW+HGE', '[CARGILL WALNUT] HOG GESTATING-', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1414.00', '1414.00', '1414.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', '1464.00', '0.00', '1464.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('145', 'CW+HS', '[CARGILL WALNUT] HOG STARTER', 'C/M', 'CARGILL/METROVET', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '1360.00', '1360.00', '1360.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', '1410.00', '0.00', '1410.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('146', 'CJ+HPSMP', ' [CJ MAX] HOG PRE STARTER MINI PEL', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('147', 'CL+HSP', '[CJ MAX] HOG STARTER PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('148', 'CJM+HGP', '[CJ MAX] HOG GROWER PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('149', 'CJM+HSP', '[CJ MAX] HOG STARTER PELLET=', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('150', 'CJM+HPSMP', '[CJ MAX] HOG PRE STARTER MINI PEL', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('151', 'CJM+HFP', '[CJ MAX] HOG FINISHER PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1275.00', '1275.00', '1275.00', '1395.00', '0.00', '1395.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('152', 'CJM+HPP', '[CJ MAX] HOG PREGGY/GESTATING PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1180.00', '1180.00', '1180.00', '1300.00', '0.00', '1300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('153', 'CJM+HMP', '[CJ MAX ]HOG MILKY/LACTATING PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1290.00', '1290.00', '1290.00', '1410.00', '0.00', '1410.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('154', 'CJM+CLC', '[CJ MAX] CHICKEN LAYER CRUMBLE ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1350.00', '1350.00', '1350.00', '1430.00', '0.00', '1430.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('155', 'CJJ+HSP', '[CJ JACKPOT] HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('156', 'CJJ+HGP', '[CJ JACKPOT] HOG GROWER PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1165.00', '1165.00', '1165.00', '1285.00', '0.00', '1285.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('157', 'CJJ+HFP', '[CJ JACKPOT] HOG FINISHER PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1125.00', '1125.00', '1125.00', '1245.00', '0.00', '1245.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('158', 'CJJ+HBP', '[CJ JACKPOT] HOG BROODSOW PELLET', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1075.00', '1075.00', '1075.00', '1195.00', '0.00', '1195.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('159', 'CJJ+HLP', '[CJ JACKPOT] HOG LACTATION PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('160', 'CJJ+HPDPP', '[CJ JACKPOT] HPDP PELLET ', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '920.00', '0.00', '920.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('161', 'GMCM+HGP', '..[GMC MEGA] HOG GROWER PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '1370.00', '0.00', '1370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('162', 'GMCM+HLP', '..[GMC MEGA] HOG LACTAING PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '1415.00', '0.00', '1415.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('163', 'GMCM+HGEP', '..[GMC MEGA] HOG GESTATING PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1175.00', '1175.00', '1175.00', '1345.00', '0.00', '1345.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('164', 'GMCK+PSP', '.[GMC KARGADO] PRE STARTER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1215.00', '1215.00', '1215.00', '1337.00', '0.00', '1337.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('165', 'GMCK+HSP', '.[GMC KARGADO] HOG STARTER PELLET ', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1535.00', '1535.00', '1535.00', '1650.00', '0.00', '1650.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('166', 'GMCK+HGP', '[GMC KARGADO] HOG GROWER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1365.00', '1365.00', '1365.00', '1500.00', '0.00', '1500.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('167', 'GMCK+HFP', '[GMC KARGADO] HOG FINISHER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1340.00', '1340.00', '1340.00', '1500.00', '0.00', '1500.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('168', 'GMCK+DLP', '[GMC KARGADO] DUCK LAYER PULLET', 'GMC', 'GENERAL MILLING CORP', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '1260.00', '0.00', '1260.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('169', 'VPMF+FPS', '[VIEPRO MILKFISH] FINISHER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '662.63', '0.00', '0.00', '772.50', '0.00', '772.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('170', 'VPM+GPS', '[VIEPRO MILKFISH] GROWER PELLET SINKER', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '686.38', '686.38', '686.38', '797.50', '0.00', '797.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('171', 'VPM+SC', '[VIEPRO MILKFISH] STARTER CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '719.63', '719.63', '719.63', '832.50', '0.00', '832.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('172', 'VPMF+PSC', '[VIEPRO MILKFISH] PRE STARTER CRUMBLE', 'VN', 'VIENOVO', 'FF', 'FISH FEED', '', '', 'P', '1', '1', '1', 'N', '780.88', '790.88', '790.88', '907.50', '0.00', '907.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('173', 'VP+PDPP', '[VIEPRO] PDP PELLET', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '777.94', '777.94', '777.94', '932.00', '0.00', '932.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('174', 'VP+DLP', '[VIEPRO] DUCK LAYER PELLET', 'VN', 'VIENOVO', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1098.04', '1098.04', '1098.04', '1292.00', '0.00', '1292.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('175', 'VP+CLM 2', '[VIEPRO] CHICKEN LAYER MASH 2', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('176', 'VP+CLM 1', '[VIEPRO] CLM 1', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1173.70', '1173.70', '1173.70', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('177', 'VP+LPD', '[VIEPRO]LAYER PULLET DEVELOPER MASH', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('178', 'VP+CDM', '[VIEPRO] CHICK DEVELOPER MASH', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('179', 'VP+CGP', '[VIEPRO] CHICK GROWER PELLET ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1154.30', '1154.30', '1154.30', '1350.00', '0.00', '1350.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('180', 'VPL+CSC', '[VIEPRO LAYER] CHICK STARTER CRUMBLE ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1256.15', '1256.15', '1256.15', '1455.00', '0.00', '1455.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('181', 'VPL+CGP', '[VIEPRO LAYER] CHICK GROWER PELLET ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1154.30', '1154.30', '1154.30', '1350.00', '0.00', '1350.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('182', 'VPL+CDM', '[VIEPRO LAYER] CHICK DEVELOPER MASH', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('183', 'VPL+CLM1', '[VIEPRO LAYER] CHICKEN LAYER MASH 1', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1173.70', '1173.70', '1173.70', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('184', 'VPL+CLM 2', '[VIEPRO LAYER] CHICKEN LAYER MASH 2', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1144.60', '1144.60', '1144.60', '1340.00', '0.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('185', 'VPL+DLP', '[VIEPRO LAYER] DUCK LAYER PELLET', 'VN', 'VIENOVO', 'DF', 'DUCK FEED', '', '', 'P', '1', '1', '1', 'N', '1098.04', '1098.04', '1098.04', '1292.00', '0.00', '1292.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('186', 'VPL+CBC', '[VIEPRO LAYER] CHICK BOOSTER CRUMBLE', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1391.95', '1391.95', '1391.95', '1595.00', '0.00', '1595.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('187', 'VPB+FP', '[VIEPRO BROILER] FINISHER PELLET ', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1401.65', '1401.65', '1401.65', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('188', 'VPB+GP', '[VIEPRO BROILER] GROWER PELLET ', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1421.05', '1421.05', '1421.05', '1610.00', '0.00', '1610.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('189', 'VPB+SC', '[VIEPRO BROILER] STARTER CRUMBLE ', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1455.00', '1455.00', '1455.00', '1465.00', '0.00', '1465.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('190', 'VPB+BC', '[VIEPRO BROILER] BOOSTER CRUMBLE', 'VN', 'VIENOVO', 'BF', 'BROILER FEED', '', '', 'P', '1', '1', '1', 'N', '1493.80', '1493.80', '1493.80', '1685.00', '0.00', '1685.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('191', 'VP+3000P', '[VIEPRO BOOST] 3000 PELLET 50KG', 'VN', 'VIENOVO', 'CS', 'CORN SEED', '', '', 'P', '1', '1', '1', 'N', '1192.25', '1192.25', '1192.25', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('192', 'VP+2000P', '[VIEPRO BOOST] 2000 CRUMBLE ', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1220.75', '1220.75', '1220.75', '1430.00', '0.00', '1430.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('193', 'VP+1000P', '[VIEPRO BOOST] 1000 CRUMBLE 50KG', 'VN', 'VIENOVO', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1372.75', '1372.75', '1372.75', '1590.00', '0.00', '1590.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('194', 'VPPRE+HLP', '[VIEPRO PREMIUM] HOG LACTATING PELLET ', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1301.50', '1301.50', '1301.50', '1535.00', '0.00', '1535.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('195', 'VPPRE+HGP', '[VIEPRO PREMIUM] HOG GESTATING PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1140.00', '1140.00', '1140.00', '1315.00', '0.00', '1315.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('196', 'VPPRE+HFP', '[VIEPRO PREMIUM] HOG FINISHER PELLET ', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1206.50', '1206.50', '1206.50', '1385.00', '0.00', '1385.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('197', 'VPPRE+HGEP', '[VIEPRO PREMIUM] HOG GESTATING PELLET=', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1140.00', '1140.00', '1140.00', '1315.00', '0.00', '1315.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('198', 'VPPRE+HGP=', '[VIEPRO PREMIUM] HOG GROWER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1254.00', '1254.00', '1254.00', '1435.00', '0.00', '1435.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('199', 'VPPRE+HSP', '[VIEPRO PREMIUM] HOG STARTER PELLET 50KG', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1455.00', '1455.00', '1455.00', '1505.00', '0.00', '1505.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('200', 'GMC+P', '[GMC] POLLARD', 'GMC', 'GENERAL MILLING CORP', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('201', 'GMC+RP', '[GMC] RED PELLET', 'GMC', 'GENERAL MILLING CORP', 'FA', 'FEED ADDITIVE', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('202', 'GMCV+HGM', '[GMC VALUE] HOG GROWER MASH', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1250.00', '0.00', '1250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('203', 'GMCV+HGP', '[GMC VLAUE] HOG GROWER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1270.00', '0.00', '1270.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('204', 'B+CLC', '[BOUNTY CHICKEN LAYER MASH', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '1220.00', '1220.00', '1220.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('205', ' BSS', 'BELMET-ANTI MALARIA 960ML', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', '', '', 'P', '1', '1', '1', 'N', '620.00', '620.00', '620.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', '720.00', '0.00', '720.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('206', 'GMCM+HSP', '[GMC MEGAMIX] HOG STARTER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1250.00', '0.00', '1250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('207', 'GMC+PBP', '[GMC] PIGLET BOOSTER PELLET', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '60.00', '60.00', '60.00', '80.00', '0.00', '80.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('208', 'B+CM', '[BOUNTY] COPRA MILL', 'B+', 'BOUNTY PLUS', 'FRM', 'FEED RAW MAATERIAL ', '', '', 'P', '1', '1', '1', 'N', '900.00', '900.00', '900.00', '1000.00', '0.00', '1000.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('209', 'B+CP', '[BOUNTY} COPRA PELLETS', 'B+', 'BOUNTY PLUS', 'FRM', 'FEED RAW MAATERIAL ', '', '', 'P', '1', '1', '1', 'N', '650.00', '650.00', '650.00', '700.00', '0.00', '700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('210', 'ES+CLC', '[EXCEL SUPER] CHICKEN LAYER CRUMBLE', 'E', 'EXCEL', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1505.00', '1505.00', '1505.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('211', 'VPPRI+HGEP', '[VIEPRO PRIME] HOG GESTATING PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1225.00', '1225.00', '1225.00', '1370.00', '0.00', '1370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('212', 'VPPRI+HLP', '[VIEPRO PRIME] HOG LACTATING PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1395.00', '1395.00', '1395.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('213', 'VPPRI+HFP', '[VIEPRO PRIME] HOG FIMISHER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1295.00', '1295.00', '1295.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('214', 'VPPRI+HGP', '[VIEPRO PRIME] HOG GROWER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'C', '1', '1', '1', 'N', '1345.00', '1345.00', '1345.00', '1490.00', '0.00', '1490.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('215', 'VPPRI+HSP', '[VIEPRO PRIME] HOG STARTER PELLET', 'VN', 'VIENOVO', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1415.00', '1415.00', '1415.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('216', 'CJ+L3', 'CJ+LEGION 3 (MAINTENANCE)', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '5.00', '5.00', '5.00', '5.00', '0.00', '5.00', '6.00', '0.00', '6.00', '7.00', '0.00', '7.00', '8.00', '0.00', '8.00', '9.00', '0.00', '9.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('217', 'CJ+L2', '[CJ] LEGION 2 (CHICK GROWER)', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('218', 'CJ+L1', '[CJ] LEGION 1 (CHICK BOOSTER)', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('219', 'BS+BS', '[BOUNTY SILVER] BROOD SOW PELLET', 'B+', 'BOUNTY PLUS', 'HF', 'HOG FEED', '', '', 'P', '1', '1', '1', 'N', '1300.00', '1300.00', '1300.00', '1350.00', '0.00', '1350.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('221', 'W52', 'WINGS POWDER DETERGENT 52GX150', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '150', '1', '1', 'N', '900.00', '900.00', '6.00', '900.00', '0.00', '6.00', '910.00', '0.00', '6.07', '920.00', '0.00', '6.13', '930.00', '0.00', '6.20', '940.00', '0.00', '6.27', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('222', 'WW52', 'WINGS POWDER WHITE DETERGENT 52GX150', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '150', '1', '1', 'N', '900.00', '900.00', '6.00', '910.00', '0.00', '6.07', '920.00', '0.00', '6.13', '930.00', '0.00', '6.20', '940.00', '0.00', '6.27', '950.00', '0.00', '6.33', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('223', 'TW10S', 'TOP CAFE WHITE 30G 10\'S (36 STRNGS)', 'GSPI', 'GENTLE SUPPREME PHILS.', 'TC', 'TOP CAFE', '', '', 'C', '360', '10', '1', 'N', '1386.00', '1386.00', '3.85', '1386.00', '38.50', '3.85', '1396.00', '38.80', '3.88', '1400.00', '38.90', '3.89', '1405.00', '39.00', '3.90', '1410.00', '39.20', '3.92', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('224', 'TBR10S', 'TOP CAFE BROWN 25G 10\'S (36 STRNGS)', 'GSPI', 'GENTLE SUPPREME PHILS.', 'TC', 'TOP CAFE', '', '', 'C', '360', '10', '1', 'N', '1386.00', '1386.00', '3.85', '1386.00', '38.50', '3.85', '1396.00', '38.80', '3.88', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('225', 'TBD10S', 'TOP CAFE BREWED 22G 10\'S (36 STRNGS)', 'GSPI', 'GENTLE SUPPREME PHILS.', 'TC', 'TOP CAFE', '', '', 'C', '360', '10', '1', 'N', '1386.00', '1386.00', '3.85', '1386.00', '38.50', '3.85', '1396.00', '0.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('227', 'MSD', 'MISEDAAP NOODLES REGULAR 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '5', 'N', '480.00', '470.00', '11.75', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-06-06 06:54:56');
INSERT INTO `ivitem_copy` VALUES ('228', 'MSK', 'MISEDAAP KALAMANSI 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '5', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('229', 'WTC52', 'WINGS WHITE POWDER 52X150', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '150', '1', '1', 'N', '900.00', '900.00', '6.00', '900.00', '0.00', '6.00', '900.00', '0.00', '6.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('231', 'GB80', 'GIV BEAUTY SOAP BLUE 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1180.00', '0.00', '16.39', '1185.00', '0.00', '16.46', '1190.00', '0.00', '16.53', '1195.00', '0.00', '16.60', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('232', 'GP80', 'GIV BEAUTY SOAP PINK 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('233', 'GW80', 'GIV BEAUTY SOAP WHITE 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('234', 'GBR80', 'GIV BEAUTY SOAP BROWN 80GX72', 'GSPI', 'GENTLE SUPPREME PHILS.', 'GIV', 'GIV BEAUTY SOAP', '', '', 'C', '72', '1', '1', 'N', '1176.00', '1176.00', '16.33', '1176.00', '0.00', '16.33', '1176.00', '0.00', '16.33', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('235', 'MKS', 'MISEDAAP KOREAN SPICY CHICKEN 87G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('236', 'MMA', 'MISEDAAP MIGORENG ASLI 91G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('237', 'MAB', 'MISEDAAP MISUP AYAMBAWANG 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('238', 'MPS', 'MISEDAAP MISUP PERISASOTO 70G 40X5', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MD', 'MISEDAAP NODLES', '', '', 'C', '40', '5', '1', 'N', '480.00', '480.00', '12.00', '480.00', '60.00', '12.00', '485.00', '60.65', '12.13', '490.00', '61.25', '12.25', '495.00', '61.90', '12.38', '500.00', '62.50', '12.50', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('239', 'W100', 'WINGS BAR WHITE 100GX36', 'GSPI', 'GENTLE SUPPREME PHILS.', 'BAR', 'BAR DETERGENT', '', '', 'C', '36', '1', '1', 'N', '352.80', '352.80', '9.80', '352.80', '0.00', '9.80', '360.00', '0.00', '10.00', '365.50', '0.00', '10.15', '370.80', '0.00', '10.30', '400.00', '0.00', '11.11', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('240', 'W420', 'WINGS WHITE BAR 36X420G', 'GSPI', 'GENTLE SUPPREME PHILS.', 'PD', 'POWDER DETERGENT', '', '', 'C', '36', '1', '1', 'N', '658.44', '658.44', '18.29', '658.44', '0.00', '18.29', '660.00', '0.00', '18.33', '670.00', '0.00', '18.61', '675.00', '0.00', '18.75', '680.00', '0.00', '18.89', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');
INSERT INTO `ivitem_copy` VALUES ('241', 'W390', 'WINGS BAR WGITE DETERGENT 150GX96', 'GSPI', 'GENTLE SUPPREME PHILS.', 'BAR', 'BAR DETERGENT', '', '', 'C', '96', '1', '1', 'N', '647.04', '647.04', '6.74', '647.04', '0.00', '6.74', '660.50', '0.00', '6.88', '680.80', '0.00', '7.09', '700.00', '0.00', '7.29', '705.00', '0.00', '7.34', 'N', null, '0', '0.00', null, null, null, '0', null, '2022-04-16', '2022-04-16 05:57:20');

-- ----------------------------
-- Table structure for ivitem_old
-- ----------------------------
DROP TABLE IF EXISTS `ivitem_old`;
CREATE TABLE `ivitem_old` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `description` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `supcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `supplier` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `catcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `category` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `brcode` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `brand` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `unit` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `pckgc` int(10) DEFAULT NULL,
  `pckgb` int(10) DEFAULT NULL,
  `pckgp` int(10) DEFAULT NULL,
  `freeitem` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `grscost` decimal(15,2) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `apricec` decimal(15,2) DEFAULT NULL,
  `apriceb` decimal(15,2) DEFAULT NULL,
  `apricep` decimal(15,2) DEFAULT NULL,
  `bpricec` decimal(15,2) DEFAULT NULL,
  `bpriceb` decimal(15,2) DEFAULT NULL,
  `bpricep` decimal(15,2) DEFAULT NULL,
  `cpricec` decimal(15,2) DEFAULT NULL,
  `cpriceb` decimal(15,2) DEFAULT NULL,
  `cpricep` decimal(15,2) DEFAULT NULL,
  `obsolet` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `lastpurc` date DEFAULT NULL,
  `discpct` int(10) DEFAULT NULL,
  `wtkg` decimal(15,2) DEFAULT NULL,
  `unitc` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitb` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `unitp` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `status` int(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=76 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivitem_old
-- ----------------------------
INSERT INTO `ivitem_old` VALUES ('1', 'HKG', 'KARGADO HOG GROWER 50KG', 'GM', 'GENERAL MILLING CORP.', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1465.00', '1465.00', '1465.00', '1465.00', '0.00', '1465.00', '1455.00', '0.00', '1455.00', '1445.00', '0.00', '1445.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2021-09-26 09:45:44');
INSERT INTO `ivitem_old` VALUES ('2', 'BCG', 'BOUNTY CHICK GROWER', 'GM', 'GENERAL MILLING CORP.', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1280.00', '0.00', '1280.00', '1270.00', '0.00', '1270.00', '1260.00', '0.00', '1260.00', 'N', null, '0', '500.00', null, null, null, '1', null, '2021-09-26 09:45:16');
INSERT INTO `ivitem_old` VALUES ('3', 'KHPS', 'KARGADO PRE STARTER PELLET 25KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1215.00', '1215.00', '1215.00', '1645.00', '0.00', '1645.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2021-09-28 10:51:24');
INSERT INTO `ivitem_old` VALUES ('4', 'KHS', 'KARGADO HOG STARTER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1535.00', '1535.00', '1535.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-28 10:49:39');
INSERT INTO `ivitem_old` VALUES ('5', 'KHG', 'KARGADO HOG GROWER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1365.00', '1365.00', '1365.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-26 11:36:15');
INSERT INTO `ivitem_old` VALUES ('6', 'KHF', 'KARGADO HOG FINISHER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1340.00', '1340.00', '1340.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-10-06 06:59:36');
INSERT INTO `ivitem_old` VALUES ('7', 'MMHL-GMC', 'MEGAMIX HOG LACTATING 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2021-09-26 10:43:42');
INSERT INTO `ivitem_old` VALUES ('8', 'MMHG-GMC', 'MEGAMIX HOG GESTATING 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2021-09-26 10:43:49');
INSERT INTO `ivitem_old` VALUES ('9', 'SPMHPS', 'S PIGGYMAX HOG PRE STARTER MINI PEL 25KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1035.00', '1035.00', '1035.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '25.00', null, null, null, '0', null, '2021-09-29 11:38:07');
INSERT INTO `ivitem_old` VALUES ('10', 'MMHG', 'MEGAMIX HOG GESTATING PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1175.00', '1175.00', '1175.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-28 22:23:21');
INSERT INTO `ivitem_old` VALUES ('11', 'MMHL', 'MEGAMIX HOG LACTAING PELLET 50GKG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1255.00', '1255.00', '1255.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-28 22:22:56');
INSERT INTO `ivitem_old` VALUES ('12', 'SMMHS', 'S MUSCLE MAX HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1420.00', '1420.00', '1420.00', '1540.00', '0.00', '1540.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:44:15');
INSERT INTO `ivitem_old` VALUES ('13', 'SMMHG', 'S MUSCLE MAX HOG GROWER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:43:53');
INSERT INTO `ivitem_old` VALUES ('14', 'SMMHF', 'S MUSCLE MAX HOG FINISHER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1275.00', '1275.00', '1275.00', '1395.00', '0.00', '1395.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:43:26');
INSERT INTO `ivitem_old` VALUES ('15', 'SMMHP', 'S MUSCLE MAX HOG PREGGY PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1180.00', '1180.00', '1180.00', '1300.00', '0.00', '1300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:43:05');
INSERT INTO `ivitem_old` VALUES ('16', 'SMMHM', 'S MUCSLE MAX HOG MILKY PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1290.00', '1290.00', '1290.00', '1410.00', '0.00', '1410.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:42:46');
INSERT INTO `ivitem_old` VALUES ('17', 'PMJHS', 'P MEGA JACKPOT HOG STARTER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1280.00', '1280.00', '1280.00', '1400.00', '0.00', '1400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:42:15');
INSERT INTO `ivitem_old` VALUES ('18', 'PJMHG', 'P MEGA JACKPOT HOG GROWER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1165.00', '1165.00', '1165.00', '1285.00', '0.00', '1285.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:41:52');
INSERT INTO `ivitem_old` VALUES ('19', 'PMJHF', 'P MEGA JACKPOT HOG FINISHER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1125.00', '1125.00', '1125.00', '1245.00', '0.00', '1245.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-10-06 06:59:21');
INSERT INTO `ivitem_old` VALUES ('20', 'PMJHB', 'P MEGA JACKPOT HOG BROODSOW PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1075.00', '1075.00', '1075.00', '1195.00', '0.00', '1195.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-10-06 06:59:13');
INSERT INTO `ivitem_old` VALUES ('21', 'PMJHL', 'P MEGA JACKPOT HOG LACTATION PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1320.00', '1320.00', '1320.00', '1440.00', '0.00', '1440.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-10-06 06:59:06');
INSERT INTO `ivitem_old` VALUES ('22', 'PMJHPDP', 'P MEGA JACKPOT HPDP PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '920.00', '0.00', '920.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-10-06 06:58:57');
INSERT INTO `ivitem_old` VALUES ('23', 'L1', 'LEGION 1 (CHICK BOOSTER) 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1440.00', '1440.00', '1440.00', '1560.00', '0.00', '1560.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:39:48');
INSERT INTO `ivitem_old` VALUES ('24', 'L2', 'LEGION 2 (CHICK GROWER) 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1270.00', '1270.00', '1270.00', '1390.00', '0.00', '1390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:39:27');
INSERT INTO `ivitem_old` VALUES ('25', 'L3', 'LEGION 3 (MAINTENACE) PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1120.00', '1120.00', '1120.00', '1240.00', '0.00', '1240.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:39:08');
INSERT INTO `ivitem_old` VALUES ('26', 'CLMC', 'CHICKEN LAYER MAX CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1200.00', '1200.00', '1200.00', '1310.00', '0.00', '1310.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:38:40');
INSERT INTO `ivitem_old` VALUES ('27', 'PDL', 'PREMIUM DUCK LAYER PELLET 50KG', 'CJP', 'CJ PHILIPPINES', 'DF', 'DUCK FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1185.00', '1185.00', '1185.00', '1235.00', '0.00', '1235.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-29 11:44:43');
INSERT INTO `ivitem_old` VALUES ('28', 'BMB', 'BROILERMAX BOOSTER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2021-09-28 06:31:01');
INSERT INTO `ivitem_old` VALUES ('29', 'BMS', 'BROILERMAX STARTER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2021-09-28 06:35:44');
INSERT INTO `ivitem_old` VALUES ('30', 'BMG', 'BROILER MAX GROWER CRUMBLE 50KG', 'CJP', 'CJ PHILIPPINES', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '1', null, '2021-09-28 06:45:04');
INSERT INTO `ivitem_old` VALUES ('31', 'B+CLM', 'BOUNTY+CHICKEN LAYER MASH 50KG', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1125.00', '0.00', '0.00', '1280.00', '0.00', '1280.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-30 06:04:36');
INSERT INTO `ivitem_old` VALUES ('32', 'B+CGM', 'BOUNTY+CHICK GROWER MASH 50KG', 'B+', 'BOUNTY PLUS', 'CF', 'CHICKEN FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1151.00', '1151.00', '1151.00', '1290.00', '0.00', '1290.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-30 06:04:48');
INSERT INTO `ivitem_old` VALUES ('33', 'VBCAA', 'VITAMIN B COMLEX+AMINO ACID(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '400.00', '400.00', '400.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:48:35');
INSERT INTO `ivitem_old` VALUES ('34', 'CP', 'CALCIUM PHOSPHORUS(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '280.00', '280.00', '280.00', '320.00', '0.00', '320.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 06:22:36');
INSERT INTO `ivitem_old` VALUES ('35', 'PE', 'PURE ELECTROLYTE(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2021-09-26 23:19:53');
INSERT INTO `ivitem_old` VALUES ('36', 'IO', 'IVERMECTINE(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '820.00', '820.00', '820.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 04:05:57');
INSERT INTO `ivitem_old` VALUES ('37', 'A', 'AMPROLLIUM(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1000.00', '1000.00', '1000.00', '1100.00', '0.00', '1100.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 04:13:03');
INSERT INTO `ivitem_old` VALUES ('38', 'TTGS', 'TYLOSIN TARTRATE+GENTAMICIN(ORAL)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '3', '0', '0', 'N', '2480.00', '2480.00', '620.00', '2480.00', '1240.00', '620.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2021-09-26 22:30:04');
INSERT INTO `ivitem_old` VALUES ('39', 'TTG', 'TYLOSIN TARTRATE+GENTAMICIN(ORAL)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1975.00', '1975.00', '493.75', '2480.00', '0.00', '620.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-30 06:35:01');
INSERT INTO `ivitem_old` VALUES ('40', 'TMPS', 'TMPS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '830.00', '830.00', '830.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 06:17:48');
INSERT INTO `ivitem_old` VALUES ('41', 'B', 'BELMET-ANTIMALARIA(ORAL)1LTR', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '675.00', '675.00', '675.00', '720.00', '0.00', '720.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:25:38');
INSERT INTO `ivitem_old` VALUES ('42', 'G', 'GLUTAMED(LIQUID DISIFECTANT)4LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '220.00', '220.00', '220.00', '220.00', '0.00', '220.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-30 23:58:18');
INSERT INTO `ivitem_old` VALUES ('43', 'EG', 'EGG BOOSTER(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '630.00', '630.00', '630.00', '700.00', '0.00', '700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 02:19:33');
INSERT INTO `ivitem_old` VALUES ('44', 'NBP', 'NUTRA-B PLUS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '380.00', '380.00', '380.00', '450.00', '0.00', '450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:34:04');
INSERT INTO `ivitem_old` VALUES ('45', 'VC', 'VITAMIN-C(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '770.00', '770.00', '770.00', '870.00', '0.00', '870.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 02:12:57');
INSERT INTO `ivitem_old` VALUES ('46', 'CPO', 'CALCIUM PHOSPHORUS(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '280.00', '0.00', '0.00', '450.00', '0.00', '450.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 02:18:59');
INSERT INTO `ivitem_old` VALUES ('47', 'PEO', 'PURE ELECTROLYTE(ORAL)1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '170.00', '170.00', '170.00', '220.00', '0.00', '220.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:50:56');
INSERT INTO `ivitem_old` VALUES ('48', 'PEC', 'PURE ELECTROLYTE.(CANISTER)1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '120.00', '120.00', '120.00', '170.00', '0.00', '170.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:49:50');
INSERT INTO `ivitem_old` VALUES ('49', 'VBCI', 'VITAMIN-B COMPLEX (INJECTABLE)100ML', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '230.00', '230.00', '230.00', '300.00', '0.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 02:14:06');
INSERT INTO `ivitem_old` VALUES ('50', 'O', 'OXYTOCIN', 'MD', 'MEDLAND', 'LSS', 'LIVE STOCK STIMULANT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-26 23:55:12');
INSERT INTO `ivitem_old` VALUES ('51', 'II', 'IVERMECTIN(INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '320.00', '320.00', '320.00', '370.00', '0.00', '370.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 07:36:21');
INSERT INTO `ivitem_old` VALUES ('52', 'E10%', 'ENROFLOXACIN10% (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-26 23:58:40');
INSERT INTO `ivitem_old` VALUES ('53', 'E20%', 'ENROFLOXACIN20% (INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '340.00', '340.00', '340.00', '390.00', '0.00', '390.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 02:14:48');
INSERT INTO `ivitem_old` VALUES ('54', 'LSB', 'LSB(INJECTABLE) 100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '1', null, '2021-10-01 06:48:51');
INSERT INTO `ivitem_old` VALUES ('55', 'LH', 'LINCOMYCIN HYDROCHLORIDE', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 00:04:16');
INSERT INTO `ivitem_old` VALUES ('56', 'IPM', 'IVERMECTIN1% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2021-09-27 00:20:07');
INSERT INTO `ivitem_old` VALUES ('57', 'LSBPM', 'LSB1% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '1', null, '2021-09-27 00:15:46');
INSERT INTO `ivitem_old` VALUES ('58', 'CSFPM', 'COLISTIN SULFATE10% (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '800.00', '800.00', '800.00', '900.00', '0.00', '900.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 06:29:56');
INSERT INTO `ivitem_old` VALUES ('59', 'LSBFMP', 'LSB1%. (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '700.00', '700.00', '700.00', '800.00', '0.00', '800.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:27:10');
INSERT INTO `ivitem_old` VALUES ('60', 'IFPM ', 'IVERMECTIN1%. (FEED PRE MIX) 1KG', 'MD', 'MEDLAND', 'LSFPM', 'LIVE STOCK FEED PRE MIX ', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '510.00', '510.00', '510.00', '610.00', '0.00', '610.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:28:56');
INSERT INTO `ivitem_old` VALUES ('61', 'HC', 'HEXAMIDE CREAM (ANTI SEPTIC CREAM)', 'BL', 'BELMAN LABORATORIES', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '38.00', '38.00', '38.00', '50.00', '0.00', '50.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 07:20:22');
INSERT INTO `ivitem_old` VALUES ('62', 'CPFS', 'CECICAL POWDER (FEED SUPPLEMENT)', 'BL', 'BELMAN LABORATORIES', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 00:58:08');
INSERT INTO `ivitem_old` VALUES ('63', 'PP', 'PIDRO POWDER', 'BL', 'BELMAN LABORATORIES', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 00:59:16');
INSERT INTO `ivitem_old` VALUES ('64', 'MVE', 'MULTI VITAMINS (FOIL) 1KG', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '200.00', '200.00', '200.00', '250.00', '0.00', '250.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '1.00', null, null, null, '0', null, '2021-09-27 07:55:48');
INSERT INTO `ivitem_old` VALUES ('65', 'ID', 'IRON DEXTRANT ', 'BL', 'BELMAN LABORATORIES', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '272.00', '0.00', '0.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 07:15:53');
INSERT INTO `ivitem_old` VALUES ('66', 'BN', 'BIO-NUTRILYTES                          ', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '520.00', '520.00', '520.00', '600.00', '0.00', '600.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-10-01 06:33:30');
INSERT INTO `ivitem_old` VALUES ('67', 'WO', 'WASH OUT', 'LDI', 'LAKPUE DRUGS INC', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'C', '1', '1', '1', 'N', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 01:28:39');
INSERT INTO `ivitem_old` VALUES ('68', 'ZP', 'ZINC PHOSPHIDE (RAT POISON)', 'LDI', 'LAKPUE DRUGS INC', 'PI', 'PESTICIDE AND INSECTICIDE', 'BR1', 'BRAND NAME 1', 'C', '12', '1', '1', 'N', '780.00', '780.00', '65.00', '785.00', '0.00', '65.42', '790.00', '0.00', '65.83', '795.00', '0.00', '66.25', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-10-12 05:38:43');
INSERT INTO `ivitem_old` VALUES ('69', 'MVEO', 'MULTI VITAMINS (ORAL) 1LTR', 'MD', 'MEDLAND', 'LSV', 'LIVE STOCK VITAMINS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '680.00', '680.00', '680.00', '700.00', '0.00', '700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-10-01 06:31:11');
INSERT INTO `ivitem_old` VALUES ('70', 'CSP', 'CHLOR SP (FEED SUPPLEMENT)', 'BL', 'BELMAN LABORATORIES', 'LSFS', 'LIVE STOCK FEED SUPPLEMENT', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '123.00', '123.00', '123.00', '170.00', '0.00', '170.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-10-06 06:59:51');
INSERT INTO `ivitem_old` VALUES ('71', 'C', 'COMBINEX ANTI SEPTIC SPRAY (AEROSOL)', 'MD', 'MEDLAND', 'LSMS', 'LIVE STOCK MEDICAL SUPPLIES', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '250.00', '250.00', '250.00', '300.00', '0.00', '300.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-10-01 06:31:37');
INSERT INTO `ivitem_old` VALUES ('72', 'N20%', 'NORFLOXACIN20% (ORAL) 1LTR', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '830.00', '830.00', '830.00', '930.00', '0.00', '930.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 06:20:03');
INSERT INTO `ivitem_old` VALUES ('73', 'AT20%', 'AMOXICILLIN TRIHYDRATE (INJECTABLE)100ML', 'MD', 'MEDLAND', 'LSA', 'LIVE STOCK ANTIBIOTICS', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '300.00', '300.00', '300.00', '400.00', '0.00', '400.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-09-27 07:32:14');
INSERT INTO `ivitem_old` VALUES ('74', 'MMHGR', 'MEGAMIX HOG GROWER PELLET 50KG', 'GMC', 'GENERAL MILLING CORP', 'HF', 'HOG FEED', 'BR1', 'BRAND NAME 1', 'P', '1', '1', '1', 'N', '1230.00', '1230.00', '1230.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', 'N', null, '0', '50.00', null, null, null, '0', null, '2021-09-28 10:45:52');
INSERT INTO `ivitem_old` VALUES ('75', '1', 'WERTYUYUYUYUYU', 'BL', 'BELMAN LABORATORIES', 'CF', 'CHICKEN FEED', '', '', 'P', '1', '1', '1', 'N', '10.00', '1.00', '1.00', '20.00', '0.00', '20.00', '30.00', '0.00', '3.00', '40.00', '0.00', '4.00', 'N', null, '0', '0.00', null, null, null, '0', null, '2021-10-15 12:50:08');

-- ----------------------------
-- Table structure for ivwh
-- ----------------------------
DROP TABLE IF EXISTS `ivwh`;
CREATE TABLE `ivwh` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(12) NOT NULL DEFAULT '',
  `whscode` varchar(5) DEFAULT NULL,
  `qty_good` decimal(10,2) DEFAULT '0.00',
  `qty_bo` decimal(10,2) DEFAULT '0.00',
  `idtime` datetime DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=163 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh
-- ----------------------------
INSERT INTO `ivwh` VALUES ('1', 'GB80', 'YLK', '0.00', '12.00', null, null, '2022-09-04 00:55:44');
INSERT INTO `ivwh` VALUES ('2', 'GBR80', 'YLK', '72.00', '12.00', null, null, '2022-09-04 00:55:44');
INSERT INTO `ivwh` VALUES ('3', 'GP80', 'YLK', '72.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh` VALUES ('4', 'GW80', 'YLK', '11784.00', '0.00', null, null, '2022-09-03 14:12:03');
INSERT INTO `ivwh` VALUES ('5', 'MSK', 'YLK', '520.00', '0.00', null, null, '2022-09-04 00:18:58');
INSERT INTO `ivwh` VALUES ('6', 'MKS', 'YLK', '600.00', '0.00', null, null, '2022-09-03 13:45:14');
INSERT INTO `ivwh` VALUES ('7', 'MMA', 'YLK', '3920.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh` VALUES ('8', 'MAB', 'YLK', '3960.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh` VALUES ('9', 'MPS', 'YLK', '4010.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh` VALUES ('10', 'MSD', 'YLK', '600.00', '0.00', null, null, '2022-09-04 00:18:58');
INSERT INTO `ivwh` VALUES ('11', 'W52', 'YLK', '865.00', '299.00', null, null, '2022-09-04 02:56:45');
INSERT INTO `ivwh` VALUES ('12', 'WW52', 'YLK', '1200.00', '0.00', null, null, '2022-09-04 00:43:25');
INSERT INTO `ivwh` VALUES ('13', 'WTC52', 'YLK', '0.00', '0.00', null, null, '2022-09-04 00:17:37');
INSERT INTO `ivwh` VALUES ('14', 'GB80', '3AW', '1795.00', '0.00', null, null, '2022-07-19 06:23:15');
INSERT INTO `ivwh` VALUES ('15', 'W52', 'WHS1', '15000.00', '0.00', null, null, '2022-09-04 00:34:52');
INSERT INTO `ivwh` VALUES ('16', 'WW52', 'WHS1', '15000.00', '0.00', null, null, '2022-09-04 00:34:52');
INSERT INTO `ivwh` VALUES ('17', 'WTC52', 'WHS1', '300.00', '0.00', null, null, '2022-06-30 06:35:21');
INSERT INTO `ivwh` VALUES ('18', 'GP80', 'WHS1', '1008.00', '0.00', null, null, '2022-07-16 07:31:48');
INSERT INTO `ivwh` VALUES ('19', 'GW80', 'WHS1', '144.00', '0.00', null, null, '2022-06-30 06:35:23');
INSERT INTO `ivwh` VALUES ('20', 'GB80', 'WHS2', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh` VALUES ('21', 'GB80', 'WHS3', '710.00', '0.00', null, null, '2022-07-20 03:11:30');
INSERT INTO `ivwh` VALUES ('22', 'GP80', 'WHS3', '1430.00', '0.00', null, null, '2022-07-20 03:12:12');
INSERT INTO `ivwh` VALUES ('23', 'GW80', 'WHS3', '791.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh` VALUES ('24', 'GBR80', 'WHS3', '792.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh` VALUES ('25', 'GB80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh` VALUES ('26', 'GP80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh` VALUES ('27', 'GW80', 'WHS4', '1440.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh` VALUES ('28', 'GBR80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh` VALUES ('29', 'GB80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh` VALUES ('30', 'GW80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh` VALUES ('31', 'GP80', 'WHS5', '0.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh` VALUES ('32', 'GB80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('33', 'GW80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('34', 'GP80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('35', 'GBR80', 'WHS6', '710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('36', 'GB80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('37', 'GW80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('38', 'GP80', 'WHS7', '720.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('39', 'GBR80', 'WHS7', '-710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh` VALUES ('40', 'GBR80', 'WHS2', '0.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh` VALUES ('41', 'GB80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh` VALUES ('42', 'GBR80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh` VALUES ('43', 'GB80', 'WHS8', '360.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh` VALUES ('44', 'GBR80', 'WHS8', '-360.00', '0.00', null, null, '2022-07-21 07:06:52');
INSERT INTO `ivwh` VALUES ('45', 'GP80', 'WHS8', '288.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh` VALUES ('46', 'GB80', 'WHS9', '1065.00', '0.00', null, null, '2022-07-22 02:37:13');
INSERT INTO `ivwh` VALUES ('47', 'GBR80', 'WHS9', '1204.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh` VALUES ('48', 'GP80', 'WHS9', '504.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh` VALUES ('49', 'MSK', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh` VALUES ('50', 'MKS', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh` VALUES ('51', 'MMA', 'WHS9', '0.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh` VALUES ('52', 'MAB', 'WHS9', '40.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh` VALUES ('53', 'MPS', 'WHS9', '40.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh` VALUES ('54', 'MSD', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh` VALUES ('55', 'W52', '3AW', '150.00', '0.00', null, null, '2022-09-04 00:36:29');
INSERT INTO `ivwh` VALUES ('56', 'GB80', 'WH10', '-5.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh` VALUES ('57', 'GBR80', 'WH10', '-10.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh` VALUES ('58', 'GP80', 'WH10', '0.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh` VALUES ('59', 'GB80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh` VALUES ('60', 'GBR80', 'WHS11', '0.00', '0.00', null, null, '2022-07-21 07:01:48');
INSERT INTO `ivwh` VALUES ('61', 'GP80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh` VALUES ('62', 'GB80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh` VALUES ('63', 'GBR80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh` VALUES ('64', 'GP80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh` VALUES ('65', 'W52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh` VALUES ('66', 'WW52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh` VALUES ('67', 'WTC52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh` VALUES ('68', 'W52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:32:08');
INSERT INTO `ivwh` VALUES ('69', 'WW52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh` VALUES ('70', 'WTC52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh` VALUES ('71', 'MKS', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh` VALUES ('72', 'MSK', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh` VALUES ('73', 'MKS', 'WHS14', '4.00', '0.00', null, null, '2022-07-19 08:52:24');
INSERT INTO `ivwh` VALUES ('74', 'MSK', 'WHS14', '4.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh` VALUES ('75', 'W52', 'WHS14', '140.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh` VALUES ('76', 'WW52', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh` VALUES ('77', 'GBR80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh` VALUES ('78', 'MSK', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh` VALUES ('79', 'GP80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh` VALUES ('80', 'MKS', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh` VALUES ('81', 'W52', 'WHS15', '75.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh` VALUES ('82', 'WW52', 'WHS15', '1650.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh` VALUES ('83', 'WTC52', 'WHS15', '0.00', '0.00', null, null, '2022-07-27 07:49:08');
INSERT INTO `ivwh` VALUES ('84', 'GP80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh` VALUES ('85', 'GW80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh` VALUES ('86', 'GB80', 'WHS14', '432.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh` VALUES ('87', 'MSD', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh` VALUES ('88', 'GBR80', 'WHS14', '360.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh` VALUES ('89', 'GP80', 'WHS14', '77.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh` VALUES ('90', 'W52', 'WHS16', '1650.00', '0.00', null, null, '2022-07-20 01:50:32');
INSERT INTO `ivwh` VALUES ('91', 'WW52', 'WHS16', '1500.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh` VALUES ('92', 'WTC52', 'WHS16', '0.00', '0.00', null, null, '2022-07-20 01:52:43');
INSERT INTO `ivwh` VALUES ('93', 'MSK', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh` VALUES ('94', 'MKS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh` VALUES ('95', 'MSD', 'WHS16', '65.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh` VALUES ('96', 'MMA', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh` VALUES ('97', 'MAB', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh` VALUES ('98', 'MPS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh` VALUES ('99', 'TBD10\'S', 'YLK', '7200.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh` VALUES ('100', 'TBR10\'S', 'YLK', '3610.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh` VALUES ('101', 'TW10\'S', 'YLK', '7190.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh` VALUES ('102', 'WTC52', 'WHS14', '1500.00', '0.00', null, null, '2022-07-20 01:34:14');
INSERT INTO `ivwh` VALUES ('103', 'MSK', 'WHS17', '440.00', '0.00', null, null, '2022-07-22 09:02:45');
INSERT INTO `ivwh` VALUES ('104', 'MSD', 'WHS17', '321.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh` VALUES ('105', 'MAB', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh` VALUES ('106', 'MMA', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh` VALUES ('107', 'MSK', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh` VALUES ('108', 'MKS', 'WHS15', '25.00', '0.00', null, null, '2022-07-21 07:35:22');
INSERT INTO `ivwh` VALUES ('109', 'MAB', 'WHS17', '325.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh` VALUES ('110', 'MMA', 'WHS17', '80.00', '0.00', null, null, '2022-07-21 05:42:10');
INSERT INTO `ivwh` VALUES ('111', 'MKS', 'WHS17', '439.00', '0.00', null, null, '2022-07-22 08:48:24');
INSERT INTO `ivwh` VALUES ('112', 'W52', 'WHS17', '150.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh` VALUES ('113', 'TW10\'S', 'WHS16', '2160.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh` VALUES ('114', 'TBR10\'S', 'WHS16', '1800.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh` VALUES ('115', 'TW10\'S', 'WHS17', '360.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh` VALUES ('116', 'TBR10\'S', 'WHS17', '-360.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh` VALUES ('117', 'TBD10\'S', 'WHS17', '720.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh` VALUES ('118', 'GB80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh` VALUES ('119', 'GBR80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh` VALUES ('120', 'WW52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh` VALUES ('121', 'WTC52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh` VALUES ('122', 'GW80', 'WHS17', '0.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh` VALUES ('123', 'W52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh` VALUES ('124', 'WW52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh` VALUES ('125', 'WTC52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh` VALUES ('126', 'GBR80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh` VALUES ('127', 'GW80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh` VALUES ('128', 'TW10\'S', 'WHS18', '-90.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh` VALUES ('129', 'TBR10\'S', 'WHS18', '0.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh` VALUES ('130', 'GP80', 'WHS16', '72.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh` VALUES ('131', 'W52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:57:22');
INSERT INTO `ivwh` VALUES ('132', 'WW52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh` VALUES ('133', 'WTC52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh` VALUES ('134', 'GB80', 'WHS19', '0.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh` VALUES ('135', 'GB80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh` VALUES ('136', 'GW80', 'WHS19', '720.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh` VALUES ('137', 'WW52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh` VALUES ('138', 'WTC52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh` VALUES ('139', 'GB80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh` VALUES ('140', 'GP80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh` VALUES ('141', 'MAB', 'WHS21', '80.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh` VALUES ('142', 'GB80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh` VALUES ('143', 'GBR80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh` VALUES ('144', 'GW80', 'WHS21', '216.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('145', 'MSK', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('146', 'MKS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('147', 'MMA', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('148', 'MAB', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('149', 'MPS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('150', 'MSD', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('151', 'MSK', 'WHS21', '120.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh` VALUES ('152', 'MKS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('153', 'MMA', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('154', 'MPS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('155', 'MSD', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh` VALUES ('156', 'MAB', 'WHS23', '80.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh` VALUES ('157', 'MSD', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh` VALUES ('158', 'MSK', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh` VALUES ('159', 'MKS', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 09:02:45');
INSERT INTO `ivwh` VALUES ('160', 'MSK', 'WHS1', '4000.00', '0.00', null, null, '2022-09-04 00:34:51');
INSERT INTO `ivwh` VALUES ('161', 'MSD', 'WHS1', '4000.00', '0.00', null, null, '2022-09-04 00:34:51');
INSERT INTO `ivwh` VALUES ('162', 'MKS', 'WHS1', '4000.00', '0.00', null, null, '2022-09-04 00:34:52');

-- ----------------------------
-- Table structure for ivwh08222022_9pm
-- ----------------------------
DROP TABLE IF EXISTS `ivwh08222022_9pm`;
CREATE TABLE `ivwh08222022_9pm` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(12) NOT NULL DEFAULT '',
  `whscode` varchar(5) DEFAULT NULL,
  `qty_good` decimal(10,2) DEFAULT '0.00',
  `qty_bo` decimal(10,2) DEFAULT '0.00',
  `idtime` datetime DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=162 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh08222022_9pm
-- ----------------------------
INSERT INTO `ivwh08222022_9pm` VALUES ('1', 'GB80', 'YLK', '5452.00', '0.00', null, null, '2022-08-07 06:01:49');
INSERT INTO `ivwh08222022_9pm` VALUES ('2', 'GBR80', 'YLK', '17280.00', '0.00', null, null, '2022-07-22 08:05:38');
INSERT INTO `ivwh08222022_9pm` VALUES ('3', 'GP80', 'YLK', '6684.00', '0.00', null, null, '2022-07-27 08:23:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('4', 'GW80', 'YLK', '11820.00', '0.00', null, null, '2022-07-27 08:23:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('5', 'MSK', 'YLK', '600.00', '0.00', null, null, '2022-08-22 13:48:09');
INSERT INTO `ivwh08222022_9pm` VALUES ('6', 'MKS', 'YLK', '600.00', '0.00', null, null, '2022-08-22 13:48:09');
INSERT INTO `ivwh08222022_9pm` VALUES ('7', 'MMA', 'YLK', '3920.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh08222022_9pm` VALUES ('8', 'MAB', 'YLK', '3960.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh08222022_9pm` VALUES ('9', 'MPS', 'YLK', '4010.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh08222022_9pm` VALUES ('10', 'MSD', 'YLK', '650.00', '0.00', null, null, '2022-08-22 13:48:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('11', 'W52', 'YLK', '1500.00', '0.00', null, null, '2022-08-22 13:48:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('12', 'WW52', 'YLK', '1500.00', '0.00', null, null, '2022-08-22 13:48:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('13', 'WTC52', 'YLK', '24898.00', '0.00', null, null, '2022-08-07 05:38:38');
INSERT INTO `ivwh08222022_9pm` VALUES ('14', 'GB80', '3AW', '1795.00', '0.00', null, null, '2022-07-19 06:23:15');
INSERT INTO `ivwh08222022_9pm` VALUES ('15', 'W52', 'WHS1', '450.00', '0.00', null, null, '2022-08-07 05:38:38');
INSERT INTO `ivwh08222022_9pm` VALUES ('16', 'WW52', 'WHS1', '450.00', '0.00', null, null, '2022-08-07 06:01:49');
INSERT INTO `ivwh08222022_9pm` VALUES ('17', 'WTC52', 'WHS1', '450.00', '0.00', null, null, '2022-08-07 05:38:38');
INSERT INTO `ivwh08222022_9pm` VALUES ('18', 'GP80', 'WHS1', '1008.00', '0.00', null, null, '2022-07-16 07:31:48');
INSERT INTO `ivwh08222022_9pm` VALUES ('19', 'GW80', 'WHS1', '144.00', '0.00', null, null, '2022-06-30 06:35:23');
INSERT INTO `ivwh08222022_9pm` VALUES ('20', 'GB80', 'WHS2', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh08222022_9pm` VALUES ('21', 'GB80', 'WHS3', '710.00', '0.00', null, null, '2022-07-20 03:11:30');
INSERT INTO `ivwh08222022_9pm` VALUES ('22', 'GP80', 'WHS3', '1430.00', '0.00', null, null, '2022-07-20 03:12:12');
INSERT INTO `ivwh08222022_9pm` VALUES ('23', 'GW80', 'WHS3', '791.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh08222022_9pm` VALUES ('24', 'GBR80', 'WHS3', '792.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh08222022_9pm` VALUES ('25', 'GB80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh08222022_9pm` VALUES ('26', 'GP80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh08222022_9pm` VALUES ('27', 'GW80', 'WHS4', '1440.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh08222022_9pm` VALUES ('28', 'GBR80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh08222022_9pm` VALUES ('29', 'GB80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh08222022_9pm` VALUES ('30', 'GW80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh08222022_9pm` VALUES ('31', 'GP80', 'WHS5', '0.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh08222022_9pm` VALUES ('32', 'GB80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('33', 'GW80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('34', 'GP80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('35', 'GBR80', 'WHS6', '710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('36', 'GB80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('37', 'GW80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('38', 'GP80', 'WHS7', '720.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('39', 'GBR80', 'WHS7', '-710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('40', 'GBR80', 'WHS2', '0.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh08222022_9pm` VALUES ('41', 'GB80', 'WHS1', '720.00', '0.00', null, null, '2022-08-07 06:01:49');
INSERT INTO `ivwh08222022_9pm` VALUES ('42', 'GBR80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh08222022_9pm` VALUES ('43', 'GB80', 'WHS8', '360.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh08222022_9pm` VALUES ('44', 'GBR80', 'WHS8', '-360.00', '0.00', null, null, '2022-07-21 07:06:52');
INSERT INTO `ivwh08222022_9pm` VALUES ('45', 'GP80', 'WHS8', '288.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh08222022_9pm` VALUES ('46', 'GB80', 'WHS9', '1065.00', '0.00', null, null, '2022-07-22 02:37:13');
INSERT INTO `ivwh08222022_9pm` VALUES ('47', 'GBR80', 'WHS9', '1204.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh08222022_9pm` VALUES ('48', 'GP80', 'WHS9', '504.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh08222022_9pm` VALUES ('49', 'MSK', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh08222022_9pm` VALUES ('50', 'MKS', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh08222022_9pm` VALUES ('51', 'MMA', 'WHS9', '0.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh08222022_9pm` VALUES ('52', 'MAB', 'WHS9', '40.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh08222022_9pm` VALUES ('53', 'MPS', 'WHS9', '40.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh08222022_9pm` VALUES ('54', 'MSD', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh08222022_9pm` VALUES ('55', 'W52', '3AW', '1800.00', '0.00', null, null, '2022-07-19 06:23:15');
INSERT INTO `ivwh08222022_9pm` VALUES ('56', 'GB80', 'WH10', '-5.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh08222022_9pm` VALUES ('57', 'GBR80', 'WH10', '-10.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh08222022_9pm` VALUES ('58', 'GP80', 'WH10', '0.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh08222022_9pm` VALUES ('59', 'GB80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh08222022_9pm` VALUES ('60', 'GBR80', 'WHS11', '0.00', '0.00', null, null, '2022-07-21 07:01:48');
INSERT INTO `ivwh08222022_9pm` VALUES ('61', 'GP80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh08222022_9pm` VALUES ('62', 'GB80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('63', 'GBR80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('64', 'GP80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('65', 'W52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh08222022_9pm` VALUES ('66', 'WW52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh08222022_9pm` VALUES ('67', 'WTC52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh08222022_9pm` VALUES ('68', 'W52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:32:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('69', 'WW52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh08222022_9pm` VALUES ('70', 'WTC52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh08222022_9pm` VALUES ('71', 'MKS', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh08222022_9pm` VALUES ('72', 'MSK', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh08222022_9pm` VALUES ('73', 'MKS', 'WHS14', '4.00', '0.00', null, null, '2022-07-19 08:52:24');
INSERT INTO `ivwh08222022_9pm` VALUES ('74', 'MSK', 'WHS14', '4.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh08222022_9pm` VALUES ('75', 'W52', 'WHS14', '140.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('76', 'WW52', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('77', 'GBR80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('78', 'MSK', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('79', 'GP80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('80', 'MKS', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('81', 'W52', 'WHS15', '0.00', '0.00', null, null, '2022-08-07 05:29:12');
INSERT INTO `ivwh08222022_9pm` VALUES ('82', 'WW52', 'WHS15', '1650.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh08222022_9pm` VALUES ('83', 'WTC52', 'WHS15', '0.00', '0.00', null, null, '2022-07-27 07:49:08');
INSERT INTO `ivwh08222022_9pm` VALUES ('84', 'GP80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh08222022_9pm` VALUES ('85', 'GW80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh08222022_9pm` VALUES ('86', 'GB80', 'WHS14', '432.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh08222022_9pm` VALUES ('87', 'MSD', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh08222022_9pm` VALUES ('88', 'GBR80', 'WHS14', '360.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh08222022_9pm` VALUES ('89', 'GP80', 'WHS14', '77.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh08222022_9pm` VALUES ('90', 'W52', 'WHS16', '1650.00', '0.00', null, null, '2022-07-20 01:50:32');
INSERT INTO `ivwh08222022_9pm` VALUES ('91', 'WW52', 'WHS16', '1500.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh08222022_9pm` VALUES ('92', 'WTC52', 'WHS16', '0.00', '0.00', null, null, '2022-07-20 01:52:43');
INSERT INTO `ivwh08222022_9pm` VALUES ('93', 'MSK', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh08222022_9pm` VALUES ('94', 'MKS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh08222022_9pm` VALUES ('95', 'MSD', 'WHS16', '65.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('96', 'MMA', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('97', 'MAB', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('98', 'MPS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('99', 'TBD10\'S', 'YLK', '7200.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh08222022_9pm` VALUES ('100', 'TBR10\'S', 'YLK', '3610.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh08222022_9pm` VALUES ('101', 'TW10\'S', 'YLK', '7190.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh08222022_9pm` VALUES ('102', 'WTC52', 'WHS14', '1500.00', '0.00', null, null, '2022-07-20 01:34:14');
INSERT INTO `ivwh08222022_9pm` VALUES ('103', 'MSK', 'WHS17', '40.00', '0.00', null, null, '2022-08-07 12:26:34');
INSERT INTO `ivwh08222022_9pm` VALUES ('104', 'MSD', 'WHS17', '-79.00', '0.00', null, null, '2022-08-07 12:28:23');
INSERT INTO `ivwh08222022_9pm` VALUES ('105', 'MAB', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh08222022_9pm` VALUES ('106', 'MMA', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh08222022_9pm` VALUES ('107', 'MSK', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh08222022_9pm` VALUES ('108', 'MKS', 'WHS15', '25.00', '0.00', null, null, '2022-07-21 07:35:22');
INSERT INTO `ivwh08222022_9pm` VALUES ('109', 'MAB', 'WHS17', '325.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh08222022_9pm` VALUES ('110', 'MMA', 'WHS17', '80.00', '0.00', null, null, '2022-07-21 05:42:10');
INSERT INTO `ivwh08222022_9pm` VALUES ('111', 'MKS', 'WHS17', '439.00', '0.00', null, null, '2022-07-22 08:48:24');
INSERT INTO `ivwh08222022_9pm` VALUES ('112', 'W52', 'WHS17', '150.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh08222022_9pm` VALUES ('113', 'TW10\'S', 'WHS16', '2160.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh08222022_9pm` VALUES ('114', 'TBR10\'S', 'WHS16', '1800.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh08222022_9pm` VALUES ('115', 'TW10\'S', 'WHS17', '360.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh08222022_9pm` VALUES ('116', 'TBR10\'S', 'WHS17', '-360.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh08222022_9pm` VALUES ('117', 'TBD10\'S', 'WHS17', '720.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh08222022_9pm` VALUES ('118', 'GB80', 'WHS17', '0.00', '0.00', null, null, '2022-08-07 12:26:02');
INSERT INTO `ivwh08222022_9pm` VALUES ('119', 'GBR80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh08222022_9pm` VALUES ('120', 'WW52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh08222022_9pm` VALUES ('121', 'WTC52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh08222022_9pm` VALUES ('122', 'GW80', 'WHS17', '720.00', '0.00', null, null, '2022-08-07 12:28:23');
INSERT INTO `ivwh08222022_9pm` VALUES ('123', 'W52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('124', 'WW52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('125', 'WTC52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('126', 'GBR80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('127', 'GW80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('128', 'TW10\'S', 'WHS18', '-90.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh08222022_9pm` VALUES ('129', 'TBR10\'S', 'WHS18', '0.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh08222022_9pm` VALUES ('130', 'GP80', 'WHS16', '72.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh08222022_9pm` VALUES ('131', 'W52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:57:22');
INSERT INTO `ivwh08222022_9pm` VALUES ('132', 'WW52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh08222022_9pm` VALUES ('133', 'WTC52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh08222022_9pm` VALUES ('134', 'GB80', 'WHS19', '0.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh08222022_9pm` VALUES ('135', 'GB80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh08222022_9pm` VALUES ('136', 'GW80', 'WHS19', '720.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh08222022_9pm` VALUES ('137', 'WW52', 'WHS20', '0.00', '0.00', null, null, '2022-08-07 06:13:49');
INSERT INTO `ivwh08222022_9pm` VALUES ('138', 'WTC52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh08222022_9pm` VALUES ('139', 'GB80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh08222022_9pm` VALUES ('140', 'GP80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh08222022_9pm` VALUES ('141', 'MAB', 'WHS21', '80.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh08222022_9pm` VALUES ('142', 'GB80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh08222022_9pm` VALUES ('143', 'GBR80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh08222022_9pm` VALUES ('144', 'GW80', 'WHS21', '216.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('145', 'MSK', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('146', 'MKS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('147', 'MMA', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('148', 'MAB', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('149', 'MPS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('150', 'MSD', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('151', 'MSK', 'WHS21', '120.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh08222022_9pm` VALUES ('152', 'MKS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('153', 'MMA', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('154', 'MPS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('155', 'MSD', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh08222022_9pm` VALUES ('156', 'MAB', 'WHS23', '80.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh08222022_9pm` VALUES ('157', 'MSD', 'WHS23', '40.00', '0.00', null, null, '2022-08-06 13:43:13');
INSERT INTO `ivwh08222022_9pm` VALUES ('158', 'MSK', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh08222022_9pm` VALUES ('159', 'MKS', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 09:02:45');
INSERT INTO `ivwh08222022_9pm` VALUES ('160', 'W52', 'WHS20', '1500.00', '0.00', null, null, '2022-08-07 06:13:49');
INSERT INTO `ivwh08222022_9pm` VALUES ('161', 'GP80', 'WHS17', '720.00', '0.00', null, null, '2022-08-07 12:26:34');

-- ----------------------------
-- Table structure for ivwh09032022_9pm
-- ----------------------------
DROP TABLE IF EXISTS `ivwh09032022_9pm`;
CREATE TABLE `ivwh09032022_9pm` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(12) NOT NULL DEFAULT '',
  `whscode` varchar(5) DEFAULT NULL,
  `qty_good` decimal(10,2) DEFAULT '0.00',
  `qty_bo` decimal(10,2) DEFAULT '0.00',
  `idtime` datetime DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=160 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh09032022_9pm
-- ----------------------------
INSERT INTO `ivwh09032022_9pm` VALUES ('1', 'GB80', 'YLK', '72.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('2', 'GBR80', 'YLK', '72.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('3', 'GP80', 'YLK', '72.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('4', 'GW80', 'YLK', '11820.00', '0.00', null, null, '2022-07-27 08:23:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('5', 'MSK', 'YLK', '600.00', '0.00', null, null, '2022-09-03 13:45:13');
INSERT INTO `ivwh09032022_9pm` VALUES ('6', 'MKS', 'YLK', '600.00', '0.00', null, null, '2022-09-03 13:45:14');
INSERT INTO `ivwh09032022_9pm` VALUES ('7', 'MMA', 'YLK', '3920.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh09032022_9pm` VALUES ('8', 'MAB', 'YLK', '3960.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh09032022_9pm` VALUES ('9', 'MPS', 'YLK', '4010.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh09032022_9pm` VALUES ('10', 'MSD', 'YLK', '650.00', '0.00', null, null, '2022-09-03 13:45:13');
INSERT INTO `ivwh09032022_9pm` VALUES ('11', 'W52', 'YLK', '1500.00', '0.00', null, null, '2022-09-03 13:45:13');
INSERT INTO `ivwh09032022_9pm` VALUES ('12', 'WW52', 'YLK', '1500.00', '0.00', null, null, '2022-09-03 13:45:13');
INSERT INTO `ivwh09032022_9pm` VALUES ('13', 'WTC52', 'YLK', '150.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('14', 'GB80', '3AW', '1795.00', '0.00', null, null, '2022-07-19 06:23:15');
INSERT INTO `ivwh09032022_9pm` VALUES ('15', 'W52', 'WHS1', '300.00', '0.00', null, null, '2022-06-30 06:35:20');
INSERT INTO `ivwh09032022_9pm` VALUES ('16', 'WW52', 'WHS1', '300.00', '0.00', null, null, '2022-06-30 06:35:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('17', 'WTC52', 'WHS1', '300.00', '0.00', null, null, '2022-06-30 06:35:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('18', 'GP80', 'WHS1', '1008.00', '0.00', null, null, '2022-07-16 07:31:48');
INSERT INTO `ivwh09032022_9pm` VALUES ('19', 'GW80', 'WHS1', '144.00', '0.00', null, null, '2022-06-30 06:35:23');
INSERT INTO `ivwh09032022_9pm` VALUES ('20', 'GB80', 'WHS2', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09032022_9pm` VALUES ('21', 'GB80', 'WHS3', '710.00', '0.00', null, null, '2022-07-20 03:11:30');
INSERT INTO `ivwh09032022_9pm` VALUES ('22', 'GP80', 'WHS3', '1430.00', '0.00', null, null, '2022-07-20 03:12:12');
INSERT INTO `ivwh09032022_9pm` VALUES ('23', 'GW80', 'WHS3', '791.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh09032022_9pm` VALUES ('24', 'GBR80', 'WHS3', '792.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh09032022_9pm` VALUES ('25', 'GB80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09032022_9pm` VALUES ('26', 'GP80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09032022_9pm` VALUES ('27', 'GW80', 'WHS4', '1440.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09032022_9pm` VALUES ('28', 'GBR80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09032022_9pm` VALUES ('29', 'GB80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh09032022_9pm` VALUES ('30', 'GW80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh09032022_9pm` VALUES ('31', 'GP80', 'WHS5', '0.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh09032022_9pm` VALUES ('32', 'GB80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('33', 'GW80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('34', 'GP80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('35', 'GBR80', 'WHS6', '710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('36', 'GB80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('37', 'GW80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('38', 'GP80', 'WHS7', '720.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('39', 'GBR80', 'WHS7', '-710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('40', 'GBR80', 'WHS2', '0.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09032022_9pm` VALUES ('41', 'GB80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09032022_9pm` VALUES ('42', 'GBR80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09032022_9pm` VALUES ('43', 'GB80', 'WHS8', '360.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh09032022_9pm` VALUES ('44', 'GBR80', 'WHS8', '-360.00', '0.00', null, null, '2022-07-21 07:06:52');
INSERT INTO `ivwh09032022_9pm` VALUES ('45', 'GP80', 'WHS8', '288.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh09032022_9pm` VALUES ('46', 'GB80', 'WHS9', '1065.00', '0.00', null, null, '2022-07-22 02:37:13');
INSERT INTO `ivwh09032022_9pm` VALUES ('47', 'GBR80', 'WHS9', '1204.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh09032022_9pm` VALUES ('48', 'GP80', 'WHS9', '504.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh09032022_9pm` VALUES ('49', 'MSK', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09032022_9pm` VALUES ('50', 'MKS', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09032022_9pm` VALUES ('51', 'MMA', 'WHS9', '0.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh09032022_9pm` VALUES ('52', 'MAB', 'WHS9', '40.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09032022_9pm` VALUES ('53', 'MPS', 'WHS9', '40.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh09032022_9pm` VALUES ('54', 'MSD', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09032022_9pm` VALUES ('55', 'W52', '3AW', '1800.00', '0.00', null, null, '2022-07-19 06:23:15');
INSERT INTO `ivwh09032022_9pm` VALUES ('56', 'GB80', 'WH10', '-5.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh09032022_9pm` VALUES ('57', 'GBR80', 'WH10', '-10.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh09032022_9pm` VALUES ('58', 'GP80', 'WH10', '0.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh09032022_9pm` VALUES ('59', 'GB80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh09032022_9pm` VALUES ('60', 'GBR80', 'WHS11', '0.00', '0.00', null, null, '2022-07-21 07:01:48');
INSERT INTO `ivwh09032022_9pm` VALUES ('61', 'GP80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh09032022_9pm` VALUES ('62', 'GB80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh09032022_9pm` VALUES ('63', 'GBR80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh09032022_9pm` VALUES ('64', 'GP80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh09032022_9pm` VALUES ('65', 'W52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh09032022_9pm` VALUES ('66', 'WW52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh09032022_9pm` VALUES ('67', 'WTC52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh09032022_9pm` VALUES ('68', 'W52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:32:08');
INSERT INTO `ivwh09032022_9pm` VALUES ('69', 'WW52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh09032022_9pm` VALUES ('70', 'WTC52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh09032022_9pm` VALUES ('71', 'MKS', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh09032022_9pm` VALUES ('72', 'MSK', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh09032022_9pm` VALUES ('73', 'MKS', 'WHS14', '4.00', '0.00', null, null, '2022-07-19 08:52:24');
INSERT INTO `ivwh09032022_9pm` VALUES ('74', 'MSK', 'WHS14', '4.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh09032022_9pm` VALUES ('75', 'W52', 'WHS14', '140.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('76', 'WW52', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('77', 'GBR80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('78', 'MSK', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('79', 'GP80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('80', 'MKS', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('81', 'W52', 'WHS15', '75.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh09032022_9pm` VALUES ('82', 'WW52', 'WHS15', '1650.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh09032022_9pm` VALUES ('83', 'WTC52', 'WHS15', '0.00', '0.00', null, null, '2022-07-27 07:49:08');
INSERT INTO `ivwh09032022_9pm` VALUES ('84', 'GP80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh09032022_9pm` VALUES ('85', 'GW80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh09032022_9pm` VALUES ('86', 'GB80', 'WHS14', '432.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh09032022_9pm` VALUES ('87', 'MSD', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh09032022_9pm` VALUES ('88', 'GBR80', 'WHS14', '360.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh09032022_9pm` VALUES ('89', 'GP80', 'WHS14', '77.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh09032022_9pm` VALUES ('90', 'W52', 'WHS16', '1650.00', '0.00', null, null, '2022-07-20 01:50:32');
INSERT INTO `ivwh09032022_9pm` VALUES ('91', 'WW52', 'WHS16', '1500.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh09032022_9pm` VALUES ('92', 'WTC52', 'WHS16', '0.00', '0.00', null, null, '2022-07-20 01:52:43');
INSERT INTO `ivwh09032022_9pm` VALUES ('93', 'MSK', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh09032022_9pm` VALUES ('94', 'MKS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh09032022_9pm` VALUES ('95', 'MSD', 'WHS16', '65.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('96', 'MMA', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('97', 'MAB', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('98', 'MPS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('99', 'TBD10\'S', 'YLK', '7200.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh09032022_9pm` VALUES ('100', 'TBR10\'S', 'YLK', '3610.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09032022_9pm` VALUES ('101', 'TW10\'S', 'YLK', '7190.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09032022_9pm` VALUES ('102', 'WTC52', 'WHS14', '1500.00', '0.00', null, null, '2022-07-20 01:34:14');
INSERT INTO `ivwh09032022_9pm` VALUES ('103', 'MSK', 'WHS17', '440.00', '0.00', null, null, '2022-07-22 09:02:45');
INSERT INTO `ivwh09032022_9pm` VALUES ('104', 'MSD', 'WHS17', '321.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('105', 'MAB', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh09032022_9pm` VALUES ('106', 'MMA', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh09032022_9pm` VALUES ('107', 'MSK', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh09032022_9pm` VALUES ('108', 'MKS', 'WHS15', '25.00', '0.00', null, null, '2022-07-21 07:35:22');
INSERT INTO `ivwh09032022_9pm` VALUES ('109', 'MAB', 'WHS17', '325.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh09032022_9pm` VALUES ('110', 'MMA', 'WHS17', '80.00', '0.00', null, null, '2022-07-21 05:42:10');
INSERT INTO `ivwh09032022_9pm` VALUES ('111', 'MKS', 'WHS17', '439.00', '0.00', null, null, '2022-07-22 08:48:24');
INSERT INTO `ivwh09032022_9pm` VALUES ('112', 'W52', 'WHS17', '150.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh09032022_9pm` VALUES ('113', 'TW10\'S', 'WHS16', '2160.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09032022_9pm` VALUES ('114', 'TBR10\'S', 'WHS16', '1800.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09032022_9pm` VALUES ('115', 'TW10\'S', 'WHS17', '360.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09032022_9pm` VALUES ('116', 'TBR10\'S', 'WHS17', '-360.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09032022_9pm` VALUES ('117', 'TBD10\'S', 'WHS17', '720.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh09032022_9pm` VALUES ('118', 'GB80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('119', 'GBR80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('120', 'WW52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh09032022_9pm` VALUES ('121', 'WTC52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh09032022_9pm` VALUES ('122', 'GW80', 'WHS17', '0.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('123', 'W52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('124', 'WW52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('125', 'WTC52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('126', 'GBR80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('127', 'GW80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('128', 'TW10\'S', 'WHS18', '-90.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09032022_9pm` VALUES ('129', 'TBR10\'S', 'WHS18', '0.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09032022_9pm` VALUES ('130', 'GP80', 'WHS16', '72.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh09032022_9pm` VALUES ('131', 'W52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:57:22');
INSERT INTO `ivwh09032022_9pm` VALUES ('132', 'WW52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09032022_9pm` VALUES ('133', 'WTC52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09032022_9pm` VALUES ('134', 'GB80', 'WHS19', '0.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh09032022_9pm` VALUES ('135', 'GB80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09032022_9pm` VALUES ('136', 'GW80', 'WHS19', '720.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh09032022_9pm` VALUES ('137', 'WW52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09032022_9pm` VALUES ('138', 'WTC52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09032022_9pm` VALUES ('139', 'GB80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09032022_9pm` VALUES ('140', 'GP80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09032022_9pm` VALUES ('141', 'MAB', 'WHS21', '80.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh09032022_9pm` VALUES ('142', 'GB80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('143', 'GBR80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09032022_9pm` VALUES ('144', 'GW80', 'WHS21', '216.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('145', 'MSK', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('146', 'MKS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('147', 'MMA', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('148', 'MAB', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('149', 'MPS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('150', 'MSD', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('151', 'MSK', 'WHS21', '120.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh09032022_9pm` VALUES ('152', 'MKS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('153', 'MMA', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('154', 'MPS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('155', 'MSD', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09032022_9pm` VALUES ('156', 'MAB', 'WHS23', '80.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh09032022_9pm` VALUES ('157', 'MSD', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('158', 'MSK', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh09032022_9pm` VALUES ('159', 'MKS', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 09:02:45');

-- ----------------------------
-- Table structure for ivwh09042022_8am
-- ----------------------------
DROP TABLE IF EXISTS `ivwh09042022_8am`;
CREATE TABLE `ivwh09042022_8am` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(12) NOT NULL DEFAULT '',
  `whscode` varchar(5) DEFAULT NULL,
  `qty_good` decimal(10,2) DEFAULT '0.00',
  `qty_bo` decimal(10,2) DEFAULT '0.00',
  `idtime` datetime DEFAULT NULL,
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`itemcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=160 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh09042022_8am
-- ----------------------------
INSERT INTO `ivwh09042022_8am` VALUES ('1', 'GB80', 'YLK', '0.00', '0.00', null, null, '2022-09-03 14:12:03');
INSERT INTO `ivwh09042022_8am` VALUES ('2', 'GBR80', 'YLK', '72.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh09042022_8am` VALUES ('3', 'GP80', 'YLK', '72.00', '0.00', null, null, '2022-09-03 13:41:56');
INSERT INTO `ivwh09042022_8am` VALUES ('4', 'GW80', 'YLK', '11784.00', '0.00', null, null, '2022-09-03 14:12:03');
INSERT INTO `ivwh09042022_8am` VALUES ('5', 'MSK', 'YLK', '520.00', '0.00', null, null, '2022-09-04 00:18:58');
INSERT INTO `ivwh09042022_8am` VALUES ('6', 'MKS', 'YLK', '600.00', '0.00', null, null, '2022-09-03 13:45:14');
INSERT INTO `ivwh09042022_8am` VALUES ('7', 'MMA', 'YLK', '3920.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh09042022_8am` VALUES ('8', 'MAB', 'YLK', '3960.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh09042022_8am` VALUES ('9', 'MPS', 'YLK', '4010.00', '0.00', null, null, '2022-07-18 07:19:19');
INSERT INTO `ivwh09042022_8am` VALUES ('10', 'MSD', 'YLK', '600.00', '0.00', null, null, '2022-09-04 00:18:58');
INSERT INTO `ivwh09042022_8am` VALUES ('11', 'W52', 'YLK', '1014.00', '0.00', null, null, '2022-09-03 14:12:03');
INSERT INTO `ivwh09042022_8am` VALUES ('12', 'WW52', 'YLK', '1050.00', '0.00', null, null, '2022-09-04 00:17:37');
INSERT INTO `ivwh09042022_8am` VALUES ('13', 'WTC52', 'YLK', '0.00', '0.00', null, null, '2022-09-04 00:17:37');
INSERT INTO `ivwh09042022_8am` VALUES ('14', 'GB80', '3AW', '1795.00', '0.00', null, null, '2022-07-19 06:23:15');
INSERT INTO `ivwh09042022_8am` VALUES ('15', 'W52', 'WHS1', '15000.00', '0.00', null, null, '2022-09-04 00:34:52');
INSERT INTO `ivwh09042022_8am` VALUES ('16', 'WW52', 'WHS1', '15000.00', '0.00', null, null, '2022-09-04 00:34:52');
INSERT INTO `ivwh09042022_8am` VALUES ('17', 'WTC52', 'WHS1', '300.00', '0.00', null, null, '2022-06-30 06:35:21');
INSERT INTO `ivwh09042022_8am` VALUES ('18', 'GP80', 'WHS1', '1008.00', '0.00', null, null, '2022-07-16 07:31:48');
INSERT INTO `ivwh09042022_8am` VALUES ('19', 'GW80', 'WHS1', '144.00', '0.00', null, null, '2022-06-30 06:35:23');
INSERT INTO `ivwh09042022_8am` VALUES ('20', 'GB80', 'WHS2', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09042022_8am` VALUES ('21', 'GB80', 'WHS3', '710.00', '0.00', null, null, '2022-07-20 03:11:30');
INSERT INTO `ivwh09042022_8am` VALUES ('22', 'GP80', 'WHS3', '1430.00', '0.00', null, null, '2022-07-20 03:12:12');
INSERT INTO `ivwh09042022_8am` VALUES ('23', 'GW80', 'WHS3', '791.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh09042022_8am` VALUES ('24', 'GBR80', 'WHS3', '792.00', '0.00', null, null, '2022-07-20 03:13:52');
INSERT INTO `ivwh09042022_8am` VALUES ('25', 'GB80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09042022_8am` VALUES ('26', 'GP80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09042022_8am` VALUES ('27', 'GW80', 'WHS4', '1440.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09042022_8am` VALUES ('28', 'GBR80', 'WHS4', '720.00', '0.00', null, null, '2022-07-15 08:11:05');
INSERT INTO `ivwh09042022_8am` VALUES ('29', 'GB80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh09042022_8am` VALUES ('30', 'GW80', 'WHS5', '360.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh09042022_8am` VALUES ('31', 'GP80', 'WHS5', '0.00', '0.00', null, null, '2022-07-15 08:15:20');
INSERT INTO `ivwh09042022_8am` VALUES ('32', 'GB80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('33', 'GW80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('34', 'GP80', 'WHS6', '0.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('35', 'GBR80', 'WHS6', '710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('36', 'GB80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('37', 'GW80', 'WHS7', '360.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('38', 'GP80', 'WHS7', '720.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('39', 'GBR80', 'WHS7', '-710.00', '0.00', null, null, '2022-07-15 08:21:21');
INSERT INTO `ivwh09042022_8am` VALUES ('40', 'GBR80', 'WHS2', '0.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09042022_8am` VALUES ('41', 'GB80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09042022_8am` VALUES ('42', 'GBR80', 'WHS1', '720.00', '0.00', null, null, '2022-07-16 07:31:47');
INSERT INTO `ivwh09042022_8am` VALUES ('43', 'GB80', 'WHS8', '360.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh09042022_8am` VALUES ('44', 'GBR80', 'WHS8', '-360.00', '0.00', null, null, '2022-07-21 07:06:52');
INSERT INTO `ivwh09042022_8am` VALUES ('45', 'GP80', 'WHS8', '288.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh09042022_8am` VALUES ('46', 'GB80', 'WHS9', '1065.00', '0.00', null, null, '2022-07-22 02:37:13');
INSERT INTO `ivwh09042022_8am` VALUES ('47', 'GBR80', 'WHS9', '1204.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh09042022_8am` VALUES ('48', 'GP80', 'WHS9', '504.00', '0.00', null, null, '2022-07-22 02:32:46');
INSERT INTO `ivwh09042022_8am` VALUES ('49', 'MSK', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09042022_8am` VALUES ('50', 'MKS', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09042022_8am` VALUES ('51', 'MMA', 'WHS9', '0.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh09042022_8am` VALUES ('52', 'MAB', 'WHS9', '40.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09042022_8am` VALUES ('53', 'MPS', 'WHS9', '40.00', '0.00', null, null, '2022-07-22 08:20:15');
INSERT INTO `ivwh09042022_8am` VALUES ('54', 'MSD', 'WHS9', '0.00', '0.00', null, null, '2022-07-21 06:11:37');
INSERT INTO `ivwh09042022_8am` VALUES ('55', 'W52', '3AW', '150.00', '0.00', null, null, '2022-09-04 00:36:29');
INSERT INTO `ivwh09042022_8am` VALUES ('56', 'GB80', 'WH10', '-5.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh09042022_8am` VALUES ('57', 'GBR80', 'WH10', '-10.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh09042022_8am` VALUES ('58', 'GP80', 'WH10', '0.00', '0.00', null, null, '2022-07-18 08:09:25');
INSERT INTO `ivwh09042022_8am` VALUES ('59', 'GB80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh09042022_8am` VALUES ('60', 'GBR80', 'WHS11', '0.00', '0.00', null, null, '2022-07-21 07:01:48');
INSERT INTO `ivwh09042022_8am` VALUES ('61', 'GP80', 'WHS11', '720.00', '0.00', null, null, '2022-07-21 06:22:28');
INSERT INTO `ivwh09042022_8am` VALUES ('62', 'GB80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh09042022_8am` VALUES ('63', 'GBR80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh09042022_8am` VALUES ('64', 'GP80', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:21:08');
INSERT INTO `ivwh09042022_8am` VALUES ('65', 'W52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh09042022_8am` VALUES ('66', 'WW52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh09042022_8am` VALUES ('67', 'WTC52', 'WHS12', '0.00', '0.00', null, null, '2022-07-18 08:23:45');
INSERT INTO `ivwh09042022_8am` VALUES ('68', 'W52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:32:08');
INSERT INTO `ivwh09042022_8am` VALUES ('69', 'WW52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh09042022_8am` VALUES ('70', 'WTC52', 'WHS13', '1500.00', '0.00', null, null, '2022-07-18 08:24:12');
INSERT INTO `ivwh09042022_8am` VALUES ('71', 'MKS', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh09042022_8am` VALUES ('72', 'MSK', 'WHS13', '0.00', '0.00', null, null, '2022-07-18 08:27:16');
INSERT INTO `ivwh09042022_8am` VALUES ('73', 'MKS', 'WHS14', '4.00', '0.00', null, null, '2022-07-19 08:52:24');
INSERT INTO `ivwh09042022_8am` VALUES ('74', 'MSK', 'WHS14', '4.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh09042022_8am` VALUES ('75', 'W52', 'WHS14', '140.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh09042022_8am` VALUES ('76', 'WW52', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:32:53');
INSERT INTO `ivwh09042022_8am` VALUES ('77', 'GBR80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09042022_8am` VALUES ('78', 'MSK', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09042022_8am` VALUES ('79', 'GP80', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09042022_8am` VALUES ('80', 'MKS', '3AW', '0.00', '0.00', null, null, '2022-07-19 06:08:53');
INSERT INTO `ivwh09042022_8am` VALUES ('81', 'W52', 'WHS15', '75.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh09042022_8am` VALUES ('82', 'WW52', 'WHS15', '1650.00', '0.00', null, null, '2022-08-04 02:46:34');
INSERT INTO `ivwh09042022_8am` VALUES ('83', 'WTC52', 'WHS15', '0.00', '0.00', null, null, '2022-07-27 07:49:08');
INSERT INTO `ivwh09042022_8am` VALUES ('84', 'GP80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh09042022_8am` VALUES ('85', 'GW80', 'WHS15', '0.00', '0.00', null, null, '2022-07-19 07:03:02');
INSERT INTO `ivwh09042022_8am` VALUES ('86', 'GB80', 'WHS14', '432.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh09042022_8am` VALUES ('87', 'MSD', 'WHS14', '0.00', '0.00', null, null, '2022-07-20 01:36:41');
INSERT INTO `ivwh09042022_8am` VALUES ('88', 'GBR80', 'WHS14', '360.00', '0.00', null, null, '2022-07-19 08:57:37');
INSERT INTO `ivwh09042022_8am` VALUES ('89', 'GP80', 'WHS14', '77.00', '0.00', null, null, '2022-07-21 05:47:04');
INSERT INTO `ivwh09042022_8am` VALUES ('90', 'W52', 'WHS16', '1650.00', '0.00', null, null, '2022-07-20 01:50:32');
INSERT INTO `ivwh09042022_8am` VALUES ('91', 'WW52', 'WHS16', '1500.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh09042022_8am` VALUES ('92', 'WTC52', 'WHS16', '0.00', '0.00', null, null, '2022-07-20 01:52:43');
INSERT INTO `ivwh09042022_8am` VALUES ('93', 'MSK', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 00:54:14');
INSERT INTO `ivwh09042022_8am` VALUES ('94', 'MKS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh09042022_8am` VALUES ('95', 'MSD', 'WHS16', '65.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09042022_8am` VALUES ('96', 'MMA', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09042022_8am` VALUES ('97', 'MAB', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09042022_8am` VALUES ('98', 'MPS', 'WHS16', '40.00', '0.00', null, null, '2022-07-20 01:02:53');
INSERT INTO `ivwh09042022_8am` VALUES ('99', 'TBD10\'S', 'YLK', '7200.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh09042022_8am` VALUES ('100', 'TBR10\'S', 'YLK', '3610.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09042022_8am` VALUES ('101', 'TW10\'S', 'YLK', '7190.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09042022_8am` VALUES ('102', 'WTC52', 'WHS14', '1500.00', '0.00', null, null, '2022-07-20 01:34:14');
INSERT INTO `ivwh09042022_8am` VALUES ('103', 'MSK', 'WHS17', '440.00', '0.00', null, null, '2022-07-22 09:02:45');
INSERT INTO `ivwh09042022_8am` VALUES ('104', 'MSD', 'WHS17', '321.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh09042022_8am` VALUES ('105', 'MAB', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh09042022_8am` VALUES ('106', 'MMA', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh09042022_8am` VALUES ('107', 'MSK', 'WHS15', '40.00', '0.00', null, null, '2022-07-20 01:45:27');
INSERT INTO `ivwh09042022_8am` VALUES ('108', 'MKS', 'WHS15', '25.00', '0.00', null, null, '2022-07-21 07:35:22');
INSERT INTO `ivwh09042022_8am` VALUES ('109', 'MAB', 'WHS17', '325.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh09042022_8am` VALUES ('110', 'MMA', 'WHS17', '80.00', '0.00', null, null, '2022-07-21 05:42:10');
INSERT INTO `ivwh09042022_8am` VALUES ('111', 'MKS', 'WHS17', '439.00', '0.00', null, null, '2022-07-22 08:48:24');
INSERT INTO `ivwh09042022_8am` VALUES ('112', 'W52', 'WHS17', '150.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh09042022_8am` VALUES ('113', 'TW10\'S', 'WHS16', '2160.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09042022_8am` VALUES ('114', 'TBR10\'S', 'WHS16', '1800.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09042022_8am` VALUES ('115', 'TW10\'S', 'WHS17', '360.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09042022_8am` VALUES ('116', 'TBR10\'S', 'WHS17', '-360.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09042022_8am` VALUES ('117', 'TBD10\'S', 'WHS17', '720.00', '0.00', null, null, '2022-08-04 06:32:57');
INSERT INTO `ivwh09042022_8am` VALUES ('118', 'GB80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09042022_8am` VALUES ('119', 'GBR80', 'WHS17', '-72.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09042022_8am` VALUES ('120', 'WW52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh09042022_8am` VALUES ('121', 'WTC52', 'WHS17', '0.00', '0.00', null, null, '2022-07-20 07:52:06');
INSERT INTO `ivwh09042022_8am` VALUES ('122', 'GW80', 'WHS17', '0.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09042022_8am` VALUES ('123', 'W52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09042022_8am` VALUES ('124', 'WW52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09042022_8am` VALUES ('125', 'WTC52', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09042022_8am` VALUES ('126', 'GBR80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh09042022_8am` VALUES ('127', 'GW80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:09:51');
INSERT INTO `ivwh09042022_8am` VALUES ('128', 'TW10\'S', 'WHS18', '-90.00', '0.00', null, null, '2022-08-04 06:32:07');
INSERT INTO `ivwh09042022_8am` VALUES ('129', 'TBR10\'S', 'WHS18', '0.00', '0.00', null, null, '2022-08-04 06:32:31');
INSERT INTO `ivwh09042022_8am` VALUES ('130', 'GP80', 'WHS16', '72.00', '0.00', null, null, '2022-07-20 08:48:35');
INSERT INTO `ivwh09042022_8am` VALUES ('131', 'W52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:57:22');
INSERT INTO `ivwh09042022_8am` VALUES ('132', 'WW52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09042022_8am` VALUES ('133', 'WTC52', 'WHS19', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09042022_8am` VALUES ('134', 'GB80', 'WHS19', '0.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh09042022_8am` VALUES ('135', 'GB80', 'WHS18', '0.00', '0.00', null, null, '2022-07-20 08:54:21');
INSERT INTO `ivwh09042022_8am` VALUES ('136', 'GW80', 'WHS19', '720.00', '0.00', null, null, '2022-07-21 05:39:25');
INSERT INTO `ivwh09042022_8am` VALUES ('137', 'WW52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09042022_8am` VALUES ('138', 'WTC52', 'WHS20', '1500.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09042022_8am` VALUES ('139', 'GB80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09042022_8am` VALUES ('140', 'GP80', 'WHS20', '720.00', '0.00', null, null, '2022-07-20 08:58:44');
INSERT INTO `ivwh09042022_8am` VALUES ('141', 'MAB', 'WHS21', '80.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh09042022_8am` VALUES ('142', 'GB80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09042022_8am` VALUES ('143', 'GBR80', 'WHS21', '144.00', '0.00', null, null, '2022-07-21 06:07:56');
INSERT INTO `ivwh09042022_8am` VALUES ('144', 'GW80', 'WHS21', '216.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('145', 'MSK', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('146', 'MKS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('147', 'MMA', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('148', 'MAB', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('149', 'MPS', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('150', 'MSD', 'WHS20', '0.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('151', 'MSK', 'WHS21', '120.00', '0.00', null, null, '2022-07-22 08:41:59');
INSERT INTO `ivwh09042022_8am` VALUES ('152', 'MKS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('153', 'MMA', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('154', 'MPS', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('155', 'MSD', 'WHS21', '80.00', '0.00', null, null, '2022-07-21 06:16:51');
INSERT INTO `ivwh09042022_8am` VALUES ('156', 'MAB', 'WHS23', '80.00', '0.00', null, null, '2022-08-04 02:55:12');
INSERT INTO `ivwh09042022_8am` VALUES ('157', 'MSD', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh09042022_8am` VALUES ('158', 'MSK', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 08:55:53');
INSERT INTO `ivwh09042022_8am` VALUES ('159', 'MKS', 'WHS23', '40.00', '0.00', null, null, '2022-07-22 09:02:45');

-- ----------------------------
-- Table structure for ivwh_copy
-- ----------------------------
DROP TABLE IF EXISTS `ivwh_copy`;
CREATE TABLE `ivwh_copy` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `item` varchar(12) NOT NULL DEFAULT '',
  `whs` varchar(5) DEFAULT NULL,
  `qty_good` int(11) DEFAULT NULL,
  `qty_bo` int(11) DEFAULT NULL,
  `idtime` datetime DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`item`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=158 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh_copy
-- ----------------------------
INSERT INTO `ivwh_copy` VALUES ('1', 'W52', 'WHS1', '13500', null, null, '2021-04-28 02:28:23');
INSERT INTO `ivwh_copy` VALUES ('2', 'WW52', 'WHS1', '6912', null, null, '2021-04-28 02:28:23');
INSERT INTO `ivwh_copy` VALUES ('3', 'WTC52', 'WHS1', '5412', null, null, '2021-04-28 02:28:23');
INSERT INTO `ivwh_copy` VALUES ('4', 'W150', 'WHS1', '1932', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('5', 'W1000', 'WHS1', '132', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('6', 'W390', 'WHS1', '120', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('7', 'WS70', 'WHS1', '960', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('8', 'WSK70', 'WHS1', '960', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('9', 'WSB390', 'WHS1', '120', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('10', 'WSBK390', 'WHS1', '120', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('11', 'W100', 'WHS1', '720', null, null, '2021-02-10 05:18:46');
INSERT INTO `ivwh_copy` VALUES ('12', '11-200001', 'WHS1', '3600', null, null, '2021-02-10 05:18:46');
INSERT INTO `ivwh_copy` VALUES ('13', '10-200010', 'WHS1', '800', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('14', '10-200011', 'WHS1', '800', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('15', '10-200012', 'WHS1', '800', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('16', '10-200013', 'WHS1', '800', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('17', '10-000189', 'WHS1', '720', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('18', '10-000190', 'WHS1', '720', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('19', '10-000191', 'WHS1', '756', null, null, '2021-04-21 07:47:54');
INSERT INTO `ivwh_copy` VALUES ('20', '10-000192', 'WHS1', '504', null, null, '2021-04-21 07:47:54');
INSERT INTO `ivwh_copy` VALUES ('21', '11-200005', 'WHS1', '7560', null, null, '2021-04-21 07:47:54');
INSERT INTO `ivwh_copy` VALUES ('22', '11-200006', 'WHS1', '7560', null, null, '2021-04-21 07:47:54');
INSERT INTO `ivwh_copy` VALUES ('23', '11-200008', 'WHS1', '7560', null, null, '2021-04-21 07:47:54');
INSERT INTO `ivwh_copy` VALUES ('24', '11-200009', 'WHS1', '7200', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('25', '11-200010', 'WHS1', '7200', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('26', '11-200012', 'WHS1', '7200', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('27', '10-200009', 'WHS1', '800', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('28', 'GG80', 'WHS1', '1440', null, null, '2021-03-20 01:30:28');
INSERT INTO `ivwh_copy` VALUES ('29', 'QQ8', 'WHS1', '4000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('30', 'MM8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('31', 'S8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('32', 'CL6', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('33', 'CS8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('34', 'SB8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('35', 'K8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('36', 'CT8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('37', 'OC8', 'WHS1', '6000', null, null, '2021-02-10 07:33:09');
INSERT INTO `ivwh_copy` VALUES ('38', 'W52', 'WHS2', '22650', null, null, '2021-04-26 01:52:15');
INSERT INTO `ivwh_copy` VALUES ('39', 'WW52', 'WHS2', '150150', null, null, '2021-04-26 01:52:15');
INSERT INTO `ivwh_copy` VALUES ('40', 'WTC52', 'WHS2', '150000', null, null, '2021-04-22 02:31:18');
INSERT INTO `ivwh_copy` VALUES ('41', 'W150', 'WHS4', '48000', null, null, '2021-02-10 06:44:01');
INSERT INTO `ivwh_copy` VALUES ('42', 'W1000', 'WHS4', '6000', null, null, '2021-02-10 06:44:01');
INSERT INTO `ivwh_copy` VALUES ('43', 'WS70', 'WHS4', '480000', null, null, '2021-02-10 06:44:01');
INSERT INTO `ivwh_copy` VALUES ('44', 'W52', 'YLKOZ', '78000', null, null, '2021-04-24 01:47:34');
INSERT INTO `ivwh_copy` VALUES ('45', 'WW52', 'YLKOZ', '78000', null, null, '2021-04-24 01:47:34');
INSERT INTO `ivwh_copy` VALUES ('46', 'WTC52', 'YLKOZ', '76650', null, null, '2021-04-24 01:47:34');
INSERT INTO `ivwh_copy` VALUES ('47', 'W150', 'YLKOZ', '49056', null, null, '2021-04-24 07:37:24');
INSERT INTO `ivwh_copy` VALUES ('48', 'W1000', 'YLKOZ', '6000', null, null, '2021-04-20 02:08:28');
INSERT INTO `ivwh_copy` VALUES ('49', 'WS70', 'YLKOZ', '48960', null, null, '2021-04-24 07:37:24');
INSERT INTO `ivwh_copy` VALUES ('50', 'WSK70', 'YLKOZ', '48000', null, null, '2021-04-20 02:08:28');
INSERT INTO `ivwh_copy` VALUES ('51', 'W52', 'WHS18', '754500', null, null, '2021-04-27 07:49:58');
INSERT INTO `ivwh_copy` VALUES ('52', 'WW52', 'WHS18', '753000', null, null, '2021-04-27 07:33:25');
INSERT INTO `ivwh_copy` VALUES ('53', 'WTC52', 'WHS18', '753000', null, null, '2021-04-27 07:33:25');
INSERT INTO `ivwh_copy` VALUES ('54', '10-200010', 'WHS5', '40000', null, null, '2021-02-10 07:24:05');
INSERT INTO `ivwh_copy` VALUES ('55', '10-200011', 'WHS5', '40000', null, null, '2021-02-10 07:24:05');
INSERT INTO `ivwh_copy` VALUES ('56', '10-200012', 'WHS5', '40000', null, null, '2021-02-10 07:24:05');
INSERT INTO `ivwh_copy` VALUES ('57', '10-200013', 'WHS5', '40000', null, null, '2021-02-10 07:24:05');
INSERT INTO `ivwh_copy` VALUES ('58', '11-200005', 'WHS6', '36000', null, null, '2021-02-10 07:24:56');
INSERT INTO `ivwh_copy` VALUES ('59', '11-200006', 'WHS6', '36000', null, null, '2021-02-10 07:24:56');
INSERT INTO `ivwh_copy` VALUES ('60', '11-200008', 'WHS6', '36000', null, null, '2021-02-10 07:24:56');
INSERT INTO `ivwh_copy` VALUES ('61', '11-200009', 'WHS6', '36000', null, null, '2021-02-10 07:24:56');
INSERT INTO `ivwh_copy` VALUES ('62', '11-200010', 'WHS6', '36000', null, null, '2021-02-10 07:24:56');
INSERT INTO `ivwh_copy` VALUES ('63', '11-200001', 'WHS6', '36000', null, null, '2021-02-10 07:24:56');
INSERT INTO `ivwh_copy` VALUES ('64', 'GBR80', 'WHS7', '20880', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('65', 'GB80', 'WHS7', '20880', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('66', 'GW80', 'WHS7', '20880', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('67', 'GP80', 'WHS7', '20880', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('68', 'WW52', 'WHS7', '43500', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('69', 'WSBK390', 'WHS7', '3480', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('70', 'WSB390', 'WHS7', '3480', null, null, '2021-04-20 02:08:02');
INSERT INTO `ivwh_copy` VALUES ('71', 'GP80', 'WHS10', '792', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('72', 'WW52', 'WHS10', '3150', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('73', 'WSK70', 'WHS10', '1056', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('74', 'GG80', 'WHS10', '792', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('75', '10-200010', 'YLKOZ', '40000', null, null, '2021-02-10 07:35:43');
INSERT INTO `ivwh_copy` VALUES ('76', '10-200009', 'WHS9', '6000', null, null, '2021-02-10 07:40:53');
INSERT INTO `ivwh_copy` VALUES ('77', 'QQ8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('78', 'S8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('79', 'CL6', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('80', 'CS8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('81', 'SB8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('82', 'K8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('83', 'CT8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('84', 'OC8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('85', 'MM8', 'WHS5', '1000', null, null, '2021-02-10 08:02:42');
INSERT INTO `ivwh_copy` VALUES ('86', '10-200010', 'WHS18', '400', null, null, '2021-02-10 07:44:45');
INSERT INTO `ivwh_copy` VALUES ('87', '10-200011', 'WHS18', '400', null, null, '2021-02-10 07:44:45');
INSERT INTO `ivwh_copy` VALUES ('88', '10-200012', 'WHS18', '400', null, null, '2021-02-10 07:44:45');
INSERT INTO `ivwh_copy` VALUES ('89', 'QQ8', 'WHS2', '100', null, null, '2021-02-10 08:05:33');
INSERT INTO `ivwh_copy` VALUES ('90', 'MM8', 'WHS2', '100', null, null, '2021-02-10 08:05:33');
INSERT INTO `ivwh_copy` VALUES ('91', 'S8', 'WHS2', '1', null, null, '2021-02-10 08:05:33');
INSERT INTO `ivwh_copy` VALUES ('92', '10-000189', 'YLKOZ', '36', null, null, '2021-04-08 02:30:45');
INSERT INTO `ivwh_copy` VALUES ('93', '10-000191', 'YLKOZ', '36', null, null, '2021-04-08 02:30:45');
INSERT INTO `ivwh_copy` VALUES ('94', '11-200006', 'YLKOZ', '360', null, null, '2021-04-08 02:30:45');
INSERT INTO `ivwh_copy` VALUES ('95', '11-200008', 'YLKOZ', '360', null, null, '2021-04-08 02:30:45');
INSERT INTO `ivwh_copy` VALUES ('96', '11-200010', 'YLKOZ', '720', null, null, '2021-04-08 02:31:38');
INSERT INTO `ivwh_copy` VALUES ('97', '10-200009', 'YLKOZ', '80', null, null, '2021-04-08 02:31:38');
INSERT INTO `ivwh_copy` VALUES ('98', 'GG80', 'YLKOZ', '72', null, null, '2021-04-08 02:31:38');
INSERT INTO `ivwh_copy` VALUES ('99', '1234567890', 'YLKOZ', '75000', null, null, '2021-04-20 02:08:28');
INSERT INTO `ivwh_copy` VALUES ('100', '1234567890', 'WHS1', '1500', null, null, '2021-04-21 03:04:16');
INSERT INTO `ivwh_copy` VALUES ('101', 'DC1', 'WHS3', '84', null, null, '2021-04-26 06:39:59');
INSERT INTO `ivwh_copy` VALUES ('102', 'DC3', 'WHS3', '168', null, null, '2021-04-26 06:39:59');
INSERT INTO `ivwh_copy` VALUES ('103', '1234567890', 'WHS2', '15000', null, null, '2021-04-22 02:31:18');
INSERT INTO `ivwh_copy` VALUES ('104', 'W52', 'WHS15', '300', null, null, '2021-04-23 07:44:35');
INSERT INTO `ivwh_copy` VALUES ('105', 'WW52', 'WHS15', '300', null, null, '2021-04-23 07:44:35');
INSERT INTO `ivwh_copy` VALUES ('106', 'QQ8', 'WHS15', '200', null, null, '2021-04-23 07:55:10');
INSERT INTO `ivwh_copy` VALUES ('107', 'CL6', 'WHS15', '200', null, null, '2021-04-23 07:55:10');
INSERT INTO `ivwh_copy` VALUES ('108', 'DC3', 'WHS15', '24', null, null, '2021-04-23 07:56:21');
INSERT INTO `ivwh_copy` VALUES ('109', 'DC1', 'WHS15', '12', null, null, '2021-04-23 07:56:21');
INSERT INTO `ivwh_copy` VALUES ('110', 'W52', 'WHS11', '15150', null, null, '2021-04-24 01:53:35');
INSERT INTO `ivwh_copy` VALUES ('111', 'WTC52', 'WHS10', '1650', null, null, '2021-04-27 08:16:32');
INSERT INTO `ivwh_copy` VALUES ('112', 'W52', 'WHS10', '1650', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('113', 'WW52', 'WHS11', '15000', null, null, '2021-04-24 01:53:35');
INSERT INTO `ivwh_copy` VALUES ('114', 'WTC52', 'WHS11', '15000', null, null, '2021-04-24 01:53:35');
INSERT INTO `ivwh_copy` VALUES ('115', 'W52', 'WHS12', '15000', null, null, '2021-04-27 07:01:52');
INSERT INTO `ivwh_copy` VALUES ('116', 'WW52', 'WHS12', '15000', null, null, '2021-04-27 07:01:52');
INSERT INTO `ivwh_copy` VALUES ('117', 'WTC52', 'WHS12', '15000', null, null, '2021-04-27 07:01:52');
INSERT INTO `ivwh_copy` VALUES ('118', 'W1000', 'WHS6', '6000', null, null, '2021-04-24 07:43:30');
INSERT INTO `ivwh_copy` VALUES ('119', 'W100', 'WHS6', '36000', null, null, '2021-04-24 07:43:30');
INSERT INTO `ivwh_copy` VALUES ('120', '10-200012', 'WHS10', '440', null, null, '2021-04-27 08:16:32');
INSERT INTO `ivwh_copy` VALUES ('121', '10-200013', 'WHS10', '440', null, null, '2021-04-27 08:16:32');
INSERT INTO `ivwh_copy` VALUES ('122', '10-000189', 'WHS10', '396', null, null, '2021-04-27 08:16:32');
INSERT INTO `ivwh_copy` VALUES ('123', '10-000190', 'WHS10', '396', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('124', 'DC3', 'WHS7', '24', null, null, '2021-04-26 01:05:15');
INSERT INTO `ivwh_copy` VALUES ('125', 'DC1', 'WHS7', '12', null, null, '2021-04-26 01:05:15');
INSERT INTO `ivwh_copy` VALUES ('126', 'W52', 'WHS4', '3000', null, null, '2021-04-26 01:27:18');
INSERT INTO `ivwh_copy` VALUES ('127', 'WW52', 'WHS4', '3000', null, null, '2021-04-26 01:27:18');
INSERT INTO `ivwh_copy` VALUES ('128', 'DC1', 'WHS5', '24', null, null, '2021-04-26 01:37:25');
INSERT INTO `ivwh_copy` VALUES ('129', 'DC3', 'WHS5', '48', null, null, '2021-04-26 01:37:25');
INSERT INTO `ivwh_copy` VALUES ('130', 'DC1', 'WHS1', '156', null, null, '2021-04-27 07:53:56');
INSERT INTO `ivwh_copy` VALUES ('131', 'DC3', 'WHS1', '288', null, null, '2021-04-27 07:53:56');
INSERT INTO `ivwh_copy` VALUES ('132', 'DC1', 'WHS2', '276', null, null, '2021-04-26 07:07:51');
INSERT INTO `ivwh_copy` VALUES ('133', 'DC3', 'WHS2', '1248', null, null, '2021-04-26 07:07:51');
INSERT INTO `ivwh_copy` VALUES ('134', '10-000191', 'WHS10', '36', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('135', '10-000192', 'WHS10', '24', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('136', '11-200005', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('137', '11-200006', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('138', '11-200008', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('139', '11-200009', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('140', '11-200010', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('141', '11-200012', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('142', '11-200001', 'WHS10', '360', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('143', '10-200011', 'WHS10', '40', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('144', '10-200010', 'WHS10', '40', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('145', 'W150', 'WHS10', '96', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('146', 'W100', 'WHS10', '72', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('147', 'W390', 'WHS10', '12', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('148', 'W1000', 'WHS10', '12', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('149', 'WS70', 'WHS10', '96', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('150', 'WSB390', 'WHS10', '12', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('151', 'WSBK390', 'WHS10', '12', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('152', 'GW80', 'WHS10', '72', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('153', 'GB80', 'WHS10', '72', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('154', 'GBR80', 'WHS10', '72', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('155', '10-200009', 'WHS10', '40', null, null, '2021-04-27 08:16:33');
INSERT INTO `ivwh_copy` VALUES ('156', 'W52', 'WHT', '4500', null, null, '2021-05-01 06:08:27');
INSERT INTO `ivwh_copy` VALUES ('157', 'WW52', 'WHT', '0', null, null, '2021-05-01 06:08:27');

-- ----------------------------
-- Table structure for ivwh_copy1
-- ----------------------------
DROP TABLE IF EXISTS `ivwh_copy1`;
CREATE TABLE `ivwh_copy1` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `item` varchar(12) NOT NULL DEFAULT '',
  `whs` varchar(5) DEFAULT NULL,
  `qty_good` int(11) DEFAULT NULL,
  `qty_bo` int(11) DEFAULT NULL,
  `idtime` datetime DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`item`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=104 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh_copy1
-- ----------------------------
INSERT INTO `ivwh_copy1` VALUES ('1', 'WTC52', 'YLKOZ', '30594', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('2', 'W52', 'YLKOZ', '36867', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('3', 'WW52', 'YLKOZ', '20394', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('4', 'W150', 'YLKOZ', '11135', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('5', 'W100', 'YLKOZ', '8208', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('6', 'W390', 'YLKOZ', '1248', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('7', 'W1000', 'YLKOZ', '1224', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('8', 'WS70', 'YLKOZ', '9787', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('9', 'WSK70', 'YLKOZ', '9792', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('10', 'WSB390', 'YLKOZ', '1224', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('11', 'WSBK390', 'YLKOZ', '1212', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('12', 'GP80', 'YLKOZ', '7920', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('13', 'GW80', 'YLKOZ', '7920', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('14', 'GB80', 'YLKOZ', '7920', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('15', 'GBR80', 'YLKOZ', '7920', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('16', 'GG80', 'YLKOZ', '7920', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('17', '10-200010', 'YLKOZ', '4047', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('18', '10-200013', 'YLKOZ', '4040', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('19', '10-000189', 'YLKOZ', '3924', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('20', '10-000190', 'YLKOZ', '3924', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('21', '10-000191', 'YLKOZ', '3744', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('22', '10-000192', 'YLKOZ', '2496', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('23', '11-200005', 'YLKOZ', '35643', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('24', '11-200006', 'YLKOZ', '36000', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('25', '11-200008', 'YLKOZ', '32580', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('26', '11-200009', 'YLKOZ', '38520', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('27', '11-200010', 'YLKOZ', '32400', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('28', '11-200012', 'YLKOZ', '35820', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('29', '11-200001', 'YLKOZ', '36770', null, null, '2021-09-20 12:31:46');
INSERT INTO `ivwh_copy1` VALUES ('30', 'WTC52', 'WHS1', '0', null, null, '2021-09-05 03:38:09');
INSERT INTO `ivwh_copy1` VALUES ('31', 'W52', 'WHS1', '150', null, null, '2021-09-08 07:29:12');
INSERT INTO `ivwh_copy1` VALUES ('32', 'DC3', 'YLKOZ', '2496', null, null, '2021-09-15 12:09:34');
INSERT INTO `ivwh_copy1` VALUES ('33', 'DC1', 'YLKOZ', '1236', null, null, '2021-09-15 12:09:34');
INSERT INTO `ivwh_copy1` VALUES ('34', 'VG200', 'YLKOZ', '100', null, null, '2021-09-11 02:59:51');
INSERT INTO `ivwh_copy1` VALUES ('35', 'DC3', 'WHS1', '1182', null, null, '2021-09-15 13:27:04');
INSERT INTO `ivwh_copy1` VALUES ('36', 'DC1', 'WHS1', '0', null, null, '2021-09-15 13:27:04');
INSERT INTO `ivwh_copy1` VALUES ('37', 'DC1', 'WHS2', '600', null, null, '2021-09-11 03:04:24');
INSERT INTO `ivwh_copy1` VALUES ('38', 'DC3', 'WHS2', '1200', null, null, '2021-09-11 03:04:24');
INSERT INTO `ivwh_copy1` VALUES ('39', 'BC1K', '3AW', '500', null, null, '2021-09-15 11:53:58');
INSERT INTO `ivwh_copy1` VALUES ('40', 'WO10ML', '3AW', '3763', null, null, '2021-09-20 12:16:42');
INSERT INTO `ivwh_copy1` VALUES ('41', 'WTC52', '3AW', '1800', null, null, '2021-09-20 12:47:00');
INSERT INTO `ivwh_copy1` VALUES ('42', '10-200013', '3AW', '120', null, null, '2021-09-20 12:47:00');
INSERT INTO `ivwh_copy1` VALUES ('43', '10-000189', '3AW', '108', null, null, '2021-09-20 12:47:00');
INSERT INTO `ivwh_copy1` VALUES ('44', 'HKG', '3AW', '0', null, null, '2021-09-30 06:11:18');
INSERT INTO `ivwh_copy1` VALUES ('45', 'BCG', '3AW', '0', null, null, '2021-09-30 06:11:18');
INSERT INTO `ivwh_copy1` VALUES ('46', 'EG', '3AW', '22', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('47', 'AT20%', '3AW', '2', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('48', 'PEC', '3AW', '7', null, null, '2021-10-27 06:10:07');
INSERT INTO `ivwh_copy1` VALUES ('49', 'PEO', '3AW', '8', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('50', 'CPO', '3AW', '6', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('51', 'G', '3AW', '-20', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('52', 'TMPS', '3AW', '8', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('53', 'TTG', '3AW', '-1', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('54', 'A', '3AW', '-1', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('55', 'IO', '3AW', '3', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('56', 'PE', '3AW', '0', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('57', 'CP', '3AW', '6', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('58', 'VBCI', '3AW', '5', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('59', 'II', '3AW', '0', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('60', 'N20%', '3AW', '2', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('61', 'C', '3AW', '3', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('62', 'MVEO', '3AW', '4', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('63', 'BN', '3AW', '5', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('64', 'MVE', '3AW', '172', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('65', 'IFPM ', '3AW', '0', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('66', 'LSBFMP', '3AW', '0', null, null, '2021-10-27 01:04:09');
INSERT INTO `ivwh_copy1` VALUES ('67', 'CSFPM', '3AW', '1', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('68', 'E20%', '3AW', '-5', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('69', 'VBCAA', '3AW', '-16', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('70', 'E10%', '3AW', '-8', null, null, '2021-10-27 01:04:05');
INSERT INTO `ivwh_copy1` VALUES ('71', 'LH', '3AW', '0', null, null, '2021-10-26 13:29:03');
INSERT INTO `ivwh_copy1` VALUES ('72', 'LSB', '3AW', '0', null, null, '2021-10-27 01:04:07');
INSERT INTO `ivwh_copy1` VALUES ('73', 'O', '3AW', '-1', null, null, '2021-10-26 13:29:01');
INSERT INTO `ivwh_copy1` VALUES ('74', 'B', '3AW', '-15', null, null, '2021-10-29 02:26:50');
INSERT INTO `ivwh_copy1` VALUES ('75', 'HC', '3AW', '-5', null, null, '2021-10-29 02:24:06');
INSERT INTO `ivwh_copy1` VALUES ('76', 'CPFS', '3AW', '0', null, null, '2021-10-27 06:29:36');
INSERT INTO `ivwh_copy1` VALUES ('77', 'PP', '3AW', '-6', null, null, '2021-10-27 06:29:36');
INSERT INTO `ivwh_copy1` VALUES ('78', 'ID', '3AW', '0', null, null, '2021-10-27 06:29:36');
INSERT INTO `ivwh_copy1` VALUES ('79', 'CSP', '3AW', '0', null, null, '2021-10-27 06:29:36');
INSERT INTO `ivwh_copy1` VALUES ('80', '1', '3AW', '-2', null, null, '2021-10-27 01:04:03');
INSERT INTO `ivwh_copy1` VALUES ('81', 'KHPS', '3AW', '-23', null, null, '2021-10-27 01:04:01');
INSERT INTO `ivwh_copy1` VALUES ('82', 'TEST3', '3AW', '-720', null, null, '2021-10-27 01:04:00');
INSERT INTO `ivwh_copy1` VALUES ('83', 'TEST4', '3AW', '0', null, null, '2021-10-27 01:03:55');
INSERT INTO `ivwh_copy1` VALUES ('84', 'TEST2', '3AW', '0', null, null, '2021-10-27 01:03:55');
INSERT INTO `ivwh_copy1` VALUES ('85', 'TEST1', '3AW', '0', null, null, '2021-10-27 01:03:55');
INSERT INTO `ivwh_copy1` VALUES ('86', 'B+CLM', '3AW', '-20', null, null, '2021-10-27 01:03:47');
INSERT INTO `ivwh_copy1` VALUES ('87', 'KHS', '3AW', '8', null, null, '2021-10-26 13:41:40');
INSERT INTO `ivwh_copy1` VALUES ('88', 'KHG', '3AW', '10', null, null, '2021-10-26 13:38:04');
INSERT INTO `ivwh_copy1` VALUES ('89', 'KHF', '3AW', '10', null, null, '2021-10-26 13:38:04');
INSERT INTO `ivwh_copy1` VALUES ('90', 'MMHL-GMC', '3AW', '10', null, null, '2021-10-26 13:38:04');
INSERT INTO `ivwh_copy1` VALUES ('91', 'MMHG-GMC', '3AW', '20', null, null, '2021-10-26 13:38:04');
INSERT INTO `ivwh_copy1` VALUES ('92', 'NBP', '3AW', '4', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('93', 'VC', '3AW', '8', null, null, '2021-10-27 06:27:00');
INSERT INTO `ivwh_copy1` VALUES ('94', 'GL', '3AW', '6', null, null, '2021-10-27 06:10:07');
INSERT INTO `ivwh_copy1` VALUES ('95', 'D', '3AW', '1', null, null, '2021-10-27 06:10:07');
INSERT INTO `ivwh_copy1` VALUES ('96', 'IPM', '3AW', '1', null, null, '2021-10-27 06:10:07');
INSERT INTO `ivwh_copy1` VALUES ('97', 'G.', '3AW', '2', null, null, '2021-10-27 06:10:07');
INSERT INTO `ivwh_copy1` VALUES ('98', 'BS', '3AW', '24', null, null, '2021-10-27 06:27:09');
INSERT INTO `ivwh_copy1` VALUES ('99', 'WO', '3AW', '70', null, null, '2021-10-28 02:32:24');
INSERT INTO `ivwh_copy1` VALUES ('100', 'AD', '3AW', '22', null, null, '2021-10-27 06:22:49');
INSERT INTO `ivwh_copy1` VALUES ('101', 'MS', '3AW', '8', null, null, '2021-10-27 06:23:37');
INSERT INTO `ivwh_copy1` VALUES ('102', 'EGCS', '3AW', '17', null, null, '2021-10-27 06:25:04');
INSERT INTO `ivwh_copy1` VALUES ('103', 'MCS', '3AW', '2', null, null, '2021-10-27 06:25:04');

-- ----------------------------
-- Table structure for ivwh_copy2
-- ----------------------------
DROP TABLE IF EXISTS `ivwh_copy2`;
CREATE TABLE `ivwh_copy2` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `item` varchar(12) NOT NULL DEFAULT '',
  `whs` varchar(5) DEFAULT NULL,
  `qty_good` int(11) DEFAULT NULL,
  `qty_bo` int(11) DEFAULT '0',
  `idtime` datetime DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`item`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=107 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of ivwh_copy2
-- ----------------------------
INSERT INTO `ivwh_copy2` VALUES ('39', 'BC1K', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('40', 'WO10ML', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('41', 'WTC52', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('42', '10-200013', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('43', '10-000189', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('44', 'HKG', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('45', 'BCG', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('46', 'EG', '3AW', '12', null, null, '2021-11-10 10:52:39');
INSERT INTO `ivwh_copy2` VALUES ('47', 'AT20%', '3AW', '2', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('48', 'PEC', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('49', 'PEO', '3AW', '8', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('50', 'CPO', '3AW', '6', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('51', 'G', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('52', 'TMPS', '3AW', '8', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('53', 'TTG', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('54', 'A', '3AW', '-5', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('55', 'IO', '3AW', '2', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('56', 'PE', '3AW', '6', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('57', 'CP', '3AW', '6', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('58', 'VBCI', '3AW', '11', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('59', 'II', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('60', 'N20%', '3AW', '2', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('61', 'C', '3AW', '3', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('62', 'MVEO', '3AW', '5', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('63', 'BN', '3AW', '10', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('64', 'MVE', '3AW', '138', null, null, '2021-11-09 12:13:04');
INSERT INTO `ivwh_copy2` VALUES ('65', 'IFPM ', '3AW', '2', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('66', 'LSBFMP', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('67', 'CSFPM', '3AW', '1', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('68', 'E20%', '3AW', '1', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('69', 'VBCAA', '3AW', '2', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('70', 'E10%', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('71', 'LH', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('72', 'LSB', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('73', 'O', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('74', 'B', '3AW', '7', null, null, '2021-11-07 23:03:06');
INSERT INTO `ivwh_copy2` VALUES ('75', 'HC', '3AW', '3', null, null, '2021-11-07 23:03:06');
INSERT INTO `ivwh_copy2` VALUES ('76', 'CPFS', '3AW', '6', null, null, '2021-11-07 23:03:06');
INSERT INTO `ivwh_copy2` VALUES ('77', 'PP', '3AW', '50', null, null, '2021-11-07 23:03:06');
INSERT INTO `ivwh_copy2` VALUES ('78', 'ID', '3AW', '6', null, null, '2021-11-07 23:03:06');
INSERT INTO `ivwh_copy2` VALUES ('79', 'CSP', '3AW', '5', null, null, '2021-11-07 23:03:06');
INSERT INTO `ivwh_copy2` VALUES ('80', '1', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('81', 'KHPS', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('104', 'ZP', '3AW', '97', null, null, '2021-11-07 23:08:55');
INSERT INTO `ivwh_copy2` VALUES ('86', 'B+CLM', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('87', 'KHS', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('88', 'KHG', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('89', 'KHF', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('90', 'MMHL-GMC', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('91', 'MMHG-GMC', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('92', 'NBP', '3AW', '4', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('93', 'VC', '3AW', '7', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('94', 'GL', '3AW', '6', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('95', 'D', '3AW', '1', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('96', 'IPM', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('97', 'G.', '3AW', '1', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('98', 'BS', '3AW', '1', null, null, '2021-11-09 02:54:01');
INSERT INTO `ivwh_copy2` VALUES ('99', 'WO', '3AW', '71', null, null, '2021-10-30 11:02:21');
INSERT INTO `ivwh_copy2` VALUES ('100', 'AD', '3AW', '0', null, null, '2021-10-30 10:40:35');
INSERT INTO `ivwh_copy2` VALUES ('101', 'MS', '3AW', '8', null, null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('102', 'EGCS', '3AW', '17', null, null, '2021-10-30 11:01:41');
INSERT INTO `ivwh_copy2` VALUES ('103', 'MCS', '3AW', '2', null, null, '2021-10-30 11:01:53');
INSERT INTO `ivwh_copy2` VALUES ('105', 'IINJ', '3AW', '6', '0', null, '2021-11-09 04:23:47');
INSERT INTO `ivwh_copy2` VALUES ('106', 'TTG,', '3AW', '14', '0', null, '2021-11-10 10:51:35');

-- ----------------------------
-- Table structure for outlet
-- ----------------------------
DROP TABLE IF EXISTS `outlet`;
CREATE TABLE `outlet` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `outletcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `outletname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`outletcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of outlet
-- ----------------------------
INSERT INTO `outlet` VALUES ('13', 'T', 'TECHNICIAN', null, '2021-12-03 10:24:57');
INSERT INTO `outlet` VALUES ('11', 'FPI', 'FARM PIGGERY', null, '2021-10-26 13:31:37');
INSERT INTO `outlet` VALUES ('12', 'FPO', 'FARM POULTRY', null, '2021-10-26 13:34:44');
INSERT INTO `outlet` VALUES ('9', 'M', 'MEGA DEALER', null, '2021-10-26 13:30:43');
INSERT INTO `outlet` VALUES ('8', 'C', 'CONSUMER', null, '2021-09-29 11:58:00');
INSERT INTO `outlet` VALUES ('14', 'SUP', 'SUPER MAKERT', null, '2022-03-19 02:51:41');
INSERT INTO `outlet` VALUES ('15', 'GRO', 'GROCERIES', null, '2022-03-19 02:51:49');
INSERT INTO `outlet` VALUES ('16', 'SSS', 'SARI SARI STORE', null, '2022-03-19 02:51:59');

-- ----------------------------
-- Table structure for paycheck
-- ----------------------------
DROP TABLE IF EXISTS `paycheck`;
CREATE TABLE `paycheck` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `voucherno` varchar(15) DEFAULT NULL,
  `checkbank` varchar(15) DEFAULT NULL,
  `checkno` varchar(15) DEFAULT NULL,
  `checkdate` date DEFAULT NULL,
  `checkamount` decimal(15,2) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of paycheck
-- ----------------------------

-- ----------------------------
-- Table structure for payd
-- ----------------------------
DROP TABLE IF EXISTS `payd`;
CREATE TABLE `payd` (
  `pk` int(11) NOT NULL,
  `tno` int(11) DEFAULT NULL,
  `ttype` varchar(2) DEFAULT NULL,
  `reftype` varchar(1) DEFAULT NULL,
  `refno` varchar(10) DEFAULT NULL,
  `refamt` decimal(15,0) DEFAULT NULL,
  `refdate` date DEFAULT NULL,
  `refdoc` varchar(10) DEFAULT NULL,
  `isdelete` tinyint(4) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pk`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of payd
-- ----------------------------

-- ----------------------------
-- Table structure for payh
-- ----------------------------
DROP TABLE IF EXISTS `payh`;
CREATE TABLE `payh` (
  `pk` int(11) NOT NULL,
  `tno` int(11) DEFAULT NULL,
  `ttype` varchar(2) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `docno` varchar(10) DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `salesman` varchar(5) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `enteredby` varchar(20) DEFAULT NULL,
  `isdelete` tinyint(4) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pk`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of payh
-- ----------------------------

-- ----------------------------
-- Table structure for pcheck
-- ----------------------------
DROP TABLE IF EXISTS `pcheck`;
CREATE TABLE `pcheck` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `voucherno` varchar(15) DEFAULT NULL,
  `checkbank` varchar(15) DEFAULT NULL,
  `checkno` varchar(15) DEFAULT NULL,
  `checkdate` date DEFAULT NULL,
  `checkamount` decimal(15,2) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of pcheck
-- ----------------------------

-- ----------------------------
-- Table structure for phyiva
-- ----------------------------
DROP TABLE IF EXISTS `phyiva`;
CREATE TABLE `phyiva` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `whscode` varchar(10) DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `itemcode` varchar(30) DEFAULT NULL,
  `qty` int(10) DEFAULT '0',
  `pckgc` int(10) DEFAULT '0',
  `pckgb` int(10) DEFAULT '0',
  `variance` int(10) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `isdeleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of phyiva
-- ----------------------------
INSERT INTO `phyiva` VALUES ('1', 'P000000001', 'YLK', '2022-06-04', 'W52', '1500', '150', '1', '8989', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('2', 'P000000001', 'YLK', '2022-06-04', 'WW52', '1500', '150', '1', '-1350', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('3', 'P000000001', 'YLK', '2022-06-04', 'MSD', '650', '40', '5', '520', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('4', 'P000000001', 'YLK', '2022-06-04', 'W52', '1500', '150', '1', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('5', 'P000000001', 'YLK', '2022-06-04', 'WW52', '1500', '150', '1', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('6', 'P000000001', 'YLK', '2022-06-04', 'MSD', '650', '40', '5', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('7', 'P000000001', 'YLK', '2022-06-04', 'MSK', '600', '40', '5', '3300', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('8', 'P000000001', 'YLK', '2022-06-04', 'W52', '1500', '150', '1', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('9', 'P000000001', 'YLK', '2022-06-04', 'WW52', '1500', '150', '1', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('10', 'P000000001', 'YLK', '2022-06-04', 'MSD', '650', '40', '5', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('11', 'P000000001', 'YLK', '2022-06-04', 'W52', '1500', '150', '1', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('12', 'P000000001', 'YLK', '2022-06-04', 'WW52', '1500', '150', '1', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('13', 'P000000001', 'YLK', '2022-06-04', 'MSD', '650', '40', '5', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('14', 'P000000001', 'YLK', '2022-06-04', 'MSK', '600', '40', '5', '0', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('15', 'P000000001', 'YLK', '2022-06-04', 'MKS', '600', '40', '5', '3240', '2022-09-03 13:45:13', '0');
INSERT INTO `phyiva` VALUES ('16', 'P000000002', 'WHS1', '2022-09-03', 'MSK', '4000', '40', '5', '-4000', '2022-09-04 00:34:51', '0');
INSERT INTO `phyiva` VALUES ('17', 'P000000002', 'WHS1', '2022-09-03', 'MSD', '4000', '40', '5', '-4000', '2022-09-04 00:34:51', '0');
INSERT INTO `phyiva` VALUES ('18', 'P000000002', 'WHS1', '2022-09-03', 'MKS', '4000', '40', '5', '-4000', '2022-09-04 00:34:51', '0');
INSERT INTO `phyiva` VALUES ('19', 'P000000002', 'WHS1', '2022-09-03', 'W52', '15000', '150', '1', '-14550', '2022-09-04 00:34:52', '0');
INSERT INTO `phyiva` VALUES ('20', 'P000000002', 'WHS1', '2022-09-03', 'WW52', '15000', '150', '1', '-14550', '2022-09-04 00:34:52', '0');
INSERT INTO `phyiva` VALUES ('21', 'P000000003', '3AW', '2022-09-04', 'W52', '150', '150', '1', '1650', '2022-09-04 00:36:29', '0');

-- ----------------------------
-- Table structure for phyivd
-- ----------------------------
DROP TABLE IF EXISTS `phyivd`;
CREATE TABLE `phyivd` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `whscode` varchar(10) DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `itemcode` varchar(30) DEFAULT NULL,
  `qtyc` decimal(10,2) DEFAULT '0.00',
  `qtyb` decimal(10,2) DEFAULT '0.00',
  `qtyp` decimal(10,2) DEFAULT '0.00',
  `pckgc` int(10) DEFAULT '0',
  `pckgb` int(10) DEFAULT '0',
  `isdeleted` varchar(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of phyivd
-- ----------------------------
INSERT INTO `phyivd` VALUES ('1', 'P000000001', 'YLK', '2022-06-04', 'W52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-06-04 07:58:47');
INSERT INTO `phyivd` VALUES ('2', 'P000000001', 'YLK', '2022-06-04', 'WW52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-06-04 07:58:47');
INSERT INTO `phyivd` VALUES ('3', 'P000000001', 'YLK', '2022-06-04', 'MSD', '15.00', '10.00', '0.00', '40', '5', '0', '2022-06-04 07:58:47');
INSERT INTO `phyivd` VALUES ('4', 'P000000001', 'YLK', '2022-06-04', 'W52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-07-27 06:54:01');
INSERT INTO `phyivd` VALUES ('5', 'P000000001', 'YLK', '2022-06-04', 'WW52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-07-27 06:54:01');
INSERT INTO `phyivd` VALUES ('6', 'P000000001', 'YLK', '2022-06-04', 'MSD', '15.00', '10.00', '0.00', '40', '5', '0', '2022-07-27 06:54:01');
INSERT INTO `phyivd` VALUES ('7', 'P000000001', 'YLK', '2022-06-04', 'MSK', '15.00', '0.00', '0.00', '40', '5', '0', '2022-07-27 06:54:01');
INSERT INTO `phyivd` VALUES ('8', 'P000000001', 'YLK', '2022-06-04', 'W52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('9', 'P000000001', 'YLK', '2022-06-04', 'WW52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('10', 'P000000001', 'YLK', '2022-06-04', 'MSD', '15.00', '10.00', '0.00', '40', '5', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('11', 'P000000001', 'YLK', '2022-06-04', 'W52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('12', 'P000000001', 'YLK', '2022-06-04', 'WW52', '10.00', '0.00', '0.00', '150', '1', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('13', 'P000000001', 'YLK', '2022-06-04', 'MSD', '15.00', '10.00', '0.00', '40', '5', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('14', 'P000000001', 'YLK', '2022-06-04', 'MSK', '15.00', '0.00', '0.00', '40', '5', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('15', 'P000000001', 'YLK', '2022-06-04', 'MKS', '15.00', '0.00', '0.00', '40', '5', '0', '2022-07-27 06:54:39');
INSERT INTO `phyivd` VALUES ('16', 'P000000002', 'WHS1', '2022-09-03', 'MSK', '100.00', '0.00', '0.00', '40', '5', '0', '2022-09-04 00:33:05');
INSERT INTO `phyivd` VALUES ('17', 'P000000002', 'WHS1', '2022-09-03', 'MSD', '100.00', '0.00', '0.00', '40', '5', '0', '2022-09-04 00:33:05');
INSERT INTO `phyivd` VALUES ('18', 'P000000002', 'WHS1', '2022-09-03', 'MKS', '100.00', '0.00', '0.00', '40', '5', '0', '2022-09-04 00:33:05');
INSERT INTO `phyivd` VALUES ('19', 'P000000002', 'WHS1', '2022-09-03', 'W52', '100.00', '0.00', '0.00', '150', '1', '0', '2022-09-04 00:33:05');
INSERT INTO `phyivd` VALUES ('20', 'P000000002', 'WHS1', '2022-09-03', 'WW52', '100.00', '0.00', '0.00', '150', '1', '0', '2022-09-04 00:33:05');
INSERT INTO `phyivd` VALUES ('21', 'P000000003', '3AW', '2022-09-04', 'W52', '1.00', '0.00', '0.00', '150', '1', '0', '2022-09-04 00:36:07');
INSERT INTO `phyivd` VALUES ('22', 'P000000004', 'WH10', '2022-09-04', 'W52', '1.00', '0.00', '0.00', '150', '1', '1', '2022-09-04 00:37:19');

-- ----------------------------
-- Table structure for phyivh
-- ----------------------------
DROP TABLE IF EXISTS `phyivh`;
CREATE TABLE `phyivh` (
  `pkno` int(12) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `tdate` date DEFAULT NULL,
  `whscode` varchar(5) DEFAULT NULL,
  `whsname` varchar(50) DEFAULT NULL,
  `remarks` varchar(150) DEFAULT NULL,
  `user` varchar(30) DEFAULT NULL,
  `posted` varchar(1) DEFAULT NULL,
  `isdeleted` varchar(1) DEFAULT '0',
  `isopen` varchar(1) DEFAULT NULL,
  `isopenby` varchar(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of phyivh
-- ----------------------------
INSERT INTO `phyivh` VALUES ('1', 'P000000001', '2022-06-04', 'YLK', 'YU LINKON JR. GEN. MDSE.', '', '1', 'Y', '0', '0', '1', '2022-09-04 00:35:50');
INSERT INTO `phyivh` VALUES ('2', 'P000000002', '2022-09-03', 'WHS1', 'WAREHOUSE 1', 'TEST PHYSICAL ENTRY', '1', 'Y', '0', '0', '1', '2022-09-04 00:35:36');
INSERT INTO `phyivh` VALUES ('3', 'P000000003', '2022-09-04', '3AW', '3A MAIN WAREHOUSE', 'SVAS', '1', 'Y', '0', '0', '1', '2022-09-04 00:36:29');
INSERT INTO `phyivh` VALUES ('4', 'P000000004', '2022-09-04', 'WH10', 'WAREHOUSE 10', 'SDV', '1', 'N', '1', '1', '1', '2022-09-04 00:37:19');

-- ----------------------------
-- Table structure for pod
-- ----------------------------
DROP TABLE IF EXISTS `pod`;
CREATE TABLE `pod` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `transno` varchar(12) DEFAULT NULL,
  `itemc` varchar(10) DEFAULT NULL,
  `ord` varchar(10) DEFAULT NULL,
  `qty` decimal(15,2) DEFAULT NULL,
  `unit` varchar(1) DEFAULT NULL,
  `pckg` int(5) DEFAULT NULL,
  `cost` decimal(15,2) DEFAULT NULL,
  `price` decimal(15,2) DEFAULT NULL,
  `disc1percent` decimal(15,2) DEFAULT NULL,
  `disc1amount` decimal(15,2) DEFAULT NULL,
  `disc2percent` decimal(15,2) DEFAULT NULL,
  `disc2amount` decimal(15,2) DEFAULT NULL,
  `qtyonhand` decimal(15,2) DEFAULT NULL,
  `isopen` varchar(1) DEFAULT NULL,
  `isopenby` varchar(1) DEFAULT NULL,
  `isdeleted` varchar(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of pod
-- ----------------------------

-- ----------------------------
-- Table structure for poh
-- ----------------------------
DROP TABLE IF EXISTS `poh`;
CREATE TABLE `poh` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `transno` varchar(12) DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `salesman` varchar(5) DEFAULT NULL,
  `whs` varchar(5) DEFAULT NULL,
  `pono` varchar(12) DEFAULT NULL,
  `grostot` decimal(15,2) DEFAULT NULL,
  `disc1percent` decimal(15,2) DEFAULT NULL,
  `disc1amount` decimal(15,2) DEFAULT NULL,
  `disc2percent` decimal(15,2) DEFAULT NULL,
  `disc2amount` decimal(15,2) DEFAULT NULL,
  `disc1net` decimal(15,2) DEFAULT NULL,
  `disc2net` decimal(15,2) DEFAULT NULL,
  `totalamt` decimal(15,2) DEFAULT NULL,
  `status` varchar(1) DEFAULT NULL,
  `invoicedate` date DEFAULT NULL,
  `remaks` varchar(150) DEFAULT NULL,
  `isopen` varchar(1) DEFAULT NULL,
  `isopenby` varchar(1) DEFAULT NULL,
  `isdeleted` varchar(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of poh
-- ----------------------------

-- ----------------------------
-- Table structure for pohis
-- ----------------------------
DROP TABLE IF EXISTS `pohis`;
CREATE TABLE `pohis` (
  `pkno` int(12) NOT NULL AUTO_INCREMENT,
  `transno` int(12) DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `salesman` varchar(5) DEFAULT NULL,
  `podate` date DEFAULT NULL,
  `invoicedate` date DEFAULT NULL,
  `invoiceno` varchar(12) DEFAULT NULL,
  `remarks` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`pkno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of pohis
-- ----------------------------

-- ----------------------------
-- Table structure for province
-- ----------------------------
DROP TABLE IF EXISTS `province`;
CREATE TABLE `province` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `provcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `provincename` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`provcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of province
-- ----------------------------
INSERT INTO `province` VALUES ('1', 'MO', 'MISAMIS OCCIDENTAL', null, '2020-09-03 06:57:36');
INSERT INTO `province` VALUES ('2', 'MR', 'MISAMIS ORIENTAL', null, '2020-09-03 06:59:19');
INSERT INTO `province` VALUES ('3', 'ZDS', 'ZABOANGA DEL SUR', null, '2020-09-03 06:59:34');
INSERT INTO `province` VALUES ('4', 'ZDN', 'ZAMBOANGA DEL NORTE', null, '2020-09-03 06:59:45');
INSERT INTO `province` VALUES ('6', 'LDN', 'LANAO DEL NORTE', null, '2020-09-03 08:00:50');
INSERT INTO `province` VALUES ('7', 'ZY', 'ZAMBOANGA SIBUGAY', null, '2021-04-10 07:12:07');
INSERT INTO `province` VALUES ('8', 'BUK', 'BUKIDNON', null, '2021-04-10 07:15:22');

-- ----------------------------
-- Table structure for rcvingd
-- ----------------------------
DROP TABLE IF EXISTS `rcvingd`;
CREATE TABLE `rcvingd` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(15) NOT NULL,
  `tdate` date DEFAULT NULL,
  `whscode` varchar(10) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `itemcode` varchar(50) DEFAULT NULL,
  `qty` int(10) DEFAULT NULL,
  `qunit` varchar(1) DEFAULT NULL,
  `pckg` int(11) DEFAULT NULL,
  `grosscost` decimal(15,2) DEFAULT NULL,
  `listcost` decimal(15,2) DEFAULT NULL,
  `listunit` varchar(1) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `grossamt` decimal(15,2) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `discpercent` decimal(15,2) DEFAULT NULL,
  `discamount` decimal(15,2) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=86 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of rcvingd
-- ----------------------------
INSERT INTO `rcvingd` VALUES ('1', 'R000000001', '2022-06-21', 'YLK', 'GB80', '100', 'C', '72', null, null, null, '16.33', '16.33', '16.33', '1633.00', null, null, '0', '2022-07-15', '2022-07-15 07:47:42');
INSERT INTO `rcvingd` VALUES ('2', 'R000000001', '2022-06-21', 'YLK', 'GBR80', '150', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '176364.00', null, null, '0', '2022-07-15', '2022-07-15 07:25:10');
INSERT INTO `rcvingd` VALUES ('3', 'R000000001', '2022-06-21', 'YLK', 'GP80', '50', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '58788.00', null, null, '0', '2022-07-15', '2022-07-15 07:25:10');
INSERT INTO `rcvingd` VALUES ('4', 'R000000001', '2022-06-21', 'YLK', 'GW80', '100', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '117576.00', null, null, '0', null, '2022-06-21 07:22:09');
INSERT INTO `rcvingd` VALUES ('5', 'R000000001', '2022-06-21', 'YLK', 'MSK', '100', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '48000.00', null, null, '0', null, '2022-06-21 07:22:09');
INSERT INTO `rcvingd` VALUES ('6', 'R000000001', '2022-06-21', 'YLK', 'MKS', '100', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '48000.00', null, null, '0', null, '2022-06-21 07:26:59');
INSERT INTO `rcvingd` VALUES ('7', 'R000000001', '2022-06-21', 'YLK', 'MMA', '100', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '48000.00', null, null, '0', null, '2022-06-21 07:26:59');
INSERT INTO `rcvingd` VALUES ('8', 'R000000001', '2022-06-21', 'YLK', 'MAB', '100', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '48000.00', null, null, '0', null, '2022-06-21 07:26:59');
INSERT INTO `rcvingd` VALUES ('9', 'R000000001', '2022-06-21', 'YLK', 'MPS', '100', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '48000.00', null, null, '0', null, '2022-06-21 07:26:59');
INSERT INTO `rcvingd` VALUES ('10', 'R000000001', '2022-06-21', 'YLK', 'MSD', '100', 'C', '40', null, null, null, '470.00', '11.75', '480.00', '47000.00', null, null, '1', null, '2022-07-15 07:25:10');
INSERT INTO `rcvingd` VALUES ('11', 'R000000002', '2022-06-28', 'YLK', 'GB80', '100', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '117576.00', null, null, '0', null, '2022-06-28 07:10:54');
INSERT INTO `rcvingd` VALUES ('12', 'R000000002', '2022-06-28', 'YLK', 'GBR80', '100', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '117576.00', null, null, '0', null, '2022-06-28 07:10:54');
INSERT INTO `rcvingd` VALUES ('13', 'R000000002', '2022-06-28', 'YLK', 'GP80', '100', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '117576.00', null, null, '0', null, '2022-06-28 07:10:54');
INSERT INTO `rcvingd` VALUES ('14', 'R000000002', '2022-06-28', 'YLK', 'GW80', '100', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '117576.00', null, null, '0', '2022-07-19', '2022-07-19 02:12:45');
INSERT INTO `rcvingd` VALUES ('15', 'R000000003', '2022-07-15', 'YLK', 'MSD', '10', 'C', '40', null, null, null, '11.75', '11.75', '480.00', '4700.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('16', 'R000000004', '2022-07-15', 'YLK', 'MSD', '10', 'C', '40', null, null, null, '470.00', '11.75', '480.00', '4700.00', null, null, '0', '2022-07-15', '2022-07-15 07:37:00');
INSERT INTO `rcvingd` VALUES ('17', 'R000000005', '2022-07-15', 'WHS3', 'GB80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '1', '2022-07-15', '2022-07-20 02:00:23');
INSERT INTO `rcvingd` VALUES ('18', 'R000000006', '2022-07-15', 'WHS3', 'GB80', '10', 'P', '1', null, null, null, '16.33', '16.33', '16.33', '163.30', null, null, '1', '2022-07-15', '2022-07-20 03:11:30');
INSERT INTO `rcvingd` VALUES ('19', 'R000000007', '2022-07-15', 'WHS4', 'GB80', '10', 'C', '72', null, null, null, '16.33', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-15', '2022-07-15 08:11:05');
INSERT INTO `rcvingd` VALUES ('20', 'R000000007', '2022-07-15', 'WHS4', 'GP80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-15', '2022-07-15 08:11:05');
INSERT INTO `rcvingd` VALUES ('21', 'R000000007', '2022-07-15', 'WHS4', 'GW80', '20', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '23515.20', null, null, '0', '2022-07-15', '2022-07-15 08:11:05');
INSERT INTO `rcvingd` VALUES ('22', 'R000000007', '2022-07-15', 'WHS4', 'GBR80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-15', '2022-07-15 08:11:05');
INSERT INTO `rcvingd` VALUES ('23', 'R000000008', '2022-07-15', 'WHS7', 'GB80', '5', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '5878.80', null, null, '0', '2022-07-15', '2022-07-15 08:21:21');
INSERT INTO `rcvingd` VALUES ('24', 'R000000008', '2022-07-15', 'WHS7', 'GW80', '5', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '5878.80', null, null, '0', '2022-07-15', '2022-07-15 08:21:21');
INSERT INTO `rcvingd` VALUES ('25', 'R000000008', '2022-07-15', 'WHS7', 'GP80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-15', '2022-07-15 08:21:21');
INSERT INTO `rcvingd` VALUES ('26', 'R000000008', '2022-07-15', 'WHS7', 'GBR80', '10', 'P', '1', null, null, null, '16.33', '16.33', '16.33', '163.30', null, null, '0', '2022-07-15', '2022-07-15 08:21:21');
INSERT INTO `rcvingd` VALUES ('27', 'R000000003', '2022-07-15', 'YLK', 'MPS', '10', 'B', '5', null, null, null, '60.00', '12.00', '60.00', '600.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('28', 'R000000003', '2022-07-15', 'YLK', 'MPS', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('29', 'R000000003', '2022-07-15', 'YLK', 'MAB', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('30', 'R000000003', '2022-07-15', 'YLK', 'W52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('31', 'R000000003', '2022-07-15', 'YLK', 'WW52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('32', 'R000000003', '2022-07-15', 'YLK', 'WTC52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-16', '2022-07-16 02:46:55');
INSERT INTO `rcvingd` VALUES ('33', 'R000000009', '2022-07-16', 'YLK', 'MSD', '10', 'B', '5', null, null, null, '58.75', '11.75', '58.75', '587.50', null, null, '0', '2022-07-16', '2022-07-16 02:58:33');
INSERT INTO `rcvingd` VALUES ('34', 'R000000010', '2022-07-16', 'YLK', 'MSD', '10', 'B', '5', null, null, null, '58.75', '11.75', '58.75', '587.50', null, null, '0', '2022-07-16', '2022-07-16 03:08:51');
INSERT INTO `rcvingd` VALUES ('35', 'R000000011', '2022-07-16', 'YLK', 'MSK', '10', 'B', '5', null, null, null, '60.00', '12.00', '60.00', '600.00', null, null, '0', '2022-07-16', '2022-07-16 03:21:10');
INSERT INTO `rcvingd` VALUES ('36', 'R000000012', '2022-07-19', 'WHS14', 'WW52', '1', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '900.00', null, null, '1', '2022-07-19', '2022-07-19 08:49:58');
INSERT INTO `rcvingd` VALUES ('37', 'R000000002', '2022-06-28', 'YLK', 'W52', '1', 'P', '1', null, null, null, '6.00', '6.00', '6.00', '6.00', null, null, '0', '2022-07-19', '2022-07-19 02:30:41');
INSERT INTO `rcvingd` VALUES ('38', 'R000000012', '2022-07-19', 'WHS14', 'GB80', '1', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '1175.76', null, null, '0', '2022-07-19', '2022-07-19 08:49:58');
INSERT INTO `rcvingd` VALUES ('39', 'R000000013', '2022-07-20', 'YLK', 'GB80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '1', '2022-07-20', '2022-07-20 00:51:20');
INSERT INTO `rcvingd` VALUES ('40', 'R000000013', '2022-07-20', 'YLK', 'GBR80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '1', '2022-07-20', '2022-07-20 00:51:20');
INSERT INTO `rcvingd` VALUES ('41', 'R000000013', '2022-07-20', 'WHS16', 'W52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 00:54:14');
INSERT INTO `rcvingd` VALUES ('42', 'R000000013', '2022-07-20', 'WHS16', 'WW52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 00:54:14');
INSERT INTO `rcvingd` VALUES ('43', 'R000000013', '2022-07-20', 'WHS16', 'WTC52', '10', 'P', '1', null, null, null, '6.00', '6.00', '6.00', '60.00', null, null, '1', '2022-07-20', '2022-07-20 01:52:43');
INSERT INTO `rcvingd` VALUES ('44', 'R000000013', '2022-07-20', 'WHS16', 'MSK', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-20', '2022-07-20 00:54:14');
INSERT INTO `rcvingd` VALUES ('45', 'R000000013', '2022-07-20', 'WHS16', 'MKS', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-20', '2022-07-20 01:02:53');
INSERT INTO `rcvingd` VALUES ('46', 'R000000013', '2022-07-20', 'WHS16', 'MSD', '1', 'C', '40', null, null, null, '470.00', '11.75', '480.00', '470.00', null, null, '0', '2022-07-20', '2022-07-20 01:02:53');
INSERT INTO `rcvingd` VALUES ('47', 'R000000013', '2022-07-20', 'WHS16', 'MMA', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-20', '2022-07-20 01:02:53');
INSERT INTO `rcvingd` VALUES ('48', 'R000000013', '2022-07-20', 'WHS16', 'MAB', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-20', '2022-07-20 01:02:53');
INSERT INTO `rcvingd` VALUES ('49', 'R000000013', '2022-07-20', 'WHS16', 'MPS', '1', 'C', '40', null, null, null, '480.00', '12.00', '480.00', '480.00', null, null, '0', '2022-07-20', '2022-07-20 01:02:53');
INSERT INTO `rcvingd` VALUES ('50', 'R000000013', '2022-07-20', 'WHS16', 'MSD', '5', 'B', '5', null, null, null, '58.75', '11.75', '58.75', '293.75', null, null, '0', '2022-07-20', '2022-07-20 01:02:53');
INSERT INTO `rcvingd` VALUES ('51', 'R000000014', '2022-07-20', 'WHS16', 'W52', '1', 'C', '150', null, null, null, '6.00', '6.00', '900.00', '900.00', null, null, '0', '2022-07-20', '2022-07-20 01:50:32');
INSERT INTO `rcvingd` VALUES ('52', 'R000000014', '2022-07-20', 'WHS16', 'MKS', '1', 'B', '5', null, null, null, '60.00', '12.00', '60.00', '60.00', null, null, '1', '2022-07-20', '2022-07-20 08:48:35');
INSERT INTO `rcvingd` VALUES ('53', 'R000000015', '2022-07-01', 'YLK', 'TBD10\'S', '10', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '13860.00', null, null, '0', '2022-07-20', '2022-08-04 06:32:57');
INSERT INTO `rcvingd` VALUES ('54', 'R000000015', '2022-07-01', 'YLK', 'TBR10\'S', '10', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '13860.00', null, null, '0', '2022-07-20', '2022-08-04 06:32:31');
INSERT INTO `rcvingd` VALUES ('55', 'R000000015', '2022-07-01', 'YLK', 'TW10\'S', '10', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '13860.00', null, null, '1', '2022-07-20', '2022-08-04 06:32:07');
INSERT INTO `rcvingd` VALUES ('56', 'R000000014', '2022-07-20', 'WHS16', 'TW10\'S', '5', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '6930.00', null, null, '0', '2022-07-20', '2022-08-04 06:32:07');
INSERT INTO `rcvingd` VALUES ('57', 'R000000014', '2022-07-20', 'WHS16', 'TBR10\'S', '5', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '6930.00', null, null, '0', '2022-07-20', '2022-08-04 06:32:31');
INSERT INTO `rcvingd` VALUES ('58', 'R000000013', '2022-07-20', 'WHS16', 'TW10\'S', '1', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '1386.00', null, null, '0', '2022-07-20', '2022-08-04 06:32:07');
INSERT INTO `rcvingd` VALUES ('59', 'R000000005', '2022-07-15', 'WHS3', 'GP80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '1', '2022-07-20', '2022-07-20 02:01:15');
INSERT INTO `rcvingd` VALUES ('60', 'R000000005', '2022-07-15', 'WHS3', 'GW80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-20', '2022-07-20 02:00:23');
INSERT INTO `rcvingd` VALUES ('61', 'R000000005', '2022-07-15', 'WHS3', 'GBR80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-20', '2022-07-20 02:01:15');
INSERT INTO `rcvingd` VALUES ('62', 'R000000006', '2022-07-15', 'WHS3', 'GP80', '10', 'C', '72', null, null, null, '16.33', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-20', '2022-07-20 03:12:12');
INSERT INTO `rcvingd` VALUES ('63', 'R000000006', '2022-07-15', 'WHS3', 'GW80', '1', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '1175.76', null, null, '1', '2022-07-20', '2022-07-20 03:13:52');
INSERT INTO `rcvingd` VALUES ('64', 'R000000006', '2022-07-15', 'WHS3', 'GBR80', '1', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '1175.76', null, null, '0', '2022-07-20', '2022-07-20 03:13:52');
INSERT INTO `rcvingd` VALUES ('65', 'R000000015', '2022-07-01', 'YLK', 'MSD', '2', 'C', '40', null, null, null, '470.00', '11.75', '480.00', '940.00', null, null, '0', '2022-07-20', '2022-07-20 08:35:38');
INSERT INTO `rcvingd` VALUES ('66', 'R000000014', '2022-07-20', 'WHS16', 'GP80', '1', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '1175.76', null, null, '0', '2022-07-20', '2022-07-20 08:48:35');
INSERT INTO `rcvingd` VALUES ('67', 'R000000016', '2022-07-20', 'WHS19', 'W52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 08:50:47');
INSERT INTO `rcvingd` VALUES ('68', 'R000000016', '2022-07-20', 'WHS19', 'WW52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 08:50:47');
INSERT INTO `rcvingd` VALUES ('69', 'R000000016', '2022-07-20', 'WHS19', 'WTC52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 08:50:47');
INSERT INTO `rcvingd` VALUES ('70', 'R000000016', '2022-07-20', 'WHS19', 'GB80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '1', '2022-07-20', '2022-07-21 05:39:25');
INSERT INTO `rcvingd` VALUES ('71', 'R000000017', '2022-07-20', 'WHS19', 'W52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '1', '2022-07-20', '2022-07-20 08:57:22');
INSERT INTO `rcvingd` VALUES ('72', 'R000000017', '2022-07-20', 'WHS20', 'WW52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 08:58:44');
INSERT INTO `rcvingd` VALUES ('73', 'R000000017', '2022-07-20', 'WHS20', 'WTC52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-07-20', '2022-07-20 08:58:44');
INSERT INTO `rcvingd` VALUES ('74', 'R000000017', '2022-07-20', 'WHS20', 'GB80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-20', '2022-07-20 08:58:44');
INSERT INTO `rcvingd` VALUES ('75', 'R000000017', '2022-07-20', 'WHS19', 'GW80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '1', '2022-07-20', '2022-07-20 08:58:44');
INSERT INTO `rcvingd` VALUES ('76', 'R000000017', '2022-07-20', 'WHS20', 'GP80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-20', '2022-07-20 08:58:44');
INSERT INTO `rcvingd` VALUES ('77', 'R000000016', '2022-07-20', 'WHS19', 'GW80', '10', 'C', '72', null, null, null, '1176.00', '16.33', '1176.00', '11757.60', null, null, '0', '2022-07-21', '2022-07-21 05:39:25');
INSERT INTO `rcvingd` VALUES ('78', 'R000000018', '2022-08-03', 'YLK', 'W52', '5', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '4500.00', null, null, '0', '2022-08-03', '2022-08-03 03:23:54');
INSERT INTO `rcvingd` VALUES ('79', 'R000000018', '2022-08-03', 'YLK', 'WW52', '10', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-08-03', '2022-08-03 03:12:49');
INSERT INTO `rcvingd` VALUES ('80', 'R000000018', '2022-08-03', 'YLK', 'WTC52', '10', 'C', '150', null, null, null, '6.00', '6.00', '900.00', '9000.00', null, null, '0', '2022-08-03', '2022-08-03 03:12:49');
INSERT INTO `rcvingd` VALUES ('81', 'R000000019', '2022-08-03', 'YLK', 'W52', '20', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '18000.00', null, null, '0', '2022-08-03', '2022-08-03 08:05:11');
INSERT INTO `rcvingd` VALUES ('82', 'R000000019', '2022-08-03', 'YLK', 'WW52', '20', 'C', '150', null, null, null, '900.00', '6.00', '900.00', '18000.00', null, null, '0', '2022-08-03', '2022-08-03 08:11:25');
INSERT INTO `rcvingd` VALUES ('83', 'R000000019', '2022-08-03', 'YLK', 'WTC52', '10', 'P', '1', null, null, null, '6.00', '6.00', '6.00', '60.00', null, null, '0', '2022-08-03', '2022-08-03 08:06:57');
INSERT INTO `rcvingd` VALUES ('84', 'R000000019', '2022-08-03', 'YLK', 'TW10\'S', '20', 'C', '360', null, null, null, '3.85', '3.85', '1386.00', '27720.00', null, null, '0', '2022-08-03', '2022-08-04 06:32:07');
INSERT INTO `rcvingd` VALUES ('85', 'R000000019', '2022-08-03', 'YLK', 'TBD10\'S', '10', 'C', '360', null, null, null, '1386.00', '3.85', '1386.00', '13860.00', null, null, '0', '2022-08-03', '2022-08-04 06:32:57');

-- ----------------------------
-- Table structure for rcvingd_deleted
-- ----------------------------
DROP TABLE IF EXISTS `rcvingd_deleted`;
CREATE TABLE `rcvingd_deleted` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT,
  `transno` varchar(15) NOT NULL,
  `date` date DEFAULT NULL,
  `whscode` varchar(10) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `itemcode` varchar(50) DEFAULT NULL,
  `qty` decimal(10,2) DEFAULT NULL,
  `qunit` varchar(1) DEFAULT NULL,
  `pckg` int(11) DEFAULT NULL,
  `grosscost` decimal(15,2) DEFAULT NULL,
  `listcost` decimal(15,2) DEFAULT NULL,
  `listunit` varchar(1) DEFAULT NULL,
  `netcost` decimal(15,2) DEFAULT NULL,
  `costpc` decimal(15,2) DEFAULT NULL,
  `grossamt` decimal(15,2) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `discpercent` decimal(15,2) DEFAULT NULL,
  `discamount` decimal(15,2) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of rcvingd_deleted
-- ----------------------------

-- ----------------------------
-- Table structure for rcvingh
-- ----------------------------
DROP TABLE IF EXISTS `rcvingh`;
CREATE TABLE `rcvingh` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `tdate` date DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(20) DEFAULT NULL,
  `whscode` varchar(10) DEFAULT NULL,
  `supcode` varchar(20) DEFAULT NULL,
  `grossamt` decimal(15,2) DEFAULT NULL,
  `disc1percent` decimal(10,2) DEFAULT NULL,
  `disc1amount` decimal(15,2) DEFAULT NULL,
  `disc2percent` decimal(15,2) DEFAULT NULL,
  `disc2amount` decimal(15,2) DEFAULT NULL,
  `disc3percent` decimal(15,2) DEFAULT NULL,
  `disc3amount` decimal(15,2) DEFAULT NULL,
  `netamount` decimal(15,2) DEFAULT NULL,
  `lprint` tinyint(4) DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT NULL,
  `paidby` varchar(20) DEFAULT NULL,
  `datepaid` date DEFAULT NULL,
  `disc1peso` decimal(15,2) DEFAULT NULL,
  `disc2peso` decimal(15,2) DEFAULT NULL,
  `disc3peso` decimal(15,2) DEFAULT NULL,
  `isopen` varchar(1) DEFAULT NULL,
  `isopenby` varchar(1) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `paidon` date DEFAULT NULL,
  `balance` decimal(15,2) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of rcvingh
-- ----------------------------
INSERT INTO `rcvingh` VALUES ('1', 'R000000001', '2022-06-21', '10000000000000A', '10000000000000A', 'YLK', 'GSPI', '594361.00', '10.00', '59436.10', '5.00', '26746.25', '0.00', '0.00', '508178.66', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-15 07:25:10');
INSERT INTO `rcvingh` VALUES ('2', 'R000000002', '2022-06-28', '10000000000000B', '10000000000000B', 'YLK', 'GSPI', '470310.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '470310.00', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-19 02:30:41');
INSERT INTO `rcvingh` VALUES ('3', 'R000000003', '2022-07-15', '10000000000000C', '10000000000000C', 'YLK', 'GSPI', '33260.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '33260.00', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:19:23');
INSERT INTO `rcvingh` VALUES ('4', 'R000000004', '2022-07-15', '10000000000000E', '10000000000000E', 'YLK', 'GSPI', '4700.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '4700.00', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:19:36');
INSERT INTO `rcvingh` VALUES ('5', 'R000000005', '2022-07-15', '10000000000000F', '10000000000000F', 'WHS3', 'GSPI', '23515.20', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '23515.20', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 02:00:23');
INSERT INTO `rcvingh` VALUES ('6', 'R000000006', '2022-07-15', '10000000000000G', '10000000000000G', 'WHS3', 'GSPI', '12933.36', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '12933.36', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 03:12:12');
INSERT INTO `rcvingh` VALUES ('7', 'R000000007', '2022-07-15', '10000000000000D', '10000000000000D', 'WHS4', 'GSPI', '58788.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '58788.00', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:20:54');
INSERT INTO `rcvingh` VALUES ('8', 'R000000008', '2022-07-15', '10000000000000I', '10000000000000I', 'WHS7', 'GSPI', '23678.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '23678.50', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:20:26');
INSERT INTO `rcvingh` VALUES ('9', 'R000000009', '2022-07-16', '10000000000000J', '10000000000000J', 'YLK', 'GSPI', '587.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '587.50', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:20:35');
INSERT INTO `rcvingh` VALUES ('10', 'R000000010', '2022-07-16', '10000000000000H', '10000000000000H', 'YLK', 'GSPI', '587.50', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '587.50', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:21:07');
INSERT INTO `rcvingh` VALUES ('11', 'R000000011', '2022-07-16', '10000000000000K', '10000000000000K', 'YLK', 'GSPI', '600.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '600.00', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:21:37');
INSERT INTO `rcvingh` VALUES ('12', 'R000000012', '2022-07-19', '10000000000000L', '10000000000000L', 'WHS14', 'GSPI', '1175.76', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '1175.76', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:21:48');
INSERT INTO `rcvingh` VALUES ('13', 'R000000013', '2022-07-20', '10000000000000M', '10000000000000M', 'WHS16', 'GSPI', '22549.75', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '22549.75', null, null, null, null, null, null, null, null, null, '1', null, null, '0', '2022-07-20 01:52:43');
INSERT INTO `rcvingh` VALUES ('14', 'R000000014', '2022-07-20', '10000000000000O', '10000000000000O', 'WHS16', 'GSPI', '15935.76', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '15935.76', null, null, null, null, null, null, null, '0', '1', '1', null, null, '0', '2022-08-03 02:37:29');
INSERT INTO `rcvingh` VALUES ('15', 'R000000015', '2022-07-01', '10000000000000P', '10000000000000P', 'YLK', 'GSPI', '28660.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '28660.00', null, null, null, null, null, null, null, '0', '1', '1', null, null, '0', '2022-09-03 14:17:32');
INSERT INTO `rcvingh` VALUES ('16', 'R000000016', '2022-07-20', '10000000000000Q', '10000000000000Q', 'WHS19', 'GSPI', '38757.60', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '38757.60', null, null, null, null, null, null, null, '1', '1', '1', null, null, '0', '2022-08-03 02:32:21');
INSERT INTO `rcvingh` VALUES ('17', 'R000000017', '2022-07-20', '10000000000000R', '10000000000000R', 'WHS20', 'GSPI', '41515.20', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '41515.20', null, null, null, null, null, null, null, '0', '1', '1', null, null, '0', '2022-08-03 03:13:01');
INSERT INTO `rcvingh` VALUES ('18', 'R000000018', '2022-08-03', '10000000000000S', '10000000000000S', 'YLK', 'GSPI', '22500.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '22500.00', null, null, null, null, null, null, null, '1', '1', '1', null, null, '0', '2022-08-03 03:23:54');
INSERT INTO `rcvingh` VALUES ('19', 'R000000019', '2022-08-03', '10000000000000T', '10000000000000T', 'YLK', 'GSPI', '77640.00', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00', '77640.00', null, null, null, null, null, null, null, '1', '1', '1', null, null, '0', '2022-08-03 08:11:25');

-- ----------------------------
-- Table structure for rcvingh_deleted
-- ----------------------------
DROP TABLE IF EXISTS `rcvingh_deleted`;
CREATE TABLE `rcvingh_deleted` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `date` date DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(20) DEFAULT NULL,
  `whscode` varchar(10) DEFAULT NULL,
  `supcode` varchar(20) DEFAULT NULL,
  `grossamt` decimal(15,2) DEFAULT NULL,
  `disc1percent` decimal(10,2) DEFAULT NULL,
  `disc1amount` decimal(15,2) DEFAULT NULL,
  `disc2percent` decimal(15,2) DEFAULT NULL,
  `disc2amount` decimal(15,2) DEFAULT NULL,
  `disc3percent` decimal(15,2) DEFAULT NULL,
  `disc3amount` decimal(15,2) DEFAULT NULL,
  `netamount` decimal(15,2) DEFAULT NULL,
  `lprint` tinyint(4) DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT NULL,
  `paidby` varchar(20) DEFAULT NULL,
  `datepaid` date DEFAULT NULL,
  `disc1peso` decimal(15,2) DEFAULT NULL,
  `disc2peso` decimal(15,2) DEFAULT NULL,
  `disc3peso` decimal(15,2) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `paidon` date DEFAULT NULL,
  `balance` decimal(15,2) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of rcvingh_deleted
-- ----------------------------

-- ----------------------------
-- Table structure for salesd
-- ----------------------------
DROP TABLE IF EXISTS `salesd`;
CREATE TABLE `salesd` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL DEFAULT '',
  `ttype` varchar(1) DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `whscode` varchar(5) DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(15) DEFAULT NULL,
  `itemcode` varchar(20) DEFAULT NULL,
  `qty` decimal(10,2) DEFAULT NULL,
  `qunit` varchar(1) DEFAULT '',
  `pckg` int(10) DEFAULT NULL,
  `pricetype` varchar(1) DEFAULT NULL,
  `cost` decimal(15,2) DEFAULT '0.00',
  `uprice` decimal(15,2) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `rrindex` tinyint(4) DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `expdate` date DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`)
) ENGINE=MyISAM AUTO_INCREMENT=84 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of salesd
-- ----------------------------
INSERT INTO `salesd` VALUES ('1', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'W52', '2.00', 'C', '150', 'A', '0.00', '900.00', '1800.00', null, '1', null, '2022-07-21 07:13:22');
INSERT INTO `salesd` VALUES ('2', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'WW52', '2.00', 'C', '150', 'A', '0.00', '910.00', '1820.00', null, '1', null, '2022-07-21 07:19:04');
INSERT INTO `salesd` VALUES ('3', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'WTC52', '2.00', 'C', '150', 'A', '0.00', '900.00', '1800.00', null, '1', null, '2022-07-21 07:35:22');
INSERT INTO `salesd` VALUES ('4', 'S000000002', 'S', '2022-06-21', 'YLK', 'B', 'B', 'GP80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-06-21 07:30:39');
INSERT INTO `salesd` VALUES ('5', 'S000000002', 'S', '2022-06-21', 'YLK', 'B', 'B', 'GW80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-06-21 07:30:39');
INSERT INTO `salesd` VALUES ('6', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'GP80', '2.00', 'C', '72', 'A', '0.00', '1176.00', '2352.00', null, '1', null, '2022-07-21 08:02:37');
INSERT INTO `salesd` VALUES ('7', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'GW80', '2.00', 'C', '72', 'A', '0.00', '1176.00', '2352.00', null, '0', null, '2022-07-19 07:01:07');
INSERT INTO `salesd` VALUES ('8', 'S000000002', 'S', '2022-06-21', 'YLK', 'B', 'B', 'W52', '75.00', 'P', '1', 'A', '0.00', '6.00', '450.00', null, '0', null, '2022-06-21 07:50:44');
INSERT INTO `salesd` VALUES ('9', 'S000000002', 'S', '2022-06-21', 'YLK', 'B', 'B', 'WW52', '75.00', 'P', '1', 'A', '0.00', '6.07', '455.25', null, '0', null, '2022-06-21 07:51:30');
INSERT INTO `salesd` VALUES ('10', 'S000000003', 'S', '2022-06-21', 'YLK', 'C', 'C', 'GP80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-06-21 07:56:58');
INSERT INTO `salesd` VALUES ('11', 'S000000003', 'S', '2022-06-21', 'YLK', 'C', 'C', 'GW80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-06-21 07:56:58');
INSERT INTO `salesd` VALUES ('12', 'S000000003', 'S', '2022-06-21', 'YLK', 'C', 'C', 'GB80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-06-21 07:56:58');
INSERT INTO `salesd` VALUES ('13', 'S000000004', 'S', '2022-06-21', 'YLK', 'D', 'D', 'W52', '75.00', 'P', '1', 'A', '0.00', '6.00', '450.00', null, '0', null, '2022-06-21 08:20:18');
INSERT INTO `salesd` VALUES ('14', 'S000000004', 'S', '2022-06-21', 'YLK', 'D', 'D', 'WW52', '75.00', 'P', '1', 'A', '0.00', '6.07', '455.25', null, '0', null, '2022-06-21 08:20:18');
INSERT INTO `salesd` VALUES ('15', 'S000000005', 'S', '2022-06-22', 'YLK', 'E', 'E', 'W52', '12.00', 'P', '1', 'A', '0.00', '6.00', '72.00', null, '0', null, '2022-06-22 02:01:28');
INSERT INTO `salesd` VALUES ('16', 'S000000005', 'S', '2022-06-22', 'YLK', 'E', 'E', 'WW52', '12.00', 'P', '1', 'A', '0.00', '6.07', '72.84', null, '0', null, '2022-06-22 02:01:28');
INSERT INTO `salesd` VALUES ('17', 'S000000005', 'S', '2022-06-22', 'YLK', 'E', 'E', 'WTC52', '12.00', 'P', '1', 'A', '0.00', '6.00', '72.00', null, '0', null, '2022-06-22 02:01:28');
INSERT INTO `salesd` VALUES ('18', 'S000000006', 'S', '2022-06-22', 'YLK', 'F', 'F', 'GB80', '36.00', 'P', '1', 'B', '0.00', '16.39', '590.04', null, '0', null, '2022-06-22 02:02:48');
INSERT INTO `salesd` VALUES ('19', 'S000000006', 'S', '2022-06-22', 'YLK', 'F', 'F', 'GW80', '36.00', 'P', '1', 'B', '0.00', '16.33', '587.88', null, '0', null, '2022-06-22 02:02:48');
INSERT INTO `salesd` VALUES ('20', 'S000000007', 'S', '2022-06-22', 'YLK', 'G', 'G', 'W52', '1.00', 'C', '150', 'B', '0.00', '910.00', '910.00', null, '1', null, '2022-06-22 02:05:01');
INSERT INTO `salesd` VALUES ('21', 'S000000008', 'S', '2022-06-22', 'YLK', 'H', 'H', 'GP80', '36.00', 'C', '72', 'B', '0.00', '1176.00', '42336.00', null, '0', null, '2022-06-24 08:36:10');
INSERT INTO `salesd` VALUES ('22', 'S000000008', 'S', '2022-06-22', 'YLK', 'H', 'H', 'GW80', '36.00', 'C', '72', 'B', '0.00', '1176.00', '42336.00', null, '0', null, '2022-06-24 08:36:10');
INSERT INTO `salesd` VALUES ('23', 'R000000009', 'R', '2022-06-24', 'YLK', '1321', '', 'GB80', '4.00', 'C', '72', 'A', '0.00', '1176.00', '4704.00', null, '0', null, '2022-07-19 08:36:19');
INSERT INTO `salesd` VALUES ('24', 'R000000009', 'R', '2022-06-24', 'YLK', '1321', '', 'GBR80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-07-19 08:36:19');
INSERT INTO `salesd` VALUES ('25', 'R000000009', 'R', '2022-06-24', 'YLK', '1321', '', 'GP80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-07-19 08:36:19');
INSERT INTO `salesd` VALUES ('26', 'R000000009', 'R', '2022-06-24', 'YLK', '1321', '', 'GW80', '2.00', 'C', '72', 'A', '0.00', '1176.00', '2352.00', null, '0', null, '2022-06-24 08:22:46');
INSERT INTO `salesd` VALUES ('27', 'S000000008', 'S', '2022-06-22', 'YLK', 'H', 'H', 'WW52', '1.00', 'C', '150', 'B', '0.00', '920.00', '920.00', null, '0', null, '2022-06-24 08:29:54');
INSERT INTO `salesd` VALUES ('28', 'S000000008', 'S', '2022-06-22', 'YLK', 'H', 'H', 'W52', '1.00', 'C', '150', 'B', '0.00', '910.00', '910.00', null, '0', null, '2022-06-24 08:29:54');
INSERT INTO `salesd` VALUES ('29', 'S000000008', 'S', '2022-06-22', 'YLK', 'H', 'H', 'WTC52', '1.00', 'C', '150', 'B', '0.00', '900.00', '900.00', null, '0', null, '2022-06-24 08:29:54');
INSERT INTO `salesd` VALUES ('30', 'S000000010', 'S', '2022-06-28', '3AW', 'J', '', 'GB80', '5.00', 'P', '1', 'A', '0.00', '16.33', '81.65', null, '0', null, '2022-07-19 06:19:56');
INSERT INTO `salesd` VALUES ('31', 'S000000011', 'S', '2022-07-19', '3AW', 'I', '', 'GB80', '2.00', 'C', '72', 'B', '0.00', '1176.00', '2352.00', null, '1', null, '2022-07-19 06:08:53');
INSERT INTO `salesd` VALUES ('32', 'S000000011', 'S', '2022-07-19', '3AW', 'I', '', 'GBR80', '1.00', 'C', '72', 'B', '0.00', '1176.00', '1176.00', null, '1', null, '2022-07-19 06:08:53');
INSERT INTO `salesd` VALUES ('33', 'S000000011', 'S', '2022-07-19', '3AW', 'I', '', 'MSK', '1.00', 'B', '5', 'B', '0.00', '60.00', '60.00', null, '1', null, '2022-07-19 06:08:53');
INSERT INTO `salesd` VALUES ('34', 'S000000011', 'S', '2022-07-19', '3AW', 'I', '', 'GP80', '1.00', 'C', '72', 'B', '0.00', '1176.00', '1176.00', null, '1', null, '2022-07-19 06:08:53');
INSERT INTO `salesd` VALUES ('35', 'S000000011', 'S', '2022-07-19', '3AW', 'I', '', 'MKS', '1.00', 'B', '5', 'B', '0.00', '60.00', '60.00', null, '1', null, '2022-07-19 06:08:53');
INSERT INTO `salesd` VALUES ('36', 'S000000010', 'S', '2022-06-28', '3AW', 'J', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-07-19 06:19:56');
INSERT INTO `salesd` VALUES ('37', 'R000000010', 'R', '2022-07-19', '3AW', 'DFDF', '', 'GB80', '5.00', 'C', '72', 'A', '0.00', '1176.00', '5880.00', null, '0', null, '2022-07-19 06:23:15');
INSERT INTO `salesd` VALUES ('38', 'R000000010', 'R', '2022-07-19', '3AW', 'DFDF', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '6.00', '6.00', null, '0', null, '2022-07-19 06:23:15');
INSERT INTO `salesd` VALUES ('39', 'R000000009', 'R', '2022-06-24', 'YLK', '1321', '', 'MSK', '2.00', 'B', '5', 'A', '0.00', '60.00', '120.00', null, '0', null, '2022-07-19 08:36:19');
INSERT INTO `salesd` VALUES ('40', 'R000000009', 'R', '2022-06-24', 'YLK', '1321', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-07-19 08:36:19');
INSERT INTO `salesd` VALUES ('41', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-07-21 07:35:22');
INSERT INTO `salesd` VALUES ('42', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'MMA', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-07-21 07:17:04');
INSERT INTO `salesd` VALUES ('43', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'MKS', '5.00', 'B', '5', 'A', '0.00', '60.00', '300.00', null, '0', null, '2022-07-21 07:35:22');
INSERT INTO `salesd` VALUES ('44', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'WTC52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '1', null, '2022-07-23 01:16:15');
INSERT INTO `salesd` VALUES ('45', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '0', null, '2022-07-23 01:16:15');
INSERT INTO `salesd` VALUES ('46', 'S000000012', 'S', '2022-07-26', 'YLK', 'K', 'I', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-07-26 07:25:26');
INSERT INTO `salesd` VALUES ('47', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'WTC52', '2.00', 'C', '150', 'A', '0.00', '900.00', '1800.00', null, '0', null, '2022-07-27 07:49:08');
INSERT INTO `salesd` VALUES ('48', 'S000000013', 'S', '2022-07-27', 'YLK', 'L', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-07-27 08:22:55');
INSERT INTO `salesd` VALUES ('49', 'S000000013', 'S', '2022-07-27', 'YLK', 'L', '', 'WTC52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-07-27 08:22:55');
INSERT INTO `salesd` VALUES ('50', 'S000000013', 'S', '2022-07-27', 'YLK', 'L', '', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '0', null, '2022-07-27 08:22:55');
INSERT INTO `salesd` VALUES ('51', 'S000000014', 'S', '2022-07-27', 'YLK', 'M', '', 'GB80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-07-27 08:23:21');
INSERT INTO `salesd` VALUES ('52', 'S000000014', 'S', '2022-07-27', 'YLK', 'M', '', 'GP80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-07-27 08:23:21');
INSERT INTO `salesd` VALUES ('53', 'S000000014', 'S', '2022-07-27', 'YLK', 'M', '', 'GW80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-07-27 08:23:21');
INSERT INTO `salesd` VALUES ('54', 'S000000015', 'S', '2022-07-27', 'YLK', 'N', '', 'MSD', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-07-27 08:23:46');
INSERT INTO `salesd` VALUES ('55', 'S000000015', 'S', '2022-07-27', 'YLK', 'N', '', 'MSK', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-07-27 08:23:46');
INSERT INTO `salesd` VALUES ('56', 'S000000015', 'S', '2022-07-27', 'YLK', 'N', '', 'MKS', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-07-27 08:23:46');
INSERT INTO `salesd` VALUES ('57', 'S000000001', 'S', '2022-06-21', 'WHS15', 'A', 'A', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '1', null, '2022-08-02 03:11:09');
INSERT INTO `salesd` VALUES ('58', 'S000000016', 'S', '2022-08-03', 'YLK', 'V', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-08-03 08:34:00');
INSERT INTO `salesd` VALUES ('59', 'S000000016', 'S', '2022-08-03', 'YLK', 'V', '', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '0', null, '2022-08-03 08:34:00');
INSERT INTO `salesd` VALUES ('60', 'S000000016', 'S', '2022-08-03', 'YLK', 'V', '', 'WTC52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-08-03 08:34:00');
INSERT INTO `salesd` VALUES ('61', 'S000000017', 'S', '2022-09-03', 'YLK', 'Q', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-09-03 08:35:34');
INSERT INTO `salesd` VALUES ('62', 'S000000017', 'S', '2022-09-03', 'YLK', 'Q', '', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '0', null, '2022-09-03 08:35:34');
INSERT INTO `salesd` VALUES ('63', 'S000000012', 'S', '2022-07-26', 'YLK', 'K', 'I', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '0', null, '2022-09-03 13:41:56');
INSERT INTO `salesd` VALUES ('64', 'S000000012', 'S', '2022-07-26', 'YLK', 'K', 'I', 'WTC52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-09-03 13:41:56');
INSERT INTO `salesd` VALUES ('65', 'S000000012', 'S', '2022-07-26', 'YLK', 'K', 'I', 'GB80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-09-03 13:41:56');
INSERT INTO `salesd` VALUES ('66', 'S000000012', 'S', '2022-07-26', 'YLK', 'K', 'I', 'GP80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-09-03 13:41:56');
INSERT INTO `salesd` VALUES ('67', 'S000000012', 'S', '2022-07-26', 'YLK', 'K', 'I', 'GBR80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-09-03 13:41:56');
INSERT INTO `salesd` VALUES ('68', 'S000000018', 'S', '2022-09-02', 'YLK', 'R', '', 'W52', '1.00', 'C', '150', 'B', '0.00', '910.00', '910.00', null, '0', null, '2022-09-03 14:02:57');
INSERT INTO `salesd` VALUES ('69', 'S000000018', 'S', '2022-09-02', 'YLK', 'R', '', 'WW52', '1.00', 'C', '150', 'B', '0.00', '920.00', '920.00', null, '0', null, '2022-09-03 14:02:57');
INSERT INTO `salesd` VALUES ('70', 'S000000019', 'S', '2022-09-02', 'YLK', 'S', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-09-03 14:09:11');
INSERT INTO `salesd` VALUES ('71', 'S000000020', 'S', '2022-09-03', 'YLK', 'T', '', 'GB80', '1.00', 'C', '72', 'A', '0.00', '1176.00', '1176.00', null, '0', null, '2022-09-03 14:12:03');
INSERT INTO `salesd` VALUES ('72', 'S000000020', 'S', '2022-09-03', 'YLK', 'T', '', 'GW80', '36.00', 'P', '1', 'A', '0.00', '16.33', '587.88', null, '0', null, '2022-09-03 14:12:03');
INSERT INTO `salesd` VALUES ('73', 'S000000020', 'S', '2022-09-03', 'YLK', 'T', '', 'W52', '36.00', 'P', '1', 'A', '0.00', '6.00', '216.00', null, '0', null, '2022-09-03 14:12:03');
INSERT INTO `salesd` VALUES ('74', 'S000000021', 'S', '2022-09-03', 'YLK', '1', '', 'WTC52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-09-04 00:17:36');
INSERT INTO `salesd` VALUES ('75', 'S000000021', 'S', '2022-09-03', 'YLK', '1', '', 'WW52', '1.00', 'C', '150', 'A', '0.00', '910.00', '910.00', null, '0', null, '2022-09-04 00:17:36');
INSERT INTO `salesd` VALUES ('76', 'S000000021', 'S', '2022-09-03', 'YLK', '1', '', 'MSD', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-09-04 00:17:36');
INSERT INTO `salesd` VALUES ('77', 'S000000021', 'S', '2022-09-03', 'YLK', '1', '', 'MSK', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-09-04 00:17:37');
INSERT INTO `salesd` VALUES ('78', 'S000000022', 'S', '2022-09-03', 'YLK', '2', '2', 'MSK', '1.00', 'C', '40', 'A', '0.00', '480.00', '480.00', null, '0', null, '2022-09-04 00:18:58');
INSERT INTO `salesd` VALUES ('79', 'S000000022', 'S', '2022-09-03', 'YLK', '2', '2', 'MSD', '2.00', 'B', '5', 'A', '0.00', '60.00', '120.00', null, '0', null, '2022-09-04 00:18:58');
INSERT INTO `salesd` VALUES ('80', 'R000000011', 'R', '2022-09-04', 'YLK', '111', '', 'W52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-09-04 00:43:25');
INSERT INTO `salesd` VALUES ('81', 'R000000011', 'R', '2022-09-04', 'YLK', '111', '', 'WW52', '1.00', 'C', '150', 'A', '0.00', '900.00', '900.00', null, '0', null, '2022-09-04 00:43:25');
INSERT INTO `salesd` VALUES ('82', 'B000000001', 'B', '2022-09-04', 'YLK', '11', '', 'GB80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-09-04 00:55:44');
INSERT INTO `salesd` VALUES ('83', 'B000000001', 'B', '2022-09-04', 'YLK', '11', '', 'GBR80', '12.00', 'P', '1', 'A', '0.00', '16.33', '195.96', null, '0', null, '2022-09-04 00:55:44');

-- ----------------------------
-- Table structure for salesd_deleted
-- ----------------------------
DROP TABLE IF EXISTS `salesd_deleted`;
CREATE TABLE `salesd_deleted` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL DEFAULT '',
  `ttype` varchar(1) DEFAULT NULL,
  `idate` date DEFAULT NULL,
  `whscode` varchar(5) DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(15) DEFAULT NULL,
  `itemcode` varchar(20) DEFAULT NULL,
  `qty` decimal(10,2) DEFAULT NULL,
  `unit` varchar(1) DEFAULT NULL,
  `pckg` int(10) DEFAULT NULL,
  `pricetype` varchar(1) DEFAULT NULL,
  `uprice` decimal(15,2) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `rrindex` tinyint(4) DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of salesd_deleted
-- ----------------------------

-- ----------------------------
-- Table structure for salesh
-- ----------------------------
DROP TABLE IF EXISTS `salesh`;
CREATE TABLE `salesh` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL DEFAULT '',
  `ttype` varchar(1) DEFAULT NULL,
  `tdate` date DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `slmncode` varchar(5) DEFAULT NULL,
  `whscode` varchar(5) DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(15) DEFAULT NULL,
  `grosstot` decimal(15,2) DEFAULT NULL,
  `disc1percent` decimal(15,2) DEFAULT NULL,
  `disc1amount` decimal(15,2) DEFAULT NULL,
  `disc2percent` decimal(15,2) DEFAULT NULL,
  `disc2amount` decimal(15,2) DEFAULT NULL,
  `disc1net` decimal(15,2) DEFAULT NULL,
  `disc2net` decimal(15,2) DEFAULT NULL,
  `totalamt` decimal(15,2) DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT '0.00',
  `updated` varchar(10) DEFAULT NULL,
  `lprint` varchar(10) DEFAULT NULL,
  `paidcash` decimal(15,2) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL,
  `terms` varchar(10) DEFAULT NULL,
  `status` varchar(1) DEFAULT NULL COMMENT 'P = Partial, F = Full',
  `pdate` date DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `isopen` varchar(1) DEFAULT NULL,
  `isopenby` varchar(1) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of salesh
-- ----------------------------
INSERT INTO `salesh` VALUES ('1', 'S000000001', 'S', '2022-06-21', '20220066', 'D', 'WHS15', 'A', 'A', '6742.00', '0.00', '0.00', '0.00', '0.00', '6742.00', '6742.00', '6742.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', '1', '1', '2022-08-02 03:11:09');
INSERT INTO `salesh` VALUES ('2', 'S000000002', 'S', '2022-06-21', '20220046', 'O', 'YLK', 'B', 'B', '1297.17', '0.00', '0.00', '0.00', '0.00', '1297.17', '1297.17', '1297.17', '0.00', null, null, null, '1', 'THE QUICK BROWN FOX JUMP OVER THE LAZY DOG', 'CREDIT', null, null, '0', '1', '1', '2022-08-02 02:53:11');
INSERT INTO `salesh` VALUES ('3', 'S000000003', 'S', '2022-06-21', '20210026', 'O', 'YLK', 'C', 'C', '587.88', '0.00', '0.00', '0.00', '0.00', '587.88', '587.88', '587.88', '587.88', null, null, null, '1', '', 'CREDIT', null, '2022-09-03', '0', null, null, '2022-09-03 14:20:29');
INSERT INTO `salesh` VALUES ('4', 'S000000004', 'S', '2022-06-21', '20210068', 'O', 'YLK', 'D', 'D', '905.25', '0.00', '0.00', '0.00', '0.00', '905.25', '905.25', '905.25', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-06-21 08:20:18');
INSERT INTO `salesh` VALUES ('5', 'S000000005', 'S', '2022-06-22', '20210068', 'O', 'YLK', 'E', 'E', '216.84', '0.00', '0.00', '0.00', '0.00', '216.84', '216.84', '216.84', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-06-22 02:01:28');
INSERT INTO `salesh` VALUES ('6', 'S000000006', 'S', '2022-06-22', '20220102', 'O', 'YLK', 'F', 'F', '1177.92', '0.00', '0.00', '0.00', '0.00', '1177.92', '1177.92', '1177.92', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-06-22 02:02:48');
INSERT INTO `salesh` VALUES ('7', 'S000000007', 'S', '2022-06-22', '20220101', 'O', 'YLK', 'G', 'G', '910.00', '0.00', '0.00', '0.00', '0.00', '910.00', '910.00', '910.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '1', null, null, '2022-06-22 02:05:01');
INSERT INTO `salesh` VALUES ('8', 'S000000008', 'S', '2022-06-22', '20220101', 'O', 'YLK', 'H', 'H', '87402.00', '0.00', '0.00', '0.00', '0.00', '87402.00', '87402.00', '87402.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-06-24 08:36:10');
INSERT INTO `salesh` VALUES ('9', 'R000000009', 'R', '2022-06-24', '20220066', 'O', 'YLK', '1321', '', '9447.96', '0.00', '0.00', '0.00', '0.00', '9447.96', '9447.96', '9447.96', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-07-19 08:36:19');
INSERT INTO `salesh` VALUES ('10', 'S000000010', 'S', '2022-06-28', '20210068', 'A', '3AW', 'J', '', '981.65', '0.00', '0.00', '0.00', '0.00', '981.65', '981.65', '981.65', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-07-19 06:19:56');
INSERT INTO `salesh` VALUES ('11', 'S000000011', 'S', '2022-07-19', '20220066', 'A', '3AW', 'I', '', '4824.00', '0.00', '0.00', '0.00', '0.00', '4824.00', '4824.00', '4824.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '1', null, null, '2022-07-19 06:08:53');
INSERT INTO `salesh` VALUES ('12', 'R000000010', 'R', '2022-07-19', '20210068', 'A', '3AW', 'DFDF', '', '5886.00', '0.00', '0.00', '0.00', '0.00', '5886.00', '5886.00', '5886.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-07-19 06:23:15');
INSERT INTO `salesh` VALUES ('13', 'S000000012', 'S', '2022-07-26', '20220066', 'O', 'YLK', 'K', 'I', '6238.00', '0.00', '0.00', '0.00', '0.00', '6238.00', '6238.00', '6238.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', '1', '1', '2022-09-03 13:41:56');
INSERT INTO `salesh` VALUES ('14', 'S000000013', 'S', '2022-07-27', '20220101', 'TC', 'YLK', 'L', '', '2710.00', '0.00', '0.00', '0.00', '0.00', '2710.00', '2710.00', '2710.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-07-27 08:22:55');
INSERT INTO `salesh` VALUES ('15', 'S000000014', 'S', '2022-07-27', '20220101', 'RA', 'YLK', 'M', '', '3528.00', '0.00', '0.00', '0.00', '0.00', '3528.00', '3528.00', '3528.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', '1', '1', '2022-09-03 14:16:55');
INSERT INTO `salesh` VALUES ('16', 'S000000015', 'S', '2022-07-27', '20220101', 'AY', 'YLK', 'N', '', '1440.00', '0.00', '0.00', '0.00', '0.00', '1440.00', '1440.00', '1440.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', '1', '1', '2022-08-02 02:51:44');
INSERT INTO `salesh` VALUES ('17', 'S000000016', 'S', '2022-08-03', '20220066', 'O', 'YLK', 'V', '', '2710.00', '0.00', '0.00', '0.00', '0.00', '2710.00', '2710.00', '2710.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-08-03 08:34:00');
INSERT INTO `salesh` VALUES ('18', 'S000000017', 'S', '2022-09-03', '20220101', 'TC', 'YLK', 'Q', '', '1810.00', '0.00', '0.00', '0.00', '0.00', '1810.00', '1810.00', '1810.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', '1', '1', '2022-09-03 08:38:24');
INSERT INTO `salesh` VALUES ('19', 'S000000018', 'S', '2022-09-02', '20220102', 'O', 'YLK', 'R', '', '1830.00', '0.00', '0.00', '0.00', '0.00', '1830.00', '1830.00', '1830.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-09-03 14:02:57');
INSERT INTO `salesh` VALUES ('20', 'S000000019', 'S', '2022-09-02', '20210068', 'O', 'YLK', 'S', '', '900.00', '0.00', '0.00', '0.00', '0.00', '900.00', '900.00', '900.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-09-03 14:09:11');
INSERT INTO `salesh` VALUES ('21', 'S000000020', 'S', '2022-09-03', '20220066', 'O', 'YLK', 'T', '', '1979.88', '0.00', '0.00', '0.00', '0.00', '1979.88', '1979.88', '1979.88', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-09-03 14:12:03');
INSERT INTO `salesh` VALUES ('22', 'S000000021', 'S', '2022-09-03', '20220101', 'TC', 'YLK', '1', '', '2770.00', '2.00', '55.40', '2.00', '54.29', '2714.60', '2687.45', '2660.31', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-09-04 00:17:36');
INSERT INTO `salesh` VALUES ('23', 'S000000022', 'S', '2022-09-03', '20220101', 'TC', 'YLK', '2', '2', '600.00', '0.00', '0.00', '0.00', '0.00', '600.00', '600.00', '600.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-09-04 00:18:58');
INSERT INTO `salesh` VALUES ('24', 'R000000011', 'R', '2022-09-04', '20220066', 'O', 'YLK', '111', '', '1800.00', '0.00', '0.00', '0.00', '0.00', '1800.00', '1800.00', '1800.00', '0.00', null, null, null, '1', '', 'CREDIT', null, null, '0', null, null, '2022-09-04 00:43:25');
INSERT INTO `salesh` VALUES ('25', 'B000000001', 'B', '2022-09-04', '20220066', 'O', 'YLK', '11', '', '391.92', '0.00', '0.00', '0.00', '0.00', '391.92', '391.92', '391.92', '0.00', null, null, null, '1', '', '', null, null, '0', null, null, '2022-09-04 00:55:44');

-- ----------------------------
-- Table structure for salesh_deleted
-- ----------------------------
DROP TABLE IF EXISTS `salesh_deleted`;
CREATE TABLE `salesh_deleted` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL DEFAULT '',
  `ttype` varchar(1) DEFAULT NULL,
  `idate` date DEFAULT NULL,
  `custcode` varchar(10) DEFAULT NULL,
  `slmncode` varchar(5) DEFAULT NULL,
  `whscode` varchar(5) DEFAULT NULL,
  `invoiceno` varchar(15) DEFAULT NULL,
  `pono` varchar(15) DEFAULT NULL,
  `grosstot` decimal(15,2) DEFAULT NULL,
  `disc1percent` decimal(15,2) DEFAULT NULL,
  `disc1amount` decimal(15,2) DEFAULT NULL,
  `disc2percent` decimal(15,2) DEFAULT NULL,
  `disc2amount` decimal(15,2) DEFAULT NULL,
  `disc1net` decimal(15,2) DEFAULT NULL,
  `disc2net` decimal(15,2) DEFAULT NULL,
  `totalamt` decimal(15,2) DEFAULT NULL,
  `applied` decimal(15,2) DEFAULT '0.00',
  `updated` varchar(10) DEFAULT NULL,
  `lprint` varchar(10) DEFAULT NULL,
  `paidcash` decimal(15,2) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL,
  `terms` varchar(10) DEFAULT NULL,
  `status` varchar(1) DEFAULT NULL COMMENT 'P = Partial, F = Full',
  `pdate` date DEFAULT NULL,
  `isdeleted` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of salesh_deleted
-- ----------------------------

-- ----------------------------
-- Table structure for salesman
-- ----------------------------
DROP TABLE IF EXISTS `salesman`;
CREATE TABLE `salesman` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `slmncode` varchar(10) CHARACTER SET utf8 NOT NULL,
  `slmnname` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `bort` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `whscode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `whsname` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `opercode` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `typeofoper` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `pricetype` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`slmncode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of salesman
-- ----------------------------
INSERT INTO `salesman` VALUES ('1', 'A', 'ANTHONY M. FULLO III', 'B', '3AW', '3A MAIN WAREHOUSE', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-03-18 11:32:37');
INSERT INTO `salesman` VALUES ('2', 'O', 'OPAW', 'B', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-03-18 11:32:38');
INSERT INTO `salesman` VALUES ('3', 'B', 'SALESMAN B', 'B', 'WHS1', 'WAREHOUSE 1', 'BK1', 'BOOKING SALESMAN 1', 'A', '2022-06-17 08:20:54');
INSERT INTO `salesman` VALUES ('4', 'C', 'SALESMAN WHS 5', 'B', 'WHS5', 'WAREHOUSE 5', 'BK1', 'BOOKING SALESMAN 1', null, '2022-06-20 06:04:44');
INSERT INTO `salesman` VALUES ('5', 'E', 'SALESMAN WHS9', 'B', 'WHS9', 'WAREHOUSE 9', 'BK1', 'BOOKING SALESMAN 1', null, '2022-07-18 07:13:50');
INSERT INTO `salesman` VALUES ('6', 'D', 'SALESMAN WHS 15', 'B', 'WHS15', 'WAREHOUSE 15', 'BK1', 'BOOKING SALESMAN 1', null, '2022-07-19 07:00:15');
INSERT INTO `salesman` VALUES ('7', 'RA', 'RICHEL ALCONTIN', 'B', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', null, '2022-07-27 08:20:09');
INSERT INTO `salesman` VALUES ('8', 'AY', 'ALBERTO YOLDAN JR', 'B', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', null, '2022-07-27 08:20:25');
INSERT INTO `salesman` VALUES ('9', 'TC', 'TOPING MAGHANOY', 'B', 'YLK', 'YU LINKON JR. GEN. MDSE.', 'BK1', 'BOOKING SALESMAN 1', null, '2022-07-27 08:20:48');

-- ----------------------------
-- Table structure for supcmdm
-- ----------------------------
DROP TABLE IF EXISTS `supcmdm`;
CREATE TABLE `supcmdm` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(11) NOT NULL,
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `docno` varchar(12) DEFAULT NULL,
  `supcode` varchar(10) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `balance` decimal(15,2) DEFAULT NULL,
  `remarks1` varchar(100) DEFAULT NULL,
  `remarks2` varchar(100) DEFAULT NULL,
  `remarks3` varchar(100) DEFAULT NULL,
  `remarks4` varchar(100) DEFAULT NULL,
  `user` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `isdeleted` tinyint(4) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of supcmdm
-- ----------------------------
INSERT INTO `supcmdm` VALUES ('1', 'D000000001', 'D', '2020-12-29', 'DM1', 'GSPI', '3000.00', '3000.00', 'TEST1', 'TEST2', 'TEST3', 'TEST4', '1', '0', '2020-12-29 07:15:34');
INSERT INTO `supcmdm` VALUES ('2', 'D000000002', 'D', '2020-12-29', 'DM2', 'GSPI', '5000.00', '5000.00', 'ASDF', 'ASDF', 'ASDF', 'ASDF', '1', '0', '2020-12-29 07:16:27');
INSERT INTO `supcmdm` VALUES ('3', 'C000000003', 'C', '2020-12-29', 'CM1', 'DM', '3123.00', '3123.00', 'ASDF', 'ASDF', 'ASDF', 'ASDF', '1', '0', '2020-12-29 08:25:57');
INSERT INTO `supcmdm` VALUES ('4', 'C000000004', 'C', '2020-12-29', 'CM2', 'GSPI', '3213.00', '3213.00', 'SDF', 'SDF', 'SDF', 'SDF', '1', '0', '2020-12-29 08:25:04');
INSERT INTO `supcmdm` VALUES ('5', 'C000000005', 'C', '2020-12-29', 'CM3', 'GSPI', '877.00', '877.00', '1', '2', '3', '4', '1', '0', '2020-12-29 08:25:32');
INSERT INTO `supcmdm` VALUES ('6', 'C000000006', 'C', '2021-01-23', 'CM4', 'GSPI', '500.00', '500.00', 'ASDF', 'ASDF', 'ASDF', 'ASDF', '1', '0', '2021-01-23 01:47:02');
INSERT INTO `supcmdm` VALUES ('7', 'D000000007', 'D', '2021-01-23', 'DM3', 'GSPI', '500.00', '500.00', 'SDFF', 'ADSF', 'DFA', 'ASDF', '1', '0', '2021-01-23 01:47:34');
INSERT INTO `supcmdm` VALUES ('8', 'C000000008', 'C', '2021-04-07', 'CM5', 'DM', '300.00', '300.00', 'ADF', 'ASDF', 'ASDF', 'ASDF', '1', '0', '2021-04-07 07:09:49');
INSERT INTO `supcmdm` VALUES ('9', 'C000000009', 'C', '2021-04-07', 'CM6', 'GSPI', '600.00', '600.00', 'BVZXCVZX', 'ZXCVZXCV', 'XCVZXCV', 'ZXCVXZCV', '1', '0', '2021-04-07 07:10:15');
INSERT INTO `supcmdm` VALUES ('10', 'C000000010', 'C', '2021-04-07', 'CM7', 'GSPI', '800.00', '800.00', 'ZXCV', 'ZXCV', 'ZXCV', 'ZXCV', '1', '0', '2021-04-07 07:10:30');
INSERT INTO `supcmdm` VALUES ('11', 'C000000011', 'C', '2021-04-07', 'CM8', 'GSPI', '1233.00', '1233.00', 'GHGFHGH', 'GHGHGH', 'HGHGHGH', 'GHGHGH', '1', '0', '2021-04-07 07:10:49');
INSERT INTO `supcmdm` VALUES ('12', 'C000000012', 'C', '2021-04-07', 'CM9', 'GSPI', '10000.00', '10000.00', 'BVBVBV', 'BVBVBV', 'BVBVBVB', 'VBVBVB', '1', '0', '2021-04-07 07:11:10');
INSERT INTO `supcmdm` VALUES ('13', 'C000000013', 'C', '2021-04-07', 'CM10', 'GSPI', '8000.00', '8000.00', 'BMVBNM', 'VBGNMVBNM', 'VBNMVBN', 'VBNMNBM', '1', '0', '2021-04-07 07:11:25');
INSERT INTO `supcmdm` VALUES ('14', 'C000000014', 'C', '2021-04-07', 'CM11', 'DM', '45613.00', '45613.00', 'CXVZXCV', 'ZXCVZXCV', 'ZXCVZXC', 'ZXCZXCV', '1', '0', '2021-04-07 07:11:41');
INSERT INTO `supcmdm` VALUES ('15', 'C000000015', 'C', '2021-04-07', 'CM12', 'GSPI', '898.00', '898.00', 'VBGGH', 'GHGHGH', 'GHGH', 'GHGHGH', '1', '0', '2021-04-07 07:11:58');
INSERT INTO `supcmdm` VALUES ('16', 'C000000016', 'C', '2021-04-07', 'CM13', 'GSPI', '4849.00', '4849.00', 'ASDFASD', 'ASDFASDF', 'ASDFADSF', 'ASDFSDAF', '1', '0', '2021-04-07 07:12:21');
INSERT INTO `supcmdm` VALUES ('17', 'C000000017', 'C', '2021-09-06', 'CM15', 'GSPI', '1000000.00', '1000000.00', 'TEST', 'TEST', 'TEST', 'TEST', '1', '0', '2021-09-06 12:07:53');

-- ----------------------------
-- Table structure for supplier
-- ----------------------------
DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `supcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `suppliername` varchar(50) CHARACTER SET utf8 NOT NULL,
  `address` varchar(150) CHARACTER SET utf8 DEFAULT NULL,
  `status` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`supcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of supplier
-- ----------------------------
INSERT INTO `supplier` VALUES ('2', 'GMC', 'GENERAL MILLING CORP', null, '0', '2021-09-26 08:55:03');
INSERT INTO `supplier` VALUES ('15', 'C/M', 'CARGILL/METROVET', null, '0', '2022-01-02 06:25:00');
INSERT INTO `supplier` VALUES ('4', 'MD', 'MEDLAND', null, '0', '2021-09-26 08:57:59');
INSERT INTO `supplier` VALUES ('7', 'B+', 'BOUNTY PLUS', null, '0', '2021-09-26 09:33:14');
INSERT INTO `supplier` VALUES ('6', 'BL', 'BELMAN LABORATORIES', null, '0', '2021-09-26 09:01:27');
INSERT INTO `supplier` VALUES ('8', 'IFMC', 'INOZA FEED MILLING CORP', null, '0', '2021-09-26 09:34:07');
INSERT INTO `supplier` VALUES ('9', 'CJP', 'CJ PHILIPPINES', null, '0', '2021-09-26 09:36:21');
INSERT INTO `supplier` VALUES ('10', 'LDI', 'LAKPUE DRUGS INC', null, '0', '2021-09-27 01:27:49');
INSERT INTO `supplier` VALUES ('12', 'VN', 'VIENOVO', null, '0', '2021-10-25 12:59:03');
INSERT INTO `supplier` VALUES ('13', '11', 'GENERAL', null, '0', '2021-10-27 01:31:12');
INSERT INTO `supplier` VALUES ('16', 'E', 'EXCEL', null, '0', '2022-01-02 09:08:22');
INSERT INTO `supplier` VALUES ('17', 'GSPI', 'GENTLE SUPPREME PHILS.', 'MANILA ', '0', '2022-03-02 08:03:14');
INSERT INTO `supplier` VALUES ('18', 'DM', 'DAIRY MILK PRODUCTS', 'CEBU CITY', '0', '2022-07-27 02:41:51');
INSERT INTO `supplier` VALUES ('19', 'LMC', 'LIMKETKAI MANUFACTURING', 'CAGAYAN DE ORO', '0', '2022-07-27 02:16:42');
INSERT INTO `supplier` VALUES ('20', 'MON', 'MONTOSCO', 'MANILA', '0', '2022-07-27 02:11:46');
INSERT INTO `supplier` VALUES ('21', 'SL', 'SEANLUC INC', 'MANILA', '0', '2022-07-27 02:12:31');
INSERT INTO `supplier` VALUES ('22', 'RG', 'REGENT CORP.', 'MANILA', '0', '2022-07-27 02:12:44');

-- ----------------------------
-- Table structure for supplier_copy
-- ----------------------------
DROP TABLE IF EXISTS `supplier_copy`;
CREATE TABLE `supplier_copy` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `supcode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `suppliername` varchar(50) CHARACTER SET utf8 NOT NULL,
  `address` varchar(150) CHARACTER SET utf8 DEFAULT NULL,
  `status` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`supcode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of supplier_copy
-- ----------------------------
INSERT INTO `supplier_copy` VALUES ('2', 'GMC', 'GENERAL MILLING CORP', null, '0', '2021-09-26 08:55:03');
INSERT INTO `supplier_copy` VALUES ('11', 'C', 'CARGILL', null, '0', '2021-09-28 22:32:15');
INSERT INTO `supplier_copy` VALUES ('4', 'MD', 'MEDLAND', null, '0', '2021-09-26 08:57:59');
INSERT INTO `supplier_copy` VALUES ('7', 'B+', 'BOUNTY PLUS', null, '0', '2021-09-26 09:33:14');
INSERT INTO `supplier_copy` VALUES ('6', 'BL', 'BELMAN LABORATORIES', null, '0', '2021-09-26 09:01:27');
INSERT INTO `supplier_copy` VALUES ('8', 'IFMC', 'INOZA FEED MILLING CORP', null, '0', '2021-09-26 09:34:07');
INSERT INTO `supplier_copy` VALUES ('9', 'CJP', 'CJ PHILIPPINES', null, '0', '2021-09-26 09:36:21');
INSERT INTO `supplier_copy` VALUES ('10', 'LDI', 'LAKPUE DRUGS INC', null, '0', '2021-09-27 01:27:49');

-- ----------------------------
-- Table structure for typeoper
-- ----------------------------
DROP TABLE IF EXISTS `typeoper`;
CREATE TABLE `typeoper` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `opercode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `operationname` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` varchar(5) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`opercode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of typeoper
-- ----------------------------
INSERT INTO `typeoper` VALUES ('1', 'BK1', 'BOOKING SALESMAN 1', null, '2020-09-05 02:50:24');
INSERT INTO `typeoper` VALUES ('2', 'BK2', 'BOOKING SALESMAN 2', null, '2020-09-05 02:50:34');
INSERT INTO `typeoper` VALUES ('3', 'BK3', 'BOOKING SALESMAN 3', null, '2020-09-05 02:50:46');
INSERT INTO `typeoper` VALUES ('4', 'VN1', 'VAN SALESMAN 1', null, '2020-09-05 02:50:56');
INSERT INTO `typeoper` VALUES ('5', 'VN2', 'VAN SALESMAN 2', null, '2020-09-05 02:51:03');
INSERT INTO `typeoper` VALUES ('6', 'VN3', 'VAN SALESMAN 3', null, '2021-04-09 01:32:38');
INSERT INTO `typeoper` VALUES ('8', 'VN4', 'VAN SALESMAN 4', null, '2021-04-09 01:04:02');
INSERT INTO `typeoper` VALUES ('9', 'VN5', 'VAN SALESMAN 5', null, '2021-04-09 01:11:57');
INSERT INTO `typeoper` VALUES ('10', 'VN6', 'VAN SALESMAN 6', null, '2021-04-09 01:12:07');
INSERT INTO `typeoper` VALUES ('11', 'VN7', 'VAN SALESMAN 7', null, '2021-04-09 01:12:17');

-- ----------------------------
-- Table structure for useraccnt
-- ----------------------------
DROP TABLE IF EXISTS `useraccnt`;
CREATE TABLE `useraccnt` (
  `ID` int(20) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) CHARACTER SET utf8 NOT NULL,
  `Password` varchar(20) CHARACTER SET utf8 NOT NULL,
  `Fullname` varchar(180) CHARACTER SET utf8 DEFAULT NULL,
  `Role` varchar(180) CHARACTER SET utf8 DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of useraccnt
-- ----------------------------
INSERT INTO `useraccnt` VALUES ('1', 'admin', '1', 'Christopher De Leon', 'Administrator', '2020-11-14 22:31:14');
INSERT INTO `useraccnt` VALUES ('2', '1', '1', 'Christopher De Tiger', 'Administrator', '2020-11-14 22:31:10');
INSERT INTO `useraccnt` VALUES ('3', 'toping', '1', 'Toping Coy', 'Administrator', '2020-11-14 22:31:20');
INSERT INTO `useraccnt` VALUES ('9', 'USER 1', '+CE6RwyQd6+gJ/3FKkZa', 'USER 1', 'Guest', '2020-11-15 06:08:42');
INSERT INTO `useraccnt` VALUES ('10', 'GUEST', '+CE6RwyQd6+gJ/3FKkZa', 'GUEST', 'Guest', '2020-11-15 06:11:13');
INSERT INTO `useraccnt` VALUES ('11', '2', 'dc5XPbJDSDmDL1wOjpq5', 'TWO', 'Administrator', '2020-11-20 19:13:28');
INSERT INTO `useraccnt` VALUES ('12', 'drug user', 'iPOihqyvdOGsXe8CNhkW', 'ADDICT ', 'Guest', '2021-02-02 08:35:21');
INSERT INTO `useraccnt` VALUES ('13', 'ben', '0Z8t2uRfLblT2aw6mdeK', 'BEN TONG', 'Administrator', '2021-06-16 00:39:36');
INSERT INTO `useraccnt` VALUES ('14', 'ylk', 'T7XgHXGmfO5gGwyPR0Br', 'YU LINKON JR', 'Administrator', '2021-06-16 08:23:07');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `pkno` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL DEFAULT '',
  `password` varchar(50) DEFAULT NULL,
  `fullname` varchar(200) DEFAULT NULL,
  `usertype` varchar(50) DEFAULT NULL,
  `dtmp` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`username`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', 'admin', '+CE6RwyQd6+gJ/3FKkZabg==', 'Administrator', 'Administrator', '2020-11-06 20:48:03');
INSERT INTO `users` VALUES ('2', 'toping', 'OFkwf5qefCaUm6nHfewEBw==', 'CHRISTOPHER D. MAGHANOY', 'Administrator', '2022-03-04 07:45:11');
INSERT INTO `users` VALUES ('3', 'nurse1', '+CE6RwyQd6+gJ/3FKkZabg==', 'NURSE 1', 'Staff Nurse', '2020-11-06 20:48:07');
INSERT INTO `users` VALUES ('4', 'Guest', 'HIhBbJBaWYk+4e1Zqkhn3A==', 'GUEST USER', 'Administrator', null);
INSERT INTO `users` VALUES ('5', '1', 'iPOihqyvdOGsXe8CNhkW3A==', 'ONE', 'Administrator', null);
INSERT INTO `users` VALUES ('6', 'Anthony III', 'k6P1XISmx1hTsbuwH+qROw==', 'ANTHONY M. FULLO III', 'Administrator', null);

-- ----------------------------
-- Table structure for voucher
-- ----------------------------
DROP TABLE IF EXISTS `voucher`;
CREATE TABLE `voucher` (
  `pkno` int(15) NOT NULL AUTO_INCREMENT COMMENT ' ',
  `transno` varchar(15) NOT NULL,
  `ttype` varchar(1) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `totbalance` decimal(15,2) DEFAULT NULL,
  `totamount` decimal(15,2) DEFAULT NULL,
  `totcod` decimal(15,2) DEFAULT NULL,
  `printed` tinyint(4) DEFAULT NULL,
  `updated` tinyint(4) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `isdeleted` int(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`transno`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of voucher
-- ----------------------------

-- ----------------------------
-- Table structure for warehouse
-- ----------------------------
DROP TABLE IF EXISTS `warehouse`;
CREATE TABLE `warehouse` (
  `pkno` int(10) NOT NULL AUTO_INCREMENT,
  `whscode` varchar(5) CHARACTER SET utf8 NOT NULL,
  `warehouse` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `status` tinyint(1) DEFAULT '0',
  `dtmp` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`pkno`,`whscode`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=58 DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of warehouse
-- ----------------------------
INSERT INTO `warehouse` VALUES ('1', '3AW', '3A MAIN WAREHOUSE', '0', '2021-09-26 08:37:16');
INSERT INTO `warehouse` VALUES ('34', 'YLK', 'YU LINKON JR. GEN. MDSE.', '0', '2022-03-12 14:38:53');
INSERT INTO `warehouse` VALUES ('35', 'WHS1', 'WAREHOUSE 1', '0', '2022-03-12 14:42:01');
INSERT INTO `warehouse` VALUES ('36', 'WHS2', 'WAREHOUSE 2', '0', '2022-03-12 14:42:06');
INSERT INTO `warehouse` VALUES ('37', 'WHS3', 'WAREHOUSE 3', '0', '2022-06-13 07:17:30');
INSERT INTO `warehouse` VALUES ('38', 'WHS4', 'WAREHOUSE 4', '0', '2022-06-13 07:45:35');
INSERT INTO `warehouse` VALUES ('39', 'WHS5', 'WAREHOUSE 5', '0', '2022-06-20 01:40:34');
INSERT INTO `warehouse` VALUES ('40', 'WHS6', 'WAREHOUSE 6', '0', '2022-06-20 06:20:04');
INSERT INTO `warehouse` VALUES ('41', 'WHS7', 'WAREHOUSE 7', '0', '2022-07-15 08:16:31');
INSERT INTO `warehouse` VALUES ('42', 'WHS8', 'WAREHOUSE 8', '0', '2022-07-18 05:52:54');
INSERT INTO `warehouse` VALUES ('43', 'WHS9', 'WAREHOUSE 9', '0', '2022-07-18 05:53:00');
INSERT INTO `warehouse` VALUES ('44', 'WH10', 'WAREHOUSE 10', '0', '2022-07-18 05:53:08');
INSERT INTO `warehouse` VALUES ('45', 'WHS11', 'WAREHOUSE 11', '0', '2022-07-18 08:08:13');
INSERT INTO `warehouse` VALUES ('46', 'WHS12', 'WAREHOUSE 12', '0', '2022-07-18 08:11:07');
INSERT INTO `warehouse` VALUES ('47', 'WHS13', 'WAREHOUSE 13', '0', '2022-07-18 08:22:40');
INSERT INTO `warehouse` VALUES ('48', 'WHS14', 'WAREHOUSE 14', '0', '2022-07-18 08:24:50');
INSERT INTO `warehouse` VALUES ('49', 'WHS15', 'WAREHOUSE 15', '0', '2022-07-19 06:59:32');
INSERT INTO `warehouse` VALUES ('50', 'WHS16', 'WAREHOUSE 16', '0', '2022-07-20 00:39:53');
INSERT INTO `warehouse` VALUES ('51', 'WHS17', 'WAREHOUSE 17', '0', '2022-07-20 01:35:54');
INSERT INTO `warehouse` VALUES ('52', 'WHS18', 'WAREHOUSE 18', '0', '2022-07-20 07:48:41');
INSERT INTO `warehouse` VALUES ('53', 'WHS19', 'WAREHOUSE 19', '0', '2022-07-20 08:50:15');
INSERT INTO `warehouse` VALUES ('54', 'WHS20', 'WAREHOUSE 20', '0', '2022-07-20 08:50:20');
INSERT INTO `warehouse` VALUES ('55', 'WHS21', 'WAREHOUSE 21', '0', '2022-07-21 05:55:34');
INSERT INTO `warehouse` VALUES ('56', 'WHS22', 'WAREHOUSE 22', '0', '2022-07-21 05:55:41');
INSERT INTO `warehouse` VALUES ('57', 'WHS23', 'WAREHOUSE 23', '0', '2022-07-22 08:50:02');
