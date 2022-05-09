namespace lab8
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filterButton = new System.Windows.Forms.Button();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnWithoutFilters = new System.Windows.Forms.RadioButton();
            this.radioBtnSelective = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnDefault = new System.Windows.Forms.RadioButton();
            this.radioBtnLowerRegistr = new System.Windows.Forms.RadioButton();
            this.radioBtnUpperRegistr = new System.Windows.Forms.RadioButton();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.checkBoxPlusMinus = new System.Windows.Forms.CheckBox();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterButton);
            this.tabPage1.Controls.Add(this.letterTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.openFileDialogButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pathTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Начальная вкладка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(532, 270);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(140, 29);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "Отфильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(168, 88);
            this.letterTextBox.MaxLength = 1;
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(353, 27);
            this.letterTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Буква для фильтра";
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(520, 28);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(48, 29);
            this.openFileDialogButton.TabIndex = 2;
            this.openFileDialogButton.Text = "...";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(168, 29);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(353, 27);
            this.pathTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.checkBoxText);
            this.tabPage2.Controls.Add(this.checkBoxPlusMinus);
            this.tabPage2.Controls.Add(this.checkBoxNumbers);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильтры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnWithoutFilters);
            this.groupBox2.Controls.Add(this.radioBtnSelective);
            this.groupBox2.Location = new System.Drawing.Point(59, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 89);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // radioBtnWithoutFilters
            // 
            this.radioBtnWithoutFilters.AutoSize = true;
            this.radioBtnWithoutFilters.Location = new System.Drawing.Point(15, 26);
            this.radioBtnWithoutFilters.Name = "radioBtnWithoutFilters";
            this.radioBtnWithoutFilters.Size = new System.Drawing.Size(130, 24);
            this.radioBtnWithoutFilters.TabIndex = 4;
            this.radioBtnWithoutFilters.Text = "Считывать все";
            this.radioBtnWithoutFilters.UseVisualStyleBackColor = true;
            this.radioBtnWithoutFilters.CheckedChanged += new System.EventHandler(this.radioBtnWithoutFilters_CheckedChanged);
            // 
            // radioBtnSelective
            // 
            this.radioBtnSelective.AutoSize = true;
            this.radioBtnSelective.Location = new System.Drawing.Point(15, 56);
            this.radioBtnSelective.Name = "radioBtnSelective";
            this.radioBtnSelective.Size = new System.Drawing.Size(127, 24);
            this.radioBtnSelective.TabIndex = 5;
            this.radioBtnSelective.Text = "Выборочный ";
            this.radioBtnSelective.UseVisualStyleBackColor = true;
            this.radioBtnSelective.CheckedChanged += new System.EventHandler(this.radioBtnSelective_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnDefault);
            this.groupBox1.Controls.Add(this.radioBtnLowerRegistr);
            this.groupBox1.Controls.Add(this.radioBtnUpperRegistr);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(85, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 125);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительные фильтры для текста";
            // 
            // radioBtnDefault
            // 
            this.radioBtnDefault.AutoSize = true;
            this.radioBtnDefault.Checked = true;
            this.radioBtnDefault.Enabled = false;
            this.radioBtnDefault.Location = new System.Drawing.Point(6, 26);
            this.radioBtnDefault.Name = "radioBtnDefault";
            this.radioBtnDefault.Size = new System.Drawing.Size(137, 24);
            this.radioBtnDefault.TabIndex = 9;
            this.radioBtnDefault.TabStop = true;
            this.radioBtnDefault.Text = "Без изменений";
            this.radioBtnDefault.UseVisualStyleBackColor = true;
            // 
            // radioBtnLowerRegistr
            // 
            this.radioBtnLowerRegistr.AutoSize = true;
            this.radioBtnLowerRegistr.Enabled = false;
            this.radioBtnLowerRegistr.Location = new System.Drawing.Point(6, 86);
            this.radioBtnLowerRegistr.Name = "radioBtnLowerRegistr";
            this.radioBtnLowerRegistr.Size = new System.Drawing.Size(278, 24);
            this.radioBtnLowerRegistr.TabIndex = 11;
            this.radioBtnLowerRegistr.Text = "Преобразовать к строчным буквам";
            this.radioBtnLowerRegistr.UseVisualStyleBackColor = true;
            // 
            // radioBtnUpperRegistr
            // 
            this.radioBtnUpperRegistr.AutoSize = true;
            this.radioBtnUpperRegistr.Enabled = false;
            this.radioBtnUpperRegistr.Location = new System.Drawing.Point(6, 56);
            this.radioBtnUpperRegistr.Name = "radioBtnUpperRegistr";
            this.radioBtnUpperRegistr.Size = new System.Drawing.Size(291, 24);
            this.radioBtnUpperRegistr.TabIndex = 10;
            this.radioBtnUpperRegistr.Text = "Преобразовать к прописным буквам";
            this.radioBtnUpperRegistr.UseVisualStyleBackColor = true;
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Enabled = false;
            this.checkBoxText.Location = new System.Drawing.Point(59, 179);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(491, 24);
            this.checkBoxText.TabIndex = 8;
            this.checkBoxText.Text = "Считывать только текст, содержащий букву на начальной вкладке";
            this.checkBoxText.UseVisualStyleBackColor = true;
            this.checkBoxText.CheckStateChanged += new System.EventHandler(this.checkBoxText_CheckStateChanged);
            // 
            // checkBoxPlusMinus
            // 
            this.checkBoxPlusMinus.AutoSize = true;
            this.checkBoxPlusMinus.Enabled = false;
            this.checkBoxPlusMinus.Location = new System.Drawing.Point(59, 149);
            this.checkBoxPlusMinus.Name = "checkBoxPlusMinus";
            this.checkBoxPlusMinus.Size = new System.Drawing.Size(205, 24);
            this.checkBoxPlusMinus.TabIndex = 7;
            this.checkBoxPlusMinus.Text = "Считывать только \"+\"/\"-\"";
            this.checkBoxPlusMinus.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Enabled = false;
            this.checkBoxNumbers.Location = new System.Drawing.Point(59, 119);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(199, 24);
            this.checkBoxNumbers.TabIndex = 6;
            this.checkBoxNumbers.Text = "Считывать только числа";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox letterTextBox;
        private Label label2;
        private Button openFileDialogButton;
        private Label label1;
        private TextBox pathTextBox;
        private TabPage tabPage2;
        private OpenFileDialog openFileDialog1;
        private Button filterButton;
        private RadioButton radioBtnLowerRegistr;
        private RadioButton radioBtnUpperRegistr;
        private RadioButton radioBtnDefault;
        private CheckBox checkBoxText;
        private CheckBox checkBoxPlusMinus;
        private CheckBox checkBoxNumbers;
        private RadioButton radioBtnSelective;
        private RadioButton radioBtnWithoutFilters;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}