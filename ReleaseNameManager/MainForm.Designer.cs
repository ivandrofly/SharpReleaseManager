namespace ReleaseNameManager
{
    partial class MainForm
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
            this.listViewSubfiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSendSelection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxComment = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateComment = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonHI = new System.Windows.Forms.RadioButton();
            this.radioButtonNonHI = new System.Windows.Forms.RadioButton();
            this.radioButtonCHI = new System.Windows.Forms.RadioButton();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDoReplace = new System.Windows.Forms.Button();
            this.groupBoxComment.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSubfiles
            // 
            this.listViewSubfiles.AllowDrop = true;
            this.listViewSubfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSubfiles.CheckBoxes = true;
            this.listViewSubfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSubfiles.FullRowSelect = true;
            this.listViewSubfiles.GridLines = true;
            this.listViewSubfiles.Location = new System.Drawing.Point(12, 57);
            this.listViewSubfiles.Name = "listViewSubfiles";
            this.listViewSubfiles.Size = new System.Drawing.Size(859, 287);
            this.listViewSubfiles.TabIndex = 0;
            this.listViewSubfiles.UseCompatibleStateImageBehavior = false;
            this.listViewSubfiles.View = System.Windows.Forms.View.Details;
            this.listViewSubfiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewSubfiles_DragDrop);
            this.listViewSubfiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewSubfiles_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Release name";
            this.columnHeader2.Width = 786;
            // 
            // buttonSendSelection
            // 
            this.buttonSendSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendSelection.Location = new System.Drawing.Point(661, 28);
            this.buttonSendSelection.Name = "buttonSendSelection";
            this.buttonSendSelection.Size = new System.Drawing.Size(129, 23);
            this.buttonSendSelection.TabIndex = 1;
            this.buttonSendSelection.Text = "Send selection";
            this.buttonSendSelection.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(796, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxComment
            // 
            this.groupBoxComment.Controls.Add(this.radioButtonCHI);
            this.groupBoxComment.Controls.Add(this.radioButtonNonHI);
            this.groupBoxComment.Controls.Add(this.radioButtonHI);
            this.groupBoxComment.Controls.Add(this.buttonUpdateComment);
            this.groupBoxComment.Controls.Add(this.textBox1);
            this.groupBoxComment.Location = new System.Drawing.Point(12, 350);
            this.groupBoxComment.Name = "groupBoxComment";
            this.groupBoxComment.Size = new System.Drawing.Size(397, 100);
            this.groupBoxComment.TabIndex = 3;
            this.groupBoxComment.TabStop = false;
            this.groupBoxComment.Text = "Comment:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 47);
            this.textBox1.TabIndex = 0;
            // 
            // buttonUpdateComment
            // 
            this.buttonUpdateComment.Location = new System.Drawing.Point(316, 19);
            this.buttonUpdateComment.Name = "buttonUpdateComment";
            this.buttonUpdateComment.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateComment.TabIndex = 1;
            this.buttonUpdateComment.Text = "Update";
            this.buttonUpdateComment.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonDoReplace);
            this.groupBoxEdit.Controls.Add(this.label4);
            this.groupBoxEdit.Controls.Add(this.label3);
            this.groupBoxEdit.Controls.Add(this.textBoxReplace);
            this.groupBoxEdit.Controls.Add(this.textBoxFind);
            this.groupBoxEdit.Location = new System.Drawing.Point(426, 350);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(445, 100);
            this.groupBoxEdit.TabIndex = 4;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Portuguese",
            "French"});
            this.comboBox1.Location = new System.Drawing.Point(13, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Language:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bluray",
            "Telesync",
            "DVD",
            "Tv",
            "Web",
            "Other"});
            this.comboBox2.Location = new System.Drawing.Point(155, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Release-Type:";
            // 
            // radioButtonHI
            // 
            this.radioButtonHI.AutoSize = true;
            this.radioButtonHI.Location = new System.Drawing.Point(78, 72);
            this.radioButtonHI.Name = "radioButtonHI";
            this.radioButtonHI.Size = new System.Drawing.Size(36, 17);
            this.radioButtonHI.TabIndex = 2;
            this.radioButtonHI.TabStop = true;
            this.radioButtonHI.Text = "HI";
            this.radioButtonHI.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonHI
            // 
            this.radioButtonNonHI.AutoSize = true;
            this.radioButtonNonHI.Location = new System.Drawing.Point(19, 72);
            this.radioButtonNonHI.Name = "radioButtonNonHI";
            this.radioButtonNonHI.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNonHI.TabIndex = 3;
            this.radioButtonNonHI.TabStop = true;
            this.radioButtonNonHI.Text = "No-HI";
            this.radioButtonNonHI.UseVisualStyleBackColor = true;
            // 
            // radioButtonCHI
            // 
            this.radioButtonCHI.AutoSize = true;
            this.radioButtonCHI.Location = new System.Drawing.Point(120, 72);
            this.radioButtonCHI.Name = "radioButtonCHI";
            this.radioButtonCHI.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCHI.TabIndex = 4;
            this.radioButtonCHI.TabStop = true;
            this.radioButtonCHI.Text = "CHI";
            this.radioButtonCHI.UseVisualStyleBackColor = true;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(9, 32);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(307, 20);
            this.textBoxFind.TabIndex = 0;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(9, 72);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(307, 20);
            this.textBoxReplace.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Find:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Replace:";
            // 
            // buttonDoReplace
            // 
            this.buttonDoReplace.Location = new System.Drawing.Point(364, 70);
            this.buttonDoReplace.Name = "buttonDoReplace";
            this.buttonDoReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonDoReplace.TabIndex = 4;
            this.buttonDoReplace.Text = "Do replace";
            this.buttonDoReplace.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxComment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSendSelection);
            this.Controls.Add(this.listViewSubfiles);
            this.Name = "MainForm";
            this.Text = "Main";
            this.groupBoxComment.ResumeLayout(false);
            this.groupBoxComment.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSubfiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonSendSelection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdateComment;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNonHI;
        private System.Windows.Forms.RadioButton radioButtonHI;
        private System.Windows.Forms.RadioButton radioButtonCHI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonDoReplace;
    }
}

