namespace TinyTypesTest
{
    class Author
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Author(FirstName f, LastName l) : this((string)f ,(string)l )
        {

        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
