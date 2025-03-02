﻿namespace Back1.ViewModels
{
    public class UserManagerResponse
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        public string role { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public DateTime? ExpireDate { get; set; }
    }
}
