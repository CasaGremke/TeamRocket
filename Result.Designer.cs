namespace TeamRock
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.lblScore = new System.Windows.Forms.Label();
            this.txtYScore = new System.Windows.Forms.TextBox();
            this.lblHScore = new System.Windows.Forms.Label();
            this.txtHScore = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Cyan;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(116, 182);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(99, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Your Score";
            // 
            // txtYScore
            // 
            this.txtYScore.Location = new System.Drawing.Point(271, 182);
            this.txtYScore.Name = "txtYScore";
            this.txtYScore.Size = new System.Drawing.Size(132, 20);
            this.txtYScore.TabIndex = 1;
            // 
            // lblHScore
            // 
            this.lblHScore.AutoSize = true;
            this.lblHScore.BackColor = System.Drawing.Color.Cyan;
            this.lblHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHScore.Location = new System.Drawing.Point(116, 227);
            this.lblHScore.Name = "lblHScore";
            this.lblHScore.Size = new System.Drawing.Size(98, 20);
            this.lblHScore.TabIndex = 2;
            this.lblHScore.Text = "High Score";
            // 
            // txtHScore
            // 
            this.txtHScore.Location = new System.Drawing.Point(271, 227);
            this.txtHScore.Name = "txtHScore";
            this.txtHScore.Size = new System.Drawing.Size(132, 20);
            this.txtHScore.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cyan;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(271, 381);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "Return";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(449, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtHScore);
            this.Controls.Add(this.lblHScore);
            this.Controls.Add(this.txtYScore);
            this.Controls.Add(this.lblScore);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtYScore;
        private System.Windows.Forms.Label lblHScore;
        private System.Windows.Forms.TextBox txtHScore;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnExit;
    }
}