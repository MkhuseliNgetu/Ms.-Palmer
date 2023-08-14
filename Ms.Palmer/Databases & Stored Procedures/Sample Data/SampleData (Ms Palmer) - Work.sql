USE VirtualMachineConfigurations; 

//Sample Data
//Work, 30GB, No-Guest-Additions.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

//Work, 30GB, Guest-Additions-Present.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 30720,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

//Work, 60GB, No-Guest-Additions.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

//Work, 60GB, Guest-Additions-Present.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 61440,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

//Work, 90GB, No-Guest-Additions.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

//Work, 90GB, Guest-Additions-Present.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 92160,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

//Work, 120GB, No-Guest-Additions.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

//Work, 120GB, Guest-Additions-Present.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 122880,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

//Work, 256GB, No-Guest-Additions.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 0;

//Work, 256GB, Guest-Additions-Present.
EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Windows 10',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Ubuntu',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Fedora',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Pop OS',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;

EXEC @AddConfig 
@UseCase = 'Work',
@OperatingSystem = 'Linux Mint',
@Size = 262144,
@OperatingSystemLicense = 'N/A',
@GuestAdditions = 1;
