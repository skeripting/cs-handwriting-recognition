using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
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

namespace HandwritingRecognition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string GetPrediction(string imagePath)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "python", 
                Arguments = $"\"C:\\Users\\kusha\\source\\repos\\HandwritingRecognition\\digit-recognizer\\main.py\" \"{imagePath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(psi))
            {
                if (process == null)
                {
                    MessageBox.Show("Couldn't find the handwriting recognizer process!");
                    return "ERROR"; 
                }

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    return $"Error: {error}";
                }

                return output.Trim(); 
            }
        }

        private void OnUploadClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.BMP;*.GIF;)|*.PNG;*.JPG;*.BMP;*.GIF;|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                imagePreview.Source = new BitmapImage(new Uri(filePath));

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                string prediction = GetPrediction(filePath);

                predictedDigitLabel.Content = prediction;
            }
        }
    }
}