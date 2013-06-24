using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Model;
using TakeNote.DAL.Interfaces;
namespace TakeNote.DAL
{
    public class SourceTypeRepository : BaseRepository<SourceType>, ISourceTypeRepository
    {
        public SourceTypeRepository(TakeNoteContext dbcContext)
            : base(dbcContext)
        {

        }
        public override void Add(SourceType entity)
        {
            throw new DALException("Add operation is not supported for type " + this.GetType().Name + ".");
        }
        public override void Update(SourceType entity)
        {
            throw new DALException("Update operation is not supported for type " + this.GetType().Name + ".");
        }
        public override void Delete(SourceType entity)
        {
            throw new DALException("Delete operation is not supported for type " + this.GetType().Name + ".");
        }
    }
}
