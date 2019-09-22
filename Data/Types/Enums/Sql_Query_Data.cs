using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Types.Enums
{
    public static class Sql_Query_Data
    {
        public enum Sql_Query_Integer_T
        {
            INT,
            INTEGER,
            SMALL_INT,
            MEDIUM_INT,
            BIG_INT,
            UNSIGNED_BIG_INT,
            INT2,
            INT8
        }

        public enum Sql_Query_Text_T
        {
            CHARACTER,
            VARCHAR,
            VARYING_CHARACTER,
            NCHAR,
            NATIVE_CHARACTER,
            NVARCHAR,
            TEXT,
            CLOB
        }

        public enum Sql_Query_Real_T
        {
            REAL,
            DOUBLE,
            DOUBLE_PRECISION,
            FLOAT
        }

        public enum Sql_Query_Numeric_T
        {
            NUMERIC,
            DECIMAL,
            BOOLEAN,
            DATE,
            DATETIME
        }

        public enum Sql_Query_None_T
        {
            BLOB
        }
    }
}
