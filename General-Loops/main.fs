\ endless loop

: endless ( -- )
  0 BEGIN
    dup . 1+
  AGAIN ;

\ begin does nothing at runtime, again jumps back to begin

\ loop with one exit at any place look like this :

\ logaritmus dualis on n1>0, rounded down to the next integer
: log2 ( +n1 -- n2 )
  assert( dup 0> )
  2/ 0 BEGIN
    over 0> WHILE
    1+ swap 2/ swap
  REPEAT
  nip ;

\ Until consumes a flag; if it is non-zero, execution
\ continues at the begin, otherwise after the until

\ another example loops

: print-1-5 ( -- )
  1 BEGIN
    dup . 1 +
    dup 5 =
  UNTIL . ;

: print-1-10 ( -- )
  1 BEGIN
    dup 10 <>
  WHILE
    dup .
    1 +
    ~~
  REPEAT . ;

\ Assignment: Write a definition for computing
\             the greatest common divisor. 

\ Ans
\ Euclidean algorithm
: gcd ( a b -- gcd )
  BEGIN
    ?dup
  WHILE tuck mod
  REPEAT ;
