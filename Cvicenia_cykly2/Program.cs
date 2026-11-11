namespace Cvicenia_cykly2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pocet = 0; 
            List<Shopping_Item> shoppingList = new List<Shopping_Item>();

            // Shopping_Item shoppingItem1 = new Shopping_Item("Milk", 1.5);   ten 3karedsi sposob

            shoppingList.Add(new Shopping_Item("Mlieko", 2.55, pocet));
            shoppingList.Add(new Shopping_Item("Chlieb", 4.0, pocet));
            shoppingList.Add(new Shopping_Item("Jablko", 6.0, pocet));
            shoppingList.Add(new Shopping_Item("Rozok", 1.0, pocet));
            shoppingList.Add(new Shopping_Item("Milk", 2.23, pocet));



            foreach (var Item in shoppingList)
            {




            }



            //while (true)
            //{
            //    double sum = 0;
            //    foreach (var Item in shoppingList)
            //    {
            //        Console.WriteLine($"Item: {Item.Name},  cena: {Item.Price}");
            //        sum += Item.Price;
            //        Console.WriteLine("Vysledna cena je: " + sum);
                    //Item.IncreasePrice();
                    //Item.IncreasePricePlus5();
                    //Item.Info();
                    //Item.PocetKusov();
//                }
                
//                Console.WriteLine("Co chcete zvisit?");
//                int zvisit = int.Parse(Console.ReadLine());
//                shoppingList[zvisit].Price += 1;


//                Console.WriteLine("Ktore chcete odstranit?");
//                int odstranit = int.Parse(Console.ReadLine());
//                shoppingList.RemoveAt(odstranit);

//                if (Console.ReadLine() == "exit")
//                {
//                    break;
//                }
//            }




//            Console.WriteLine("Dakujeme za vas nakup");





       }
    }
}
