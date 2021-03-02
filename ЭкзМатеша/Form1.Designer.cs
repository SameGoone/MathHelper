
namespace MathHelper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ClearRandomButton = new System.Windows.Forms.Button();
            this.GetMAndDButton = new System.Windows.Forms.Button();
            this.DResultBox = new System.Windows.Forms.TextBox();
            this.MResultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SampleExactleDispersionBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ClearSampleButton = new System.Windows.Forms.Button();
            this.SampleDispersionBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GetSampleResultButton = new System.Windows.Forms.Button();
            this.SampleMeanBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SampleGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ClearCombButton = new System.Windows.Forms.Button();
            this.GetCombResultButton = new System.Windows.Forms.Button();
            this.PCombOutputBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CCombOutputBox = new System.Windows.Forms.TextBox();
            this.ACombOutputBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mCombInputBox = new System.Windows.Forms.TextBox();
            this.nCombInputBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ClearRandomButton);
            this.tabPage1.Controls.Add(this.GetMAndDButton);
            this.tabPage1.Controls.Add(this.DResultBox);
            this.tabPage1.Controls.Add(this.MResultBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RandomGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(553, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Случайные величины";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ClearRandomButton
            // 
            this.ClearRandomButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ClearRandomButton.Location = new System.Drawing.Point(257, 294);
            this.ClearRandomButton.Name = "ClearRandomButton";
            this.ClearRandomButton.Size = new System.Drawing.Size(202, 35);
            this.ClearRandomButton.TabIndex = 6;
            this.ClearRandomButton.Text = "Очистить";
            this.ClearRandomButton.UseVisualStyleBackColor = false;
            this.ClearRandomButton.Click += new System.EventHandler(this.ClearRandomButton_Click);
            // 
            // GetMAndDButton
            // 
            this.GetMAndDButton.Location = new System.Drawing.Point(257, 83);
            this.GetMAndDButton.Name = "GetMAndDButton";
            this.GetMAndDButton.Size = new System.Drawing.Size(202, 34);
            this.GetMAndDButton.TabIndex = 5;
            this.GetMAndDButton.Text = "Посчитать";
            this.GetMAndDButton.UseVisualStyleBackColor = true;
            this.GetMAndDButton.Click += new System.EventHandler(this.GetMAndDButton_Click);
            // 
            // DResultBox
            // 
            this.DResultBox.Location = new System.Drawing.Point(314, 47);
            this.DResultBox.Name = "DResultBox";
            this.DResultBox.ReadOnly = true;
            this.DResultBox.Size = new System.Drawing.Size(146, 26);
            this.DResultBox.TabIndex = 4;
            // 
            // MResultBox
            // 
            this.MResultBox.Location = new System.Drawing.Point(313, 8);
            this.MResultBox.Name = "MResultBox";
            this.MResultBox.ReadOnly = true;
            this.MResultBox.Size = new System.Drawing.Size(146, 26);
            this.MResultBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "D[X] =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "M[X] =";
            // 
            // RandomGrid
            // 
            this.RandomGrid.AllowUserToResizeRows = false;
            this.RandomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.RandomGrid.Location = new System.Drawing.Point(7, 8);
            this.RandomGrid.Name = "RandomGrid";
            this.RandomGrid.RowHeadersVisible = false;
            this.RandomGrid.Size = new System.Drawing.Size(205, 321);
            this.RandomGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "P";
            this.Column2.Name = "Column2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SampleExactleDispersionBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ClearSampleButton);
            this.tabPage2.Controls.Add(this.SampleDispersionBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.GetSampleResultButton);
            this.tabPage2.Controls.Add(this.SampleMeanBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.SampleGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(553, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выборка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SampleExactleDispersionBox
            // 
            this.SampleExactleDispersionBox.Location = new System.Drawing.Point(257, 168);
            this.SampleExactleDispersionBox.Name = "SampleExactleDispersionBox";
            this.SampleExactleDispersionBox.ReadOnly = true;
            this.SampleExactleDispersionBox.Size = new System.Drawing.Size(146, 26);
            this.SampleExactleDispersionBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Выборочная дисперсия с поправкой:";
            // 
            // ClearSampleButton
            // 
            this.ClearSampleButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ClearSampleButton.Location = new System.Drawing.Point(257, 294);
            this.ClearSampleButton.Name = "ClearSampleButton";
            this.ClearSampleButton.Size = new System.Drawing.Size(202, 35);
            this.ClearSampleButton.TabIndex = 14;
            this.ClearSampleButton.Text = "Очистить";
            this.ClearSampleButton.UseVisualStyleBackColor = false;
            this.ClearSampleButton.Click += new System.EventHandler(this.ClearSampleButton_Click);
            // 
            // SampleDispersionBox
            // 
            this.SampleDispersionBox.Location = new System.Drawing.Point(257, 107);
            this.SampleDispersionBox.Name = "SampleDispersionBox";
            this.SampleDispersionBox.ReadOnly = true;
            this.SampleDispersionBox.Size = new System.Drawing.Size(146, 26);
            this.SampleDispersionBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Выборочная дисперсия:";
            // 
            // GetSampleResultButton
            // 
            this.GetSampleResultButton.Location = new System.Drawing.Point(257, 217);
            this.GetSampleResultButton.Name = "GetSampleResultButton";
            this.GetSampleResultButton.Size = new System.Drawing.Size(202, 34);
            this.GetSampleResultButton.TabIndex = 11;
            this.GetSampleResultButton.Text = "Посчитать";
            this.GetSampleResultButton.UseVisualStyleBackColor = true;
            this.GetSampleResultButton.Click += new System.EventHandler(this.GetSampleResultButton_Click);
            // 
            // SampleMeanBox
            // 
            this.SampleMeanBox.Location = new System.Drawing.Point(257, 39);
            this.SampleMeanBox.Name = "SampleMeanBox";
            this.SampleMeanBox.ReadOnly = true;
            this.SampleMeanBox.Size = new System.Drawing.Size(146, 26);
            this.SampleMeanBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выборочное среднее:";
            // 
            // SampleGrid
            // 
            this.SampleGrid.AllowUserToResizeRows = false;
            this.SampleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SampleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.SampleGrid.Location = new System.Drawing.Point(7, 8);
            this.SampleGrid.Name = "SampleGrid";
            this.SampleGrid.RowHeadersVisible = false;
            this.SampleGrid.Size = new System.Drawing.Size(205, 321);
            this.SampleGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "x";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "n";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ClearCombButton);
            this.tabPage3.Controls.Add(this.GetCombResultButton);
            this.tabPage3.Controls.Add(this.PCombOutputBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.CCombOutputBox);
            this.tabPage3.Controls.Add(this.ACombOutputBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.mCombInputBox);
            this.tabPage3.Controls.Add(this.nCombInputBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(553, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Комбинаторика";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ClearCombButton
            // 
            this.ClearCombButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ClearCombButton.Location = new System.Drawing.Point(332, 290);
            this.ClearCombButton.Name = "ClearCombButton";
            this.ClearCombButton.Size = new System.Drawing.Size(202, 33);
            this.ClearCombButton.TabIndex = 13;
            this.ClearCombButton.Text = "Очистить";
            this.ClearCombButton.UseVisualStyleBackColor = false;
            this.ClearCombButton.Click += new System.EventHandler(this.ClearCombButton_Click);
            // 
            // GetCombResultButton
            // 
            this.GetCombResultButton.Location = new System.Drawing.Point(41, 290);
            this.GetCombResultButton.Name = "GetCombResultButton";
            this.GetCombResultButton.Size = new System.Drawing.Size(190, 33);
            this.GetCombResultButton.TabIndex = 12;
            this.GetCombResultButton.Text = "Получить";
            this.GetCombResultButton.UseVisualStyleBackColor = true;
            this.GetCombResultButton.Click += new System.EventHandler(this.GetCombResultButton_Click);
            // 
            // PCombOutputBox
            // 
            this.PCombOutputBox.Location = new System.Drawing.Point(78, 190);
            this.PCombOutputBox.Name = "PCombOutputBox";
            this.PCombOutputBox.ReadOnly = true;
            this.PCombOutputBox.Size = new System.Drawing.Size(153, 26);
            this.PCombOutputBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "P =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Получи:";
            // 
            // CCombOutputBox
            // 
            this.CCombOutputBox.Location = new System.Drawing.Point(78, 223);
            this.CCombOutputBox.Name = "CCombOutputBox";
            this.CCombOutputBox.ReadOnly = true;
            this.CCombOutputBox.Size = new System.Drawing.Size(153, 26);
            this.CCombOutputBox.TabIndex = 8;
            // 
            // ACombOutputBox
            // 
            this.ACombOutputBox.Location = new System.Drawing.Point(78, 255);
            this.ACombOutputBox.Name = "ACombOutputBox";
            this.ACombOutputBox.ReadOnly = true;
            this.ACombOutputBox.Size = new System.Drawing.Size(153, 26);
            this.ACombOutputBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "C =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "A =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Введи:";
            // 
            // mCombInputBox
            // 
            this.mCombInputBox.Location = new System.Drawing.Point(78, 54);
            this.mCombInputBox.Name = "mCombInputBox";
            this.mCombInputBox.Size = new System.Drawing.Size(153, 26);
            this.mCombInputBox.TabIndex = 3;
            // 
            // nCombInputBox
            // 
            this.nCombInputBox.Location = new System.Drawing.Point(78, 87);
            this.nCombInputBox.Name = "nCombInputBox";
            this.nCombInputBox.Size = new System.Drawing.Size(153, 26);
            this.nCombInputBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "m = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "n = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 408);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox DResultBox;
        private System.Windows.Forms.TextBox MResultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RandomGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button GetMAndDButton;
        private System.Windows.Forms.Button GetSampleResultButton;
        private System.Windows.Forms.TextBox SampleMeanBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView SampleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PCombOutputBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CCombOutputBox;
        private System.Windows.Forms.TextBox ACombOutputBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mCombInputBox;
        private System.Windows.Forms.TextBox nCombInputBox;
        private System.Windows.Forms.Button GetCombResultButton;
        private System.Windows.Forms.TextBox SampleDispersionBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ClearRandomButton;
        private System.Windows.Forms.Button ClearSampleButton;
        private System.Windows.Forms.Button ClearCombButton;
        private System.Windows.Forms.TextBox SampleExactleDispersionBox;
        private System.Windows.Forms.Label label12;
    }
}

