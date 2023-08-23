USE VirtualMachineConfigurations; 
GO
--Sample Data
--Entertainment, 30GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Entertainment, 30GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Entertainment, 60GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Entertainment, 60GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Entertainment, 90GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Entertainment, 90GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig 
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Entertainment, 120GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Entertainment, 120GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
--Entertainment, 256GB, No-Guest-Additions.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;
GO
--Entertainment, 256GB, Guest-Additions-Present.
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Windows 10',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Ubuntu',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Fedora',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Pop OS',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
GO
EXEC VirtualMachineConfigurations.dbo.AddConfig
@UseCase = 'Entertainment',
@OperatingSystem = 'Linux Mint',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
