![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/f7e22a88-d485-4a46-a2ba-a7f9de65c66f)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/eb798df4-6a76-455d-bbba-c33cb0493524)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/5d7cb2c6-91d5-46dd-b384-1d9359a9925a)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/60d03ddc-561e-4cb5-87c7-c1b7c311c01b)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/f30aec0d-2954-4db9-9687-2c51d2eb3c9a)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/43dac45e-4443-4798-80eb-7839d61bca89)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/78e2a55a-5cec-4900-8e8b-951b2a9207b7)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/f5480305-876a-4fe2-90ff-d9bdd4d86d5d)

![image](https://github.com/dyeyniyel/comp123-lab5-Theatre/assets/158533198/23b8da79-e687-47e4-9398-a5c05f010b39)

Testing	1 Mark

In your test harness (the Main() method in the Program Class), copy and paste the following code:

Movie terminator = new Movie("Terminator 2: Judgement Day", 1991, 105);

terminator.AddActor("Arnold Schwarzenegger");

terminator.SetGenre(GenreEnum.Horror | GenreEnum.Action);

terminator.AddActor("Linda Hamilton");

Show s1 = new Show(terminator, new Time(11, 35), DayEnum.Mon, 5.95);

Console.WriteLine(s1);



Console.WriteLine(s1);              //displays one object

Theatre eglinton = new Theatre("Cineplex");

eglinton.AddShow(s1);

eglinton.PrintShows();              //displays one object



Movie godzilla = new Movie("Godzilla 2014", 2014, 123);

godzilla.AddActor("Aaron Johnson");

godzilla.AddActor("Ken Watanabe");

godzilla.AddActor("Elizabeth Olsen");

godzilla.SetGenre(GenreEnum.Action | GenreEnum.Documentary | GenreEnum.Comedy);



Movie trancendence = new Movie("Transendence", 2014, 120);

trancendence.AddActor("Johnny Depp");

trancendence.AddActor("Morgan Freeman");

trancendence.SetGenre(GenreEnum.Comedy);

eglinton.AddShow(new Show(trancendence, new Time(18, 5), DayEnum.Sun, 7.87));



Movie m1 = new Movie("The Shawshank Redemption", 1994, 120);

m1.AddActor("Tim Robbins");

m1.AddActor("Morgan Freeman");

m1.SetGenre(GenreEnum.Action);

eglinton.AddShow(new Show(m1, new Time(14, 5), DayEnum.Sun, 8.87));



Movie avengers = new Movie("Avengers: Endgame", 2019, 120);

avengers.AddActor("Robert Downey Jr.");

avengers.AddActor("Chris Evans");

avengers.AddActor("Chris Hemsworth");

avengers.AddActor("Scarlett Johansson");

avengers.AddActor("Mark Ruffalo");

avengers.SetGenre(GenreEnum.Action | GenreEnum.Fantasy | GenreEnum.Adventure);

eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));



m1 = new Movie("Olympus Has Fallen", 2013, 120);

m1.AddActor("Gerard Butler");

m1.AddActor("Morgan Freeman");

m1.SetGenre(GenreEnum.Action);

eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Sun, 8.87));



m1 = new Movie("The Mask of Zorro", 1998, 136);

m1.AddActor("Antonio Banderas");

m1.AddActor("Anthony Hopkins");

m1.AddActor("Catherine Zeta-Jones");

m1.SetGenre(GenreEnum.Action | GenreEnum.Romance);

eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Sun, 8.87));



m1 = new Movie("Four Weddings and a Funeral", 1994, 117);

m1.AddActor("Hugh Grant");

m1.AddActor("Andie MacDowell");

m1.AddActor("Kristin Scott Thomas");

m1.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);

eglinton.AddShow(new Show(m1, new Time(15, 5), DayEnum.Sat, 8.87));

eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Tue, 6.50));



m1 = new Movie("You've Got Mail", 1998, 119);

m1.AddActor("Tom Hanks");

m1.AddActor("Meg Ryan");

m1.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);

eglinton.AddShow(new Show(m1, new Time(15, 5), DayEnum.Sat, 8.87));



m1 = new Movie("The Poison Rose", 2019, 98);

m1.AddActor("John Travolta");

m1.AddActor("Morgan Freeman");

m1.AddActor("Brendan Fraser");

m1.SetGenre(GenreEnum.Action | GenreEnum.Romance);

eglinton.AddShow(new Show(m1, new Time(22, 5), DayEnum.Sun, 10.25));



Movie car3 = new Movie("Cars 3", 2017, 109);

car3.AddActor("Owen Williams");

car3.AddActor("Cristela Alonzo");

car3.AddActor("Arnie Hammer");

car3.AddActor("Chris Cooper");

car3.SetGenre(GenreEnum.Comedy | GenreEnum.Animation | GenreEnum.Romance);

eglinton.AddShow(new Show(car3, new Time(09, 55), DayEnum.Sat, 6.40));

eglinton.AddShow(new Show(car3, new Time(11, 05), DayEnum.Sat, 6.50));



