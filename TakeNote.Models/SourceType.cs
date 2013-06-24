using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TakeNote.Model
{
    public class SourceType
    {
        public int SourceTypeId { get; set; }
        [MaxLength(100)]
        public string SourceTypeName { get; set; }
    }    
}
