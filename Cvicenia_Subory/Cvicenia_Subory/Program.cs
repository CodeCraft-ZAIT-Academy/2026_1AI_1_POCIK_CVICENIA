namespace Cvicenie_subory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\pocikd26\Downloads\Logs_oneRow.log";


            //Zapis suborov 
            var newConstent = "Toto je nove.  \n";
            File.AppendAllText(path, newConstent);


            //Citanie suboru
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

        }
    }
}