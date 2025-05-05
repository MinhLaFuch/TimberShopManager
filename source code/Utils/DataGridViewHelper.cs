using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.Utils
{
    public class DataGridViewHelper
    {
        public static void SetVietnameseHeaders(DataGridView dgv, Dictionary<string, string> headerMappings)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (headerMappings.TryGetValue(column.Name, out string header))
                {
                    column.HeaderText = header;
                }
            }
        }

        public static void FormatDateColumns(DataGridView dgv, string columnName, string format = "dd/MM/yyyy")
        {

            if (dgv.Columns.Contains(columnName))
            {
                dgv.Columns[columnName].DefaultCellStyle.Format = format;
            }
            
        }

        public static void FormatThousandSeparator(DataGridView dgv, List<string> columnNames)
        {
            foreach (var colName in columnNames)
            {
                if (dgv.Columns.Contains(colName))
                {
                    dgv.Columns[colName].DefaultCellStyle.Format = "N0";
                }
            }
        }

        public static void HideColumns(DataGridView dgv, params string[] columnNames)
        {
            foreach (string colName in columnNames)
            {
                if (dgv.Columns.Contains(colName))
                    dgv.Columns[colName].Visible = false;
            }
        }
    }
}
