namespace Sapper
{
    partial class Sapper
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
            this.Eazy = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eazy
            // 
            this.Eazy.Location = new System.Drawing.Point(136, 63);
            this.Eazy.Name = "eazy";
            this.Eazy.Size = new System.Drawing.Size(165, 73);
            this.Eazy.TabIndex = 0;
            this.Eazy.Text = "Eazy";
            this.Eazy.UseVisualStyleBackColor = true;
            this.Eazy.Click += new System.EventHandler(this.Eazy_Click);
            // 
            // Normal
            // 
            this.Normal.Location = new System.Drawing.Point(136, 142);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(165, 68);
            this.Normal.TabIndex = 1;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // hard
            // 
            this.Hard.Location = new System.Drawing.Point(136, 216);
            this.Hard.Name = "hard";
            this.Hard.Size = new System.Drawing.Size(165, 81);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Sapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 400);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Eazy);
            this.Name = "Sapper";
            this.Text = "Sapper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eazy;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Hard;
    }
}