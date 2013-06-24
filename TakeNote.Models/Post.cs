using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNote.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostUrlSlug { get; set; }
        public string PostBody { get; set; }

        public int? PostTypeId { get; set; }
        public PostType PostType { get; set; }

        public string SourceUrl { get; set; }
        public int? SourceTypeId { get; set; }
        public SourceType SourceType { get; set; }
        
        public DateTimeOffset? DateAdded { get; set; }
        public DateTimeOffset? DateModified { get; set; }
        public DateTimeOffset? DatePublished { get; set; }

        public int? AuthorId { get; set; }
        public User Author { get; set; }

        public int? LastModifierId { get; set; } /* illustrate the use of zero-to-many relationship with no navigation property on the other side. */
        public User LastModifier { get; set; }

        public bool? IsPublic { get; set; }

        public DateTimeOffset? DateDeleted { get; set; }

        public int? ParentPostId { get; set; }
        public Post ParentPost { get; set; }
    }

}
