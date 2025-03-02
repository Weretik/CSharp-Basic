# TasksOfSCharp

## Overview

This repository contains solutions to C# homework assignments, covering key object-oriented programming (OOP) concepts and related topics. The project is structured into multiple sections, each focusing on a specific aspect of C# programming.

## Project Structure

The repository is organized into the following folders, corresponding to different topics:

1. **Introduction to OOP. Classes and Objects**  
   - **Task 2**: Create a `Rectangle` class with fields for `side1` and `side2`. Implement methods to calculate the area and perimeter, along with properties to access these values. The program takes user input and displays the results.
   - **Task 3**: Create a `Book` class and associated classes `Title`, `Author`, and `Content`. Implement a `Show()` method to display book details in different colors.
   - **Task 4**: Implement classes `Point` and `Figure` to work with polygons. The `Figure` class calculates side lengths and the perimeter based on a given number of points.
   - **Task 6**: Develop an `Address` class with fields for postal address details. Implement properties for data access and create an instance to display the stored information. 

2. **Classes and Objects. Class Diagrams**  
   - **Task 2**: Create a `Converter` class with fields representing exchange rates for three currencies. Implement methods for currency conversion from and to UAH.
   - **Task 3**: Create an `Employee` class with fields for name and surname. Implement a method to calculate salary and tax based on position and experience. Display employee details, salary, and tax on the screen.
   - **Task 4**: Implement an `Invoice` class with fields for account number, customer, and provider. These should be immutable after initialization. Include private fields for `article` and `quantity`. Implement methods to calculate the total order cost with and without VAT.
   - **Task 6**: Develop a `User` class with fields for user profile information (login, name, surname, and registration date). Ensure that the registration date is immutable after initialization. Implement a method to display user details on the screen.


3. **Inheritance and Polymorphism**  
   - **Task 2**: Implement a [`ClassRoom`](./3.Inheritance%20and%20polymorphism/Pupil.cs) class that represents a study group. Create a [`Pupil`](./3.%20Inheritance%20and%20polymorphism/Pupil.cs) class with methods `Study()`, `Read()`, `Write()`, and `Relax()`. Derive `ExcellentPupil`, `GoodPupil`, and `BadPupil` classes, overriding their methods accordingly. The `ClassRoom` constructor should accept up to four `Pupil` instances.
   - **Task 3**: Develop a [`Vehicle`](./3.Inheritance%20and%20polymorphism/Vehicle.cs) class with properties for coordinates and transport parameters (price, speed, year of manufacture). Derive `Plane`, `Car`, and `Ship` classes, adding additional fields such as passenger capacity and home port for `Ship`, and altitude and passenger count for `Plane`.
   - **Task 4**: Create a [`DocumentWorker`](./3.Inheritance%20and%20polymorphism/DocumentWorker.cs) class with methods `OpenDocument()`, `EditDocument()`, and `SaveDocument()`. Override these methods in a `ProDocumentWorker` subclass to add extended editing capabilities and further extend `ExpertDocumentWorker` to support saving in additional formats. The program should instantiate different versions based on the user’s license key.
   - **Task 5**: Implement a [`Printer`](./3.Inheritance%20and%20polymorphism/Printer.cs) class with a method `Print(string value)` that prints text. Derive subclasses that override this method to print in different formats or colors.

 

4. **Abstraction. Abstract Classes and Interfaces**  
   - **Task 2**: Implement an [`AbstractHandler`](./4.%20Abstraction.%20Abstract%20classes%20and%20interfaces/AbstractHandler.cs) class with methods `Open()`, `Create()`, `Change()`, and `Save()`. Derive `XMLHandler`, `TXTHandler`, and `DOCHandler` classes that override these methods for different document formats. The program should handle document processing based on its format.
   - **Task 3**: Create two interfaces [`IPlayable`](./4.%20Abstraction.%20Abstract%20classes%20and%20interfaces/Interface1.cs) and `IRecodable`, each containing three methods: `Play()`, `Pause()`, and `Stop()` for `IPlayable`; `Record()`, `Pause()`, and `Stop()` for `IRecodable`. Develop a `Player` class implementing both interfaces and execute both playback and recording functionalities in the program.
 

5. **Arrays and Indexers**  
   - **Task 2**: Implement a program that creates an array of `N` elements, fills it with random integers, and displays the maximum, minimum, sum, and average values of the elements, as well as all odd numbers.
   - **Task 3**: Develop a [`MyMatrix`](./5.%20Arrays%20and%20indexers/MyMatrix.cs) class that allows defining and resizing a matrix dynamically. Implement methods to retrieve the original and transposed matrices.
   - **Task 4**: Create an [`Article`](./5.%20Arrays%20and%20indexers/Article.cs) class representing a product, including fields for its name, store, and price. Implement a `Store` class that holds an array of `Article` objects and provides search and retrieval functionality based on product names or indices.


6. **Static and Nested Classes**  
   - **Task 2**: Implement a static [`FindAndReplaceManager`](./6.%20Static%20and%20nested%20classes/Book.cs) class with a `FindNext(string str)` method to search for a string within a book.
   - **Task 3**: Extend the book example by adding a nested `Notes` class inside [`Book`](./6.%20Static%20and%20nested%20classes/Book.cs), allowing users to store notes.
   - **Task 4**: Create an extension method for arrays that sorts elements in ascending order, implemented in [`ExtensionArray`](./6.%20Static%20and%20nested%20classes/ExtensionArray.cs).
   - **Task 6**: Develop a static [`Calculator`](./6.%20Static%20and%20nested%20classes/Calculator.cs) class containing methods for basic arithmetic operations.


7. **Structures and Their Types**  
   This section covers working with structures and comparing them with classes.
   - **Task 2**: Implement a [`Train`](./7.%20Structures%20and%20their%20types/Train.cs) structure containing fields for the destination, train number, and departure time. Create an array of `Train` structures, sort them by train number, and allow the user to search for a train by number.
   - **Task 3**: Create a `MyClass` class and a `MyStruct` structure, both containing a `string change` field. Implement methods in the `Program` class to modify the field and demonstrate the difference between reference types (classes) and value types (structures).
   - **Task 5**: Develop a `Notebook` structure (located in [`Program.cs`](./7.%20Structures%20and%20their%20types/Program.cs)) with fields for model, manufacturer, and price. Implement a constructor to initialize these fields and a method to display the structure’s contents.


8. **Enumeration**  
   - **Task 2**: Implement a static [`Printer`](./8.%20Enumeration/Printer.cs) class with a `Print(string text, int color)` method to display text in a user-selected color.
   - **Task 3**: Develop an [`Accountant`](./8.%20Enumeration/Accountant.cs) class that determines if an employee is eligible for a bonus based on an `enum` representing job positions and their required work hours.
   - **Task 5**: Create a program (located in [`Program.cs`](./8.%20Enumeration/Program.cs)) that accepts a user's birthdate and calculates the number of days until their next birthday.


Each section contains one or more C# files that demonstrate concepts through practical examples.

## Requirements

- .NET SDK (latest stable version)
- C# compiler
- IDE of your choice (Visual Studio, JetBrains Rider, or VS Code with C# extension)

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Weretik/TasksOfSCharp.git
   ```
2. Open the project in your preferred IDE.
3. Navigate to the specific topic folder.
4. Run the `Program.cs` file within that topic to execute the examples.

## License

This project is open-source and available under the MIT License.
