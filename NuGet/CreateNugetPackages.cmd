@echo off
nuget.exe pack Digi21.DigiNG.IO.Geomedia.nuspec
nuget.exe sign Digi21.DigiNG.IO.Geomedia.22.3.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://timestamp.comodoca.com?td=sha256.
