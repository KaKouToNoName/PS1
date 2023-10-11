// ********** 16 **********
Console.Write("Введите шестизначное число:");
int isAH = int.Parse(Console.ReadLine());
if ((isAH >= 1000000) || (isAH < 100000)) Console.WriteLine("Число меньше или больше допустимого значения");
else
{
    int isH1 = isAH + 1;
    int isH2 = isAH - 1;
    if (((isH1 / 100000) + (isH1 % 100000 / 10000) + (isH1 % 10000 / 1000) == (isH1 % 1000 / 100) + (isH1 % 100 / 10) + (isH1 % 10)) || ((isH2 / 100000) + (isH2 % 100000 / 10000) + (isH2 % 10000 / 1000) == (isH2 % 1000 / 100) + (isH2 % 100 / 10) + (isH2 % 10))) Console.WriteLine($"Да, {isAH} является почти счастливым");
    else Console.WriteLine($"Нет, {isAH} не является почти счастливым");
}
Console.WriteLine();
// ********** 7 **********
Console.WriteLine("Введите три числа - стороны треугольника");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if ((a + b > c) && (a + c > b) && (b + c > a)) Console.WriteLine("YES");
else Console.WriteLine("NO");
Console.WriteLine();
// ********** 18 **********
int count1 = 0;
Console.WriteLine("Введите два четырехзначных числа:");
int ffd = int.Parse(Console.ReadLine());
int sfd = int.Parse(Console.ReadLine());
string sffd = Convert.ToString(ffd), ssfd = Convert.ToString(sfd);
if ((ffd > 10000) || (sfd > 10000) || (ffd < 1000) || (sfd < 1000)) Console.WriteLine("Значения не подходят");
else
{
    for (int i = 0; i < 4; i++)
    {
        if (sffd[i] == ssfd[i]) count1++;
    }
}
Console.WriteLine(count1);
Console.WriteLine();
// ********** 9 **********
Console.WriteLine("Введите три коэффицента: ");int x2 = int.Parse(Console.ReadLine());int x = int.Parse(Console.ReadLine());int l = int.Parse(Console.ReadLine());
Console.WriteLine($"{(x2==0 ? "" : (x2==1 ? "x^2" : (x2!=-1 ? $"{x2}x^2" : "-x^2")))}{(x == 0 ? "" : ((x == 1)&&(x2!=0) ? "+x" : ((x==1)&&(x2==0)? "x" :((x > 1)&&(x2!=0) ? $"+{x}x" : ((x>1)&&(x2==0)? $"{x}x" : ( x==-1 ? "-x": $"{x}x"))))))}{(l == 0 ? "" : ((l > 0)&&(x2==0)&&(x==0) ? $"{l}" : (l>0 ? $"+{l}" : $"{l}")))}");