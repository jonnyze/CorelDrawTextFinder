# CorelDrawTextFinder
Search for Corel Draw Files containing text in folder and subfolders. 
Written in C# for .NET Framework 4.8. This is a console application.

This is, at least for now, just a quick hack to help a friend.

In short:
The CorelDraw format is a compressed archive, basically a zip-archive containing multiple files. This code finds all files matchin *.cdr in the current directory and subdirectories. Each file is unzipped i memory and the contents of META-INF/textinfo.xml is searched. Matches are output to console.

