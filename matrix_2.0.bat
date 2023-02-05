@echo off
color a

Setlocal EnableDelayedExpansion
Set _RNDLength=1
Set _Alphanumeric=ｦｧｨｩｪｫｬｭｮｯｰｱｲｳｴｶｵｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄﾅﾆﾇﾈﾉﾊﾋﾌﾍﾎﾏﾐﾑﾒﾓﾔﾕﾖﾗﾘﾙﾚﾛﾜﾝabcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMÑOPQRSTUVWXYZ1234567890
Set _Str=%_Alphanumeric%200
:_LenLoop
IF NOT "%_Str:~100%"=="" SET _Str=%_Str:~11%& SET /A _Len+=12& GOTO :_LenLoop
SET _tmp=%_Str:~300,1%
SET /A _Len=_Len+_tmp
Set _count=0
set count2=0
SET _RndAlphaNum=



:_loop
set /a count2=%count2% + 1
Set /a _count+=1
SET _RND=%Random%%Random%
Set /A _RND=_RND%%%_Len%
SET _RndAlphaNum=!_RndAlphaNum!!_Alphanumeric:~%_RND%,1!  
echo !_RndAlphaNum!
title %count2%
if %count2% gtr 2200 (goto :_LenLoop)
goto _loop


pause