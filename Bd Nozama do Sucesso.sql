CREATE DATABASE  IF NOT EXISTS `nozama` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `nozama`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: nozama
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `exame`
--

DROP TABLE IF EXISTS `exame`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exame` (
  `idexame` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `cpf` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `sexo` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `dataExame` datetime NOT NULL,
  `obs` mediumtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `tireoide` tinyint DEFAULT NULL,
  `hemograma` tinyint DEFAULT NULL,
  `colesterol` tinyint DEFAULT NULL,
  `glicose` tinyint DEFAULT NULL,
  `coagulograma` tinyint DEFAULT NULL,
  `funcaohepatica` tinyint DEFAULT NULL,
  `ureia` tinyint DEFAULT NULL,
  `creatinina` tinyint DEFAULT NULL,
  `hiv` tinyint DEFAULT NULL,
  PRIMARY KEY (`idexame`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exame`
--

LOCK TABLES `exame` WRITE;
/*!40000 ALTER TABLE `exame` DISABLE KEYS */;
INSERT INTO `exame` VALUES (6,'Sebastião Ferreira de Assis','88888888888','Prefiro não informar','2023-11-27 00:00:00','A fancy person\r\nÉ dodói da cabeça\r\nAutista\r\nAuditiva\r\nFlamenguista\r\nBotafoguense',0,1,1,1,0,1,0,0,1),(7,'Igu Im d\' Rosa','13398259643','Masculino','2023-11-23 00:00:00','uma pessoa legal',0,0,1,0,0,0,0,0,0),(8,'Kauã D\' Bahamas','99927614695','Masculino','2023-11-29 00:00:00','Trabalha no Bahamas',1,1,1,1,1,1,1,1,1),(9,'Elon Musk','19487214981','Masculino','2023-12-08 00:00:00','O homem de ferro da vida real',0,1,1,1,0,0,0,0,1),(10,'Tarcísio D\' Açougue','99993621978','Masculino','2023-12-08 00:00:00','Mental\r\nInsano',0,1,1,1,0,0,0,0,0);
/*!40000 ALTER TABLE `exame` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `idpaciente` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `endereco` mediumtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `email` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `obs` mediumtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `deficiencia` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cpf` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `celular` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `sexo` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `whatsapp` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `datanascimento` date NOT NULL,
  PRIMARY KEY (`idpaciente`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (18,'Sebastião Ferreira de Assis','França - Paris','SebastiaoSFA@outlook.com','A fancy person\r\nÉ dodói da cabeça\r\nAutista\r\nAuditiva\r\nFlamenguista\r\nBotafoguense','Outras não listadas (escreva abaixo)','88888888888','32920843205','Prefiro não informar','Sim','1958-11-20'),(19,'Igu Im D\' Rosa','Rua clorinda','domingoSilva@outlook.com','Visual\r\nOutro dodói da cabeça que joga Genshin (\'Mental\')','Mais de uma','99998259643','37940924434','Masculino','Não','2023-11-14'),(20,'Kauã D\' Bahamas','Bahamas','kauabh@gmail.com','Trabalha no Bahamas','Física','99927614695','32169421874','Masculino','Sim','2003-02-24'),(21,'Tarcísio D\' Açougue','Rua Padre Bonifácio','manotarci@tesla.com','Mental\r\nInsano','Mais de uma','99993621978','32932152924','Masculino','Sim','2003-09-17'),(22,'Gabi el D\' Marmota','Lá longe','gabrielgenshin@hotmail.com','O cara que joga jogo de fada (\'Mental\')','Outras não listadas (escreva abaixo)','99970131279','32752152154','Masculino','Sim','2004-11-26'),(23,'Deusi D\' Fofura','rua pedro s, marcedo','deusilanemariua1062@gmail.com','','Auditiva','99915412692','32988198509','Prefiro não informar','Sim','2003-12-07'),(24,'Elon Musk','Marte','manomusk@spacex.br','O homem de ferro da vida real','Outras não listadas (escreva abaixo)','19487214981','84968932535','Masculino','Não','1971-06-28'),(25,'Mark Zuckerberg','Califórnia','manozuck@facebook.com','Alien?','Outras não listadas (escreva abaixo)','89512807511','52197521789','Masculino','Sim','1984-05-14');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profissional`
--

DROP TABLE IF EXISTS `profissional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profissional` (
  `idprofissional` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `cpf` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `endereco` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `celular` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `profissao` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `dataNacimento` date NOT NULL,
  `sexo` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`idprofissional`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profissional`
--

LOCK TABLES `profissional` WRITE;
/*!40000 ALTER TABLE `profissional` DISABLE KEYS */;
INSERT INTO `profissional` VALUES (5,'Aparecida de Fatima','10987654321','Av. Rio Branco','32323232323','Enfermeiro ','1981-03-05','Feminino'),(7,'Priscilla Machado Alves','99999999999','Canadá - Quebec','32984867787','Técnico em enfermagem','2023-11-14','Prefiro não informar');
/*!40000 ALTER TABLE `profissional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'nozama'
--

--
-- Dumping routines for database 'nozama'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-21 12:25:52
