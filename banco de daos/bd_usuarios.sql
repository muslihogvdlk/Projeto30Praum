-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 08/07/2025 às 20:19
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_usuarios`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cadastro`
--

CREATE TABLE `tb_cadastro` (
  `id_usuario` int(11) NOT NULL,
  `nome_perfil` varchar(30) NOT NULL,
  `senha` varchar(15) NOT NULL,
  `apelido` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_cadastro`
--

INSERT INTO `tb_cadastro` (`id_usuario`, `nome_perfil`, `senha`, `apelido`) VALUES
(1, 'ewdfasdsd', '77777777', 'sdgffwsdg'),
(2, 'MUSLINDO VDLK', '33333333', 'MUSLIH VDL'),
(3, 'JOAO PESSOA DE RAXA', '66666666', 'JAO'),
(4, 'NEYMAR JR DOS SANTOS', 'NEYMAR10', 'NEYMAR GOA'),
(5, 'gycdcrv', '08088888', 'vggtyffryd'),
(6, 'mateus brasileiro', '77766600', 'Matue'),
(7, 'Cleriton Savio', '99999999', 'TETO'),
(8, 'melly', '88888888', 'melly');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `nome_unique` (`nome_perfil`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
