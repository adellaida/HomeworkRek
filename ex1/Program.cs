//void ShowNums (int num)
//{
//    Console.Write(num + " ");
//    if (num>1) ShowNums(num - 1);   
//}

//ShowNums(5);

int SumNums (int m, int n) {
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
Console.Write(SumNums(1, 15));
