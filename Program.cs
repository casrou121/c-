using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Валерий Панков
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.


            //Анкета

            Console.WriteLine("Анкета");

            Console.Write("Введите имя:");
                string name = Console.ReadLine();
            Console.Write("Введите фамилию:");
                string lastname = Console.ReadLine();
            Console.Write("Введите возраст:");
                int age = int.Parse(Console.ReadLine());
            Console.Write("Введите рост в метрах:");
                double height = double.Parse(Console.ReadLine());
            Console.Write("Введите вес в килограммах:");
                double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Имя:" + name + "Фамилия:" + lastname + "Возраст:" + age + "Рост:" + height + "Вес:" + weight);

            Console.WriteLine(string.Format("Имя:{0} Фамилия:{1} Возраст:{2} Рост:{3} Вес:{4}", name, lastname, age, height, weight));
            
            Console.WriteLine($"Имя:{name} Фамилия:{lastname} Возраст:{age} Рост:{height} Вес:{weight} ");



            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.


            //Индекс массы тела

            double x;
            double y;

            x = Convert.ToDouble(height);
            y = Convert.ToDouble(weight);

            double z = x / (y * y);

           
            Console.WriteLine(z);

            //Написать программу обмена значениями двух переменных:

            //a) с использованием третьей переменной;


            Console.WriteLine("Введите переменную а:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b:");
            int b = int.Parse(Console.ReadLine());

            int t = a;
                         a = b;
                         b = t;

            Console.WriteLine(a);
            Console.WriteLine(b);


            //б) *без использования третьей переменной.

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();
                       
        }
    }
}
