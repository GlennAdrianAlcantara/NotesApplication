namespace NotesApplication.Forms
{
    partial class UpdateNotesForm
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
            titleTxtBox = new TextBox();
            contentTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnUpdateNotes = new Button();
            SuspendLayout();
            // 
            // titleTxtBox
            // 
            titleTxtBox.Location = new Point(88, 69);
            titleTxtBox.Multiline = true;
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(307, 36);
            titleTxtBox.TabIndex = 2;
            titleTxtBox.TextChanged += titleTxtBox_TextChanged;
            // 
            // contentTxtBox
            // 
            contentTxtBox.Location = new Point(88, 156);
            contentTxtBox.Multiline = true;
            contentTxtBox.Name = "contentTxtBox";
            contentTxtBox.Size = new Size(307, 126);
            contentTxtBox.TabIndex = 4;
            contentTxtBox.TextChanged += contentTxtBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(88, 45);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 5;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(88, 132);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 6;
            label2.Text = "Content:";
            // 
            // btnUpdateNotes
            // 
            btnUpdateNotes.BackColor = SystemColors.Highlight;
            btnUpdateNotes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateNotes.ForeColor = SystemColors.ButtonFace;
            btnUpdateNotes.Location = new Point(169, 314);
            btnUpdateNotes.Name = "btnUpdateNotes";
            btnUpdateNotes.Size = new Size(131, 37);
            btnUpdateNotes.TabIndex = 7;
            btnUpdateNotes.Text = "Update";
            btnUpdateNotes.UseVisualStyleBackColor = false;
            btnUpdateNotes.Click += btnUpdateNotes_Click;
            // 
            // UpdateNotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 376);
            Controls.Add(btnUpdateNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contentTxtBox);
            Controls.Add(titleTxtBox);
            Name = "UpdateNotesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateNotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTxtBox;
        private TextBox contentTxtBox;
        private Label label1;
        private Label label2;
        private Button btnUpdateNotes;
    }
}