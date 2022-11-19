/*Задача 23: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
 3 -> 1, 8, 27
 5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int cub = Convert.ToInt32(Console.ReadLine());

void Cub(int[] cub){
  int num = 0;
  int length = cub.Length;
  while (num <  length){
    cub[num] = Convert.ToInt32(Math.Pow(num, 3));
    num++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cub+1];
Cub(arry);
PrintArry(arry);