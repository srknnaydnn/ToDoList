namespace TodoList.Helper.Result
{
    public class SuccesDataResult<T> : DataResult<T> where T : class
    {
        public SuccesDataResult(T data,string message):base(data,message,true)
        {
            
        }
      
    }
}
