Console.Write("Введите имя пользователя: ");
string usermame = Console.ReadLine();

if(usermame.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(usermame);
}
