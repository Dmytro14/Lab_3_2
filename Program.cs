using System;
using System.IO;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\C#\Вища математика.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Файл неможливо прочитати");
                Console.WriteLine(e.Message);
            }
            try
            {
                

                using (StreamWriter sw = new StreamWriter(@"D:\C#\Вища математика.txt"))
                {
                   
                    sw.WriteLine("Оцiнювання групи IK-11 \n\n" +
                        "Борщовецький Дмитро\t4 \n" +
                        "Вульчак Павло\t\t5 \n" +
                        "Горечий Юрiй\t\t4 \n" +
                        "Грозовський Владислав\t5 \n" +
                        "Захарчук Петро\t\t5 \n" +
                        "Iванова Ангелiна\t4 \n" +
                        "Кузьмiнський Вiталiй\t5 \n" +
                        "Кутасевич Владислав\t4 \n" +
                        "Лакус Михайло\t\t5 \n" +
                        "Мальгiн Павло\t\t5 \n" +
                        "Марчук	Дмитро\t\t5 \n" +
                        "Матiяш	Арсен\t\t5 \n" +
                        "Морас Артур\t\t4 \n" +
                        "Мiшакiн Максим\t\t5 \n" +
                        "Нiколайчук Богдан\t5 \n" +
                        "Павлюк	Роман\t\t4 \n" +
                        "Пригода Андрiй\t\t5 \n" +
                        "Рибак Юрiй\t\t5 \n" +
                        "Свiдрак Iван\t\t5 \n" +
                        "Сембай	Владислав\t4 \n" +
                        "Хом'як	Вiталiй\t\t5 \n" +
                        "Чабак Олег\t\t5 \n" +
                        "Янович	Олександра \t5 \n" +
                        "Ярема Назарiй\t\t4 \n" +
                        "Яцишин	Олександр\t5 \n");
                }
                Console.WriteLine("Записано!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Файл неможливо переписати");
                Console.WriteLine(e.Message);
            }
        }
    }
    }
