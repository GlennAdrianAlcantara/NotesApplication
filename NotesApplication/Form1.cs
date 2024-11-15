using NotesApplication.Controller;
using NotesApplication.DAO;
using NotesApplication.Models;
using NotesApplication.Services;
using NotesApplication.Data;
using NotesApplication.Forms;



namespace NotesApplication
{
    public partial class Form1 : Form
    {
        public readonly NotesController _notesController;
        public Form1()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var notesRepository = new NotesRepository(context);
            var notesServices = new NotesServices(notesRepository);
            _notesController = new NotesController(notesServices);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            panelNotes.Controls.Clear();
            panelNotes.AutoScroll = true;   // Enable scrolling if the content overflows
            panelNotes.WrapContents = true; // Allow wrapping content within the available space
            panelNotes.FlowDirection = FlowDirection.LeftToRight;  // You can switch to TopDown if you prefer vertical layout
            panelNotes.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100); // Dynamic width & height
            panelNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            var notes = _notesController.GetAllNotes();
            foreach (var note in notes)
            {
                AddNotesCard(note);
            }
        }

        private void btnAddNotes_Click(object sender, EventArgs e)
        {
            var addNotesForm = new AddNotesForm();
            addNotesForm.NotesAdded += LoadNotes;
            addNotesForm.ShowDialog();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void AddNotesCard(NotesItem notesItem)
        {
            // Define a modern color palette
            Color cardBackgroundColor = Color.FromArgb(33, 150, 243); // Light blue
            Color titleColor = Color.FromArgb(255, 255, 255); // White
            Color contentColor = Color.FromArgb(230, 230, 230); // Light gray for content
            Color dateColor = Color.FromArgb(200, 200, 200); // Slightly darker gray for date
            Color actionColor = Color.FromArgb(244, 67, 54); // Red for delete, Gold for edit
            Color buttonBackgroundColor = Color.FromArgb(0, 123, 255); // Darker blue for button
            Color buttonTextColor = Color.White; // White text for button

            // Card Panel setup
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = cardBackgroundColor,
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Delete Icon
            var deleteIcon = new Label
            {
                Text = "✖",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = actionColor,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteNotes(notesItem);
            cardPanel.Controls.Add(deleteIcon);

            // Edit Icon
            var editIcon = new Label
            {
                Text = "✏",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateNotes(notesItem);
            cardPanel.Controls.Add(editIcon);

            // Title Label
            var titleLabel = new Label
            {
                Text = notesItem.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = titleColor,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(titleLabel);

            // Content Label
            var contentLabel = new Label
            {
                Text = notesItem.Content,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = contentColor,
                Location = new Point(10, 40),
                Size = new Size(350, 50),
                AutoSize = false
            };
            cardPanel.Controls.Add(contentLabel);

            // Date Label
            var dateLabel = new Label
            {
                Text = notesItem.UpdatedDate != default(DateTime)
            ? $"Last updated on: {notesItem.UpdatedDate:MMMM dd, yyyy hh:mm tt}"
            : $"Added on: {notesItem.CreatedDate:MMMM dd, yyyy hh:mm tt}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.White,
                Location = new Point(10, 90),
                AutoSize = true
            };
            cardPanel.Controls.Add(dateLabel);

            // View Details Button
            var viewDetailsButton = new Button
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = buttonBackgroundColor,
                ForeColor = buttonTextColor,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 30),
                Location = new Point(cardPanel.Width - 120, cardPanel.Height - 40)
            };
            viewDetailsButton.FlatAppearance.BorderSize = 0;
            viewDetailsButton.Click += (sender, e) => ShowTaskDetails(notesItem);
            cardPanel.Controls.Add(viewDetailsButton);

            panelNotes.Controls.Add(cardPanel);
        }






        private void ShowTaskDetails(NotesItem notesItem)
        {
            string details = $"Title: {notesItem.Title}\n\n" +
                             $"Content:\n{notesItem.Content}\n\n" +
                             $"Date Added: {notesItem.CreatedDate:MMMM dd, yyyy hh:mm tt}";

            MessageBox.Show(details, "Note Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void UpdateNotes(NotesItem notesItem)
        {
            var updateNotesForm = new UpdateNotesForm(notesItem);

           
            updateNotesForm.NoteUpdated += (updatedNote) =>
            {
                
                _notesController.UpdateNotes(updatedNote); 
                LoadNotes();
                MessageBox.Show("Note updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            updateNotesForm.ShowDialog();
        }


        private void DeleteNotes(NotesItem notesItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {notesItem.Title}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _notesController.DeleteNotes(notesItem.Id);
                LoadNotes(); 
            }


        }

        private void btnAddNotes_Click_1(object sender, EventArgs e)
        {
            
            var addNotesForm = new AddNotesForm();
            addNotesForm.NotesAdded += LoadNotes;
            addNotesForm.ShowDialog();
        }
    }
}
