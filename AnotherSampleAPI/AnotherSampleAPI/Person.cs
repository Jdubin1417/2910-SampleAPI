namespace AnotherSampleAPI
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Card[] Cards { get; set; }

        public Person(string firstName, string lastName)
        {
            Cards = new Card[52];

            for (int i = 0; i < 52; i++)
            {
                Cards[i] = new Card(i);
            }
            FirstName = firstName;

            LastName = lastName;
        }
    }
}
