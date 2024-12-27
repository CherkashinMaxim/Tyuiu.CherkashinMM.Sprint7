namespace Tyuiu.CherkashinMM.Sprint7.Project.V0
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip_CMM = new MenuStrip();
            fileToolStripMenuItem_CMM = new ToolStripMenuItem();
            newToolStripMenuItem_CMM = new ToolStripMenuItem();
            openToolStripMenuItem_CMM = new ToolStripMenuItem();
            toolStripSeparator_CMM = new ToolStripSeparator();
            saveToolStripMenuItem_CMM = new ToolStripMenuItem();
            saveAsToolStripMenuItem_CMM = new ToolStripMenuItem();
            toolStripSeparator1_CMM = new ToolStripSeparator();
            exitToolStripMenuItem_CMM = new ToolStripMenuItem();
            editToolStripMenuItem_CMM = new ToolStripMenuItem();
            toolStripMenuItemRefreshFile_CMM = new ToolStripMenuItem();
            toolStripMenuItemSortFile_CMM = new ToolStripMenuItem();
            toolStripMenuItemRefreshStats_CMM = new ToolStripMenuItem();
            toolStripSeparator15_CMM = new ToolStripSeparator();
            toolStripMenuItemDeleteSelected_CMM = new ToolStripMenuItem();
            toolStripMenuItemSelectAll_CMM = new ToolStripMenuItem();
            toolStripSeparator4_CMM = new ToolStripSeparator();
            toolStripMenuItemExtendedSearch_CMM = new ToolStripMenuItem();
            helpToolStripMenuItem_CMM = new ToolStripMenuItem();
            guideToolStripMenuItem_CMM = new ToolStripMenuItem();
            toolStripSeparator5_CMM = new ToolStripSeparator();
            aboutToolStripMenuItem_CMM = new ToolStripMenuItem();
            groupBoxSearch = new GroupBox();
            buttonSearch_CMM = new CircularButton();
            buttonSearchFilter_CMM = new CircularButton();
            textBoxSearch_CMM = new CustomTextBox();
            groupBoxTools_CMM = new GroupBox();
            buttonRefreshFile_CMM = new CircularButton();
            buttonRefreshStats_CMM = new CircularButton();
            buttonAddClient_CMM = new CircularButton();
            buttonSort_CMM = new CircularButton();
            buttonExtendedSearch_CMM = new CircularButton();
            panelSearchAndTools_CMM = new Panel();
            splitContainerGridAndContainer2_CMM = new SplitContainer();
            groupBoxDataGridView_CMM = new GroupBox();
            dataGridView_CMM = new DataGridView();
            splitContainerChartAndStats_CMM = new SplitContainer();
            groupBoxChart_CMM = new GroupBox();
            chartStats_CMM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxStatistics_CMM = new GroupBox();
            labelStats_CMM = new Label();
            toolTip_CMM = new ToolTip(components);
            openFileDialog_CMM = new OpenFileDialog();
            saveFileDialog_CMM = new SaveFileDialog();
            menuStrip_CMM.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxTools_CMM.SuspendLayout();
            panelSearchAndTools_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerGridAndContainer2_CMM).BeginInit();
            splitContainerGridAndContainer2_CMM.Panel1.SuspendLayout();
            splitContainerGridAndContainer2_CMM.Panel2.SuspendLayout();
            splitContainerGridAndContainer2_CMM.SuspendLayout();
            groupBoxDataGridView_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerChartAndStats_CMM).BeginInit();
            splitContainerChartAndStats_CMM.Panel1.SuspendLayout();
            splitContainerChartAndStats_CMM.Panel2.SuspendLayout();
            splitContainerChartAndStats_CMM.SuspendLayout();
            groupBoxChart_CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStats_CMM).BeginInit();
            groupBoxStatistics_CMM.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_CMM
            // 
            menuStrip_CMM.Font = new Font("Segoe UI", 12F);
            menuStrip_CMM.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem_CMM, editToolStripMenuItem_CMM, helpToolStripMenuItem_CMM });
            menuStrip_CMM.Location = new Point(0, 0);
            menuStrip_CMM.Name = "menuStrip_CMM";
            menuStrip_CMM.Size = new Size(1264, 29);
            menuStrip_CMM.TabIndex = 0;
            menuStrip_CMM.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem_CMM
            // 
            fileToolStripMenuItem_CMM.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem_CMM, openToolStripMenuItem_CMM, toolStripSeparator_CMM, saveToolStripMenuItem_CMM, saveAsToolStripMenuItem_CMM, toolStripSeparator1_CMM, exitToolStripMenuItem_CMM });
            fileToolStripMenuItem_CMM.Name = "fileToolStripMenuItem_CMM";
            fileToolStripMenuItem_CMM.Size = new Size(59, 25);
            fileToolStripMenuItem_CMM.Text = "&Файл";
            // 
            // newToolStripMenuItem_CMM
            // 
            newToolStripMenuItem_CMM.Image = Properties.Resources.Document_16x;
            newToolStripMenuItem_CMM.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem_CMM.Name = "newToolStripMenuItem_CMM";
            newToolStripMenuItem_CMM.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem_CMM.Size = new Size(282, 26);
            newToolStripMenuItem_CMM.Text = "&Новый файл";
            newToolStripMenuItem_CMM.Click += newToolStripMenuItem_CMM_Click;
            // 
            // openToolStripMenuItem_CMM
            // 
            openToolStripMenuItem_CMM.Image = Properties.Resources.OpenFolder_16x;
            openToolStripMenuItem_CMM.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem_CMM.Name = "openToolStripMenuItem_CMM";
            openToolStripMenuItem_CMM.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem_CMM.Size = new Size(282, 26);
            openToolStripMenuItem_CMM.Text = "&Открыть";
            openToolStripMenuItem_CMM.Click += openToolStripMenuItem_CMM_Click;
            // 
            // toolStripSeparator_CMM
            // 
            toolStripSeparator_CMM.Name = "toolStripSeparator_CMM";
            toolStripSeparator_CMM.Size = new Size(279, 6);
            // 
            // saveToolStripMenuItem_CMM
            // 
            saveToolStripMenuItem_CMM.Image = (Image)resources.GetObject("saveToolStripMenuItem_CMM.Image");
            saveToolStripMenuItem_CMM.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem_CMM.Name = "saveToolStripMenuItem_CMM";
            saveToolStripMenuItem_CMM.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem_CMM.Size = new Size(282, 26);
            saveToolStripMenuItem_CMM.Text = "&Сохранить";
            saveToolStripMenuItem_CMM.Click += saveToolStripMenuItem_CMM_Click;
            // 
            // saveAsToolStripMenuItem_CMM
            // 
            saveAsToolStripMenuItem_CMM.Name = "saveAsToolStripMenuItem_CMM";
            saveAsToolStripMenuItem_CMM.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem_CMM.Size = new Size(282, 26);
            saveAsToolStripMenuItem_CMM.Text = "Сохранить &как";
            saveAsToolStripMenuItem_CMM.Click += saveAsToolStripMenuItem_CMM_Click;
            // 
            // toolStripSeparator1_CMM
            // 
            toolStripSeparator1_CMM.Name = "toolStripSeparator1_CMM";
            toolStripSeparator1_CMM.Size = new Size(279, 6);
            // 
            // exitToolStripMenuItem_CMM
            // 
            exitToolStripMenuItem_CMM.Image = Properties.Resources.Output_16x;
            exitToolStripMenuItem_CMM.Name = "exitToolStripMenuItem_CMM";
            exitToolStripMenuItem_CMM.Size = new Size(282, 26);
            exitToolStripMenuItem_CMM.Text = "В&ыход";
            exitToolStripMenuItem_CMM.Click += exitToolStripMenuItem_CMM_Click;
            // 
            // editToolStripMenuItem_CMM
            // 
            editToolStripMenuItem_CMM.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemRefreshFile_CMM, toolStripMenuItemSortFile_CMM, toolStripMenuItemRefreshStats_CMM, toolStripSeparator15_CMM, toolStripMenuItemDeleteSelected_CMM, toolStripMenuItemSelectAll_CMM, toolStripSeparator4_CMM, toolStripMenuItemExtendedSearch_CMM });
            editToolStripMenuItem_CMM.Name = "editToolStripMenuItem_CMM";
            editToolStripMenuItem_CMM.Size = new Size(129, 25);
            editToolStripMenuItem_CMM.Text = "&Редактировать";
            // 
            // toolStripMenuItemRefreshFile_CMM
            // 
            toolStripMenuItemRefreshFile_CMM.Image = Properties.Resources.RefreshScript_grey_16x;
            toolStripMenuItemRefreshFile_CMM.Name = "toolStripMenuItemRefreshFile_CMM";
            toolStripMenuItemRefreshFile_CMM.ShortcutKeyDisplayString = "";
            toolStripMenuItemRefreshFile_CMM.ShortcutKeys = Keys.F4;
            toolStripMenuItemRefreshFile_CMM.Size = new Size(281, 26);
            toolStripMenuItemRefreshFile_CMM.Text = "&Сбросить файл";
            toolStripMenuItemRefreshFile_CMM.Click += buttonRefreshFile_CMM_Click_1;
            // 
            // toolStripMenuItemSortFile_CMM
            // 
            toolStripMenuItemSortFile_CMM.Image = Properties.Resources.Sort_16x;
            toolStripMenuItemSortFile_CMM.Name = "toolStripMenuItemSortFile_CMM";
            toolStripMenuItemSortFile_CMM.Size = new Size(281, 26);
            toolStripMenuItemSortFile_CMM.Text = "&Сортировка";
            toolStripMenuItemSortFile_CMM.Click += buttonSort_CMM_Click;
            // 
            // toolStripMenuItemRefreshStats_CMM
            // 
            toolStripMenuItemRefreshStats_CMM.Image = Properties.Resources.ResetTimelineView_16x;
            toolStripMenuItemRefreshStats_CMM.Name = "toolStripMenuItemRefreshStats_CMM";
            toolStripMenuItemRefreshStats_CMM.ShortcutKeys = Keys.F5;
            toolStripMenuItemRefreshStats_CMM.Size = new Size(281, 26);
            toolStripMenuItemRefreshStats_CMM.Text = "&Обновить статистику";
            toolStripMenuItemRefreshStats_CMM.Click += buttonRefreshStats_CMM_Click;
            // 
            // toolStripSeparator15_CMM
            // 
            toolStripSeparator15_CMM.Name = "toolStripSeparator15_CMM";
            toolStripSeparator15_CMM.Size = new Size(278, 6);
            // 
            // toolStripMenuItemDeleteSelected_CMM
            // 
            toolStripMenuItemDeleteSelected_CMM.Name = "toolStripMenuItemDeleteSelected_CMM";
            toolStripMenuItemDeleteSelected_CMM.ShortcutKeys = Keys.Delete;
            toolStripMenuItemDeleteSelected_CMM.Size = new Size(281, 26);
            toolStripMenuItemDeleteSelected_CMM.Text = "Удалить в&ыделенное";
            toolStripMenuItemDeleteSelected_CMM.Click += toolStripMenuItemDeleteSelected_CMM_Click;
            // 
            // toolStripMenuItemSelectAll_CMM
            // 
            toolStripMenuItemSelectAll_CMM.Name = "toolStripMenuItemSelectAll_CMM";
            toolStripMenuItemSelectAll_CMM.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            toolStripMenuItemSelectAll_CMM.Size = new Size(281, 26);
            toolStripMenuItemSelectAll_CMM.Text = "Выделить в&сё";
            toolStripMenuItemSelectAll_CMM.Click += toolStripMenuItemSelectAll_Click;
            // 
            // toolStripSeparator4_CMM
            // 
            toolStripSeparator4_CMM.Name = "toolStripSeparator4_CMM";
            toolStripSeparator4_CMM.Size = new Size(278, 6);
            // 
            // toolStripMenuItemExtendedSearch_CMM
            // 
            toolStripMenuItemExtendedSearch_CMM.Image = Properties.Resources.ExtendedSearch_16x;
            toolStripMenuItemExtendedSearch_CMM.Name = "toolStripMenuItemExtendedSearch_CMM";
            toolStripMenuItemExtendedSearch_CMM.ShortcutKeys = Keys.Control | Keys.F;
            toolStripMenuItemExtendedSearch_CMM.Size = new Size(281, 26);
            toolStripMenuItemExtendedSearch_CMM.Text = "&Расширенный поиск";
            toolStripMenuItemExtendedSearch_CMM.Click += buttonExtendedSearch_CMM_Click;
            // 
            // helpToolStripMenuItem_CMM
            // 
            helpToolStripMenuItem_CMM.DropDownItems.AddRange(new ToolStripItem[] { guideToolStripMenuItem_CMM, toolStripSeparator5_CMM, aboutToolStripMenuItem_CMM });
            helpToolStripMenuItem_CMM.Name = "helpToolStripMenuItem_CMM";
            helpToolStripMenuItem_CMM.Size = new Size(83, 25);
            helpToolStripMenuItem_CMM.Text = "&Помощь";
            // 
            // guideToolStripMenuItem_CMM
            // 
            guideToolStripMenuItem_CMM.Name = "guideToolStripMenuItem_CMM";
            guideToolStripMenuItem_CMM.Size = new Size(272, 26);
            guideToolStripMenuItem_CMM.Text = "&Руководство пользователя";
            guideToolStripMenuItem_CMM.Click += guideToolStripMenuItem_CMM_Click;
            // 
            // toolStripSeparator5_CMM
            // 
            toolStripSeparator5_CMM.Name = "toolStripSeparator5_CMM";
            toolStripSeparator5_CMM.Size = new Size(269, 6);
            // 
            // aboutToolStripMenuItem_CMM
            // 
            aboutToolStripMenuItem_CMM.Image = Properties.Resources.InformationSymbol_16x;
            aboutToolStripMenuItem_CMM.Name = "aboutToolStripMenuItem_CMM";
            aboutToolStripMenuItem_CMM.Size = new Size(272, 26);
            aboutToolStripMenuItem_CMM.Text = "&О программе...";
            aboutToolStripMenuItem_CMM.Click += aboutToolStripMenuItem_CMM_Click;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(buttonSearch_CMM);
            groupBoxSearch.Controls.Add(buttonSearchFilter_CMM);
            groupBoxSearch.Controls.Add(textBoxSearch_CMM);
            groupBoxSearch.Dock = DockStyle.Fill;
            groupBoxSearch.Location = new Point(0, 0);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(1264, 105);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Поиск по ключевым словам";
            // 
            // buttonSearch_CMM
            // 
            buttonSearch_CMM.Anchor = AnchorStyles.Right;
            buttonSearch_CMM.BackColor = Color.White;
            buttonSearch_CMM.FlatAppearance.BorderSize = 0;
            buttonSearch_CMM.FlatStyle = FlatStyle.Flat;
            buttonSearch_CMM.Image = Properties.Resources.Search_16x;
            buttonSearch_CMM.Location = new Point(806, 30);
            buttonSearch_CMM.Name = "buttonSearch_CMM";
            buttonSearch_CMM.Size = new Size(56, 56);
            buttonSearch_CMM.TabIndex = 1;
            buttonSearch_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonSearch_CMM, "ПоискСортирует и выделяет строки, в которых найдено ключевые слова");
            buttonSearch_CMM.UseVisualStyleBackColor = false;
            buttonSearch_CMM.Click += buttonSearch_CMM_Click;
            // 
            // buttonSearchFilter_CMM
            // 
            buttonSearchFilter_CMM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSearchFilter_CMM.BackColor = Color.White;
            buttonSearchFilter_CMM.FlatAppearance.BorderSize = 0;
            buttonSearchFilter_CMM.FlatStyle = FlatStyle.Flat;
            buttonSearchFilter_CMM.Image = Properties.Resources.Filter_16x;
            buttonSearchFilter_CMM.Location = new Point(868, 30);
            buttonSearchFilter_CMM.Name = "buttonSearchFilter_CMM";
            buttonSearchFilter_CMM.Size = new Size(56, 56);
            buttonSearchFilter_CMM.TabIndex = 1;
            buttonSearchFilter_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonSearchFilter_CMM, "Фильтр\r\nОставить только те строки, в которых были найдены ключевые слова");
            buttonSearchFilter_CMM.UseVisualStyleBackColor = false;
            buttonSearchFilter_CMM.Click += buttonSearchFilter_CMM_Click;
            // 
            // textBoxSearch_CMM
            // 
            textBoxSearch_CMM.BackColor = SystemColors.Control;
            textBoxSearch_CMM.Font = new Font("Segoe UI", 12F);
            textBoxSearch_CMM.Location = new Point(12, 30);
            textBoxSearch_CMM.Name = "textBoxSearch_CMM";
            textBoxSearch_CMM.Padding = new Padding(10, 5, 10, 5);
            textBoxSearch_CMM.Size = new Size(788, 56);
            textBoxSearch_CMM.TabIndex = 0;
            // 
            // groupBoxTools_CMM
            // 
            groupBoxTools_CMM.Controls.Add(buttonRefreshFile_CMM);
            groupBoxTools_CMM.Controls.Add(buttonRefreshStats_CMM);
            groupBoxTools_CMM.Controls.Add(buttonAddClient_CMM);
            groupBoxTools_CMM.Controls.Add(buttonSort_CMM);
            groupBoxTools_CMM.Controls.Add(buttonExtendedSearch_CMM);
            groupBoxTools_CMM.Dock = DockStyle.Right;
            groupBoxTools_CMM.Location = new Point(930, 0);
            groupBoxTools_CMM.Name = "groupBoxTools_CMM";
            groupBoxTools_CMM.Size = new Size(334, 105);
            groupBoxTools_CMM.TabIndex = 1;
            groupBoxTools_CMM.TabStop = false;
            groupBoxTools_CMM.Text = "Инструменты";
            // 
            // buttonRefreshFile_CMM
            // 
            buttonRefreshFile_CMM.Anchor = AnchorStyles.Right;
            buttonRefreshFile_CMM.BackColor = Color.White;
            buttonRefreshFile_CMM.BackgroundImageLayout = ImageLayout.Center;
            buttonRefreshFile_CMM.FlatAppearance.BorderSize = 0;
            buttonRefreshFile_CMM.FlatStyle = FlatStyle.Flat;
            buttonRefreshFile_CMM.Image = Properties.Resources.Sort_16x;
            buttonRefreshFile_CMM.Location = new Point(254, 30);
            buttonRefreshFile_CMM.Name = "buttonRefreshFile_CMM";
            buttonRefreshFile_CMM.Size = new Size(56, 56);
            buttonRefreshFile_CMM.TabIndex = 1;
            buttonRefreshFile_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonRefreshFile_CMM, "Сбросить файл\r\nПерезагрузить файл");
            buttonRefreshFile_CMM.UseVisualStyleBackColor = false;
            buttonRefreshFile_CMM.Click += buttonRefreshFile_CMM_Click_1;
            // 
            // buttonRefreshStats_CMM
            // 
            buttonRefreshStats_CMM.Anchor = AnchorStyles.Right;
            buttonRefreshStats_CMM.BackColor = Color.White;
            buttonRefreshStats_CMM.BackgroundImageLayout = ImageLayout.Center;
            buttonRefreshStats_CMM.FlatAppearance.BorderSize = 0;
            buttonRefreshStats_CMM.FlatStyle = FlatStyle.Flat;
            buttonRefreshStats_CMM.Image = Properties.Resources.Sort_16x;
            buttonRefreshStats_CMM.Location = new Point(192, 30);
            buttonRefreshStats_CMM.Name = "buttonRefreshStats_CMM";
            buttonRefreshStats_CMM.Size = new Size(56, 56);
            buttonRefreshStats_CMM.TabIndex = 1;
            buttonRefreshStats_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonRefreshStats_CMM, "Обновить статистику\r\nОбновить график и статистику на основе обновленной таблицы");
            buttonRefreshStats_CMM.UseVisualStyleBackColor = false;
            buttonRefreshStats_CMM.Click += buttonRefreshStats_CMM_Click;
            // 
            // buttonAddClient_CMM
            // 
            buttonAddClient_CMM.Anchor = AnchorStyles.Right;
            buttonAddClient_CMM.BackColor = Color.White;
            buttonAddClient_CMM.BackgroundImageLayout = ImageLayout.Center;
            buttonAddClient_CMM.FlatAppearance.BorderSize = 0;
            buttonAddClient_CMM.FlatStyle = FlatStyle.Flat;
            buttonAddClient_CMM.Image = Properties.Resources.Sort_16x;
            buttonAddClient_CMM.Location = new Point(130, 30);
            buttonAddClient_CMM.Name = "buttonAddClient_CMM";
            buttonAddClient_CMM.Size = new Size(56, 56);
            buttonAddClient_CMM.TabIndex = 1;
            buttonAddClient_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonAddClient_CMM, "Добавить клиента\r\nДобавить новую строку для клиента");
            buttonAddClient_CMM.UseVisualStyleBackColor = false;
            buttonAddClient_CMM.Click += buttonAddClient_CMM_Click;
            // 
            // buttonSort_CMM
            // 
            buttonSort_CMM.Anchor = AnchorStyles.Right;
            buttonSort_CMM.BackColor = Color.White;
            buttonSort_CMM.BackgroundImageLayout = ImageLayout.Center;
            buttonSort_CMM.FlatAppearance.BorderSize = 0;
            buttonSort_CMM.FlatStyle = FlatStyle.Flat;
            buttonSort_CMM.Image = Properties.Resources.Sort_16x;
            buttonSort_CMM.Location = new Point(68, 30);
            buttonSort_CMM.Name = "buttonSort_CMM";
            buttonSort_CMM.Size = new Size(56, 56);
            buttonSort_CMM.TabIndex = 1;
            buttonSort_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonSort_CMM, "Сортировка\r\nОтсортировать таблицу по столбцу");
            buttonSort_CMM.UseVisualStyleBackColor = false;
            buttonSort_CMM.Click += buttonSort_CMM_Click;
            // 
            // buttonExtendedSearch_CMM
            // 
            buttonExtendedSearch_CMM.Anchor = AnchorStyles.Right;
            buttonExtendedSearch_CMM.BackColor = Color.White;
            buttonExtendedSearch_CMM.FlatAppearance.BorderSize = 0;
            buttonExtendedSearch_CMM.FlatStyle = FlatStyle.Flat;
            buttonExtendedSearch_CMM.Image = Properties.Resources.ExtendedSearch_16x1;
            buttonExtendedSearch_CMM.Location = new Point(6, 30);
            buttonExtendedSearch_CMM.Name = "buttonExtendedSearch_CMM";
            buttonExtendedSearch_CMM.Size = new Size(56, 56);
            buttonExtendedSearch_CMM.TabIndex = 1;
            buttonExtendedSearch_CMM.TabStop = false;
            toolTip_CMM.SetToolTip(buttonExtendedSearch_CMM, "Расширенный поиск\r\nПоиск по определённому значению в конкретном столбце");
            buttonExtendedSearch_CMM.UseVisualStyleBackColor = false;
            buttonExtendedSearch_CMM.Click += buttonExtendedSearch_CMM_Click;
            // 
            // panelSearchAndTools_CMM
            // 
            panelSearchAndTools_CMM.Controls.Add(groupBoxTools_CMM);
            panelSearchAndTools_CMM.Controls.Add(groupBoxSearch);
            panelSearchAndTools_CMM.Dock = DockStyle.Top;
            panelSearchAndTools_CMM.Location = new Point(0, 29);
            panelSearchAndTools_CMM.Name = "panelSearchAndTools_CMM";
            panelSearchAndTools_CMM.Size = new Size(1264, 105);
            panelSearchAndTools_CMM.TabIndex = 3;
            // 
            // splitContainerGridAndContainer2_CMM
            // 
            splitContainerGridAndContainer2_CMM.Dock = DockStyle.Fill;
            splitContainerGridAndContainer2_CMM.Location = new Point(0, 134);
            splitContainerGridAndContainer2_CMM.Name = "splitContainerGridAndContainer2_CMM";
            // 
            // splitContainerGridAndContainer2_CMM.Panel1
            // 
            splitContainerGridAndContainer2_CMM.Panel1.Controls.Add(groupBoxDataGridView_CMM);
            splitContainerGridAndContainer2_CMM.Panel1.Enabled = false;
            // 
            // splitContainerGridAndContainer2_CMM.Panel2
            // 
            splitContainerGridAndContainer2_CMM.Panel2.Controls.Add(splitContainerChartAndStats_CMM);
            splitContainerGridAndContainer2_CMM.Panel2MinSize = 400;
            splitContainerGridAndContainer2_CMM.Size = new Size(1264, 547);
            splitContainerGridAndContainer2_CMM.SplitterDistance = 649;
            splitContainerGridAndContainer2_CMM.TabIndex = 4;
            // 
            // groupBoxDataGridView_CMM
            // 
            groupBoxDataGridView_CMM.Controls.Add(dataGridView_CMM);
            groupBoxDataGridView_CMM.Dock = DockStyle.Fill;
            groupBoxDataGridView_CMM.Location = new Point(0, 0);
            groupBoxDataGridView_CMM.Name = "groupBoxDataGridView_CMM";
            groupBoxDataGridView_CMM.Size = new Size(649, 547);
            groupBoxDataGridView_CMM.TabIndex = 0;
            groupBoxDataGridView_CMM.TabStop = false;
            groupBoxDataGridView_CMM.Text = "Таблица";
            // 
            // dataGridView_CMM
            // 
            dataGridView_CMM.AllowUserToAddRows = false;
            dataGridView_CMM.AllowUserToDeleteRows = false;
            dataGridView_CMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CMM.Dock = DockStyle.Fill;
            dataGridView_CMM.Location = new Point(3, 19);
            dataGridView_CMM.Name = "dataGridView_CMM";
            dataGridView_CMM.RowHeadersVisible = false;
            dataGridView_CMM.Size = new Size(643, 525);
            dataGridView_CMM.TabIndex = 0;
            dataGridView_CMM.SortCompare += dataGridView_CMM_SortCompare;
            // 
            // splitContainerChartAndStats_CMM
            // 
            splitContainerChartAndStats_CMM.Dock = DockStyle.Fill;
            splitContainerChartAndStats_CMM.Location = new Point(0, 0);
            splitContainerChartAndStats_CMM.Name = "splitContainerChartAndStats_CMM";
            // 
            // splitContainerChartAndStats_CMM.Panel1
            // 
            splitContainerChartAndStats_CMM.Panel1.Controls.Add(groupBoxChart_CMM);
            // 
            // splitContainerChartAndStats_CMM.Panel2
            // 
            splitContainerChartAndStats_CMM.Panel2.Controls.Add(groupBoxStatistics_CMM);
            splitContainerChartAndStats_CMM.Panel2MinSize = 230;
            splitContainerChartAndStats_CMM.Size = new Size(611, 547);
            splitContainerChartAndStats_CMM.SplitterDistance = 377;
            splitContainerChartAndStats_CMM.TabIndex = 0;
            // 
            // groupBoxChart_CMM
            // 
            groupBoxChart_CMM.Controls.Add(chartStats_CMM);
            groupBoxChart_CMM.Dock = DockStyle.Fill;
            groupBoxChart_CMM.Location = new Point(0, 0);
            groupBoxChart_CMM.Name = "groupBoxChart_CMM";
            groupBoxChart_CMM.Size = new Size(377, 547);
            groupBoxChart_CMM.TabIndex = 0;
            groupBoxChart_CMM.TabStop = false;
            groupBoxChart_CMM.Text = "График";
            // 
            // chartStats_CMM
            // 
            chartArea1.Name = "ChartArea1";
            chartStats_CMM.ChartAreas.Add(chartArea1);
            chartStats_CMM.Dock = DockStyle.Fill;
            legend1.CustomItems.Add(legendItem1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartStats_CMM.Legends.Add(legend1);
            chartStats_CMM.Location = new Point(3, 19);
            chartStats_CMM.Name = "chartStats_CMM";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartStats_CMM.Series.Add(series1);
            chartStats_CMM.Size = new Size(371, 525);
            chartStats_CMM.TabIndex = 0;
            chartStats_CMM.Text = "chart1";
            // 
            // groupBoxStatistics_CMM
            // 
            groupBoxStatistics_CMM.Controls.Add(labelStats_CMM);
            groupBoxStatistics_CMM.Dock = DockStyle.Fill;
            groupBoxStatistics_CMM.Location = new Point(0, 0);
            groupBoxStatistics_CMM.Name = "groupBoxStatistics_CMM";
            groupBoxStatistics_CMM.Size = new Size(230, 547);
            groupBoxStatistics_CMM.TabIndex = 0;
            groupBoxStatistics_CMM.TabStop = false;
            groupBoxStatistics_CMM.Text = "Статистика";
            // 
            // labelStats_CMM
            // 
            labelStats_CMM.Dock = DockStyle.Fill;
            labelStats_CMM.Location = new Point(3, 19);
            labelStats_CMM.Name = "labelStats_CMM";
            labelStats_CMM.Size = new Size(224, 525);
            labelStats_CMM.TabIndex = 0;
            labelStats_CMM.Text = "label1";
            // 
            // toolTip_CMM
            // 
            toolTip_CMM.ToolTipIcon = ToolTipIcon.Info;
            toolTip_CMM.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_CMM
            // 
            openFileDialog_CMM.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1264, 681);
            Controls.Add(splitContainerGridAndContainer2_CMM);
            Controls.Add(panelSearchAndTools_CMM);
            Controls.Add(menuStrip_CMM);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "FormMain";
            Text = "Заказы";
            FormClosing += FormMain_FormClosing;
            menuStrip_CMM.ResumeLayout(false);
            menuStrip_CMM.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxTools_CMM.ResumeLayout(false);
            panelSearchAndTools_CMM.ResumeLayout(false);
            splitContainerGridAndContainer2_CMM.Panel1.ResumeLayout(false);
            splitContainerGridAndContainer2_CMM.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerGridAndContainer2_CMM).EndInit();
            splitContainerGridAndContainer2_CMM.ResumeLayout(false);
            groupBoxDataGridView_CMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_CMM).EndInit();
            splitContainerChartAndStats_CMM.Panel1.ResumeLayout(false);
            splitContainerChartAndStats_CMM.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerChartAndStats_CMM).EndInit();
            splitContainerChartAndStats_CMM.ResumeLayout(false);
            groupBoxChart_CMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStats_CMM).EndInit();
            groupBoxStatistics_CMM.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_CMM;
        private ToolStripMenuItem fileToolStripMenuItem_CMM;
        private ToolStripMenuItem newToolStripMenuItem_CMM;
        private ToolStripMenuItem openToolStripMenuItem_CMM;
        private ToolStripSeparator toolStripSeparator_CMM;
        private ToolStripMenuItem saveToolStripMenuItem_CMM;
        private ToolStripMenuItem saveAsToolStripMenuItem_CMM;
        private ToolStripSeparator toolStripSeparator1_CMM;
        private ToolStripMenuItem exitToolStripMenuItem_CMM;
        private ToolStripMenuItem editToolStripMenuItem_CMM;
        private ToolStripSeparator toolStripSeparator4_CMM;
        private ToolStripMenuItem helpToolStripMenuItem_CMM;
        private ToolStripSeparator toolStripSeparator5_CMM;
        private ToolStripMenuItem aboutToolStripMenuItem_CMM;
        private GroupBox groupBoxSearch;
        private GroupBox groupBoxTools_CMM;
        private Panel panelSearchAndTools_CMM;
        private SplitContainer splitContainerGridAndContainer2_CMM;
        private SplitContainer splitContainerChartAndStats_CMM;
        private GroupBox groupBoxDataGridView_CMM;
        private GroupBox groupBoxChart_CMM;
        private GroupBox groupBoxStatistics_CMM;
        private DataGridView dataGridView_CMM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_CMM;
        private ToolStripMenuItem guideToolStripMenuItem_CMM;
        private CustomTextBox textBoxSearch_CMM;
        private CircularButton buttonSearch_CMM;
        private CircularButton buttonSearchFilter_CMM;
        private CircularButton buttonExtendedSearch_CMM;
        private CircularButton buttonSort_CMM;
        private CircularButton buttonAddClient_CMM;
        private CircularButton buttonRefreshStats_CMM;
        private ToolTip toolTip_CMM;
        private Label labelStats_CMM;
        private OpenFileDialog openFileDialog_CMM;
        private SaveFileDialog saveFileDialog_CMM;
        private CircularButton buttonRefreshFile_CMM;
        private ToolStripMenuItem toolStripMenuItemRefreshFile_CMM;
        private ToolStripMenuItem toolStripMenuItemRefreshStats_CMM;
        private ToolStripMenuItem toolStripMenuItemExtendedSearch_CMM;
        private ToolStripMenuItem toolStripMenuItemSortFile_CMM;
        private ToolStripMenuItem toolStripMenuItemDeleteSelected_CMM;
        private ToolStripSeparator toolStripSeparator15_CMM;
        private ToolStripMenuItem toolStripMenuItemSelectAll_CMM;
    }
}
