
@echo off
echo Waiting for file handle to be closed ...
ping 127.0.0.1 -n 5 -w 1000 > NUL
move /Y "E:\Users\brend\Documents\Visual Studio 2017\Projects\PrimalMediaManager\MinimalManager\youtube-dl.exe.new" "E:\Users\brend\Documents\Visual Studio 2017\Projects\PrimalMediaManager\MinimalManager\youtube-dl.exe" > NUL
echo Updated youtube-dl to version 2019.07.14.
start /b "" cmd /c del "%~f0"&exit /b"
                
