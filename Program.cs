Console.WriteLine("Tell me the X value");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tell me the Y value");
int Y = Convert.ToInt32(Console.ReadLine());

if (X < 0 & Y > 0)
    Console.WriteLine("they are at the Northwest");
else if (X < 0 & Y == 0)
    Console.WriteLine("they are at the west");
else if (X < 0 & Y < 0)
    Console.WriteLine("they are at the southwest");
else if (X == 0 & Y > 0)
    Console.WriteLine("they are at the north");
else if (X == 0 & Y == 0)
    Console.WriteLine("holy shit! the enemy is here!!");
else if (X == 0 & Y < 0)
    Console.WriteLine("they are at the south");
else if (X > 0 & Y > 0)
    Console.WriteLine("they are at the Northeast");
else if (X > 0 & Y == 0)
    Console.WriteLine("They are at the east");
else if (X > 0 & Y < 0)
    Console.WriteLine("they are at the southeast");
// was there a more simple way to do it?