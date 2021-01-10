using System;

namespace Delegate
{
    delegate int MyDelegate(int a, int b, int c);
    delegate int MathemathicDelegate(int a, int b);
    delegate int Del();
    delegate double ArrayDelegate(Del[] a);
    class Program
    {
        static void Main(string[] args)
        {
            #region First task
            MyDelegate myDelegate = (int x, int y, int c) => (x + y + c) / 3;
            Console.WriteLine($"Среднее арифметическое {myDelegate(2, 3, 4)}");
            #endregion
            #region Second task
            Console.WriteLine("Введите математическое действие: ");
            var sign = Convert.ToChar(Console.ReadLine());

            MathemathicDelegate add = (int x, int y) => (x + y);
            MathemathicDelegate minus = (int x, int y) => (x - y);
            MathemathicDelegate multiply = (int x, int y) => (x * y);
            MathemathicDelegate divide = (int x, int y) =>
           {
               if (y == 0) throw new ArgumentException();
               return x / y;

           };
            ChoseOperation(sign);

            static void Operation(int a, int b, MathemathicDelegate mathemathic)
            {
                var value = mathemathic(a, b);
                Console.WriteLine(value);
            }
            void ChoseOperation(char znak)
            {
                switch (sign)
                {
                    case '+':
                        Operation(5, 5, add);
                        break;
                    case '-':
                        Operation(5, 5, minus);
                        break;
                    case '*':
                        Operation(5, 5, multiply);
                        break;
                    case '/':
                        Operation(5, 5, divide);
                        break;
                    default:
                        Console.WriteLine("Нету такого действия");
                        break;
                }

            }
            #endregion
            #region third task
            static int GetRandom()
            {
                return new Random().Next(100);
            }

            Del[] arrayDelegate = new Del[10];
            for (int i = 0; i < arrayDelegate.Length; i++)
            {
                arrayDelegate[i] = () => new Del(GetRandom).Invoke();
            }
            ArrayDelegate array = delegate (Del[] dels)
            {
                double sum = 0;
                for (int i = 0; i < dels.Length; i++)
                {
                    sum += dels[i].Invoke();
                }
                return sum / dels.Length;
            };

            for (int i = 0; i < arrayDelegate.Length; i++)
            {
                Console.Write(arrayDelegate[i].Invoke() + " ");
            }
            Console.WriteLine($"Среднее число {array(arrayDelegate)}");
            #endregion

        }
    }
    }

