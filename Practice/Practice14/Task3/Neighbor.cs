using System;

namespace Task3
{
    class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public string PhoneNumber { get; set; }

        public Neighbor(string fullName, int flatNumber, string phoneNumber)
        {
            FullName = fullName;
            FlatNumber = flatNumber;
            PhoneNumber = phoneNumber;
        }

        public void ShowData()
        {
            Console.WriteLine($"Full name: {FullName};\nFlat number: {FlatNumber};\nPhone number: {PhoneNumber}.");
        }
    }
}
