; -- Moto_Boot_Logo_Maker-Installer.iss \ Copyright © 2020 - 2021 MOD @Franco28 --
; -- This is only for Moto_Boot_Logo_Maker - Motorola Moto Devices  --

#define MyAppName "Moto_Boot_Logo_Maker"
#define MyAppName2 "Moto_Boot_Logo_Maker_v"
#define MyInstallerSuffix "_Setup"
#define MyAppVersion "4.4.4.1"
#define MyAppPublisher "A .NET Tool to make and build Moto Boot Logos(4MiB, 6MiB, 8MiB, 16MiB & 32MiB)"
#define MyAppURL "https://github.com/Franco28/Moto_Boot_Logo_Maker"
#define MyAppExeName "Moto_Boot_Logo_Maker.exe"
#define MyAppDate "2021-04-28"

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
CompressionThreads=8
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
// Portable
en.PortableOptionTitle=Installation Type
en.PortableOptionSubTitle=Select Installation Option
en.PortableOptionAsk=Where would you like to install this program?
en.PortableOptionC=Normal C:\ Installation
en.PortableOptionPortable=Portable Edition (This will be extracted in Desktop)
es.PortableOptionTitle=Tipo de instalación
es.PortableOptionSubTitle=Seleccione la opción de instalación
es.PortableOptionAsk=¿Dónde le gustaría instalar este programa?
es.PortableOptionC=Instalación Normal en carpeta C:\
es.PortableOptionPortable=Edición portátil (esto se extraerá en el escritorio)      
pt.PortableOptionTitle=Tipo de Instalação
pt.PortableOptionSubTitle=Selecione a opção de instalação
pt.PortableOptionAsk=Onde você gostaria de instalar este programa?
pt.PortableOptionC=Normal C:\ Instalação
pt.PortableOptionPortable=Edição portátil (será extraído no desktop)
pl.PortableOptionTitle=Typ instalacji
pl.PortableOptionSubTitle=Wybierz opcję instalacji
pl.PortableOptionAsk=Gdzie chcesz zainstalować ten program?
pl.PortableOptionC=Normalny C:\ Instalacja
pl.PortableOptionPortable=Wersja przenośna (zostanie wyodrębniona na pulpicie)
it.PortableOptionTitle=Tipo di installazione
it.PortableOptionSubTitle=Seleziona l'opzione di installazione
it.PortableOptionAsk=Dove vorresti installare questo programma?
it.PortableOptionC=C:\ Installazione normale
it.PortableOptionPortable=Edizione portatile (verrà estratta nel desktop)
fr.PortableOptionTitle=Type d'installation
fr.PortableOptionSubTitle=Sélectionnez l'option d'installation
fr.PortableOptionAsk=Où souhaitez-vous installer ce programme?
fr.PortableOptionC=Normal C:\ Installation
fr.PortableOptionPortable=Édition portable (cela sera extrait dans le bureau)
ru.PortableOptionTitle=Тип установки
ru.PortableOptionSubTitle=Выберите вариант установки
ru.PortableOptionAsk=Куда бы вы хотели установить эту программу?
ru.PortableOptionC=Обычный C:\ Установка
ru.PortableOptionPortable=Portable Edition (будет извлечен в Desktop)
tr.PortableOptionTitle=Kurulum Türü
tr.PortableOptionSubTitle=Kurulum Seçeneğini Seçin
tr.PortableOptionAsk=Bu programı nereye kurmak istersiniz?
tr.PortableOptionC=Normal C:\ Kurulum
tr.PortableOptionPortable=Portable Edition (Bu, Masaüstünde çıkarılacaktır)
de.PortableOptionTitle=Installationstyp
de.PortableOptionSubTitle=Wählen Sie Installationsoption
de.PortableOptionAsk=Wo möchten Sie dieses Programm installieren?
de.PortableOptionC=Normal C:\ Installation
de.PortableOptionPortable=Portable Edition (Dies wird in Desktop extrahiert)
ja.PortableOptionTitle=インストールタイプ
ja.PortableOptionSubTitle=インストールオプションを選択します
ja.PortableOptionAsk=このプログラムをどこにインストールしますか？
ja.PortableOptionC=通常のC:\インストール
ja.PortableOptionPortable=Portable Edition（これはデスクトップで抽出されます）

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}";

