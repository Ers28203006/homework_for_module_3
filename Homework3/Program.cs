using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeatCycle = true;
            int loopRepeatCondition;

            Random rnd = new Random();

            while (repeatCycle)
            {
            Console.WriteLine("Решение какой задачи вывести на экран? Введите от 1 до 5");
            int taskNumber = int.Parse(Console.ReadLine());



                switch (taskNumber)
                {
                    case 1:

                        /***- 1 -***/

                        int countSpaces = 0;

                        char characterEntered = ' ';

                        string stringEntered = null;

                        Console.WriteLine("         /***- 1 -***/");
                        Console.WriteLine();

                        Console.WriteLine("Введите строку символов или предложение для анализа:");

                        while (characterEntered != '.')
                        {
                            characterEntered = (char)Console.Read();

                            stringEntered = stringEntered + characterEntered;

                            if (characterEntered == ' ')
                            {
                                ++countSpaces;
                            }
                        }
                        Console.Write("Строка: ");
                        Console.WriteLine(stringEntered);
                        Console.Write("имеет ");
                        Console.Write(countSpaces);
                        Console.WriteLine(" пробелa");
                        Console.ReadLine();
                        break;

                    case 2:

                        /****- 2 -****/

                        Console.WriteLine("         /***- 2 -***/");
                        Console.WriteLine();

                        const int numberOfDigitsInTheTicket = 6;

                        int[] ticketNumber = new int[numberOfDigitsInTheTicket];
                        int tempNumber;

                        for (int i = 0; i < numberOfDigitsInTheTicket; i++)
                        {
                            Console.Write("Введите ");
                            Console.Write(i + 1);
                            Console.Write(" цифру билета: ");

                            tempNumber = Int32.Parse(Console.ReadLine());

                            ticketNumber[i] = tempNumber;
                        }

                        if (ticketNumber[0] + ticketNumber[1] + ticketNumber[2] ==
                            ticketNumber[3] + ticketNumber[4] + ticketNumber[5])
                        {

                            Console.WriteLine("Число билета счастливое!!!");

                        }

                        else
                        {

                            Console.WriteLine("Число билета будет обязательно счастливым в следующий раз!!!");

                        }

                        break;

                    case 3:

                        /****- 3 -****/

                        Console.WriteLine("         /***- 3 -***/");
                        Console.WriteLine();

                        Console.Write("Введите текст: ");
                        stringEntered = Console.ReadLine();

                        char[] forAnalyzingCharacterString = stringEntered.ToCharArray();

                        stringEntered = null;

                        int numericValueOfTheSymbol;

                        for (int i = 0; i < forAnalyzingCharacterString.Length; i++)
                        {
                            numericValueOfTheSymbol = (int)forAnalyzingCharacterString[i];

                            if(numericValueOfTheSymbol >= 65 && numericValueOfTheSymbol<=90)
                            {
                                numericValueOfTheSymbol += 32;
                            }

                            else if (numericValueOfTheSymbol >= 192 && numericValueOfTheSymbol <= 223)
                            {
                                numericValueOfTheSymbol += 32;
                            }

                            else if(numericValueOfTheSymbol>=97 && numericValueOfTheSymbol <= 122)
                            {
                                numericValueOfTheSymbol -= 32;
                            }

                            else if(numericValueOfTheSymbol >= 224 && numericValueOfTheSymbol <= 255)
                            {
                                numericValueOfTheSymbol -= 32;
                            }

                            forAnalyzingCharacterString[i] = (char)numericValueOfTheSymbol;
                            stringEntered += forAnalyzingCharacterString[i];
                        }

                        Console.WriteLine();
                        Console.WriteLine("Текст после преобразования имеет вид:");
                        Console.WriteLine(stringEntered);

                        break;
                    case 4:
                        /****- 4 -****/

                        Console.WriteLine("         /***- 4 -***/");
                        Console.WriteLine();


                        int lowerRange = rnd.Next(1, 4);
                        int upperRange = rnd.Next(5, 8);

                        int[][] gearArray = new int[upperRange - lowerRange][];

                        for (int i = 0; i < gearArray.Length; i++)
                        {

                            gearArray[i] = new int[lowerRange+i];

                            for (int j = 0; j < lowerRange+i; j++)
                            {

                                gearArray[i][j] = lowerRange + i;

                                Console.Write(gearArray[i][j]);
                                Console.Write(" ");

                            }
                            Console.WriteLine();
                        }
                       
                       break;
                    case 5:

                        /****- 5 -****/

                        Console.WriteLine("         /***- 5 -***/");
                        Console.WriteLine();

                        int numberN = rnd.Next(100, 999);

                        Console.WriteLine();

                        Console.Write("Целое число: ");
                        Console.WriteLine(numberN);

                        const int sizeNumber = 3;
                        int[]flipNumber = new int[sizeNumber];

                        Console.Write("Перевернутый вид целого числа имеет вид: ");
                        for (int i = 0; i < flipNumber.Length; i++)
                        {
                            flipNumber[i] = numberN % 10;
                            numberN /= 10;

                            Console.Write(flipNumber[i]);
                        }
                        Console.WriteLine();

                        break;
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Желаете продолжить?");
                Console.WriteLine("1 - ДА");
                Console.WriteLine("0 - НЕТ");

                loopRepeatCondition = int.Parse(Console.ReadLine());

                switch (loopRepeatCondition)
                {
                    case 0:

                        repeatCycle = false;

                        break;
                    case 1:

                        System.Console.Clear();

                        break;
                }
            }
        }
    }
}
