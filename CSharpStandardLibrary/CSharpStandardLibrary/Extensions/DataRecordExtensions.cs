using System;
using System.Data;

namespace CSharpStandardLibrary.Extensions
{
    public static class DataRecordExtentions
    {
        public static T GetValueWithDbNullNormalization<T>(this IDataRecord row, string columnName)
        {
            if (Convert.IsDBNull(row[columnName]))
                return default(T);

            return (T) row[columnName];
        }

        public static string GetTextWithDbNullNormalization(this IDataRecord row, string columnName)
        {
            if (Convert.IsDBNull(row[columnName]))
                return null;

            var o = row[columnName];

            if (o == null)
                return null;

            return row[columnName].ToString();
        }
    }
}