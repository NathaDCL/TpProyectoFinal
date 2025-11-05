-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.32-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.12.0.7122
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para bddtpfinal
CREATE DATABASE IF NOT EXISTS `bddtpfinal` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `bddtpfinal`;

-- Volcando estructura para tabla bddtpfinal.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Cliente` varchar(50) NOT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Correo` varchar(50) NOT NULL,
  `Activo` varchar(2) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.clientes: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bddtpfinal.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL DEFAULT '0',
  `Precio` double NOT NULL,
  `Categoria` varchar(50) NOT NULL,
  `Activo` varchar(2) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.productos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bddtpfinal.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `NomUsuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.usuarios: ~1 rows (aproximadamente)
INSERT INTO `usuarios` (`IdUsuario`, `Nombre`, `Apellido`, `NomUsuario`, `Contraseña`) VALUES
	(1, 'a', 'a', 'a', 'a');

-- Volcando estructura para tabla bddtpfinal.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDCliente` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Total` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDCliente` (`IDCliente`),
  CONSTRAINT `IDCliente` FOREIGN KEY (`IDCliente`) REFERENCES `clientes` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.ventas: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bddtpfinal.ventasitems
CREATE TABLE IF NOT EXISTS `ventasitems` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDVenta` int(11) NOT NULL,
  `IDProducto` int(11) NOT NULL,
  `PrecioUnitario` double NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `PrecioTotal` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDVenta` (`IDVenta`),
  KEY `IDProducto` (`IDProducto`),
  CONSTRAINT `IDProducto` FOREIGN KEY (`IDProducto`) REFERENCES `productos` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IDVenta` FOREIGN KEY (`IDVenta`) REFERENCES `ventas` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.ventasitems: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
