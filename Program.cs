Console.WriteLine ("Введите 5_значное число");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = {0, 0, 0, 0, 0};  
int work_number = number;
int i; int j;
if (number > 9999 && number < 100000)
  {
    for (i = 0 ; i < array.Length ; i ++);
    array [i] = work_number % 10;
    work_number = work_number / 10;
  }
else Console.WriteLine("Incorrect number");
if (array[1] == array[5] && array[2] == array[4]) Console.WriteLine("Полиндром");

for (j = 0 ; j < array.Length ; j ++);
    Console.WriteLine(array [j]);