Movie toys4 = new Movie("Toys Story 4", 2019, 89);

toys4.AddActor("Keanu Reeves");

toys4.AddActor("Christina Hendricks");

toys4.AddActor("Tom Hanks");

toys4.AddActor("Tim Allen");

toys4.SetGenre(GenreEnum.Comedy | GenreEnum.Fantasy | GenreEnum.Animation);

eglinton.AddShow(new Show(toys4, new Time(14, 10), DayEnum.Sat, 6.40));



eglinton.AddShow(new Show(godzilla, new Time(13, 55), DayEnum.Mon, 6.89));

eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));

eglinton.AddShow(new Show(godzilla, new Time(14), DayEnum.Sun, 6.89));

eglinton.AddShow(new Show(toys4, new Time(14, 10), DayEnum.Sat, 6.40));

eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));

eglinton.AddShow(new Show(godzilla, new Time(16, 55), DayEnum.Sun, 6.89));

eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));

eglinton.AddShow(new Show(m1, new Time(20, 35), DayEnum.Sat, 10.25));

eglinton.AddShow(new Show(godzilla, new Time(22, 5), DayEnum.Wed, 8.50));

eglinton.AddShow(new Show(avengers, new Time(20, 30), DayEnum.Tue, 10.75));

eglinton.AddShow(new Show(godzilla, new Time(20, 15), DayEnum.Thu, 8.50));

eglinton.AddShow(new Show(avengers, new Time(20, 30), DayEnum.Wed, 10.75));

eglinton.AddShow(new Show(godzilla, new Time(18, 25), DayEnum.Fri, 8.50));

eglinton.AddShow(new Show(avengers, new Time(14, 15), DayEnum.Sun, 10.75));



eglinton.PrintShows();                                      //displays 27 objects

eglinton.PrintShows(DayEnum.Sun);                           //displays 8 objects

eglinton.PrintShows(GenreEnum.Action);                      //displays 19 objects

eglinton.PrintShows(GenreEnum.Romance);                     //displays 8 objects

eglinton.PrintShows(GenreEnum.Action | GenreEnum.Romance);  //displays 3 objects

eglinton.PrintShows("Morgan Freeman");                      //displays 5 objects



Time time = new Time(14, 05);

eglinton.PrintShows(time);                                  //displays 6 objects



eglinton.PrintShows(DayEnum.Sun, time);                     //displays 3 objects



##############################################
Output:

To understand what the code is doing, you will need to match the output to the appropriate code statements.



