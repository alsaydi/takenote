using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNote.Services.Interfaces
{
    public interface ISlugService
    {
        string CreateSlug(string title);
    }
}
