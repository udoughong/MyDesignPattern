using System;

namespace SDP_PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterRegistry mr = new MonsterRegistry();
            UsingPrototype(mr);
            UsingPrototypeManager(mr);
            Console.ReadLine();
        }

        private static void UsingPrototypeManager(MonsterRegistry mr)
        {
            Console.WriteLine("Using prototype manager start...");
            mr.RegisterMonster("Cyborg", new Cyborg());
            mr.RegisterMonster("Alien", new Alien());
            mr.RegisterMonster("Acid", new Acid());
            Console.WriteLine("Getting instance of monsters through cloning...");
            Monster cyborg1 = mr.GetMonster("Cyborg");
            cyborg1.Attack();
            Monster alien1 = mr.GetMonster("Alien");
            alien1.Attack();
            Monster acid1 = mr.GetMonster("Acid");
            acid1.Attack();
            Console.WriteLine("Cloning the monsters...");
            Monster cyborg2 = cyborg1.Clone();
            cyborg2.Attack();
            Monster alien2 = alien1.Clone();
            alien2.Attack();
            Monster acid2 = acid1.Clone();
            acid2.Attack();
        }

        private static void UsingPrototype(MonsterRegistry mr)
        {
            Console.WriteLine("Using prototype start...");
            Monster cyborg1 = mr.CreateMonster("Cyborg");
            cyborg1.Attack();
            Monster alien1 = mr.CreateMonster("Alien");
            alien1.Attack();
            Monster acid1 = mr.CreateMonster("Acid");
            acid1.Attack();
            Console.WriteLine("Cloning the monsters...");
            Monster cyborg2 = cyborg1.Clone();
            cyborg2.Attack();
            Monster alien2 = alien1.Clone();
            alien2.Attack();
            Monster acid2 = acid1.Clone();
            acid2.Attack();
        }
    }
}
/*Output:
Using prototype start...
[Cyborg] Loading sounds
[Cyborg] Loading textures
[Cyborg] Attacking
[Alien] Loading sounds
[Alien] Loading textures
[Alien] Attacking
[Acid] Loading sounds
[Acid] Loading textures
[Acid] Attacking
Cloning the monsters...
[Cyborg] Attacking
[Alien] Attacking
[Acid] Attacking
Using prototype manager start...
[Cyborg] Loading sounds
[Cyborg] Loading textures
[Alien] Loading sounds
[Alien] Loading textures
[Acid] Loading sounds
[Acid] Loading textures
Getting instance of monsters through cloning...
[Cyborg] Attacking
[Alien] Attacking
[Acid] Attacking
Cloning the monsters...
[Cyborg] Attacking
[Alien] Attacking
[Acid] Attacking
*/
