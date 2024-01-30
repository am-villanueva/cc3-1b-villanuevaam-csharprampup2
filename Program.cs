namespace CSharpRampUp
{
    class Program
    {
        static void Main()
        {
            // Part 1 (Input and Conversion)
            Console.Write("Enter Weight in Pounds (lbs): ");
            double weightInPounds = GetDoubleInput();
            double weightInKilograms = weightInPounds * 0.45359237;
            Console.WriteLine("Weight when converted to Kilograms (kg): " + weightInKilograms);

            Console.Write("Enter Length in Miles (mi): ");
            double lengthInMiles = GetDoubleInput();
            double lengthInKilometers = lengthInMiles * 1.60934;
            Console.WriteLine("Length when converted to Kilometers (km): " + lengthInKilometers);

            Console.Write("Enter Temperature of Fahrenheit (°F): ");
            double tempInFahrenheit = GetDoubleInput();
            double tempInCelsius = (tempInFahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature when converted to Celsius (°C): " + tempInCelsius);

            double[] ages = new double[10];
            double sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Age of Student " + (i + 1) + ": ");
                ages[i] = GetDoubleInput();
                sum += ages[i];
            }

            double averageAge = sum / 10;
            Console.WriteLine("Ages of all students: " + string.Join(", ", ages));
            Console.WriteLine("The Average age of students: " + averageAge);

            // Story Section
            DisplayFantasyStory();

            // Part 2 - Number Patterns
            Console.Write("Enter a positive integer for the first pattern: ");
            int pattern1Input = GetPositiveIntInput();

            if (pattern1Input > 0)
            {
                Console.WriteLine("Pattern 1:");
                PrintNumberPattern1(pattern1Input);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("\nEnter a positive integer for the second pattern: ");
            int pattern2Input = GetPositiveIntInput();

            if (pattern2Input > 0)
            {
                Console.WriteLine("Pattern 2:");
                PrintNumberPattern2(pattern2Input);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("\nEnter a positive integer for the third pattern: ");
            int pattern3Input = GetPositiveIntInput();

            if (pattern3Input > 0)
            {
                Console.WriteLine("Pattern 3:");
                PrintNumberPattern3(pattern3Input);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        static double GetDoubleInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static int GetPositiveIntInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }
            return input;
        }

        static void PrintNumberPattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumberPattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumberPattern3(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void DisplayFantasyStory()
        {
            Console.WriteLine( 
@"Once upon a time in the mystical realm of Toothonia, where tooth fairies thrived and their powers knew no bounds, there
lived five remarkable tooth fairies, each possessing unique powers, distinct abilities, and magical items. Unlike any
other tooth fairies who collected children's lost teeth and left a shiny coin or a small treat in return, these five
fairies, Ari, Phia, Jho, Mader, and Zai used their unique powers, abilities, and magical items to make children's bedtime
a truly enchanting experience. As the young dreamers drifted into slumber, they knew that the fairies of Toothonia were 
watching over them, turning the ordinary act of losing a tooth into an extraordinary journey of dreams and possibilities.

Ari carried a crystal vial filled with Stardust Elixir, which granted children sweet and enchanting dreamswhen sprinkled 
over their pillows. To illuminate the darkest nights with her radiant wand, creating a soft glow that filled children's 
dreams with wonder.

Phia possessed a satchel of Gossamer Feathers, which, when blown into the wind, would carry children's dreams to the 
farthest corners of Toothonia. She could also communicate with animals, using her 'Whispering Quill' to write secret
messages and relay children's wishes to their furry and feathered friends.

Jho kept a Palette of Imagination, a magical paint palette that never ran out of colors and allowed her to create endless 
dreamscapes. She could paint the most vivid and fantastical dreams with her 'Prism Prism', bringing a burst of color and 
joy to the sleep of children.

Mader treasured a Starry Locket, which contained a piece of the nighttime sky and granted her the ability to navigate 
through dreams with ease. Mader wove intricate dream catchers with her net that could capture children's fears and replace 
them with dreams of courage and hope.

Zai held a Vial of Cosmic Dust, a shimmering substance that allowed her to create magical constellations in the night sky
as a reward for brave children. She shows children glimpses of their future potential through her 'Cosmic Mirror', inspiring 
them to chase their dreams."
            );
        }
    }
}
