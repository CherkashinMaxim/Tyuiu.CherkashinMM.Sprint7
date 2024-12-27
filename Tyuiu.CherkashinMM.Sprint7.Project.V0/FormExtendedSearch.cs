using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    public partial class FormExtendedSearch : Form
    {
        public Func<string, string, string, bool> OnSearchTriggered;

        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;

        public FormExtendedSearch()
        {
            InitializeComponent();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            comboBoxColumns_CMM.Items.AddRange(new string[]
            {
            "Фамилия", "Имя", "Отчество", "Адрес", "Название товара",
            "Дата исполнения", "Номер счета", "Телефон", "Номер заказа",
            "Стоимость заказа", "Цена", "Количество"
            });

            comboBoxColumns_CMM.SelectedIndexChanged += ComboBoxColumns_SelectedIndexChanged;
            comboBoxColumns_CMM.SelectedIndex = 0;
        }

        private void ComboBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxColumns_CMM.SelectedItem.ToString();

            panelInput_CMM.Controls.Clear();

            if (selectedColumn == "Фамилия" || selectedColumn == "Имя" || selectedColumn == "Отчество" ||
                selectedColumn == "Адрес" || selectedColumn == "Название товара")
            {
                TextBox textBox = new TextBox { Width = 255, Location = new Point(0, 25), Size = new Size(255, 23) };

                panelInput_CMM.Controls.Add(new Label { Text = "Введите ключевые слова:", Location = new Point(0, 7), Size = new Size(148, 15) });
                panelInput_CMM.Controls.Add(textBox);
            }
            else if (selectedColumn == "Дата исполнения")
            {
                dateTimePickerFrom = new DateTimePicker { Width = 200, Format = DateTimePickerFormat.Short, Location = new Point(33, 0), Size = new Size(218, 23) };
                dateTimePickerTo = new DateTimePicker { Width = 200, Format = DateTimePickerFormat.Short, Location = new Point(33, 29), Size = new Size(218, 23) };

                panelInput_CMM.Controls.Add(new Label { Text = "От:", Location = new Point(3, 3), Width = 25 });
                panelInput_CMM.Controls.Add(dateTimePickerFrom);
                panelInput_CMM.Controls.Add(new Label { Text = "До:", Location = new Point(3, 33), Width = 25 });
                panelInput_CMM.Controls.Add(dateTimePickerTo);
            }
            else
            {
                textBoxFrom = new TextBox { Width = 200, Location = new Point(33, 0), Size = new Size(218, 23) };
                textBoxTo = new TextBox { Width = 200, Location = new Point(33, 29), Size = new Size(218, 23) };

                textBoxFrom.KeyPress += NumericTextBox_KeyPress;
                textBoxTo.KeyPress += NumericTextBox_KeyPress;

                panelInput_CMM.Controls.Add(new Label { Text = "От:", Location = new Point(3, 3), Width = 25 });
                panelInput_CMM.Controls.Add(textBoxFrom);
                panelInput_CMM.Controls.Add(new Label { Text = "До:", Location = new Point(3, 33), Width = 25 });
                panelInput_CMM.Controls.Add(textBoxTo);
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxColumns_CMM.SelectedItem == null || panelInput_CMM.Controls.Count == 0)
            {
                MessageBox.Show("Выберите столбец и введите значение для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedColumn = comboBoxColumns_CMM.SelectedItem.ToString();
            string fromValue = null;
            string toValue = null;

            if (panelInput_CMM.Controls.Count == 2 && panelInput_CMM.Controls[1] is TextBox textBoxSingle)
            {
                fromValue = textBoxSingle.Text;
            }
            else if (panelInput_CMM.Controls.Count == 4 && panelInput_CMM.Controls[1] is DateTimePicker && panelInput_CMM.Controls[3] is DateTimePicker)
            {
                fromValue = dateTimePickerFrom.Value.ToShortDateString();
                toValue = dateTimePickerTo.Value.ToShortDateString();
            }
            else if (panelInput_CMM.Controls.Count == 4 && panelInput_CMM.Controls[1] is TextBox && panelInput_CMM.Controls[3] is TextBox)
            {
                fromValue = textBoxFrom.Text;
                toValue = textBoxTo.Text;
            }

            if (string.IsNullOrWhiteSpace(fromValue))
            {
                MessageBox.Show("Введите значение для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = OnSearchTriggered?.Invoke(selectedColumn, fromValue, toValue) ?? false;

            if (found)
            {
                this.Close();
            }
        }
    }
}
