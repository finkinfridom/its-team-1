-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Creato il: Feb 07, 2017 alle 23:24
-- Versione del server: 8.0.0-dmr
-- Versione PHP: 7.0.13-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `ristorante`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `categoria`
--

CREATE TABLE `categoria` (
  `nome_cat` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'antipasto / primo / secondo / contorno / pizza / dolce / ecc'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dump dei dati per la tabella `categoria`
--

INSERT INTO `categoria` (`nome_cat`) VALUES
('antipasti'),
('caffetteria'),
('contorni'),
('dolci'),
('drink'),
('primi'),
('secondi');

-- --------------------------------------------------------

--
-- Struttura della tabella `cliente`
--

CREATE TABLE `cliente` (
  `cod_cliente` int(11) NOT NULL,
  `mail` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefono` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cognome` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nome` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `punti` smallint(11) NOT NULL COMMENT 'accumulati se prenotato online? o ogni tot € di spesa?'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dump dei dati per la tabella `cliente`
--

INSERT INTO `cliente` (`cod_cliente`, `mail`, `telefono`, `cognome`, `nome`, `punti`) VALUES
(1, 'marco@marchi.it', '011-666', 'marchi', 'marco', 0);

-- --------------------------------------------------------

--
-- Struttura della tabella `comanda`
--

CREATE TABLE `comanda` (
  `num_comanda` int(11) NOT NULL,
  `giorno_ora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `ingredienti`
--

CREATE TABLE `ingredienti` (
  `nome_ingr` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `descrizione` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `esaurito` tinyint(1) DEFAULT '0' COMMENT '1 ce n''è ancora / 0 finito (segnalato dalla cucina?)'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `prenotazione`
--

CREATE TABLE `prenotazione` (
  `cod_prenotazione` int(11) NOT NULL,
  `gg_prenotazione` date NOT NULL,
  `giorno` date NOT NULL,
  `ora` time NOT NULL,
  `num_persone` tinyint(11) NOT NULL,
  `cod_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotti`
--

CREATE TABLE `prodotti` (
  `cod_prodotto` int(11) NOT NULL,
  `nome_prod` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `descrizione` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `nel_menu` tinyint(1) NOT NULL DEFAULT '1' COMMENT '1 ordinabile e visibile nel menu / 0 disattivo',
  `nome_cat` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `giacenza` smallint(11) DEFAULT NULL COMMENT 'calcolato se bevanda o bistecca o contabili',
  `prezzo` float NOT NULL,
  `featured` tinyint(1) NOT NULL DEFAULT '0' COMMENT '1 nei featured / 0 no'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dump dei dati per la tabella `prodotti`
--

INSERT INTO `prodotti` (`cod_prodotto`, `nome_prod`, `descrizione`, `nel_menu`, `nome_cat`, `giacenza`, `prezzo`, `featured`) VALUES
(1, 'patate', 'fritte con salse a scelta', 1, 'contorni', NULL, 3.5, 1),
(2, 'pollo fritto', 'alette piccanti', 1, 'secondi', NULL, 6, 1),
(3, 'bistecca', 'bistecca alla griglia di angus argentino', 1, 'secondi', 50, 15, 0),
(4, 'zuppa di verdure', 'con crostini', 0, 'primi', NULL, 4.5, 0),
(5, 'birra lager 0.40', 'chiara scura tanta e poca', 1, 'drink', NULL, 3.2, 0),
(6, 'involtino primavera', 'frittissimissimo', 1, 'antipasti', 500, 1, 0),
(7, 'caffè nero', 'fatto con i copertoni', 1, 'caffetteria', NULL, 1, 0),
(8, 'caffè lungo', 'all\'americana', 0, 'caffetteria', NULL, 1, 0);

-- --------------------------------------------------------

--
-- Struttura della tabella `prod_comanda`
--

CREATE TABLE `prod_comanda` (
  `num_comanda` int(11) NOT NULL,
  `stato` enum('preparazione','attesa','consegnare','annullata','consegnata') COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'in preparazione / in stop / da consegnare/ annullata / consegnata',
  `cod_prodotto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Struttura della tabella `prod_ingr`
--

CREATE TABLE `prod_ingr` (
  `nome_ingr` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cod_prodotto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Struttura della tabella `servizio`
--

CREATE TABLE `servizio` (
  `giorno_ora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `num_servizio` int(11) NOT NULL COMMENT 'parte da 1 ogni giorno',
  `ora_fine` time DEFAULT NULL,
  `num_persone` int(11) NOT NULL,
  `totale` float NOT NULL COMMENT 'calcolato',
  `num_tavolo` int(11) NOT NULL,
  `cod_cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dump dei dati per la tabella `servizio`
--

INSERT INTO `servizio` (`giorno_ora`, `num_servizio`, `ora_fine`, `num_persone`, `totale`, `num_tavolo`, `cod_cliente`) VALUES
('2017-02-01 13:42:43', 1, NULL, 4, 0, 1, 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `serv_spese`
--

CREATE TABLE `serv_spese` (
  `cod_spesa` int(11) NOT NULL,
  `giorno_ora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `spese`
--

CREATE TABLE `spese` (
  `cod_spesa` int(11) NOT NULL,
  `nome_spesa` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `moltiplicatore` tinyint(1) NOT NULL DEFAULT '0' COMMENT '1 da moltiplicare per num persone / 0 spesa fissa'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dump dei dati per la tabella `spese`
--

INSERT INTO `spese` (`cod_spesa`, `nome_spesa`, `moltiplicatore`) VALUES
(1, 'coperto', 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `tavolo`
--

CREATE TABLE `tavolo` (
  `num_tavolo` int(11) NOT NULL,
  `libero` tinyint(1) NOT NULL DEFAULT '0' COMMENT '1 occupato / 0 libero'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dump dei dati per la tabella `tavolo`
--

INSERT INTO `tavolo` (`num_tavolo`, `libero`) VALUES
(1, 0),
(2, 0),
(3, 0),
(4, 0),
(5, 0),
(6, 0);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`nome_cat`);

--
-- Indici per le tabelle `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`cod_cliente`),
  ADD UNIQUE KEY `mail` (`mail`),
  ADD UNIQUE KEY `telefono` (`telefono`);

--
-- Indici per le tabelle `comanda`
--
ALTER TABLE `comanda`
  ADD PRIMARY KEY (`num_comanda`),
  ADD KEY `giorno_ora` (`giorno_ora`);

--
-- Indici per le tabelle `ingredienti`
--
ALTER TABLE `ingredienti`
  ADD PRIMARY KEY (`nome_ingr`);

--
-- Indici per le tabelle `prenotazione`
--
ALTER TABLE `prenotazione`
  ADD PRIMARY KEY (`cod_prenotazione`),
  ADD KEY `cod_cliente` (`cod_cliente`);

--
-- Indici per le tabelle `prodotti`
--
ALTER TABLE `prodotti`
  ADD PRIMARY KEY (`cod_prodotto`),
  ADD UNIQUE KEY `nome_prod` (`nome_prod`),
  ADD KEY `nome` (`nome_cat`);

--
-- Indici per le tabelle `prod_comanda`
--
ALTER TABLE `prod_comanda`
  ADD PRIMARY KEY (`num_comanda`),
  ADD KEY `cod_prodotto` (`cod_prodotto`);

--
-- Indici per le tabelle `prod_ingr`
--
ALTER TABLE `prod_ingr`
  ADD PRIMARY KEY (`nome_ingr`,`cod_prodotto`),
  ADD KEY `cod_prodotto` (`cod_prodotto`);

--
-- Indici per le tabelle `servizio`
--
ALTER TABLE `servizio`
  ADD PRIMARY KEY (`giorno_ora`),
  ADD KEY `num_tavolo` (`num_tavolo`),
  ADD KEY `servizio_ibfk_2` (`cod_cliente`);

--
-- Indici per le tabelle `serv_spese`
--
ALTER TABLE `serv_spese`
  ADD PRIMARY KEY (`cod_spesa`,`giorno_ora`),
  ADD KEY `giorno_ora` (`giorno_ora`);

--
-- Indici per le tabelle `spese`
--
ALTER TABLE `spese`
  ADD PRIMARY KEY (`cod_spesa`);

--
-- Indici per le tabelle `tavolo`
--
ALTER TABLE `tavolo`
  ADD PRIMARY KEY (`num_tavolo`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `prenotazione`
--
ALTER TABLE `prenotazione`
  MODIFY `cod_prenotazione` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT per la tabella `prodotti`
--
ALTER TABLE `prodotti`
  MODIFY `cod_prodotto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT per la tabella `spese`
--
ALTER TABLE `spese`
  MODIFY `cod_spesa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `comanda`
--
ALTER TABLE `comanda`
  ADD CONSTRAINT `comanda_ibfk_1` FOREIGN KEY (`giorno_ora`) REFERENCES `servizio` (`giorno_ora`);

--
-- Limiti per la tabella `prenotazione`
--
ALTER TABLE `prenotazione`
  ADD CONSTRAINT `prenotazione_ibfk_1` FOREIGN KEY (`cod_cliente`) REFERENCES `cliente` (`cod_cliente`);

--
-- Limiti per la tabella `prodotti`
--
ALTER TABLE `prodotti`
  ADD CONSTRAINT `prodotti_ibfk_1` FOREIGN KEY (`nome_cat`) REFERENCES `categoria` (`nome_cat`);

--
-- Limiti per la tabella `prod_comanda`
--
ALTER TABLE `prod_comanda`
  ADD CONSTRAINT `prod_comanda_ibfk_1` FOREIGN KEY (`num_comanda`) REFERENCES `comanda` (`num_comanda`),
  ADD CONSTRAINT `prod_comanda_ibfk_2` FOREIGN KEY (`cod_prodotto`) REFERENCES `prodotti` (`cod_prodotto`);

--
-- Limiti per la tabella `prod_ingr`
--
ALTER TABLE `prod_ingr`
  ADD CONSTRAINT `prod_ingr_ibfk_1` FOREIGN KEY (`nome_ingr`) REFERENCES `ingredienti` (`nome_ingr`),
  ADD CONSTRAINT `prod_ingr_ibfk_2` FOREIGN KEY (`cod_prodotto`) REFERENCES `prodotti` (`cod_prodotto`);

--
-- Limiti per la tabella `servizio`
--
ALTER TABLE `servizio`
  ADD CONSTRAINT `servizio_ibfk_1` FOREIGN KEY (`num_tavolo`) REFERENCES `tavolo` (`num_tavolo`),
  ADD CONSTRAINT `servizio_ibfk_2` FOREIGN KEY (`cod_cliente`) REFERENCES `cliente` (`cod_cliente`);

--
-- Limiti per la tabella `serv_spese`
--
ALTER TABLE `serv_spese`
  ADD CONSTRAINT `serv_spese_ibfk_1` FOREIGN KEY (`cod_spesa`) REFERENCES `spese` (`cod_spesa`),
  ADD CONSTRAINT `serv_spese_ibfk_2` FOREIGN KEY (`giorno_ora`) REFERENCES `servizio` (`giorno_ora`);