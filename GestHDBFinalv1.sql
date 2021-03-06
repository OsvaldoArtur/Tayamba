USE [master]
GO
/****** Object:  Database [GestHorario]    Script Date: 11/10/17 11:17:53 ******/
CREATE DATABASE [GestHorario] ON  PRIMARY 
( NAME = N'GestHorario', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\GestHorario.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GestHorario_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\GestHorario_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GestHorario] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestHorario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestHorario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestHorario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestHorario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestHorario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestHorario] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestHorario] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GestHorario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestHorario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestHorario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestHorario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestHorario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestHorario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestHorario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestHorario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestHorario] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestHorario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestHorario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestHorario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestHorario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestHorario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestHorario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestHorario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestHorario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestHorario] SET  MULTI_USER 
GO
ALTER DATABASE [GestHorario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestHorario] SET DB_CHAINING OFF 
GO
USE [GestHorario]
GO
/****** Object:  Table [dbo].[Cadeira_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Cadeira_tb](
	[idCadeira] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Cadeira] [varchar](150) NOT NULL,
	[Credito_Cadeira] [int] NOT NULL,
	[Ano] [int] NOT NULL,
	[Semestre] [int] NOT NULL,
	[idCurso] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
SET ANSI_PADDING ON
ALTER TABLE [dbo].[Cadeira_tb] ADD [TipoCadeira] [varchar](max) NULL
 CONSTRAINT [PK_Cadeira] PRIMARY KEY CLUSTERED 
(
	[idCadeira] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Criar_Horario_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criar_Horario_tb](
	[idHorario] [int] IDENTITY(1,1) NOT NULL,
	[idDia] [int] NULL,
	[idDocente] [int] NULL,
	[idCadeira] [int] NULL,
	[idHoras] [int] NULL,
	[idFaculdade] [int] NULL,
	[idHorarioPorSemestre] [int] NULL,
 CONSTRAINT [PK_Criar_Horario] PRIMARY KEY CLUSTERED 
(
	[idHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cusos_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cusos_tb](
	[idCurso] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Curso] [varchar](150) NOT NULL,
	[Duracao_Curso] [int] NOT NULL,
 CONSTRAINT [PK_Cusos] PRIMARY KEY CLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Departamento_tb](
	[idDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Departamento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[idDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Docente_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Docente_tb](
	[idDocente] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Docente] [varchar](150) NOT NULL,
	[Formacao_Academica] [varchar](50) NOT NULL,
	[idDepartamento] [int] NOT NULL,
 CONSTRAINT [PK_Docente] PRIMARY KEY CLUSTERED 
(
	[idDocente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Faculdade_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Faculdade_tb](
	[idFaculdade] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Universidade] [varchar](max) NOT NULL,
	[Nome_Extensao] [varchar](max) NULL,
	[logotipo] [image] NULL,
 CONSTRAINT [PK_Faculdade] PRIMARY KEY CLUSTERED 
(
	[idFaculdade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Horario_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_tb](
	[idHorarioPorSemana] [int] IDENTITY(1,1) NOT NULL,
	[Ano] [int] NULL,
	[Semestre] [int] NULL,
	[idSala] [int] NULL,
	[idPeriodo] [int] NULL,
	[idCurso] [int] NULL,
	[idAno] [int] NULL,
 CONSTRAINT [PK_Horario_tb] PRIMARY KEY CLUSTERED 
(
	[idHorarioPorSemana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horas_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Horas_tb](
	[Horas] [varchar](550) NULL,
	[idPeriodo] [int] NULL,
	[idHoras] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Horas_tb] PRIMARY KEY CLUSTERED 
(
	[idHoras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Periodo_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Periodo_tb](
	[idPeriodo] [int] IDENTITY(1,1) NOT NULL,
	[Nome_periodo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Periodo] PRIMARY KEY CLUSTERED 
(
	[idPeriodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salas_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Salas_tb](
	[idSala] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Sala] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Salas] PRIMARY KEY CLUSTERED 
(
	[idSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Semana_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Semana_tb](
	[idDia] [int] IDENTITY(1,1) NOT NULL,
	[Dia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Semana] PRIMARY KEY CLUSTERED 
(
	[idDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario_tb]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario_tb](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](max) NULL,
	[NomeUsuario] [varchar](max) NULL,
	[SenhaUsuario] [varchar](max) NULL,
 CONSTRAINT [PK_Usuario_tb] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_Horario]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Horario]
AS
SELECT        dbo.Criar_Horario_tb.idHorario AS idCriarHoriario, dbo.Horario_tb.Ano, dbo.Horario_tb.Semestre, dbo.Horario_tb.idSala, dbo.Horario_tb.idPeriodo, dbo.Horario_tb.idCurso, dbo.Criar_Horario_tb.idDia, 
                         dbo.Criar_Horario_tb.idDocente, dbo.Criar_Horario_tb.idCadeira, dbo.Criar_Horario_tb.idHoras, dbo.Criar_Horario_tb.idFaculdade, dbo.Cadeira_tb.Nome_Cadeira, dbo.Docente_tb.Nome_Docente, 
                         dbo.Horas_tb.Horas, dbo.Periodo_tb.Nome_periodo, dbo.Cusos_tb.Nome_Curso, dbo.Semana_tb.Dia, dbo.Salas_tb.Nome_Sala, dbo.Criar_Horario_tb.idHorarioPorSemestre, dbo.Horario_tb.idAno, 
                         dbo.Horario_tb.idHorarioPorSemana
FROM            dbo.Criar_Horario_tb INNER JOIN
                         dbo.Horario_tb ON dbo.Criar_Horario_tb.idHorarioPorSemestre = dbo.Horario_tb.idHorarioPorSemana INNER JOIN
                         dbo.Cadeira_tb ON dbo.Criar_Horario_tb.idCadeira = dbo.Cadeira_tb.idCadeira INNER JOIN
                         dbo.Cusos_tb ON dbo.Horario_tb.idCurso = dbo.Cusos_tb.idCurso AND dbo.Cadeira_tb.idCurso = dbo.Cusos_tb.idCurso INNER JOIN
                         dbo.Docente_tb ON dbo.Criar_Horario_tb.idDocente = dbo.Docente_tb.idDocente INNER JOIN
                         dbo.Horas_tb ON dbo.Criar_Horario_tb.idHoras = dbo.Horas_tb.idHoras INNER JOIN
                         dbo.Periodo_tb ON dbo.Horario_tb.idPeriodo = dbo.Periodo_tb.idPeriodo AND dbo.Horas_tb.idPeriodo = dbo.Periodo_tb.idPeriodo INNER JOIN
                         dbo.Salas_tb ON dbo.Horario_tb.idSala = dbo.Salas_tb.idSala INNER JOIN
                         dbo.Semana_tb ON dbo.Criar_Horario_tb.idDia = dbo.Semana_tb.idDia


GO
/****** Object:  View [dbo].[View_ListaHorario]    Script Date: 11/10/17 11:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ListaHorario]
AS
SELECT        dbo.Horario_tb.Semestre, dbo.Horario_tb.Ano, dbo.Salas_tb.idSala, dbo.Salas_tb.Nome_Sala, dbo.Periodo_tb.idPeriodo, dbo.Periodo_tb.Nome_periodo, dbo.Cusos_tb.idCurso, dbo.Cusos_tb.Nome_Curso, 
                         dbo.Horario_tb.idAno, dbo.Horario_tb.idHorarioPorSemana
FROM            dbo.Cusos_tb INNER JOIN
                         dbo.Horario_tb ON dbo.Cusos_tb.idCurso = dbo.Horario_tb.idCurso INNER JOIN
                         dbo.Periodo_tb ON dbo.Horario_tb.idPeriodo = dbo.Periodo_tb.idPeriodo INNER JOIN
                         dbo.Salas_tb ON dbo.Horario_tb.idSala = dbo.Salas_tb.idSala


GO
ALTER TABLE [dbo].[Cadeira_tb]  WITH CHECK ADD  CONSTRAINT [FK_Cadeira_tb_Cusos_tb] FOREIGN KEY([idCurso])
REFERENCES [dbo].[Cusos_tb] ([idCurso])
GO
ALTER TABLE [dbo].[Cadeira_tb] CHECK CONSTRAINT [FK_Cadeira_tb_Cusos_tb]
GO
ALTER TABLE [dbo].[Criar_Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Criar_Horario_Cadeira] FOREIGN KEY([idCadeira])
REFERENCES [dbo].[Cadeira_tb] ([idCadeira])
GO
ALTER TABLE [dbo].[Criar_Horario_tb] CHECK CONSTRAINT [FK_Criar_Horario_Cadeira]
GO
ALTER TABLE [dbo].[Criar_Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Criar_Horario_Docente] FOREIGN KEY([idDocente])
REFERENCES [dbo].[Docente_tb] ([idDocente])
GO
ALTER TABLE [dbo].[Criar_Horario_tb] CHECK CONSTRAINT [FK_Criar_Horario_Docente]
GO
ALTER TABLE [dbo].[Criar_Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Criar_Horario_Faculdade] FOREIGN KEY([idFaculdade])
REFERENCES [dbo].[Faculdade_tb] ([idFaculdade])
GO
ALTER TABLE [dbo].[Criar_Horario_tb] CHECK CONSTRAINT [FK_Criar_Horario_Faculdade]
GO
ALTER TABLE [dbo].[Criar_Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Criar_Horario_Semana] FOREIGN KEY([idDia])
REFERENCES [dbo].[Semana_tb] ([idDia])
GO
ALTER TABLE [dbo].[Criar_Horario_tb] CHECK CONSTRAINT [FK_Criar_Horario_Semana]
GO
ALTER TABLE [dbo].[Criar_Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Criar_Horario_tb_Horario_tb] FOREIGN KEY([idHorarioPorSemestre])
REFERENCES [dbo].[Horario_tb] ([idHorarioPorSemana])
GO
ALTER TABLE [dbo].[Criar_Horario_tb] CHECK CONSTRAINT [FK_Criar_Horario_tb_Horario_tb]
GO
ALTER TABLE [dbo].[Docente_tb]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Departamento] FOREIGN KEY([idDepartamento])
REFERENCES [dbo].[Departamento_tb] ([idDepartamento])
GO
ALTER TABLE [dbo].[Docente_tb] CHECK CONSTRAINT [FK_Docente_Departamento]
GO
ALTER TABLE [dbo].[Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Horario_tb_Cusos_tb] FOREIGN KEY([idCurso])
REFERENCES [dbo].[Cusos_tb] ([idCurso])
GO
ALTER TABLE [dbo].[Horario_tb] CHECK CONSTRAINT [FK_Horario_tb_Cusos_tb]
GO
ALTER TABLE [dbo].[Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Horario_tb_Periodo_tb] FOREIGN KEY([idPeriodo])
REFERENCES [dbo].[Periodo_tb] ([idPeriodo])
GO
ALTER TABLE [dbo].[Horario_tb] CHECK CONSTRAINT [FK_Horario_tb_Periodo_tb]
GO
ALTER TABLE [dbo].[Horario_tb]  WITH CHECK ADD  CONSTRAINT [FK_Horario_tb_Salas_tb] FOREIGN KEY([idSala])
REFERENCES [dbo].[Salas_tb] ([idSala])
GO
ALTER TABLE [dbo].[Horario_tb] CHECK CONSTRAINT [FK_Horario_tb_Salas_tb]
GO
ALTER TABLE [dbo].[Horas_tb]  WITH CHECK ADD  CONSTRAINT [FK_Horas_tb_Periodo_tb] FOREIGN KEY([idPeriodo])
REFERENCES [dbo].[Periodo_tb] ([idPeriodo])
GO
ALTER TABLE [dbo].[Horas_tb] CHECK CONSTRAINT [FK_Horas_tb_Periodo_tb]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Criar_Horario_tb"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Horario_tb"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cadeira_tb"
            Begin Extent = 
               Top = 6
               Left = 281
               Bottom = 136
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cusos_tb"
            Begin Extent = 
               Top = 138
               Left = 275
               Bottom = 251
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Docente_tb"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Horas_tb"
            Begin Extent = 
               Top = 252
               Left = 275
               Bottom = 365
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Periodo_tb"
            Begin Extent = 
               Top = 366
               Left = 282
               Bottom = 462
               Right = 452
            End
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Horario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Salas_tb"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 498
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Semana_tb"
            Begin Extent = 
               Top = 462
               Left = 246
               Bottom = 558
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 22
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2430
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Horario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Horario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cusos_tb"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Horario_tb"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Periodo_tb"
            Begin Extent = 
               Top = 120
               Left = 38
               Bottom = 216
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Salas_tb"
            Begin Extent = 
               Top = 138
               Left = 246
               Bottom = 234
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2850
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListaHorario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListaHorario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ListaHorario'
GO
USE [master]
GO
ALTER DATABASE [GestHorario] SET  READ_WRITE 
GO
