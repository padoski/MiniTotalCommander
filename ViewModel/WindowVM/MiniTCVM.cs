using Commander.ViewModel.Commands;
using Commander.ViewModel.ControlVM;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace Commander.ViewModel.WindowVM
{
    using R = Properties.Resources;

    class MiniTCVM : BaseVM
    {

        #region properties

        private readonly PanelTCVM LeftPanel = new PanelTCVM();
        private readonly PanelTCVM RightPanel = new PanelTCVM();

        private string copyError;

        public string CopyError
        {
            get
            {
                return copyError;
            }
            private set
            {
                copyError = value;
                OnPropertyChanged(nameof(CopyError));
            }
        }

        private string succesfullCopy;

        public string SuccesfullCopy
        {
            get
            {
                return succesfullCopy;
            }
            private set
            {
                succesfullCopy = value;
                OnPropertyChanged(nameof(SuccesfullCopy));

            }
        }

        private ObservableCollection<PanelTCVM> panels;

        public ObservableCollection<PanelTCVM> Panels
        {
            get
            {
                return panels;
            }
            private set
            {
                panels = value;
                OnPropertyChanged(nameof(Panels));
            }
        }

        #endregion

        #region commands

        private ICommand copyCommand;

        public ICommand CopyCommand
        {
            get
            {
                return copyCommand ?? (copyCommand = new CommandHandler(Copy, CanCopy));
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>")]
        private void Copy()
        {
            Console.WriteLine($"Kopiowanie pliku: {LeftPanel.SelectedFile} do: {RightPanel.Path}");
            try
            {
                File.Copy(LeftPanel.SelectedFile, Path.Combine(RightPanel.Path, Path.GetFileName(LeftPanel.SelectedFile)));
                SuccesfullCopy = string.Format(R.copy_succed, LeftPanel.SelectedFile, RightPanel.Path);
                CopyError = string.Empty;
                LeftPanel.UpdateContent();
                RightPanel.UpdateContent();
            }
            catch (Exception)
            {
                Console.WriteLine("Nie można skopiować");
                CopyError = string.Format(R.copy_error, LeftPanel.SelectedFile, RightPanel.Path);
                SuccesfullCopy = string.Empty;
            }
        }

        private bool CanCopy()
        {
            if (!string.IsNullOrEmpty(LeftPanel.SelectedFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region events binding

        private void ClearInfo()
        {
            CopyError = string.Empty;
            SuccesfullCopy = string.Empty;
        }

        #endregion



        public MiniTCVM()
        {
            LeftPanel.InteractionEvent += ClearInfo;
            RightPanel.InteractionEvent += ClearInfo;

            Panels = new ObservableCollection<PanelTCVM>
            {
                LeftPanel,
                RightPanel
            };
        }
    }
}
