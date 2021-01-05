using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                listBox.Items.Add(drive);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "Text Document (.txt)|*.txt";
            if (ofd.ShowDialog()==true)
            {
                string filename = ofd.FileName;
                textBox.Text = filename;
                textBox1.Text = File.ReadAllText(filename);
            }*/

            //Unidades de almacenamiento
            ///listBox.Items.Clear();
            
            

            //Carpetas
            /*string sourceDirectory = @"E:\";
            var txtFiles = Directory.GetFiles(sourceDirectory);
            textBox.Text = txtFiles[0];*/

            //Archivos
            /*string path = @"e:\Bryan\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    textBox.Text+=s ;
                }
            }*/



        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBox2.Items.Clear();
            try
            {
                DriveInfo drive = (DriveInfo)listBox.SelectedItem;
                foreach (DirectoryInfo dir in drive.RootDirectory.GetDirectories())
                {
                    listBox2.Items.Add(dir);
                }
                foreach (FileInfo file in drive.RootDirectory.GetFiles())
                {
                    listBox2.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"list2");               
            }           

        }

        /*private void listBox2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            listBox2.Items.Clear();
            try
            {                
                DirectoryInfo directory = (DirectoryInfo)listBox2.SelectedItem;
                string path = Path.GetFullPath(directory.FullName);
                foreach (string subdir in Directory.EnumerateDirectories(path))
                {
                    listBox2.Items.Add(subdir);
                }
                foreach (string file in Directory.EnumerateFiles(path))
                {
                    listBox2.Items.Add(file);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);               
            }       
        }*/
        private void listBox2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            listBox3.Items.Clear();
            try
            {
                DirectoryInfo directory = (DirectoryInfo)listBox2.SelectedItem;
                foreach (FileInfo file in directory.GetFiles())
                {
                    listBox3.Items.Add(file);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+"list2");
            }

        }

        private void listBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                FileInfo file = (FileInfo)listBox3.SelectedItem;
                textBox.Text = file.Name;
                textBox2.Text = File.ReadAllText(file.FullName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "list3");
            }


        }
    }
}
