using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?

Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("hey kitty");
            Console.ReadLine();
            Console.WriteLine("bye kitty");
            Console.Beep(37,25000);
            Console.ReadLine() ;


        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Feedback on your code:

Main Task Completion:

Task 1: You have successfully printed a message to the console using Console.WriteLine();. However, the task was to print 'Hello World!', and you have printed 'hey kitty'. While your code is technically correct, it's important to follow the instructions exactly in programming tasks.
Task 2: You have correctly implemented Console.ReadLine(); to make the program wait for input. Good job!
Code Commenting: You have not included any comments in your code. While this is a simple program, it's good practice to start commenting your code now. Comments help others understand your code, and they can also help you remember your thought process when you return to a piece of code later.

Extension Tasks:

Task 1: You have successfully printed another message after the ReadLine. Well done!
Task 2: You have implemented Console.Beep(37,25000); to make the console beep. However, you haven't changed the color of the console text or background. Consider researching and implementing Console.ForegroundColor and Console.BackgroundColor.
Answers to Questions: You haven't provided any answers to the questions in the task. Remember to answer these in your submission next time.

Overall, you've done a good job with this task, especially with the main tasks and extension tasks. Remember to follow the instructions exactly, comment your code, and answer all questions in future tasks. Keep up the good work!


===============================================================================
*/