namespace EmptyRecycleBin {
  partial class MAIN {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.DoEmpty = new System.Windows.Forms.Button();
      this.DoExit = new System.Windows.Forms.Button();
      this.LINK = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // DoEmpty
      // 
      this.DoEmpty.AutoSize = true;
      this.DoEmpty.Font = new System.Drawing.Font("Segoe UI", 9.75 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DoEmpty.ForeColor = System.Drawing.Color.SteelBlue;
      this.DoEmpty.Image = global::EmptyRecycleBin.Properties.Resources.icon_scaled;
      this.DoEmpty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.DoEmpty.Location = new System.Drawing.Point(14, 16);
      this.DoEmpty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.DoEmpty.Name = "DoEmpty";
      this.DoEmpty.Size = new System.Drawing.Size(208, 276);
      this.DoEmpty.TabIndex = 0;
      this.DoEmpty.Text = "Empty Recycle Bin";
      this.DoEmpty.UseVisualStyleBackColor = true;
      this.DoEmpty.Click += new System.EventHandler(this.DoEmpty_Click);
      // 
      // DoExit
      // 
      this.DoExit.AutoSize = true;
      this.DoExit.Font = new System.Drawing.Font("Segoe UI", 9.75 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DoExit.ForeColor = System.Drawing.Color.OrangeRed;
      this.DoExit.Image = global::EmptyRecycleBin.Properties.Resources.icon2_scaled;
      this.DoExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.DoExit.Location = new System.Drawing.Point(229, 16);
      this.DoExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.DoExit.Name = "DoExit";
      this.DoExit.Size = new System.Drawing.Size(157, 276);
      this.DoExit.TabIndex = 1;
      this.DoExit.Text = "Quit";
      this.DoExit.UseVisualStyleBackColor = true;
      this.DoExit.Click += new System.EventHandler(this.DoExit_Click);
      // 
      // LINK
      // 
      this.LINK.AutoEllipsis = true;
      this.LINK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.LINK.Font = new System.Drawing.Font("Segoe Print", 9.75 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LINK.ForeColor = System.Drawing.Color.Red;
      this.LINK.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.LINK.LinkColor = System.Drawing.Color.Red;
      this.LINK.Location = new System.Drawing.Point(14, 307);
      this.LINK.Name = "LINK";
      this.LINK.Size = new System.Drawing.Size(371, 47);
      this.LINK.TabIndex = 2;
      this.LINK.TabStop = true;
      this.LINK.Text = "Created by Andrew Poženel";
      this.LINK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.LINK.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.LINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_LinkClicked);
      // 
      // MAIN
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8 F, 20 F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(399, 365);
      this.ControlBox = false;
      this.Controls.Add(this.LINK);
      this.Controls.Add(this.DoExit);
      this.Controls.Add(this.DoEmpty);
      this.Cursor = System.Windows.Forms.Cursors.Cross;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    private LinkLabel LINK;
  }
}