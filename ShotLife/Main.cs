using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Drawing.Imaging;

using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Microsoft.Win32;
namespace ShotLife
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Visible = false;
            shotTimer.Interval =Convert.ToInt16(GetSettingsValue("Frequency"))*60*1000;
            Start();
        }

        private void Start()
        {
            shotTimer.Stop();
            shotTimer.Start();
        }
        private void Stop()
        {
            shotTimer.Stop();
        }
        private void ShowConfig()
        {
            Config frmConfig = new Config();
            frmConfig.Show();
        }
        private void Exit()
        {
            Application.Exit();
        }

        private void shotTimer_Tick(object sender, EventArgs e)
        {
            ShotScreen();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void tsmConfig_Click(object sender, EventArgs e)
        {
            ShowConfig();
        }

        private void Main_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        string wholeFileName = string.Empty;
        private void ShotScreen()
        {
   
            Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format16bppRgb555);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                                        0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

           

            string savePath =  GetSettingsValue("SavePath");
            if (string.IsNullOrEmpty(savePath))
            {
               savePath= Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar;
            }
            string fileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".jpg";
             wholeFileName = savePath + fileName;
             string compressedFileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "_Compressed.jpg";
             string wholeCompressedFileName = savePath + compressedFileName;
           //  bmpScreenshot.Save(wholeCompressedFileName, codeInfo, encoderParams);
            bmpScreenshot.Save(wholeFileName);
            /*
            string smallFileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "_thum.jpg";
            string wholeSmallFile = savePath + smallFileName;
            PHComponents.PHGraphic.MakeSmallPic(wholeFileName, wholeSmallFile, bmpScreenshot.Width, bmpScreenshot.Height, "HW");
             */

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(SendMail));
            t.Start();
        }
        private void SendMail()
        {
           SendMail(wholeFileName);
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void SendMail(string wholeFileName)
        {
            SmtpClient smtp = new SmtpClient();

            smtp.Host = GetSettingsValue("SmtpServer");
            PHComponents.SCCrypto crypt = new PHComponents.SCCrypto();
//
            smtp.Credentials = new NetworkCredential(GetSettingsValue("MailUserName"),crypt.Decrypting(GetSettingsValue("MailPassword")));
        //    smtp.Credentials = new NetworkCredential(GetSettingsValue("MailUserName"), GetSettingsValue("MailPassword"));

            MailMessage mail = new MailMessage(GetSettingsValue("MailTo"), GetSettingsValue("MailTo"), "ShotLife", "ShotLife");
            Attachment file = new Attachment(wholeFileName);
            mail.Attachments.Add(file);
            smtp.Send(mail);

        }

        private void tsmStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void tsmStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ShotScreen();
        }

        private void tsmOpenMainForm_Click(object sender, EventArgs e)
        {

        }
        private string GetSettingsValue(string propName)
        {
            return (string) Properties.Settings.Default[propName];
        }

        private void Main_MinimumSizeChanged_1(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        

           MessageBox.Show("a");

        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }
    }
}
