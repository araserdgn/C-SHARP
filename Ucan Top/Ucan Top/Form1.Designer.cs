namespace Ucan_Top
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
            this.components = new System.ComponentModel.Container();
            this.üst = new System.Windows.Forms.Label();
            this.sol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sağ = new System.Windows.Forms.Label();
            this.hareket = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // üst
            // 
            this.üst.BackColor = System.Drawing.SystemColors.Highlight;
            this.üst.Location = new System.Drawing.Point(15, 35);
            this.üst.Name = "üst";
            this.üst.Size = new System.Drawing.Size(750, 23);
            this.üst.TabIndex = 0;
            // 
            // sol
            // 
            this.sol.BackColor = System.Drawing.Color.LightCoral;
            this.sol.Location = new System.Drawing.Point(12, 35);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(28, 428);
            this.sol.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(865, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sağ
            // 
            this.sağ.BackColor = System.Drawing.Color.LightCoral;
            this.sağ.Location = new System.Drawing.Point(737, 35);
            this.sağ.Name = "sağ";
            this.sağ.Size = new System.Drawing.Size(28, 428);
            this.sağ.TabIndex = 4;
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Aqua;
            this.hareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hareket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hareket.Location = new System.Drawing.Point(316, 414);
            this.hareket.Name = "hareket";
            this.hareket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hareket.Size = new System.Drawing.Size(89, 23);
            this.hareket.TabIndex = 5;
            this.hareket.Text = "--------------";
            this.hareket.UseVisualStyleBackColor = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(372, 187);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 21);
            this.ball.TabIndex = 6;
            this.ball.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(814, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 21);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.sağ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.üst);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label üst;
        private System.Windows.Forms.Label sol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sağ;
        private System.Windows.Forms.Button hareket;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}

