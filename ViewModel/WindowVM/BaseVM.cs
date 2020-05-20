using System.ComponentModel;


namespace Commander.ViewModel.WindowVM
{
    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(params string[] namesOfProperties)
        {
            if (PropertyChanged != null)
            {
                foreach (string prop in namesOfProperties)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
                }
            }
        }
    }
}
