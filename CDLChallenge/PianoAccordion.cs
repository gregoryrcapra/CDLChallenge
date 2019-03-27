using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDLChallenge
{

    public class PianoAccordion
    {

        // manufacturer- can be Pigini, Petosa, Giulietti, Weltmeister, or Victoria
        public string make;

        // can be 26, 34, 37, or 41
        public short trebleKeys;

        // can be 12, 24, 48, 60, 80, 96, or 120
        public short bassKeys;

        // can be 2, 3, 4, or 5
        public short trebleReeds;

        // can be "musette", "swing", "alpine", "concert", or "jazz"
        public string tuning;

        // can be "available", "out-of-stock", or "on-order"
        public string status;

        // unpredictable val
        public string model;

        public PianoAccordion(){}

        public PianoAccordion(string make, short trebleKeys, short bassKeys, short trebleReeds, string tuning, string status, string model)
        {
            this.make = make;
            this.trebleKeys = trebleKeys;
            this.bassKeys = bassKeys;
            this.trebleReeds = trebleReeds;
            this.tuning = tuning;
            this.status = status;
            this.model = model;
        }

        public string getMake()
        {
            return make.ToString();
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public string getModel()
        {
            return model;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public short getTrebleKeys()
        {
            return trebleKeys;
        }

        public void setTrebleKeys(short trebleKeys)
        {
            this.trebleKeys = trebleKeys;
        }

        public short getBassKeys()
        {
            return bassKeys;
        }

        public void setBassKeys(short bassKeys)
        {
            this.bassKeys = bassKeys;
        }

        public string getStatus()
        {
            return status.ToString();
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public short getTrebleReeds()
        {
            return trebleReeds;
        }

        public void setTrebleReeds(short trebleReeds)
        {
            this.trebleReeds = trebleReeds;
        }

        public string getTuning()
        {
            return tuning.ToString();
        }

        public void setTuning(string tuning)
        {
            this.tuning = tuning;
        }

        /// <summary>
        /// Override function for "GetHashCode" method
        /// </summary>
        /// <returns>int hash</returns>
        //FUTURE DEV -> REDUCE PROBABILITY OF COLLISION IN HASHFUNC
        public override int GetHashCode()
        {
            int hash = 3;
            hash = 61 * hash + (this.make).GetHashCode();
            hash = 61 * hash + this.trebleKeys;
            hash = 61 * hash + this.bassKeys;
            hash = 61 * hash + this.trebleReeds;
            hash = 61 * hash + (this.tuning).GetHashCode();
            return hash;
        }

        /// <summary>
        /// Override function for "Equals" method
        /// </summary>
        /// <param name="obj">the Piano Accordion object</param>
        /// <returns>true or false</returns>
        public override bool Equals(Object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            PianoAccordion other = (PianoAccordion)obj;
            if (this.trebleKeys != other.trebleKeys)
            {
                return false;
            }
            if (this.bassKeys != other.bassKeys)
            {
                return false;
            }
            if (this.trebleReeds != other.trebleReeds)
            {
                return false;
            }
            if (this.make != other.make)
            {
                return false;
            }
            if (this.tuning != other.tuning)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Converts Piano Accordion Object to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "PianoAccordion{" + "make=" + make + ", trebleKeys=" + trebleKeys + ", bassKeys=" + bassKeys + ", trebleReeds=" + trebleReeds + ", tuning=" + tuning + ", status=" + status + ", model=" + model + '}';
        }
    }
}
