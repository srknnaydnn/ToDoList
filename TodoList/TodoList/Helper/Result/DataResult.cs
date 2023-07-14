namespace TodoList.Helper.Result
{
    public class DataResult<T>:Result where T : class
    {
        public T Data { get; set; }

        public DataResult(T data,string message,bool success ):base(message,success)
        {
            Data = data;
        }
    }
}
