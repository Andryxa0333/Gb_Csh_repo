Console.Write("Insert M number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert N number: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintFromMToN(int start, int finish){
    if (start == finish){
            Console.WriteLine(finish);
            return;
        } 
    if (start < finish){
        Console.WriteLine(start);
        PrintFromMToN(start+1, finish);
    }
    if(finish < start){
        Console.WriteLine(start);
        PrintFromMToN(start-1, finish);
    }
}

PrintFromMToN(M,N);