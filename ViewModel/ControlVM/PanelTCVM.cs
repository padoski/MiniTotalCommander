using Commander.ViewModel.Commands;
using Commander.ViewModel.WindowVM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace Commander.ViewModel.ControlVM
{
    using R = Properties.Resources;

    class PanelTCVM : BaseVM
    {
        #region properties

        private List<string> contentOriginal;
        private int foldersCount;
        private int deepIndex;

        public event Action InteractionEvent;

        private string path;

        public string Path
        {
            get
            {
                return path;
            }
            private set
            {
                path = value;
                UpdateContent();
                OnPropertyChanged(nameof(Path));
            }
        }

        private string selectedFile;

        public string SelectedFile
        {
            get
            {
                return selectedFile;
            }
            private set
            {
                selectedFile = value;
                OnPropertyChanged(nameof(selectedFile));
            }
        }



        private int selectedDriveIndex;

        public int SelectedDriveIndex
        {
            get
            {
                return selectedDriveIndex;
            }
            set
            {
                selectedDriveIndex = value;
                deepIndex = 0;
                Path = Drivers[SelectedDriveIndex];
                Console.WriteLine(Path);
                OnPropertyChanged(nameof(SelectedDriveIndex));
            }
        }

        private string errorText;

        public string ErrorText
        {
            get
            {
                return errorText;
            }
            private set
            {
                errorText = value;
                OnPropertyChanged(nameof(ErrorText));
            }
        }


        private List<string> drivers;

        public List<string> Drivers
        {
            get
            {
                return drivers;
            }
            private set
            {
                drivers = value;
                OnPropertyChanged(nameof(Drivers));
            }
        }

        private List<string> content;
        public List<string> Content
        {
            get
            {
                return content;
            }
            private set
            {
                content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        #endregion

        private ICommand pathSelectCommand;

        public ICommand PathSelectCommand
        {
            get
            {
                return pathSelectCommand ?? (pathSelectCommand = new CommandHandlerParameter(Click, () => { return true; }));
            }

        }

        private void Click(int index)
        {
            if (index == -1)
            {
                return;
            }
            InteractionEvent?.Invoke();
            ErrorText = string.Empty;

            if (deepIndex == 0) 
            {
                if (index < foldersCount)
                {

                    deepIndex++;
                    Path = contentOriginal[index];
                    SelectedFile = string.Empty;
                }
                else
                {
                    SelectedFile = contentOriginal[index];
                }
            }
            else
            {
                if (index == 0)
                {
                    deepIndex--;
                    Path = System.IO.Path.GetDirectoryName(Path);
                    SelectedFile = string.Empty;
                }
                else if (index <= foldersCount)
                {
                    deepIndex++;
                    Path = contentOriginal[index - 1];
                    SelectedFile = string.Empty;
                }
                else
                {
                    SelectedFile = contentOriginal[index - 1];
                }
            }
        }

        public PanelTCVM()
        {
            Drivers = Directory.GetLogicalDrives().OfType<string>().ToList();
            SelectedDriveIndex = 0;
            deepIndex = 0;
            Path = Drivers[SelectedDriveIndex];
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>")]
        public void UpdateContent()
        {
            List<string> folders;
            try
            {
                folders = Directory.GetDirectories(Path).OfType<string>().ToList();
            }
            catch (UnauthorizedAccessException)
            {
                ErrorText = R.lack_of_acces;
                deepIndex--;
                return;
            }

            foldersCount = folders.Count;
            List<string> files = Directory.GetFiles(Path).OfType<string>().ToList();
            contentOriginal = folders.Concat(files).ToList();


            for (int i = 0; i < folders.Count; i++)
            {
                folders[i] = "<" + folders[i][0] + ">" + folders[i].Substring(3);
            }

            for (int i = 0; i < files.Count; i++)
            {
                files[i] = files[i].Substring(3);
            }


            if (deepIndex > 0)
            {

                List<string> buff = new List<string>()
                {
                    R.folder_up
                };
                Content = buff.Concat(folders.Concat(files).ToList()).ToList();
            }
            else
            {
                Content = folders.Concat(files).ToList();
            }
        }
    }
}
