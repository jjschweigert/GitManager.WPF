using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitManager.WPF.Model
{
    public class Note
    {
        public string Title { get; set; }
        public DateTime LastModified { get; set; }
        public string Content { get; set; }
    }
}
