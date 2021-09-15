using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib mitu kraadi õues on;
            //kui õues on rohkem kui 35 kraadi, programm kuvab "päris palav on noh";
            //kui õues on 30 kuni 35 kraadi, programm kuvab "suht palav";
            //kui õues on 20 kuni 30 kraadi, programm kuvab "noo siuke kena ilm";
            //kui õues on 10 kuni 20 kraadi, programm kuvab "noo suht külmavõitu";
            //kui õues on 0 kuni 10 kraadi, programm kuvab "päris külm";
            //kui õues on alla 0 kraadi, programm kuvab "noo krdi suht külm on pigem jää koju :p";

            Console.WriteLine("mitu kraadi täna väljas on mees?!");
            int temp = Int32.Parse(Console.ReadLine());

            switch(temp)
            {
                case var _ when temp < 0:
                    Console.WriteLine("noo krdi suht külm pigem jää koju: p");
                    break;
                case var _ when temp >= 0 && temp <= 10:
                    Console.WriteLine("päris külm on");
                    break;
                case var _ when temp >= 10 && temp <= 20:
                    Console.WriteLine("noo suht külmavõitu");
                    break;
                case var _ when temp >= 20 && temp <= 30:
                    Console.WriteLine("noo siuke kena ilm isegi :D");
                    break;
                case var _ when temp >= 30 && temp <= 35:
                    Console.WriteLine("suht palav on");
                    break;
                default:
                    Console.WriteLine("noooo päris palav on");
                    break;
            }
        }
    }
}
