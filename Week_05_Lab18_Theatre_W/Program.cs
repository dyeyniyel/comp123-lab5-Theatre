using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_05_Lab18_Theatre_W
{
    //DayEnum Enum
    public enum DayEnum
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }

    //GenreEnum Enum
    [Flags]
    public enum GenreEnum
    {  //added values for combinations of genre
        Unrated = 0,
        Action = 1,
        Comedy = 2,
        Horror = 4,
        Fantasy = 8,
        Musical = 16,
        Mystery = 32,
        Romance = 64,
        Adventure = 128,
        Animation = 256,
        Documentary = 512
    }
    //Time Struct for representing the time for the movie schedule
    public struct Time
    {
        //properties
        public int Hours { get; }
        public int Minutes { get; }
        //constructor
        public Time(int hours, int minutes = 0)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}", this.Hours, this.Minutes); //format time as "HH:MM"
        }

        public static bool operator ==(Time lhs, Time rhs) ///method to compare time within a 15-minute window
        {
            int lhsMinutes = lhs.Hours * 60 + lhs.Minutes;
            int rhsMinutes = rhs.Hours * 60 + rhs.Minutes;
            return Math.Abs(lhsMinutes - rhsMinutes) <= 15; //This  will return true if the difference between the two arguments is less than or equal to 15 minutes, otherwise it returns false
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }

    }

    //Movie class
    public class Movie 
    {
        //properties
        public int Length { get; }
        public int Year { get; }
        public String Title { get; }
        public GenreEnum Genre { get; private set; }
        public List<string> Cast { get; }

        //constructor
        public Movie(string title, int year, int length)
        {
            this.Title = title;
            this.Year = year;
            this.Length = length;
            this.Cast = new List<string>(); //Initialize the Cast property to an empty list of string.
        }
        //method to add an actor
        public void AddActor(string actor)
        {
            this.Cast.Add(actor);
        }
        //method to set movie genre
        public void SetGenre(GenreEnum genre)
        {
            this.Genre |= genre; //bitwise operator for combining genre
        }
    }

    //Struct representing a movie show
    public struct Show
    {
        //properties
        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        //constructor
        public Show(Movie movie, Time time, DayEnum day, double price)
        {
            this.Movie = movie;
            this.Time = time;
            this.Day = day;
            this.Price = price;
        }
        public override string ToString()
        {
            string actors = string.Join(", ", Movie.Cast); //string containing all the actor names separated by commas
            return $"Title: {Movie.Title}, Time: {Time.ToString()}, Day: {Day}, Price: {Price:C}, Actors: {actors}";
        }
    }

    //class representing a theater with shows
    public class Theatre
    {
        private List<Show> shows; //List to store the shows
        public string Name { get; } //Theater name

        //constructor
        public Theatre(string name)
        {
            this.Name = name;
            this.shows = new List<Show>(); //Initialize the Shows property to a new list of show
        }
        //method to add a show
        public void AddShow(Show show)
        {
            this.shows.Add(show);
        }

        //Method to print all shows
        public void PrintShows()
        {
            Console.WriteLine($"\n{Name}\nAll shows");
            Console.WriteLine(new string('=', 25));
            int count = 1;
            foreach (Show show in shows) //iterate list of shows
            {
                Movie movie = show.Movie; //retrieve the Movie object associated with the current Show object and assigns it to the movie variable.
                string actors = string.Join(", ", movie.Cast); //string containing the names of all the actors in the movie.
                string genres = string.Join(", ", Enum.GetValues(typeof(GenreEnum)) //creates a string "genres" that contains all the genres that the movie belongs to, except for the Unrated genre. The genres are separated by commas.
                    .Cast<GenreEnum>() //treat the genre values as part of the GenreEnum type
                    .Where(genre => genre != GenreEnum.Unrated && movie.Genre.HasFlag(genre)) //include  genre in the list only if it's not 'Unrated' and if the movie has this genre
                    .Select(genre => genre.ToString())); //convert each genre into a string output
                Console.WriteLine($"{count++}: {show.Day} {show.Time} {movie.Title} ({movie.Year}) {movie.Length}min ({genres}) {actors} {show.Price:C}");
            }
        }
        //method taking genre as an argument
        public void PrintShows(GenreEnum genre)
        {
            Console.WriteLine($"\n{Name}\nGenre: {genre}");
            Console.WriteLine(new string('=', 25));
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre)) //display output if movie's genre matches the specified genre
                {
                    Console.WriteLine($"{count++}: {show.Day} {show.Time} {show.Movie.Title} ({show.Movie.Year}) {show.Movie.Length}min ({show.Movie.Genre}) {string.Join(", ", show.Movie.Cast)} {show.Price:C}");
                }
            }
        }
        //method taking day as an argument
        public void PrintShows(DayEnum day)
        {
            Console.WriteLine($"\n{Name}\nDay: {day}");
            Console.WriteLine(new string('=', 25));
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day) //display output if movie's day matches the specified day
                {
                    Console.WriteLine($"{count++}: {show.Day} {show.Time} {show.Movie.Title} ({show.Movie.Year}) {show.Movie.Length}min ({show.Movie.Genre}) {string.Join(", ", show.Movie.Cast)} {show.Price:C}");
                }
            }
        }
        //method taking time as an argument
        public void PrintShows(Time time)
        {
            Console.WriteLine($"\n{Name}\nTime: {time}");
            Console.WriteLine(new string('=', 25));
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Time == time) //display output if movie's time matches the specified time
                {
                    Console.WriteLine($"{count++}: {show.Day} {show.Time} {show.Movie.Title} ({show.Movie.Year}) {show.Movie.Length}min ({show.Movie.Genre}) {string.Join(", ", show.Movie.Cast)} {show.Price:C}");
                }
            }
        }
        //method taking actor as an argument
        public void PrintShows(string actor)
        {
            Console.WriteLine($"\n{Name}\nActor: {actor}");
            Console.WriteLine(new string('=', 25));
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor)) //display output if movie's actor matches the specified actor
                {
                    Console.WriteLine($"{count++}: {show.Day} {show.Time} {show.Movie.Title} ({show.Movie.Year}) {show.Movie.Length}min ({show.Movie.Genre}) {string.Join(", ", show.Movie.Cast)} {show.Price:C}");
                }
            }
        }
        //method taking day and time values as arguments
        public void PrintShows(DayEnum day, Time time)
        {
            Console.WriteLine($"\n{Name}\nDay: {day}, Time: {time}");
            Console.WriteLine(new string('=', 25));
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time) //display output if movie's day and time matches the specified values
                {
                    Console.WriteLine($"{count++}: {show.Day} {show.Time} {show.Movie.Title} ({show.Movie.Year}) {show.Movie.Length}min ({show.Movie.Genre}) {string.Join(", ", show.Movie.Cast)} {show.Price:C}");
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //provided code from the lab
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
            Console.ReadKey();
        }
    }
}
