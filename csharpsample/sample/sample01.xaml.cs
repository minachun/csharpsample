using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace csharpsample.sample
{
    /// <summary>
    /// sample01.xaml の相互作用ロジック
    /// </summary>
    public partial class sample01 : Window
    {
        public sample01()
        {
            this.clist = new List<Color> { Colors.AliceBlue, Colors.Aqua, Colors.Beige, Colors.Cornsilk, Colors.ForestGreen, Colors.Gold };
            this.cindex = 0;
            this.btncolor = new SolidColorBrush(this.clist[this.cindex]);
            InitializeComponent();
            this.DataContext = this;
        }

        private Brush _btncolor;
        public Brush btncolor
        {
            get => _btncolor;
            set
            {
                _btncolor = value;
            }
        }

        private int cindex = 0;
        private List<Color> clist;

        private void countupbtn_Click(object sender, RoutedEventArgs e)
        {
            this.cindex += 1;
            if ( this.cindex >= this.clist.Count )
            {
                this.cindex = 0;
            }
            this.btncolor = new SolidColorBrush(this.clist[this.cindex]);
        }
    }
}
