# CalendarApp

[new]

# Steps
 - Enter CalendarApp.sln
 - Open CalendarApp Properties in project tab
 - Disable "Sign the ClickOnce_manifests" in signing page
 - Run application


!!! [Deprecated] !!!

## Instalation 

 > install Xampp/Wamp/Mamp
> 
 > run Apache + MySQL services
> 
 > create database named "calendarapp"

### From this moment app should work on default root user, if you want to set up own connection or change user from default change connection string placed in EventsDAO.cs file

```C#
namespace CalendarApp
{
    internal class EventsDAO
    { 

    --->    private string connString = "server=127.0.0.1; port=3306; user=root; database=calendarapp; password=; convert zero datetime=True;";
    

```
