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

using devDept.Eyeshot;
using devDept.Eyeshot.Control;
using devDept.Eyeshot.Entities;
using devDept.Geometry;


namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            design1.ContentRendered += new EventHandler(design1_ContentRendered);
        }

        private void design1_ContentRendered(object sender, EventArgs e)
        {
            // Creates a mesh with the shape of a box
            Mesh m = Mesh.CreateBox(30, 20, 10);

            // Adds the mesh to the master entity collection
            design1.Entities.Add(m, System.Drawing.Color.DarkRed);

            // Fits the drawing in the viewport
            design1.ZoomFit();
        }

    }
}