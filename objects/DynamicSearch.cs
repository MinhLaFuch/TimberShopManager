using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.objects
{
    /// <summary>
    /// Provides dynamic search functionality for a DataGridView using multiple input controls (TextBox or ComboBox).
    /// Automatically listens to the TextChanged event of each control and applies a filter on the grid in real time.
    /// </summary>
    ///
    /// <remarks>
    /// Usage:
    /// 1. Initialize the class with:
    ///    - A list of search input controls (TextBoxes or ComboBoxes).
    ///    - A dictionary mapping control names to column names in the DataTable.
    ///    - A function delegate that loads the original unfiltered DataTable.
    ///    - The target DataGridView to apply filtering on.
    ///
    /// 2. Call <see cref="Enable"/> to start listening to input changes and apply dynamic filtering.
    /// 3. Call <see cref="Disable"/> to stop filtering and detach all event listeners.
    /// 
    /// Filtering logic uses SQL-style LIKE with wildcard '%' for partial matching.
    /// All conditions are combined using OR logic (i.e., matches if *any* condition is met).
    /// </remarks>
    ///
    /// <example>
    /// Example:
    /// <code>
    /// var searchHelper = new DynamicSearch(
    ///     new List<Control> { txtID, txtName },
    ///     new Dictionary<string, string>
    ///     {
    ///         { "txtID", "SupplierID" },
    ///         { "txtName", "Name" }
    ///     },
    ///     LoadSupplierData,
    ///     dgvSupplier
    /// );
    ///
    /// searchHelper.Enable(); // Start dynamic filtering
    /// searchHelper?.Disable(); // Stop filtering when needed (Notify ?)
    /// </code>
    /// </example>

    internal class DynamicSearch
    {
        private readonly List<Control> _searchControls;
        private readonly Dictionary<string, string> _columnMappings;
        private readonly Func<DataTable> _loadDataFunc;
        private readonly DataGridView _targetGrid;

        private bool _isEnabled = false;

        public DynamicSearch(List<Control> searchControls,
                                    Dictionary<string, string> columnMappings,
                                    Func<DataTable> loadDataFunc,
                                    DataGridView targetGrid)
        {
            _searchControls = searchControls;
            _columnMappings = columnMappings;
            _loadDataFunc = loadDataFunc;
            _targetGrid = targetGrid;
        }

        public void Enable()
        {
            if (_isEnabled) return;

            foreach (var control in _searchControls)
            {
                if (control is TextBox textBox)
                    textBox.TextChanged += Control_TextChanged;
                else if (control is ComboBox comboBox)
                    comboBox.TextChanged += Control_TextChanged;
            }

            _isEnabled = true;
        }

        public void Disable()
        {
            if (!_isEnabled) return;

            foreach (var control in _searchControls)
            {
                if (control is TextBox textBox)
                    textBox.TextChanged -= Control_TextChanged;
                else if (control is ComboBox comboBox)
                    comboBox.TextChanged -= Control_TextChanged;
            }

            _isEnabled = false;
        }

        private void Control_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        public void ApplyFilter()
        {
            var filters = new List<string>();

            foreach (var control in _searchControls)
            {
                string value = "";

                if (control is TextBox tb && !string.IsNullOrEmpty(tb.Text))
                    value = tb.Text;
                else if (control is ComboBox cb && !string.IsNullOrEmpty(cb.Text))
                    value = cb.Text;

                if (!string.IsNullOrEmpty(value) && _columnMappings.TryGetValue(control.Name, out string columnName))
                {
                    filters.Add($"{columnName} LIKE '%{value.Replace("'", "''")}%'");
                }
            }

            var dataTable = _loadDataFunc.Invoke();
            var dv = new DataView(dataTable);

            dv.RowFilter = filters.Count > 0 ? string.Join(" OR ", filters) : string.Empty;
            _targetGrid.DataSource = dv;
        }
    }

}
