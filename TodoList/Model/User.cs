﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}
