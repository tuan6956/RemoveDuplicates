namespace RemoveDuplicates
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
            this.txtFileMain = new System.Windows.Forms.TextBox();
            this.txtFileCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFileMain = new System.Windows.Forms.Button();
            this.btnOpenFileCheck = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileMain
            // 
            this.txtFileMain.Location = new System.Drawing.Point(12, 26);
            this.txtFileMain.Name = "txtFileMain";
            this.txtFileMain.Size = new System.Drawing.Size(285, 20);
            this.txtFileMain.TabIndex = 0;
            // 
            // txtFileCheck
            // 
            this.txtFileCheck.Location = new System.Drawing.Point(12, 68);
            this.txtFileCheck.Name = "txtFileCheck";
            this.txtFileCheck.Size = new System.Drawing.Size(285, 20);
            this.txtFileCheck.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File cần lọc";
            // 
            // btnOpenFileMain
            // 
            this.btnOpenFileMain.Location = new System.Drawing.Point(304, 26);
            this.btnOpenFileMain.Name = "btnOpenFileMain";
            this.btnOpenFileMain.Size = new System.Drawing.Size(55, 23);
            this.btnOpenFileMain.TabIndex = 4;
            this.btnOpenFileMain.Text = "Open";
            this.btnOpenFileMain.UseVisualStyleBackColor = true;
            this.btnOpenFileMain.Click += new System.EventHandler(this.btnOpenFileMain_Click);
            // 
            // btnOpenFileCheck
            // 
            this.btnOpenFileCheck.Location = new System.Drawing.Point(303, 65);
            this.btnOpenFileCheck.Name = "btnOpenFileCheck";
            this.btnOpenFileCheck.Size = new System.Drawing.Size(55, 23);
            this.btnOpenFileCheck.TabIndex = 5;
            this.btnOpenFileCheck.Text = "Open";
            this.btnOpenFileCheck.UseVisualStyleBackColor = true;
            this.btnOpenFileCheck.Click += new System.EventHandler(this.btnOpenFileCheck_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(141, 94);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(78, 96);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(55, 20);
            this.txtIndex.TabIndex = 9;
            this.txtIndex.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Index CCN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnOpenFileCheck);
            this.Controls.Add(this.btnOpenFileMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileCheck);
            this.Controls.Add(this.txtFileMain);
            this.Name = "Form1";
            this.Text = "Remove Duplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileMain;
        private System.Windows.Forms.TextBox txtFileCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFileMain;
        private System.Windows.Forms.Button btnOpenFileCheck;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label3;
    }
}

