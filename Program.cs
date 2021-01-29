using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            int valid = 0;

            while (valid < 1)
            {
                Console.WriteLine("Hiya! What numerical grade do you expect to get in ISM 4300? Go ahead and round to the nearest whole number, would ya?");

                string input = Console.ReadLine();
                int grade_input = int.Parse(input);
                try
                {

                    if ((grade_input > 0) || (grade_input <= 100))
                    {
                        valid = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Beep Boop... does not compute. Lemme git that one mo' time");
                }
                    if ((grade_input >= 98) && (grade_input <= 100))
                    {
                        Console.WriteLine("Congrats you're getting an A+. Also, you should probably get out more.");
                    }
                    else if ((grade_input >= 92) && (grade_input <= 97))
                    {
                        Console.WriteLine("What's behind door number 2 Bob? Its an A! Nice Job!");
                    }
                    else if ((grade_input >= 90) && (grade_input <= 91))
                    {
                        Console.WriteLine("An A-! Close, but uhh not quite.");
                    }
                    else if ((grade_input >= 88) && (grade_input <= 89))
                    {
                        Console.WriteLine("You got a B+! Thats like a B, but marginally better!");
                    }
                    else if ((grade_input >= 82) && (grade_input <= 87))
                    {
                        Console.WriteLine("B is for Bees. Or boats. Or Banana. Or the grade that you got.");
                    }
                    else if ((grade_input >= 78) && (grade_input <= 79))
                    {
                        Console.WriteLine("You got a C+! Woo for high-end mediocrity.");
                    }
                    else if ((grade_input >= 72) && (grade_input <= 77))
                    {
                        Console.WriteLine("The grade you have received is a C. Thats it. Thats all I have to say about it.");
                    }
                    else if ((grade_input >= 70) && (grade_input <= 71))
                    {
                        Console.WriteLine("You are getting a C-. I too like to live dangerously.");
                    }
                    else if ((grade_input >= 68) && (grade_input <= 69))
                    {
                        Console.WriteLine("D+... a D+. Better luck next year, kid.");
                    }
                    else if ((grade_input >= 62) && (grade_input <= 67))
                    {
                        Console.WriteLine("You got a D. We gotta pump those numbers up! I mean it. Don't let that student debt accumulate for nothin'");
                    }
                    else
                    {
                        Console.WriteLine("Woah Woah Woah, something isnt right here. Try entering a number between 0 and 100!");
                    }
                }
                               
                }

            }
                     



                }

                

               

            
        
    
