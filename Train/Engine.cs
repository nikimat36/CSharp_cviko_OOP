namespace Train {
    public class Engine {
        //---- variables ----//
        private string type;

        //---- getters/ setters ----//
        public string Type { get { return type; } set { type = value; } }


        //---- constructors ----//
        public Engine() { }
        public Engine(string type) { this.Type = type; }

        //---- methods ----//
        public override string ToString() {
            return Type;
        }
    }
}