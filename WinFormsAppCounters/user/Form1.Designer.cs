namespace WinFormsAppCounters.user
{
    partial class Form1
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
            labelNumber = new Label();
            labelValue = new Label();
            labelColor = new Label();
            textBoxNumber = new TextBox();
            textBoxValue = new TextBox();
            comboBoxColor = new ComboBox();
            labelMonth = new Label();
            labelDay = new Label();
            labelYear = new Label();
            textBoxMonth = new TextBox();
            textBoxDay = new TextBox();
            textBoxYear = new TextBox();
            listBoxCounter = new ListBox();
            buttonAdd = new Button();
            buttonPrint = new Button();
            buttonSearch = new Button();
            buttonRemove = new Button();
            buttonExit = new Button();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(22, 33);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(74, 20);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "Number ?";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(22, 92);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(56, 20);
            labelValue.TabIndex = 1;
            labelValue.Text = "Value ?";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(22, 157);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(56, 20);
            labelColor.TabIndex = 2;
            labelColor.Text = "Color ?";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(102, 33);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 3;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(102, 89);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(125, 27);
            textBoxValue.TabIndex = 4;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(102, 154);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(151, 28);
            comboBoxColor.TabIndex = 5;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(517, 33);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(63, 20);
            labelMonth.TabIndex = 6;
            labelMonth.Text = "Month ?";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new Point(519, 72);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(46, 20);
            labelDay.TabIndex = 7;
            labelDay.Text = "Day ?";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(517, 116);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(48, 20);
            labelYear.TabIndex = 8;
            labelYear.Text = "Year ?";
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(603, 26);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(125, 27);
            textBoxMonth.TabIndex = 9;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(603, 69);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(125, 27);
            textBoxDay.TabIndex = 10;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(603, 109);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(125, 27);
            textBoxYear.TabIndex = 11;
            // 
            // listBoxCounter
            // 
            listBoxCounter.FormattingEnabled = true;
            listBoxCounter.Location = new Point(22, 223);
            listBoxCounter.Name = "listBoxCounter";
            listBoxCounter.Size = new Size(367, 264);
            listBoxCounter.TabIndex = 12;
            listBoxCounter.SelectedIndexChanged += listBoxCounter_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(419, 228);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add ?";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(419, 281);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(94, 29);
            buttonPrint.TabIndex = 14;
            buttonPrint.Text = "Print ?";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(419, 342);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search ?";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(544, 228);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 16;
            buttonRemove.Text = "Remove ?";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(962, 633);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 17;
            buttonExit.Text = "Exit ";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(544, 281);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 18;
            buttonUpdate.Text = "Update ?";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 709);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonExit);
            Controls.Add(buttonRemove);
            Controls.Add(buttonSearch);
            Controls.Add(buttonPrint);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxCounter);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxDay);
            Controls.Add(textBoxMonth);
            Controls.Add(labelYear);
            Controls.Add(labelDay);
            Controls.Add(labelMonth);
            Controls.Add(comboBoxColor);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxNumber);
            Controls.Add(labelColor);
            Controls.Add(labelValue);
            Controls.Add(labelNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumber;
        private Label labelValue;
        private Label labelColor;
        private TextBox textBoxNumber;
        private TextBox textBoxValue;
        private ComboBox comboBoxColor;
        private Label labelMonth;
        private Label labelDay;
        private Label labelYear;
        private TextBox textBoxMonth;
        private TextBox textBoxDay;
        private TextBox textBoxYear;
        private ListBox listBoxCounter;
        private Button buttonAdd;
        private Button buttonPrint;
        private Button buttonSearch;
        private Button buttonRemove;
        private Button buttonExit;
        private Button buttonUpdate;
    }
}