﻿namespace fashionManager.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException(string mensagem)
            : base(mensagem) { }
    }
}
