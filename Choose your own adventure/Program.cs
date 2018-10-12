using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_your_own_adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string userHouse, userAnswer;
            //Give the user a scenario, ask them to choose a path

            while (true)
            {
                Console.WriteLine("Professor McGonnagall: 'Welcome to Hogwarts!  First years, please step up to the sorting hat.'");
                Console.WriteLine("Professor McGonangall places the sorting hat on your head.");
                Console.WriteLine("You suddenly hear a booming voice interrupt your thoughts.");
                Console.WriteLine("Sorting Hat: 'What is the nature of your heart?'");
                Console.WriteLine("You answer with: A) courage B) kindness C) truth D) ambition");
                userHouse = Console.ReadLine();

                switch (userHouse)
                {
                    //Gryffindor
                    case "A":
                    case "a":
                        Gryffindor();
                        break;
                    //Hufflepuff
                    case "B":
                    case "b":
                        Hufflepuff();
                        break;
                    //Ravenclaw
                    case "C":
                    case "c":
                        Ravenclaw();
                        break;
                    //Slytherin
                    case "D":
                    case "d":
                        Slytherin();
                        break;
                    //Muggle
                    default:
                        Console.WriteLine("Sorting Hat: 'Bah! You must be a squib, I don't sense a lick of magic in you.  Off you get.'");
                        Console.WriteLine("Your time at Hogwarts was short-lived.  You have been expelled.");
                        break;
                }

                //Ask user if they'd like to start over
                Console.WriteLine("Would you like to start over?  Type N to quit.");
                userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == "N")
                    {
                        break;
                    }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }

        public static void Gryffindor()
        {
            Console.WriteLine("'You have the heart of the lion.' The Sorting hat yells out: 'Gryffindor!'");
            Console.WriteLine("You take a seat at the Gryffindor table next to the house ghost and another first year.");
            Console.WriteLine("Will you talk to A) the ghost or B) the student?");
            string conversation = Console.ReadLine().ToUpper();
            if (conversation == "A")
            {
                Console.WriteLine("You turn to Nearly Headless Nick and ask him how long he has been Gryffindor's house ghost.");
                Console.WriteLine("Nick scoffs. 'Far longer than you can imagine, I dare say.'");
            }
            else
            {
                Console.WriteLine("You turn to the student on your right, and ask if they are happy they were sorted in Gryffindor.");
                Console.WriteLine("'Are you kidding me?  I'm over the moon!  All of my sisters were Hufflepuffs and my mother was ashamed.  I can't wait to tell her.'");
            }
        }

        public static void Hufflepuff()
        {
            Console.WriteLine("The sorting hat says, 'I sense that you have a pure heart.  I think Hufflepuff is the correct house for you.'");
            Console.WriteLine("You take a seat at the Hufflepuff table.  You see a feast laid out before you.");
            Console.WriteLine("There are so many options, will you start with A) yorkshire pudding or B) steak and kidney pie?");
            string conversation = Console.ReadLine().ToUpper();
            if (conversation == "A")
            {
                Console.WriteLine("You take a heaping portion of the yorkshire pudding.");
                Console.WriteLine("The second year across the table scolds you, 'Save some for the rest of us, won't you?'");
            }
            else
            {
                Console.WriteLine("You grab a serving of the steak and kidney pie.");
                Console.WriteLine("You take a bite and start to feel homesick, this pie tastes nothing like mother's.");
            }
        }

        public static void Ravenclaw()
        {
            Console.WriteLine("'You are cunning and seek the truth, Ravenclaw is the house for you!'");
            Console.WriteLine("You take a seat at the Ravenclaw table next to another first year.");
            Console.WriteLine("She asks 'Are you thinking of taking A) potions or B) herbology this year?'");
            string conversation = Console.ReadLine().ToUpper();
            if (conversation == "A")
            {
                Console.WriteLine("You reply 'I'm looking forward to potions, even though I've heard the professor is terrible.'");
                Console.WriteLine("She smiles, 'Yes, Snape can be awful but potions is a very useful skill to learn.'");
            }
            else
            {
                Console.WriteLine("You say 'I think I will sign up for Herbology.'");
                Console.WriteLine("She looks disappointed.  'Ah, I signed up for potions.  I think it will come in handy when we take our O.W.L.S.'");
            }
        }

        public static void Slytherin()
        {
            Console.WriteLine("The sorting hat smirks. 'I can sense great ambition in your heart, you belong in Slytherin!'");
            Console.WriteLine("You take a seat at the Slytherin table next to two first years.");
            Console.WriteLine("The student on your left asks, 'I can't wait to take our first flying lesson, how about you?'");
            Console.WriteLine("You feel A) terrified or B) excited to fly on a broom and learn quidditch.");
            string conversation = Console.ReadLine().ToUpper();
            if (conversation == "A")
            {
                Console.WriteLine("'Honestly I'm scared to death of flying' you reply.");
                Console.WriteLine("The other student smiles and whispers back 'Me too, I'm glad I'm not alone.'");
            }
            else
            {
                Console.WriteLine("You chuckle and say 'I can't wait!  I hope I can make it onto the quidditch team in time.'");
                Console.WriteLine("The other student frowns, 'Oh really?  Honestly I'm not looking forward to it.'");
            }
        }
    }
}
