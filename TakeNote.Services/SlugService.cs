using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Model;
using TakeNote.DAL.Interfaces;
using TakeNote.Services.Interfaces;
namespace TakeNote.Services
{
    public class SlugService : ISlugService
    {
        public readonly string Separator = "-";
        public readonly int MaxLength = 60;
        private IPostRepository _postRepository;
        private User  _currentUser;
        /// <summary>
        /// The currentUser is needed to make sure the generated slug is unique per individual userspace.
        /// </summary>
        /// <param name="postRepository"></param>
        /// <param name="currentUser"></param>
        public SlugService(IPostRepository postRepository,User currentUser)
        {
            this._postRepository = postRepository;
            this._currentUser = currentUser;
        }
        public string CreateSlug(string title)
        {
            return title;
        }
    }
}
