using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Commander.View
{

    public partial class PanelTCControl : UserControl
    {

        #region properties

        public string Path
        {
            get
            {
                return (string)GetValue(PathProperty);
            }
            set
            {
                SetValue(PathProperty, value);
            }
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(string), typeof(PanelTCControl), new PropertyMetadata(null));


        public List<string> Drivers
        {
            get
            {
                return (List<string>)GetValue(DriversProperty);
            }
            set
            {
                SetValue(DriversProperty, value);
            }
        }

        public static readonly DependencyProperty DriversProperty =
            DependencyProperty.Register("Drivers", typeof(List<string>), typeof(PanelTCControl), new PropertyMetadata(null));


        public List<string> PathContent
        {
            get
            {
                return (List<string>)GetValue(PathContentProperty);
            }
            set
            {
                SetValue(PathContentProperty, value);
            }
        }

        public static readonly DependencyProperty PathContentProperty =
            DependencyProperty.Register("PathContent", typeof(List<string>), typeof(PanelTCControl), new PropertyMetadata(null));


        public int SelectedDriveIndex
        {
            get
            {
                return (int)GetValue(SelectedDriveIndexProperty);
            }
            set
            {
                SetValue(SelectedDriveIndexProperty, value);
            }
        }

        public static readonly DependencyProperty SelectedDriveIndexProperty =
            DependencyProperty.Register("SelectedDriveIndex", typeof(int), typeof(PanelTCControl), new PropertyMetadata(null));


        public string ErrorText
        {
            get
            {
                return (string)GetValue(ErrorTextProperty);
            }
            set
            {
                SetValue(ErrorTextProperty, value);
            }
        }

        public static readonly DependencyProperty ErrorTextProperty =
            DependencyProperty.Register("ErrorText", typeof(string), typeof(PanelTCControl), new PropertyMetadata(null));



        public string SelectedFile
        {
            get
            {
                return (string)GetValue(SelectedFileProperty);
            }
            set
            {
                SetValue(SelectedFileProperty, value);
            }
        }

        public static readonly DependencyProperty SelectedFileProperty =
            DependencyProperty.Register("SelectedFile", typeof(string), typeof(PanelTCControl), new PropertyMetadata(null));



        public ICommand SelectPath
        {
            get
            {
                return (ICommand)GetValue(SelectPathProperty);
            }
            set
            {
                SetValue(SelectPathProperty, value);
            }
        }

        public static readonly DependencyProperty SelectPathProperty =
            DependencyProperty.Register("SelectPath", typeof(ICommand), typeof(PanelTCControl), new PropertyMetadata(null));

        #endregion

        public PanelTCControl()
        {
            InitializeComponent();

        }
    }
}
