namespace ProChic4._8
{
    partial class BIOS
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
            this.btnBegin = new libLeMS.Button();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin.Held = false;
            this.btnBegin.HoldOnPush = false;
            this.btnBegin.Location = new System.Drawing.Point(12, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.ShowFocusRectangle = true;
            this.btnBegin.Size = new System.Drawing.Size(143, 67);
            this.btnBegin.Stuck = false;
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Go to Windows 95";
            this.btnBegin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // BIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBegin);
            this.Name = "BIOS";
            this.Text = "BIOS";
            this.ResumeLayout(false);

        }

        #endregion

        private libLeMS.Button btnBegin;
    }
}