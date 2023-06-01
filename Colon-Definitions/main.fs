\ similar to procedures and function in other programming language

: squared ( n -- n^2 )
  dup * ;

5 squared .
7 squared .

\ The newly-defined word can be used like any other word,
\ including using it in other definitions: 

: cubed ( n -- n^3 )
  dup squared * ;

-5 cubed .

: fourth-power ( n -- n^4 )
  squared squared ;

3 fourth-power .

\ Assignment: Write colon definitions for nip, tuck, negate, and /mod
\ in terms of other Forth words, and check if they work
\ (hint: test your tests on the originals first).
\ Don't let the `redefined'-Messages spook you, they are just warnings. 

\ Ans for nip
\ nip -- remove second item from top stack
: renip ( a b c -- a c )
  swap drop ;

\ Ans for tuck
\ tuck -- inserts copy top item in stack below second item from top, shifting other items up 1 2 3 4 -> 1 2 4 3 4

: retuck ( a b c -- a c b c )
  swap over ;

\ Ans for negate
\ negate - change num to negative or vice versa
: renegate ( a -- -a )
  -1 * ;

\ Ans for /mod
\ /mod perform division and modulus
: redivmod ( a b -- a/b a%b )
  tuck over swap /
  swap rot mod
  swap ;
