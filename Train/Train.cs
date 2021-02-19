using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Train {
        //---- variables ----//

        private Locomotive locomotive;
        private List<IWagon> wagons = new List<IWagon>();

        //---- getters/ setters ----//
        internal Locomotive Locomotive { get { return locomotive; }  set { locomotive = value; } }
        internal List<IWagon> Wagons { get { return wagons; }  set {  wagons = value; }  }


        //---- constructors ----//
        public Train() { }
        public Train(Locomotive locomotive) {
            this.locomotive = locomotive;
        }

        public Train(Locomotive locomotive, List<IWagon> wagonsX) {
            this.locomotive = locomotive;
            //this.wagons = wagons;
            foreach (IWagon wagon in wagonsX) {
                wagon.ConnectWagon(this);
            }
        }


        //---- methods ----//
        public override string ToString() {
            string ret = "Lokomotiva: " + locomotive.ToString() + ":\n";
            for (int i = 0; i < wagons.Count; i++) {
                ret += "-- " + i + ". vagón: " + wagons[i].ToString() + "\n";
            }
            return ret;
        }
        public void ConnectWagon(IWagon wagon) {
            wagon.ConnectWagon(this);
        }

        public void DisconnectWagon(IWagon wagon) {
            wagon.DisconnectWagon(this);
        }

        public void ReservedChair(int noOfWagon, int noOfSeat) {
            if(noOfWagon - 1 <= Wagons.Count || noOfWagon <= 0) {
                if (Wagons[noOfWagon] is PersonalWagon) {
                    if (noOfSeat <= ((PersonalWagon)Wagons[noOfWagon - 1]).Sits.Count && noOfSeat > 0) {
                        if (((PersonalWagon)Wagons[noOfWagon - 1]).Sits[noOfSeat].Reserved == false) {
                            ((PersonalWagon)Wagons[noOfWagon - 1]).Sits[noOfSeat].Reserved = true;
                            Console.WriteLine("Místo bylo úspěšně rezervováno. :)");
                        } else {
                            Console.WriteLine("Toto místo je již zabrané.");
                        }
                    } else {
                        Console.WriteLine("Takové sedadlo neexistuje");
                    }
                } else {
                    Console.WriteLine("Tento vagón není určen pro pasažéry.");
                }
            } else {
                Console.WriteLine("CHYBA: Číslo vágonu neodpovídá.");
            }
        }

        public void ListReservedChairs() {
            int i = 1;
            foreach (IWagon wagon in wagons) {
                if (wagon is PersonalWagon) {
                    Console.WriteLine($"Vagón č. {i}:");
                    i += 1;
                    foreach (Chair seat in ((PersonalWagon)wagon).Sits) {
                        if (seat.Reserved == true) {
                            Console.WriteLine($" -- sedadlo: {seat.Number}");
                        }
                    }
                }
            }
        }
    }
}
