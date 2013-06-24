using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeNote.Model;
using TakeNote.DAL;
using TakeNote.DAL.Interfaces;
namespace TakeNote.Services.Interfaces
{
    public interface IPostService
    {
        /// <summary>
        /// Get a specific post
        /// </summary>
        /// <param name="requestor">The user who is making the current request.</param>
        /// <param name="id"></param>
        /// <returns></returns>
        Post GetPost(User requestor, int id);
        /// <summary>
        /// Get posts posted by the user whose ID is <paramref name="userID"/>
        /// </summary>
        /// <param name="requestor"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<Post> GetUserPosts(User requestor, int userID);
        Post CreatePost(User requestor, Post post);
        void DeletePost(User requestor, Post post);
        void UpdatePost(User requestor, Post post);
    }
}
