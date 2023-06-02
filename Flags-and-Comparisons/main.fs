\ You can use and or xor invert as operations on canonical flags.

1 2 and .
1 2 or .
1 3 xor .
1 invert .



\ You can use the all-bits-set feature of canonical flags
\ and the bitwise operation of the Boolean operations to avoid if

: foo ( n1 -- n2 )
  0= if
    14
  else
    0
  then ;

: foo ( n1 -- n2 )
  0= 14 and ;

\ Assignment: Write min without if.

: min ( n1 n2 -- n)
  2dup + swap rot swap - abs -  2 / ;
