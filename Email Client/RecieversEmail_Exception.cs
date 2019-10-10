using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Client
{
    class RecieversEmail_Exception:Exception
    {
        public RecieversEmail_Exception(string message)
            :base(message)
        {

        }
    }
}
