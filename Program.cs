Console.WriteLine ("Введите 5_значное число");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = new int [5];  
int work_number = number;
int i;
  if (number > 9999 && number < 100000)  
    {
      for (i = 0 ; i < array.Length ; i ++)
     {
      work_number = number % 10;
      array[i] = work_number;
      number /= 10;
     }
     if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine("Полиндром");
     else Console.WriteLine("НЕТ");
    }
  else Console.WriteLine("Incorrect number");
    
