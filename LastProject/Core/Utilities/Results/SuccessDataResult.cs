namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        

        public SuccessDataResult(string message, T data) : base(true, message, data)
        {
        }

        public SuccessDataResult(T data) : base(true, data)
        {
        }

        //public SuccessDataResult(string successfulLogin)
        //{
        //    this.successfulLogin = successfulLogin;
        //    this.status = status;
        //}
    }
}