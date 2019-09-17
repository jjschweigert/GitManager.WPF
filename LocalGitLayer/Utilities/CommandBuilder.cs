using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalGitLayer.Utilities
{
    public class CommandBuilder
    {
        #region Command Types

        public static class CommandType
        {
            private static readonly Type[] ValidTypes =
            {
                typeof(CommandType.Management_T),
                typeof(CommandType.Update_T),
                typeof(CommandType.Utility_T)
            };

            public static readonly Dictionary<Management_T, string> Management_T_Strings = new Dictionary<Management_T, string>
            {
                { Management_T.CLONE, "CLONE" },
                { Management_T.INIT, "INIT" },
                { Management_T.RESET, "RESET" },
                { Management_T.DELETE, "DELETE" }

            };

            public static readonly Dictionary<Update_T, string> Update_T_Strings = new Dictionary<Update_T, string>
            {
                { Update_T.COMMIT, "COMMIT" },
                { Update_T.PULL, "PULL" },
                { Update_T.PUSH, "PUSH" },
                { Update_T.STATUS, "STATUS" }

            };

            public static readonly Dictionary<Utility_T, string> Utility_T_Strings = new Dictionary<Utility_T, string>
            {
                { Utility_T.DIFF, "DIFF" },
                { Utility_T.LOG, "LOG" }
            };

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

            public static string ToString(object Command)
            {
                Type CommandType = Command.GetType();

                if(CommandType == ValidTypes[0])
                {
                    return Management_T_Strings[(Management_T)Command];
                }
                else if(CommandType == ValidTypes[1])
                {
                    return Update_T_Strings[(Update_T)Command];
                }
                else if(CommandType == ValidTypes[2])
                {
                    return Utility_T_Strings[(Utility_T)Command];
                }
                else
                {
                    return string.Empty;
                }
            }

            public static bool IsValidCommand(object Command)
            {
                if(ValidTypes.Contains(Command.GetType()))
                {
                    return true;
                }

                return false;
            }
        }

        #endregion Command Types

        private List<object> BatchOperation { get; set; } = new List<object>();

        public CommandBuilder()
        {

        }

        public string GetCurrentBatch()
        {
            string CurrentBatch = "";

            if(BatchOperation.Count > 0)
            {
                object LastOperation = BatchOperation.Last();

                foreach(object Operation in BatchOperation)
                {
                    if(Operation == LastOperation)
                    {
                        CurrentBatch += CommandType.ToString(Operation);
                    }
                    else
                    {
                        CurrentBatch += CommandType.ToString(Operation) + " => ";
                    }
                }
            }

            return CurrentBatch;
        }

        public void AddOperationToCurrentBatch(object NewOperation)
        {
            if(CommandType.IsValidCommand(NewOperation))
            {
                BatchOperation.Add(NewOperation);
            }
        }

        public void ClearCurrentBatch()
        {
            BatchOperation.Clear();
        }
    }
}
