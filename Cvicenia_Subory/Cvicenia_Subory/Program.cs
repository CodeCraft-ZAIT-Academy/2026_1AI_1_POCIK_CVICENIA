
namespace Cvicenie_subory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\pocikd26\Downloads\Logs_big.log";







            var content = File.ReadAllLines(path);
            double error = 0;
            double warning = 0;
            double fatal = 0;
            double info = 0;



            foreach (var line in content)
            {



                if (line.Contains("WARNING"))
                {
                    warning++;

                }


                if (line.Contains("FATAL"))
                {
                    fatal++;

                }

                if (line.Contains("INFO"))
                {
                    info++;

                }

                if (line.Contains("ERROR"))
                {
                    error++;

                }
            }

                double total = content.Length;



                double errorPercent = (double)error / total * 100;
            Console.WriteLine("ERROR: " + error + " " + errorPercent.ToString() + "%");




            double warningPercent = (double)warning / total * 100;
            Console.WriteLine("WARNING: " + warning + " " + warningPercent.ToString() + "%");




            double fatalPercent = (double)fatal / total * 100;
            Console.WriteLine("FATAL: " + fatal + " " + fatalPercent.ToString() + "%");




            double infoPercent = (double)info / total * 100;
            Console.WriteLine("INFO: " + info + " " + infoPercent.ToString() + "%");



            }
        }
    }



//namespace Cvicenie_subory
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var path = @"C:\Users\pocikd26\Downloads\Logs_big.log";

//            // Načítanie súboru
//            var content = File.ReadAllLines(path);

//            // Počítadlá
//            int error = 0;
//            int warning = 0;
//            int fatal = 0;
//            int info = 0;

//            // Prechádzanie riadkov
//            foreach (var line in content)
//            {
//                if (line.Contains("ERROR"))
//                {
//                    error++;
//                }

//                if (line.Contains("WARNING"))
//                {
//                    warning++;
//                }

//                if (line.Contains("FATAL"))
//                {
//                    fatal++;
//                }

//                if (line.Contains("INFO"))
//                {
//                    info++;
//                }
//            }


//            int total = content.Length;


//            double errorPercent = (double)error / total * 100;
//            Console.WriteLine("ERROR: " + error + " " + errorPercent.ToString("F2") + "%");
//            double warningPercent = (double)warning / total * 100;
//            Console.WriteLine("WARNING: " + warning + " " + warningPercent.ToString("F2") + "%");
//            double fatalPercent = (double)fatal / total * 100;
//            Console.WriteLine("FATAL: " + fatal + " " + fatalPercent.ToString("F2") + "%");
//            double infoPercent = (double)info / total * 100;
//            Console.WriteLine("INFO: " + info + " " + infoPercent.ToString("F2") + "%");




//        }
//    }
//}