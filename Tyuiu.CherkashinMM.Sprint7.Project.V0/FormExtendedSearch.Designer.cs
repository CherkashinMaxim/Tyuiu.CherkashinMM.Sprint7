namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    partial class FormExtendedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtendedSearch));
            comboBoxColumns_CMM = new ComboBox();
            panelInput_CMM = new Panel();
            textBox1 = new TextBox();
            labelFrom_CMM = new Label();
            buttonSearch_CMM = new Button();
            panelInput_CMM.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxColumns_CMM
            // 
            comboBoxColumns_CMM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColumns_CMM.FormattingEnabled = true;
            comboBoxColumns_CMM.Location = new Point(12, 12);
            comboBoxColumns_CMM.Name = "comboBoxColumns_CMM";
            comboBoxColumns_CMM.Size = new Size(121, 23);
            comboBoxColumns_CMM.TabIndex = 0;
            // 
            // panelInput_CMM
            // 
            panelInput_CMM.Controls.Add(textBox1);
            panelInput_CMM.Controls.Add(labelFrom_CMM);
            panelInput_CMM.Location = new Point(148, 12);
            panelInput_CMM.Name = "panelInput_CMM";
            panelInput_CMM.Size = new Size(255, 52);
            panelInput_CMM.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 1;
            // 
            // labelFrom_CMM
            // 
            labelFrom_CMM.AutoSize = true;
            labelFrom_CMM.Location = new Point(0, 7);
            labelFrom_CMM.Name = "labelFrom_CMM";
            labelFrom_CMM.Size = new Size(148, 15);
            labelFrom_CMM.TabIndex = 0;
            labelFrom_CMM.Text = "Введите ключевые слова:";
            // 
            // buttonSearch_CMM
            // 
            buttonSearch_CMM.Location = new Point(12, 41);
            buttonSearch_CMM.Name = "buttonSearch_CMM";
            buttonSearch_CMM.Size = new Size(121, 23);
            buttonSearch_CMM.TabIndex = 2;
            buttonSearch_CMM.Text = "Найти";
            buttonSearch_CMM.UseVisualStyleBackColor = true;
            buttonSearch_CMM.Click += buttonSearch_Click;
            // 
            // FormExtendedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 87);
            Controls.Add(buttonSearch_CMM);
            Controls.Add(panelInput_CMM);
            Controls.Add(comboBoxColumns_CMM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(446, 126);
            MinimizeBox = false;
            Name = "FormExtendedSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расширенный поиск";
            panelInput_CMM.ResumeLayout(false);
            panelInput_CMM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxColumns_CMM;
        private Panel panelInput_CMM;
        private Button buttonSearch_CMM;
        private Label labelFrom_CMM;
        private TextBox textBox1;
    }
}