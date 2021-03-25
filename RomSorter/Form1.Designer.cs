namespace RomSorter
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.browseDir = new System.Windows.Forms.Button();
            this.regionMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moveFilesChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sortBtn.Location = new System.Drawing.Point(166, 113);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(15, 41);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(226, 20);
            this.filePathBox.TabIndex = 1;
            // 
            // browseDir
            // 
            this.browseDir.Location = new System.Drawing.Point(15, 12);
            this.browseDir.Name = "browseDir";
            this.browseDir.Size = new System.Drawing.Size(96, 23);
            this.browseDir.TabIndex = 2;
            this.browseDir.Text = "Browse Directory";
            this.browseDir.UseVisualStyleBackColor = true;
            this.browseDir.Click += new System.EventHandler(this.browseDir_Click);
            // 
            // regionMenu
            // 
            this.regionMenu.Items.AddRange(new object[] {
            "Europe",
            "USA",
            "Japan",
            "Others"});
            this.regionMenu.Location = new System.Drawing.Point(122, 81);
            this.regionMenu.Name = "regionMenu";
            this.regionMenu.Size = new System.Drawing.Size(121, 21);
            this.regionMenu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select region to keep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Or enter file path manually";
            // 
            // moveFilesChk
            // 
            this.moveFilesChk.AutoSize = true;
            this.moveFilesChk.Location = new System.Drawing.Point(249, 17);
            this.moveFilesChk.Name = "moveFilesChk";
            this.moveFilesChk.Size = new System.Drawing.Size(149, 17);
            this.moveFilesChk.TabIndex = 7;
            this.moveFilesChk.Text = "Move all files to root folder";
            this.moveFilesChk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 148);
            this.Controls.Add(this.moveFilesChk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionMenu);
            this.Controls.Add(this.browseDir);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.sortBtn);
            this.Name = "Form1";
            this.Text = "Rom Pack Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button browseDir;
        private System.Windows.Forms.ComboBox regionMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox moveFilesChk;
    }
}

