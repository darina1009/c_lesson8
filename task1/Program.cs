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

void orderArray(int[,] array){
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if(array[i, k]<array[i,k + 1]){
                int temp = array[i,k + 1];
                array[i, k + 1] = array[i,k];
                array[i,k] = temp;
            }
        }
    }
}

}


int[,] array2d = GetArray2d();
PrintArray(array2d);
orderArray(array2d);
PrintArray(array2d);