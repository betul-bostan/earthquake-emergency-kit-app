# Earthquake Emergency Kit App

A C# Windows Forms desktop application for creating and managing an earthquake emergency kit.

The project was developed as part of an Object-Oriented Programming course and demonstrates the use of classes, collections, event-driven programming, Windows Forms controls, and basic validation.

## Project Overview

The application allows users to create a list of emergency supplies for an earthquake preparedness kit.

Users can:

- Add an item with a name and quantity
- Remove a selected item
- View the current emergency-kit item list
- Check whether the kit contains a sufficient number of items
- Receive status messages after each operation
- Track when each item was added
- Receive reminders for items that have not been updated for a long period

## Main Features

### Add Emergency Items

Users enter:

- Item name
- Item quantity

The application validates the input before adding the item to the emergency kit.

### Remove Items

A selected item can be removed from both:

- The application's internal item collection
- The Windows Forms list displayed to the user

### Kit Status Check

The application checks the total number of different items in the kit.

- Five or more items: the kit is presented as ready
- Fewer than five items: the kit is presented as potentially incomplete

This is an application-level rule created for educational demonstration and should not be interpreted as an official emergency-preparedness standard.

### Item Update Reminder

Each item stores its creation date.

A timer checks the item list periodically and displays a warning when an item has not been updated for more than 30 days.

## Object-Oriented Design

The project contains the following main classes:

### `Malzeme`

Represents an emergency-kit item.

Properties:

- `Ad` — item name
- `Adet` — item quantity
- `EklenmeTarihi` — date and time when the item was added

The class overrides `ToString()` to display the item name and quantity in the interface.

### `Canta`

Represents the emergency kit.

Responsibilities:

- Stores a list of `Malzeme` objects
- Adds items to the list
- Removes items from the list

### `Form1`

Provides the graphical user interface and handles:

- Button events
- Input validation
- List display
- Status messages
- Timer-based reminders

## Technologies

- C#
- .NET Framework 4.8.1
- Windows Forms
- Visual Studio 2022
- Object-Oriented Programming
- Event-driven programming

The project file targets .NET Framework 4.8.1 and is configured as a Windows executable.

## Repository Structure

```text
earthquake-emergency-kit-app/
├── Properties/
├── App.config
├── Canta.cs
├── DepremCantasiApp.csproj
├── DepremCantasiApp.sln
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Malzeme.cs
├── Program.cs
├── .gitignore
└── README.md
```

## Requirements

To open and run the project, you need:

- Windows 10 or Windows 11
- Visual Studio 2022
- .NET desktop development workload
- .NET Framework 4.8.1 targeting pack

> Windows Forms projects targeting .NET Framework are designed to run on Windows. macOS users can inspect the source code, but running the application requires Windows or a Windows virtual machine.

## Downloading the Project

### Option 1: Download ZIP

1. Open the repository on GitHub
2. Select the green **Code** button
3. Choose **Download ZIP**
4. Extract the downloaded ZIP file

### Option 2: Clone with Git

```bash
git clone https://github.com/betul-bostan/earthquake-emergency-kit-app.git
```

## Opening the Project

After downloading or cloning the repository:

1. Open Visual Studio 2022
2. Select **Open a project or solution**
3. Open:

```text
DepremCantasiApp.sln
```

4. Wait for Visual Studio to load the project
5. Build the solution
6. Run the application using the **Start** button

## Running the Application

In Visual Studio:

```text
Build → Build Solution
```

Then:

```text
Debug → Start Without Debugging
```

You can also use:

```text
Ctrl + F5
```

## Usage

1. Enter the name of an emergency item
2. Select its quantity
3. Click the add button
4. Repeat the process for additional items
5. Select an item and use the remove button when needed
6. Use the status button to check the kit's current state

## Current Limitations

- Items are stored only in memory and are lost when the application closes.
- The list is not saved to a file or database.
- The readiness check is based only on item count.
- The application does not use an official emergency-supply checklist.
- Items cannot currently be edited after being added.
- The reminder system uses the item's creation time rather than a true expiration date.
- The current interface is designed only for Windows.
- Automated tests are not included.

## Future Improvements

- Save the kit to JSON, XML, or a database
- Load previously saved items when the application starts
- Add item-editing support
- Add item categories such as food, health, communication, and shelter
- Add expiration-date tracking
- Add an official recommended-item checklist
- Show missing recommended items
- Add search and filtering
- Improve the interface design
- Add confirmation dialogs before deletion
- Add unit tests for the `Canta` and `Malzeme` classes
- Migrate to a modern .NET version
- Publish an installable Windows release

## Author

**Betül Bostan**

- [GitHub](https://github.com/betul-bostan)
- [LinkedIn](https://www.linkedin.com/in/bet%C3%BCl-bostan-2105942b2/)
