CREATE DATABASE  IF NOT EXISTS `mallon_bd` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mallon_bd`;
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
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `idDepartamento` int NOT NULL AUTO_INCREMENT,
  `departamento` varchar(45) NOT NULL,
  PRIMARY KEY (`idDepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'Vendas'),(2,'Oficina'),(3,'TI'),(9,'Pós Vendas'),(10,'Peças'),(11,'Mkt');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itens`
--

LOCK TABLES `itens` WRITE;
/*!40000 ALTER TABLE `itens` DISABLE KEYS */;
INSERT INTO `itens` VALUES (21,'Henry Abakati','VWCNI-TI','1','Notebook','Dell','Ispiron','I5 ','8GB DDR3','1TB HDD / 480GB SSD','Windows 10 Pro',10000,1,3,'',''),(22,'Laércio Soares Fragoso','TOYCNI-TI','1','Notebook','Dell','Vostro','I7 8565U','8GB DDR4','1TB HDD / 120 SSD','Windows 10 Pro',3000,3,3,'446127-670747-219296-399410-232782-496848-262163-373032','446127-670747-219296-399410-232782-496848-262163-373032'),(23,'Maria','TOYCNI-TABLET','1','Tablet','Sony','12435JDC','','8GB','64GB','Android 11',3000,3,2,NULL,NULL),(24,'Maicon Solza','TOYCNI-PECAS','1','Descktop','ASUS','X552E','Intel I9','32GB','1TB','Windows 11',12000,3,10,'',''),(26,'Mateus','BabySung','1','Notebook','Sansung','Sansungbook','I3 1115g4','4GB','240SSD','Windows 11 ',3000,14,11,NULL,NULL),(28,'Rafa','TOYCNI-GARANTIA','1','Notebook','Dell','VOSTRO 78944','I9 9967K','8GB DDR4','1TB HDD 1TBSSD\'','Windows 12 pro',8000,3,2,'446127-670747-219296-399410-232782-496848-262163-373032','446127-670747-219296-399410-232782-496848-262163-373032'),(29,'Leandro','TOYCNI-RH','10','Notebook','Dell','ABC123','I9 1000K','8 GB DDR7','120SSD 2TB HDDD','Windows 15',15000,3,9,'DEU-CERTO','DEU-CERTO'),(30,'Lucas Santos','TOYCNI-OFCINA3','1','Notebook','Dell','X552E','I7 3770','16GB','480SSD','WINDOWS XP',19000,3,2,'SUA CHAVE TESTE DEU BOA','TESTE'),(32,'Eduardo','TOYCNI-OFICINA10','1','Notebook','Positivo','X66y','I7 3770','8GB DDR4','240SSD 1TB','Windows 10',2500,3,2,'teste','kkkkkkkkk');
/*!40000 ALTER TABLE `itens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_alteracoes`
--

DROP TABLE IF EXISTS `log_alteracoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_alteracoes` (
  `idLog` int NOT NULL AUTO_INCREMENT,
  `idItem` int NOT NULL,
  `usuarioResponsavel_antes` varchar(45) DEFAULT NULL,
  `nomeEquipamento_antes` varchar(45) NOT NULL,
  `quantidade_antes` varchar(45) DEFAULT NULL,
  `tipo_antes` varchar(45) DEFAULT NULL,
  `fabricante_antes` varchar(45) DEFAULT NULL,
  `modelo_antes` varchar(45) DEFAULT NULL,
  `processador_antes` varchar(45) DEFAULT NULL,
  `memoria_antes` varchar(45) DEFAULT NULL,
  `hd_ssd_antes` varchar(45) DEFAULT NULL,
  `sistemaOperacional_antes` varchar(45) DEFAULT NULL,
  `valorEstimado_antes` double NOT NULL,
  `idLoja_antes` int NOT NULL,
  `idDepartamento_antes` int NOT NULL,
  `idBitLocker_antes` varchar(128) DEFAULT NULL,
  `chaveBitLocker_antes` varchar(128) DEFAULT NULL,
  `usuarioResponsavel_depois` varchar(45) DEFAULT NULL,
  `nomeEquipamento_depois` varchar(45) NOT NULL,
  `quantidade_depois` varchar(45) DEFAULT NULL,
  `tipo_depois` varchar(45) DEFAULT NULL,
  `fabricante_depois` varchar(45) DEFAULT NULL,
  `modelo_depois` varchar(45) DEFAULT NULL,
  `processador_depois` varchar(45) DEFAULT NULL,
  `memoria_depois` varchar(45) DEFAULT NULL,
  `hd_ssd_depois` varchar(45) DEFAULT NULL,
  `sistemaOperacional_depois` varchar(45) DEFAULT NULL,
  `valorEstimado_depois` double NOT NULL,
  `idLoja_depois` int NOT NULL,
  `idDepartamento_depois` int NOT NULL,
  `idBitLocker_depois` varchar(128) DEFAULT NULL,
  `chaveBitLocker_depois` varchar(128) DEFAULT NULL,
  `dataHoraAlteracao` datetime NOT NULL,
  PRIMARY KEY (`idLog`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_alteracoes`
