
using MetroFramework.Controls;

namespace IdanLalezari326643269.FORMS
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.AddRecord_BTN = new System.Windows.Forms.Button();
            //this.AddRecord_BTN = new MetroButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.First_BTN = new System.Windows.Forms.Button();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Next_BTN = new System.Windows.Forms.Button();
            this.Last_BTN = new System.Windows.Forms.Button();
            this.Update_BTN = new System.Windows.Forms.Button();
            this.Clear_BTN = new System.Windows.Forms.Button();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRecord_BTN
            // 
            this.AddRecord_BTN.Location = new System.Drawing.Point(176, 9);
            this.AddRecord_BTN.Name = "AddRecord_BTN";
            this.AddRecord_BTN.Size = new System.Drawing.Size(62, 53);
            this.AddRecord_BTN.TabIndex = 40;
            this.AddRecord_BTN.Text = "Add";
            this.AddRecord_BTN.UseVisualStyleBackColor = true;
            this.AddRecord_BTN.Click += new System.EventHandler(this.AddRecord_BTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(135, 357);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(765, 219);
            this.dataGridView.TabIndex = 38;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.Location = new System.Drawing.Point(847, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(53, 25);
            this.Title.TabIndex = 21;
            this.Title.Text = "Title";
            // 
            // First_BTN
            // 
            this.First_BTN.BackColor = System.Drawing.Color.Transparent;
            this.First_BTN.Image = ((System.Drawing.Image)(resources.GetObject("First_BTN.Image")));
            this.First_BTN.Location = new System.Drawing.Point(12, 7);
            this.First_BTN.Name = "First_BTN";
            this.First_BTN.Size = new System.Drawing.Size(35, 35);
            this.First_BTN.TabIndex = 41;
            this.First_BTN.UseVisualStyleBackColor = false;
            this.First_BTN.Click += new System.EventHandler(this.First_BTN_Click);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Back_BTN.Image")));
            this.Back_BTN.Location = new System.Drawing.Point(53, 7);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(35, 35);
            this.Back_BTN.TabIndex = 42;
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Next_BTN
            // 
            this.Next_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Next_BTN.Image")));
            this.Next_BTN.Location = new System.Drawing.Point(94, 7);
            this.Next_BTN.Name = "Next_BTN";
            this.Next_BTN.Size = new System.Drawing.Size(35, 35);
            this.Next_BTN.TabIndex = 43;
            this.Next_BTN.UseVisualStyleBackColor = true;
            this.Next_BTN.Click += new System.EventHandler(this.Next_BTN_Click);
            // 
            // Last_BTN
            // 
            this.Last_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Last_BTN.Image")));
            this.Last_BTN.Location = new System.Drawing.Point(135, 7);
            this.Last_BTN.Name = "Last_BTN";
            this.Last_BTN.Size = new System.Drawing.Size(35, 35);
            this.Last_BTN.TabIndex = 44;
            this.Last_BTN.UseVisualStyleBackColor = true;
            this.Last_BTN.Click += new System.EventHandler(this.Last_BTN_Click);
            // 
            // Update_BTN
            // 
            this.Update_BTN.Location = new System.Drawing.Point(244, 9);
            this.Update_BTN.Name = "Update_BTN";
            this.Update_BTN.Size = new System.Drawing.Size(62, 53);
            this.Update_BTN.TabIndex = 45;
            this.Update_BTN.Text = "Update";
            this.Update_BTN.UseVisualStyleBackColor = true;
            this.Update_BTN.Click += new System.EventHandler(this.Update_BTN_Click);
            // 
            // Clear_BTN
            // 
            this.Clear_BTN.Location = new System.Drawing.Point(312, 9);
            this.Clear_BTN.Name = "Clear_BTN";
            this.Clear_BTN.Size = new System.Drawing.Size(62, 53);
            this.Clear_BTN.TabIndex = 39;
            this.Clear_BTN.Text = "Clear";
            this.Clear_BTN.UseVisualStyleBackColor = true;
            this.Clear_BTN.Click += new System.EventHandler(this.Clear_BTN_Click);
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.Enabled = false;
            this.Cancel_BTN.Location = new System.Drawing.Point(380, 9);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(62, 53);
            this.Cancel_BTN.TabIndex = 46;
            this.Cancel_BTN.Text = "Cancel";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            this.Cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Enabled = false;
            this.Save_BTN.Location = new System.Drawing.Point(448, 9);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(62, 53);
            this.Save_BTN.TabIndex = 47;
            this.Save_BTN.Text = "Save";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(802, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Search_BTN
            // 
            this.Search_BTN.Location = new System.Drawing.Point(607, 63);
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Size = new System.Drawing.Size(54, 23);
            this.Search_BTN.TabIndex = 50;
            this.Search_BTN.Text = "search";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click_1);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 588);
            this.Controls.Add(this.Search_BTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.Cancel_BTN);
            this.Controls.Add(this.Update_BTN);
            this.Controls.Add(this.Last_BTN);
            this.Controls.Add(this.Next_BTN);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.First_BTN);
            this.Controls.Add(this.AddRecord_BTN);
            this.Controls.Add(this.Clear_BTN);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Title);
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button AddRecord_BTN;
        //protected MetroButton AddRecord_BTN;
        public System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.Label Title;
        protected System.Windows.Forms.Button First_BTN;
        protected System.Windows.Forms.Button Back_BTN;
        protected System.Windows.Forms.Button Next_BTN;
        protected System.Windows.Forms.Button Last_BTN;
        protected System.Windows.Forms.Button Update_BTN;
        protected System.Windows.Forms.Button Clear_BTN;
        protected System.Windows.Forms.Button Cancel_BTN;
        protected System.Windows.Forms.Button Save_BTN;
        protected System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Button Search_BTN;
    }
}