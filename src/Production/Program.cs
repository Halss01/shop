using System;

namespace shop
{
    class Program
    {
       public bool o = true;
        public static void Main(string[] args)
        {
            bool i = true;
            while(i == true){
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

                Console.WriteLine("Chcete si koupit ještě něco ? (ano/ne)");
                
                while(o == true){
                string again = Console.ReadLine();
                shop(again);
                }
                Console.ReadLine();
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
        public static string shop(string again){
            
                if(again == "ano"){
                    o = false;
                    return  "0";
                }
                else if(again == "ne"){
                    o = false;
                    return "Děkuji přijďte zas";
                }
                else{
                    return "Prosím vyjadřujte se jako člověk";
                }
            }
        }

    }
}
