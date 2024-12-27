using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Threading.Channels;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.CherkashinMM.Sprint7.Project.V0.Lib;

namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{

    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private ComboBox comboBox1;
        private string openFilePath;
        private string resourcesPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources"));
        private bool fileOpened = false;
        private bool changed = false;
        private bool newFile = false;

        private string[] columnNames = {
            "Фамилия", "Имя", "Отчество", "Номер счета", "Адрес", "Телефон",
            "Номер заказа", "Дата исполнения", "Стоимость заказа",
            "Название товара", "Цена", "Количество"
        };

        public FormMain()
        {
            InitializeComponent();
            TrackChanges();

            openFileDialog_CMM.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_CMM.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

            saveFileDialog_CMM.Title = "Сохранить как...";
            saveFileDialog_CMM.FileName = "data.csv";

            menuStrip_CMM.Renderer = new RoundedMenuStripRenderer();

            this.Resize += FormMain_Resize;

            Button invisibleButton = new Button
            {
                Size = new Size(0, 0),
                Location = new Point(-10, -10),
                TabStop = false
            };

            this.Controls.Add(invisibleButton);

            splitContainerGridAndContainer2_CMM.Panel1.Enabled = true;

            buttonExtendedSearch_CMM.Tag = Image.FromFile(resourcesPath + @"\ExtendedSearch_16x1.png");
            buttonSearch_CMM.Tag = Image.FromFile(resourcesPath + @"\Search_16x.png");
            buttonSearchFilter_CMM.Tag = Image.FromFile(resourcesPath + @"\Filter_16x.png");
            buttonSort_CMM.Tag = Image.FromFile(resourcesPath + @"\Sort_16x.png");
            buttonAddClient_CMM.Tag = Image.FromFile(resourcesPath + @"\Add_grey_16x.png");
            buttonRefreshStats_CMM.Tag = Image.FromFile(resourcesPath + @"\ResetTimelineViewDisabled_16x.png");
            buttonRefreshFile_CMM.Tag = Image.FromFile(resourcesPath + @"\RefreshScript_grey_16x.png");

            dataGridView_CMM.CellClick += DataGridView_CellClick;

            resetAll();
            labelStats_CMM.Visible = false;

            this.ActiveControl = invisibleButton;
        }

        

        /* ------- Работа с таблицей ------- */

        private void addFirstColumn()
        {
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "🗑️",
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 30
            };

            var rowNumberColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "№",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = 30
            };

            dataGridView_CMM.Columns.Add(deleteButtonColumn);
            dataGridView_CMM.Columns.Add(rowNumberColumn);

            dataGridView_CMM.RowsAdded += UpdateRowNumbers;
            dataGridView_CMM.RowsRemoved += UpdateRowNumbers;

            dataGridView_CMM.ColumnHeaderMouseClick += (s, e) =>
            {
                if (e.ColumnIndex == 1)
                {
                    UpdateRowNumbers(null, null);
                }
            };

            foreach (var columnName in columnNames)
            {
                dataGridView_CMM.Columns.Add(columnName, columnName);
            }

            dataGridView_CMM.CellBeginEdit += (s, e) =>
            {
                if (e.RowIndex == 0 || e.ColumnIndex == 0)
                {
                    e.Cancel = false;
                }
            };

            dataGridView_CMM.AllowUserToAddRows = true;
            saveAsToolStripMenuItem_CMM.Enabled = true;
            saveToolStripMenuItem_CMM.Enabled = true;
            toolStripMenuItemDeleteSelected_CMM.Enabled = true;
            toolStripMenuItemSelectAll_CMM.Enabled = true;
            exitToolStripMenuItem_CMM.Enabled = true;
            buttonAddClient_CMM.Enabled = true;
            buttonRefreshStats_CMM.Enabled = true;
            buttonExtendedSearch_CMM.Enabled = true;
            buttonSort_CMM.Enabled = true;
            buttonSearchFilter_CMM.Enabled = true;
            buttonSearch_CMM.Enabled = true;
            toolStripMenuItemExtendedSearch_CMM.Enabled = true;
            toolStripMenuItemSortFile_CMM.Enabled = true;
            toolStripMenuItemRefreshStats_CMM.Enabled = true;
            fileOpened = true;
        }

        private void UpdateRowNumbers(object sender, EventArgs e)
        {
            if (dataGridView_CMM.Columns.Count > 1 && dataGridView_CMM.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_CMM.Rows.Count; i++)
                {
                    if (dataGridView_CMM.Rows[i].Cells.Count > 1)
                    {
                        dataGridView_CMM.Rows[i].Cells[1].Value = (i + 1).ToString();
                    }
                }
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_CMM.Rows[e.RowIndex];
                if (e.ColumnIndex == 0 && e.RowIndex >= 0 && !row.IsNewRow)
                {
                    dataGridView_CMM.Rows.RemoveAt(e.RowIndex);
                    UpdateRowNumbers(null, null);
                }
            }
        }

        private void dataGridView_CMM_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            string[] numericColumns = { "Номер счета", "Номер заказа", "Стоимость заказа", "Цена" };

            if (numericColumns.Contains(e.Column.HeaderText))
            {
                if (decimal.TryParse(e.CellValue1?.ToString(), out decimal value1) &&
                    decimal.TryParse(e.CellValue2?.ToString(), out decimal value2))
                {
                    e.SortResult = value1.CompareTo(value2);
                    e.Handled = true;
                }
            }
            else
            {
                e.SortResult = string.Compare(e.CellValue1?.ToString(), e.CellValue2?.ToString());
                e.Handled = true;
            }
            UpdateRowNumbers(null, null);
        }

        private string[,] ConvertDataGridViewToArray(DataGridView dataGridView)
        {
            int rows = dataGridView.Rows.Count - 1;
            int cols = dataGridView.Columns.Count - 2;
            string[,] data = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 2; j < dataGridView.Columns.Count; j++)
                {
                    data[i, j - 2] = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                }
            }

            return data;
        }

        /* ------- Работа с файлами ------- */

        private void openToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            if (fileOpened)
            {
                var result = MessageBox.Show(
                    "У вас уже открыт файл. Вы уверены, что хотите открыть другой файл?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }

                dataGridView_CMM.Rows.Clear();
                dataGridView_CMM.Columns.Clear();
            }
            if (openFileDialog_CMM.ShowDialog() == DialogResult.OK)
            {
                addFirstColumn();
                openFilePath = openFileDialog_CMM.FileName;

                try
                {
                    List<string[]> file = ds.readTable(openFilePath);
                    LoadDataIntoGridView(file);
                    LoadDataToChartAndStats();
                    buttonRefreshFile_CMM.Enabled = true;
                    toolStripMenuItemRefreshFile_CMM.Enabled = true;
                    changed = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                resetAll();
            }
        }

        private void saveAsToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_CMM.ShowDialog() == DialogResult.OK)
            {
                openFilePath = saveFileDialog_CMM.FileName;

                try
                {
                    string[,] data = ConvertDataGridViewToArray(dataGridView_CMM);
                    ds.SaveToFile(openFilePath, columnNames, data);
                    MessageBox.Show("Данные успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changed = false;
                    newFile = false;
                    buttonRefreshFile_CMM.Enabled = true;
                    toolStripMenuItemRefreshFile_CMM.Enabled = true;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Нет доступа для сохранения файла. Выберите другой путь.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            if (newFile)
            {
                saveAsToolStripMenuItem_CMM_Click(sender, e);
                return;
            }

            try
            {
                string[,] data = ConvertDataGridViewToArray(dataGridView_CMM);
                ds.SaveToFile(openFilePath, columnNames, data);
                MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changed = false;
                newFile = false;
                buttonRefreshFile_CMM.Enabled = true;
                toolStripMenuItemRefreshFile_CMM.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefreshFile_CMM_Click_1(object sender, EventArgs e)
        {
            if (!newFile)
            {
                dataGridView_CMM.Rows.Clear();
                dataGridView_CMM.Columns.Clear();

                string pth = openFilePath;

                resetAll();
                addFirstColumn();

                openFilePath = pth;

                try
                {
                    List<string[]> file = ds.readTable(pth);
                    LoadDataIntoGridView(file);
                    LoadDataToChartAndStats();
                    buttonRefreshFile_CMM.Enabled = true;
                    toolStripMenuItemRefreshFile_CMM.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            if (changed == true)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите закрыть файл, не сохранив его?",
                    "Подтверждение закрытия",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            dataGridView_CMM.Rows.Clear();
            dataGridView_CMM.Columns.Clear();

            resetAll();
        }

        private void newToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            if (fileOpened)
            {
                var result = MessageBox.Show(
                    "У вас уже открыт файл. Вы уверены, что хотите создать новый файл?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dataGridView_CMM.Rows.Clear();
                    addFirstColumn();
                }
            }
            else
            {
                addFirstColumn();
                newFile = true;
            }
        }

        private void LoadDataIntoGridView(List<string[]> file)
        {
            if (file == null || file.Count == 0)
            {
                MessageBox.Show("Файл пуст или не содержит данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var line in file)
            {
                int newRowIndex = dataGridView_CMM.Rows.Add();

                for (int j = 0; j < line.Length; j++)
                {
                    if (j + 2 < dataGridView_CMM.Columns.Count)
                    {
                        dataGridView_CMM.Rows[newRowIndex].Cells[j + 2].Value = line[j];
                    }
                }

                dataGridView_CMM.Rows[newRowIndex].Cells[0].Value = "🗑️";
            }
        }

        /* ------- Сортировка ------- */

        private void buttonSort_CMM_Click(object sender, EventArgs e)
        {
            using (FormSort sortForm = new FormSort())
            {
                if (sortForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedColumn = sortForm.SelectedColumn;
                    string sortOrder = sortForm.SortOrder;

                    PerformSorting(selectedColumn, sortOrder);
                }
            }
        }

        private void PerformSorting(string columnName, string sortOrder)
        {
            string[] numericColumns = { "Номер счета", "Номер заказа", "Стоимость заказа", "Цена" };

            var column = dataGridView_CMM.Columns.Cast<DataGridViewColumn>()
                          .FirstOrDefault(c => c.HeaderText == columnName);

            if (column == null)
            {
                MessageBox.Show("Указанный столбец не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int columnIndex = column.Index;
            bool ascending = sortOrder == "От А до Я";

            var rows = dataGridView_CMM.Rows.Cast<DataGridViewRow>()
                        .Where(r => !r.IsNewRow)
                        .ToList();

            if (numericColumns.Contains(column.HeaderText))
            {
                rows = ascending
                    ? rows.OrderBy(r =>
                    {
                        if (decimal.TryParse(r.Cells[columnIndex].Value?.ToString(), out decimal value))
                            return value;
                        return decimal.MinValue;
                    }).ToList()
                    : rows.OrderByDescending(r =>
                    {
                        if (decimal.TryParse(r.Cells[columnIndex].Value?.ToString(), out decimal value))
                            return value;
                        return decimal.MinValue;
                    }).ToList();
            }
            else
            {
                rows = ascending
                    ? rows.OrderBy(r => r.Cells[columnIndex].Value?.ToString()).ToList()
                    : rows.OrderByDescending(r => r.Cells[columnIndex].Value?.ToString()).ToList();
            }

            dataGridView_CMM.Rows.Clear();
            foreach (var row in rows)
            {
                dataGridView_CMM.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());
            }
        }

        /* ------- Работа с клиентами ------- */

        private void buttonAddClient_CMM_Click(object sender, EventArgs e)
        {
            if (dataGridView_CMM.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_CMM.SelectedCells[0].RowIndex;
                int newRowIndex = selectedRowIndex + 1;

                dataGridView_CMM.Rows.Insert(newRowIndex);
                dataGridView_CMM.Rows[newRowIndex].Cells[0].Value = "🗑️";
            }
            else
            {
                int newRowIndex = dataGridView_CMM.Rows.Add();
                dataGridView_CMM.Rows[newRowIndex].Cells[0].Value = "🗑️";
            }
            UpdateRowNumbers(null, null);
        }

        private void toolStripMenuItemDeleteSelected_CMM_Click(object sender, EventArgs e)
        {
            if (dataGridView_CMM.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить строки, связанные с выделенными ячейками?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    HashSet<int> rowsToDelete = new HashSet<int>();
                    foreach (DataGridViewCell cell in dataGridView_CMM.SelectedCells)
                    {
                        if (!dataGridView_CMM.Rows[cell.RowIndex].IsNewRow)
                        {
                            rowsToDelete.Add(cell.RowIndex);
                        }
                    }

                    foreach (int rowIndex in rowsToDelete.OrderByDescending(index => index))
                    {
                        dataGridView_CMM.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выделенных ячеек для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* ------- Поиск ------- */

        private void buttonSearch_CMM_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_CMM.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText.Contains("Введите ключевые слова"))
            {
                MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lowerSearchText = searchText.ToLower();

            var rowsToMove = dataGridView_CMM.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells.Cast<DataGridViewCell>()
                .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(lowerSearchText)))
                .ToList();

            foreach (var row in rowsToMove)
            {
                dataGridView_CMM.Rows.Remove(row);
                dataGridView_CMM.Rows.Insert(0, row);
            }

            if (rowsToMove.Count > 0)
            {
                dataGridView_CMM.ClearSelection();
                foreach (var row in rowsToMove)
                {
                    row.Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Совпадений не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateRowNumbers(null, null);
        }

        private void buttonSearchFilter_CMM_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_CMM.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText.Contains("Введите ключевые слова"))
            {
                MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lowerSearchText = searchText.ToLower();

            var matchingRows = dataGridView_CMM.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells.Cast<DataGridViewCell>()
                .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(lowerSearchText)))
                .ToList();

            for (int i = dataGridView_CMM.Rows.Count - 1; i >= 0; i--)
            {
                if (!matchingRows.Contains(dataGridView_CMM.Rows[i]) && !dataGridView_CMM.Rows[i].IsNewRow)
                {
                    dataGridView_CMM.Rows.RemoveAt(i);
                }
            }

            if (matchingRows.Count == 0)
            {
                MessageBox.Show("Совпадений не найдено.", "Результат фильтрации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateRowNumbers(null, null);
        }

        private void buttonExtendedSearch_CMM_Click(object sender, EventArgs e)
        {
            FormExtendedSearch formExtendedSearch = new FormExtendedSearch();
            formExtendedSearch.OnSearchTriggered = (column, fromValue, toValue) =>
            {
                bool found = PerformSearch(column, fromValue, toValue);
                return found;
            };

            formExtendedSearch.ShowDialog();
        }

        private bool PerformSearch(string columnName, string fromValue, string toValue)
        {
            if (dataGridView_CMM.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста. Выполните загрузку данных перед поиском.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int columnIndex = dataGridView_CMM.Columns[columnName].Index;
            var matchingRows = dataGridView_CMM.Rows.Cast<DataGridViewRow>()
            .Where(row =>
            {
                if (row.IsNewRow) return false;

                var cellValue = row.Cells[columnIndex].Value?.ToString();
                if (string.IsNullOrWhiteSpace(cellValue)) return false;

                if (fromValue != null && toValue != null)
                {
                    if (decimal.TryParse(cellValue, out decimal numericValue))
                    {
                        if (decimal.TryParse(fromValue, out decimal fromNumeric) && decimal.TryParse(toValue, out decimal toNumeric))
                        {
                            return numericValue >= fromNumeric && numericValue <= toNumeric;
                        }
                    }
                    else if (DateTime.TryParse(cellValue, out DateTime dateValue))
                    {
                        if (DateTime.TryParse(fromValue, out DateTime fromDate) && DateTime.TryParse(toValue, out DateTime toDate))
                        {
                            return dateValue >= fromDate && dateValue <= toDate;
                        }
                    }
                    return false;
                }
                else if (fromValue != null)
                {
                    return cellValue.ToLower().Contains(fromValue.ToLower());
                }

                return false;
            }).ToList();

            if (matchingRows.Count == 0)
            {
                MessageBox.Show("Совпадений не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            foreach (DataGridViewRow row in matchingRows)
            {
                dataGridView_CMM.Rows.Remove(row);
                dataGridView_CMM.Rows.Insert(0, row);
            }

            foreach (DataGridViewRow row in matchingRows)
            {
                row.Selected = true;
            }

            MessageBox.Show($"Найдено совпадений: {matchingRows.Count}.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        /* ------- Интерфейс ------- */

        private void FormMain_Resize(object sender, EventArgs e)
        {
            textBoxSearch_CMM.Width = buttonSearch_CMM.Location.X - buttonSearch_CMM.Width + 37;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileOpened && changed)
            {
                var result = MessageBox.Show($"Вы хотите сохранить изменения в файле {openFilePath}?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_CMM_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void toolStripMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            dataGridView_CMM.SelectAll();
        }

        private void guideToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.ShowDialog();
        }

        private void aboutToolStripMenuItem_CMM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        /* ------- Статистика и графики ------- */

        private void LoadDataToChartAndStats()
        {
            if (dataGridView_CMM.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста. Загрузите данные перед построением статистики.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, (int TotalQuantity, decimal TotalRevenue)> salesData = new();

            string[] allowedProducts = { "смартфон", "планшет", "телевизор", "часы", "наушники" };

            foreach (DataGridViewRow row in dataGridView_CMM.Rows)
            {
                if (row.IsNewRow) continue;

                var productName = row.Cells["Название товара"]?.Value?.ToString()?.ToLower();
                if (string.IsNullOrWhiteSpace(productName) || !allowedProducts.Contains(productName)) continue;

                if (!decimal.TryParse(row.Cells["Цена"]?.Value?.ToString(), out var price)) continue;
                if (!int.TryParse(row.Cells["Количество"]?.Value?.ToString(), out var quantity)) continue;

                if (salesData.ContainsKey(productName))
                {
                    salesData[productName] = (
                        TotalQuantity: salesData[productName].TotalQuantity + quantity,
                        TotalRevenue: salesData[productName].TotalRevenue + price * quantity
                    );
                }
                else
                {
                    salesData[productName] = (TotalQuantity: quantity, TotalRevenue: price * quantity);
                }
            }

            if (salesData.Count == 0)
            {
                MessageBox.Show("Нет корректных данных для анализа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chartStats_CMM.Series.Clear();
            chartStats_CMM.Titles.Clear();

            chartStats_CMM.Titles.Clear();
            var chartTitle = new Title
            {
                Text = "Статистика продаж по товарам",
                Font = new Font("Arial", 12),
                Docking = Docking.Top
            };
            chartStats_CMM.Titles.Add(chartTitle);
            chartStats_CMM.ChartAreas[0].AxisX.Title = "Товары";
            chartStats_CMM.ChartAreas[0].AxisY.Title = "Количество проданных единиц";

            chartStats_CMM.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            Series series = new Series("Продажи")
            {
                ChartType = SeriesChartType.Column,
                IsXValueIndexed = true
            };

            foreach (var item in salesData)
            {
                series.Points.AddXY(item.Key, item.Value.TotalQuantity);
                series.Points[0].LabelToolTip = "da";
            }

            foreach (var item in series.Points)
            {
                Console.WriteLine(item);
            }

            chartStats_CMM.Series.Add(series);

            var totalQuantity = salesData.Sum(item => item.Value.TotalQuantity);
            var totalRevenue = salesData.Sum(item => item.Value.TotalRevenue);
            var averagePrice = totalRevenue / (totalQuantity > 0 ? totalQuantity : 1);
            var maxSale = salesData.OrderByDescending(item => item.Value.TotalRevenue).FirstOrDefault();
            var minSale = salesData.OrderBy(item => item.Value.TotalRevenue).FirstOrDefault();

            labelStats_CMM.Text = $@"
Общая статистика:
- Количество проданных товаров: {totalQuantity}
- Общая выручка: {totalRevenue:C}
- Средняя цена товара: {averagePrice:C}
- Самый популярный товар: {maxSale.Key} (выручка: {maxSale.Value.TotalRevenue:C})
- Наименее популярный товар: {minSale.Key} (выручка: {minSale.Value.TotalRevenue:C})";
            labelStats_CMM.Visible = true;
        }

        private void buttonRefreshStats_CMM_Click(object sender, EventArgs e)
        {
            LoadDataToChartAndStats();
        }

        /* ------- Общее управление ------- */

        private void TrackChanges()
        {
            dataGridView_CMM.CellValueChanged += (s, e) =>
            {
                changed = true;
            };

            dataGridView_CMM.RowsRemoved += (s, e) =>
            {
                changed = true;
            };

            dataGridView_CMM.RowsAdded += (s, e) =>
            {
                if (!dataGridView_CMM.Rows[e.RowIndex].IsNewRow)
                {
                    changed = true;
                }
            };
        }

        private void resetAll()
        {
            dataGridView_CMM.AllowUserToAddRows = false;
            buttonAddClient_CMM.Enabled = false;
            saveAsToolStripMenuItem_CMM.Enabled = false;
            saveToolStripMenuItem_CMM.Enabled = false;
            toolStripMenuItemDeleteSelected_CMM.Enabled = false;
            toolStripMenuItemSelectAll_CMM.Enabled = false;
            exitToolStripMenuItem_CMM.Enabled = false;
            buttonRefreshStats_CMM.Enabled = false;
            buttonRefreshFile_CMM.Enabled = false;
            buttonExtendedSearch_CMM.Enabled = false;
            buttonSort_CMM.Enabled = false;
            buttonSearchFilter_CMM.Enabled = false;
            buttonSearch_CMM.Enabled = false;
            toolStripMenuItemExtendedSearch_CMM.Enabled = false;
            toolStripMenuItemRefreshFile_CMM.Enabled = false;
            toolStripMenuItemSortFile_CMM.Enabled = false;
            toolStripMenuItemRefreshStats_CMM.Enabled = false;
            fileOpened = false;
            openFilePath = null;

            changed = false;
        }
    }











    public class CircularButton : Button
    {
        private bool isPressed = false;

        public CircularButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false; 
            this.BackColor = Color.White;
            this.Text = "";

            this.Image = null;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);

            if (isPressed)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(50, Color.Black)))
                {
                    pevent.Graphics.FillEllipse(brush, 0, 0, this.Width, this.Height);
                }
            }

            using (Pen pen = new Pen(Color.LightGray, 2))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawEllipse(pen, 1, 1, this.Width - 2, this.Height - 2);
            }

            if (this.Tag is Image img)
            {
                int imgSize = Math.Min(this.Width, this.Height) / 2;
                int imgX = (this.Width - imgSize) / 2;
                int imgY = (this.Height - imgSize) / 2;

                pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                pevent.Graphics.DrawImage(img, imgX, imgY, imgSize, imgSize);
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            isPressed = true;
            Invalidate();
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            isPressed = false;
            Invalidate(); 
            base.OnMouseUp(mevent);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.Parent?.Focus();
        }
    }


    public class RoundedMenuStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var bounds = new Rectangle(Point.Empty, e.Item.Size);

            if (e.Item.Selected)
            {
                using (var brush = new SolidBrush(Color.FromArgb(50, Color.Black))) 
                using (var path = new GraphicsPath())
                {
                    int cornerRadius = 8; 
                    path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
                    path.AddArc(bounds.Right - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
                    path.AddArc(bounds.Right - cornerRadius, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                    path.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }

    public class CustomTextBox : Panel
    {
        private TextBox textBox;
        private int cornerRadius = 20;
        private string placeholderText = "Введите ключевые слова";
        private bool isPlaceholderActive = true;

        public CustomTextBox()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.Padding = new Padding(10, 5, 10, 5);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.Gray,
                BackColor = Color.White,
                Text = placeholderText,
                Location = new Point(Padding.Left, Padding.Top),
                Width = this.Width - Padding.Horizontal
            };

            this.Controls.Add(textBox);

            textBox.GotFocus += RemovePlaceholder;
            textBox.LostFocus += SetPlaceholder;

            this.Resize += CustomTextBox_Resize;
            this.Paint += CustomTextBox_Paint;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                isPlaceholderActive = true;
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void CustomTextBox_Resize(object sender, EventArgs e)
        {
            textBox.Width = this.Width - Padding.Horizontal;
            textBox.Height = this.Height - Padding.Vertical;

            textBox.Location = new Point(Padding.Left, (this.Height - textBox.Height) / 2);
            this.Invalidate();
        }

        private void CustomTextBox_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = GetRoundedRectanglePath(new Rectangle(0, 0, this.Width - 1, this.Height - 1), cornerRadius))
            using (Pen pen = new Pen(Color.LightGray, 1.5f))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        public string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }
    }
}