

namespace classRegister.Entities
{
    public class Students
    {
        private string id;

        private string name;

        private string email;

        private int age;

        private string address;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public Students()
        {
        }

        public Students(string id, string name, string email, int age, string address)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.age = age;
            this.address = address;
        }

    }
}