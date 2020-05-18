CREATE TABLE Users
(
    Id INT NOT NULL IDENTITY(1, 1),
    FirstName VARCHAR(255),
    LastName VARCHAR(255)
)

INSERT INTO dbo.Users
VALUES
    ('Bartłomiej', 'Glac'),
    ('Jakub', 'Sikora');

SELECT [FirstName], [LastName]
FROM dbo.[Users]
WHERE Id=2;