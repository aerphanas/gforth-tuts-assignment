\ basic counted loop

include compat/loops.fs \ U+DO

\ from tutorial example

: ^ ( n1 u -- n )
  \ n = the uth power of n1
  1 swap 0 U+DO
  over *
  LOOP nip ;

\ reimplement without U+DO

: ^ ( n1 u -- n )
  1 ?DO dup * LOOP ;

\ access counter counted loop with i

: print-0-9 ( -- )
  10 0 ?DO
    i .
  LOOP ;

\ from tutorial example

: fac ( u -- u! )
  1 swap +1 1 U+DO
  i *
  LOOP ;

\ reimplement without U+DO

: fac ( n -- result )
  1 swap 1
  ?DO
    i 1+ *
  LOOP ;

: list-fib ( n -- n)
  0 1 rot 2 - 0
  ?DO
   2dup +
  LOOP ;

\ Assignment: Write a definition for computing the nth Fibonacci number.

: nth-fib ( n -- n)
  0 1 rot 2 - 0
  ?DO
    2dup + rot drop
  LOOP swap drop ;
