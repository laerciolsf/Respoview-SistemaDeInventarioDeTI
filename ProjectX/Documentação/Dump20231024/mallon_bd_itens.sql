-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: mallon_bd
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `itens`
--

DROP TABLE IF EXISTS `itens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `itens` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuarioResponsavel` varchar(45) DEFAULT NULL,
  `nomeEquipamento` varchar(45) NOT NULL,
  `quantidade` varchar(45) DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `fabricante` varchar(45) DEFAULT NULL,
  `modelo` varchar(45) DEFAULT NULL,
  `processador` varchar(45) DEFAULT NULL,
  `memoria` varchar(45) DEFAULT NULL,
  `hd_ssd` varchar(45) DEFAULT NULL,
  `sistemaOperacional` varchar(45) DEFAULT NULL,
  `valorEstimado` double NOT NULL,
  `idLoja` int NOT NULL,
  `idDepartamento` int NOT NULL,
  `idBitLocker` varchar(128) DEFAULT NULL,
  `chaveBitLocker` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idLoja_idx` (`idLoja`),
  KEY `idDepartamento_idx` (`idDepartamento`),
  CONSTRAINT `idDepartamento` FOREIGN KEY (`idDepartamento`) REFERENCES `departamentos` (`idDepartamento`),
  CONSTRAINT `idLoja` FOREIGN KEY (`idLoja`) REFERENCES `lojas` (`idLoja`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itens`
--

LOCK TABLES `itens` WRITE;
/*!40000 ALTER TABLE `itens` DISABLE KEYS */;
INSERT INTO `itens` VALUES (21,'Henry Abakat','VWCNI-TI','1','Notebook','Dell','Ispiron','I5 ','8GB DDR3','1TB HDD / 480GB SSD','Windows 10 Pro',10000,1,3,NULL,NULL),(22,'Laércio Soares Fragoso','TOYCNI-TI','1','Notebook','Dell','Vostro','I7 8565U','8GB DDR4','1TB HDD / 120 SSD','Windows 10 Pro',3000,3,3,'446127-670747-219296-399410-232782-496848-262163-373032','446127-670747-219296-399410-232782-496848-262163-373032'),(23,'Maria','TOYCNI-TABLET','1','Tablet','Sony','12435JDC','','8GB','64GB','Android 11',3000,3,2,NULL,NULL),(24,'Maicon','TOYCNI-PECAS','1','Descktop','ASUS','X552E','Intel I9','32GB','1TB','Windows 11',12000,3,10,NULL,NULL),(25,'Luiz','Computador 05','1','Notebook','Dell','x552e','Intel I9','32GB','1TB','Windows 10',9000,2,2,NULL,NULL),(26,'Mateus','BabySung','1','Notebook','Sansung','Sansungbook','I3 1115g4','4GB','240SSD','Windows 11 ',3000,14,11,NULL,NULL),(27,'Maikinho','TOYCNI-MAL','1','Notebook','Positivo','X552E','I9 169999','64GB DDR8','7TB SSD','Windows 12',74000,3,2,NULL,NULL),(28,'Rava','TOYCNI-GARANTIA','1','Notebook','Dell','VOSTRO 78944','I9 9967K','8GB DDR4','1TB HDD 1TBSSD\'','Windows 12 pro',8000,3,2,'446127-670747-219296-399410-232782-496848-262163-373032','446127-670747-219296-399410-232782-496848-262163-373032');
/*!40000 ALTER TABLE `itens` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-17 11:33:03
