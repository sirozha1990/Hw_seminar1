/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Введите колличество чисел N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[n];

void InputNumbers(int n){
for (int i = 0; i < n; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Poz(int[] Numbers)
{
  int count = 0;
  for (int i = 0; i < Numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(n);

Console.WriteLine($"Введено чисел больше 0: {Poz(Numbers)} ");
