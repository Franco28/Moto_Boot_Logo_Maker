@echo off

title clean-path-to-build
color d

echo.
echo.
echo clean-path-to-build
echo.

SET dirset86=Setup\

if exist "%dirset86%HtmlAgilityPack.pdb" (del /F "%dirset86%HtmlAgilityPack.pdb") else (echo File HtmlAgilityPack.pdb already removed) 
if exist "%dirset86%HtmlAgilityPack.xml" (del /F "%dirset86%HtmlAgilityPack.xml") else (echo File HtmlAgilityPack.xml already removed) 
if exist "%dirset86%Newtonsoft.Json.xml" (del /F "%dirset86%Newtonsoft.Json.xml") else (echo File Newtonsoft.Json.xml already removed) 

if exist "%dirset86%Moto_Boot_Logo_Maker.application" (del /F "%dirset86%Moto_Boot_Logo_Maker.application") else (echo File Moto_Boot_Logo_Maker.application already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.exe.manifest" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe.manifest") else (echo File Moto_Boot_Logo_Maker.exe.manifest already removed) 
pause>nul