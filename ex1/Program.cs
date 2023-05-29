void ShowNums (int num)
{
    Console.Write(num + " ");
    if (num>1) ShowNums(num - 1);
    
    
}

ShowNums(5);
