    int f = 1;
    Console.Write("enter the value: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        f = f * i;
    }
    Console.WriteLine("Factorial of {0} is :{1}", num, +f);


