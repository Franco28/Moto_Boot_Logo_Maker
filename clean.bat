@echo off

title Clean Before Merge
color d

echo.
echo.
echo Clean Build Path
echo.

SET dirt86=Moto_Logo\
SET dirset86=Setup\
SET dirtFileManager=0.Password-Encrypt.Decrypt\

if exist "%dirt86%obj" (@RD /S /Q "%dirt86%obj") else (echo Folder %dirt86%obj already removed) 
if exist "%dirt86%bin" (@RD /S /Q "%dirt86%bin") else (echo Folder %dirt86%bin already removed) 
if exist "%dirset86%app.publish\Moto_Boot_Logo_Maker.exe" (del /F "%dirset86%app.publish\Moto_Boot_Logo_Maker.exe") else (echo File app.publish\Moto_Boot_Logo_Maker.exe already removed) 
if exist "%dirt86%app.publish" (@RD /S /Q "%dirt86%app.publish") else (echo Folder %dirt86%app.publish already removed) 

if exist "%dirtFileManager%obj" (@RD /S /Q "%dirtFileManager%obj") else (echo Folder %dirtFileManager%obj already removed) 
if exist "%dirtFileManager%bin" (@RD /S /Q "%dirtFileManager%bin") else (echo Folder %dirtFileManager%bin already removed) 

if exist "%dirset86%HtmlAgilityPack.pdb" (del /F "%dirset86%HtmlAgilityPack.pdb") else (echo File HtmlAgilityPack.pdb already removed) 
if exist "%dirset86%HtmlAgilityPack.xml" (del /F "%dirset86%HtmlAgilityPack.xml") else (echo File HtmlAgilityPack.xml already removed) 
if exist "%dirset86%System.Buffers.xml" (del /F "%dirset86%System.Buffers.xml") else (echo File System.Buffers.xml already removed) 
if exist "%dirset86%System.Memory.xml" (del /F "%dirset86%System.Memory.xml") else (echo File System.Memory.xml already removed) 
if exist "%dirset86%System.Numerics.Vectors.xml" (del /F "%dirset86%System.Numerics.Vectors.xml") else (echo File System.Numerics.Vectors.xml already removed) 
if exist "%dirset86%System.Runtime.CompilerServices.Unsafe.xml" (del /F "%dirset86%System.Runtime.CompilerServices.Unsafe.xml") else (echo File System.Runtime.CompilerServices.Unsafe.xml already removed) 

if exist "%dirset86%Moto_Boot_Logo_Maker.exe" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe") else (echo File Moto_Boot_Logo_Maker.exe already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.exe.config" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe.config") else (echo File Moto_Boot_Logo_Maker.exe.config already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.application" (del /F "%dirset86%Moto_Boot_Logo_Maker.application") else (echo File Moto_Boot_Logo_Maker.application already removed) 
if exist "%dirset86%Moto_Boot_Logo_Maker.exe.manifest" (del /F "%dirset86%Moto_Boot_Logo_Maker.exe.manifest") else (echo File Moto_Boot_Logo_Maker.exe.manifest already removed) 
pause>nul