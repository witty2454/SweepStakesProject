using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class Contestant
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNum;

        public Contestant()
        {
            FirstName = UserInterface.GetFirstName();
            LastName = UserInterface.GetLastName();
            EmailAddress = UserInterface.GetEmailAddress();
            RegistrationNum = 0;
        }
    }
}