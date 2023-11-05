﻿using System.ComponentModel.DataAnnotations;
namespace ToDoAI.Models
{
    public class InputFields
    {
        public int Id { get; set; }

        public string? ToDo { get; set; }

        public string? TypeOfHelp { get; set; }

        public DateTime DateTime { get; set; }
    }
}
