using System;
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();
    
        Console.WriteLine();
        Console.WriteLine($"Hi {first}, Welcome to the self improvement Journal ");
        Console.WriteLine();
        Console.WriteLine("Menu options");

        int userSelection = 0;

        while (userSelection != 5)
        {
            Console.WriteLine("What would you want to do? Select options below 1-5.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Fitness reporting Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            userSelection = int.Parse(Console.ReadLine());
 
            if (userSelection == 1)
            {
                Breathing breath1 = new Breathing();
                breath1.SetName("Breathing ");
                breath1.SetDescription("This activity will help you relax by walking you through breathing in and out");
                breath1.SetEndingText("I hope the Breathing Activity helped you relax");

                //Call the welcome message
                Console.WriteLine(breath1.WelcomeMsgInstruction());
                Console.Write("How Long in seconds will you like to do this Activity? ");
                int duration = int.Parse(Console.ReadLine());
                Console.WriteLine(breath1.StartBreathingActivity(duration));
            }
            else if (userSelection == 2)
            {
                Reflection reflect1 = new Reflection();
                reflect1.SetName("Reflection Activity");
                reflect1.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.\nYou will recognize the power you have and how you can use it in other aspects of your life.");
                reflect1.SetEndingText("I hope the Reflection Activity helped you focus");

                //Call and print the welcome message
                Console.WriteLine(reflect1.WelcomeMsgInstruction());
                Console.WriteLine();
                //Allow the user to pass an intended duration for this Activity
                Console.Write("How Long in seconds will you like to do this Activity? ");
                int duration = int.Parse(Console.ReadLine());

                //assign text attributes to the prompt questions
                reflect1._firstPrompt.Add("Think of a time when you stood up for someone else ");
                reflect1._firstPrompt.Add("Think of a time when you did something really difficult ");
                reflect1._firstPrompt.Add("Think of a time when you helped someone in need ");
                reflect1._firstPrompt.Add("Think of a time when you did something truly selfless ");

                //assign text attributes to the prompt follow up questions
                reflect1._followUpPrompt.Add("Why was this experience meaningful to you? ");
                reflect1._followUpPrompt.Add("Have you ever done anything like this before?");
                reflect1._followUpPrompt.Add("How did you get started? ");
                reflect1._followUpPrompt.Add("How did you feel when it was complete? ");
                reflect1._followUpPrompt.Add("What made this time different than other times when you were not as successful? ");
                reflect1._followUpPrompt.Add("What is your favorite thing about this experience? ");
                reflect1._followUpPrompt.Add("What could you learn from this experience that applies to other situations? ");
                //Call the method that will ensure that the reflection Activity is commenced and concluded
                Console.WriteLine(reflect1.StartReflectionActivity(duration));
                
                

            }
            else if (userSelection == 3)
            {
                //instantiate the Listing Activity
                Listing list1 = new Listing();

                //assign all the setters for this class
                list1.SetName("Listing Activity");
                list1.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                list1.SetEndingText("I hope the Listing Activity helped you focus");

                //Call and print the welcome message
                Console.WriteLine(list1.WelcomeMsgInstruction());
                Console.WriteLine();
                //Allow the user specify how long the activity will last
                Console.Write("How Long in seconds will you like to do this Activity? ");
                int duration = int.Parse(Console.ReadLine());

                //Assign text attributes to all Lisitng Prompt questions
                list1._ListPrompt.Add("Who are people that you appreciate? ");
                list1._ListPrompt.Add("What are personal strengths of yours? ");
                list1._ListPrompt.Add("Who are people that you have helped this week? ");
                list1._ListPrompt.Add("When have you felt the Holy Ghost this month? ");
                list1._ListPrompt.Add("Who are some of your personal heroes? ");
                //Assign text attributes to all listing follow up questions
                list1._followUpListPrompt.Add("Why was this experience meaningful to you? ");
                list1._followUpListPrompt.Add("Have you ever done anything like this before?");
                list1._followUpListPrompt.Add("How did you get started? ");
                list1._followUpListPrompt.Add("How did you feel when it was complete? ");
                list1._followUpListPrompt.Add("What made this time different than other times when you were not as successful? ");
                list1._followUpListPrompt.Add("What is your favorite thing about this experience? ");
                list1._followUpListPrompt.Add("What could you learn from this experience that applies to other situations? ");
                //Call and allow the listing Activity to run
                Console.WriteLine(list1.StartListingActivity(duration));
                }
                //A fourth activity to help fitness
                else if (userSelection == 4)
                {
                //Instantiate the fitness Activity
                FitnessActivity fit1 = new FitnessActivity();
                //Assign all the setters for this class
                fit1.SetName("Fitness Activity");
                fit1.SetDescription("This activity will help you get control of your mind and body by helping you do a simple fitness activity");
                fit1.SetEndingText("I hope the Fitness Activity helped you increase your alertness");

                // Call and print the welcome message for this activity
                Console.WriteLine(fit1.WelcomeMsgInstruction());
                Console.Write("How Long in seconds will you like to do this Activity? ");
                //Allow the user select the duration for this Activity
                int duration = int.Parse(Console.ReadLine());
                Console.WriteLine(fit1.StartFitnessActivity(duration));
            }
            //Termintate the program if user selects quit
            else if (userSelection == 5)
            {
                //display what is written in the journal
                Console.WriteLine("Thank you for participating. I hope you enjoyed your experience? ");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Invalid selection made. Please select from 1-5" );
            Console.WriteLine();
        }
    }
}