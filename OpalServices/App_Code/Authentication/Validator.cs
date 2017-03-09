using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;

namespace OpalServices.App_Code
{
    public class Validator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == "sVjPFUsCFR52PJjbLLNTFted" && password == "ggXXDXACqjZjajALCMjyfrfd"))
            {
                throw new FaultException("Incorrect Username or Password");
            }
        }
    }
}