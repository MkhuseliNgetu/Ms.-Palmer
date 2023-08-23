USE VirtualMachineConfigurations; 
GO
--Sample Data
--Gaming, 30GB, No-Guest-Additions.
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Gaming, 30GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Gaming, 60GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Gaming, 60GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Gaming, 90GB, No-Guest-Additions.
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Gaming, 90GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Gaming, 120GB, No-Guest-Additions.
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Gaming, 120GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Gaming, 256GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Gaming, 256GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Windows 10',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Ubuntu',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Fedora',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Pop OS',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Gaming',
@OperatingSystem = 'Linux Mint',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
