int [] array={23,6,3,66,74,74,35};
int n=array.Length;//количество элементов массива
int find=74;
int index=0;
while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;//прерви
    }
    //index=index+1;
    index++;
}
