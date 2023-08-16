namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string message) : base(false, message)
        {
        }

        public ErrorDataResult(T data) : base(false, data)
        {
        }
    }
}

