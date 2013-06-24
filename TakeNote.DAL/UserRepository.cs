using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Model;
using TakeNote.DAL.Interfaces;
namespace TakeNote.DAL
{
    public class UserRepository : BaseRepository<User>, IUserRepository    
    {
        public UserRepository(TakeNoteContext dbContext)
            : base(dbContext)
        {

        }
        
    }
}
