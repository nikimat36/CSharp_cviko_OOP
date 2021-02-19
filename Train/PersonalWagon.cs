using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    abstract class PersonalWagon : IWagon {
        //---- variables ----//
        private List<Door> doors = new List<Door>();
        private List<Chair> sits = new List<Chair>();
        private int numberOfChairs;

        public Train train;

        //---- getters/ setters ----//
        internal List<Door> Doors { get { return doors; } set { doors = value; } }
        internal List<Chair> Sits { get { return sits; } set { sits = value; } }
        public int NumberOfChairs { get { return numberOfChairs; } set { numberOfChairs = value; } }


        //---- constructors ----//
        public PersonalWagon(int numberOfChairs) {
            this.numberOfChairs = numberOfChairs;
            for (int i = 0; i < numberOfChairs; i++) {
                Sits.Add(new Chair(i));
            }
        }

        //---- methods ----//
        public override string ToString() { 
            return $"typ: {this.GetType().Name}, počet sedadel: {numberOfChairs}"; 
        }

        public void ConnectWagon(Train train) {
            if (this.train == null) {    //kontrola, zda už není součástí nějakého vlaku.
                if (train.Locomotive.Engine.Type == "parní" && train.Wagons.Count > 5) {    //kontrola max.kapacity parní lokomotivy
                    Console.WriteLine("Parní lokomotiva neutáhne více jak 5 vagónů.");
                } else {
                    this.train = train;
                    train.Wagons.Add(this);
                    Console.WriteLine("Vagón připojen");
                }
            } else {
                Console.WriteLine("Tento vagón je již připojen k vlaku LOL.");
            }
        }

        public void DisconnectWagon(Train train) {
            if (this.train == train) {  //nebo (train.Wagons.Contains(this))
                train.Wagons.Remove(this);
                this.train = null;
                Console.WriteLine("Vagón úspěšně odpojen");
            } else {
                Console.WriteLine("Vagón není součástí této soupravy");
            }
        }
    }
}
