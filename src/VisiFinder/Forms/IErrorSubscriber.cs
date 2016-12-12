namespace VisiFinder.Forms
{
    using System;

    public interface IErrorSubscriber
    {
        void RegisterError(Exception lastError);
    }
}