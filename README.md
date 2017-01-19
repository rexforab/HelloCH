# Hello

Greetings!

I have used .Net CORE.

As such you will require Visual Studio 2015 update 3 and the .Net CORE SDK to build and run the application: 
https://www.microsoft.com/net/core#windows

Since it isn't recommended to store the .suo file in Git, I would ask that you change your solution properties to multiple
startup projects, selecting the API and Console application for ease of use.  Alternatively you can start the API and manually start
new instance of the console application.  The API is set to not launch a browser on startup.

-Alex Rexford
