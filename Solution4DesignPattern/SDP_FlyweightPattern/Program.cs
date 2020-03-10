using System;

namespace SDP_FlyweightPattern
{
    class Program
    {
        static Random r = new Random();
        static readonly int MAX_OBJECTS = 10000;
        static void Main(string[] args)
        {
            WithoutFlyweight();
            WithFlyweight();
            Console.ReadLine();
        }
        static void WithoutFlyweight()
        {
            Console.WriteLine("Without flyweight");
            Character[] c = new Character[MAX_OBJECTS];
            for (int i = 0; i < MAX_OBJECTS; ++i)
            {
                c[i] = new Character("Arial",r.Next(8,12),(char)r.Next(65,122),new Position(1,1));
            }
            Console.WriteLine("Total objects created:{0}",Character.GetCount());
        }

        private static void WithFlyweight()
        {
            Console.WriteLine("With flyweight");
            FlyweightCharacter[] c = new FlyweightCharacter[MAX_OBJECTS];
            CharacterFactory f = new CharacterFactory();
            for (int i = 0; i < MAX_OBJECTS; ++i)
            {
                c[i] = f.GetCharacter("Arial", r.Next(8, 12), (char)r.Next(65, 122));
            }
            Console.WriteLine("Total objects created:{0}", FlyweightCharacter.GetCount());
        }

    }
}
/*Output:
Without flyweight
Total objects created:10000
With flyweight
Total objects created:228
*/
