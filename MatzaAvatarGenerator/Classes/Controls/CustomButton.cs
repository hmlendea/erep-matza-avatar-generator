using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MatzaAvatarGenerator
{
    class CustomButton : Control
    {
        public Color BorderColor { get; set; }
        public Color ShadowColor { get; set; }
        public string ButtonName;
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                Refresh();
            }
        } bool selected;
        public bool Clicked
        {
            get { return clicked; }
            set
            {
                clicked = value;
                Refresh();
            }
        } bool clicked;

        public CustomButton()
        {
            InitializeEvents();
            InitializeStyles();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            Width = 75;
            Height = 23;

            Font = new Font("Palatino Linotype", (int)(Height * 0.35), Font.Style);
            ForeColor = Color.Gold;
            BackColor = Color.DarkRed;
            BorderColor = ColorTranslator.FromHtml("#2F2E28");
            ShadowColor = Color.Black;
        }

        private void InitializeEvents()
        {
            base.MouseEnter += new System.EventHandler(this.base_MouseEnter);
            base.MouseLeave += new System.EventHandler(this.base_MouseLeave);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);
        }
        private void InitializeStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Image img;
            Font f = new Font(Font.FontFamily, Height / 3, Font.Style);
            Brush fb = new SolidBrush(ForeColor);
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(0, 0, Width, Height);
            string pathButtons = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Data\\GFX\\Panels\\Buttons\\";

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Selected == false)
                //if (Clicked == false)
                img = DrawingPlus.LoadImage("\\Panels\\Buttons\\" + ButtonName + "_Idle.PNG", false);
            //else
            //img = DrawingPlus.LoadImage("\\Panels\\Buttons\\" + ButtonName + "_Clicked.PNG", false);
            else
            {
                img = DrawingPlus.LoadImage("\\Panels\\Buttons\\" + ButtonName + "_Selected.PNG", false);
                f = new Font(f.FontFamily, f.Size + 1, f.Style | FontStyle.Underline);
            }
            if (Enabled == false)
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            if (img != null)
            {
                g.FillRectangle(new SolidBrush(BackColor), r);
                g.DrawImage(img, r);

                #region Universal Resize
                #region Cornder
                // Top-Left Corner
                g.DrawImage(img,
                    new Rectangle(0, 0, img.Width / 2, img.Height / 2),
                    new Rectangle(0, 0, img.Width / 2, img.Height / 2),
                    GraphicsUnit.Pixel);

                // Bottom-Left Corner
                g.DrawImage(img,
                    new Rectangle(0, Height - img.Height / 2, img.Width / 2, img.Height / 2),
                    new Rectangle(0, img.Height / 2, img.Width / 2, img.Height / 2),
                    GraphicsUnit.Pixel);

                // Top-Right Corner
                g.DrawImage(img,
                    new Rectangle(Width - img.Width / 2, 0, img.Width / 2, img.Height / 2),
                    new Rectangle(img.Width / 2, 0, img.Width / 2, img.Height / 2),
                    GraphicsUnit.Pixel);

                // Bottom-Right Corner
                g.DrawImage(img,
                    new Rectangle(Width - img.Width / 2, Height - img.Height / 2, img.Width / 2, img.Height / 2),
                    new Rectangle(img.Width / 2, img.Height / 2, img.Width / 2, img.Height / 2),
                    GraphicsUnit.Pixel);
                #endregion
                #region Sides
                // Top Side
                for (int i = 0; i < Width - img.Width; i++)
                    g.DrawImage(img,
                        new Rectangle(img.Width / 2 + i, 0, 1, img.Height / 2),
                        new Rectangle(img.Width / 2, 0, 1, img.Height / 2),
                        GraphicsUnit.Pixel);

                // Left Side
                for (int i = 0; i < Height - img.Height; i++)
                    g.DrawImage(img,
                        new Rectangle(0, img.Height / 2 + i, img.Width / 2, 1),
                        new Rectangle(0, img.Height / 2, img.Width / 2, 1),
                        GraphicsUnit.Pixel);

                // Bottom Side
                for (int i = 0; i < Width - img.Width; i++)
                    g.DrawImage(img,
                        new Rectangle(img.Width / 2 + i, Height - img.Height / 2, 1, img.Height / 2),
                        new Rectangle(img.Width / 2, img.Height / 2, 1, img.Height / 2),
                        GraphicsUnit.Pixel);

                // Right Side
                for (int i = 0; i < Height - img.Height; i++)
                    g.DrawImage(img,
                        new Rectangle(Width - img.Width / 2, img.Height / 2 + i, img.Width / 2, 1),
                        new Rectangle(img.Width / 2, img.Height / 2, img.Width / 2, 1),
                        GraphicsUnit.Pixel);
                #endregion
                // Center
                for (int i = 0; i < Width - img.Width; i++)
                    for (int j = 0; j < Height - img.Height; j++)
                        g.DrawImage(img,
                            new Rectangle(img.Width / 2 + i, img.Height / 2 + j, 1, 1),
                            new Rectangle(img.Width / 2, img.Height / 2, 1, 1),
                            GraphicsUnit.Pixel);
                #endregion
            }
            else
            {
                Color bg;
                int a = Math.Min(8, Height / 8);

                if (Selected)
                    bg = DrawingPlus.DarkenColor(BackColor, -16);
                //else if (Clicked)
                    //bg = DrawingPlus.DarkenColor(BackColor, -32);
                else
                    bg = BackColor;

                DrawingPlus.DrawBorder(g, r, BorderColor, a - 2);
                DrawingPlus.DrawPanel(g, new Rectangle(a, a, Width - a * 2, Height - a * 2), bg, 2);
            }

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            if (ShadowColor != Color.Transparent)
                g.DrawString(Text, f, new SolidBrush(Color.Black),
                    new Rectangle(1, 1, Width, Height), sf);
            g.DrawString(Text, f, fb, r, new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
        }

        #region Events
        private void base_MouseEnter(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");
            Sound.Play("Button\\Select.WAV");

            Selected = true;
        }
        private void base_MouseLeave(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            Selected = false;
        }
        private void base_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default_Pressed.CUR");
            Sound.Play("Button\\Click.WAV");

            Clicked = true;
        }
        private void base_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            Clicked = false;
        }
        #endregion
    }

    #region Buttons
    class MenuButton : CustomButton
    {
        public MenuButton()
        {
            ButtonName = "Menu";
            Size = new Size(256, 48);
        }
    }
    #endregion
}
