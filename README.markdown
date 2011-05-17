Plain Text Journal
==================

*Plain Text Journal* is a personal journaling tool. It is intended to be used as a very simple, no-frills daily diary. It was built with two things in mind:

1. A journal tool should be simple, and easy to use. Writing a daily journal is all about the content. It's not about tagging, categorizing, cross linking and etc.. That's what blogs, wikis and note taking tools are for. Plain Text Journal is different. It's just you and your writing. The interface supports the bare minimum features.

2. Personal journals are long term affairs. Most people keep them for many years. It makes no sense to trap all that content in some database, or proprietary file format. Plain Text Journal saves your entries in plain text. It is a tool that helps you to navigate, organize and create new entries, but at the end of the day it's all just text. You can go back and edit your entries with any text editor at any time.

Here is a sample screenshot:

<img src="http://maciak.org/tools/plaintextjournal/plaintextjournal.jpg">

Features
--------

- Inline Spell-Check
- Easy navigation though archives using calendar widget
- Entries are saved in plain text and can be easily edited

Requirements:
-------------

Plain Text Journal was written in C#. You will need Microsoft .NET Framework 3.5 or better to run it. The project was created using Microsoft Visual C# 2008 Express, and the repository includes all the project files for your convenience. You should be able to open and compile the project in any version of Microsoft Visual Studio.

Installation:
-------------

There are two options for obtaining Plain Text Journal binaries:

1. Download <a href="http://maciakl.github.com/Plain-Text-Journal/setup.exe">sedup.exe</a> and install Plain Text Journal on your system.
2. Download the <a href="http://maciakl.github.com/Plain-Text-Journal/Journal.exe">stand alone binary</a> and run it from anywhere.


License:
--------

This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

Copyright (c) 2011 Lukasz Grzegorz Maciak (maciak.org)

File Storage
------------

Plain Text Journal stores all your work in a single directory. By default this directory is set to:

        C:\Documents and Settings\Username\My Documents\My Journal\

or on Windows Vista and above:

        C:\Users\Username\Documents\My Journal\

You can change this at any time using the _Change Journal Folder_ option from the _Journal_ menu.

Inside, Plain Text Journal will create a directory for each month. The directories are named as follows for easy sorting:

        YYYY-MM

Inside monthly directories, each daily journal entry will be stored as a separate file named using ISO date standard like this:

       YYYY-MM-DD.txt

So for example the journal entry for May 1, 2011 will be in a file named: 2011-05-01.txt. There is no additional metadata attached to any files - there is no need. Renaming the files will file the entry under an appropriate day. There is no collisions since you can't have two files with the same name in the same folder. Files with invalid names will simply be ignored by the tool, but not deleted.

Development Notes:
------------------

The main text box is a custom control derived from System.Windows.Controls rather than System.Windows.Forms. This was done in order to get the built-in spell checking working properly. Note that causes the box to act in non-standard ways. For example, not all properties are exposed and visible in the visual designer. The code for the control is located in _Class1.cs_. To access certain properties you will need to either hard-code them in the constructor, or add Property functions. For an example how this can be done, see the _KeyUp1_ method.


