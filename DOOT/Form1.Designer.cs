namespace DOOT
{
    partial class Randomshidd
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spookLabel = new System.Windows.Forms.Label();
            this.doots = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spook";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Is spook?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // spookLabel
            // 
            this.spookLabel.AutoSize = true;
            this.spookLabel.Font = new System.Drawing.Font("Comic Sans MS", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spookLabel.ForeColor = System.Drawing.Color.White;
            this.spookLabel.Location = new System.Drawing.Point(76, -38);
            this.spookLabel.Name = "spookLabel";
            this.spookLabel.Size = new System.Drawing.Size(616, 238);
            this.spookLabel.TabIndex = 4;
            this.spookLabel.Text = "DOOT";
            this.spookLabel.Visible = false;
            // 
            // doots
            // 
            this.doots.AutoSize = true;
            this.doots.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doots.ForeColor = System.Drawing.Color.Yellow;
            this.doots.Location = new System.Drawing.Point(384, 317);
            this.doots.Name = "doots";
            this.doots.Size = new System.Drawing.Size(151, 38);
            this.doots.TabIndex = 5;
            this.doots.Text = "dootmeter";
            // 
            // Randomshidd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doots);
            this.Controls.Add(this.spookLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Randomshidd";
            this.Text = "Pretty fucking spooky my dude not gonna lie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label spookLabel;
        private System.Windows.Forms.Label doots;
    }
}

