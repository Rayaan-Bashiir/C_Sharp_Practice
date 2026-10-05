# Introduction to C#

## Topics

- 1.1 Objects
- 1.8 Getting Started with Visual Studio
- 2.1 Getting Started with Forms and Controls
- 2.3 Introduction to C# Code
- 2.5 Label Controls
- 2.7 PictureBox Controls
- 2.8 Comments, Blank Lines, and Indentation
- 2.9 Writing the Code to Close an Application's Form
- 2.10 Dealing with Syntax Errors

## What is C#?

C# (pronounced "C-Sharp") is a modern programming language created by Microsoft. It is used to build Windows applications with forms and buttons.

## 1. Objects and Controls

An **object** is a part of a program that stores data and can perform actions.

- **Properties** are the data an object holds, such as its text or color.
- **Methods** are the actions an object can do.
- A **class** is the blueprint that describes a type of object.
- **Controls** are the objects you can see on the screen, such as `Label`, `Button`, and `TextBox`.
- Some objects are invisible at run time, such as `Timer` and `OpenFileDialog`.

## 2. The .NET Framework

.NET is a large collection of ready-made classes that helps you build Windows programs. C# is one of the languages that work with it, and every control you drag onto a form comes from a .NET class.

## 3. Visual Studio Basics

Visual Studio is an IDE (integrated development environment) where you design and write your programs.

| Window | Purpose |
|---|---|
| Designer | Where you draw the form |
| Toolbox | Where you pick controls to add, usually on the left side |
| Properties | Where you change a control's settings |
| Solution Explorer | Where you see the project files |

- **Auto Hide** keeps a window collapsed into a small tab on the edge until you need it.
- A **solution** is a container for one or more projects.
- A **project** holds the files of one application, mainly `Form1.cs` and `Program.cs`.
- `Program.cs` has the start-up code, and `Form1.cs` has the code of the form.

## 4. Forms and Properties

Every Windows Forms app starts with an empty form named `Form1`. The look and behavior of any control come from its properties, for example the `Text` property changes the words shown on it, such as the form's title bar.

**Rules for naming controls:**

- Start with a letter or an underscore.
- Use only letters, numbers, and underscores.
- No spaces.
- Use camelCase, for example `showAnswerButton`.

## 5. Structure of C# Code

C# code is organized in three levels:

1. **Namespace**: a container for classes.
2. **Class**: a container for methods.
3. **Method**: a group of statements that does one job.

## 6. Events

An **event** is something the user does, such as clicking the mouse or pressing a key. Windows apps are **event-driven**, which means they wait for an event and then respond to it. An **event handler** is the method that runs when a specific event happens. Double clicking a control in the Designer creates its default event handler.

## 7. Label Control

A `Label` shows text on the form. Important properties:

- `Text`: the words displayed
- `Font`: font type and size
- `BorderStyle`: adds a border
- `AutoSize`: lets the label resize itself
- `TextAlign`: position of the text inside the label

To show output in a label, assign a string to its `Text` property. Assigning an empty string `""` clears it.

## 8. PictureBox Control

A `PictureBox` displays an image. Important properties:

- `Image`: the picture to show
- `SizeMode`: how the picture fits inside the box
- `Visible`: shows or hides the control while the program runs

Double clicking a PictureBox in the Designer creates its Click event handler.

## 9. Comments and Style

Comments are short notes that explain the code and are ignored by the computer. Use `//` for one line. Blank lines and indentation make the code easier to read.

## 10. Closing a Form

- `this.Close()` closes the current form.
- `Application.Exit()` closes the whole application.

## 11. Syntax Errors

When you type a mistake, Visual Studio underlines it with a jagged line. Fix these errors before running the program, otherwise the build fails.