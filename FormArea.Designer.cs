namespace WindowsPracticas
{
    partial class FormArea
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
            this.VerArea = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VerArea
            // 
            this.VerArea.Location = new System.Drawing.Point(327, 174);
            this.VerArea.Name = "VerArea";
            this.VerArea.Size = new System.Drawing.Size(75, 23);
            this.VerArea.TabIndex = 0;
            this.VerArea.Text = "VerArea";
            this.VerArea.UseVisualStyleBackColor = true;
            this.VerArea.Click += new System.EventHandler(this.VerArea_Click);
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(302, 104);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(100, 20);
            this.Base.TabIndex = 1;
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(302, 130);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 20);
            this.Altura.TabIndex = 2;
            // 
            // FormArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.VerArea);
            this.Name = "FormArea";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerArea;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.TextBox Altura;
    }
}

