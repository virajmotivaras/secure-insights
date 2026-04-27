**Why do project boundaries matter?**

A boundary is the line that separates one responsibility from another.

Examples:

API code should not be mixed with analytics scripts
design notes should not be buried inside source folders
DSA practice should not pollute production app code

Project boundaries matter because they keep responsibilities separated.

If everything is mixed together, the codebase becomes harder to understand, test, change, and scale. Boundaries help us decide:

what belongs where
which part of the system is responsible for what
how one part should interact with another

For example, API code, analytics scripts, documentation, and DSA practice should not all live in the same place. Each has a different purpose. When we separate them properly, the system becomes easier to maintain.

Good project boundaries improve:

readability
maintainability
testability
team collaboration
future extensibility

Project boundaries matter because they reduce coupling, improve clarity, and make the system easier to evolve safely.


**What is the difference between a solution, a project, and a package/module?**
A solution contains all the solution related files
A solution can contain more than one project

These are different levels of organization.

Solution

A solution is the top-level container in .NET.
It groups one or more related projects together.

You can think of it as the umbrella for the whole workspace.

Example:

SecureInsights.sln

It helps manage multiple projects in one system.

Project

A project is a concrete buildable unit inside the solution.

Examples:

a Web API
a class library
a test project
a console app

A project has its own configuration and output, usually defined by a .csproj file.

Example:

SecureInsights.Api.csproj

A solution may contain many projects.

Package / Module

This depends a bit on language.

In Python:

a module is usually a single .py file
a package is a folder that organizes related Python modules

In a broader sense, packages/modules are smaller units of organization inside a codebase. They help group related logic together.

In C#, the closest ideas are namespaces, assemblies, and NuGet packages, but for your current understanding, it is enough to think of modules/packages as the internal code organization layer below the project level.


A solution groups projects.
A project is a buildable application or library.
A package or module organizes code inside or across projects

**Why is scanning an array O(n)?**
The complexity increases with the size of the array

For an array of size n:

you start with one candidate max
then inspect the remaining elements one by one
each inspection is constant-time work
so total work grows linearly with n

A more precise way to say it:

The algorithm performs n - 1 comparisons in the worst case, so its time complexity is O(n)

Space complexity

Your answer: O(1) extra space
Also correct.

Why?

Because you are not creating another array, list, or data structure that grows with input size.

You only use a small fixed number of variables, for example:

max
i

Even if the array becomes huge, the extra memory used by the algorithm stays essentially the same.

That is why we say:

Extra space complexity is O(1).

Notice the phrase extra space. The input array already exists; we usually do not count that as extra memory created by the algorithm.
There are n - 1 comparisons, each constant-time, so total time is linear

Final answer

Time complexity: O(n)
Because in order to guarantee the maximum value, the algorithm must inspect each element once, leading to n - 1 comparisons.

Space complexity: O(1) extra space
Because it uses only a fixed number of additional variables, regardless of input size.

Why it is not O(1) time:
Because the amount of work depends on the size of the array. To guarantee correctness, the algorithm must examine all elements in the worst case, and in fact even in the best case.