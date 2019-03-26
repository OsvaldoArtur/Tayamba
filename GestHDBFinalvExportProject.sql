-- Inline SQL script
Create Database GestHorario
Use GestHorario

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

CREATE TABLE [dbo].[Cadeira_tb](
	[idCadeira] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Cadeira] [varchar](150) NOT NULL,
	[Credito_Cadeira] [int] NOT NULL,
	[Ano] [int] NOT NULL,
	[Semestre] [int] NOT NULL,
	[idCurso] [int] NOT NULL
) 
ALTER TABLE [dbo].[Cadeira_tb] ADD [TipoCadeira] [varchar](max) NULL
 CONSTRAINT [PK_Cadeira] PRIMARY KEY CLUSTERED 
(
	[idCadeira] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Cadeira_tb]  WITH CHECK ADD  CONSTRAINT [FK_Cadeira_tb_Cusos_tb] FOREIGN KEY([idCurso])
REFERENCES [dbo].[Cusos_tb] ([idCurso])
GO

ALTER TABLE [dbo].[Cadeira_tb] CHECK CONSTRAINT [FK_Cadeira_tb_Cusos_tb]
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

ALTER TABLE [dbo].[Docente_tb]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Departamento] FOREIGN KEY([idDepartamento])
REFERENCES [dbo].[Departamento_tb] ([idDepartamento])
GO

ALTER TABLE [dbo].[Docente_tb] CHECK CONSTRAINT [FK_Docente_Departamento]
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

ALTER TABLE [dbo].[Horas_tb]  WITH CHECK ADD  CONSTRAINT [FK_Horas_tb_Periodo_tb] FOREIGN KEY([idPeriodo])
REFERENCES [dbo].[Periodo_tb] ([idPeriodo])
GO

ALTER TABLE [dbo].[Horas_tb] CHECK CONSTRAINT [FK_Horas_tb_Periodo_tb]
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

CREATE VIEW [dbo].[View_ListaHorario]
AS
SELECT        dbo.Horario_tb.Semestre, dbo.Horario_tb.Ano, dbo.Salas_tb.idSala, dbo.Salas_tb.Nome_Sala, dbo.Periodo_tb.idPeriodo, dbo.Periodo_tb.Nome_periodo, dbo.Cusos_tb.idCurso, dbo.Cusos_tb.Nome_Curso, 
                         dbo.Horario_tb.idAno, dbo.Horario_tb.idHorarioPorSemana
FROM            dbo.Cusos_tb INNER JOIN
                         dbo.Horario_tb ON dbo.Cusos_tb.idCurso = dbo.Horario_tb.idCurso INNER JOIN
                         dbo.Periodo_tb ON dbo.Horario_tb.idPeriodo = dbo.Periodo_tb.idPeriodo INNER JOIN
                         dbo.Salas_tb ON dbo.Horario_tb.idSala = dbo.Salas_tb.idSala


GO

USE [GestHorario]
GO

INSERT INTO [dbo].[Periodo_tb]
           ([Nome_periodo])
     VALUES
           ('Laboral'),
('Laboral-Tarde'),
		   ('Pos-Laboral')
GO

USE [GestHorario]
GO

INSERT INTO [dbo].[Semana_tb]
           ([Dia])
     VALUES
           ('2ª Segunda'),
		   ('3ª Terca'),
		   ('4ª Quarta'),
		   ('5ª Quinta'),
		   ('6ª Sexta'),
		   ('7ª Sabado'),
		   ('8ª Domingo')
GO

USE [GestHorario]
GO

INSERT INTO [dbo].[Departamento_tb]
           ([Nome_Departamento])
     VALUES
           ('Geral')
GO
