
Hello Player, My name is Steven. 
I'm going to help you learn how to play this game.
First off, how excited are you to play this game?
-> My_Choices

== My_Choices ==
+ [Excited!]-> excited 
+ [not very excited] -> notVeryExcited
+[Huh?] -> repeat

== excited ==
That's great!  -> END
== notVeryExcited ==
You really don't care about this game? Why are you even playing it then. You ain't one of them art critic are ya? -> END
== repeat ==
ARE YOU DEAF, 
I SAID  how excited are you to play this game? -> My_Choices


    -> END