Mon 11:35 Terminator 2: Judgement Day (1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95



Cineplex

All shows

=============

 1: Mon 11:35 Terminator 2: Judgement Day (1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95



Cineplex

All shows

=============

 1: Mon 11:35 Terminator 2: Judgement Day (1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95

 2: Sun 18:05 Transendence (2014) 120min (Comedy) Johnny Depp, Morgan Freeman $7.87

 3: Sun 14:05 The Shawshank Redemption (1994) 120min (Action) Tim Robbins, Morgan Freeman $8.87

 4: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

 5: Sun 16:05 Olympus Has Fallen (2013) 120min (Action) Gerard Butler, Morgan Freeman $8.87

 6: Sun 16:05 The Mask of Zorro (1998) 136min (Action, Romance) Antonio Banderas, Anthony Hopkins, Catherine Zeta-Jones $8.87

 7: Sat 15:05 Four Weddings and a Funeral (1994) 117min (Comedy, Romance) Hugh Grant, Andie MacDowell, Kristin Scott Thomas $8.87

 8: Tue 16:05 Four Weddings and a Funeral (1994) 117min (Comedy, Romance) Hugh Grant, Andie MacDowell, Kristin Scott Thomas $6.50

 9: Sat 15:05 You've Got Mail (1998) 119min (Comedy, Romance) Tom Hanks, Meg Ryan $8.87

10: Sun 22:05 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

11: Sat 09:55 Cars 3 (2017) 109min (Animation, Comedy, Romance) Owen Williams, Cristela Alonzo, Arnie Hammer, Chris Cooper $6.40

12: Sat 11:05 Cars 3 (2017) 109min (Animation, Comedy, Romance) Owen Williams, Cristela Alonzo, Arnie Hammer, Chris Cooper $6.50

13: Sat 14:10 Toys Story 4 (2019) 89min (Animation, Comedy, Fantasy) Keanu Reeves, Christina Hendricks, Tom Hanks, Tim Allen $6.40

14: Mon 13:55 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

15: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

16: Sun 14:00 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

17: Sat 14:10 Toys Story 4 (2019) 89min (Animation, Comedy, Fantasy) Keanu Reeves, Christina Hendricks, Tom Hanks, Tim Allen $6.40

18: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

19: Sun 16:55 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

20: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

21: Sat 20:35 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

22: Wed 22:05 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $8.50

23: Tue 20:30 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75

24: Thu 20:15 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $8.50

25: Wed 20:30 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75

26: Fri 18:25 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $8.50

27: Sun 14:15 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75



Cineplex

Movies on Sun

=============

 1: Sun 18:05 Transendence (2014) 120min (Comedy) Johnny Depp, Morgan Freeman $7.87

 2: Sun 14:05 The Shawshank Redemption (1994) 120min (Action) Tim Robbins, Morgan Freeman $8.87

 3: Sun 16:05 Olympus Has Fallen (2013) 120min (Action) Gerard Butler, Morgan Freeman $8.87

 4: Sun 16:05 The Mask of Zorro (1998) 136min (Action, Romance) Antonio Banderas, Anthony Hopkins, Catherine Zeta-Jones $8.87

 5: Sun 22:05 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

 6: Sun 14:00 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

 7: Sun 16:55 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

 8: Sun 14:15 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75



Cineplex

Action movies

=============

 1: Mon 11:35 Terminator 2: Judgement Day (1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95

 2: Sun 14:05 The Shawshank Redemption (1994) 120min (Action) Tim Robbins, Morgan Freeman $8.87

 3: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

 4: Sun 16:05 Olympus Has Fallen (2013) 120min (Action) Gerard Butler, Morgan Freeman $8.87

 5: Sun 16:05 The Mask of Zorro (1998) 136min (Action, Romance) Antonio Banderas, Anthony Hopkins, Catherine Zeta-Jones $8.87

 6: Sun 22:05 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

 7: Mon 13:55 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

 8: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

 9: Sun 14:00 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

10: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

11: Sun 16:55 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

12: Sat 21:05 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $12.25

13: Sat 20:35 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

14: Wed 22:05 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $8.50

15: Tue 20:30 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75

16: Thu 20:15 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $8.50

17: Wed 20:30 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75

18: Fri 18:25 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $8.50

19: Sun 14:15 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75



Cineplex

Romance movies

=============

 1: Sun 16:05 The Mask of Zorro (1998) 136min (Action, Romance) Antonio Banderas, Anthony Hopkins, Catherine Zeta-Jones $8.87

 2: Sat 15:05 Four Weddings and a Funeral (1994) 117min (Comedy, Romance) Hugh Grant, Andie MacDowell, Kristin Scott Thomas $8.87

 3: Tue 16:05 Four Weddings and a Funeral (1994) 117min (Comedy, Romance) Hugh Grant, Andie MacDowell, Kristin Scott Thomas $6.50

 4: Sat 15:05 You've Got Mail (1998) 119min (Comedy, Romance) Tom Hanks, Meg Ryan $8.87

 5: Sun 22:05 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

 6: Sat 09:55 Cars 3 (2017) 109min (Animation, Comedy, Romance) Owen Williams, Cristela Alonzo, Arnie Hammer, Chris Cooper $6.40

 7: Sat 11:05 Cars 3 (2017) 109min (Animation, Comedy, Romance) Owen Williams, Cristela Alonzo, Arnie Hammer, Chris Cooper $6.50

 8: Sat 20:35 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25



Cineplex

Action, Romance movies

=============

 1: Sun 16:05 The Mask of Zorro (1998) 136min (Action, Romance) Antonio Banderas, Anthony Hopkins, Catherine Zeta-Jones $8.87

 2: Sun 22:05 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

 3: Sat 20:35 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25



Cineplex

Morgan Freeman movies

=============

 1: Sun 18:05 Transendence (2014) 120min (Comedy) Johnny Depp, Morgan Freeman $7.87

 2: Sun 14:05 The Shawshank Redemption (1994) 120min (Action) Tim Robbins, Morgan Freeman $8.87

 3: Sun 16:05 Olympus Has Fallen (2013) 120min (Action) Gerard Butler, Morgan Freeman $8.87

 4: Sun 22:05 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25

 5: Sat 20:35 The Poison Rose (2019) 98min (Action, Romance) John Travolta, Morgan Freeman, Brendan Fraser $10.25



Cineplex

Movies @14:05

=============

 1: Sun 14:05 The Shawshank Redemption (1994) 120min (Action) Tim Robbins, Morgan Freeman $8.87

 2: Sat 14:10 Toys Story 4 (2019) 89min (Animation, Comedy, Fantasy) Keanu Reeves, Christina Hendricks, Tom Hanks, Tim Allen $6.40

 3: Mon 13:55 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

 4: Sun 14:00 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

 5: Sat 14:10 Toys Story 4 (2019) 89min (Animation, Comedy, Fantasy) Keanu Reeves, Christina Hendricks, Tom Hanks, Tim Allen $6.40

 6: Sun 14:15 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75



Cineplex

Sun movies @14:05

=============

 1: Sun 14:05 The Shawshank Redemption (1994) 120min (Action) Tim Robbins, Morgan Freeman $8.87

 2: Sun 14:00 Godzilla 2014 (2014) 123min (Action, Comedy, Documentary) Aaron Johnson, Ken Watanabe, Elizabeth Olsen $6.89

 3: Sun 14:15 Avengers: Endgame (2019) 120min (Action, Adventure, Fantasy) Robert Downey Jr., Chris Evans, Chris Hemsworth, Scarlett Johansson, Mark Ruffalo $10.75





