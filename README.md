# TrollCLM
Combined https://github.com/calebstewart/bypass-clm and reflection technique from https://github.com/cybersectroll/TrollAMSI
- Bypass Applocker
- Bypass CLM\
  
This will spawn **interactive** powershell session within your cmd/powershell that runs InstallUtil.exe hence no need for PS runspace
# Compile
- Release, x64, ConsoleApplication 
- Add reference to Microsoft.PowerShell.ConsoleHost.dll & System.Configuration & System.Configuration.Install

# Usage 
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe /logfile= /LogToConsole=false /U "C:\<path>\TrollCLM.exe"
