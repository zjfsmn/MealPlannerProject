--use MealPlannerDB
--

--drop table dbo.PhysicalProfile
--drop table dbo.[User]
--drop table dbo.[DietProfile] 


CREATE TABLE [dbo].[User] (
    [UserName] NVARCHAR (50) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserName] ASC)
);


CREATE TABLE [dbo].[PhysicalProfile] (
    [DoOption]          INT           NOT NULL,
    [Gender]            INT           NOT NULL,
    [Height]            FLOAT (53)    NOT NULL,
    [Weight]            FLOAT (53)    NOT NULL,
    [Age]               INT           NOT NULL,
    [ActivityLevel]     INT           NOT NULL,
    [FinalWeight]       FLOAT (53)    NULL,
    [DaysToGo]          INT           NULL,
    [UserName]          NVARCHAR (50) NOT NULL,
    [BMI]               FLOAT (53)    NULL,
    [SuggestedCalories] INT           NULL,
    CONSTRAINT [PK_PhysicalProfile] PRIMARY KEY CLUSTERED ([UserName] ASC),
    CONSTRAINT [FK_PhysicalProfile] FOREIGN KEY ([UserName]) REFERENCES [dbo].[User] ([UserName])
);

CREATE TABLE [dbo].[DietProfile] (
    [UserName]   NVARCHAR (50) NOT NULL,
    [DietChoice] INT           NOT NULL,
    [Gluten]     BIT           DEFAULT ((0)) NOT NULL,
    [Peanut]     BIT           DEFAULT ((0)) NOT NULL,
    [Eggs]       BIT           DEFAULT ((0)) NOT NULL,
    [Dairy]      BIT           DEFAULT ((0)) NOT NULL,
    [Soy]        BIT           DEFAULT ((0)) NOT NULL,
    [Onion]      BIT           DEFAULT ((0)) NOT NULL,
    [Nuts]       BIT           DEFAULT ((0)) NOT NULL,
    [Seafood]    BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserName] ASC),
    CONSTRAINT [FK_DietProfile_ToTable] FOREIGN KEY ([UserName]) REFERENCES [dbo].[User] ([UserName])
);



