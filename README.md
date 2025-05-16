# VB.NET-OOP
You'll learn how to structure a simple inventory system using custom classes, properties, and methods, while following a clean architecture approach.
## OOP Class
Find an example about creating TextBox Control in VB.NET at Runtime in my [VB.NET Blog](https://adonetaccess2003.blogspot.com/2011/05/vb-net-create-objects-in-runtime.html)
### Visual Basic
I will use Visual Studio 2022.
.NET 8.0
### Project 1 - Creating Class Library for WinForms
We will simply create a **TextBox** Control with modified Properties.
You may find this code in WinFormsLibrary1->CustomTextBox.vb file.
### Summary of OOP Concepts Demonstrated:
**Concept**				**Implementation**
## Additional Resources

- [Creating TextBox Control in VB.NET at Runtime (Blog)](https://adonetaccess2003.blogspot.com/2011/05/vb-net-create-objects-in-runtime.html)

---

Feel free to contribute or open issues for suggestions!
# VB.NET-OOP Inventory System Example

This project demonstrates how to structure a simple inventory system in VB.NET using custom classes, properties, and methods, following a clean architecture approach.

## Features

- Custom WinForms TextBox control with extended functionality
- Demonstrates core OOP concepts: inheritance, encapsulation, overriding, and customization
- Built with Visual Studio 2022 and .NET 8.0

## Prerequisites

- Visual Studio 2022 or later
- .NET 8.0 SDK

## OOP Concepts Demonstrated

| Concept        | Implementation                        |
| -------------- | ------------------------------------- |
| Inheritance    | `CustomTextBox` inherits `TextBox`    |
| Encapsulation  | `_autoUpperCase` with public property |
| Overriding     | Overrides `OnTextChanged`             |
| Customization  | Modify properties in `New()`          |

## Project Structure

- `WinFormsLibrary1/CustomTextBox.vb`  
  Contains the custom `CustomTextBox` control.

## Usage Example

To use the custom TextBox in your WinForms project:
Inheritance				Inherits TextBox
Encapsulation			_autoUpperCase with public property
Overriding				Overrides OnTextChanged
Customization			Modify properties in New() constructor