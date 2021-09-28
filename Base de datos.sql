-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-09-2021 a las 22:14:55
-- Versión del servidor: 8.0.26
-- Versión de PHP: 7.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `compras`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `bajaUser` (IN `id` INT)  BEGIN
	update productos set productos.estado= 0 where prodc.idProducto=id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaCompras` ()  BEGIN
	select idProducto, Nombre, precio from productos;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ingCompra` (IN `id` INT, IN `nom` VARCHAR(45), IN `pre` INT, IN `est` INT)  BEGIN
	insert into productos (idProducto, Nombre,precio,estado) values (id,nom,pre,est);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ingProceso` (IN `id_proc` INT, IN `fech` VARCHAR(65), IN `det` VARCHAR(65), IN `nombre` VARCHAR(65), IN `dpi` VARCHAR(65))  BEGIN
	insert into proceso_compra (id_proc, fech,det,nombre,dpi) values (id_proc, fech,det,nombre,dpi);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `idFactura` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Nit` varchar(45) DEFAULT NULL,
  `total` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proceso_compra`
--

CREATE TABLE `proceso_compra` (
  `id_proc` int DEFAULT NULL,
  `fech` varchar(65) DEFAULT NULL,
  `det` varchar(65) DEFAULT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `dpi` varchar(65) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `proceso_compra`
--

INSERT INTO `proceso_compra` (`id_proc`, `fech`, `det`, `nombre`, `dpi`) VALUES
(1, '12-09-2121', 'algo', 'Juan', '23132132'),
(0, ' ', ' ', ' ', ' '),
(2, '28-09-2021', 'Se compraron tantos celulares', 'Jorge', '51481181');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `idProducto` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `precio` int DEFAULT NULL,
  `estado` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idProducto`, `Nombre`, `precio`, `estado`) VALUES
(1, 'algo', 500, 1),
(1, 'Juguete', 500, 1),
(1, 'asda', 500, 1),
(1, 'asd', 10, 1),
(4, 'Bebe de Juguete', 1, 1),
(5, 'algo', 500, 1),
(0, ' ', 0, 0),
(7, 'Oso', 600, 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
