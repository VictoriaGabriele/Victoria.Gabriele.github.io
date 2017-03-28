/*
 * Program by: Victoria Gabriele
 */

using System;


namespace BouncingBalls
{

    class Program
    {
        static void Main()
        {
            Field.Run();
        }
    }
    class Ball  
    {
        public string Name;
        public double Size;
        public string Colour;
        public bool Moving;


        public void Bouncing()
        {

            if (Moving == true)
            {
                Console.WriteLine(Name + " is bouncing");

            }
        }
           public void Rolling()
            {
             if (Moving == false)
            {
                Console.WriteLine(Name + " is Rolling");

            }
        }
        
    }

    class Field
    {
        static string Name = "The Field";
        static double Size = 48.5;
        public static void Run()
        {
            string input;
            Console.Title = "The Field";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string title = @"
            ______ __                  ____ ___       __

 ______  __                  ____                ___       __     
/\__  _\/\ \                /\  _`\   __        /\_ \     /\ \    
\/_/\ \/\ \ \___      __    \ \ \L\_\/\_\     __\//\ \    \_\ \   
   \ \ \ \ \  _ `\  /'__`\   \ \  _\/\/\ \  /'__`\\ \ \   /'_` \  
    \ \ \ \ \ \ \ \/\  __/    \ \ \/  \ \ \/\  __/ \_\ \_/\ \L\ \ 
     \ \_\ \ \_\ \_\ \____\    \ \_\   \ \_\ \____\/\____\ \___,_\
      \/_/  \/_/\/_/\/____/     \/_/    \/_/\/____/\/____/\/__,_ / ";

            Console.WriteLine(title);
            Console.WriteLine("Welcome to " + Name + " It is " + Size + " by 109.1 meaters ");
            Console.WriteLine("Bouncing Balls created by Victoria G. \n\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();
          
           

            Ball SoccerBall = new Ball();
            SoccerBall.Colour = "White";
            SoccerBall.Size = 22;
            SoccerBall.Moving = false;
            SoccerBall.Bouncing();
            SoccerBall.Rolling();

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            SoccerBall.Name = "Soccer Ball";
            Console.WriteLine("The first ball in the field you come across is a " + SoccerBall.Name + " Would you like to give it a nickname?" );
            input = Console.ReadLine();

            if (input.ToLower() == "yes") 
            {
                Console.WriteLine("What would you like to name the " + SoccerBall.Name); 
                SoccerBall.Name = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You have decided not to give the ball a nickname");
            }
            Console.WriteLine("The " + SoccerBall.Name + " is " + SoccerBall.Colour + " and is " + SoccerBall.Size + " cm in diameter");
            
            Console.ReadLine();


            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
                
            Ball BasketBall = new Ball();
            BasketBall.Size = 29;
            BasketBall.Name = "Basketball";
            BasketBall.Colour = "Orange";
            BasketBall.Moving = true;
            BasketBall.Bouncing();
            BasketBall.Rolling();
            Console.WriteLine("The second ball in the field you come across is a " + BasketBall.Name);
            input = Console.ReadLine();
            Console.WriteLine("The current size of " + BasketBall.Name + " is " + BasketBall.Size + " cm in diameter. enter a number to change the size.");
            input = Console.ReadLine(); 
            BasketBall.Size = Int32.Parse(input);
           
            
            Console.WriteLine("The " + BasketBall.Name + " is " + BasketBall.Colour + " and is " + BasketBall.Size + " cm in diameter");
            Console.ReadLine();

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Ball TennisBall = new Ball();
            TennisBall.Size = 2.9;
            TennisBall.Name = "Tennis Ball";
            TennisBall.Colour = "Green";
            TennisBall.Moving = true;
            TennisBall.Bouncing();
            TennisBall.Rolling();
            Console.WriteLine("The last ball in the field you come across is a " + TennisBall.Name );

            Console.WriteLine("The " + TennisBall.Name + " is " + TennisBall.Colour + " Would you like to change the colour of the " + TennisBall.Name + "?");
            input = Console.ReadLine();

            if (input.ToLower() == "yes")
            {
                Console.WriteLine("What colour would you like the  " + TennisBall.Name + " to be?");
                TennisBall.Colour = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You have decided not to change the colour");
            }
            Console.WriteLine("The " + TennisBall.Name + " is " + TennisBall.Colour + " and is " + TennisBall.Size + " cm in diameter");
            Console.ReadLine();



        }
    }

}

