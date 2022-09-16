using System;
    namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Домашнее задание 1. Вывести на экран число е с точностью до десятых.");
            double e = Math.E;
            Console.WriteLine("{0:F1}", e);

            Console.WriteLine("Домашнее задание 2. Вывести на экран числа 50 и 10 одно под другим");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine("Домашнее задание 3. Вывести на экран столбиком четыре любых числа");
            Random rnd = new Random();
            int value = rnd.Next();
            Console.WriteLine(value);
            int value1 = rnd.Next();
            Console.WriteLine(value1);
            int value2 = rnd.Next();
            Console.WriteLine(value2);
            int value3 = rnd.Next();
            Console.WriteLine(value3);

            Console.WriteLine("Домашнее задание 4. Вывести число больше вводимого на 10");
            Console.WriteLine("Введите число");
            int f = int.Parse(Console.ReadLine());
            int summach = f + 10;
            Console.WriteLine($"Результат {summach}");

            Console.WriteLine("Домашнее задание 5. Дана сторона квадрата. Найти его периметр");
            Console.Write("Введите сторону квадрата ");
            int g = int.Parse(Console.ReadLine());
            int per = 4 * g;
            Console.WriteLine($"Периметр квадрата равен {per} ");

            Console.WriteLine("Домашнее задание 6. Дан радиус окружности. Найти длину окружности и площадь круга");
            Console.WriteLine("Введите радиус окружности");
            int r = int.Parse(Console.ReadLine());
            double dlinaokr = 2 * r * Math.PI;
            double ploschad = Math.PI * r * r;
            Console.WriteLine($"Длина окружности равна {dlinaokr}");
            Console.WriteLine($"Площадь круга равна {ploschad}");

            Console.WriteLine("Домашнее задание 7. Найти значение y=cos(x)");
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double xx = x * Math.PI / 180;
            double y = Math.Cos(xx);
            Console.WriteLine($" cos(x)={y}");

            Console.WriteLine("Домашнее задание 8. Даны основания и высота равнобедренной трапециию. Найдите ее периметр");
            Console.WriteLine("Введите основание 1");
            int osn1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание 2");
            int osn2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            int vys = int.Parse(Console.ReadLine());
            int perim = osn1 + osn2 / 2 * vys;
            Console.WriteLine($"Периметри равнобедренной трапеции равен {perim}");

            Console.WriteLine("Домашнее задание 9. Известна стоимость 1 кг конфет (15р), печенек (16р) и яблок(17р). Найти стоимость покупки");
            Console.WriteLine("Введите кол-во кг купленных конфет");
            int candy = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во кг купленных яблок ");
            int apple = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во кг купленных печенек");
            int cookie = int.Parse(Console.ReadLine());
            int all = candy * 15 + apple * 16 + cookie * 17;
            Console.WriteLine($"Стоимость не очень рациональной с точки зрения полезности покупки равна {all} рублей и гастрит");

            Console.WriteLine("Домашнее задание 10. МТМ");
            Console.WriteLine("МИР ТРУД МАЙ");
            Console.WriteLine("МИР");
            Console.WriteLine("     ТРУД");
            Console.WriteLine("             МАЙ");

            Console.WriteLine("Домашнее задание 13");
            Console.WriteLine("Введите число");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {ch}");

            Console.WriteLine("Домашнее задание 14");
            Console.WriteLine(" 2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("Домашнее задание 15");
            Random rnd1 = new Random();
            int value4 = rnd1.Next();
            Console.WriteLine(value4);
            int value5 = rnd1.Next();
            Console.WriteLine(value5);
            int value6 = rnd1.Next();
            Console.WriteLine(value6);
            int value7 = rnd1.Next();
            Console.WriteLine(value7);

            Console.WriteLine("Домашнее задание 16");
            Console.WriteLine("Поиск корней квадратного уравнения вида ax^2+bx+c");
            Console.WriteLine("Введите коэффицент a");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент b");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент c");
            double c1 = double.Parse(Console.ReadLine());
            double x1 = (-b1 + Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1)) / 2 * a1;
            double x2 = (-b1 - Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1)) / 2 * a1;
            Console.WriteLine($" x1 = {x1}");
            Console.WriteLine($" x2 = {x2}");

            Console.WriteLine("Домашнее задание 17");
            Console.WriteLine("Введите первое число");
            int chislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int chislo2 = int.Parse(Console.ReadLine());
            int mar = (chislo1 + chislo2) / 2;
            double mge = Math.Sqrt(chislo1 * chislo2);

            Console.WriteLine("Домашнее задание 18. Расстояние между точками");
            Console.WriteLine("Введите координаты первой точки в соответсвтие с осями x и y");
            Console.Write("Первая точка x: ");
            int xt1 = int.Parse(Console.ReadLine());
            Console.Write("Первая точка y: ");
            int yt1 = int.Parse(Console.ReadLine());
            Console.Write("Вторая точка x: ");
            int xt2 = int.Parse(Console.ReadLine());
            Console.Write("Вторая точка y: ");
            int yt2 = int.Parse(Console.ReadLine());
            double rass = Math.Sqrt(Math.Pow((xt2 - xt1), 2) + Math.Pow((yt2 - yt1), 2));
            Console.WriteLine($"Расстояние между точками равно {rass}");

            Console.WriteLine("Домашнее задание 19а");
            Console.Write("Введите значение a: ");
            int aa1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int bb1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            int cc1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {bb1} ");
            Console.WriteLine($"b = {cc1} ");
            Console.WriteLine($"c = {aa1} ");

            Console.WriteLine("Домашнее задание 19б");
            Console.Write("Введите значение a: ");
            int aaa1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int bbb1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            int ccc1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {ccc1} ");
            Console.WriteLine($"b = {aaa1} ");
            Console.WriteLine($"c = {bbb1} ");

            Console.WriteLine("Домашнее задание 20");
            Console.Write("Введите количество прошедший секунд ");
            int sek = int.Parse(Console.ReadLine());
            int hour = sek / 3600;
            int min = sek % 60;
            int sec = (sek - hour * 3600 - min * 60) % 360;
            Console.WriteLine($" {hour} часов {min} минут {sec} секунд");

            Console.WriteLine("Домашнее задание 21");
            int kva = (543 * 130) % (130 * 130);
            Console.Write($"Вот столько квадратиков можно вырезать: {kva}");

            Console.WriteLine("Домашнее задание 22");
            int l = 321;
            int w = l % 10;
            int nom1 = w * 100;
            int nom2 = l / 100;
            int nom3 = l - 100 * nom2;
            int nom4 = (nom3 - w) / 10;
            int nom5 = nom1 + 10 * nom2 + nom4;
            Console.WriteLine($"Из {l} в {nom5}");

            Console.WriteLine("Домашнее задание 23");
            Console.Write("Введите число больше 999: ");
            int sak = int.Parse(Console.ReadLine());
            int hun = sak / 100;
            int thous = sak / 1000;
            Console.WriteLine($"Число сотен равно {hun}, а число тысяч равно {thous}");

            Console.WriteLine("Домашнее задание 24");
            Console.Write("Введите четырехзначное число");
            int god = int.Parse(Console.ReadLine());
            Console.WriteLine("24a");
            int goda1 = god % 10;
            int goda2 = god % 100 - goda1;
            int goda3 = god % 1000 - goda1 - goda2;
            int goda4 = (god % 10000 - goda1 - goda2 - goda3) / 1000;
            int fgod = goda1 * 1000 + goda2 * 10 + goda3 / 10 + goda4;
            Console.WriteLine($" Число на выводе {fgod}");
            Console.WriteLine("24б");
            int godb1 = god % 10;
            int godb2 = god % 100 - godb1;
            int godb3 = god % 1000 - godb1 - godb2;
            int godb4 = (god % 10000 - godb1 - godb2 - godb3) / 1000;
            int ffgod = godb3 * 10 + godb4 * 100 + godb1 * 10 + godb2 / 10;
            Console.WriteLine($"Число на выводе {ffgod} ");
            Console.WriteLine("24в");
            int godc1 = god % 10;
            int godc2 = god % 100 - godc1;
            int godc3 = god % 1000 - godc2 - godc1;
            int godc4 = (god % 10000 - godc1 - godc2 - godc3);
            int fffgod = godc4 + godc2 * 10 + godc3 / 10 + godc1;
            Console.WriteLine($"Число на выводе {fffgod}");
            Console.WriteLine("24г");
            int godd1 = god % 10;
            int godd2 = god % 100 - godd1;
            int godd3 = god % 1000 - godd1 - godd2;
            int godd4 = (god % 10000 - godd1 - godd2 - godd3) / 1000;
            int ffffgod = godd2 * 100 + godd1 * 100 + godd4 * 10 + godd3 / 100;
            Console.WriteLine($" Число на выводе {ffffgod}");

            Console.WriteLine("Домашнее задание 25");
            Console.WriteLine("Введите трехзначное известное число");
            int somedigit = int.Parse(Console.ReadLine());
            int sd = somedigit / 100;
            int sd2 = somedigit - sd * 100;
            int sd3 = sd2 * 10 + sd;
            Console.WriteLine($"Искомое {sd3}");

            Console.WriteLine("Задание 26");
            int h = 14;
            int m = 38;
            int s = 21;
            int overall_h = h + m / 60 + s / 3600;
            Console.WriteLine(overall_h * 30);

            Console.WriteLine("Домашнее задание 28");
            Console.WriteLine("Введите число ");
            int n281 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите число ");
            int n282 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите число ");
            int n283 = Math.Abs(int.Parse(Console.ReadLine()));
            int mini1 = Math.Min(n281, n282);
            int mini2 = Math.Min(mini1, n283);
            Console.WriteLine($"Минимальное число = {mini2}");

            Console.WriteLine("Домашнее задание 29");
            Console.WriteLine("Введите число ");
            int num1 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите число ");
            int num2 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите число ");
            int num3 = Math.Abs(int.Parse(Console.ReadLine()));
            int min1 = Math.Min(num1, num2);
            int minim = Math.Min(min1, num3);
            int max1 = Math.Max(num1, num2);
            int max = Math.Max(max1, num3);
            Console.WriteLine(max - minim);

            Console.WriteLine("Домашнее задание 30");
            int fairy = 0;
            int numberr = 9;
            for (int i = 1; i <= numberr; i++)
                if (numberr % i == 0)
                    fairy += 1;
            Console.WriteLine(fairy);

            Console.WriteLine("Домашнее задание 31");
            int cnt = 0;
            Console.WriteLine("Чему равно a? ");
            double o = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно b? ");
            double p = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно c? ");
            double q = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно d? ");
            double v = int.Parse(Console.ReadLine());
            for (int x3 = -100; x3 <= 100; x3++)
                if ((o * Math.Pow(x3, 3) + p * Math.Pow(x3, 2) + q * 1 + v) == 0)
                    cnt++;
            Console.WriteLine(cnt);

            Console.WriteLine("Домашнее задание 32");
            int i1 = 2;
            int i2 = 3;
            int d = i2 - i1;
            Console.WriteLine("Введите элемент последовательности ");
            int n = int.Parse(Console.ReadLine());
            int an = i1 + d * (n - 1);
            Console.WriteLine($"{n} число последовательности = {an}");

            Console.WriteLine("Домашнее задание 33");
            Console.WriteLine("Ты пенсионер? ");
            string ans1 = Console.ReadLine();
            Console.WriteLine("Ты студент? ");
            string ans2 = Console.ReadLine();
            Console.WriteLine("Ты трудоустроен? ");
            string ans3 = Console.ReadLine();
            if ((((ans1 == "Да") || (ans1 == "да")) || ((ans2 == "Да") || (ans2 == "да"))) & ((ans3 == "Нет") || (ans3 == "нет")))
                Console.WriteLine("Получаю кредит");
            else if (((((ans1 == "Да") || (ans1 == "да")) || ((ans2 == "Да") || (ans2 == "да"))) & ((ans3 == "Да") || (ans3 == "да"))) || (((ans1 == "Да") || (ans1 == "да")) & ((ans2 == "Да") || (ans2 == "да"))))
                Console.WriteLine("Не получаю кредит");



























        }
    }
}