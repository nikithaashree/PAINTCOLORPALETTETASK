
using System.Windows;
using System.Windows.Input;



namespace PAINT_COLOUR_PALETTE_TASK_31._07._23
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lblcrimson_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblcrimson.Background; 
        }

        private void lblkhaki_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
lblmain.Background = lblkhaki.Background;
        }

        private void lbldarkgoldenrod_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
lblmain.Background=lbldarkgoldenrod.Background;
        }

        private void lbldarkseagreen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
lblmain.Background=lbldarkseagreen.Background;
        }

        private void lblbisque_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
lblmain.Background= lblbisque.Background;
        }

        private void lblaquamarine_MouseEnter(object sender, MouseEventArgs e)
        {
lblmain.Background= lblaquamarine.Background;
        }

        private void lbldarkgreen_MouseEnter(object sender, MouseEventArgs e)
        {
            lblmain.Background = lbldarkgreen.Background;
        }

        private void lbldarkred_MouseEnter(object sender, MouseEventArgs e)
        {
            lblmain.Background = lbldarkred.Background;
        }

        private void lblburlywood_MouseLeave(object sender, MouseEventArgs e)
        {
            lblmain.Background = lblburlywood.Background;
        }

        private void lbldarkviolet_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            lblmain.Background=lbldarkviolet.Background;
        }

        private void lbldarkslateblue_MouseMove(object sender, MouseEventArgs e)
        {
lblmain.Background = lbldarkslateblue.Background;
        }

        private void lbllemonchiffon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background= lbllemonchiffon.Background;
        }
    }

}
