namespace Task
{
    public class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, string email)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string LastName { get; }
        public long PhoneNumber { get; }
        public string Email { get; }

        public override string ToString()
        {
            return $"{Name,-13}{LastName,-16}{PhoneNumber,-17}{Email}";
        }
    }
}
