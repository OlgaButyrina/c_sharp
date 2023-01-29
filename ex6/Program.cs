Console.WriteLine ("Напишите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{ 
    Console.WriteLine ("УРА, это же МАША!");
}
else
{
    Console.Write ("Привет, ");
    Console.Write (username);
    Console.Write ("!");
}