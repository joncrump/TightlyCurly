ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [SQL2008_724869_tcadmin_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)_1.ldf', MAXSIZE = 1024000 KB, FILEGROWTH = 10 %);

