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
    public partial class VerticalBar : UserControl
    {
        public static double Progress = 0;
        public Color Color { get; set; } = Color.GreenYellow;

        private Timer timer;

        public VerticalBar()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += (object sender, EventArgs e) => { Redraw(); };
            timer.Interval = 16;
            timer.Start();

        }

        /// <summary>
        /// Установка значения прогресс-бара
        /// </summary>
        /// <param name="progress"></param>
        public void SetProgress(int progress)
        {
            Progress = (double) progress / 100.0;
            Redraw();
        }

        /// <summary>
        /// Обновление визуализации
        /// </summary>
        private void Redraw()
        {
            int height = pBox.Height;

            Bitmap bmp = 
                new Bitmap(pBox.Width, pBox.Height, pBox.CreateGraphics());
            Graphics g = Graphics.FromImage(bmp);
            

            Brush brush = Brushes.White;
            SolidBrush b = new SolidBrush(this.Color);
            
            Brush brushColor = b;

            int hColor = (int)(height * Progress);

            g.FillRectangle(
                brush,
                0, 0, pBox.Width, pBox.Height);

            g.FillRectangle(
                brushColor,
                0, pBox.Height - hColor, pBox.Width, hColor);

            pBox.Image = bmp;
            pBox.Refresh();
        }
    }
}
