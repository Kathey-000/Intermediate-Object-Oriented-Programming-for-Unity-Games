using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        // declare your Dictionary field and create the Dictionary object for it here
        Dictionary<string, int> digitizer;


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            // populate your dictionary field here
            digitizer = new Dictionary<string, int>();
            digitizer.Add("ZERO", 0);
            digitizer.Add("ONE", 1);
            digitizer.Add("TWO", 2);
            digitizer.Add("THREE", 3);
            digitizer.Add("FOUR", 4);
            digitizer.Add("FIVE", 5);
            digitizer.Add("SIX", 6);
            digitizer.Add("SEVEN", 7);
            digitizer.Add("EIGHT", 8);
            digitizer.Add("NINE", 9);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            // delete the code below and add your code
            if (digitizer.ContainsKey(word.ToUpper()))
            {
                return digitizer[word.ToUpper()];
            }
            else
            {
                return -1;
            }

        }

        #endregion
    }
}
