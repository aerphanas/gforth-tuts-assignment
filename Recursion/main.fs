\ vactorial recursive non-standard

: fac1 ( n -- n! )
  dup
  0> IF
    dup 1- fac1 *
  ELSE
    drop 1
  ENDIF ;

\ or standard

: fac2 ( n -- n! )
  dup
  0> IF
    dup 1- recurse *
  ELSE
    drop 1
  ENDIF ;

\ Assignment: Write a recursive definition for computing
\             the nth Fibonacci number. 

: fib ( n -- n-th Fibonacci number )
  dup 2
  < IF
    drop 1
  ELSE
    dup 1 - recurse
    swap 2 - recurse +
  THEN ;
