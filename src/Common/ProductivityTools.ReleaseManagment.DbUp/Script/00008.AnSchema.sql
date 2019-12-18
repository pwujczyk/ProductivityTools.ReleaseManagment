 IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'AngryNerds')
                            BEGIN
                            EXEC('CREATE SCHEMA AngryNerds')
                            END