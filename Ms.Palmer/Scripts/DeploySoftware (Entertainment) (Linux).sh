#!/bin/bash

# The Purpose of this script is install software based on the user-specified use case of the virtual machine.
InstallScript='~/Ms.Palmer/bin/Debug/PalmerInstallScript.txt'
MainUser="$(id -nu)"

if [[ "${MainUser}" -eq 0 ]]
then 
	echo 'This script cannot be run as root. Please re-run the script as a non-root user'
fi

#Checking if the file is not empty
if [[ "{InstallScript}" -ne 0 ]]
then
	#Adding Flathub --for convinence 
	flatpak remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrep
	#Spotify - for music streaming
	flatpak install -y --noninteractive flathub com.spotify.Client
	#Plex - video streaming
	flatpak install -y --noninteractive flathub tv.plex.PlexDesktop
	#Bottles - local video playback
	flatpak install -y --noninteractive flathub org.videolan.VLC
	#Flatseal - For editing flatpak files & permissions
	flatpak install -y --noninteractive flathub com.github.tchx84.Flatseal
	#User Interaction
	echo 'Installing, Please wait....'
	
fi

#Check if the script has excuted successfully
if [[ "${?}" -eq 0 ]]
then 
	echo 'Software was deployed succesfully'
elif [[ "${?}" - ge 1 ]]
then 
	echo 'Software was noit deployed succesfully'
fi
