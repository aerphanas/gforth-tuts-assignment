\ You should put a correct stack effect on every definition,
\ even if it is just ( -- ). You should also add some descriptive
\ comment to more complicated words (I usually do this in the lines following :).
\ If you don't do this, your code becomes unreadable
\ (because you have to work through every definition before you can understand any). 

\ Assignment: The stack effect of swap can be written like this: x1 x2 -- x2 x1.
\ Describe the stack effect of -, drop, dup, over, rot, nip, and tuck.

\ Ans
\ - ( a b -- a - b )

\ Ans
\ drop ( a b -- a )

\ Ans
\ dup ( w1 -- w1 w1 )

\ Ans
\ over ( w1 w2 -- w1 w2 w1 )

\ Ans
\ rot ( w1 w2 w3 -- w2 w3 w1 )

\ Ans
\ nip ( w1 w2 w3 -- w1 w3 )

\ Ans
\ tuck ( w1 w2 -- w2 w1 w2 )

\ The names of the stack items in stack-effect and stack comments in the standard,
\ in this manual, and in many programs specify the type through a type prefix,
\ similar to Fortran and Hungarian notation. The most frequent prefixes are: 

\ Assignment: Write stack-effect comments for all definitions you have written up to now. 
