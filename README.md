# SecureInsights

A portfolio project to demonstrate:

- .NET backend engineering
- Python analytics and automation
- software design and architecture
- DSA practice
- cloud, security, and AI integration over time

## Repository structure

- `src/dotnet-api` - main ASP.NET Core API
- `src/python-analytics` - Python analytics and utility scripts
- `docs` - architecture and learning notes
- `dsa` - data structures and algorithms practice
- `patterns` - software pattern examples

## Current status

Week 1 setup complete.


src/api

C# Main backend code.

src/analytics

Python scripts/modules for analytics and reporting.

mkdir -p src/python-analytics
cd src/python-analytics
python -m venv .venv

.venv\Scripts\Activate.ps1

https://jonny0211.medium.com/python-virtualenv-and-venv-dos-and-donts-abf1b83cf943

Python comes with an automated system for keeping a package set local to a given Python project. Virtual environments — courtesy of the virtualenv tool in Python 2 and venv in Python 3—can be used to create a separate, isolated instance of the Python runtime for a project, with its own complement of packages.

docs

Architecture notes, ADR-style reasoning, weekly notes.

dsa

Practice problems in C# and maybe some in Python.
Big O
O(1) — constant time

Same amount of work regardless of input size.

Example:
accessing an array element by index.

O(n) — linear time

Work grows in proportion to input size.

Example:
scan an array to find a value.

O(n^2) — quadratic time

Often appears with nested loops.
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        // work
    }
}
If n doubles, work becomes about four times larger.

O(log n) — logarithmic time

Work grows slowly as input grows.

Typical example:
binary search on a sorted array.

Each step cuts the remaining search space in half.


What is an array conceptually?

An array is a contiguous collection of elements stored in order.

Important characteristics:

ordered
index-based access
efficient reads by index
fixed-size in many low-level models

In C#, arrays are real arrays:
int[] numbers = { 10, 20, 30, 40 };

In Python, list is more flexible than a classical fixed-size array, but for interview thinking, it often plays the “array-like sequence” role.

numbers = [10, 20, 30, 40]

Why arrays matter so much

Because many problems are disguised array problems:

find duplicates
find maximum
move elements
merge ranges
compute prefix values
two-pointer problems
sliding window problems

If arrays are weak, DSA feels hard.
If arrays are strong, half of DSA becomes manageable.



patterns

Small pattern examples, tied back to the actual project.


sql

Views, scripts, analytics queries.

tests

If not co-located, can contain cross-project test assets.