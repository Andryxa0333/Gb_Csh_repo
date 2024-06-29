Console.Write("Insert m number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert n number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int n, int m){
    if (n == 0){
        return m+1;
    }
    else if (m == 0){
        return Ackerman(n-1,1);
    }
    return Ackerman(n-1, Ackerman(n, m-1));
}

Console.WriteLine(Ackerman(n, m));