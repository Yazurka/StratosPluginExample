# Stratos Plugin Example

Build solution and copy Demo.Stratos.Plugin.dll to [PathToRepo]Stratos\src\bin\Debug

Hit http://localhost:1337/api/plugin/getString to check that everything is ok. 
This URL should return the string "Hello From Stratos Plugin!"

For now the name of your dll must fulfill this contract "*.Stratos.Plugin.dll". Example "Demo.Stratos.Plugin.dll", "MyPlugin.Stratos.Plugin.dll", "Company.My.Plugin.Stratos.Plugin.dll" etc.
