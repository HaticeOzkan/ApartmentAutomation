namespace ApartmentAutomation
{
    partial class Expenses
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
            this.dataGrdViewExpense = new System.Windows.Forms.DataGridView();
            this.groupBoxExpence = new System.Windows.Forms.GroupBox();
            this.radioButtonElectric = new System.Windows.Forms.RadioButton();
            this.radioButtonCleanLines = new System.Windows.Forms.RadioButton();
            this.radioButtonElevator = new System.Windows.Forms.RadioButton();
            this.radioButtonWater = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxMounth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonWatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewExpense)).BeginInit();
            this.groupBoxExpence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrdViewExpense
            // 
            this.dataGrdViewExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViewExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrdViewExpense.Location = new System.Drawing.Point(0, 221);
            this.dataGrdViewExpense.Name = "dataGrdViewExpense";
            this.dataGrdViewExpense.Size = new System.Drawing.Size(464, 201);
            this.dataGrdViewExpense.TabIndex = 0;
            // 
            // groupBoxExpence
            // 
            this.groupBoxExpence.Controls.Add(this.radioButtonElectric);
            this.groupBoxExpence.Controls.Add(this.radioButtonCleanLines);
            this.groupBoxExpence.Controls.Add(this.radioButtonElevator);
            this.groupBoxExpence.Controls.Add(this.radioButtonWater);
            this.groupBoxExpence.Controls.Add(this.label2);
            this.groupBoxExpence.Controls.Add(this.label1);
            this.groupBoxExpence.Controls.Add(this.btn_Add);
            this.groupBoxExpence.Controls.Add(this.dateTimePickerExpense);
            this.groupBoxExpence.Controls.Add(this.textBoxAmount);
            this.groupBoxExpence.Location = new System.Drawing.Point(12, 1);
            this.groupBoxExpence.Name = "groupBoxExpence";
            this.groupBoxExpence.Size = new System.Drawing.Size(440, 145);
            this.groupBoxExpence.TabIndex = 1;
            this.groupBoxExpence.TabStop = false;
            this.groupBoxExpence.Text = "New Add Expense";
            // 
            // radioButtonElectric
            // 
            this.radioButtonElectric.AutoSize = true;
            this.radioButtonElectric.Location = new System.Drawing.Point(23, 49);
            this.radioButtonElectric.Name = "radioButtonElectric";
            this.radioButtonElectric.Size = new System.Drawing.Size(60, 17);
            this.radioButtonElectric.TabIndex = 12;
            this.radioButtonElectric.TabStop = true;
            this.radioButtonElectric.Text = "Electric";
            this.radioButtonElectric.UseVisualStyleBackColor = true;
            // 
            // radioButtonCleanLines
            // 
            this.radioButtonCleanLines.AutoSize = true;
            this.radioButtonCleanLines.Location = new System.Drawing.Point(23, 109);
            this.radioButtonCleanLines.Name = "radioButtonCleanLines";
            this.radioButtonCleanLines.Size = new System.Drawing.Size(78, 17);
            this.radioButtonCleanLines.TabIndex = 11;
            this.radioButtonCleanLines.TabStop = true;
            this.radioButtonCleanLines.Text = "Cleanliness";
            this.radioButtonCleanLines.UseVisualStyleBackColor = true;
            // 
            // radioButtonElevator
            // 
            this.radioButtonElevator.AutoSize = true;
            this.radioButtonElevator.Location = new System.Drawing.Point(23, 79);
            this.radioButtonElevator.Name = "radioButtonElevator";
            this.radioButtonElevator.Size = new System.Drawing.Size(64, 17);
            this.radioButtonElevator.TabIndex = 10;
            this.radioButtonElevator.TabStop = true;
            this.radioButtonElevator.Text = "Elevator";
            this.radioButtonElevator.UseVisualStyleBackColor = true;
            // 
            // radioButtonWater
            // 
            this.radioButtonWater.AutoSize = true;
            this.radioButtonWater.Location = new System.Drawing.Point(23, 19);
            this.radioButtonWater.Name = "radioButtonWater";
            this.radioButtonWater.Size = new System.Drawing.Size(54, 17);
            this.radioButtonWater.TabIndex = 9;
            this.radioButtonWater.TabStop = true;
            this.radioButtonWater.Text = "Water";
            this.radioButtonWater.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(269, 98);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 30);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Location = new System.Drawing.Point(211, 19);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerExpense.TabIndex = 5;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(214, 53);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(150, 20);
            this.textBoxAmount.TabIndex = 4;
            // 
            // comboBoxMounth
            // 
            this.comboBoxMounth.FormattingEnabled = true;
            this.comboBoxMounth.Location = new System.Drawing.Point(68, 173);
            this.comboBoxMounth.Name = "comboBoxMounth";
            this.comboBoxMounth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMounth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mounth:";
            // 
            // buttonWatch
            // 
            this.buttonWatch.Location = new System.Drawing.Point(226, 161);
            this.buttonWatch.Name = "buttonWatch";
            this.buttonWatch.Size = new System.Drawing.Size(59, 42);
            this.buttonWatch.TabIndex = 4;
            this.buttonWatch.Text = "Watch";
            this.buttonWatch.UseVisualStyleBackColor = true;
            this.buttonWatch.Click += new System.EventHandler(this.buttonWatch_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 422);
            this.Controls.Add(this.buttonWatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMounth);
            this.Controls.Add(this.groupBoxExpence);
            this.Controls.Add(this.dataGrdViewExpense);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewExpense)).EndInit();
            this.groupBoxExpence.ResumeLayout(false);
            this.groupBoxExpence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdViewExpense;
        private System.Windows.Forms.GroupBox groupBoxExpence;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonElectric;
        private System.Windows.Forms.RadioButton radioButtonCleanLines;
        private System.Windows.Forms.RadioButton radioButtonElevator;
        private System.Windows.Forms.RadioButton radioButtonWater;
        private System.Windows.Forms.ComboBox comboBoxMounth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWatch;
    }
}