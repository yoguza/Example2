Console.WriteLine("Введите имя:");
string username = Console.ReadLine();

if(username.ToLower()=="маша")
{
    Console.WriteLine("Здравствуй, Машенька!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}