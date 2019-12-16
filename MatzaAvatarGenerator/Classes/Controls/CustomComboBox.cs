using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace MatzaAvatarGenerator
{
    class CustomComboBox : ComboBox
    {
        public Color ShadowColor { get; set; }
        new public System.Windows.Forms.DrawMode DrawMode { get; set; }

        public CustomComboBox()
        {
            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;

            DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;

            BackColor = Color.DarkRed;
            ForeColor = Color.Gold;
            ShadowColor = Color.Black;

            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);

            DrawItem += new DrawItemEventHandler(CustomComboBox_DrawItem);
        }

        void CustomComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox cb = (ComboBox)sender;
            Graphics g = e.Graphics;
            Color clrText;
            Color clrHighlight;
            Color clrShadow;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                clrHighlight = ForeColor;
                clrText = BackColor;
                clrShadow = Color.Transparent;
            }
            else
            {
                clrHighlight = BackColor;

                if (Enabled)
                    clrText = ForeColor;
                else
                    clrText = ColorTranslator.FromHtml("#A0A0A0");

                clrShadow = ShadowColor;
            }

            DrawingPlus.DrawBilinearHorizontalGradient(g, e.Bounds, clrHighlight, 3);
            if (clrShadow != Color.Transparent)
                g.DrawString(cb.Items[e.Index].ToString(), e.Font, new SolidBrush(ShadowColor),
                    new Point(e.Bounds.X - 1, e.Bounds.Y + 1));

            g.DrawString(cb.Items[e.Index].ToString(), e.Font, new SolidBrush(clrText), new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }
    }
}
