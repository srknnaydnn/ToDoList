using TodoList.Helper.EnumHelper;

namespace TodoList.Model.Dto
{
    public class TodoItemForUpdate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TodoTitle { get; set; }
        public string TodoDescription { get; set; }
        public DateTime UpdateDate { get; set; }

        public TodoEnumStatus Status { get; set; }
    }
}
