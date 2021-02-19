namespace Train {
    public class Person {
        //---- variables ----//
        private string firstName;
        private string lastName;

        //---- getters/ setters ----//
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }


        //---- constructors ----//
        public Person(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //---- methods ----//
        public override string ToString() {
            return firstName + " " + lastName;
        }
    }
}