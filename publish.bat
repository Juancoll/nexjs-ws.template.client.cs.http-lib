set name=template.api.wsclient

del %name%.*.nupkg
.\.nuget\nuget.exe restore
.\.nuget\nuget.exe pack -Build -OutputDirectory . %name%.csproj
.\.nuget\nuget.exe push -Source "nodall-dev" -ApiKey myazurekey %name%.*.nupkg      
