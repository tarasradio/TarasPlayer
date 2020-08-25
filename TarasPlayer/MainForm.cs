using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarasPlayer
{
    public partial class MainForm : Form
    {
        BassWrapper master; // для воспроизведения
        FileManager fileManager; // для управления файлами

        Timer updateTimer;

        bool isPause;

        bool isOpenFisrt = false;

        public MainForm()
        {
            InitializeComponent();

            master = new BassWrapper();
            fileManager = new FileManager();

            updateTimer = new Timer();
            updateTimer.Interval = 20;
            updateTimer.Tick += UpdateTimer_Tick;

            // настройка кнопок
            playPause.Enabled = false;
            prevFile.Enabled = false;
            nextFile.Enabled = false;

            String[] Args = Environment.GetCommandLineArgs();

            initGridView();

            // если программой открыт файл по умолчанию при запуске
            if (Args.Length > 1)
            {
                isOpenFisrt = true;

                fileManager.OpenFile(Args[1]);
                updateList();
                fileGrid.CurrentCell = fileGrid.Rows[fileManager.CurrentIndex].Cells[0];
                master.OpenStream(fileManager.GetFileName(), false, true);

                isOpenFisrt = false; updateTimer.Enabled = true;
            }

            mPlayBar.mClick += MPlayBar_mClick;
        }

        void initGridView()
        {
            fileGrid.ColumnCount = 3;
            fileGrid.RowHeadersVisible = false;
            fileGrid.ColumnHeadersVisible = false;

            fileGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fileGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fileGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void MPlayBar_mClick(int progress)
        {
            //задаем положение проигрывания
            Double all = (double)progress/ 100.0;
            all = all * (master.GetTimeOfStream()[1] * 60 + master.GetTimeOfStream()[0]);

            master.SetPosOfStream((int)all);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            durationLable.Text =
                String.Format("{0:00}", master.GetTimeOfStream()[1]) +
                ":" +
                String.Format("{0:00}", master.GetTimeOfStream()[0]);

            currentLable.Text =
                String.Format("{0:00}", master.GetPosOfStream()[1]) +
                ":" +
                String.Format("{0:00}", master.GetPosOfStream()[0]);

            double duration = 
                (double)(master.GetPosOfStream()[1] * 60 + master.GetPosOfStream()[0]) /
                (double)(master.GetTimeOfStream()[1] * 60 + master.GetTimeOfStream()[0]);

            duration *= 100.0;
            if (duration > 100) duration = 100;
            
            mPlayBar.SetProgress((int)duration);

            bitrateLable.Text = master.GetBitrate() + " кБит/с";
            
            if(master.GetState() == BassWrapper.PLAY_STATE.STOPPED)
            {
                int index = fileGrid.CurrentRow.Index;

                if (index == (fileGrid.RowCount - 1))
                {
                    fileGrid.CurrentCell = fileGrid.Rows[0].Cells[0];
                }
                else
                {
                    fileGrid.CurrentCell = fileGrid.Rows[index + 1].Cells[0];
                }
            }
            
            spectrumControl.UpdateSpectrum(master.GetSpectrum(8));
        }

        public void loadFiles()
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.RestoreDirectory = true;
            ofd.FileName = "";
            ofd.Filter = "Mp3 файлы|*.mp3|Все файлы (*.*)|*.*";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                isOpenFisrt = true;

                updateTimer.Enabled = false;
                fileManager.OpenFile(ofd.FileNames[0]);
                updateList();
                fileGrid.CurrentCell = fileGrid.Rows[fileManager.CurrentIndex].Cells[0];
                master.OpenStream(fileManager.GetFileName(), false, true);

                isOpenFisrt = false; updateTimer.Enabled = true;
            }
        }

        private void updateList()
        {
            fileGrid.Rows.Clear();
            fileGrid.RowCount = fileManager.OpenFiles.Count;

            List<String> fileNames = fileManager.OpenFiles;

            for (int i = 0; i < fileManager.OpenFiles.Count; i++)
            {
                string fileName = fileManager.CurrentDirectory;
                fileName += "\\";
                fileName += fileNames[i];
                fileName += ".mp3";

                master.OpenStream(fileName, false, false);

                String Duration =
                String.Format("{0:00}", master.GetTimeOfStream()[1]) +
                ":" +
                String.Format("{0:00}", master.GetTimeOfStream()[0]);

                fileGrid[0, i].Value = Duration;
                fileGrid[1, i].Value = fileNames[i];
                fileGrid[2, i].Value = master.GetBitrate() + " кБит/с";
            }

            fileGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            fileGrid.DefaultCellStyle.ForeColor = Color.DarkBlue;

            playPause.Enabled = true;
            prevFile.Enabled = true;
            nextFile.Enabled = true;

            playPause.Image = TarasPlayer.Properties.Resources.pauseIcon;

            isPause = false;
        }

        private void openFileItem_Click(object sender, EventArgs e)
        {
            loadFiles();
        }
        
        private void selectFile()
        {
            fileManager.CurrentIndex = fileGrid.CurrentCell.RowIndex;

            string fileName = fileManager.CurrentDirectory;

            fileName += "\\";
            fileName += fileManager.GetFileName();
            fileName += ".mp3";

            master.OpenStream(fileName, false, true);

            indexLable.Text = (fileGrid.CurrentRow.Index + 1) + "/" + fileManager.OpenFiles.Count;

            isPause = false;
            playPause.Image = TarasPlayer.Properties.Resources.pauseIcon;

            updateTimer.Enabled = true;

        }

        private void volumeDown_Click(object sender, EventArgs e)
        {
            master.DownVolume(10);
        }

        private void volumeUp_Click(object sender, EventArgs e)
        {
            master.UpVolume(10);
        }

        private void playPause_Click(object sender, EventArgs e)
        {
            if(!isPause)
            {
                isPause = true;
                master.PauseStream();

                playPause.Image = TarasPlayer.Properties.Resources.playIcon;
            }
            else
            {
                isPause = false;
                master.PlayStream();

                playPause.Image = TarasPlayer.Properties.Resources.pauseIcon;
            }
        }

        private void nextFile_Click(object sender, EventArgs e)
        {
            int index = fileGrid.CurrentRow.Index;

            if (index == fileGrid.RowCount - 1)
                fileGrid.CurrentCell = fileGrid.Rows[0].Cells[0];
            else
                fileGrid.CurrentCell = fileGrid.Rows[fileGrid.CurrentRow.Index + 1].Cells[0];
            selectFile();
        }

        private void prevFile_Click(object sender, EventArgs e)
        {
            int index = fileGrid.CurrentRow.Index;
            if (index == 0)
                fileGrid.CurrentCell = fileGrid.Rows[fileGrid.RowCount - 1].Cells[0];
            else
                fileGrid.CurrentCell = fileGrid.Rows[fileGrid.CurrentRow.Index - 1].Cells[0];
            selectFile();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void overCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = overCheckBox.Checked;
        }
        
        private void fileGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (isOpenFisrt == true) return;

            int rowSelected = fileGrid.CurrentRow.Index;
            if (rowSelected == -1) return;
            selectFile();
        }
    }
}
