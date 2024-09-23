using System.Runtime.ConstrainedExecution;

namespace NewC_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGrandmothers;
            int minutesForOneGrandmother = 10;
            int numberGrandmothersPerHour = 6;
            int numberHours;
            int numberMinutes;
            int timeWhenThereNoQueue = 7;

            Console.Write($"Вам не пвезло и вы заболели и решили ранним утром придти в поликлинику что бы попасть без очереди, но встали слишком поздно и в {timeWhenThereNoQueue} утра уже образовалась очередь. Сколько бабушек вы видите перед собой: ");
            numberGrandmothers = Convert.ToInt32( Console.ReadLine() );

            numberHours = numberGrandmothers / numberGrandmothersPerHour;
            numberMinutes = numberGrandmothers * minutesForOneGrandmother - (numberHours * minutesForOneGrandmother);

            Console.WriteLine($"Придя рано утром в полеклинику Вы должны отстоять {numberHours} часов и {numberMinutes} минут. Удачи.");
        }
    }
}