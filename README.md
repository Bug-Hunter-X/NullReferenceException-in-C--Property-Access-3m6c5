# NullReferenceException in C# Property Access

This repository demonstrates a common coding error in C#: the `NullReferenceException`. This exception occurs when you try to access a member (property, method, etc.) of an object that is currently null. 

The `Bug.cs` file contains code that throws this exception. The `BugSolution.cs` file provides a corrected version that safely handles the potential null value.

**How to reproduce:**
1. Clone this repository.
2. Compile and run `Bug.cs`. You will observe a `NullReferenceException`.
3. Then, compile and run `BugSolution.cs`. This version avoids the exception.