using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApplication.DAO;
using NotesApplication.Models;

namespace NotesApplication.Services
{
    public class NotesServices
    {
        private readonly NotesRepository _notesRepository;
        public NotesServices(NotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public List<NotesItem> GetAllNotes()
        {
            return _notesRepository.GetAllNotes();
        }
        public NotesItem GetNotesById(int id)
        {
            return _notesRepository.GetNotesById(id);
        }
        public void AddNotes(NotesItem notesItem)
        {
            _notesRepository.AddNotes(notesItem);
        }
        public void DeleteNotes(int id)
        {
            _notesRepository.DeleteNotes(id);
        }
        public void UpdateNotes(NotesItem notesItem)
        {
            _notesRepository.UpdateNotes(notesItem);
        }
    }
}
