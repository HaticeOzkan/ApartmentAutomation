namespace ApartmentAutomation
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
            this.btn_Incomes = new System.Windows.Forms.Button();
            this.btn_Expences = new System.Windows.Forms.Button();
            this.pbBx_Apartment = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBx_Apartment)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Incomes
            // 
            this.btn_Incomes.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Incomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Incomes.Location = new System.Drawing.Point(58, 156);
            this.btn_Incomes.Name = "btn_Incomes";
            this.btn_Incomes.Size = new System.Drawing.Size(112, 111);
            this.btn_Incomes.TabIndex = 0;
            this.btn_Incomes.Text = "Incomes";
            this.btn_Incomes.UseVisualStyleBackColor = false;
            this.btn_Incomes.Click += new System.EventHandler(this.btn_Incomes_Click);
            // 
            // btn_Expences
            // 
            this.btn_Expences.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Expences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Expences.Location = new System.Drawing.Point(406, 156);
            this.btn_Expences.Name = "btn_Expences";
            this.btn_Expences.Size = new System.Drawing.Size(112, 111);
            this.btn_Expences.TabIndex = 1;
            this.btn_Expences.Text = "Expences";
            this.btn_Expences.UseVisualStyleBackColor = false;
            this.btn_Expences.Click += new System.EventHandler(this.btn_Expences_Click);
            // 
            // pbBx_Apartment
            // 
            this.pbBx_Apartment.Image = global::ApartmentAutomation.Properties.Resources.Ev;
            this.pbBx_Apartment.InitialImage = null;
            this.pbBx_Apartment.Location = new System.Drawing.Point(202, 46);
            this.pbBx_Apartment.Name = "pbBx_Apartment";
            this.pbBx_Apartment.Size = new System.Drawing.Size(180, 138);
            this.pbBx_Apartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBx_Apartment.TabIndex = 2;
            this.pbBx_Apartment.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apartment Automation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(567, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBx_Apartment);
            this.Controls.Add(this.btn_Expences);
            this.Controls.Add(this.btn_Incomes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBx_Apartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Incomes;
        private System.Windows.Forms.Button btn_Expences;
        private System.Windows.Forms.PictureBox pbBx_Apartment;
        private System.Windows.Forms.Label label1;
    }
}

