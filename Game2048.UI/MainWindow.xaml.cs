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

namespace Game2048.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{
    public MainWindow() {
        InitializeComponent();
    }

    private void MainWindow_OnKeyDown(object sender, KeyEventArgs e) {
        switch (e.Key) {
            case Key.W: Up(); break;
        }
       
        
    }

    void Up() {
        if (Button4_1.Content.ToString() != "") {
            if (Button4_1.Content.ToString() == Button3_1.Content.ToString()) {
                Button3_1.Content = (int.Parse(Button3_1.Content.ToString()) + int.Parse(Button4_1.Content.ToString())).ToString();
                Button4_1.Content = "";
                Button4_1.Style = Resources["BtnDefault"] as Style;
                switch (int.Parse(Button3_1.Content.ToString())) {
                    case 4: Button3_1.Style = Resources["Btn4"] as Style; break;
                    case 8: Button3_1.Style = Resources["Btn8"] as Style; break;
                    case 16: Button3_1.Style = Resources["Btn16"] as Style; break;
                    case 32: Button3_1.Style = Resources["Btn32"] as Style; break;
                    case 64: Button3_1.Style = Resources["Btn64"] as Style; break;

                }
            }
        }


        for (int i = 0; i < 4; i++) {
        }
    }
}