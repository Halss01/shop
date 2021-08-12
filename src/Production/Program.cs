using System;

namespace shop
{
    class Program
    {
       public bool o = true;
        public static void Main(string[] args)
        {
            bool a = true;
            while(a == true){
                Console.WriteLine("1. Van Halen: 5150.  150,-");
                Console.WriteLine("2. Guns N' Roses: Appetite for Destruction.  200,-");
                Console.WriteLine("3. Blink 182: Enema of the State.  175,-");

                string item = Console.ReadLine();
                Console.WriteLine("Cena za kus je " + items(item));
                Console.WriteLine("prosím zaplať");
                var cost = int.Parse(items(item));
                int sum = int.Parse(Console.ReadLine()) - cost;

                string output = sum >= 0 ? "děkuji za nákup" : "tohle bohužel nebude stačit" ;
                Console.WriteLine(output);

                Console.WriteLine("Chcete si koupit ještě něco ? (ano/ne)");
                bool b = true;
                while(b == true){
                string again = Console.ReadLine();
                
                if(shop(again) == "Děkuji přijďte zas"){
                    a = false;
                    b = false;
                    Console.ReadLine();
                }
                else if(shop(again) == "Prosím vyjadřujte se jako člověk"){

                }
                else{
                    b = false;
                }}
                
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
                    return  "0";
                }
                else if(again == "ne"){
                    return "Děkuji přijďte zas";
                }
                else{
                    return "Prosím vyjadřujte se jako člověk";
                }
            }
        }

}
