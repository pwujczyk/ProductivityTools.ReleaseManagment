 IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'common')
                            BEGIN
                            EXEC('CREATE SCHEMA common')
                            END