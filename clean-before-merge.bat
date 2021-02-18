@echo off

title clean-before-merge
color d

echo.
echo.
echo clean-before-merge
echo.

SET dirt86=Tool\Moto_Logo\
SET dirset86=Tool\Setup\

if exist "%dirt86%obj" (@RD /S /Q "%dirt86%obj") else (echo Folder %dirt86%obj already removed) 
if exist "%dirt86%bin" (@RD /S /Q "%dirt86%bin") else (echo Folder %dirt86%bin already removed) 
if exist "%dirset86%app.publish\Moto_Boot_Logo_Maker.exe" (del /F "%dirset86%app.publish\Moto_Boot_Logo_Maker.exe") else (echo File app.publish\Moto_Boot_Logo_Maker.exe already removed) 
if exist "%dirt86%app.publish" (@RD /S /Q "%dirt86%app.publish") else (echo Folder %dirt86%app.publish already removed) 

if exist "%dirset86%HtmlAgilityPack.pdb" (del /F "%dirset86%HtmlAgilityPack.pdb") else (echo File HtmlAgilityPack.pdb already removed) 
if exist "%dirset86%HtmlAgilityPack.xml" (del /F "%dirset86%HtmlAgilityPack.xml") else (echo File HtmlAgilityPack.xml already removed) 

if exist "%dirset86%Moto_Boot_Logo_Maker.exe" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe") else (echo File Moto_Boot_Logo_Maker.exe already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.exe.config" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe.config") else (echo File Moto_Boot_Logo_Maker.exe.config already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.application" (del /F "%dirset86%Moto_Boot_Logo_Maker.application") else (echo File Moto_Boot_Logo_Maker.application already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.exe.manifest" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe.manifest") else (echo File Moto_Boot_Logo_Maker.exe.manifest already removed) 
pause>nul