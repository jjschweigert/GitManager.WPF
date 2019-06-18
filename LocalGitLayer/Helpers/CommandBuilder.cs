using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalGitLayer
{
    public static class CommandBuilder
    {
        #region Command Types

        public static class CommandType
        {
            public enum Management_T
            {
                CLONE,
                INIT,
                RESET,
                DELETE
            }

            public enum Update_T
            {
                COMMIT,
                PULL,
                PUSH,
                STATUS
            }

            public enum Utility_T
            {
                DIFF,
                LOG
            }
        }

        #endregion Command Types
    }
}
