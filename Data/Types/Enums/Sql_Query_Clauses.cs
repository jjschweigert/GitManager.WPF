using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Types.Enums
{
    public static class Sql_Query_Clauses
    {
        public enum Sql_Query_Operation_T
        {
            CREATE_DATABASE,
            CREATE_TABLE,
            DROP_TABLE,
            INSERT,
            SELECT,
            UPDATE,
            DELETE,
        }

        public enum Sql_Query_Clause_T
        {
            WHERE,
            AND,
            OR,
            LIKE,
            GLOB,
            LIMIT,
            ORDER_BY,
            GROUP_BY,
            HAVING
        }

        public enum Sql_Query_Keyword_T
        {
            DISTINCT
        }
    }
}
