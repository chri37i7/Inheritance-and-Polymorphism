using System;

namespace Implementation.Entities
{
    public class Temperature : IEquatable<Temperature>, IComparable<Temperature>, ICloneable
    {
        #region Fields
        protected double celcius;
        #endregion

        #region Constructor
        public Temperature(double celcius)
        {
            Celcius = celcius;
        }
        #endregion

        #region Properties
        public double Celcius
        {
            get
            {
                return celcius;
            }
            set
            {
                if(celcius != value)
                {
                    celcius = value;
                }
            }
        }

        public double Farenheit
        {
            get
            {
                return (Celcius * 9) / 5 + 32;
            }
        }

        public string Text
        {
            get
            {
                return TemperatureText();
            }
        }
        #endregion

        #region Methods
        private string TemperatureText()
        {
            if(Celcius < -30)
            {
                return "Blistering cold!";
            }
            else if(Celcius >= -30 && Celcius <= -10)
            {
                return "Everything has frozen!";
            }
            else if(Celcius > -10 && Celcius <= 0)
            {
                return "It's Somewhat cold!";
            }
            else if(Celcius > 0 && Celcius <= 10)
            {
                return "It's Cold!";
            }
            else if(Celcius > 10 && Celcius <= 20)
            {
                return "It's Warm!";
            }
            else if(Celcius > 20 && Celcius <= 30)
            {
                return "It's very warm!";
            }
            else if(Celcius > 30 && Celcius <= 40)
            {
                return "California is on fire!";
            }
            else if(Celcius > 40)
            {
                return "Australia has burnt down";
            }
            else
            {
                return string.Empty;
            }
        } 
        #endregion

        #region Interface Implementations & Method Overrides

        #region Equals Implementation And Override
        /// <summary>
        /// Compares an object with the current object to check if they match
        /// </summary>
        /// <param name="temperature"></param>
        /// <returns></returns>
        public virtual bool Equals(Temperature temperature)
        {
            if(temperature == null)
            {
                return false;
            }
            else
            {
                return Celcius == temperature.Celcius &&
                    Farenheit == temperature.Farenheit &&
                    string.Equals(Text, temperature.Text);
            }
        }

        /// <summary>
        /// Casts the object to a <see cref="Temperature"/> object, 
        /// and uses <see cref="Equals(Temperature)"/> to check equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Temperature);
        }
        #endregion

        #region GetHashCode Override
        /// <summary>
        /// Generates a unique number which only an object with exact same values should be able to provide
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Tell CLR we dont care if it overflows or underflows in this instance
            unchecked
            {
                // Prime number so hash collision is more unlikely to happen
                int hash = 17;

                // Multiply hash with a second prime number and add each fields hash code
                hash = hash * 23 + Celcius.GetHashCode();
                hash = hash * 23 + Farenheit.GetHashCode();
                hash = hash * 23 + Text.GetHashCode();

                // Return the hash
                return hash;
            }
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return $"Celcius: {Celcius}, Farenheit: {Farenheit}, Text: {Text}";
        }
        #endregion

        #region CompareTo Implementation
        /// <summary>
        /// Compares this to another <see cref="Temperature"/> instance 
        /// </summary>
        /// <param name="temperature"></param>
        /// <returns></returns>
        public virtual int CompareTo(Temperature temperature)
        {
            // Null Check
            if(temperature == null)
            {
                return 1;
            }

            // Compare properties
            int result = Celcius.CompareTo(temperature.Celcius);

            // Compare the other properties if the first matches
            if(result == 0)
            {
                result = Farenheit.CompareTo(temperature.Farenheit);
            }
            if(result == 0)
            {
                result = Text.CompareTo(temperature.Text);
            }

            // Return result
            return result;
        }
        #endregion

        #region Clone Implementation
        /// <summary>
        /// Creates a clone of the current object instance
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            // Create shallow copy of current object
            Temperature clone = (Temperature)MemberwiseClone();

            // Return the cloned object
            return clone;
        }
        #endregion

        #endregion
    }
}