using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace VocabularyUp
{
	public class SuperLabel: Label
    {
        private SuperProgressBar superProgressBar1;
        private bool bFlip = true;

		public SuperLabel()
		{
		}


		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.None;
			stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

			Brush textBrush = new SolidBrush(this.ForeColor);

			Matrix storedState = g.Transform;

			if (bFlip)
			{
				g.RotateTransform(180f);

				g.TranslateTransform(-ClientRectangle.Width,
										-ClientRectangle.Height);
			}

			g.DrawString(
				this.Text,
				this.Font,
				textBrush,
				ClientRectangle,
				stringFormat);

			g.Transform = storedState;
		}

		[Description("When this parameter is true the VLabel flips at 180 degrees."), Category("Appearance")]
		public bool Flip180
		{
			get
			{
				return bFlip;
			}
			set
			{
				bFlip = value;
				this.Invalidate();
			}
		}

        private void InitializeComponent()
        {
            this.superProgressBar1 = new VocabularyUp.SuperProgressBar();
            this.SuspendLayout();
            // 
            // superProgressBar1
            // 
            this.superProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.superProgressBar1.Name = "superProgressBar1";
            this.superProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.superProgressBar1.TabIndex = 0;
            this.ResumeLayout(false);

        }
    }
}
