using System;

namespace UapDemo.Models
{
    public class TaskModel
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
