using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoList.Helper.EnumHelper;

namespace TodoList.Model
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TodoTitle { get; set; }
        public string  TodoDescription { get; set; }
        public DateTime  CreateDate{ get; set; }
        public DateTime UpdateDate { get; set; }
        public TodoEnumStatus Status{ get; set; }
        public virtual User User{ get; set; }
    }
}
