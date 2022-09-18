namespace EmptyRecycleBin
{
    partial class MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoEmpty = new System.Windows.Forms.Button();
            this.DoExit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DoEmpty
            // 
            this.DoEmpty.AutoSize = true;
            this.DoEmpty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoEmpty.ForeColor = System.Drawing.Color.SteelBlue;
            this.DoEmpty.Location = new System.Drawing.Point(12, 12);
            this.DoEmpty.Name = "DoEmpty";
            this.DoEmpty.Size = new System.Drawing.Size(182, 207);
            this.DoEmpty.TabIndex = 0;
            this.DoEmpty.Text = "Empty Recycle Bin";
            this.DoEmpty.UseVisualStyleBackColor = true;
            this.DoEmpty.Click += new System.EventHandler(this.DoEmpty_Click);
            // 
            // DoExit
            // 
            this.DoExit.AutoSize = true;
            this.DoExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.DoExit.Location = new System.Drawing.Point(200, 12);
            this.DoExit.Name = "DoExit";
            this.DoExit.Size = new System.Drawing.Size(137, 207);
            this.DoExit.TabIndex = 1;
            this.DoExit.Text = "Quit";
            this.DoExit.UseVisualStyleBackColor = true;
            this.DoExit.Click += new System.EventHandler(this.DoExit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 230);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(325, 35);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by Andrew Poženel";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 274);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DoExit);
            this.Controls.Add(this.DoEmpty);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty Recycle Bin";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoEmpty;
        private Button DoExit;
        private LinkLabel linkLabel1;
    }
}