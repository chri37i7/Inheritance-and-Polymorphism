using System;

namespace Implementation.Entities
{
    public class Temperature : IEquatable<Temperature>, IComparable<Temperature>, ICloneable
    {
        #region Fields
        protected double celcius;
        protected double farenheit;
        protected string text;
        #endregion

        #region Constructor
        public Temperature(double celcius, double farenheit, string text)
        {
            Celcius = celcius;
            Farenheit = farenheit;
            Text = text;
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
                return farenheit;
            }
            set
            {
                if(farenheit != value)
                {
                    farenheit = value;
                }
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if(text != value)
                {

                    text = value;
                }
            }
        }
        #endregion

        #region Method Implementations & Overrides

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
            // Create shallow copy
            object clone = MemberwiseClone();

            // Return
            return clone;
        }
        #endregion

        #endregion
    }
}