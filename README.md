# Alibi
[![License: MIT](https://img.shields.io/github/license/ElijahZAwesome/Alibi)](https://github.com/ElijahZAwesome/Alibi/blob/main/LICENSE) [![Fork This Repo](https://img.shields.io/github/forks/ElijahZAwesome/Alibi)](https://github.com/ElijahZAwesome/Alibi/blob/main/LICENSE) [![Star This Repo](https://img.shields.io/github/stars/ElijahZAwesome/Alibi)](https://github.com/ElijahZAwesome/Alibi/blob/main/LICENSE)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/1913dc611b664376a11c84c4e1c2861a)](https://www.codacy.com/gh/ElijahZAwesome/Alibi/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=ElijahZAwesome/Alibi&amp;utm_campaign=Badge_Grade)

Attorney Online 2 Server Implementation in C# .NET Core
 
# What is it?
After having ran an Attorney Online server, I despise the current experience of maintaining an active server
for this game. So I thought it would be fun to try and make one myself, to see if I can do something better.

# Prerequisites
Windows:

 - All you need is either the Desktop or Core version of the [.NET 5.0 Runtime](https://dotnet.microsoft.com/download/dotnet/5.0) installed.

Linux/Unix:
 
 - Determine how to install the dotnet core runtime on your distribution:
 [here](https://docs.microsoft.com/en-us/dotnet/core/install/linux) or [here](https://wiki.archlinux.org/index.php/.NET_Core#Installation) are a few.

# Usage
To run the most basic possible server, all you have to do is download the latest 
[Release](https://github.com/ElijahZAwesome/Alibi/releases/).
It will make the needed config files for you and set up defaults for you.

Double click or run this in the console (currently no command line arguments):

```
Alibi
```

# Documentation:
You can go to the [documentation](https://elijahzawesome.github.io/Alibi) page if you wanna find out how to use the server, make plugins, and the various other articles ~~ill eventually make~~. However, this page is still WIP, so don't expect a full tutorial.

# Plugins

Surprisingly, this thing supports plugins! To make one, just make a new .Net Core 
Class Library that targets net5.0, and reference the `Alibi.Plugins.API` 
project of this repository, or install this 
[NuGet package](https://www.nuget.org/packages/Alibi.Plugins.API/).

Then, make a class that inherits from `Plugin`, and implement it's required members, and the constructor.
You should now have a bare-bones working plugin! Build it and put the .dll in the `Plugins`
folder of Alibi, and restart the server.

# Progress
These packets are not implemented:

- [ ] SETCASE
- [ ] CASEA
- [ ] Slow loading packets (needed because client is bugged lol)

# Contributing
I am **always** open to issues, pull requests, debugging specific issues in private, whatever. I could really use it, actually. My Discord is ElijahZAwesome#6933.

# TODO
Some shit that needs to get done

- [ ]  Make websockets less terrible again.
- [ ]  ~~Add a "primary admin" or something so only they can restart the server and create/remove logins, since mods shouldnt be able to remove mods.~~
- [X]  Multiple levels of permissions, User, Moderator, Administrator
- [X]  ~~***Switch to an ID system (incremented ID as primary key in the db instead of hwid)***~~ instead of this, clients just can't connect and interact with the server unless they have followed the protocol and sent their HWID
- [X]  Kick clients without HWIDs
- [X]  Clean up some of this shit code
- [X]  Become more thread safe (Maybe?)
- [X]  Plugins
- [X]  Areas
- [X]  Commands (Some commands are in but need more)
- [X]  Logging architecture
- [X]  Database
- [X] *I think the command paradigm currently implemented is good enough. Any Tsuserver3 commands that users want can be added by request or through usermade plugins  ~~Implement standard commands~~
- [ ]  Test/Stress test this bitch
- [ ]  Document server
- [ ]  Document Plugin API