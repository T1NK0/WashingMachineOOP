using System;

namespace Washing_Machine_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer wash = new Washer();

            #region powerOn
            //Asks the user to input a value 1 or 2, to power on or off the machine.
            Console.WriteLine("Start vaskemaskinen ved at skrive 1: ");
            //Makes an int called startstop, which has the value of the user input converted to int 32, so the system can read it as an int.
            int userStartStop = Convert.ToInt32(Console.ReadLine());
            if (userStartStop == 1)
            {
                wash.TurnOn();
                Console.WriteLine("Vaskemaskinen er nu tændt");
            }
            #endregion

            Console.WriteLine();

            #region openDoor1
            Console.WriteLine("Åben døren ved at skrive 1: ");
            int userDoorOpenClose = Convert.ToInt32(Console.ReadLine());

            if (userDoorOpenClose == 1)
            {
                wash.OpenDoor();
                Console.WriteLine("Døren er nu åben");
            }
            #endregion

            Console.WriteLine();

            #region closeDoor1
            Console.WriteLine("Luk døren ved at skrive 2: ");
            userDoorOpenClose = Convert.ToInt32(Console.ReadLine());
            if (userDoorOpenClose == 2)
            {
                wash.CloseDoor();
                Console.WriteLine("Døren er nu lukket");
            }

            #endregion

            Console.WriteLine();

            #region dosage
            Console.WriteLine("Angiv dosering i skefulde: ");
            wash.washerDosage = Convert.ToInt32(Console.ReadLine());
            #endregion

            Console.WriteLine();

            #region selectProgram
            //Gives the user 3 choices of programs to choose from.
            Console.WriteLine("Vælg program:");
            Console.WriteLine("1: Kort vask - 30 min");
            Console.WriteLine("2: Mellem vask - 60 min");
            Console.WriteLine("3: Lang vask - 90 min");
            wash.washerProgram = Convert.ToInt32(Console.ReadLine());
            if (wash.washerProgram == 1)
            {
                wash.washerTimer = 30;
            }
            else if (wash.washerProgram == 2)
            {
                wash.washerTimer = 60;
            }
            else if (wash.washerProgram == 3)
            {
                wash.washerTimer = 90;
            }
            #endregion

            Console.WriteLine();

            #region runWaterAndDrum
            //If washer is turned on, and washer door is closed, and washer dosage is given, and washer program is chosen, start the drum, and run the water.
            if (wash.washerPower == true && wash.washerDoor == false && wash.washerDosage != 0 && wash.washerProgram != 0)
            {
                wash.RunDrum();

                wash.RunWater();
            }
            #endregion

            #region status
            Console.Write("Power: ");
            Console.WriteLine(wash.washerPower);

            Console.Write("Dør: ");
            Console.WriteLine(wash.washerDoor);

            Console.Write("Dosering: ");
            Console.WriteLine(wash.washerDosage);

            Console.Write("Program: ");
            Console.WriteLine(wash.washerProgram);

            Console.Write("Timer: ");
            Console.WriteLine(wash.washerTimer);

            Console.Write("Trommel: ");
            Console.WriteLine(wash.washerDrum);

            Console.Write("Vand: ");
            Console.WriteLine(wash.washerWater);
            #endregion

            Console.WriteLine();

            Console.WriteLine("Tøm vaskemaskine:");

            #region openDoor2
            Console.WriteLine("Tast 1 for at åbne døren");
            userDoorOpenClose = Convert.ToInt32(Console.ReadLine());
            if (userDoorOpenClose == 1)
            {
                wash.OpenDoor();
            }
            #endregion

            Console.WriteLine();

            #region closeDoor2
            Console.WriteLine("Tast 2 for at lukke døren");
            userDoorOpenClose = Convert.ToInt32(Console.ReadLine());
            if (userDoorOpenClose == 2)
            {
                wash.CloseDoor();
            }
            #endregion

            Console.WriteLine();

            #region powerOffWasher
            Console.WriteLine("Tast 2 for at slukke for vaskemaskinen");
            userStartStop = Convert.ToInt32(Console.ReadLine());
            if (userStartStop == 2)
            {
                wash.TurnOff();
                Console.WriteLine(wash.washerPower);
            }
            #endregion
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
