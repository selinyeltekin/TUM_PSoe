using System;
using System.Threading;

namespace ProSD {
    //using example = Helpers;

    class Program2
    {
        static void Main(string[] args)
        {
            Helpers example = new Helpers();
            int has_green = 1;
            bool switch_state = false;
            int count = 0; //count sıfırdan baslar
            int amount = 5; //5 kere dondurcek kodu
            var history = new int[amount];
            //Console.WriteLine(example.CurrentSwitchState());
            bool active_state = true;
            while(active_state)
            {
                if (example.CurrentSwitchState() == true & has_green ==1)
                {
                    has_green = 0;
                }
                else
                {
                    has_green = 1; //while içi şemaya göre yazıldı
                }
                example.Sleep(1000);
                //Console.WriteLine("The has_green function value is " + has_green);
                //Console.WriteLine("How many times you are in the loop: " +count);
                history[count] = has_green;
                count++;
                if (count == amount)
                {
                    active_state = false;
                }
            }
            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine("index of the array "+i+", has_green value is " + history[i]);
            }
        }
    }

}
