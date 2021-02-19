using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class BusinessWagon : PersonalWagon {
        //---- variables ----//
        private Person steward;

        //---- getters/ setters ----//
        public Person Steward { get { return steward; } set { steward = value; } }


        //---- constructors ----//
        public BusinessWagon(int numberOfChairs, Person steward) :base(numberOfChairs) {
            this.steward = steward;
        }

        //---- methods ----//
        public override string ToString() {
            return base.ToString() + $", steward: {this.Steward}";
        }
    }
}
