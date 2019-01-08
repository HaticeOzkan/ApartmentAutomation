namespace ApartmentAutomation
{
    partial class Incomes
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
            this.dataGridViewIncomes = new System.Windows.Forms.DataGridView();
            this.grpBx_Incomes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_Amount = new System.Windows.Forms.TextBox();
            this.dTimePc_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.numericUpDownFlatNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).BeginInit();
            this.grpBx_Incomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlatNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIncomes
            // 
            this.dataGridViewIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewIncomes.Location = new System.Drawing.Point(0, 152);
            this.dataGridViewIncomes.Name = "dataGridViewIncomes";
            this.dataGridViewIncomes.Size = new System.Drawing.Size(480, 237);
            this.dataGridViewIncomes.TabIndex = 0;
            // 
            // grpBx_Incomes
            // 
            this.grpBx_Incomes.Controls.Add(this.numericUpDownFlatNo);
            this.grpBx_Incomes.Controls.Add(this.btn_Add);
            this.grpBx_Incomes.Controls.Add(this.dTimePc_Date);
            this.grpBx_Incomes.Controls.Add(this.txtBx_Amount);
            this.grpBx_Incomes.Controls.Add(this.label3);
            this.grpBx_Incomes.Controls.Add(this.label2);
            this.grpBx_Incomes.Controls.Add(this.label1);
            this.grpBx_Incomes.Location = new System.Drawing.Point(12, 12);
            this.grpBx_Incomes.Name = "grpBx_Incomes";
            this.grpBx_Incomes.Size = new System.Drawing.Size(460, 134);
            this.grpBx_Incomes.TabIndex = 1;
            this.grpBx_Incomes.TabStop = false;
            this.grpBx_Incomes.Text = "New Add Dues";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flat No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // txtBx_Amount
            // 
            this.txtBx_Amount.Location = new System.Drawing.Point(93, 66);
            this.txtBx_Amount.Name = "txtBx_Amount";
            this.txtBx_Amount.Size = new System.Drawing.Size(120, 20);
            this.txtBx_Amount.TabIndex = 4;
            // 
            // dTimePc_Date
            // 
            this.dTimePc_Date.Location = new System.Drawing.Point(270, 22);
            this.dTimePc_Date.Name = "dTimePc_Date";
            this.dTimePc_Date.Size = new System.Drawing.Size(169, 20);
            this.dTimePc_Date.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(311, 73);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 40);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // numericUpDownFlatNo
            // 
            this.numericUpDownFlatNo.Location = new System.Drawing.Point(93, 26);
            this.numericUpDownFlatNo.Name = "numericUpDownFlatNo";
            this.numericUpDownFlatNo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFlatNo.TabIndex = 7;
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.grpBx_Incomes);
            this.Controls.Add(this.dataGridViewIncomes);
            this.Name = "Incomes";
            this.Text = "Incomes";
            this.Load += new System.EventHandler(this.Incomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).EndInit();
            this.grpBx_Incomes.ResumeLayout(false);
            this.grpBx_Incomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlatNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIncomes;
        private System.Windows.Forms.GroupBox grpBx_Incomes;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dTimePc_Date;
        private System.Windows.Forms.TextBox txtBx_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFlatNo;
    }
}