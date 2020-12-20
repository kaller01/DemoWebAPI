using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class NoteProcessor
    {
        public static int CreateNote(int id, string text, DateTime todo)
        {
            NoteModel data = new NoteModel {Text = text, Todo = todo };

            string sql = @"insert into test.dbo.Notes (Text, Todo) values (@Text, @Todo);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<NoteModel> LoadNotes()
        {
            string sql = @"select Id, Text, Todo from dbo.Notes;";

            return SqlDataAccess.LoadData<NoteModel>(sql);
        }
    }
}
