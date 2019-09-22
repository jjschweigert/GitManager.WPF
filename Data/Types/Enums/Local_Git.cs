using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Types.Enums
{
    public class Local_Git
    {
        public enum Git_Management_T
        {
            CLONE,
            INIT,
            RESET,
            DELETE
        }

        public enum Git_Update_T
        {
            COMMIT,
            PULL,
            PUSH,
            STATUS
        }

        public enum Git_Utility_T
        {
            DIFF,
            LOG
        }
    }
}
