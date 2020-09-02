using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks; 

namespace Oto
{
    class Oto
    {
        static async void BPMLoop()
        {

            for (int i = 0; i <= 50; i++)
            {
                await Task.Delay(968);
                Console.Beep(800, 100);
                

            }

            //音を鳴らす
        }
        static async void JudgeLoop(double ms)
        {
            int count = 0;
            bool checkthousand = false;
            while (!checkthousand)
            {
                ms += 0.1;
                Console.WriteLine("{0:0.00}",ms);
                await Task.Delay(100);
                if (ms > 1)
                {
                    count++;
                }
                if (count >= 90)
                {
                    checkthousand = true;
                    Console.WriteLine("数値はこれ以上計測されません");
                }

            }
            

        }
       

        static void Main(string[] args)
        {
            Console.WriteLine("数字を入力するとゲームが始まります\n" +
                              "5.0を当ててください\n" +
                              "ノーツ数: 10");
            int BPM = int.Parse(Console.ReadLine());
            Console.WriteLine(BPM + "で開始します\n");

            int milliSeconds = 0;

            Oto.JudgeLoop(milliSeconds);
            Oto.BPMLoop();
            Console.ReadLine();
        }
    }
}
