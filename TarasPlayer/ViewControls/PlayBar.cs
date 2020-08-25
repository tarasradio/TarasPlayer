using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarasPlayer
{
    public partial class PlayBar : UserControl
    {
        public static double _prog = 0;

        public delegate void MouseEventDelegate(int progress);
        public event MouseEventDelegate mClick;

        public PlayBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Установка значения прогресс-бара
        /// </summary>
        /// <param name="progress"></param>
        public void SetProgress(int progress)
        {
            _prog = (double)progress / 100.0;
            UpdateDraw();
        }

        /// <summary>
        /// Обновление визуализации
        /// </summary>
        private void UpdateDraw()
        {
            int width = pBox.Width;
            if (width == 0) return;

            Bitmap bmp =
                new Bitmap(pBox.Width, pBox.Height, pBox.CreateGraphics());
            Graphics g = Graphics.FromImage(bmp);

            Brush brush = Brushes.White;
            Brush brushColor = Brushes.LimeGreen;

            int wColor = (int)(width * _prog);

            g.FillRectangle(
                brush,
                0, 0, pBox.Width, pBox.Height);

            g.FillRectangle(
                brushColor,
                0, 0, wColor, pBox.Height);

            pBox.Image = bmp;
            pBox.Refresh();
        }

        private void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            int prog = (int)((double)e.X / (double)pBox.Width * 100.0);
            mClick(prog);
        }
    }
}
