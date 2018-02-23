USE [LCASP]
GO
ALTER TABLE archer_data ADD dtStamp DATETIME NULL;
GO
UPDATE lcasp_version set database_version = 16;
GO

