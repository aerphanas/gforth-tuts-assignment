\ The words +, -, *, /, and mod always operate
\ on the top two stack items

2 2 .s
+ .s
.
2 1 - .
7 3 mod .

\ order of the words unambiguously determines
\ the order of evaluation and the operands

3 4 + 5 * .
3 4 5 * + .

\ Assignment: What are the infix expressions
\ corresponding to the Forth code above?
\ Write 6-7*8+9 in Forth notation

\ Ans
6 7 8 * - 9 + .

\ use negate to change sign

2 negate .

\ Assignment: Convert -(-3)*4-5 to Forth.

\ Ans
3 negate negate 4 * 5 - .
