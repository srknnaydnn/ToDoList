namespace TodoList.Helper.Result
{
    public class Result
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public Result(string message, bool success)
        {
            Message = message;
            Success = success;
        }
    }
}
