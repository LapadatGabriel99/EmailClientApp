using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Client
{
    public class RecipientPassword_Exception : Exception
    {
        public RecipientPassword_Exception(string message)
            :base(message)
        {

        }
    }
}
