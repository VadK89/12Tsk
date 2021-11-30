using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Tsk
{
    class Program
    {
        /*Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
         *  метод, определяющий длину окружности по заданному радиусу;
         *  метод, определяющий площадь круга по заданному радиусу;
         *  метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0. 
         */
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.WriteLine("Ввод исходных координат");
            Console.WriteLine("Введите значение радиуса окружности");
            Solut.rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату х0 центра окружности");
            Solut.x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату у0 центра окружности");
            Solut.y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату х точки");
            Solut.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату у точки");
            Solut.y = Convert.ToDouble(Console.ReadLine());
            //Вывод результов            
            Solut.Length();
            Solut.Area();
            Solut.CoordCheck();                        
            Console.ReadKey();


        }
    }
    //Задаем класс
    static class Solut
    {
        //Задаем переменные
        public static double rad;
        static double length;
        static double area;
        public static double x0;
        public static double y0;
        public static double x;
        public static double y;

      
       public static void Length()
       {
            if (rad >= 0)
            {
                length =2 * rad * Math.PI;
                Console.WriteLine("Длина окружности соcтавляет {0,0000:0.00} мм", length);
            }
            else
            {
                Console.WriteLine("Длина окружности не определена. Радиус отриательный или равен нулю.");
            }          
        }      
        public static void Area()
        {
            if (rad > 0)
            {
                area = Math.Pow(rad, 2) * Math.PI;
                Console.WriteLine("Площадь окружности составляет {00,0000:0.00} мм2", area);
            }
            else
            {
                Console.WriteLine("Площадь окружности не определена. Радиус отриательный или равен нулю.");
            }
        }
        public static void CoordCheck()
        {
            double chk = Math.Sqrt(Math.Pow((x-x0), 2) + Math.Pow((y-y0), 2));
            if (chk<=rad)
            {
                Console.WriteLine("Точка с координатами х и у принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка с координатами х и у не принадлежит кругу");
            }
        
        }
    }
}
