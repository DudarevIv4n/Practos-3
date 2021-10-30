using LibMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_4
{
    public static class Solution
    {
        public static string GetColumnsProduct(this MyArray matrix)
        {
            string result = string.Empty;

            for (int i = 0; i < matrix.LineLength; i++)
            {
                int produt = 1;
                for (int j = 0; j < matrix.ColumnLength; j++)
                {
                    produt *= matrix[j, i];
                    if (j == matrix.ColumnLength - 1)
                    {
                        result += $"Произведение {i + 1} столбца = {produt}" + "\n";
                    }
                }
            }
            return result;
        }
    }
}
