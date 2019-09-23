namespace OOP_List_Listbox
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
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.lbxCarListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCar.Location = new System.Drawing.Point(102, 95);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(148, 33);
            this.btnCreateCar.TabIndex = 0;
            this.btnCreateCar.Text = "Skapa Bil";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.BtnCreateCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tillverkare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reg.nr";
            // 
            // tbxBrand
            // 
            this.tbxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrand.Location = new System.Drawing.Point(150, 23);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(100, 32);
            this.tbxBrand.TabIndex = 3;
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRegNr.Location = new System.Drawing.Point(150, 57);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(100, 32);
            this.tbxRegNr.TabIndex = 4;
            // 
            // lbxCarListBox
            // 
            this.lbxCarListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCarListBox.FormattingEnabled = true;
            this.lbxCarListBox.ItemHeight = 25;
            this.lbxCarListBox.Location = new System.Drawing.Point(267, 12);
            this.lbxCarListBox.Name = "lbxCarListBox";
            this.lbxCarListBox.Size = new System.Drawing.Size(396, 229);
            this.lbxCarListBox.TabIndex = 5;
            this.lbxCarListBox.SelectedIndexChanged += new System.EventHandler(this.LbxCarListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxCarListBox);
            this.Controls.Add(this.tbxRegNr);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.TextBox tbxRegNr;
        private System.Windows.Forms.ListBox lbxCarListBox;
        private System.Windows.Forms.Button button1;
    }
}

