using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get 
            { 
                return _lastName; 
            }

            set 
            { 
                _lastName = value; 
            }
        }

        public string EmailAddress { get; set; }

        public string FullName 
        {   get
            {
                string fullName = LastName;

                if (!String.IsNullOrEmpty(FirstName))
                {
                    if (!String.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;   
            }  
        }
    }
}
