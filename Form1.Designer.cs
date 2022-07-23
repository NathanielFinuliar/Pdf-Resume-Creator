namespace Pdf_Resume_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Converterlbl = new System.Windows.Forms.Label();
            this.CnvrtrBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Converterlbl
            // 
            this.Converterlbl.AutoSize = true;
            this.Converterlbl.BackColor = System.Drawing.Color.DeepPink;
            this.Converterlbl.Font = new System.Drawing.Font("The Bold Font", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Converterlbl.ForeColor = System.Drawing.Color.White;
            this.Converterlbl.Location = new System.Drawing.Point(44, 149);
            this.Converterlbl.Name = "Converterlbl";
            this.Converterlbl.Size = new System.Drawing.Size(427, 44);
            this.Converterlbl.TabIndex = 1;
            this.Converterlbl.Text = "RESUME JSON FILE TO PDF";
            // 
            // CnvrtrBttn
            // 
            this.CnvrtrBttn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CnvrtrBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CnvrtrBttn.Font = new System.Drawing.Font("The Bold Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnvrtrBttn.ForeColor = System.Drawing.Color.White;
            this.CnvrtrBttn.Location = new System.Drawing.Point(173, 209);
            this.CnvrtrBttn.Name = "CnvrtrBttn";
            this.CnvrtrBttn.Size = new System.Drawing.Size(156, 48);
            this.CnvrtrBttn.TabIndex = 2;
            this.CnvrtrBttn.Text = "CONVERT";
            this.CnvrtrBttn.UseVisualStyleBackColor = false;
            this.CnvrtrBttn.Click += new System.EventHandler(this.CnvrtrBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 444);
            this.Controls.Add(this.CnvrtrBttn);
            this.Controls.Add(this.Converterlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pdf Resume Converter App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Converterlbl;
        private System.Windows.Forms.Button CnvrtrBttn;
    }
}

