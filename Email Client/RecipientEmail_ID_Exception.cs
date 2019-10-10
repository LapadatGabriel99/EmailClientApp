using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Client
{
    public class RecipientEmail_ID_Exception:Exception
    {
        public RecipientEmail_ID_Exception(string message)
            : base(message)
        {

        }
    }
}
