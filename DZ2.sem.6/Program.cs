// напишите программу, которая найдет точку пересечения двух прямых
// заданных уравнением y = k1 * x + b1, y = k2 * x + b2
//значения k1,b1,k2 и b2 задаются пользователем

Console.WriteLine("Введите значение k1");
  double k1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите значение b1");
  double b1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите значение k2");
  double k2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите значение b2");
  double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
    else 
    {
        double x = Math.Round((b2 - b1)/(k1 - k2),2);
        double y = Math.Round(k1 *((b2 - b1)/(k1 - k2)) + b1,2);
       Console.WriteLine($"Точка пересечения двух прямых ({x};{y}) ");
    }
    
   
    