using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        // declare your fields here
        string firstName;
        string middleName;
        string lastName;
        string streetAddress;
        string city;
        string state;
        string postalCode;
        string country;
        string phoneNumber;
        
        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
                // delete code below and replace with correct code
                return firstName;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                // delete code below and replace with correct code
                return middleName;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                // delete code below and replace with correct code
                return lastName;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
                // delete code below and replace with correct code
                return streetAddress;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                // delete code below and replace with correct code
                return city;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                // delete code below and replace with correct code
                return state;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                // delete code below and replace with correct code
                return postalCode;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                // delete code below and replace with correct code
                return country;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                // delete code below and replace with correct code
                return phoneNumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here
            StreamReader myStream = null;
            string oneLine;
            try
            {
                myStream = File.OpenText(fileName);
                oneLine = myStream.ReadLine();

                int currentIndex = oneLine.IndexOf(',');
                int nextIndex = oneLine.IndexOf(',', currentIndex + 1);

                firstName = oneLine.Substring(0, currentIndex);
                middleName = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;
                nextIndex = oneLine.IndexOf(',', currentIndex + 1);
                
                lastName = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;
                nextIndex = oneLine.IndexOf(',', currentIndex + 1);

                streetAddress = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;
                nextIndex = oneLine.IndexOf(',', currentIndex + 1);

                city = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;
                nextIndex = oneLine.IndexOf(',', currentIndex + 1);

                state = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;
                nextIndex = oneLine.IndexOf(',', currentIndex + 1);

                postalCode = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;
                nextIndex = oneLine.IndexOf(',', currentIndex + 1);

                country = oneLine.Substring(currentIndex + 1, nextIndex - currentIndex - 1);
                currentIndex = nextIndex;

                phoneNumber = oneLine.Substring(currentIndex + 1);


            }
            catch(Exception e)
            {
            }
            finally
            {
                if(myStream != null)
                {
                    myStream.Close();
                }
            }
            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data
        }

        #endregion
    }
}
