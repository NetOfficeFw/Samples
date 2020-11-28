C:\Windows\SysWOW64\regsvr32.exe /s Net5Addin.comhost.dll

reg add "HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\NetOfficeSamples.Net5Addin" /f /v FriendlyName /t REG_SZ /d ".NET 5 Addin"
reg add "HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\NetOfficeSamples.Net5Addin" /f /v Description /t REG_SZ /d "Sample addin running in .NET 5."
reg add "HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\NetOfficeSamples.Net5Addin" /f /v LoadBehavior /t REG_DWORD /d 3
