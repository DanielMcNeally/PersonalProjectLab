using System;
using PersonalProjectLab;

namespace CalculateDeltaT
{
    class CalculateDeltaT
    {
        static void Main(string[] args)
        {
            double molality;
            double vhf = 0.00;
            double kb = 0.00;
            double kf = 0.00;
            string KbOrKf;
            string input = "";

            bool cont = true;

            while (cont)
            {



                Console.WriteLine("Would you like to calculate the new Boiling point(enter Kb) or Freezing point(enter Kf)?");

                KbOrKf = Console.ReadLine(); //must be Kb or Kf
                                             //convert input into string

                //if Kb else Kf
                if (KbOrKf == "Kb")  // only do this if KB is entered

                {
                    //show list of solvents 
                    Console.WriteLine("Acetic Acid(AA), Benzene(B), Carbon Disulfide(CD), Carbon Tetrachloride(CT), Chloroform(C), Diethyl Ether(DE), Ethanol(E), Water(W)");
                    // ask for the solvent
                    Console.WriteLine(" Please choose an abreveation from the list");
                    input = Console.ReadLine();
                    // take the number thats hard coded in
                    if (input == "AA")
                    {
                        kb = 3.07;
                        vhf = 2;
                    }
                    if (input == "B")
                    {
                        kb = 2.53;
                        vhf = 1;
                    }
                    if (input == "CD")
                    {
                        kb = 2.34;
                        vhf = 1;
                    }
                    if (input == "CT")
                    {
                        kb = 3.63;
                        vhf = 1;
                    }
                    if (input == "C")
                    {
                        kb = 3.63;
                        vhf = 1;
                    }
                    if (input == "DE")
                    {
                        kb = 2.02;
                        vhf = 1;
                    }
                    if (input == "E")
                    {
                        kb = 1.22;
                        vhf = 1;
                    }
                    if (input == "W")
                    {
                        kb = 0.512;
                        vhf = 1;
                    }

                    // make it an int
                    //ask for the molality of the solvent

                    Console.WriteLine("What is the Molality of the solvent?");

                    molality = double.Parse(Console.ReadLine());
                    //calculate the number
                    MathDelataT mathDT = new MathDelataT();

                    double myBoilingPoint = mathDT.CalculateKb(vhf, molality, kb);
                    //take the number and add it to 100
                    //write to console
                    Console.WriteLine("Your new boiling point is " + myBoilingPoint + " degrees C");
                }
                if (KbOrKf == "Kf")
                {
                    //show list of solvents 
                    Console.WriteLine("Acetic Acid(AA), Benzene(B), Carbon Disulfide(CD), Carbon Tetrachloride(CT), Chloroform(C), Diethyl Ether(DE), Ethanol(E), Water(W)");
                    // ask for the solvent
                    Console.WriteLine(" Please choose an abreveation from the list");
                    input = Console.ReadLine();
                    // take the number thats hard coded in
                    if (input == "AA")
                    {
                        kf = 3.9;
                        vhf = 2;
                    }
                    if (input == "B")
                    {
                        kf = 4.9;
                        vhf = 1;
                    }
                    if (input == "CD")
                    {
                        kf = 3.83;
                        vhf = 1;
                    }
                    if (input == "CT")
                    {
                        kf = 30.0;
                        vhf = 1;
                    }
                    if (input == "C")
                    {
                        kf = 4.70;
                        vhf = 1;
                    }
                    if (input == "DE")
                    {
                        kf = 1.79;
                        vhf = 1;
                    }
                    if (input == "E")
                    {
                        kf = 1.99;
                        vhf = 1;
                    }
                    if (input == "W")
                    {
                        kf = 1.86;
                        vhf = 1;
                    }

                    //ask for the molality of the solvent

                    Console.WriteLine("What is the Molality of the solvent?");

                    molality = double.Parse(Console.ReadLine());
                    //calculate the number
                    MathDelataT mathDT = new MathDelataT();

                    double myFreezingPoint = mathDT.CalculateKf(vhf, molality, kf);
                    //double myFreezingPoint = 00.0 - vhf * molality * kf;
                    //take the number and minus it from 0
                    //write to console
                    Console.WriteLine("Your new freezing point is " + myFreezingPoint + " degrees C");
                }


                Console.WriteLine("Would you like to make another calculation? Yes/No?");
                input = Console.ReadLine();
                if (input == "No")
                {
                    cont = false;

                }


            }
                 Console.WriteLine("Program has ended...Thank you!");
            
                
            
            
        }

                //Prompt user to see if they want to do another calculation
                //If they chose yes, start back up at the top again.
                //Else end program

            }
        }
 

