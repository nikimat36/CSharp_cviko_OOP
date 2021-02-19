using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Hopper : IWagon {
        //---- variables ----//
        private double loadingCapacity;

        public Train train;

        //---- getters/ setters ----//
        public double LoadingCapacity { get { return loadingCapacity; } set { loadingCapacity = value; } }


        //---- constructors ----//
        public Hopper(double loadingCapacity) {
            this.loadingCapacity = loadingCapacity;
        }

        //---- methods ----//
        public override string ToString() {
            return base.ToString() + $", loading capacity: {this.LoadingCapacity}";
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
