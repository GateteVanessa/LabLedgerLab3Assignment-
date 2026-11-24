namespace LabLedger.Views
{
    partial class ViewEquipmentForm
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
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colAssetId = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colLab = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colAvailable = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colAssetId, colCategory, colLab, colTotal, colAvailable, colStatus });
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 245);
            dataGridView1.TabIndex = 0;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colAssetId
            // 
            colAssetId.HeaderText = "Asset ID";
            colAssetId.MinimumWidth = 6;
            colAssetId.Name = "colAssetId";
            colAssetId.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colLab
            // 
            colLab.HeaderText = "Lab";
            colLab.MinimumWidth = 6;
            colLab.Name = "colLab";
            colLab.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colAvailable
            // 
            colAvailable.HeaderText = "Available";
            colAvailable.MinimumWidth = 6;
            colAvailable.Name = "colAvailable";
            colAvailable.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, ID or category";
            txtSearch.Size = new Size(343, 27);
            txtSearch.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(434, 17);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(598, 17);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Show All";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 338);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 338);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Quantity:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(535, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 27);
            textBox3.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(12, 405);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Borrow";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(363, 407);
            button4.Name = "button4";
            button4.Size = new Size(94, 24);
            button4.TabIndex = 9;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(181, 407);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "Return";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(535, 402);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "close";
            button6.UseVisualStyleBackColor = true;
            // 
            // ViewEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "ViewEquipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEquipmentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAssetId;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colLab;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colAvailable;
        private DataGridViewTextBoxColumn colStatus;
        private TextBox txtSearch;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
