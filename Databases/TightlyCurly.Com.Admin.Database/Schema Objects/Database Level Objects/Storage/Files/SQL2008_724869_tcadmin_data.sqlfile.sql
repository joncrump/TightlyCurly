ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [SQL2008_724869_tcadmin_data], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', MAXSIZE = 512000 KB, FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

