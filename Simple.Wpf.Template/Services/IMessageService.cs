namespace Simple.Wpf.Template.Services
{
    using System;
    using ViewModels;

    public interface IMessageService
    {
        IObservable<MessageViewModel> Show { get; }

        void Post(string header, CloseableViewModel viewModel, IDisposable lifetime);
    }
}