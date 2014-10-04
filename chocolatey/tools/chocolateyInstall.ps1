$toolsDir = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)" 
$url = "https://github.com/moonpyk/RedisTray/releases/download/v0.1.0/RedisTray.v0.1.0.zip"
Install-ChocolateyZipPackage 'RedisTray' $url $toolsDir 
