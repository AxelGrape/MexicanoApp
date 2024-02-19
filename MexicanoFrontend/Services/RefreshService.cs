namespace MexicanoFrontend.Services
{
    public interface IRefreshService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }

    public class RefreshService : IRefreshService
    {
        public event Action? RefreshRequested;
        public void CallRequestRefresh()
        {
            if(RefreshRequested != null )   
            RefreshRequested?.Invoke();
        }
    }
}
