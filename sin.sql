-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-04-2020 a las 20:11:28
-- Versión del servidor: 10.1.26-MariaDB
-- Versión de PHP: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sin`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` text COLLATE utf8_unicode_ci NOT NULL,
  `indice` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `concepto`
--

CREATE TABLE `concepto` (
  `codigo_concepto` varchar(5) NOT NULL,
  `nombre_concepto` varchar(60) DEFAULT NULL,
  `efecto_concepto` varchar(1) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `concepto`
--

INSERT INTO `concepto` (`codigo_concepto`, `nombre_concepto`, `efecto_concepto`, `estado`) VALUES
('AGUI', 'Aguinaldo', '+', 1),
('BONI', 'Bonificaciones', '+', 1),
('IGSS', 'IGSS', '-', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `codigo_departamento` varchar(5) NOT NULL,
  `nombre_departamento` varchar(80) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`codigo_departamento`, `nombre_departamento`, `estado`) VALUES
('BOD', 'Bodegas', 1),
('COP', 'Compras', 1),
('IT', 'IT', 1),
('RRHH', 'Recursos Humanos', 1),
('VENTA', 'Ventas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `codigo_empleado` varchar(5) NOT NULL,
  `nombre_empleado` varchar(60) DEFAULT NULL,
  `codigo_puesto` varchar(5) DEFAULT NULL,
  `codigo_departamento` varchar(5) DEFAULT NULL,
  `sueldo_empleado` float(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`codigo_empleado`, `nombre_empleado`, `codigo_puesto`, `codigo_departamento`, `sueldo_empleado`, `estado`) VALUES
('1288', 'Randy Choc', 'AdWeb', 'IT', 7000.00, 1),
('657', 'Gustavo Perez', 'GG', 'VENTA', 15000.00, 1),
('8787', 'Lucas Ramirez', 'BOGU', 'BOD', 4000.00, 1),
('JJGB', 'Juan Gámez', 'GGCT', 'VENTA', 12000.00, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nominad`
--

CREATE TABLE `nominad` (
  `codigo_nomina` varchar(5) NOT NULL,
  `codigo_empleado` varchar(5) NOT NULL,
  `codigo_concepto` varchar(5) NOT NULL,
  `valor_nominaD` float(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `nominad`
--

INSERT INTO `nominad` (`codigo_nomina`, `codigo_empleado`, `codigo_concepto`, `valor_nominaD`) VALUES
('N0420', '1288', 'AGUI', 1000.00),
('N0420', '1288', 'IGSS', 200.00),
('N0420', '8787', 'BONI', 250.00),
('N0420', '8787', 'IGSS', 200.00),
('N0420', 'JJGB', 'AGUI', 1500.00),
('N0420', 'JJGB', 'BONI', 350.00),
('N0420', 'JJGB', 'IGSS', 300.00),
('N0520', '657', 'AGUI', 1200.00),
('N0520', '657', 'IGSS', 275.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nominae`
--

CREATE TABLE `nominae` (
  `codigo_nomina` varchar(5) NOT NULL,
  `fecha_inicial_nomina` date DEFAULT NULL,
  `fecha_final_nomina` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `nominae`
--

INSERT INTO `nominae` (`codigo_nomina`, `fecha_inicial_nomina`, `fecha_final_nomina`) VALUES
('N0220', '2020-02-01', '2020-02-29'),
('N0420', '2020-04-01', '2020-04-30'),
('N0520', '2020-05-01', '2020-05-31');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE `puesto` (
  `codigo_puesto` varchar(5) NOT NULL,
  `nombre_puesto` varchar(60) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `puesto`
--

INSERT INTO `puesto` (`codigo_puesto`, `nombre_puesto`, `estado`) VALUES
('AdWeb', 'Administrador Web', 1),
('BOGU', 'Bodeguero', 1),
('CONT', 'Contador', 1),
('GG', 'Gerente General', 1),
('GGCT', 'Gerente de Calidad Total', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `concepto`
--
ALTER TABLE `concepto`
  ADD PRIMARY KEY (`codigo_concepto`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`codigo_departamento`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`codigo_empleado`),
  ADD KEY `FK_puestoempleado` (`codigo_puesto`),
  ADD KEY `FK_departamentoempleado` (`codigo_departamento`);

--
-- Indices de la tabla `nominad`
--
ALTER TABLE `nominad`
  ADD PRIMARY KEY (`codigo_nomina`,`codigo_empleado`,`codigo_concepto`),
  ADD KEY `FK_conceptonominaD` (`codigo_concepto`),
  ADD KEY `FK_empleadonominaD` (`codigo_empleado`);

--
-- Indices de la tabla `nominae`
--
ALTER TABLE `nominae`
  ADD PRIMARY KEY (`codigo_nomina`);

--
-- Indices de la tabla `puesto`
--
ALTER TABLE `puesto`
  ADD PRIMARY KEY (`codigo_puesto`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `FK_departamentoempleado` FOREIGN KEY (`codigo_departamento`) REFERENCES `departamento` (`codigo_departamento`),
  ADD CONSTRAINT `FK_puestoempleado` FOREIGN KEY (`codigo_puesto`) REFERENCES `puesto` (`codigo_puesto`);

--
-- Filtros para la tabla `nominad`
--
ALTER TABLE `nominad`
  ADD CONSTRAINT `FK_conceptonominaD` FOREIGN KEY (`codigo_concepto`) REFERENCES `concepto` (`codigo_concepto`),
  ADD CONSTRAINT `FK_empleadonominaD` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleado` (`codigo_empleado`),
  ADD CONSTRAINT `FK_nominaEnominaD` FOREIGN KEY (`codigo_nomina`) REFERENCES `nominae` (`codigo_nomina`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
