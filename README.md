# Loopless-programming-workshop
A workshop of introducing map/filter/reduce instead of loops.

The workshop has two parts. 
In the first one, through the steps of exercises we're creating our own implementations of those functions and at the same time we're getting rid of most of the loops from the code.
This part is covered by code in solution folders numbered 1 to 3.

Second part, covered by folders with numbers 4 and 5 first goes through different language features that support creating good readable code that uses our map/filter/reduce functions.
Then there are some final exercises written with heavy usage of the loops - we want to refactor them to our new style and see how code changes.

###Structure
This repo contains a folder with workshop starting code as well as a folder with solution of all the exercises as proposed by myself. My solutions are not the best ones by any means, sometimes they're the result of experimenting sometimes things could be more generic - yet I believe they might bring some advice when stuck.

The Visual Studio solution (.sln) itself contains two projects. One with exercises and second one with tests. Tests are written using FluentAssertions library and should be used as a verification for the code being written for the exercises.

###Requirements
* Visual Studio 2013/2015 (Community edition is enough)
* Good knowledge of C# programming language, in particular: 
  * `Func<>` delegates, 
  * lambdas and captured variables (closures)
  * `IEnumerable<T>` interface,
* LINQ knowledge is a plus 


###How to start
Open the solution located in `Starting code` folder. Build it and run all the tests. Most of them should be failing.
Follow the comments in exercises to implement functionality and validate Your work with included tests.

**Tip**: If You're using standard test runner, toggle test ordering to "by class".

###Support
Should You need any support, have questions or anything else, feel free to contact me via pull requests / issues.

