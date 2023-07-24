namespace TodoList.Helper.Result
{
    public class ErrorDataResult<T>:DataResult<T> where T : class
    {
        public ErrorDataResult(T data,string message):base(data,message,false)
        {
            
        }
    }
}
