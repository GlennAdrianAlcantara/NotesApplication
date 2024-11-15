using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApplication.Data;
using NotesApplication.Models;

namespace NotesApplication.DAO
{
    public class NotesRepository
    {
        private readonly ApplicationDbContext _context;

        public NotesRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<NotesItem> GetAllNotes()
        {
            return _context.NotesItems.ToList();
        }

        public NotesItem GetNotesById(int id)
        {
            return _context.NotesItems.Find(id);
        }

        public void AddNotes(NotesItem notesItem)
        {
            _context.NotesItems.Add(notesItem);
            _context.SaveChanges();
        }
        public void UpdateNotes(NotesItem notesItem)
        {
            _context.NotesItems.Update(notesItem);
            _context.SaveChanges();
        }
        public void DeleteNotes(int id)
        {
            var notes = _context.NotesItems.Find(id);
            if (notes != null)
            {
                _context.NotesItems.Remove(notes);
                _context.SaveChanges();
            }
        }
    }
}
