using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MatzaAvatarGenerator
{
    public partial class frmMain : CustomForm
    {
        Image photo;
        Image avatar;

        public frmMain()
        {
            Program.IsRunning = true;

            InitializeComponent();
            lblVersion.Text += Application.ProductVersion;
            cmbFlag.SelectedIndex = 0;
            cmbBorder.SelectedIndex = 0;
            cmbFootstep.SelectedIndex = 0;

            foreach (Control ctrl in Controls)
            {
                ctrl.MouseDown += delegate { Cursor = CustomCursor.Load("Default_Pressed.CUR"); };
                ctrl.MouseUp += delegate { Cursor = CustomCursor.Load("Default.CUR"); };
            }
            MouseDown += delegate { Cursor = CustomCursor.Load("Default_Pressed.CUR"); };
            MouseUp += delegate { Cursor = CustomCursor.Load("Default.CUR"); };

            Cursor = CustomCursor.Load("Default.CUR");

            VersionChecker.CheckVersion(true);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OFD.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.GIF|All files (*.*)|*.*";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                //photo = ResizeImage(Image.FromFile(OFD.FileName), 308, 308);
                photo = Image.FromFile(OFD.FileName);
                pbPhoto.BackgroundImage = photo;
                pbPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                grpAvatar.Enabled = true;
            }
        }

        private Image ResizeImage(Image imgOriginal, int width, int height)
        {
            Bitmap imgResized = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(imgResized))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                g.DrawImage(imgOriginal, new Rectangle(0, 0, width, height));
            }

            return imgResized;
        }
        private Image GenerateAvatar(Image img, string text)
        {
            Bitmap bmp = new Bitmap(400, 400);
            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            SolidBrush b = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(bmp);
            StringFormat sf = new StringFormat();
            //sf.Alignment = StringAlignment.Center;
            //sf.LineAlignment = StringAlignment.Center;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            switch(cmbBorder.SelectedIndex)
            {
                case 0:
                    g.DrawImage(img, new Rectangle(46, 46, 308, 308));
                    g.DrawImage(Properties.Resources.Border_Blue, r);
                    break;
                case 1:
                    g.DrawImage(img, new Rectangle(46, 46, 308, 308));
                    g.DrawImage(Properties.Resources.Border_Pink , r);
                    break;
                default:
                    g.DrawImage(img, r);
                    break;
            }

            switch(cmbFootstep.SelectedIndex)
            {
                case 0:
                    g.DrawImage(Properties.Resources.Footstep_Pink , r);
                    break;
                case 1:
                    g.DrawImage(Properties.Resources.Footstep_Blue, r);
                    break;
                default:
                    break;
            }

            switch (cmbFlag.SelectedIndex)
            {
                case 0:
                    g.DrawImage(Properties.Resources.Flag_Left, r);
                    break;
                case 1:
                    g.DrawImage(Properties.Resources.Flag_Right, r);
                    break;
                default:
                    break;
            }

            //g.DrawString(txtPosition.Text, f, Brushes.Black, new Rectangle(0, 351, 400, 36), sf);
            //g.DrawString(txtPosition.Text, f, b, new Rectangle(1, 350, 400, 42), sf);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath gp = new GraphicsPath();
            gp.AddString(txtPosition.Text, new FontFamily("Palatino Linotype"), (int)FontStyle.Bold, 36f,
                new Rectangle(1, 350, 400, 42), sf);

            g.DrawPath(new Pen(Brushes.Black, 3), gp);
            g.FillPath(b, gp);

            g.Dispose();

            return bmp;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            avatar = GenerateAvatar(photo, "nuci");
            pbAvatar.BackgroundImage = avatar;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "JPG Image (*.JPG)|*.JPG";
            SFD.Title = "Save Matza Avatar";
            SFD.FileName = ("Avatar" + new Random().Next(1000, 9999));
            SFD.InitialDirectory = Application.StartupPath;

            if (SFD.ShowDialog() == DialogResult.OK)
                try
                {
                    avatar.Save(SFD.FileName, ImageFormat.Bmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Am întâmpinat o eroare oleacă..." + Environment.NewLine + Environment.NewLine +
                        "'" + ex.Message + "'" + Environment.NewLine + Environment.NewLine +
                        "Încearcă să salvezi cu alt nume...", "Eroare :O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Process.Start("https://docs.google.com/document/d/1ZOumer5CNN_q82Gfx2oAg7T_qBiMu3DIWYWGRKqMBOA/pub");

            VersionChecker.CheckVersion();
        }
    }
}
