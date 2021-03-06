USE [BD_CasaDeLaCiudad]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](45) NOT NULL,
	[Apellidos] [varchar](45) NOT NULL,
	[Dni] [int] NOT NULL,
	[Direccion] [varchar](45) NOT NULL,
	[FechNac] [date] NOT NULL,
	[Telefono] [varchar](45) NULL,
	[Correo] [varchar](45) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Legajo] [int] NOT NULL,
	[Persona_idPersona] [int] NOT NULL,
	[Cargo_idCargo] [int] NOT NULL,
	[Activo] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_EmpleadoProfesor]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_EmpleadoProfesor]
AS
SELECT        emp.idEmpleado AS id, per.Apellidos + ', ' + per.Nombres AS apeNom
FROM            dbo.Empleado AS emp INNER JOIN
                         dbo.Persona AS per ON emp.Persona_idPersona = per.idPersona
WHERE        (emp.Cargo_idCargo = 2)
GO
/****** Object:  Table [dbo].[PlanDeEstudio]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanDeEstudio](
	[idPlanDeEstudio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[RandoEdad] [varchar](20) NULL,
	[Activo] [varchar](1) NOT NULL,
 CONSTRAINT [PK_PlanDeEstudio] PRIMARY KEY CLUSTERED 
(
	[idPlanDeEstudio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[idCursos] [int] IDENTITY(1,1) NOT NULL,
	[FechaIncial] [date] NOT NULL,
	[FechaFinal] [date] NOT NULL,
	[CupoAct] [int] NOT NULL,
	[CupoMax] [int] NOT NULL,
	[Empleado_idEmpleado] [int] NOT NULL,
	[PlanDeEstudio_idPlanDeEstudio] [int] NOT NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[idCursos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[idInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Alumno_idAlumno] [int] NOT NULL,
	[Usuario_idUsuario] [int] NOT NULL,
	[Curso_idCursos] [int] NOT NULL,
 CONSTRAINT [PK_Inscripcion] PRIMARY KEY CLUSTERED 
(
	[idInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_CursosConInscripcion]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_CursosConInscripcion]
AS
SELECT DISTINCT cur.idCursos AS id, UPPER(plaEst.Nombre) + ' - Desde: ' + CONVERT(varchar, cur.FechaIncial) + ' Hasta: ' + CONVERT(varchar, cur.FechaFinal) AS detalle
FROM            dbo.Cursos AS cur INNER JOIN
                         dbo.Inscripcion AS ins ON cur.idCursos = ins.Curso_idCursos INNER JOIN
                         dbo.PlanDeEstudio AS plaEst ON cur.PlanDeEstudio_idPlanDeEstudio = plaEst.idPlanDeEstudio
GO
/****** Object:  View [dbo].[vw_CursoPlanDeEstudio]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_CursoPlanDeEstudio]
AS
SELECT        cur.idCursos AS id, UPPER(plaEst.Nombre) + ' - Desde: ' + CONVERT(varchar, cur.FechaIncial) + ' Hasta: ' + CONVERT(varchar, cur.FechaFinal) AS detalle
FROM            dbo.Cursos AS cur INNER JOIN
                         dbo.PlanDeEstudio AS plaEst ON cur.PlanDeEstudio_idPlanDeEstudio = plaEst.idPlanDeEstudio
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NOT NULL,
	[Clave] [varchar](45) NOT NULL,
	[Empleado_idEmpleado] [int] NOT NULL,
	[Perfil_idPerfil] [int] NOT NULL,
	[Activo] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_EmpleadosSinUsuario]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_EmpleadosSinUsuario]
AS
SELECT        emp.idEmpleado AS id, CONVERT(varchar, emp.Legajo) + ' - ' + per.Apellidos + ', ' + per.Nombres AS apeNom
FROM            dbo.Empleado AS emp INNER JOIN
                         dbo.Persona AS per ON emp.Persona_idPersona = per.idPersona LEFT OUTER JOIN
                         dbo.Usuario AS usu ON emp.idEmpleado = usu.Empleado_idEmpleado
WHERE        (usu.idUsuario IS NULL)
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[idAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Legajo] [int] NOT NULL,
	[Persona_idPersona] [int] NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[idAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[idCargo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[idCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[idPerfil] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 17/04/2020 10:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[idPermisos] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](45) NULL,
	[Perfil_idPerfil] [int] NOT NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[idPermisos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (1, 31313, 2)
INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (16, 31345, 29)
INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (1036, 45458, 1056)
INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (2016, 78789, 2034)
INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (2017, 12124, 2035)
INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (3016, 69857, 3034)
INSERT [dbo].[Alumno] ([idAlumno], [Legajo], [Persona_idPersona]) VALUES (3017, 66466, 3035)
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[Cargo] ON 

INSERT [dbo].[Cargo] ([idCargo], [Descripcion]) VALUES (1, N'Director')
INSERT [dbo].[Cargo] ([idCargo], [Descripcion]) VALUES (2, N'Profesor')
INSERT [dbo].[Cargo] ([idCargo], [Descripcion]) VALUES (3, N'Secretario')
INSERT [dbo].[Cargo] ([idCargo], [Descripcion]) VALUES (6, N'Administrador')
SET IDENTITY_INSERT [dbo].[Cargo] OFF
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([idCursos], [FechaIncial], [FechaFinal], [CupoAct], [CupoMax], [Empleado_idEmpleado], [PlanDeEstudio_idPlanDeEstudio]) VALUES (2, CAST(N'2020-01-01' AS Date), CAST(N'2020-03-31' AS Date), 15, 20, 11, 3)
INSERT [dbo].[Cursos] ([idCursos], [FechaIncial], [FechaFinal], [CupoAct], [CupoMax], [Empleado_idEmpleado], [PlanDeEstudio_idPlanDeEstudio]) VALUES (3, CAST(N'2020-04-01' AS Date), CAST(N'2020-08-31' AS Date), 0, 10, 10, 6)
INSERT [dbo].[Cursos] ([idCursos], [FechaIncial], [FechaFinal], [CupoAct], [CupoMax], [Empleado_idEmpleado], [PlanDeEstudio_idPlanDeEstudio]) VALUES (4, CAST(N'2019-02-01' AS Date), CAST(N'2019-10-31' AS Date), 0, 20, 10, 5)
INSERT [dbo].[Cursos] ([idCursos], [FechaIncial], [FechaFinal], [CupoAct], [CupoMax], [Empleado_idEmpleado], [PlanDeEstudio_idPlanDeEstudio]) VALUES (1004, CAST(N'2019-03-01' AS Date), CAST(N'2019-06-30' AS Date), 0, 40, 11, 8)
INSERT [dbo].[Cursos] ([idCursos], [FechaIncial], [FechaFinal], [CupoAct], [CupoMax], [Empleado_idEmpleado], [PlanDeEstudio_idPlanDeEstudio]) VALUES (2003, CAST(N'2020-03-01' AS Date), CAST(N'2020-06-30' AS Date), 0, 15, 15, 4)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (2, 4587, 30, 1, N'S')
INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (7, 999, 36, 3, N'S')
INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (9, 888, 37, 3, N'S')
INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (10, 777, 38, 2, N'S')
INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (11, 666, 1055, 2, N'S')
INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (14, 31520, 1, 6, N'S')
INSERT [dbo].[Empleado] ([idEmpleado], [Legajo], [Persona_idPersona], [Cargo_idCargo], [Activo]) VALUES (15, 112244, 1060, 2, N'S')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[Inscripcion] ON 

INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (4, CAST(N'2020-01-02' AS Date), 16, 13, 4)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (2006, CAST(N'2020-04-10' AS Date), 2017, 1015, 1004)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (2007, CAST(N'2020-04-10' AS Date), 2017, 1015, 4)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (2008, CAST(N'2020-04-10' AS Date), 2016, 1015, 3)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (2010, CAST(N'2020-04-10' AS Date), 1036, 1015, 1004)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (2011, CAST(N'2020-04-10' AS Date), 1, 1015, 1004)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (2012, CAST(N'2020-04-10' AS Date), 1, 1015, 3)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (3004, CAST(N'2020-04-13' AS Date), 3017, 1015, 2003)
INSERT [dbo].[Inscripcion] ([idInscripcion], [Fecha], [Alumno_idAlumno], [Usuario_idUsuario], [Curso_idCursos]) VALUES (3005, CAST(N'2020-04-13' AS Date), 3016, 1015, 2003)
SET IDENTITY_INSERT [dbo].[Inscripcion] OFF
SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([idPerfil], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfil] ([idPerfil], [Descripcion]) VALUES (13, N'Director')
INSERT [dbo].[Perfil] ([idPerfil], [Descripcion]) VALUES (14, N'Profesor')
INSERT [dbo].[Perfil] ([idPerfil], [Descripcion]) VALUES (15, N'Secretario')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
SET IDENTITY_INSERT [dbo].[Permisos] ON 

INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (1, N'abmUsuario', 1)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (2, N'abmEmpleado', 13)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (3, N'abmPlan', 13)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (5, N'abmCurso', 13)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (6, N'abmInscripcion', 13)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (7, N'abmAlumno', 13)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (8, N'repAsistencia', 13)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (9, N'abmCurso', 15)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (10, N'abmInscripcion', 15)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (11, N'abmAlumno', 15)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (12, N'repAsistencia', 15)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (13, N'abmAlumno', 14)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (14, N'repAsistencia', 14)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (15, N'abmEmpleado', 1)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (16, N'abmPlan', 1)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (17, N'abmCurso', 1)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (18, N'abmInscripcion', 1)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (19, N'abmAlumno', 1)
INSERT [dbo].[Permisos] ([idPermisos], [Descripcion], [Perfil_idPerfil]) VALUES (20, N'repAsistencia', 1)
SET IDENTITY_INSERT [dbo].[Permisos] OFF
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (1, N'Carlos', N'Cardozo', 33885284, N'San juan 252 1b', CAST(N'1988-10-20' AS Date), N'3813501540', N'cardozocarlos88@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (2, N'Mia', N'Cardozo Diaz', 52451052, N'Muñecas 767 ', CAST(N'1992-08-20' AS Date), N'3814512540', N'No tiene')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (29, N'Cintia Raquel', N'diaz', 31038558, N'Muñecas 767', CAST(N'1983-06-30' AS Date), N'63813405447', N'cdiaz@cotalt.coop')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (30, N'Diana ', N'Sosa', 52478987, N'Muñecas 767', CAST(N'1962-09-19' AS Date), N'3814580268', N'brunojosue09@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (36, N'Julieta', N'Santos', 29123547, N'roca 1000', CAST(N'1985-12-11' AS Date), N'4564578', N'juancho@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (37, N'Celeste', N'Mel', 31038457, N'Las eras 600', CAST(N'1981-05-27' AS Date), N'1545890268', N'78979')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (38, N'Facundo ', N'Gomez', 45789635, N'Crisostomo 785', CAST(N'1985-07-07' AS Date), N'15336687', N'dgomez@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (1055, N'Pablo', N'Sanchez', 25874125, N'Monteagudo 56', CAST(N'1973-01-09' AS Date), N'42155879', N'NO TIENE')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (1056, N'Cintia Elena', N'Acosta', 32014871, N'fonabi oeste casa 3', CAST(N'1987-01-09' AS Date), N'15632587', N'cintiaacostagmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (1060, N'Victor', N'Paul', 27814693, N'Crisostomo 745 3 D', CAST(N'1989-03-21' AS Date), N'3816625145', N'paulvictor45@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (2034, N'Fabian', N'Portal', 78587845, N'las eras 35', CAST(N'1975-01-09' AS Date), N'3813501587', N'fabi@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (2035, N'Alejandro', N'Pollo', 58754123, N'Santafe 234', CAST(N'1989-04-18' AS Date), N'38145789654', N'pollop@gmail,.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (3034, N'Sandra', N'Landivar', 27148254, N'Guemes 457', CAST(N'1983-04-20' AS Date), N'3816687415', N'slandivar@gmail.com')
INSERT [dbo].[Persona] ([idPersona], [Nombres], [Apellidos], [Dni], [Direccion], [FechNac], [Telefono], [Correo]) VALUES (3035, N'Luis Fernando', N'Venencia', 4578214, N'Sirio libanes 670 Metan-Salta', CAST(N'1990-07-18' AS Date), N'421066', N'luisFernando@gmail.com')
SET IDENTITY_INSERT [dbo].[Persona] OFF
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] ON 

INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (1, N'Opc', N'10 a 12', N'N')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (2, N'bordado', N'20-30', N'N')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (3, N'office', N'20 a 30', N'S')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (4, N'OPC', N'20 a 50', N'S')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (5, N'.NET', N'20-30', N'N')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (6, N'programacion', N'18 a 50', N'S')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (7, N'Bordado', N'30-60', N'S')
INSERT [dbo].[PlanDeEstudio] ([idPlanDeEstudio], [Nombre], [RandoEdad], [Activo]) VALUES (8, N'C#', N'18-40', N'S')
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (13, N'dsosa', N'1234', 2, 14, N'S')
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (15, N'jsantos', N'123', 7, 15, N'S')
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (16, N'cmell', N'1234', 9, 15, N'S')
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (17, N'fgomez', N'1234', 10, 14, N'N')
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (18, N'psanchez', N'1234', 11, 14, N'S')
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (1015, N'ccardozo', N'1234', 14, 1, N'S')
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Clave], [Empleado_idEmpleado], [Perfil_idPerfil], [Activo]) VALUES (1016, N'vpaul', N'1234', 15, 14, N'S')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Persona] FOREIGN KEY([Persona_idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Persona]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Empleado] FOREIGN KEY([Empleado_idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Empleado]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_PlanDeEstudio] FOREIGN KEY([PlanDeEstudio_idPlanDeEstudio])
REFERENCES [dbo].[PlanDeEstudio] ([idPlanDeEstudio])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_PlanDeEstudio]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Cargo] FOREIGN KEY([Cargo_idCargo])
REFERENCES [dbo].[Cargo] ([idCargo])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Cargo]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Persona] FOREIGN KEY([Persona_idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Persona]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_Alumno] FOREIGN KEY([Alumno_idAlumno])
REFERENCES [dbo].[Alumno] ([idAlumno])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_Alumno]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_Cursos] FOREIGN KEY([Curso_idCursos])
REFERENCES [dbo].[Cursos] ([idCursos])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_Cursos]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_Usuario] FOREIGN KEY([Usuario_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_Usuario]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfil] FOREIGN KEY([Perfil_idPerfil])
REFERENCES [dbo].[Perfil] ([idPerfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfil]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([Empleado_idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([Perfil_idPerfil])
REFERENCES [dbo].[Perfil] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
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
         Begin Table = "cur"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 294
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "plaEst"
            Begin Extent = 
               Top = 6
               Left = 332
               Bottom = 136
               Right = 507
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CursoPlanDeEstudio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CursoPlanDeEstudio'
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
         Begin Table = "cur"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 294
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ins"
            Begin Extent = 
               Top = 6
               Left = 332
               Bottom = 136
               Right = 522
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "plaEst"
            Begin Extent = 
               Top = 6
               Left = 560
               Bottom = 136
               Right = 735
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CursosConInscripcion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_CursosConInscripcion'
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
         Begin Table = "emp"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "per"
            Begin Extent = 
               Top = 6
               Left = 264
               Bottom = 136
               Right = 434
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_EmpleadoProfesor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_EmpleadoProfesor'
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
         Begin Table = "emp"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "per"
            Begin Extent = 
               Top = 6
               Left = 264
               Bottom = 136
               Right = 434
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "usu"
            Begin Extent = 
               Top = 6
               Left = 472
               Bottom = 136
               Right = 682
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_EmpleadosSinUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_EmpleadosSinUsuario'
GO
