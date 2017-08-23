namespace Anuitex.Library.Presenters
{
    public class MainPresenter
    {
        private readonly MainForm view;

        public MainPresenter(MainForm view)
        {
            this.view = view;
        }

        public void Run()
        {
            view.Show();
        }
    }
}