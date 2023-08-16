﻿namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public Result(bool success)
        {
            Success = success;
        }

        public Result(bool success, string message) : this(success)
        {

            Message = message;
        }
    }
}

