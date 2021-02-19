using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class NightWagon : PersonalWagon {
        //---- variables ----//
        private int numberOfBeds;
        private Bed[] beds;

        //---- getters/ setters ----//
        public int NumberOfBeds { get { return numberOfBeds; } set { numberOfBeds = value; } }

        internal Bed[] Beds { get => beds; set => beds = value; }


        //---- constructors ----//
        public NightWagon(int numberOfChairs, Bed[] beds) : base(numberOfChairs) {
            this.Beds = beds;
            numberOfBeds = beds.Length;
            for (int i = 0; i < Beds.Length; i++) {
                this.beds[i] = new Bed(i);
            }
        }

        //---- methods ----//
        public override string ToString() {
            return base.ToString() + $"number of beds: {this.NumberOfBeds}";
        }
    }
}