--

LOCK TABLES `log_alteracoes` WRITE;
/*!40000 ALTER TABLE `log_alteracoes` DISABLE KEYS */;
INSERT INTO `log_alteracoes` VALUES (1,30,'Lucas','TOYCNI-OFCINA3','1','Notebook','Dell','X552E','I7 3770','16GB','480SSD','WINDOWS XP',19000,3,2,'TESTE','SUA CHAVE TESTE DEU BOA','Lucas Santos','TOYCNI-OFCINA3','1','Notebook','Dell','X552E','I7 3770','16GB','480SSD','WINDOWS XP',19000,3,2,'SUA CHAVE TESTE DEU BOA','TESTE','2024-10-05 19:26:15'),(2,21,'Henry Abakat','VWCNI-TI','1','Notebook','Dell','Ispiron','I5 ','8GB DDR3','1TB HDD / 480GB SSD','Windows 10 Pro',10000,1,3,NULL,NULL,'Henry Abakati','VWCNI-TI','1','Notebook','Dell','Ispiron','I5 ','8GB DDR3','1TB HDD / 480GB SSD','Windows 10 Pro',10000,1,3,'','','2024-11-17 22:18:23');
/*!40000 ALTER TABLE `log_alteracoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_exclusoes`
--

DROP TABLE IF EXISTS `log_exclusoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_exclusoes` (
  `idLog` int NOT NULL AUTO_INCREMENT,
  `idItem` int NOT NULL,
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
  `usuarioExclusao` varchar(45) DEFAULT NULL,
  `dataHoraExclusao` datetime NOT NULL,
  PRIMARY KEY (`idLog`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_exclusoes`
--

LOCK TABLES `log_exclusoes` WRITE;
/*!40000 ALTER TABLE `log_exclusoes` DISABLE KEYS */;
INSERT INTO `log_exclusoes` VALUES (1,31,'laio','TOYCNI-oficinabox','1','Notobook','Dell','X76223','I7 3450','8 RAM DDR$','SSD120 1TB HD','Windows 11',4500,3,2,'9D18F0FB-86EB-4ED9-8CA9-47A4FC1CFE0A','446127-670747-219296-399410-232782-496848-262163-373032',NULL,'2024-10-05 19:18:17'),(2,27,'Maikinho','TOYCNI-MAL','1','Notebook','Positivo','X552E','I9 169999','64GB DDR8','7TB SSD','Windows 12',74000,3,2,NULL,NULL,NULL,'2024-11-17 22:17:46');
/*!40000 ALTER TABLE `log_exclusoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lojas`
--

DROP TABLE IF EXISTS `lojas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lojas` (
  `idLoja` int NOT NULL AUTO_INCREMENT,
  `loja` varchar(45) NOT NULL,
  PRIMARY KEY (`idLoja`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lojas`
--

LOCK TABLES `lojas` WRITE;
/*!40000 ALTER TABLE `lojas` DISABLE KEYS */;
INSERT INTO `lojas` VALUES (1,'VW'),(2,'Toyota LGS'),(3,'Toyota CNI'),(4,'Posto Mallon'),(5,'Silo'),(14,'Toyota Papanduva');
/*!40000 ALTER TABLE `lojas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(128) NOT NULL,
  `login` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `nivelAcesso` int NOT NULL DEFAULT '4',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Administrador','admin','202cb962ac59075b964b07152d234b70',1),(2,'','','d41d8cd98f00b204e9800998ecf8427e',4),(3,'sdfdsfdsf','dfdsfdsf','7f4b53f61cfce6127a298189802d7c6e',4),(4,'Laercio','laio','caf1a3dfb505ffed0d024130f58c5cfa',4),(5,'cxvcxv','xcvxcv','0376f6bba322ff9b8c3c692914e9de19',4),(6,'laio','laio soares','202cb962ac59075b964b07152d234b70',3);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-27  0:32:39
