using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluation.Framework.Data.Converter
{
    public static class SqlDataTypes
    {
        public static string DBString(object valor)
        {
            if (valor.ToString().Length <= 0)
                return (string)null;
            return valor.ToString();
        }

        public static int DBInt32(object valor)
        {
            return Convert.ToInt32(valor);
        }

        public static int? DBInt32(object valor, bool IsNullable)
        {
            if (!IsNullable)
                return new int?(SqlDataTypes.DBInt32(valor));
            if (valor != null && valor != DBNull.Value)
                return new int?(Convert.ToInt32(valor));
            return new int?();
        }

        public static Decimal DBDecimal(object valor)
        {
            return Convert.ToDecimal(valor);
        }

        public static Decimal? DBDecimal(object valor, bool IsNullable)
        {
            if (!IsNullable)
                return new Decimal?((Decimal)SqlDataTypes.DBInt32(valor));
            if (valor != null && valor != DBNull.Value)
                return new Decimal?(Convert.ToDecimal(valor));
            return new Decimal?();
        }

        public static DateTime DBDateTime(object valor)
        {
            return Convert.ToDateTime(valor);
        }

        public static DateTime? DBDateTime(object valor, bool IsNullable)
        {
            if (!IsNullable)
                return new DateTime?(SqlDataTypes.DBDateTime(valor));
            if (valor != null && valor != DBNull.Value)
                return new DateTime?(Convert.ToDateTime(valor));
            return new DateTime?();
        }

        public static bool DBBoolean(object valor)
        {
            return Convert.ToBoolean(valor);
        }

        public static bool? DBBoolean(object valor, bool IsNullable)
        {
            if (!IsNullable)
                return new bool?(SqlDataTypes.DBBoolean(valor));
            if (valor != null && valor != DBNull.Value)
                return new bool?(Convert.ToBoolean(valor));
            return new bool?();
        }
    }
}