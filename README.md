# d1-calculator

# REQUIREMENTS:
Create a Calculator. Use everything that you have learned from the prework tutorials.

Create a very basic, 4 function calculator within a console application.

Specs
Upon completion, your calculator should contain the following:

Inside the Program.cs file of your console application you should have 4 external methods plus the Main method:
Add()
Subtract()
Multiply()
Divide()
Each of these methods should take in 2 parameters, and return the solution of those 2 numbers. (i.e if you are adding 2 numbers than your return would be the sum of the 2 numbers added together. )

Output to the console the answer to the proposed math problem.


# ARCHITECTURE:
Main function
  - collects operands from user and stores as doubles
  - collects desired operation from user and stores as string
  - routes operands to correct operation function (via switch)
  - displays results to user on console
  - exits program after single run

Add, Subtract, Multiply, Divide functions
  - accepts 2 operands (type: double) and returns the sum, difference, product, or quotient (respectively) as double


# SOLUTION TESTS:
Add: ![](tests/add-success.PNG)
Subtract: ![](tests/subtract-success.PNG)
Multiply: ![](tests/multiply-success.PNG)
Divide: ![](tests/divide-success.PNG)