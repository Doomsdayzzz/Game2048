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
    private Dictionary<string, Button> _tiles;
    private Dictionary<string, Style> _styles;
    public MainWindow() {
        InitializeComponent();
        _tiles = new Dictionary<string, Button>() {
            {nameof(Button1_1),Button1_1},
            {nameof(Button1_2),Button1_2},
            {nameof(Button1_3),Button1_3},
            {nameof(Button1_4),Button1_4},
            {nameof(Button2_1),Button2_1},
            {nameof(Button2_2),Button2_2},
            {nameof(Button2_3),Button2_3},
            {nameof(Button2_4),Button2_4},
            {nameof(Button3_1),Button3_1},
            {nameof(Button3_2),Button3_2},
            {nameof(Button3_3),Button3_3},
            {nameof(Button3_4),Button3_4},
            {nameof(Button4_1),Button4_1},
            {nameof(Button4_2),Button4_2},
            {nameof(Button4_3),Button4_3},
            {nameof(Button4_4),Button4_4}
        };
        _styles = new Dictionary<string, Style>() {
            {"default", (Style)Resources["BtnDefault"]},
            { "2", (Style)Resources["Btn2"] },
            { "4", (Style)Resources["Btn4"] },
            { "8", (Style)Resources["Btn8"] },
            { "16", (Style)Resources["Btn16"] },
            { "32", (Style)Resources["Btn32"] },
            { "64", (Style)Resources["Btn64"] },
            { "128", (Style)Resources["Btn128"] },
            { "256", (Style)Resources["Btn256"] },
            { "512", (Style)Resources["Btn512"] },
            { "1024", (Style)Resources["Btn1024"] },
            { "2048", (Style)Resources["Btn2048"] }
        };
    }

    private void MainWindow_OnKeyDown(object sender, KeyEventArgs e) {
        switch (e.Key) {
            case Key.W: Up(); break;
            case Key.S: Down(); break;
            case Key.A: Left(); break;
            case Key.D: Right(); break;
        }
       
        
    }

    void Up() {
        for (int k = 0; k < 4; k++) {
            for(int i = 2; i <= 4; i ++) {
                for (int j = 1; j <= 4; j++) {
                    if ((_tiles[$"Button{i - 1}_{j}"].Content.ToString() == "") & (_tiles[$"Button{i}_{j}"].Content.ToString() != "")) {
                        _tiles[$"Button{i - 1}_{j}"].Content = _tiles[$"Button{i}_{j}"].Content;
                        var numStyle = _tiles[$"Button{i}_{j}"].Content.ToString();
                        _tiles[$"Button{i-1}_{j}"].Style = _styles[$"{numStyle}"];
                        _tiles[$"Button{i}_{j}"].Content = "";
                        _tiles[$"Button{i}_{j}"].Style = _styles["default"];
                    }
                }
            }
        }
    }
    void Down() {
        for (int k = 0; k < 4; k++) {
            for(int i = 3; i >= 1; i --) {
                for (int j = 4; j >= 1; j--) {
                    if ((_tiles[$"Button{i + 1}_{j}"].Content.ToString() == "") & (_tiles[$"Button{i}_{j}"].Content.ToString() != "")) {
                        _tiles[$"Button{i + 1}_{j}"].Content = _tiles[$"Button{i}_{j}"].Content;
                        var numStyle = _tiles[$"Button{i}_{j}"].Content.ToString();
                        _tiles[$"Button{i + 1}_{j}"].Style = _styles[$"{numStyle}"];
                        _tiles[$"Button{i}_{j}"].Content = "";
                        _tiles[$"Button{i}_{j}"].Style = _styles["default"];
                    }
                }
            }
        }
    }
    void Left() {
        for (int k = 0; k < 4; k++) {
            for(int i = 1; i <= 4; i ++) {
                for (int j = 2; j <= 4; j++) {
                    if ((_tiles[$"Button{i}_{j-1}"].Content.ToString() == "") & (_tiles[$"Button{i}_{j}"].Content.ToString() != "")) {
                        _tiles[$"Button{i}_{j-1}"].Content = _tiles[$"Button{i}_{j}"].Content;
                        var numStyle = _tiles[$"Button{i}_{j}"].Content.ToString();
                        _tiles[$"Button{i}_{j-1}"].Style = _styles[$"{numStyle}"];
                        _tiles[$"Button{i}_{j}"].Content = "";
                        _tiles[$"Button{i}_{j}"].Style = _styles["default"];
                    }
                }
            }
        }
    }
    void Right() {
        for (int k = 0; k < 4; k++) {
            for(int i = 4; i >= 1; i--) {
                for (int j = 3; j >= 1; j--) {
                    if ((_tiles[$"Button{i}_{j+1}"].Content.ToString() == "") & (_tiles[$"Button{i}_{j}"].Content.ToString() != "")) {
                        _tiles[$"Button{i}_{j+1}"].Content = _tiles[$"Button{i}_{j}"].Content;
                        var numStyle = _tiles[$"Button{i}_{j}"].Content.ToString();
                        _tiles[$"Button{i}_{j+1}"].Style = _styles[$"{numStyle}"];
                        _tiles[$"Button{i}_{j}"].Content = "";
                        _tiles[$"Button{i}_{j}"].Style = _styles["default"];
                    }
                }
            }
        }
    }
}