using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class Customer
    {
        public Customer()
        {
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrEmpty(fullName) )
                {
                    if(!string.IsNullOrWhiteSpace(FullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        private string _LastName
        {
            get 
            { 
                return _LastName; 
            }
            set
            {
                _LastName = value; 
            }
        }
        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
