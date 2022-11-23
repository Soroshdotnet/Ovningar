using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3_Inkapsling_arv_och_polymorfism
{
    abstract class UserError
    {
        abstract public string UEmessage();

    }

    private class NumericInputError : UserError
    { 
    }
}
