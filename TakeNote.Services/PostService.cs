using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Services.Interfaces;
using TakeNote.Model;
using TakeNote.DAL.Interfaces;

namespace TakeNote.Services
{
    public class PostService : IPostService 
    {
        private IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            this._postRepository = postRepository;
        }
        #region IPostService Members

        public Model.Post GetPost(Model.User requestor, int id)
        {
            var post =  this._postRepository.Find(id);
            return post;
        }

        public List<Model.Post> GetUserPosts(Model.User requestor, int userID)
        {
            var posts = this._postRepository.FindMany((p) => p.AuthorId == userID);
            return posts;
        }

        public Model.Post CreatePost(Model.User requestor, Model.Post post)
        {
            if (requestor == null)
            {
                throw new ArgumentNullException("requestor");
            }
            if (post == null)
            {
                throw new ArgumentNullException("post");
            }
            post.AuthorId = requestor.UserId;
            post.DateAdded = DateTimeOffset.Now;
            this._postRepository.Add(post);
            return post;
        }

        public void DeletePost(Model.User requestor, Model.Post post)
        {
            post.DateDeleted = DateTimeOffset.Now;
            this.UpdatePost(requestor, post);
        }

        public void UpdatePost(Model.User requestor, Model.Post post)
        {
            if (requestor == null)
            {
                throw new ArgumentNullException("requestor");
            }
            if (post == null)
            {
                throw new ArgumentNullException("post");
            }
            if (requestor.UserId != post.AuthorId)
            {
                throw new AuthorizationException("Only the author of a post can modify it.");
            }
            post.LastModifierId = requestor.UserId;
            post.DateModified = DateTimeOffset.Now;
            this._postRepository.Update(post);
        }

        #endregion
    }
}
