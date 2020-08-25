using System;
using System.Collections.Generic;

using Un4seen.Bass;
using Un4seen.BassWasapi;


namespace TarasPlayer
{
    public class BassWrapper
    {
        public static int _stream;
        public static bool _initDefaultDevice;
        public static bool _isRepeat;

        public static int curVolume = 100;

        float[] buffer;
        List<byte> spectrumData;

        private static WASAPIPROC BassProcess;

        public BassWrapper()
        {
            Init();
            curVolume = 100;

            BassProcess = new WASAPIPROC(Process);
        }
        
        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        public static bool Init()
        {
            if (!_initDefaultDevice)
            {
                _initDefaultDevice =
                    Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);

                BassWasapi.BASS_WASAPI_Init(-1, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, BassProcess, IntPtr.Zero);
            }
            return _initDefaultDevice;
        }
        
        public void OpenStream(string fileName, bool isRepeat, bool isPlay)
        {
            CloseStream();

            _isRepeat = isRepeat;

            if (Init() == true)
            {
                _stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);
                if (_stream != 0)
                {
                    Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, curVolume / 100.0f);
                    if(isPlay)
                        Bass.BASS_ChannelPlay(_stream, _isRepeat);
                    else
                        Bass.BASS_ChannelPause(_stream);

                }
            }
        }

        public void CloseStream()
        {
            Bass.BASS_ChannelStop(_stream);
            Bass.BASS_StreamFree(_stream);
        }

        public void SetStreamVolume(int stream, int volume)
        {
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100.0f);
        }

        public void PlayStream()
        {
            Bass.BASS_ChannelPlay(_stream, _isRepeat);
        }

        public void PauseStream()
        {
            Bass.BASS_ChannelPause(_stream);
        }

        public void UpVolume(int value)
        {
            if (curVolume + value >= 100)
                curVolume = 100;
            else
                curVolume += value;

            Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, curVolume / 100.0f);
        }

        public void DownVolume(int value)
        {
            if (curVolume - value <= 0)
                curVolume = 0;
            else
                curVolume -= value;

            Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, curVolume / 100.0f);
        }

        public List<int> GetTimeOfStream()
        {
            List<int> time = new List<int>();

            long TimeBytes = Bass.BASS_ChannelGetLength(_stream);
            int Seconds = (int)Bass.BASS_ChannelBytes2Seconds(_stream, TimeBytes);

            int Minutes = Seconds / 60;

            Seconds = Seconds - Minutes * 60;

            time.Add(Seconds);
            time.Add(Minutes);

            return time;
        }

        public List<int> GetPosOfStream()
        {
            List<int> time = new List<int>();
            long TimeBytes = Bass.BASS_ChannelGetPosition(_stream);
            int Seconds = (int)Bass.BASS_ChannelBytes2Seconds(_stream, TimeBytes);

            int Minutes = Seconds / 60;

            Seconds = Seconds - Minutes * 60;

            time.Add(Seconds);
            time.Add(Minutes);

            return time;
        }

        public int GetBitrate()
        {
            float bitRate = 0;
            Bass.BASS_ChannelGetAttribute(_stream, BASSAttribute.BASS_ATTRIB_BITRATE, ref bitRate);

            return (int)bitRate;
        }

        public void SetPosOfStream(int seconds)
        {
            long bytes = Bass.BASS_ChannelSeconds2Bytes(_stream, seconds);
            Bass.BASS_ChannelSetPosition(_stream, bytes);
        }

        public enum PLAY_STATE
        {
            STOPPED, PLAYING, PAUSED, STALLED 
        };

        public PLAY_STATE GetState()
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_STOPPED)
                return PLAY_STATE.STOPPED;
            else if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
                return PLAY_STATE.PLAYING;
            else if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PAUSED)
                return PLAY_STATE.PAUSED;
            else return PLAY_STATE.STALLED;
        }

        public List<byte> GetSpectrum(int lines)
        {
            buffer = new float[1024];
            spectrumData = new List<byte>();

            int result = Bass.BASS_ChannelGetData(_stream,buffer, (int)BASSData.BASS_DATA_FFT2048);
            if (result < 0) return spectrumData;

            int x, y;
            int b0 = 0;
            
            for (x = 0; x < lines; x++)
            {
                float peak = 0;
                int b1 = (int) Math.Pow(2, x * 10.0 / (lines - 1));
                if (b1 > 1023) b1 = 1023;
                if (b1 <= b0) b1 = b0 + 1;

                while(b0 < b1)
                {
                    if (peak < buffer[1 + b0]) peak = buffer[1 + b0];
                    b0++;
                }

                y = (int) (Math.Sqrt(peak) * 3 * 255 - 4);
                if (y > 255) y = 255;
                if (y < 0) y = 0;
                spectrumData.Add((byte)y);
            }

            return spectrumData;
        }
    }
}
