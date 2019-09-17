using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Models
{
    public class PlaygroundWindow : BaseModel
    {
        private Visibility _Content_GridSplitter_Visibility { get; set; }
        public Visibility Content_GridSplitter_Visibility
        {
            get
            {
                return _Content_GridSplitter_Visibility;
            }
            set
            {
                _Content_GridSplitter_Visibility = value;
                base.NotifyPropertyChanged("Content_GridSplitter_Visibility");
            }
        }

        private Visibility _Sidebar_Grid_Visibility { get; set; }
        public Visibility Sidebar_Grid_Visibility
        {
            get
            {
                return _Sidebar_Grid_Visibility;
            }
            set
            {
                _Sidebar_Grid_Visibility = value;
                base.NotifyPropertyChanged("Sidebar_Grid_Visibility");
            }
        }

        public string WindowTitle
        {
            get
            {
                return "Local Git Manager";
            }
        }
    }
}
