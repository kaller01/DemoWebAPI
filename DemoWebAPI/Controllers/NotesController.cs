using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLibrary;
using static DataLibrary.BusinessLogic.NoteProcessor;
using DataLibrary.Models;

namespace DemoWebAPI.Controllers
{
    public class NotesController : ApiController
    {
        List<Note> notes = new List<Note>();
        int LastUsedId = 0;

        public NotesController()
        {
            notes.Add(new Note { Text = "Learn C#", Todo = DateTime.UtcNow.AddDays(1), Id = LastUsedId });
            LastUsedId++;
            notes.Add(new Note { Text = "Learn .NET", Todo = DateTime.UtcNow.AddMonths(5), Id = LastUsedId });
            LastUsedId++;
            notes.Add(new Note { Text = "Write down languages", Todo = DateTime.UtcNow.AddHours(5), Id = LastUsedId });
            LastUsedId++;
        }

        // GET: api/Notes
        public List<NoteModel> Get()
        {
            return LoadNotes();
        }

        // GET: api/Notes/5
        public Note Get(int id)
        {
            return notes.Where(note => note.Id == id).FirstOrDefault();
        }

        // POST: api/Notes
        public void Post([FromBody] Note value)
        {
            CreateNote(value.Id, value.Text, value.Todo);
        }

        // PUT: api/Notes/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Notes/5
        public void Delete(int id)
        {
        }
    }
}
