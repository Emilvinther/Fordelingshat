using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshat
{
    internal class SortingHat
    {

        
        
        
        
        

        public void Sorting()
        {
            //Valueables
            int choice = 0;
            string house = "";
            string words = "";

            // Random for choice
            Random random = new Random();
            choice = random.Next(0, 4);

            // Chooses what house you belong in
            if (choice == 0)
            {
                house = ((Dorms)0).ToString();
                words = "For the brave and strong";
            }
            else if (choice == 1)
            {
                house = ((Dorms)1).ToString();
                words = "For the Loyal and Valiant";
            }
            else if (choice == 2)
            {
                house = (((Dorms)2).ToString());
                words = "For the Curious and Intellegent";

            }
            else if (choice == 3)
            {
                house = ((Dorms)3).ToString();
                words = "For the sneaky, Strong Willed, and for those who do everything to acheve their goal ";
            }

            // Writes out the house and its words
            Console.WriteLine("You got sorted into: {0} {1}",house, words);


        }

    }

    // Enum holding hogwarts houses
    enum Dorms
    {
        Gryffindor = 0,
        Hufflepuff = 1,
        Ravenclaw = 2,
        Slytherin = 3,
    }
}
