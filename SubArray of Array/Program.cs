using System;

public class Program
{
    public static void Main()
    {
        int[] array = InputArray();                         //основной массив 
        int[] subArray = InputArray();                      // подмассив
        Console.WriteLine(IsSubArray(array,subArray));      //результат проверки на подмассив
    }
    public static int[] InputArray()                        //метод для считывания данных в массив
    {
        int count = Int32.Parse(Console.ReadLine()!);
        int[] array = new int[count];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = Int32.Parse(Console.ReadLine()!);
        }
        return array;
    }
    public static bool IsSubArray(int[] array, int[] subArray)  //метод проверяет подмассив в массиве
    {
        bool isSubArray = false;
        for (var i = 0; i <= array.Length - subArray.Length; i++)
        {
            isSubArray = true;
            for (var j = 0; j < subArray.Length; j++)
            {
                if (array[i + j] != subArray[j])
                {
                    isSubArray = false;
                    break;
                }
            }
            if (isSubArray)
            {
                break;
            }
        }
        return isSubArray;
    }
}