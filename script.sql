USE [Manitou]
GO
/****** Object:  Table [dbo].[Etat]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Etat](
	[id] [char](2) NOT NULL,
	[libelle] [varchar](30) NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[idFamille] [char](3) NOT NULL,
	[libFamille] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFamille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fichefrais]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fichefrais](
	[idVisiteur] [char](3) NOT NULL,
	[mois] [char](6) NOT NULL,
	[annee] [int] NOT NULL,
	[nbJustificatifs] [int] NULL,
	[montantValide] [decimal](10, 2) NULL,
	[dateModif] [date] NULL,
	[idEtat] [char](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idVisiteur] ASC,
	[mois] ASC,
	[annee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FraisForfait]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FraisForfait](
	[id] [char](3) NOT NULL,
	[libelle] [char](20) NULL DEFAULT (NULL),
	[montant] [decimal](5, 2) NULL DEFAULT (NULL),
	[TypeForfait] [char](2) NULL,
	[idRegion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Laboratoire]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Laboratoire](
	[idLabo] [int] IDENTITY(1,1) NOT NULL,
	[nomLabo] [char](20) NULL,
 CONSTRAINT [PK_Laboratoire] PRIMARY KEY CLUSTERED 
(
	[idLabo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LigneFraisForfait]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LigneFraisForfait](
	[idVisiteur] [char](3) NOT NULL,
	[mois] [char](6) NOT NULL,
	[annee] [int] NOT NULL,
	[idFraisForfait] [char](3) NOT NULL,
	[quantite] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVisiteur] ASC,
	[mois] ASC,
	[annee] ASC,
	[idFraisForfait] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LigneFraisHorsForfait]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LigneFraisHorsForfait](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVisiteur] [char](3) NOT NULL,
	[mois] [char](6) NOT NULL,
	[annee] [int] NOT NULL,
	[libelle] [varchar](100) NULL,
	[date] [date] NULL,
	[montant] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MEDECIN]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEDECIN](
	[idMedecin] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](30) NOT NULL,
	[prenom] [varchar](30) NOT NULL,
	[adresse] [varchar](80) NOT NULL,
	[tel] [varchar](15) NULL,
	[idSpecialite] [char](3) NULL,
	[departement] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedecin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[idMedicament] [char](12) NOT NULL,
	[nomCommercial] [varchar](64) NOT NULL,
	[idFamille] [char](3) NOT NULL,
	[composition] [varchar](256) NOT NULL,
	[effets] [varchar](256) NOT NULL,
	[contreIndications] [varchar](256) NOT NULL,
	[prix] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedicament] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOTIF]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOTIF](
	[idMotif] [int] IDENTITY(1,1) NOT NULL,
	[libMotif] [varchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMotif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OFFRIR]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OFFRIR](
	[idRapport] [int] NOT NULL,
	[idMedicament] [char](12) NOT NULL,
	[quantite] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRapport] ASC,
	[idMedicament] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RAPPORT]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RAPPORT](
	[idRapport] [int] IDENTITY(1,1) NOT NULL,
	[dateRapport] [date] NULL,
	[idMotif] [int] NULL,
	[bilan] [varchar](64) NULL,
	[idVisiteur] [char](3) NOT NULL,
	[idMedecin] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRapport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Region]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Region](
	[idRegion] [int] NOT NULL,
	[libRegion] [varchar](64) NULL,
	[idVisiteur] [char](3) NOT NULL,
	[idSecteur] [int] NOT NULL,
 CONSTRAINT [PK_REGION] PRIMARY KEY CLUSTERED 
(
	[idRegion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Secteur]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Secteur](
	[idSecteur] [int] NOT NULL,
	[libSecteur] [varchar](64) NULL,
	[idVisiteur] [char](3) NOT NULL,
 CONSTRAINT [PK_SECTEUR] PRIMARY KEY CLUSTERED 
(
	[idSecteur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPECIALITE]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPECIALITE](
	[idSpecialite] [char](3) NOT NULL,
	[libSpecialite] [varchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idSpecialite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Travailler]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Travailler](
	[idVisiteur] [char](3) NOT NULL,
	[idRegion] [int] NOT NULL,
 CONSTRAINT [PK_TRAVAILLER] PRIMARY KEY CLUSTERED 
(
	[idVisiteur] ASC,
	[idRegion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Visiteur]    Script Date: 18/12/2018 17:23:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Visiteur](
	[idVisiteur] [char](3) NOT NULL,
	[idLabo] [int] NOT NULL,
	[nom] [varchar](32) NULL,
	[prenom] [varchar](32) NULL,
	[rue] [varchar](64) NULL,
	[cp] [char](5) NULL,
	[ville] [varchar](64) NULL,
	[dateEmbauche] [char](10) NULL,
	[identifiant] [varchar](16) NOT NULL,
	[password] [varchar](128) NOT NULL,
 CONSTRAINT [PK_VISITEUR] PRIMARY KEY CLUSTERED 
(
	[idVisiteur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[fichefrais] ADD  DEFAULT (NULL) FOR [nbJustificatifs]
GO
ALTER TABLE [dbo].[fichefrais] ADD  DEFAULT (NULL) FOR [montantValide]
GO
ALTER TABLE [dbo].[fichefrais] ADD  DEFAULT (NULL) FOR [dateModif]
GO
ALTER TABLE [dbo].[fichefrais] ADD  DEFAULT ('CR') FOR [idEtat]
GO
ALTER TABLE [dbo].[LigneFraisForfait] ADD  DEFAULT (NULL) FOR [quantite]
GO
ALTER TABLE [dbo].[LigneFraisHorsForfait] ADD  DEFAULT (NULL) FOR [libelle]
GO
ALTER TABLE [dbo].[LigneFraisHorsForfait] ADD  DEFAULT (NULL) FOR [date]
GO
ALTER TABLE [dbo].[LigneFraisHorsForfait] ADD  DEFAULT (NULL) FOR [montant]
GO
ALTER TABLE [dbo].[fichefrais]  WITH CHECK ADD FOREIGN KEY([idEtat])
REFERENCES [dbo].[Etat] ([id])
GO
ALTER TABLE [dbo].[fichefrais]  WITH CHECK ADD FOREIGN KEY([idVisiteur])
REFERENCES [dbo].[Visiteur] ([idVisiteur])
GO
ALTER TABLE [dbo].[FraisForfait]  WITH CHECK ADD  CONSTRAINT [FK_RegionFraisForfait] FOREIGN KEY([idRegion])
REFERENCES [dbo].[Region] ([idRegion])
GO
ALTER TABLE [dbo].[FraisForfait] CHECK CONSTRAINT [FK_RegionFraisForfait]
GO
ALTER TABLE [dbo].[LigneFraisForfait]  WITH CHECK ADD FOREIGN KEY([idFraisForfait])
REFERENCES [dbo].[FraisForfait] ([id])
GO
ALTER TABLE [dbo].[LigneFraisForfait]  WITH CHECK ADD FOREIGN KEY([idVisiteur], [mois], [annee])
REFERENCES [dbo].[fichefrais] ([idVisiteur], [mois], [annee])
GO
ALTER TABLE [dbo].[LigneFraisHorsForfait]  WITH CHECK ADD FOREIGN KEY([idVisiteur], [mois], [annee])
REFERENCES [dbo].[fichefrais] ([idVisiteur], [mois], [annee])
GO
ALTER TABLE [dbo].[MEDECIN]  WITH CHECK ADD  CONSTRAINT [medecin_fk] FOREIGN KEY([idSpecialite])
REFERENCES [dbo].[SPECIALITE] ([idSpecialite])
GO
ALTER TABLE [dbo].[MEDECIN] CHECK CONSTRAINT [medecin_fk]
GO
ALTER TABLE [dbo].[MEDICAMENT]  WITH CHECK ADD  CONSTRAINT [medicament_fk] FOREIGN KEY([idFamille])
REFERENCES [dbo].[FAMILLE] ([idFamille])
GO
ALTER TABLE [dbo].[MEDICAMENT] CHECK CONSTRAINT [medicament_fk]
GO
ALTER TABLE [dbo].[OFFRIR]  WITH CHECK ADD  CONSTRAINT [offrir_fk1] FOREIGN KEY([idRapport])
REFERENCES [dbo].[RAPPORT] ([idRapport])
GO
ALTER TABLE [dbo].[OFFRIR] CHECK CONSTRAINT [offrir_fk1]
GO
ALTER TABLE [dbo].[OFFRIR]  WITH CHECK ADD  CONSTRAINT [offrir_fk2] FOREIGN KEY([idMedicament])
REFERENCES [dbo].[MEDICAMENT] ([idMedicament])
GO
ALTER TABLE [dbo].[OFFRIR] CHECK CONSTRAINT [offrir_fk2]
GO
ALTER TABLE [dbo].[RAPPORT]  WITH CHECK ADD  CONSTRAINT [rapport_fk1] FOREIGN KEY([idVisiteur])
REFERENCES [dbo].[Visiteur] ([idVisiteur])
GO
ALTER TABLE [dbo].[RAPPORT] CHECK CONSTRAINT [rapport_fk1]
GO
ALTER TABLE [dbo].[RAPPORT]  WITH CHECK ADD  CONSTRAINT [rapport_fk2] FOREIGN KEY([idMedecin])
REFERENCES [dbo].[MEDECIN] ([idMedecin])
GO
ALTER TABLE [dbo].[RAPPORT] CHECK CONSTRAINT [rapport_fk2]
GO
ALTER TABLE [dbo].[RAPPORT]  WITH CHECK ADD  CONSTRAINT [rapport_fk3] FOREIGN KEY([idMotif])
REFERENCES [dbo].[MOTIF] ([idMotif])
GO
ALTER TABLE [dbo].[RAPPORT] CHECK CONSTRAINT [rapport_fk3]
GO
ALTER TABLE [dbo].[Region]  WITH CHECK ADD  CONSTRAINT [FK_SECTEUR] FOREIGN KEY([idSecteur])
REFERENCES [dbo].[Secteur] ([idSecteur])
GO
ALTER TABLE [dbo].[Region] CHECK CONSTRAINT [FK_SECTEUR]
GO
ALTER TABLE [dbo].[Region]  WITH CHECK ADD  CONSTRAINT [FK_VISITEUR] FOREIGN KEY([idVisiteur])
REFERENCES [dbo].[Visiteur] ([idVisiteur])
GO
ALTER TABLE [dbo].[Region] CHECK CONSTRAINT [FK_VISITEUR]
GO
ALTER TABLE [dbo].[Secteur]  WITH CHECK ADD  CONSTRAINT [FK_VISITEURSECTEUR] FOREIGN KEY([idVisiteur])
REFERENCES [dbo].[Visiteur] ([idVisiteur])
GO
ALTER TABLE [dbo].[Secteur] CHECK CONSTRAINT [FK_VISITEURSECTEUR]
GO
ALTER TABLE [dbo].[Travailler]  WITH CHECK ADD  CONSTRAINT [FK_TRAVAILLER] FOREIGN KEY([idRegion])
REFERENCES [dbo].[Region] ([idRegion])
GO
ALTER TABLE [dbo].[Travailler] CHECK CONSTRAINT [FK_TRAVAILLER]
GO
ALTER TABLE [dbo].[Travailler]  WITH CHECK ADD  CONSTRAINT [FK_VISITEURTRAVAIL] FOREIGN KEY([idVisiteur])
REFERENCES [dbo].[Visiteur] ([idVisiteur])
GO
ALTER TABLE [dbo].[Travailler] CHECK CONSTRAINT [FK_VISITEURTRAVAIL]
GO
ALTER TABLE [dbo].[Visiteur]  WITH CHECK ADD  CONSTRAINT [FK_Laboratoire] FOREIGN KEY([idLabo])
REFERENCES [dbo].[Laboratoire] ([idLabo])
GO
ALTER TABLE [dbo].[Visiteur] CHECK CONSTRAINT [FK_Laboratoire]
GO
