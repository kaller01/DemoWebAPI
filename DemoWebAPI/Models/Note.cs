using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models
{
    public class Note
    {
        public int Id { get; set; } = 0;
        public string Text { get; set; } = "";
        public DateTime Created = DateTime.UtcNow;
        private DateTime todo;

        public DateTime Todo { get => todo; set => todo = value; }
    }
}