using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class EconomyWagon : PersonalWagon {
        //---- variables ----//


        //---- getters/ setters ----//


        //---- constructors ----//
        public EconomyWagon(int numberOfChairs) : base(numberOfChairs) {

        }

        //---- methods ----//
        public override string ToString() {
            return base.ToString();
        }
    }
}
