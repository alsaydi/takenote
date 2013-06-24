using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNote.DAL.Interfaces
{
    public class DALException : Exception
    {
        public DALException(string msg)
            : base(msg)
        {

        }
    }
}
