namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    partial class FormSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSort));
            comboBoxOrder_CMM = new ComboBox();
            buttonDone_CMM = new Button();
            labelOrder_CMM = new Label();
            comboBoxSort_CMM = new ComboBox();
            labelColumn_CMM = new Label();
            SuspendLayout();
            // 
            // comboBoxOrder_CMM
            // 
            comboBoxOrder_CMM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrder_CMM.FormattingEnabled = true;
            comboBoxOrder_CMM.Items.AddRange(new object[] { "От А до Я", "От Я до А" });
            comboBoxOrder_CMM.Location = new Point(220, 28);
            comboBoxOrder_CMM.Name = "comboBoxOrder_CMM";
            comboBoxOrder_CMM.Size = new Size(185, 23);
            comboBoxOrder_CMM.TabIndex = 3;
            // 
            // buttonDone_CMM
            // 
            buttonDone_CMM.Location = new Point(424, 28);
            buttonDone_CMM.Name = "buttonDone_CMM";
            buttonDone_CMM.Size = new Size(89, 23);
            buttonDone_CMM.TabIndex = 5;
            buttonDone_CMM.Text = "Выполнить";
            buttonDone_CMM.UseVisualStyleBackColor = true;
            buttonDone_CMM.Click += this.buttonDone_CMM_Click;
            // 
            // labelOrder_CMM
            // 
            labelOrder_CMM.AutoSize = true;
            labelOrder_CMM.Location = new Point(220, 10);
            labelOrder_CMM.Name = "labelOrder_CMM";
            labelOrder_CMM.Size = new Size(55, 15);
            labelOrder_CMM.TabIndex = 6;
            labelOrder_CMM.Text = "Порядок";
            // 
            // comboBoxSort_CMM
            // 
            comboBoxSort_CMM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort_CMM.FormattingEnabled = true;
            comboBoxSort_CMM.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Номер счета", "Адрес", "Телефон", "Номер заказа", "Дата исполнения", "Стоимость заказа", "Название товара", "Цена", "Количество" });
            comboBoxSort_CMM.Location = new Point(14, 28);
            comboBoxSort_CMM.Name = "comboBoxSort_CMM";
            comboBoxSort_CMM.Size = new Size(185, 23);
            comboBoxSort_CMM.TabIndex = 4;
            // 
            // labelColumn_CMM
            // 
            labelColumn_CMM.AutoSize = true;
            labelColumn_CMM.Location = new Point(14, 10);
            labelColumn_CMM.Name = "labelColumn_CMM";
            labelColumn_CMM.Size = new Size(54, 15);
            labelColumn_CMM.TabIndex = 7;
            labelColumn_CMM.Text = "Столбец";
            // 
            // FormSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 63);
            Controls.Add(comboBoxOrder_CMM);
            Controls.Add(buttonDone_CMM);
            Controls.Add(labelOrder_CMM);
            Controls.Add(comboBoxSort_CMM);
            Controls.Add(labelColumn_CMM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сортировка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ComboBox comboBoxOrder_CMM;
        private Button buttonDone_CMM;
        private Label labelOrder_CMM;
        private ComboBox comboBoxSort_CMM;
        private Label labelColumn_CMM;
    }
}