Console.WriteLine("Задание первое (64)");

void ShowNums (int n)
{
    Console.Write(n + " ");
    if (n>1) ShowNums(n - 1);   
}
ShowNums(5);
ShowNums(8);

Console.WriteLine("Задание второе (66)");

int Summa (int m, int n) {
    int sum =0;
    if (m<n) {
        while (n>=m) {
        sum = sum + m;
        m = m+1;
    }
    }
    else if (m>n) {
        while (n<=m) {
        sum = sum + n;
        n = n+1;
    }
    }
    else if (m==n) {
        sum = m;
    }
    return sum;
}
Console.WriteLine(Summa(1, 15));
Console.WriteLine(Summa(4,8));

Console.WriteLine("Задание третье (68)");

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(2, 3));
Console.WriteLine(Akk(3, 2));

