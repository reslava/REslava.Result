# REslava.Result

 🚧 **Under Construction** - This library is currently in active development

>A very simple, clean, and robust C# .NET library that implements the Result pattern for elegant error handling that minimises the use of exceptions. 
>Handle success/failure/reason info along with an optional value.

<div align="center">

![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?&logo=csharp&logoColor=white)
[![GitHub contributors](https://img.shields.io/github/contributors/reslava/REslava.Result)](https://GitHub.com/reslava/REslava.Result/graphs/contributors/) 
[![GitHub Stars](https://img.shields.io/github/stars/reslava/REslava.Result)](https://github.com/reslava/REslava.Result/stargazers) 
[![GitHub license](https://img.shields.io/github/license/reslava/REslava.Result)](https://github.com/reslava/REslava.Result/blob/master/LICENSE.txt)

</div>

## 📋 Table of Contents
- [Overview](#-overview)
- [References](#-references)

## 🎯 Overview
**REslava.Result** provides a functional approach to error handling in C# by implementing the Result pattern. Instead of throwing exceptions for expected error cases, this library allows you to return detailed information about the error along with your data, making your code more predictable and easier to understand.

After studying the excellent ErrorOr and FluentResults libraries (many thanks to the authors of both) and their approaches to implementing the Result pattern, I decided to start a new library from scratch based on FluentResults. 
I like to start from a blank project because that way I can design my own class structure and implement the features I consider appropriate. 

My idea is to make this library as simple as possible, easy to understand and use.

I hope you find this library useful. Thank you!

## 📶 UML Class Diagram

Here you can see UML class diagrama used to implement Result pattern in the project:

- [UML](UML.md)
- [UML simplified](UML-simple.md) (only class names)


## 📕 References
- [Series: Working with the result pattern](https://andrewlock.net/series/working-with-the-result-pattern/)
- [The Result Pattern in C#: A Smarter Way to Handle Errors](https://medium.com/@aseem2372005/the-result-pattern-in-c-a-smarter-way-to-handle-errors-c6dee28a0ef0)
- [Functional Error Handling in .NET With the Result Pattern](https://www.milanjovanovic.tech/blog/functional-error-handling-in-dotnet-with-the-result-pattern)
- [ErrorOr](https://github.com/amantinband/error-or)
- [OneOf](https://github.com/mcintyre321/OneOf)
- [FluentResults](https://github.com/altmann/FluentResults)

---

<div align="center">

**⭐ Star this repository if you find it useful!**

Made with ❤️ by [Rafa Eslava](https://github.com/reslava)

</div>