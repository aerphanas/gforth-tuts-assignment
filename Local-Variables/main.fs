\ local Variable example

\ rewrite swap with local Variable
\ -- is comment
: reswap { a b -- b a }
	 b a ;

\ or
: rereswap ( w1 w2 -- w2 w1 )
  { a b } b a ;

\ In Gforth you can have several locals definitions, anywhere in a colon definition;
\ in contrast, in a standard program you can have only one locals definition per colon definition,
\ and that locals definition must be outside any control structure.

\ With locals you can write slightly longer definitions without running into stack trouble.
\ However, I recommend trying to write colon definitions without locals
\ for exercise purposes to help you gain the essential factoring skills. 

\ Assignment: Rewrite your definitions until now with locals
