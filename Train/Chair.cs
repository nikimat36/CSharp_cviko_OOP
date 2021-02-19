using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Chair {
        //---- variables ----//
        private bool nearWindow;
        private int number;
        private bool reserved;

        //---- getters/ setters ----//
        public bool NearWindow { get { return nearWindow; } set { nearWindow = value; } }
        public int Number { get { return number; } set { number = value; } }
        public bool Reserved { get { return reserved; } set { reserved = value; } }


        //---- constructors ----//
        public Chair() { }

        public Chair(int number) { this.number = number; }
            
        //---- methods ----//
    }
}
