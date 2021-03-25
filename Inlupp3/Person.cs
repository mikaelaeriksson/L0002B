using System;

// Mikaela Eriksson mikerv-0 9410122163 L0002B task 3

namespace Inlupp3
{
    public class Person
    {
        public string firstName, lastName, pNumber;
        public Person(string firstName, string lastName, string pNumber)
        {
            if (!PNumberCheck(pNumber))
            {
                throw new Exception();
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.pNumber = pNumber;
        }

        // Check if personal number input is valid with Luhn algorithm (check digit)
        public static bool PNumberCheck(string pNo)
        {
            int tot = 0;
            for (int i = 0; i < pNo.Length; i++)
            {
                int tempvar = (pNo[i] - '0') << (1 - (i & 1));
                if (tempvar > 9) tempvar -= 9;
                tot += tempvar;
            }
            return (tot % 10) == 0;
        }

        // Check if second last digit is odd (male) or even (female)
        public static string CheckGender(string pNo)
        {
            int g;
            if (!Int32.TryParse(pNo[8].ToString(), out g))
            {
                throw new Exception();
            }
            return g % 2 == 0 ? "female" : "male";
        }
    }
}
