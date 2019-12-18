 IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'general')
                            BEGIN
                            EXEC('CREATE SCHEMA general')
                            END