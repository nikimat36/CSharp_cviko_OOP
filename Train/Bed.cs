using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Bed {
        private int number;
        private bool reserved;

        //---- getters/ setters ----//
        public int Number { get { return number; } set { number = value; } }
        public bool Reserved { get { return reserved; } set { reserved = value; } }


        //---- constructors ----//
        public Bed() { }

        public Bed(int number) { this.number = number; }

        public Bed(bool reserver) { this.Reserved = reserved; }

        //---- methods ----//
    }
}
