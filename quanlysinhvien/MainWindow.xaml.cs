using quanlysinhvien.Models;
using System.Net;
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

namespace quanlysinhvien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly QuanLySinhVienContext _context;
        public MainWindow()
        {
            InitializeComponent();
           
            //_context = new QuanLySinhVienContext();
            //loadData()/*;*/
            _context  = new QuanLySinhVienContext();
            loadData();
        }

        private void dgSinhvien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
       private void loadData()
        {
            dgSinhVien.ItemsSource = _context.SinhViens.ToList();
        }
    }
}