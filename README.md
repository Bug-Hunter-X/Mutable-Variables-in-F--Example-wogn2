# Mutable Variables in F#

This repository demonstrates a common issue in F#:  the overuse of mutable variables. While mutability is sometimes necessary, it often leads to code that's harder to understand, debug, and test. This example shows how to refactor code that uses mutable variables to use immutable ones instead, improving the overall functional style of your F# program. 

## Problem
The `bug.fs` file contains code that uses mutable variables (`let mutable`). This makes the code less predictable, especially in larger and more complex scenarios. 

## Solution
The `bugSolution.fs` file shows the improved version, demonstrating how to replace mutable variables with immutable ones and potentially using function arguments.  This reduces mutability, which leads to more reliable and predictable code. 