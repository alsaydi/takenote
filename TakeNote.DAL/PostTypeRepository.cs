using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Model;
namespace TakeNote.DAL.Interfaces
{
    public class PostTypeRepository : BaseRepository<PostType>, IPostTypeRepository
    {
        public PostTypeRepository(TakeNoteContext dbContext)
            : base(dbContext)
        {
            
        }
        public override void Add(PostType entity)
        {
            throw new DALException("Add operation is not supported for type " + this.GetType().Name + ".");
        }
        public override void Update(PostType entity)
        {
            throw new DALException("Update operation is not supported for type " + this.GetType().Name + ".");
        }
        public override void Delete(PostType entity)
        {
            throw new DALException("Delete operation is not supported for type " + this.GetType().Name + ".");
        }
    }
}
