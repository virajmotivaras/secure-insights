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

patterns

Small pattern examples, tied back to the actual project.

sql

Views, scripts, analytics queries.

tests

If not co-located, can contain cross-project test assets.