#define VCLStylesSkinPath "{localappdata}\VCLStylesSkin"
[Files]     
Source: "..\SetupTheme\VclStylesinno.dll"; DestDir: {#VCLStylesSkinPath}; Flags: uninsneveruninstall
Source: "..\SetupTheme\Glossy.vsf"; DestDir: {#VCLStylesSkinPath}; Flags: uninsneveruninstall 
Source: "..\SetupTheme\VclStylesinno.dll"; DestDir: "{app}"; Flags: dontcopy
Source: "..\SetupTheme\Glossy.vsf"; DestDir: "{app}"; Flags: dontcopy
Source: "Moto_Boot_Logo_Maker.exe"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "Moto_Boot_Logo_Maker.exe.config"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs   
Source: "AndroidLib.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "HtmlAgilityPack.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs   
Source: "DarkUI.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs  
Source: "LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "credits.txt"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "Files"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "Files/*"; DestDir: "{app}/Files/"; Flags: ignoreversion recursesubdirs createallsubdirs    

[Icons]
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}";
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"; IconFilename: "{app}\Files\Images\Logo\unins.ico";
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Comment: "{#MyAppPublisher}"; Tasks: desktopicon;

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, "&", "&&")}}"; Flags: shellexec nowait postinstall skipifsilent;

[InstallDelete]
Type: filesandordirs; Name: "{app}\Files";
Type: files; Name: "{app}\License";
Type: files; Name: "{app}\*.dll"; 
Type: files; Name: "{app}\*.txt";
Type: files; Name: "{app}\Moto_Boot_Logo_Maker.exe.config";
Name: ExpandConstant('{localappdata}\Temp\{#MyAppName2}{#MyAppVersion}{#MyInstallerSuffix}'; Type: filesandordirs;  
Name: ExpandConstant('{localappdata}\Franco28\*'; Type: filesandordirs;  
Name: ExpandConstant('{localappdata}\Franco28'; Type: filesandordirs;  

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
            DelTree(ExpandConstant('{app}\Settings'), True, True, True);
            DelTree(ExpandConstant('{app}\Logs'), True, True, True);
            DelTree(ExpandConstant('{app}'), True, True, True);
            DelTree(ExpandConstant('C:\adb'), True, True, True);  
            DelTree(ExpandConstant('C:\NewMotoLogo'), True, True, True);
        end;
  end;
end;   

// Visual Style   

// Import the LoadVCLStyle function from VclStylesInno.DLL
procedure LoadVCLStyle(VClStyleFile: String); external 'LoadVCLStyleW@files:VclStylesInno.dll stdcall setuponly';
procedure LoadVCLStyle_UnInstall(VClStyleFile: String); external 'LoadVCLStyleW@{#VCLStylesSkinPath}\VclStylesInno.dll stdcall uninstallonly';
// Import the UnLoadVCLStyles function from VclStylesInno.DLL
procedure UnLoadVCLStyles; external 'UnLoadVCLStyles@files:VclStylesInno.dll stdcall setuponly';
procedure UnLoadVCLStyles_UnInstall; external 'UnLoadVCLStyles@{#VCLStylesSkinPath}\VclStylesInno.dll stdcall uninstallonly';

function InitializeSetup(): Boolean;
begin
 ExtractTemporaryFile('Glossy.vsf');
 LoadVCLStyle(ExpandConstant('{tmp}\Glossy.vsf'));
 Result := True;
end;

procedure DeinitializeSetup();
begin
	UnLoadVCLStyles;
end;

function InitializeUninstall: Boolean;
begin
  Result := True;
  LoadVCLStyle_UnInstall(ExpandConstant('{#VCLStylesSkinPath}\Glossy.vsf'));
end;

procedure DeinitializeUninstall();
begin
  UnLoadVCLStyles_UnInstall;
end;