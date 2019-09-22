using System;
using System.Collections.Generic;
using System.Text;
using Data.Types.Enums;

namespace Services.LocalConfig
{
    public class QueryBuilder
    {
        #region To String Methods

        public static string ToString(Sql_Query_Data.Sql_Query_Integer_T Int)
        {
            switch (Int)
            {
                case Sql_Query_Data.Sql_Query_Integer_T.BIG_INT:
                    return "BIGINT";

                case Sql_Query_Data.Sql_Query_Integer_T.INT:
                    return "INT";

                case Sql_Query_Data.Sql_Query_Integer_T.INT2:
                    return "INT2";

                case Sql_Query_Data.Sql_Query_Integer_T.INT8:
                    return "INT8";

                case Sql_Query_Data.Sql_Query_Integer_T.INTEGER:
                    return "INTEGER";

                case Sql_Query_Data.Sql_Query_Integer_T.MEDIUM_INT:
                    return "MEDIUMINT";

                case Sql_Query_Data.Sql_Query_Integer_T.SMALL_INT:
                    return "SMALLINT";

                case Sql_Query_Data.Sql_Query_Integer_T.UNSIGNED_BIG_INT:
                    return "UNSIGNED BIG INT";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Data.Sql_Query_Text_T Text)
        {
            switch (Text)
            {
                case Sql_Query_Data.Sql_Query_Text_T.CHARACTER:
                    return "CHARACTER({0})";

                case Sql_Query_Data.Sql_Query_Text_T.CLOB:
                    return "CLOB";

                case Sql_Query_Data.Sql_Query_Text_T.NATIVE_CHARACTER:
                    return "NATIVE CHARACTER({0})";

                case Sql_Query_Data.Sql_Query_Text_T.NCHAR:
                    return "NCHAR({0})";

                case Sql_Query_Data.Sql_Query_Text_T.NVARCHAR:
                    return "NVARCHAR({0})";

                case Sql_Query_Data.Sql_Query_Text_T.TEXT:
                    return "TEXT";

                case Sql_Query_Data.Sql_Query_Text_T.VARCHAR:
                    return "VARCHAR({0})";

                case Sql_Query_Data.Sql_Query_Text_T.VARYING_CHARACTER:
                    return "VARYING CHARACTER({0})";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Data.Sql_Query_None_T None)
        {
            switch (None)
            {
                case Sql_Query_Data.Sql_Query_None_T.BLOB:
                    return "BLOB";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Data.Sql_Query_Real_T Real)
        {
            switch (Real)
            {
                case Sql_Query_Data.Sql_Query_Real_T.DOUBLE:
                    return "DOUBLE";

                case Sql_Query_Data.Sql_Query_Real_T.DOUBLE_PRECISION:
                    return "DOUBLE PRECISION";

                case Sql_Query_Data.Sql_Query_Real_T.FLOAT:
                    return "FLOAT";

                case Sql_Query_Data.Sql_Query_Real_T.REAL:
                    return "REAL";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Data.Sql_Query_Numeric_T Num)
        {
            switch (Num)
            {
                case Sql_Query_Data.Sql_Query_Numeric_T.BOOLEAN:
                    return "BOOLEAN";

                case Sql_Query_Data.Sql_Query_Numeric_T.DATE:
                    return "DATE";

                case Sql_Query_Data.Sql_Query_Numeric_T.DATETIME:
                    return "DATETIME";

                case Sql_Query_Data.Sql_Query_Numeric_T.DECIMAL:
                    return "DECIMAL({0},{1})";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Clauses.Sql_Query_Operation_T Op)
        {
            switch (Op)
            {
                case Sql_Query_Clauses.Sql_Query_Operation_T.CREATE_DATABASE:
                    return "CREATE DATABASE";

                case Sql_Query_Clauses.Sql_Query_Operation_T.CREATE_TABLE:
                    return "CREATE TABLE";

                case Sql_Query_Clauses.Sql_Query_Operation_T.DELETE:
                    return "DELETE FROM {0} WHERE {1}";

                case Sql_Query_Clauses.Sql_Query_Operation_T.DROP_TABLE:
                    return "DROP TABLE {0}";

                case Sql_Query_Clauses.Sql_Query_Operation_T.INSERT:
                    return "INSERT INTO {0} [{1}] VALUES ({2})";

                case Sql_Query_Clauses.Sql_Query_Operation_T.SELECT:
                    return "SELECT {0} FROM {1}";

                case Sql_Query_Clauses.Sql_Query_Operation_T.UPDATE:
                    return "UPDATE {0} SET {1} WHERE {2}";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Clauses.Sql_Query_Clause_T Clause, bool LeadingClause = false)
        {
            string FullClause = "";

            switch (Clause)
            {
                case Sql_Query_Clauses.Sql_Query_Clause_T.AND:

                    if (LeadingClause)
                    {
                        FullClause += "AND ";
                    }

                    FullClause += "{0} AND {1}";

                    return FullClause;

                case Sql_Query_Clauses.Sql_Query_Clause_T.GLOB:
                    return "GLOB {0}";

                case Sql_Query_Clauses.Sql_Query_Clause_T.GROUP_BY:
                    return "GROUP BY {0}";

                case Sql_Query_Clauses.Sql_Query_Clause_T.HAVING:
                    return "HAVING {0}";

                case Sql_Query_Clauses.Sql_Query_Clause_T.LIKE:
                    return "LIKE {0}";

                case Sql_Query_Clauses.Sql_Query_Clause_T.LIMIT:
                    return "LIMIT {0}";

                case Sql_Query_Clauses.Sql_Query_Clause_T.OR:

                    if (LeadingClause)
                    {
                        FullClause += "OR ";
                    }

                    FullClause += "{0} OR {1}";

                    return FullClause;

                case Sql_Query_Clauses.Sql_Query_Clause_T.ORDER_BY:
                    return "ORDER BY {0}";

                case Sql_Query_Clauses.Sql_Query_Clause_T.WHERE:
                    return "WHERE {0}";

                default:
                    return "";
            }
        }

        public static string ToString(Sql_Query_Clauses.Sql_Query_Keyword_T Keyword)
        {
            switch (Keyword)
            {
                case Sql_Query_Clauses.Sql_Query_Keyword_T.DISTINCT:
                    return "DISTINCT";

                default:
                    return "";
            }
        }

        #endregion To String Methods
    }
}
