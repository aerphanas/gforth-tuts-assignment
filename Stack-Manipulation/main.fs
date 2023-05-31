\ Stack manipulation words rearrange the data on the stack.

1 .s drop .s
1 .s dup .s drop drop .s
1 2 .s over .s drop drop drop
1 2 .s swap .s drop drop
1 2 3 .s rot .s drop drop drop

\ There are also variants that manipulate twice as many stack items

1 2 3 4 .s 2swap .s 2drop 2drop

\ Two more stack manipulation words are:

1 2 .s nip .s drop
1 2 .s tuck .s 2drop drop

\ stack manipulation :
\ drop -- remove top item in stack 1 2 -> 1
\ dup -- duplicate top item in stack and pushing  1 2 -> 1 2 2
\ over -- duplicate second from top to top stack 1 2 -> 1 2 1
\ swap -- swap 2 element from top stack 1 2 -> 2 1
\ rot -- move third from top item stack to top stack 1 2 3 -> 2 3 1
\ nip -- remove second item from top stack
\ tuck -- inserts copy top item in stack below second item from top, shifting other items up 1 2 3 4 -> 1 2 4 3 4

\ Assignment: Replace nip and tuck with combinations of other stack manipulation words
\ GIVEN:              HOW DO YOU GET:
\ 1 2 3               3 2 1
\ 1 2 3               1 2 3 2
\ 1 2 3               1 2 3 3
\ 1 2 3               1 3 3
\ 1 2 3               2 1 3
\ 1 2 3 4             4 3 2 1
\ 1 2 3               1 2 3 1 2 3
\ 1 2 3 4             1 2 3 4 1 2
\ 1 2 3
\ 1 2 3               1 2 3 4
\ 1 2 3               1 3

\ Ans
\ 1 2 3 -> 3 2 1
1 2 3 .s
swap rot .s
2drop drop .s

\ 1 2 3 -> 1 2 3 2
1 2 3 .s
over .s
2drop 2drop .s

\ 1 2 3 -> 1 2 3 3
1 2 3 .s
dup .s
2drop 2drop .s

\ 1 2 3 -> 1 3 3
1 2 3 .s
swap drop dup .s
2drop drop .s

\ 1 2 3 -> 2 1 3
1 2 3 .s
rot swap .s
2drop drop .s

\ 1 2 3 4 -> 4 3 2 1 
1 2 3 4 .s
drop rot drop 4 swap rot 1 .s
2drop 2drop .s

\ 1 2 3 -> 1 2 3 1 2 3
1 2 3 .s
drop over 3 swap over 1 - dup 1 + .s
2drop 2drop 2drop .s

\ 1 2 3 4 -> 1 2 3 4 1 2
1 2 3 4 .s
drop drop over 3 swap 4 swap 2 .s
2drop 2drop 2drop .s

\ 1 2 3 -> _
1 2 3 .s
2drop drop .s

\ 1 2 3 -> 1 2 3 4
1 2 3 .s
dup 1 + .s
2drop 2drop .s

\ 1 2 3 -> 1 3
1 2 3 .s
swap drop .s
2drop .s

5 dup * .

\ Assignment: Write 17^3 and 17^4 in Forth, without writing 17 more than once.
\ Write a piece of Forth code that expects two numbers on the stack
\ (a and b, with b on top) and computes (a-b)(a+1). 

\ Ans
\ 17^3
17 dup dup * * .

\ 17^4
17 dup dup dup * * * .

\ a b -> (a - b)(a + 1)
5 10 .s
over 1 + swap rot swap - * .
