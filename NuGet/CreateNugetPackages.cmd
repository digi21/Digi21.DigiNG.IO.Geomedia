@echo off
nuget.exe pack Digi21.DigiNG.IO.Geomedia.nuspec
nuget.exe sign Digi21.DigiNG.IO.Geomedia.21.0.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://tsa.starfieldtech.com
