Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "муталиб")
{
    Console.WriteLine("Мутя ты что ли.");     
}
else
{
    Console.Write("Салам,");
    Console.WriteLine(username);
}
