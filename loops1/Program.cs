using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //when would use a loop?
                //why would you use a loop?
                //nested loops

                //For Loops
                //can be used for both counting....
                //iterating through an array(or collection type)
                //looks like this
                //for initializer;condition;updater)
                //{
                //do something
                // //infinite loops for(int i = 0; i,<=10; i++)  // keywords break and continue
                //{
                //console.writeline(i);
                //}
                //    int i;
                //  for (int i = 15; i > 0; i--)
                {
                    //      Console.WriteLine(i);
                }

                //   Console.WriteLine("After the loop has run, i now has a value of " +  i);

                //  string greeting = "My name is Little Bill.";
                //the .Split method() takes a string and turns it into an array of smaller strings(substrings) it defaults the splits on spaces.
                //  string[] wordsInGreeting = greeting.Split();


                //    for (int i = 0; i < wordsInGreeting.Length; i++)
                {
                    //         Console.WriteLine(wordsInGreeting[i]);
                    //    }


                    //create an array called days with the elements Monday,Tuesday, and Wednesday.
                    //using a for loop, print the elements of the days array.

                    //string[] daysOfWeek = { "Monday", "Tuesday, Wednesday" };
                    // string [] weekdays = daysOfWeek.Split();
                    //for (int i=0; i < weekdays.Length; i++)
                    //{
                    //Console.WriteLine(weekdays[i]);
                    //}

                    //   string Story = "Once upon a time";
                    //  string[] wordinStory = Story.Split();
                    //array.reverse(wordinStory)

                    //    for (int i = 0; i < wordinStory.Length; i--)
                    //      {
                    //         Console.WriteLine(wordinStory[i]);


                    //  }

                    //      int [] numbers= {1,2,3,4,5,6,7,8,9,10}
                    //       int [i.Length; i++ )

                    //        {
                    //              product = product * numbers[i];
                    //       }

                    //Foreach loop-used to iterate over a collection (a list or array)
                    //you can think of the structure of a foreach loop as a structure of a foreach loop as the statement;
                    //foreach (data type variable in collection)
                    // do something
                    //}

                    //      string[] calendar = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
                    //foreach (string month in calendar)
                    //{
                    //    Console.WriteLine(month);

                    //}
                    //for each loop allow the temp variable to "know" to assign

                    //itself to each element in a collection(like an array), one at a time

                    //for each loop will always go from begin to end, no matter what
                    //it counts the number of elements in the collection,and runs that many times


                    //    string [] musicians = {"The Clash","The Beatles", "Rolling Stones", "Prince","David Bowie", "The Ramones"};

                    //     foreach(string bands in musicians)
                    //     {
                    //         Console.WriteLine(bands);
                    //      }

                    //while loops is used when you want a chunk of code to run only if a 
                    //a condition is met first
                    //while something is true, do this thing
                    //Console.WriteLine("What is your first name");
                    //string firstName = Console.ReadLine();
                    //while (firstName.ToUpper() == "Daniel")
                    //{
                    //    Console.WriteLine("Dude, you're amazing");
                    //    break;

                    //}

                    //Console.WriteLine("do you want to play the game? YES/NO");
                    //string playAgain = Console.ReadLine();
                    //while (playAgain == "YES")
                    //{
                    //    Console.WriteLine("It's a rematch");
                    //    Console.WriteLine("Do you want to play again? YES/NO");
                    //    playAgain = Console.ReadLine();
                    //}

                    //a do-while loop is similar to a while loop,however
                    //the do-while loop used when you want a chunk of code to run
                    //at least once, but repeat only if the while condition is met

                    //    string playAgain;
                    //    do
                    //    {
                    //        Console.WriteLine("Welcome to my game");
                    //        //lets pretend the code for game
                    //        Console.WriteLine("Great game!!");
                    //        Console.WriteLine("Do you want play again? YES or No");
                    //        playAgain = Console.ReadLine();
                    //    }

                    //    while (playAgain == "YES");

                    //}




                    //    string classOne;
                    //do
                    //{
                    //    Console.WriteLine("would you like to add a class to gpa calculation? YES or NO");
                    //    classOne = Console.ReadLine().ToLower();

                    //  Console.Write("What would you like to add to your GPA calculation");
                    //    Console.WriteLine("What is the letter grade for the class? no + or -");
                    //classOne= Console.Readline();
                    //  }
                    //    while (classOne == "YES") ;
                    //nested loops
                    //loop inside of another loop
                    //real life example a clock
                    //create a nested loop structure that prints:
                    // 1234
                    //1234

                    //for (int rows = 1; rows <= 2; rows ++ )
                    //{
                    //    for (int columns = 1; columns <= 4; columns++)

                    //    {
                    //        Console.Write(columns);
                    //    }
                    //    Console.WriteLine();


                    //}
                    // print a triangle 
                    // outer loop will go line by line
                    //the inner loop will go different elememts in the line.
                    //results:
                    //1
                    //12
                    //123
                    //1234 .....

                    //for (int rows = 1; rows <= 4; rows++)
                    //      for (int columns=1; columns <=rows; columns ++)


                    //    {
                    //            {
                    //                Console.Write(columns);

                    //            }
                    //            Console.WriteLine();


                    //int[] luckyNumbers = { 2, 4, 67, 3, 4 };
                    //foreach (int numbers in luckyNumbers)

                    //{

                    //    Console.WriteLine(numbers);


                    //}


                    //Console.WriteLine();


                    //        string[] movies = { "Godfather", "Network", "Major League", "Ace Ventura" };
                    //     foreach (string titles in movies)

                    //        {
                    //            if (movies.StartsWith("B") )
                    //            Console.WriteLine(movies);
                    //        }

                    //    }

                    //}
                }
            }
        }
    }
}
    

