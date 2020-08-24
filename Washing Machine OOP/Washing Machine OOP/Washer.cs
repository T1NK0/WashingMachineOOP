using System;
using System.Collections.Generic;
using System.Text;

namespace Washing_Machine_OOP
{
    class Washer
    {
        private bool power;
        private bool door;
        private int dosage;
        private int program;
        private int timer;
        private bool drum;
        private bool water;

        #region power
        public bool washerPower
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public bool TurnOn()
        {
            return this.power = true;
        }

        public bool TurnOff()
        {
            return this.power = false;
        }
        #endregion

        #region door
        public bool washerDoor
        {
            get
            {
                return this.door;
            }
            set
            {
                this.door = value;
            }
        }

        public bool OpenDoor()
        {
            return this.door = true;
        }

        public bool CloseDoor()
        {
            return this.door = false;
        }
        #endregion

        #region dosage
        public int washerDosage
        {
            get
            {
                return this.dosage;
            }
            set
            {
                this.dosage = value;
            }
        }
        #endregion

        #region program
        public int washerProgram
        {
            get
            {
                return this.program;
            }
            set
            {
                this.program = value;
            }
        }
        #endregion

        #region timer
        public int washerTimer
        {
            get
            {
                return this.timer;
            }
            set
            {
                this.timer = value;
            }
        }
        #endregion

        #region drum
        public bool washerDrum
        {
            get
            {
                return this.drum;
            }
            set
            {
                this.drum = value;
            }
        }

        public bool RunDrum()
        {
            return this.drum = true;
        }

        public bool StopDrum()
        {
            return this.drum = false;
        }
        #endregion

        #region water
        public bool washerWater
        {
            get
            {
                return this.water;
            }
            set
            {
                this.water = value;
            }
        }

        public bool RunWater()
        {
            return this.water = true;
        }

        public bool StopWater()
        {
            return this.water = false;
        }
        #endregion

        public Washer()
        {

        }



    }
}
