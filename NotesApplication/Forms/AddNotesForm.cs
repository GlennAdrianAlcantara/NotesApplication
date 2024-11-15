using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApplication.Controller;
using NotesApplication.DAO;
using NotesApplication.Models;
using NotesApplication.Services;
using NotesApplication.Data;
using NotesApplication.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotesApplication.Forms
{
    public partial class AddNotesForm : Form
    {
        private readonly NotesController _notesController;
        private DateTime createdDate;

        public event Action NotesAdded;

        public AddNotesForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var notesRepository = new NotesRepository(context);
            var notesServices = new NotesServices(notesRepository);
            _notesController = new NotesController(notesServices);
        }

        private void AddNotesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            string notesTitle = titleTxtBox.Text;
            string notesContent = contentTxtBox.Text;
            DateTime createdDate = DateTime.Now; 

            
            _notesController.AddNotes(notesTitle, notesContent, createdDate);

            MessageBox.Show("Added Successfully", "Information");

            NotesAdded?.Invoke(); 
            this.Close();
        }
    }
}
