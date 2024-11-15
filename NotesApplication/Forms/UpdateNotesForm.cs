using NotesApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApplication.Forms;

namespace NotesApplication.Forms
{
    public partial class UpdateNotesForm : Form
    {
        private NotesItem notesItem;

        public event Action<NotesItem> NoteUpdated;
        public UpdateNotesForm()
        {
            InitializeComponent();
        }

        public UpdateNotesForm(NotesItem notesItem)
        {
            InitializeComponent();
            this.notesItem = notesItem;

            // Populate the form with the note's data
            titleTxtBox.Text = notesItem.Title;
            contentTxtBox.Text = notesItem.Content;
        }

        private void titleTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contentTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateNotes_Click(object sender, EventArgs e)
        {
            notesItem.Title = titleTxtBox.Text;
            notesItem.Content = contentTxtBox.Text;
            notesItem.UpdatedDate = DateTime.Now;

            // Trigger the NoteUpdated event
            NoteUpdated?.Invoke(notesItem);

            // Close the form after updating
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
