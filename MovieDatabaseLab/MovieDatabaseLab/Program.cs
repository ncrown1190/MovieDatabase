// See https://aka.ms/new-console-template for more information
using MovieDatabaseLab;
using System.Linq;

//Console.WriteLine("Hello, World!");

/*  In your program.cs file, create a List<Movie> and store at least 10 movies there. 
 *  You can use literals to construct the movies. Make sure to have a mixture of categories.
    Program constructs list properly—1 point
    Program puts at least 10 properly instantiated Movies into the List—1 point 
 */

List<string> category = new List<string>
{
   "Horror",
   "Science Fiction",
   "Comedy",
   "Romance"
};

List<Movie> movies = new List<Movie>
{
    new Movie("Terrifier", "Horror"),
    new Movie("Halloween", "Horror"),
    new Movie("Life Is Beautiful", "Comedy"),
    new Movie("The Hangover", "Comedy"),
    new Movie("Chucky", "Horror"),
    new Movie("Avatar", "Science Fiction"),
    new Movie("Casablanca", "Romance"),
    new Movie("Star Wars", "Sci-Fi"),
    new Movie("Scream", "Horror"),
    new Movie("Step Brothers", "Comedy")
};

/*  When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
    Program takes user input correctly—1 point
    Program gives explicit feedback if user enters invalid category—1 point
    Program iterates through List validly—1 point
    Program only outputs if movie matches category—1 point
 */
Console.Write("Category of Movies to select\n");
foreach (string c in category)
{
    Console.WriteLine($"  {c}");
}
do
{
    Console.Write("What category of movie you are interested? ");
    string userAnswer = Console.ReadLine();
    string userCategory = userAnswer.Trim().ToLower();

    List<Movie> movie = movies.Where(x => x.Category.ToLower() == userCategory).ToList();

    foreach (Movie m in movie)
    {
        //Console.WriteLine($"In {userAnswer} category, you can see : {m.Title}");
        Console.WriteLine($"In this category, you can see : {m.Title}");
    }
} while (TryAgain() == true);


static bool TryAgain()
{
    Console.Write("Do yo want continue? y/n: ");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower().Equals("y"))
    {
        return true;
    }
    else
    {
        Console.Write("Goodbye!");
        return false;
    }
}
