
namespace ManageRes
{
    partial class ChooseFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListFood = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPriceFood = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAmountMoney = new System.Windows.Forms.Label();
            this.numericUpDownAmountFood = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPriceTable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListFood)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(410, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Food";
            // 
            // dataGridViewListFood
            // 
            this.dataGridViewListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListFood.Location = new System.Drawing.Point(511, 64);
            this.dataGridViewListFood.Name = "dataGridViewListFood";
            this.dataGridViewListFood.RowHeadersWidth = 51;
            this.dataGridViewListFood.RowTemplate.Height = 24;
            this.dataGridViewListFood.Size = new System.Drawing.Size(535, 359);
            this.dataGridViewListFood.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownAmountFood);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxFood);
            this.groupBox2.Controls.Add(this.textBoxPriceFood);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 256);
            this.groupBox2.TabIndex = 14;
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
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(151, 52);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(293, 24);
            this.comboBoxFood.TabIndex = 13;
            this.comboBoxFood.SelectedIndexChanged += new System.EventHandler(this.comboBoxFood_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Amount:";
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonOrder.Location = new System.Drawing.Point(12, 326);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(113, 45);
            this.buttonOrder.TabIndex = 15;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRefresh.Location = new System.Drawing.Point(386, 326);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(119, 45);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelAmountMoney);
            this.panel1.Location = new System.Drawing.Point(511, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 100);
            this.panel1.TabIndex = 17;
            // 
            // labelAmountMoney
            // 
            this.labelAmountMoney.AutoSize = true;
            this.labelAmountMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountMoney.Location = new System.Drawing.Point(19, 55);
            this.labelAmountMoney.Name = "labelAmountMoney";
            this.labelAmountMoney.Size = new System.Drawing.Size(111, 25);
            this.labelAmountMoney.TabIndex = 0;
            this.labelAmountMoney.Text = "Amount: 0";
            // 
            // numericUpDownAmountFood
            // 
            this.numericUpDownAmountFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmountFood.Location = new System.Drawing.Point(151, 173);
            this.numericUpDownAmountFood.Name = "numericUpDownAmountFood";
            this.numericUpDownAmountFood.Size = new System.Drawing.Size(71, 26);
            this.numericUpDownAmountFood.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPriceTable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 68);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPriceTable
            // 
            this.textBoxPriceTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPriceTable.Location = new System.Drawing.Point(149, 21);
            this.textBoxPriceTable.Name = "textBoxPriceTable";
            this.textBoxPriceTable.Size = new System.Drawing.Size(293, 26);
            this.textBoxPriceTable.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price of table:";
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Green;
            this.buttonPayment.Location = new System.Drawing.Point(12, 480);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(113, 45);
            this.buttonPayment.TabIndex = 19;
            this.buttonPayment.Text = "Payment";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Food: 0";
            // 
            // ChooseFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1058, 541);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewListFood);
            this.Controls.Add(this.label1);
            this.Name = "ChooseFood";
            this.Text = "ChooseFood";
            this.Load += new System.EventHandler(this.ChooseFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListFood)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListFood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.TextBox textBoxPriceFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAmountMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPriceTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Label label6;
    }
}