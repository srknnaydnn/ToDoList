using TodoList.Helper.EnumHelper;

namespace TodoList.Model.Dto
{
    public class TodoItemForAdd
    {
        public int UserId { get; set; }
        public string TodoTitle { get; set; }
        public string TodoDescription { get; set; }
        public DateTime CreateDate { get; set; }     
        public TodoEnumStatus Status { get; set; }
        
    }
}
