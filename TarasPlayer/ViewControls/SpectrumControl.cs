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
    public partial class SpectrumControl : UserControl
    {
        List<VerticalBar> spectrumBars;

        public SpectrumControl()
        {
            InitializeComponent();

            spectrumBars = new List<VerticalBar>();

            spectrumBars.Add(vBar32); vBar32.Color = Color.DarkBlue;
            spectrumBars.Add(vBar64); vBar64.Color = Color.DarkBlue;
            spectrumBars.Add(vBar125); vBar125.Color = Color.DarkBlue;
            spectrumBars.Add(vBar250); vBar250.Color = Color.DarkBlue;
            spectrumBars.Add(vBar500); vBar500.Color = Color.DarkBlue;
            spectrumBars.Add(vBar1000); vBar1000.Color = Color.DarkBlue;
            spectrumBars.Add(vBar2000); vBar2000.Color = Color.DarkBlue;
            spectrumBars.Add(vBar4000); vBar4000.Color = Color.DarkBlue;
        }
        
        public void SetFreqValue(int freq, int value)
        {
            spectrumBars[freq].SetProgress(value);
        }

        public void UpdateSpectrum(List<byte> spectrumData)
        {
            for(int i = 0; i < spectrumData.Count; i++)
            {
                spectrumBars[i].SetProgress((int)((float)(spectrumData[i]) / 255.0f * 100.0f));
            }
        }
    }
}
