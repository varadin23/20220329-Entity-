-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 29. 10:20
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `school_0329`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `project_student`
--

CREATE TABLE `project_student` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Email` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `project_student`
--

INSERT INTO `project_student` (`Id`, `Name`, `Email`) VALUES
(1, 'Váradi Niki', 'varadika45@gmail.com'),
(2, 'kerekes József', 'Jozsi@kkszki.hu');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `project_subject`
--

CREATE TABLE `project_subject` (
  `id` int(11) NOT NULL,
  `Name` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Student_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `project_subject`
--

INSERT INTO `project_subject` (`id`, `Name`, `Student_id`) VALUES
(1, 'matek', 1),
(2, 'matek', 2);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `project_student`
--
ALTER TABLE `project_student`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `project_subject`
--
ALTER TABLE `project_subject`
  ADD PRIMARY KEY (`id`),
  ADD KEY `project_subject_student_id_fk` (`Student_id`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `project_subject`
--
ALTER TABLE `project_subject`
  ADD CONSTRAINT `project_subject_student_id_fk` FOREIGN KEY (`Student_id`) REFERENCES `project_student` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
