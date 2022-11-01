-- Database name "CharacterGenerator"
-- Create database and run this T-SQL query:


USE "CharacterGenerator";

DROP TABLE IF EXISTS "Characters";

CREATE TABLE [dbo].[Characters] (
    [Id]             INT IDENTITY (1, 1) NOT NULL,
    [LifePhaseId]    INT NULL,
    [MainTraitId]    INT NULL,
    [MainStrengthId] INT NULL,
    [MainFlawId]     INT NULL,
    [GoalId]         INT NULL,
    [SecretId]       INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

DROP TABLE IF EXISTS "Goal";

CREATE TABLE [dbo].[Goal] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Goal] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT "Goal" ON;

INSERT INTO "Goal" ("Id", "Goal") VALUES
(1,'Find Love'),
(2, 'Exact Revenge'),
(3, 'Discover Their Past'),
(4, 'Achieve Power'),
(5, 'Get Rich'),
(6, 'Be Accepted'),
(7, 'Find Their True Self'),
(8, 'Enjoy Life'),
(9, 'Leave A Legacy');

SET IDENTITY_INSERT "Goal" OFF;

DROP TABLE IF EXISTS "LifePhase";
CREATE TABLE [dbo].[LifePhase] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [LifePhase] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT "LifePhase" ON;
INSERT INTO "LifePhase" ("Id", "LifePhase") VALUES
(1, 'Teenager'),
(2, 'Student'),
(3, 'Part-Time Worker'),
(4, 'Full-Time Worker'),
(5, 'Stay-At-Home Parent'),
(6, 'Elderly Worker'),
(7, 'Retired');

SET IDENTITY_INSERT "LifePhase" OFF;

DROP TABLE IF EXISTS "MainFlaw";
CREATE TABLE [dbo].[MainFlaw] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [MainFlaw] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT "MainFlaw" ON;
INSERT INTO "MainFlaw" ("Id", "MainFlaw") VALUES
(1, 'Cowardice'),
(2, 'Short Temper'),
(3, 'Physical Weakness'),
(4, 'Compulsive Lying'),
(5, 'Hubris'),
(6, 'Gullibility'),
(7, 'Outdated Worldview'),
(8, 'Hatefulness');

SET IDENTITY_INSERT "MainFlaw" OFF;

DROP TABLE IF EXISTS "MainStrength";

CREATE TABLE [dbo].[MainStrength] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [MainStrength] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT "MainStrength" ON;
INSERT INTO "MainStrength" ("Id", "MainStrength") VALUES
(1, 'Courage'),
(2, 'Charisma'),
(3, 'Connections'),
(4, 'Tenacity'),
(5, 'General Likeability'),
(6, 'Creativity'),
(7, 'Street Smarts'),
(8, 'Intelligence');

SET IDENTITY_INSERT "MainStrength" OFF;

DROP TABLE IF EXISTS "MainTrait";

CREATE TABLE [dbo].[MainTrait] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [MainTrait] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT "MainTrait" ON;
INSERT INTO "MainTrait" ("Id", "MainTrait") VALUES
(1, 'Joyful'),
(2, 'Melancholic'),
(3, 'Sensitive'),
(4, 'Humorous'),
(5, 'Serious'),
(6, 'Ambitious'),
(7, 'Laid-Back');
SET IDENTITY_INSERT "MainTrait" OFF;

DROP TABLE IF EXISTS "Secret";

CREATE TABLE [dbo].[Secret] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Secret] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT "Secret" ON;
INSERT INTO "Secret" ("Id", "Secret") VALUES
(1, 'Progressing Illness'),
(2, 'Kleptomania'),
(3, 'Impostor Syndome'),
(4, 'Criminal Background'),
(5, 'History of Abuse'),
(6, 'Double Life'),
(7, 'Massive Debt'),
(8, 'Addiction');
SET IDENTITY_INSERT "Secret" OFF;

ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_ToGoal] FOREIGN KEY([GoalId])
REFERENCES [dbo].[Goal] ([Id]);
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_ToGoal];
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_ToLifePhase] FOREIGN KEY([LifePhaseId])
REFERENCES [dbo].[LifePhase] ([Id]);
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_ToLifePhase];
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_ToMainFlaw] FOREIGN KEY([MainFlawId])
REFERENCES [dbo].[MainFlaw] ([Id]);
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_ToMainFlaw];
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_ToMainStrength] FOREIGN KEY([MainStrengthId])
REFERENCES [dbo].[MainStrength] ([Id]);
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_ToMainStrength];
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_ToMainTrait] FOREIGN KEY([MainTraitId])
REFERENCES [dbo].[MainTrait] ([Id]);
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_ToMainTrait];
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_ToSecret] FOREIGN KEY([SecretId])
REFERENCES [dbo].[Secret] ([Id]);
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_ToSecret];
