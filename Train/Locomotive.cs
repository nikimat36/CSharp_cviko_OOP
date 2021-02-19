using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Locomotive {
        //---- variables ----//
        private Person driver;
        private Engine engine;

        //---- getters/ setters ----//
        public Person Driver { get { return driver; } set { driver = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }

        //---- constructors ----//
        public Locomotive() { }

        public Locomotive(Person driver, Engine engine) {
            this.driver = driver;
            this.engine = engine;
        }

        //---- methods ----//
        public override string ToString() {
            return $"typ: {engine.ToString()}, řidič: {driver.LastName}";
        }

    }
}
