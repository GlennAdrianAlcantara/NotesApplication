namespace NotesApplication.Forms
{
    partial class AddNotesForm
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
            label1 = new Label();
            titleTxtBox = new TextBox();
            label2 = new Label();
            contentTxtBox = new TextBox();
            btnSaveNotes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // titleTxtBox
            // 
            titleTxtBox.Location = new Point(51, 49);
            titleTxtBox.Multiline = true;
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(307, 36);
            titleTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(51, 113);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Content:";
            // 
            // contentTxtBox
            // 
            contentTxtBox.Location = new Point(51, 137);
            contentTxtBox.Multiline = true;
            contentTxtBox.Name = "contentTxtBox";
            contentTxtBox.Size = new Size(307, 126);
            contentTxtBox.TabIndex = 3;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.BackColor = SystemColors.Highlight;
            btnSaveNotes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveNotes.ForeColor = SystemColors.ButtonFace;
            btnSaveNotes.Location = new Point(139, 281);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(131, 37);
            btnSaveNotes.TabIndex = 4;
            btnSaveNotes.Text = "Save";
            btnSaveNotes.UseVisualStyleBackColor = false;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // AddNotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 343);
            Controls.Add(btnSaveNotes);
            Controls.Add(contentTxtBox);
            Controls.Add(label2);
            Controls.Add(titleTxtBox);
            Controls.Add(label1);
            Name = "AddNotesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNotes";
            Load += AddNotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTxtBox;
        private Label label2;
        private TextBox contentTxtBox;
        private Button btnSaveNotes;
    }
}