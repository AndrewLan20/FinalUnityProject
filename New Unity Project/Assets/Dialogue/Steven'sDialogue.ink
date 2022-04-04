
Hello Player, My name is Steven. 
I'm going to help you learn how to play this game.
First off, how excited are you to play this game?
-> My_Choices

== My_Choices ==
+ [Excited!]-> excited 
+ [not very excited] -> notVeryExcited
+[Huh?] -> repeat

== excited ==
I'm pretty excited for this game!  -> END
== notVeryExcited ==
It's whatever, I couldn't really be bohered to care -> END
== repeat ==
ARE YOU DEAF, 
I SAID  how excited are you to play this game? -> My_Choices


    -> END
