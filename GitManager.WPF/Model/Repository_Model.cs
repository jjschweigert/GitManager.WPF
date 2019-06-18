using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitManager.WPF.Model
{
    public class Repository_Model
    {
        public enum Status_T
        {
            NONE,
            NEW,
            DEVELOPMENT,
            PRODUCTION
        }

        private DirectoryInfo RepositoryDirectory { get; set; }

        public string Path
        {
            get
            {
                return RepositoryDirectory.FullName;
            }
        }

        public string Name
        {
            get
            {
                return RepositoryDirectory.Name;
            }
        }

        public Commit NewestCommit { get; set; }

        public Status_T Status { get; set; }
    }
}
