\ In Forth you can use control structures only inside colon definitions.

: abs ( n1 -- +n2 )
  dup  0 < IF
    negate
    endif ;

\ if takes a flag from the stack. If the flag is non-zero (true),
\ the following code is performed, otherwise execution continues after the endif (or else).

\  < compares the top two stack elements and produces a flag

1 2 < .
2 1 < .
1 1 < .

\ non zero is true
\ zero is false

\ Actually the standard name for endif is then.

\ You can optionally use an else-part

: min ( n1 n2 -- n )
  2dup < if
    drop
  else
    nip
  then ;

\ Assignment: Write min without else-part (hint: what's the definition of nip?). 
: min ( n1 n2 -- n )
  2dup > if
    swap
  then
  drop ;

