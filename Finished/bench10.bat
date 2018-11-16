@echo off
@setlocal

::All Global Variables


set start=%time%

::Checks whether the benchmark is done
set benchnum=1
set benchcomp=0
set limit=10
set numlimit=1073741824

:benchloopstart
if %benchcomp% lss %limit% (goto :benchloop1)
goto :finish
:benchloop1
if %benchnum% == %numlimit% (goto :benchloop3)
goto :benchloop2
:benchloop2
set /a benchnum = %benchnum% * 2
echo %benchnum%
goto :benchloop4
:benchloop3
set /a benchnum = %benchnum%/2
echo %benchnum%
goto :benchloop4
:benchloop4
set /a benchcomp = %benchcomp% + 1
echo %benchcomp%
goto :benchloopstart

:finish
set end=%time%
set options="tokens=1-4 delims=:.,"
for /f %options% %%a in ("%start%") do set start_h=%%a&set /a start_m=100%%b %% 100&set /a start_s=100%%c %% 100&set /a start_ms=100%%d %% 100
for /f %options% %%a in ("%end%") do set end_h=%%a&set /a end_m=100%%b %% 100&set /a end_s=100%%c %% 100&set /a end_ms=100%%d %% 100

set /a hours=%end_h%-%start_h%
set /a mins=%end_m%-%start_m%
set /a secs=%end_s%-%start_s%
set /a ms=%end_ms%-%start_ms%
if %ms% lss 0 set /a secs = %secs% - 1 & set /a ms = 100%ms%
if %secs% lss 0 set /a mins = %mins% - 1 & set /a secs = 60%secs%
if %mins% lss 0 set /a hours = %hours% - 1 & set /a mins = 60%mins%
if %hours% lss 0 set /a hours = 24%hours%
if 1%ms% lss 100 set ms=0%ms%

:: Mission accomplished
set /a totalsecs = %hours%*3600 + %mins%*60 + %secs%
echo command took %hours%:%mins%:%secs%.%ms% (%totalsecs%.%ms%s total)
pause