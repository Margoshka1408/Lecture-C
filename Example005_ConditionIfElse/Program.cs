Console.Write("Введите имя пользователя: ");
string username=Console.ReadLine();//ToLower позволяет писать любыми буквами
if (username.ToLower()=="Маша")
{
    Console.Write("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
