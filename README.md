This is an asp.net mvc (.net 6.0) project.

To be able to run it create the database using the [CreationQuerry.sql](https://github.com/Seif302010/MedicalScan/blob/main/DataBaseSetup/CreationQuerry.sql) file in the [DataBaseSetup](https://github.com/Seif302010/MedicalScan/tree/main/DataBaseSetup) folder.

Then configure your connection string in the [appsettings.json](https://github.com/Seif302010/MedicalScan/blob/main/appsettings.json) file, it's recommended to use the [ConnectionString.sql](https://github.com/Seif302010/MedicalScan/blob/main/DataBaseSetup/ConnectionString.sql) file to get the connection string.

After that run the command:
```
dotnet restore

```
to get all the packages needed then run 
```
dotnet run

```
or for the hot reload run 
```
dotnet watch run

```
Now you are ready to go :wink:
