C:\Windows\SysWOW64\regsvr32.exe /s NetCore3Addin.comhost.dll

reg add "HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\NetOfficeSamples.NetCore3Addin" /f /v FriendlyName /t REG_SZ /d ".NET Core 3.1 Addin"
reg add "HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\NetOfficeSamples.NetCore3Addin" /f /v Description /t REG_SZ /d "Sample addin running in .NET Core 3.1."
reg add "HKEY_CURRENT_USER\Software\Microsoft\Office\Word\Addins\NetOfficeSamples.NetCore3Addin" /f /v LoadBehavior /t REG_DWORD /d 3
