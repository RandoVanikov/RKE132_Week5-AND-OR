//math >= 90; Bio >=90; Chem >=90

int math, bio, chem;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Bio result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chem result:");
chem = Int32.Parse(Console.ReadLine());

if (math >= 90 && bio >= 90 && chem >= 90)
{
    Console.WriteLine("Congrats! You are enrolled!");
}
else
{
    Console.WriteLine("Your application cannot be approved!");
}