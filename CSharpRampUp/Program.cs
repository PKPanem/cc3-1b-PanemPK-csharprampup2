namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Weight in pounds(lbs):");
            float weight = Single.Parse(Console.ReadLine());
            double weight1 = weight * 0.453592;
            Console.WriteLine("Weight in pounds(lbs):" + weight);
            Console.WriteLine("Weight in kilograms(kg):" + weight1);
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter Distance in Miles:");
            float haba = Single.Parse(Console.ReadLine());
            double haba1 = haba * 1.60934;
            Console.WriteLine("Distance in Miles(mi):" + haba);
            Console.WriteLine("Distance in Kilometres(km):" + haba1);
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter Temparature in Fahrenheit:");
            float init = Single.Parse(Console.ReadLine());
            double init1 = (init - 32) * 5 / 9;
            Console.WriteLine("Temparature in Fahrenheit:" + init);
            Console.WriteLine("Temparature in Celsius:" + init1);
            Console.WriteLine("=====================================");
            Console.WriteLine("Age of Student 1:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 2:");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 3:");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 4:");
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 5:");
            int age4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 6:");
            int age5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 7:");
            int age6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 8:");
            int age7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 9:");
            int age8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 10:");
            int age9 = Convert.ToInt32(Console.ReadLine());
            double summary = (age + age1 + age2 + age3 + age4 + age5 + age6 + age7 + age8 + age9) / 10;
            Console.WriteLine("Mean Age of Students:" + summary);
            Console.WriteLine("=======================================");
            string name1 = "Jojo";
            string name2 = "Uncle Roger";
            string name3 = "Luna";
            string name4 = "Axel";
            string name5 = "Seraphina";
            string item1 = "Super Awesome Chef Knife";
            string item2 = "Pot of Destiny";
            string item3 = "secret spice salt";
            string story = @"In the mystical realm of Food warzz," + name1 + @" and his extraordinary team of chefs embarked on a culinary odyssey to defend their world from
the encroaching plague of blandness that threatened to engulf their beloved cuisine. Along their flavourful journey, they stumbled upon the" + item1 + @",
a pulsating culinary blade radiating immense gastronomical potential. This serendipitous discovery introduced them to the enigmatic knife, a culinary tool 
bestowed upon" + name1 + @"the remarkable ability to manipulate the taste buds of others. 

Their culinary confrontations against the malevolent chef" + name2 + @"pushed the limits of their newfound abilities and equipment."
 + name3 + @", the mystical mage of the kitchen, harnessed the essence of paprika, channeling the raw energy of spice into enchanting flavours that could 
transform even the blandest dishes into mouthwatering masterpieces." + name4 + @" the fearless culinary warrior, wielded the legendary" + item2 + @",
a cauldron forged through culinary craftsmanship, enabling him to cook any ingredient to perfection, regardless of its origin. "
+ name5 + @", the crafty rogue of the culinary world, unveiled her ability" + item3 + @", a unique seasoning blend that not only elevated the flavors of her 
dishes but also granted her the ability to replicate the culinary techniques and abilities of her adversaries, assuming the culinary personas and
giving her the edge in the most intense kitchen battles.

Together, they demonstrated that the unbreakable bonds of friendship and the harmonious synergy of their extraordinary culinary powers and equipment were
the secret ingredient to triumph over the peculiar gastronomic challenge of Food Warzz. Their journey ensured that their world remained a realm of culinary wonder,
where enchanting flavours and extraordinary dishes perpetually graced their tables.";
            Console.WriteLine(story);
            Console.WriteLine("==============================================================");
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else
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
            Console.WriteLine("Enter a positive number:");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= n1; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum is:" + sum);
            }
            Console.WriteLine("Enter a number:");
            int n3 = int.Parse(Console.ReadLine());
            if (n3 <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                for (int i = n3; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
