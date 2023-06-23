CREATE PROCEDURE AddConfig(
@UseCase VARCHAR (10) = '',
@OperatingSystem VARCHAR (15) = '',
@Size INT = '',
@OperatingSystemLicense VARCHAR (30) = '',
@GuestAdditions BIT = ''
)
AS
BEGIN

INSERT INTO VMConfigurations
VALUES (@UseCase, @OperatingSystem, @Size, @OperatingSystemLicense, @GuestAdditions);

END