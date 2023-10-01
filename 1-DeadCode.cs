using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringDemo
{
    public class _1_DeadCode
    {
        public void DoStuff()
        {
            var number = 0;

            while (number < 1)
            {
                Console.WriteLine($"Number is {number}!");
            }

            MyPrettyMethod();
        }

        /*
        DENNA FUNGERADE FÖRUT, GÖR FALLBACK OM NYA LÖSNINGEN INTE FUNKAR!
        MVH KIM 1992-04-01
         */
        //public void DoStuff()
        //{
        //    var number = 1;
        //    var text = "1";

        //    if(number.ToString() == text)
        //    {
        //        Console.WriteLine("Number is same as text!");
        //        Console.ReadLine();
        //    }
        //}

        public void MyPrettyMethod()
        {
            var isTrue = false;

            if (isTrue)
            {
                DoSomething();
            }
            else if (!isTrue)
            {
                DoSomethingElse();
            }

            return;

            DoSomethingCompletelyDifferent();
        }

        public void DoSomething()
        {
            //Gör något
        }

        public void DoSomethingElse()
        {
            //Gör något annat
        }

        public void DoSomethingCompletelyDifferent()
        { 
            //Gör något HELT annat
        }
    }
}
