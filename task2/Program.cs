int Promt(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}

int[,] GetArray2d(){
    int m = Promt("введите m");
    int n = Promt("введите n");
    int[,] array = new int[m, n];
    for(int i = 0; i<m; i++){
        for( int j = 0; j < n; j++){
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array; 
}

void PrintArray(int[,] array){//вывод массива
    for(int i= 0; i< array.GetLength(0);i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i, j] +" " );
        }
        Console.WriteLine();
    }
  
}

int SumElem(int[,] array, int i){
    int sum = array[i,0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];

    }
    return sum;
}



int[,] array2d = GetArray2d();
PrintArray(array2d);
int minSum = 0;
int Sum = SumElem(array2d, 0);
for (int i = 0; i < array2d.GetLength(0); i++)
{
    int tempSum = SumElem(array2d, i);
    if (Sum>tempSum)
    {
        Sum = tempSum;
        minSum = i;
    }
}

Console.WriteLine(minSum);