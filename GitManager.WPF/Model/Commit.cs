using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitManager.WPF.Model
{
    public class Commit
    {
        public DateTime Date { get; set; }
        public string ShortName { get; set; }
        public string Message { get; set; }
        public string Who { get; set; }
    }
}
