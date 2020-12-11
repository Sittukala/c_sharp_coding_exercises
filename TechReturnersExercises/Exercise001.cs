using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {
            word = word.Substring(0, 1).ToUpper()+word.Substring(1,word.Length-1);
            return word;
            throw new NotImplementedException();
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
           String initials = firstName.Substring(0, 1).ToUpper() + "." + lastName.Substring(0, 1).ToUpper();
            return initials;
           throw new NotImplementedException();
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            double vat = ((vatRate / 100) * originalPrice);
            double vatAdded = Math.Round(originalPrice + vat,2);
            return vatAdded;
            throw new NotImplementedException();
        }

        public static String Reverse(String sentence) 
        {

            String reverse = "";
            for (int i = sentence.Length- 1; i >= 0; i--)
            {
                reverse = reverse + sentence[i];
            }

            return reverse;

            throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            int count = 0;
            foreach (var user in users)
            {
                if (user.Type == "Linux")
                {
                    count++;
                }
            }
            return count;
                throw new NotImplementedException();
        }
    }
}
