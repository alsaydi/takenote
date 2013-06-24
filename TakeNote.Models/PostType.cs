using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TakeNote.Model
{
    public class PostType
    {
        public int PostTypeId { get; set; }
        [MaxLength(100)]
        public string PostTypeName { get; set; }
    }

}
