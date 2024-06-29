int[] input = new int[6] {1,2,5,0,10,34};

void PrintArrByInd(int[] array, int index=0){
    if (index == array.Length) return;
    PrintArrByInd(array, index+1);
    Console.Write("{0} ",array[index]);
}

PrintArrByInd(input);