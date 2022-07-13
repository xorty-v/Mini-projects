using System;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Threading;

namespace QR_AttendanceControl
{
    public partial class Scanner : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private ZXing.BarcodeReader reader;
        private SoundPlayer player;
        private string previousId;

        public Scanner()
        {
            InitializeComponent();
        }
        private void Scanner_Load(object sender, EventArgs e)
        {
            // qr-код
            reader = new ZXing.BarcodeReader();
            reader.Options.PossibleFormats = new List<ZXing.BarcodeFormat>();
            reader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);

            //Вывод и получение списка видеоустройств
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo divece in videoDevices)
                    lbCams.Items.Add(divece.Name);
            }

            //Видеоустройство по умолчанию 
            lbCams.SelectedIndex = 0;
        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[lbCams.SelectedIndex].MonikerString);
            videoSource.NewFrame += video_NewFrame;
            videoSource.Start();
            btn_Scan.Enabled = false;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbWebCam.Image = (Bitmap)eventArgs.Frame.Clone(); // вывод изображения на PictherBox
            ZXing.Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone()); // распознание qr-код'a

            if (result == null)
                return;

            if (DataBase.CheckingId(result.Text))
                return;

            if (!CheckPreviousId(result.Text))
            {
                player = new SoundPlayer(@"C:\Users\Рамази\source\repos\QR-AttendanceControl\QR-AttendanceControl\bin\Debug\yess.wav");
                player.Play();

                Thread.Sleep(1000);
                Student student = new Student(result.Text);
                DataBase.AddStudentFromAttendance(student);
            }

            previousId = result.Text;
        }

        private bool CheckPreviousId(string id)
        {
            return previousId == id;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();

            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

            this.Close();
            authorisation.Show();
        }

    }
}
