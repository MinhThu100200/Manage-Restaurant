
namespace ManageRes
{
    partial class CRUDTableForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTypeTable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStateTable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemoveTable = new System.Windows.Forms.Button();
            this.buttonEditTable = new System.Windows.Forms.Button();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.buttonSearchTable = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewListTable = new System.Windows.Forms.DataGridView();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonRemoveTable);
            this.groupBox1.Controls.Add(this.buttonEditTable);
            this.groupBox1.Controls.Add(this.buttonAddTable);
            this.groupBox1.Controls.Add(this.buttonSearchTable);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(546, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownQuantity);
            this.groupBox2.Controls.Add(this.comboBoxTypeTable);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxStateTable);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxNameTable);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 299);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxTypeTable
            // 
            this.comboBoxTypeTable.FormattingEnabled = true;
            this.comboBoxTypeTable.Location = new System.Drawing.Point(132, 114);
            this.comboBoxTypeTable.Name = "comboBoxTypeTable";
            this.comboBoxTypeTable.Size = new System.Drawing.Size(293, 24);
            this.comboBoxTypeTable.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "State:";
            // 
            // textBoxStateTable
            // 
            this.textBoxStateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStateTable.Location = new System.Drawing.Point(132, 174);
            this.textBoxStateTable.Name = "textBoxStateTable";
            this.textBoxStateTable.Size = new System.Drawing.Size(293, 26);
            this.textBoxStateTable.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type:";
            // 
            // textBoxNameTable
            // 
            this.textBoxNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameTable.Location = new System.Drawing.Point(132, 49);
            this.textBoxNameTable.Name = "textBoxNameTable";
            this.textBoxNameTable.Size = new System.Drawing.Size(293, 26);
            this.textBoxNameTable.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name: ";
            // 
            // buttonRemoveTable
            // 
            this.buttonRemoveTable.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemoveTable.Location = new System.Drawing.Point(24, 388);
            this.buttonRemoveTable.Name = "buttonRemoveTable";
            this.buttonRemoveTable.Size = new System.Drawing.Size(124, 46);
            this.buttonRemoveTable.TabIndex = 12;
            this.buttonRemoveTable.Text = "Remove";
            this.buttonRemoveTable.UseVisualStyleBackColor = false;
            this.buttonRemoveTable.Click += new System.EventHandler(this.buttonRemoveTable_Click);
            // 
            // buttonEditTable
            // 
            this.buttonEditTable.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEditTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditTable.Location = new System.Drawing.Point(360, 390);
            this.buttonEditTable.Name = "buttonEditTable";
            this.buttonEditTable.Size = new System.Drawing.Size(122, 42);
            this.buttonEditTable.TabIndex = 10;
            this.buttonEditTable.Text = "Edit";
            this.buttonEditTable.UseVisualStyleBackColor = false;
            this.buttonEditTable.Click += new System.EventHandler(this.buttonEditTable_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAddTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddTable.Location = new System.Drawing.Point(198, 392);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(124, 42);
            this.buttonAddTable.TabIndex = 9;
            this.buttonAddTable.Text = "Add";
            this.buttonAddTable.UseVisualStyleBackColor = false;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonSearchTable
            // 
            this.buttonSearchTable.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSearchTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchTable.Location = new System.Drawing.Point(376, 12);
            this.buttonSearchTable.Name = "buttonSearchTable";
            this.buttonSearchTable.Size = new System.Drawing.Size(100, 35);
            this.buttonSearchTable.TabIndex = 2;
            this.buttonSearchTable.Text = "Search";
            this.buttonSearchTable.UseVisualStyleBackColor = false;
            this.buttonSearchTable.Click += new System.EventHandler(this.buttonSearchTable_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(76, 18);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(279, 26);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID: ";
            // 
            // dataGridViewListTable
            // 
            this.dataGridViewListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListTable.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewListTable.Name = "dataGridViewListTable";
            this.dataGridViewListTable.RowHeadersWidth = 51;
            this.dataGridViewListTable.RowTemplate.Height = 24;
            this.dataGridViewListTable.Size = new System.Drawing.Size(528, 463);
            this.dataGridViewListTable.TabIndex = 3;
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRefresh.Location = new System.Drawing.Point(451, 16);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(108, 39);
            this.labelRefresh.TabIndex = 5;
            this.labelRefresh.Text = "Table";
            this.labelRefresh.Click += new System.EventHandler(this.labelRefresh_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(132, 242);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownQuantity.TabIndex = 18;
            // 
            // CRUDTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1058, 541);
            this.Controls.Add(this.labelRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewListTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDTableForm";
            this.Text = "CRUDTableForm";
            this.Load += new System.EventHandler(this.CRUDTableForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxStateTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemoveTable;
        private System.Windows.Forms.Button buttonEditTable;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.Button buttonSearchTable;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewListTable;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypeTable;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
    }
}