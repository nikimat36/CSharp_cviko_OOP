using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Program {
        static void Main(string[] args) {
            //--- 1. krok
            BusinessWagon b1 = new BusinessWagon(100, new Person("Lenka", "Kozáková"));
            BusinessWagon b2 = new BusinessWagon(80, new Person("Petr", "Flákač"));
            BusinessWagon b3 = new BusinessWagon(90, new Person("Martina", "Mrzutá"));
            NightWagon n1 = new NightWagon(50, new Bed[50]);
            Hopper h1 = new Hopper(500);
            Locomotive l1 = new Locomotive(new Person("Karel", "Novák"), new Engine("diesel"));
            Train t1 = new Train(l1, new List<IWagon> { b1, b2, b3, n1, h1});

            Hopper h2 = new Hopper(400);
            t1.ConnectWagon(h2);

            //--- 2. krok
            EconomyWagon e1 = new EconomyWagon(200);
            EconomyWagon e2 = new EconomyWagon(220);
            Hopper h3 = new Hopper(450);
            Hopper h4 = new Hopper(500);
            Hopper h5 = new Hopper(550);
            Engine en2 = new Engine("parní");
            Locomotive l2 = new Locomotive(new Person("Pepik", "Janů"), en2);
            Train t2 = new Train(l2, new List<IWagon> { e1, e2, h3, h4, h5 });
            t2.ConnectWagon(new Hopper(500));

            //--- 3. krok
            t1.ReservedChair(3, 11);    //Rezervujte sedadlo v třetím vagonu.

            t1.ReservedChair(5, 1);     //Zkuste jinému cestovateli rezervovat sedadlo v Hopperu.
            
            t1.ReservedChair(3, 11);    //Zkuste taky rezervovat už jednou rezervované 
                                        //sedadlo, opět ověřte, že to nejde a že program nespadne na výjimku.

            t1.ListReservedChairs();    //Vypište rezervovaná sedadla.


            //--- 4.krok
            Console.WriteLine(t1);
            Console.WriteLine(t2);

        }
    }
}