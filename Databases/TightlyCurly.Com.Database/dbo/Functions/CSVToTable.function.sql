
CREATE FUNCTION [dbo].[CSVToTable] ( @stringInput VARCHAR(8000) )
RETURNS @OutputTable TABLE ( [Value] VARCHAR(100) )
AS
BEGIN

    DECLARE @String    VARCHAR(100)

    WHILE LEN(@StringInput) > 0
    BEGIN
        SET @String      = LEFT(@StringInput, 
                                ISNULL(NULLIF(CHARINDEX(',', @StringInput) - 1, -1),
                                LEN(@StringInput)))
        SET @StringInput = SUBSTRING(@StringInput,
                                     ISNULL(NULLIF(CHARINDEX(',', @StringInput), 0),
                                     LEN(@StringInput)) + 1, LEN(@StringInput))

        INSERT INTO @OutputTable ( [Value] )
        VALUES ( @String )
    END
    
    RETURN
END
