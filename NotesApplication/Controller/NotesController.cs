using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApplication.Models;
using NotesApplication.Services;
using NotesApplication.Forms;
using NotesApplication.DAO;

namespace NotesApplication.Controller
{
    public class NotesController
    {
        private readonly NotesServices _notesServices;

        public NotesController(NotesServices notesServices)
        {
            _notesServices = notesServices;
        }
        public List<NotesItem> GetAllNotes()
        {
            return _notesServices.GetAllNotes();
        }

        public NotesItem GetNotesById(int id)
        {
            return _notesServices.GetNotesById(id);
        }

        public void AddNotes(string notesTitle, string notesContent, DateTime createdDate)
        {
            var notesItem = new NotesItem
            {
                Title = notesTitle,
                Content = notesContent,
                CreatedDate = createdDate
            };
            _notesServices.AddNotes(notesItem);
        }

        public void UpdateNotes(NotesItem updatedNote)
        {
            var notesItem = _notesServices.GetNotesById(updatedNote.Id);
            if (notesItem != null)
            {
                notesItem.Title = updatedNote.Title;
                notesItem.Content = updatedNote.Content;
                notesItem.UpdatedDate = DateTime.Now;  // You can auto-set this to current date
                _notesServices.UpdateNotes(notesItem);
            }
        }




        public void DeleteNotes(int id)
        {
            _notesServices.DeleteNotes(id);
        }
    }
}
