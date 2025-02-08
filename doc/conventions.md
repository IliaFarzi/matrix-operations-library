# Robotics API C# Code Conventions

This document establishes a common set of naming and file organization rules for the project. It is intended to promote consistency, readability, and maintainability throughout the codebase.

> **Note:** Some guidelines (such as using kebab-case for files or lower_snake_case for enum values) originate from conventions in other languages (e.g., TypeScript). In this document, we adapt these rules to fit C# best practices while preserving the project’s intent.

---

## 1. General Guidelines

- **Whole Words:** Use whole, descriptive words in names whenever possible. Avoid abbreviations unless they are widely recognized.
- **Uniqueness:** Ensure that directories, files, components, and functions have unique names to prevent ambiguity.
- **Consistency:** Follow these guidelines throughout the project to make the code easier to read and maintain.

---

## 2. Naming Conventions

### 2.1 Variables, Parameters, and Local Fields

- **Local Variables and Parameters:**  
  Use **camelCase**.  
  _Example:_
  ```csharp
  bool isLoading = true;
  void ProcessData(string userName) { … }

    State Variables:
    For booleans that represent states, use the is or has prefix.
    Examples: isLoading, hasCompletedOnboarding
    Private Fields:
    Many teams prefer using either camelCase or a leading underscore (e.g., _userName) for private fields. Choose one style and use it consistently.

### 2.2 Methods (Functions) and Properties

    Methods:
    In C#, method names are written in PascalCase.
    Example:

public void LoadUserData() { … }

Properties:
Public properties also use PascalCase.
Example:

    public string UserName { get; set; }

### 2.3 Constants and Symbols

    Constants:
    Use PascalCase for constant values in C# (consistent with .NET guidelines).
    Example:

public const int DefaultTimeout = 30;

Symbols:
For compile-time symbols or similar values, if needed, use UPPER_SNAKE_CASE.
Example:

    #define DEBUG_MODE

### 2.4 Classes, Types, and Interfaces

    Classes and Custom Types:
    Use PascalCase for class names and other types.
    Examples: UserManager, AuthenticationService

    When the additional Type suffix clarifies the role of a type, append it.
    Example: UserType

    Interfaces:
    Although C# typically uses an “I” prefix (e.g. IRepository), this project uses an Interface suffix instead.
    Example: UserRepositoryInterface
    Do not use the "I" prefix.

    Enums:
        The enum type itself should use PascalCase and may include an Enum suffix if it improves clarity.
        Example:

public enum TicketStatusEnum { … }

Enum Members:
While the common C# practice is to use PascalCase for enum members, this project specifies using lower_snake_case for enum values.
Example:

        public enum TicketStatusEnum {
            open_ticket,
            closed_ticket,
            pending_ticket
        }

    Collections:
    For collections, adopt lower_snake_case in plural form if it fits the API contract.
    Example: ticket_types

### 3. File and Directory Naming
   3.1 File Names

   In C#, file names should match the primary class, interface, or type defined within the file, and use PascalCase with a .cs extension.
   Examples: UserManager.cs, AuthenticationService.cs
   Note: Although some conventions (e.g., name.scope.entity.ts or kebab-case) are common in other languages like TypeScript, in a C# project we favor naming files to match the contained type names.

### 3.2 Directory Structure

    Organize code into directories that represent logical layers or modules (e.g., Controllers, Models, Services, Repositories).
    Use PascalCase for directory names to remain consistent with C# naming practices.

### 4. Summary of Key Points

   Use whole words for clarity.
   State variables (booleans) should begin with is or has.
   Variables and parameters: camelCase.
   Methods and public properties: PascalCase.
   Constants: PascalCase.
   Classes and custom types: PascalCase (append “Type” suffix when needed).
   Interfaces: Use an Interface suffix instead of an “I” prefix.
   Enums:
   Enum type names use PascalCase (optionally with an “Enum” suffix).
   Enum members use lower_snake_case.
   Collections: Use lower_snake_case in plural form.
   Files and directories: Use PascalCase, with file names matching the primary type defined in them.

