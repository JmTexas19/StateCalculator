# StateCalculator
The goal of this project was to create a calculator very similar to the one on Windows. It was contructed using a State Design Pattern in C#.

The 3 main states the Calculator uses are the CleanState, NextOperandState, and ResultState. 
- The CleanState is the basic default state that accepts operands and operators. 
- The NextOperandState is the operator state that only accepts Operands. 
- The ResultState displays the final result after calculating the expression and accepts both operators and operands.

Functionality in current release:
- All Operations
- All Clears
- Backspace, Reciprocol, Square, and Root
- Decimal and Negative

Possible Future Improvements:
- Cleaner UI
- Percent Function
