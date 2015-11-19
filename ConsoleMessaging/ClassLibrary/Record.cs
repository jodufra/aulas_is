using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Record
    {
        public String Subject;
        public String Body;

        public override String ToString()
        {
            return "Subject: " + Subject + ", Body: " + Body;
        }
    }
}
