using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetName
{
    class pet
    {


        // Set up private strings


        private string m_sName;

        private int m_iHunger;
        private int m_iHappy;
        private int m_iSleep;
        private int m_FedPet;
        private int m_iDrink;
        private int m_BedTime;



        // Constructor

        // Set up public pet strings 
        public pet(string sName)

        {

            m_sName = sName;

            m_iHunger = -10;
            m_iHappy = 10;
            m_iSleep = 10;
            m_FedPet = 20;
            m_iDrink = 10;
            m_BedTime = 10;




        }


    // Set up and define sleep 

        public void sleep()
        {


            m_iSleep -= 3;

            if (m_iSleep < 0)

            {

                m_iSleep = 0;

            }

            Console.WriteLine("{0} is tired now from a long fun day on the road |", m_sName);

        }

        // set up and define Happy 

        public void Happy()
        {

            m_iHappy -= 3;

            if (m_iHappy < 0)

            {

                m_iHappy = 0;

            }

            Console.WriteLine("{0} is happy and loves you|", m_sName);

        }

        // Set up and Define Eat


        public void Eat()
        {

            m_iHunger -= 3;

            if (m_iHunger < 0)


                Console.WriteLine("{0} needs breakfast to start the day, Press enter to feed your pet breakfast ", m_sName);

                


            {

                m_iHunger = 0;

            }

      
        }



        //Set up and Define FedPet (when the pet is fed)


        public void FedPet()
        {

            m_FedPet -= 3;

            if (m_FedPet < 0)

            {

                m_FedPet = 0;

            }

            Console.WriteLine(@"_____________________________________________________________________");
            Console.WriteLine("you fed {0} yay your pet is ready to start the day now! :D ", m_sName);
            Console.WriteLine(@"_____________________________________________________________________");
            Console.WriteLine("Press Enter");
          


        }



        //  Set up and Define Drink 


        public void Drink()
        {

            m_iDrink -= 100;

            if (m_FedPet < 10)

            {

                m_iDrink = 0;

            }

            Console.WriteLine("{0} is thirsty, give him water by pressing enter|", m_sName);
           

                                

        }


        //  Set up and Define BedTime (When the pet goes to sleep


        public void BedTime()
        {

            m_BedTime -= 100;

            if (m_BedTime < 10)
            {

                m_BedTime = 0;

            }


            Console.WriteLine("you put {0} to bed, your pet smiles :) and falls asleep |", m_sName);




        }





    }



}
