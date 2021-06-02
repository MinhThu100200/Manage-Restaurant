
namespace ManageRes
{
    partial class ListFoodForm
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
            this.dataGridViewListFood = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPriceFood = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemoveFood = new System.Windows.Forms.Button();
            this.buttonEditFood = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.buttonSearchFood = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListFood
            // 
            this.dataGridViewListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListFood.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewListFood.Name = "dataGridViewListFood";
            this.dataGridViewListFood.RowHeadersWidth = 51;
            this.dataGridViewListFood.RowTemplate.Height = 24;
            this.dataGridViewListFood.Size = new System.Drawing.Size(489, 463);
            this.dataGridViewListFood.TabIndex = 0;
            this.dataGridViewListFood.DoubleClick += new System.EventHandler(this.dataGridViewListFood_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(437, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Food";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonRemoveFood);
            this.groupBox1.Controls.Add(this.buttonEditFood);
            this.groupBox1.Controls.Add(this.buttonAddFood);
            this.groupBox1.Controls.Add(this.buttonSearchFood);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(507, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 470);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPriceFood);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxNameFood);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 191);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // textBoxPriceFood
            // 
            this.textBoxPriceFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPriceFood.Location = new System.Drawing.Point(151, 116);
            this.textBoxPriceFood.Name = "textBoxPriceFood";
            this.textBoxPriceFood.Size = new System.Drawing.Size(293, 26);
            this.textBoxPriceFood.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(57, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price:";
            // 
            // textBoxNameFood
            // 
            this.textBoxNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameFood.Location = new System.Drawing.Point(151, 49);
            this.textBoxNameFood.Name = "textBoxNameFood";
            this.textBoxNameFood.Size = new System.Drawing.Size(293, 26);
            this.textBoxNameFood.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name: ";
            // 
            // buttonRemoveFood
            // 
            this.buttonRemoveFood.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemoveFood.Location = new System.Drawing.Point(21, 307);
            this.buttonRemoveFood.Name = "buttonRemoveFood";
            this.buttonRemoveFood.Size = new System.Drawing.Size(124, 46);
            this.buttonRemoveFood.TabIndex = 12;
            this.buttonRemoveFood.Text = "Remove";
            this.buttonRemoveFood.UseVisualStyleBackColor = false;
            this.buttonRemoveFood.Click += new System.EventHandler(this.buttonRemoveFood_Click);
            // 
            // buttonEditFood
            // 
            this.buttonEditFood.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEditFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditFood.Location = new System.Drawing.Point(399, 311);
            this.buttonEditFood.Name = "buttonEditFood";
            this.buttonEditFood.Size = new System.Drawing.Size(122, 42);
            this.buttonEditFood.TabIndex = 10;
            this.buttonEditFood.Text = "Edit";
            this.buttonEditFood.UseVisualStyleBackColor = false;
            this.buttonEditFood.Click += new System.EventHandler(this.buttonEditFood_Click);
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAddFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddFood.Location = new System.Drawing.Point(21, 399);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(124, 42);
            this.buttonAddFood.TabIndex = 9;
            this.buttonAddFood.Text = "Add";
            this.buttonAddFood.UseVisualStyleBackColor = false;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // buttonSearchFood
            // 
            this.buttonSearchFood.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSearchFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchFood.Location = new System.Drawing.Point(421, 12);
            this.buttonSearchFood.Name = "buttonSearchFood";
            this.buttonSearchFood.Size = new System.Drawing.Size(100, 35);
            this.buttonSearchFood.TabIndex = 2;
            this.buttonSearchFood.Text = "Search";
            this.buttonSearchFood.UseVisualStyleBackColor = false;
            this.buttonSearchFood.Click += new System.EventHandler(this.buttonSearchFood_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(112, 18);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(293, 26);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID: ";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(399, 399);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(122, 42);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ListFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1058, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListFood);
            this.Name = "ListFoodForm";
            this.Text = "ListFoodForm";
            this.Load += new System.EventHandler(this.ListFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPriceFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemoveFood;
        private System.Windows.Forms.Button buttonEditFood;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonSearchFood;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefresh;
    }
}