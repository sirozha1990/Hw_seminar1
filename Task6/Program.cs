﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Write("Введите трехзначное число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
FindThirdNumber(number); 
 
void FindThirdNumber(int num){ 
 int result=0; 
    if (num>999){ 
        while (num > 999){ 
            num = num/10; 
            if (num>99 && num<999){ 
                result=num %10;   
                Console.WriteLine("Третья цифра "+ number +" - "+result); 
            } 
        }  
    } else if (num>99 && num<999 ){ 
         result = num%10; 
         Console.WriteLine("Третья цифра " + " - "+result); 
    } 
    else if (num<100){  
    Console.WriteLine("третьей цифры нет"); 
     } 
 
    }
 