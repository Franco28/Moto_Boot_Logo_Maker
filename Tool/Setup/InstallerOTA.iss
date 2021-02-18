﻿; -- Moto_Boot_Logo_Maker-Installer.iss \ Copyright © 2020 - 2021 MOD @Franco28 --
; -- This is only for Moto_Boot_Logo_Maker - Motorola Moto Devices  --

#define MyAppName "Moto_Boot_Logo_Maker"
#define MyAppName2 "MBLM_v"
#define MyInstallerSuffix "_OTA"
#define MyAppVersion "4.4.3.1"
#define MyAppPublisher "A .NET Tool to make and build Moto Boot Logos(4MiB, 6MiB, 8MiB, 16MiB & 32MiB)"
#define MyAppURL "https://github.com/Franco28/Moto_Boot_Logo_Maker"
#define MyAppExeName "Moto_Boot_Logo_Maker.exe"
#define MyAppDate "2021-02-18"

[Setup]
PrivilegesRequired=admin    
AppId={{7F2206C5-C746-41C6-BDC0-2B8E1EB9C8E3}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppComments={#MyAppPublisher}
AppPublisher=Franco28
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
ChangesAssociations=yes
DefaultDirName={sd}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableDirPage=yes
AppReadmeFile=https://github.com/Franco28/Moto_Boot_Logo_Maker#getting-started-read-all-please
AllowNoIcons=yes
ArchitecturesAllowed=x86 x64
OutputBaseFilename={#MyAppName2}{#MyAppVersion}{#MyInstallerSuffix}
Compression=lzma2/ultra64
InternalCompressLevel=ultra
CompressionThreads=4
WizardImageStretch=True
AppContact=Support
AppCopyright=Copyright © 2020 - 2021 MOD by @Franco28
UninstallDisplayIcon={app}\Files\Images\Logo\main_icon.ico
SetupIconFile=Files\Images\Logo\main_icon.ico
TouchDate={#MyAppDate}
UserInfoPage=no
WizardStyle=modern
InfoBeforeFile=changelog.txt
OutputDir=C:\Users\Franco28\Documents\GitHub\Moto_Boot_Logo_Maker
UninstallDisplayName={#MyAppName}
VersionInfoVersion={#MyAppVersion}
TimeStampsInUTC=yes 
LicenseFile=LICENSE.txt

[Languages]
Name: en; MessagesFile: "compiler:Default.isl"
Name: es; MessagesFile: "compiler:Languages\Spanish.isl"
Name: pt; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: pl; MessagesFile: "compiler:Languages\Polish.isl"
Name: it; MessagesFile: "compiler:Languages\Italian.isl"
Name: fr; MessagesFile: "compiler:Languages\French.isl"
Name: ru; MessagesFile: "compiler:Languages\Russian.isl"
Name: tr; MessagesFile: "compiler:Languages\Turkish.isl"
Name: de; MessagesFile: "compiler:Languages\German.isl"  
Name: ja; MessagesFile: "compiler:Languages\Japanese.isl"

[Messages]
en.BeveledLabel={#MyAppName} v{#MyAppVersion} - English
es.BeveledLabel={#MyAppName} v{#MyAppVersion} - Español
pt.BeveledLabel={#MyAppName} v{#MyAppVersion} - Português
pl.BeveledLabel={#MyAppName} v{#MyAppVersion} - Polskie
it.BeveledLabel={#MyAppName} v{#MyAppVersion} - Italiano
fr.BeveledLabel={#MyAppName} v{#MyAppVersion} - Français
ru.BeveledLabel={#MyAppName} v{#MyAppVersion} - Pусский
tr.BeveledLabel={#MyAppName} v{#MyAppVersion} - Türk
de.BeveledLabel={#MyAppName} v{#MyAppVersion} - Deutsche   
ja.BeveledLabel={#MyAppName} v{#MyAppVersion} - 日本人

[CustomMessages]
en.RemoveToolSettings=Do you want to remove all Moto_Boot_Logo_Maker settings?
es.RemoveToolSettings=¿Quieres remover toda la configuración de Moto_Boot_Logo_Maker?
pt.RemoveToolSettings=Quer remover todas as configurações do Moto_Boot_Logo_Maker?
pl.RemoveToolSettings=Czy chcesz usunąć wszystkie ustawienia Moto_Boot_Logo_Maker?
it.RemoveToolSettings=Vuoi rimuovere tutte le impostazioni Moto_Boot_Logo_Maker?
fr.RemoveToolSettings=Voulez-vous supprimer tous les paramètres Moto_Boot_Logo_Maker?
ru.RemoveToolSettings=Вы хотите удалить все настройки Moto_Boot_Logo_Maker?
tr.RemoveToolSettings=Tüm Moto_Boot_Logo_Maker ayarlarını kaldırmak istiyor musunuz?
de.RemoveToolSettings=Möchten Sie alle Moto_Boot_Logo_Maker-Einstellungen entfernen?     
ja.RemoveToolSettings=Moto_Boot_Logo_Maker設定をすべて削除しますか？

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}";

[Files]     
Source: "Moto_Boot_Logo_Maker.exe"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "Moto_Boot_Logo_Maker.exe.config"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs   
Source: "LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}";
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"; IconFilename: "{app}\Files\Images\Logo\unins.ico";
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Comment: "{#MyAppPublisher}"; Tasks: desktopicon;

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, "&", "&&")}}"; Flags: shellexec nowait postinstall skipifsilent;

[InstallDelete]
Type: files; Name: "{app}\License";
Type: files; Name: "{app}\change.txt";
Type: files; Name: "{app}\Moto_Boot_Logo_Maker.exe.config";
Name: ExpandConstant('{localappdata}\Franco28\*'; Type: filesandordirs;  
Name: ExpandConstant('{localappdata}\Franco28'; Type: filesandordirs;  
Name: ExpandConstant('{localappdata}\Temp\{#MyAppName2}{#MyAppVersion}{#MyInstallerSuffix}'; Type: filesandordirs;  

[UninstallDelete]
Type: filesandordirs; Name: "{app}\Files";
Type: files; Name: "{app}\*.dll";
Type: files; Name: "{app}\*.txt";

[Registry]
Root: "HKLM"; Subkey: "SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"; \
    ValueType: String; ValueName: "{app}\{#MyAppExeName}"; ValueData: "RUNASADMIN"; \
    Flags: uninsdeletekeyifempty uninsdeletevalue      

[Code]
procedure CurUninstallStepChanged (CurUninstallStep: TUninstallStep);
begin
   case CurUninstallStep of                   
     usPostUninstall:
       begin
         if MsgBox(ExpandConstant('{cm:RemoveToolSettings}'), mbConfirmation, MB_YESNO) = IDYES then      
            DelTree(ExpandConstant('{localappdata}\Franco28'), True, True, True);
            DelTree(ExpandConstant('C:\adb'), True, True, True);  
            DelTree(ExpandConstant('C:\NewMotoLogo'), True, True, True);
        end;
  end;
end;   