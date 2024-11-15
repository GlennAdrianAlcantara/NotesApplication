namespace NotesApplication
{
    partial class Form1
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
            panelNotes = new FlowLayoutPanel();
            label1 = new Label();
            btnAddNotes = new Button();
            SuspendLayout();
            // 
            // panelNotes
            // 
            panelNotes.Location = new Point(2, 70);
            panelNotes.Name = "panelNotes";
            panelNotes.Size = new Size(908, 381);
            panelNotes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 150, 243);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(346, 40);
            label1.TabIndex = 0;
            label1.Text = "Simple Notes Manager";
            // 
            // btnAddNotes
            // 
            btnAddNotes.BackColor = Color.FromArgb(33, 150, 243);
            btnAddNotes.Dock = DockStyle.Right;
            btnAddNotes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNotes.ForeColor = SystemColors.ButtonFace;
            btnAddNotes.Location = new Point(910, 0);
            btnAddNotes.Name = "btnAddNotes";
            btnAddNotes.Size = new Size(131, 451);
            btnAddNotes.TabIndex = 5;
            btnAddNotes.Text = "Add Notes";
            btnAddNotes.UseVisualStyleBackColor = false;
            btnAddNotes.Click += btnAddNotes_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1053, 450);
            Controls.Add(btnAddNotes);
            Controls.Add(label1);
            Controls.Add(panelNotes);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelNotes;
        private Label label1;
        private Button btnAddNotes;
    }
}
