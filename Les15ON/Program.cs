using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Les15ON
{
    internal class Program
    {
        static void Main(string[] args)        
        {
            /*В массивах вы выполняли задание "Динамический массив"
Используя всё изученное, напишите улучшенную версию динамического массива(не обязательно брать своё старое решение)
Задание нужно, чтобы вы освоились с List и прощупали его преимущество. 
Проверка на ввод числа обязательна.
Пользователь вводит числа, и программа их запоминает. 
Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
Выход из программы должен происходить только в том случае, если пользователь введет команду exit.*/

            /*List<int> lst = new List<int>();
            string strSum = "sum";
            string strTmp = "";
            string strEx = "exit";
            bool isWork = true;
            int sum = 0;
            int numTmp = 0;

            while (isWork)
            {
                Console.Write("Enter num - > ");
                strTmp = Console.ReadLine();

                if (strEx == strTmp.ToLower())
                {
                    isWork = false;
                    continue;
                }

                if(strSum == strTmp.ToLower())
                {
                    
                    foreach(int i in lst)
                    {
                        sum += i;
                    }
                    Console.WriteLine("SUM is - " + sum);
                   

                }
                else
                {
                     if (int.TryParse(strTmp , out numTmp))
                    {
                        lst.Add(numTmp);
                    }
                    else
                    {
                        Console.WriteLine("Попробуй еще раз");
                    }
                }
            }
*/

/*
            int[,] matrix = new int[6, 8];
            int numMtrx = 1;
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 101);
                    Console.Write(matrix[i,j]+ "\t");
                }
                Console.WriteLine();
            }*/

/*
# hard
        Задача: 329.Longest increasing Part in a Matrix
Дана матрица целых чисел размером m x n. Верните длину самого длинного возрастающего пути в матрице.
Из каждой ячейки можно перемещаться в четырех направлениях: влево, вправо, вверх или вниз.Перемещение по диагонали или выход
                за границы матрицы(т.е.замкнутые переходы) не допускается.

👨‍💻 Алгоритм:

            1⃣Инициализация и создание матрицы:
Инициализируйте размеры матрицы m и n. Создайте матрицу matrix с добавленными границами(нулевыми значениями) вокруг исходной
                матрицы, чтобы избежать выхода за пределы при обработке.
Рассчитайте количество исходящих связей(outdegrees) для каждой клетки и сохраните их в outdegree.

2⃣Поиск начальных листьев:
            Найдите все клетки с нулевыми исходящими связями и добавьте их в список leaves.Эти клетки будут начальной точкой
                для "слоевого удаления".

3⃣Удаление слоев:
Повторяйте процесс удаления клеток уровня за уровнем в порядке топологической сортировки, пока не останется листьев. Обновляйте
                количество исходящих связей и добавляйте новые листья на следующем уровне.Подсчитывайте количество уровней,
                что в итоге даст длину самого длинного возрастающего пути.
*/


            Shop shop = new Shop();

            Queue<Shopper> sh  = new Queue<Shopper>();

            Shopper shoper;

            shop.CreateAssortment();

            sh = shop.CreateQueue();

            bool isBuy = true;

            //sh.Dequeue().ShowBascet();



            while(sh.Count > 0)
            {
                Console.WriteLine("Количество покупателей в очереди " + sh.Count);

                shoper = sh.Dequeue();

                isBuy = true;

               /* Console.WriteLine("Корзина покупателя "); 
                shoper.ShowBascet();

                //Console.WriteLine("Сумма корзины ");
                shoper.ShowSumBascet();*/

                while (isBuy)
                {
                    Console.WriteLine("Корзина покупателя ");
                    shoper.ShowBascet();

                    //Console.WriteLine("Сумма корзины ");
                    shoper.ShowSumBascet();
                    Console.WriteLine("Деньги покупателя " + shoper.money);

                    if (shoper.GetBascetSum() <= shoper.money)
                    {
                        shop.MoneyShop(shoper.GetBascetSum());
                        isBuy = false;
                    }
                    else
                    {
                       shop.TakeProduct(shoper.ReturnProduct(UserUtils.GenerateRandomNumber(0, shoper.GetCountProd())));
                    }

                }
                Console.WriteLine("Покупатель обслужен!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
