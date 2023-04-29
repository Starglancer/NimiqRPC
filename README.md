# Nimiq RPC

## Description

A Windows Forms based gui for the Nimiq client RPC calls

## Screenshots

## Features

 - Will work with both local and remote Nimiq clients
 - Heartbeat check every 10 seconds to ensure client is still running
 - Tray icon for running in the background to monitor status
 - Display details of blocks, peers, transactions and mining status
 - control mining parameters and client logging level
 - DOES NOT create transactions by design. Please use the standard Nimiq web wallet for that purpose
 
## Requirements

 - Network connection to the internet
 - No inbound ports need to be opened
 - Microsoft Windows operating system (I have tested on Windows 10 only)
 - Dot Net Framework 4.7.2. This will be installed at deployment time if not already present
 
## To Do List

- Fix any bugs identified by users
- Make enhancements identified by users
 
## Acknowledgements

- Thanks to rraallvv for his [NimiqClientSharp](https://github.com/rraallvv/NimiqClientSharp) wrapper used in this project
- Thanks to [Advanced Installer](https://www.advancedinstaller.com/) for their excellent installer which has been used from release 1.00 onwards
