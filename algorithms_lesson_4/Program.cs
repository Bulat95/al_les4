using System;

namespace algorithms_lesson_4
{
    class Program
    {
        static int myPositionX = 1;
        static int myPositionY = 0;
        static int[][] labirint;
        static void Main(string[] args)
        {
            // Так как спрашивать было уже слишком поздно я решил, что стартуем с противоположного угла (слева снизу) до пустой клетки (справа сверху). 
            labirint = new int [4][];
            labirint[0] = new int [] { 3, 3 };
            labirint[1] = new int [] { 1, 1, 1 };
            labirint[2] = new int [] { 0, 1, 0 };
            labirint[3] = new int [] { 0, 1, 0 };
            
            controller(myPositionX, myPositionY, labirint);
        }

        static void controller(int myPositionX, int myPositionY, int[][] arr) 
        {
            if (checkRight(myPositionX, myPositionY, labirint))
            {
                Console.WriteLine("Моя позиция была " + myPositionX + " " + myPositionY);
                myPositionX++;
                Console.WriteLine("Моя позиция стала " + myPositionX + " " + myPositionY);
            }

            if (checkUp(myPositionY, labirint))
            {
                Console.WriteLine("Моя позиция была " + myPositionX + " " + myPositionY);
                myPositionY++;
                Console.WriteLine("Моя позиция стала " + myPositionX + " " + myPositionY);
            }
            else { Console.WriteLine("Там стена"); }
        }
        static bool checkRight(int myPositionX, int myPositionY, int[][] labirint)
        {
            if (myPositionX < labirint[myPositionY].Length )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool checkUp(int y, int[][] arr)
        {
            if (y > 0 && (myPositionX != 1 || myPositionY != 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
