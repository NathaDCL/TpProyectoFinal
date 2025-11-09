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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.clientes: ~3 rows (aproximadamente)
INSERT INTO `clientes` (`ID`, `Cliente`, `Telefono`, `Correo`, `Activo`) VALUES
	(1, 'a', '12', 'a@', 'si'),
	(2, 'b', '14', 'b@', 'si'),
	(3, 'c', '13', 'c@', 'si');

-- Volcando estructura para tabla bddtpfinal.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL DEFAULT '0',
  `Precio` double NOT NULL,
  `Categoria` varchar(50) NOT NULL,
  `Activo` varchar(2) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.productos: ~4 rows (aproximadamente)
INSERT INTO `productos` (`ID`, `Nombre`, `Precio`, `Categoria`, `Activo`) VALUES
	(1, 'cosa', 7564, 'rara', 'si'),
	(2, 'otra cosa', 2983, 'bastante rara', 'si'),
	(3, 'cosa extra', 5364, 'muy rara', 'si'),
	(4, 'otra cosa extra ', 12122, 'rarisima', 'si');

-- Volcando estructura para tabla bddtpfinal.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `NomUsuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.usuarios: ~2 rows (aproximadamente)
INSERT INTO `usuarios` (`IdUsuario`, `Nombre`, `Apellido`, `NomUsuario`, `Contraseña`) VALUES
	(1, 'a', 'a', 'a', 'a'),
	(2, 'b', 'b', 'b', 'b');

-- Volcando estructura para tabla bddtpfinal.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDCliente` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Total` double NOT NULL,
  `Activo` varchar(2) NOT NULL DEFAULT 'no',
  PRIMARY KEY (`ID`),
  KEY `IDCliente` (`IDCliente`),
  CONSTRAINT `IDCliente` FOREIGN KEY (`IDCliente`) REFERENCES `clientes` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.ventas: ~5 rows (aproximadamente)
INSERT INTO `ventas` (`ID`, `IDCliente`, `Fecha`, `Total`, `Activo`) VALUES
	(1, 2, '1234-12-12', 476532, 'si'),
	(2, 2, '1222-01-21', 30405, 'si'),
	(3, 3, '1000-01-22', 37820, 'si'),
	(4, 2, '1111-01-01', 0, 'no'),
	(5, 1, '0001-01-01', 0, 'no');

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bddtpfinal.ventasitems: ~6 rows (aproximadamente)
INSERT INTO `ventasitems` (`ID`, `IDVenta`, `IDProducto`, `PrecioUnitario`, `Cantidad`, `PrecioTotal`) VALUES
	(1, 1, 1, 7564, 21, 158844),
	(2, 1, 1, 7564, 21, 158844),
	(3, 1, 1, 7564, 21, 158844),
	(4, 2, 2, 2983, 3, 8949),
	(5, 2, 3, 5364, 4, 21456),
	(6, 3, 1, 7564, 5, 37820);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
