namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_CMM = new Button();
            labelInfo_CMM = new Label();
            pictureBoxPhoto_CMM = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_CMM).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_CMM
            // 
            buttonOK_CMM.Location = new Point(516, 249);
            buttonOK_CMM.Name = "buttonOK_CMM";
            buttonOK_CMM.Size = new Size(97, 34);
            buttonOK_CMM.TabIndex = 5;
            buttonOK_CMM.Text = "OK";
            buttonOK_CMM.UseVisualStyleBackColor = true;
            buttonOK_CMM.Click += buttonOK_CMM_Click;
            // 
            // labelInfo_CMM
            // 
            labelInfo_CMM.AutoSize = true;
            labelInfo_CMM.Font = new Font("Segoe UI", 12F);
            labelInfo_CMM.Location = new Point(216, 26);
            labelInfo_CMM.Name = "labelInfo_CMM";
            labelInfo_CMM.Size = new Size(406, 189);
            labelInfo_CMM.TabIndex = 4;
            labelInfo_CMM.Text = resources.GetString("labelInfo_CMM.Text");
            labelInfo_CMM.Click += labelInfo_CMM_Click;
            // 
            // pictureBoxPhoto_CMM
            // 
            pictureBoxPhoto_CMM.Image = Properties.Resources._1077596_200;
            pictureBoxPhoto_CMM.Location = new Point(12, 12);
            pictureBoxPhoto_CMM.Name = "pictureBoxPhoto_CMM";
            pictureBoxPhoto_CMM.Size = new Size(198, 271);
            pictureBoxPhoto_CMM.TabIndex = 3;
            pictureBoxPhoto_CMM.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 296);
            Controls.Add(buttonOK_CMM);
            Controls.Add(labelInfo_CMM);
            Controls.Add(pictureBoxPhoto_CMM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_CMM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_CMM;
        private Label labelInfo_CMM;
        private PictureBox pictureBoxPhoto_CMM;
    }
}