using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.NavBar;
using System.Windows.Controls.Primitives;
using DevExpress.Xpf.Core;

namespace NavBarToolTip {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void ExplorerBarView_ItemSelected(object sender, DevExpress.Xpf.NavBar.NavBarItemSelectedEventArgs e) {

        }

        private void NavBarControl_MouseMove(object sender, MouseEventArgs e) {
            NavBarControl nb = sender as NavBarControl;
            tooltip.IsOpen = false;
            Cursor = Cursors.Arrow;

            NavBarItem nbItem = nb.View.GetNavBarItem(e);
            NavBarGroup nbGroup = nb.View.GetNavBarGroup(e);
            if (nbItem == null && nbGroup != null) {
                tooltip_text.Text = string.Format("Header = {0}\n", nbGroup.Header);
                tooltip.Placement = PlacementMode.Mouse;
                tooltip.IsOpen = true;
                Cursor = Cursors.Hand;
            }
            if (nbItem != null) {
                tooltip_text.Text = string.Format("Name = {0}\n", nbItem.Content);
                tooltip.Placement = PlacementMode.Mouse;
                tooltip.IsOpen = true;
                Cursor = Cursors.Hand;
            }

        }

        private void NavBarControl_MouseLeave(object sender, MouseEventArgs e) {
            tooltip.IsOpen = false;
        }
    }
}
