using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Model;
using TakeNote.DAL.Interfaces;
namespace TakeNote.DAL
{
    public class PostRepository : BaseRepository<Post>, IPostRepository    
    {
        public PostRepository(TakeNoteContext dbContext)
            : base(dbContext)
        {

        }
    }
}
