using System;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 0; i < 2 ;i++){
                Console.WriteLine("1. Van Halen: 5150.  150,-");
                Console.WriteLine("2. Guns N' Roses: Appetite for Destruction.  200,-");
                Console.WriteLine("3. Blink 182: Enema of the State.  175,-");

                string item = Console.ReadLine();
                Console.WriteLine("Cena za kus je " + items(item));
                Console.WriteLine("prosím zaplať");
                var cost = int.Parse(items(item));
                int sum = int.Parse(Console.ReadLine()) - cost;

                string output = sum > 0 ? "děkuji za nákup" : "tohle bohužel nebude stačit" ;
                Console.WriteLine(output);
                int o;
                for(o = 0; o < 1; o++){
                    Console.WriteLine("Chcete si koupit ještě něco ? (ano/ne)");
                    string again = Console.ReadLine();
                    if(again == "ano"){
                        i = 0;
                    }
                    else if(again == "ne"){
                        Console.WriteLine("Děkuji přijďte zas");
                        Console.ReadLine();
                        o = 1;
                    }
                    else{
                        Console.WriteLine("Prosím vyjadřujte se jako člověk");
                        o = 0;
                    }
                }
            }
        }
        public static string items(string item){
            if(item == "1"){
                string cost = "150";
                return cost;
            }
            else if(item == "2"){
                string cost = "200";
                return cost;
            }
            else if(item == "3"){
                string cost = "175";
                return cost;
            }
            else{
                return "ERROR!";
            }

        }

    }
}
