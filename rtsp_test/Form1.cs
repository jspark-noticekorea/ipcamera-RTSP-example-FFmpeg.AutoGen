using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Threading;
using FFmpeg.AutoGen;
using System.IO;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;

namespace rtsp_test
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private bool isThreadRunning;
        private Dispatcher dispatcher = Dispatcher.CurrentDispatcher;
        System.Drawing.Bitmap playImg;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            
            if (this.isThreadRunning)
            {
                this.isThreadRunning = false;
            }
            else
            {
                this.isThreadRunning = true;

                this.thread = new Thread(ProcessThread);

                this.thread.Start();
            }

        }


        private unsafe void ProcessThread()
        {
            FFmpegBinariesHelper.RegisterFFmpegBinaries();

            string url = tbUrl.Text;

            using (VideoStreamDecoder decoder = new VideoStreamDecoder(url))
            {
                IReadOnlyDictionary<string, string> contextInfoDictionary = decoder.GetContextInfo();

                contextInfoDictionary.ToList().ForEach(x => Console.WriteLine($"{x.Key} = {x.Value}"));

                Size sourceSize = decoder.FrameSize;
                AVPixelFormat sourcePixelFormat = decoder.PixelFormat;
                Size targetSize = sourceSize;
                AVPixelFormat targetPixelFormat = AVPixelFormat.AV_PIX_FMT_BGR24;

                using (VideoFrameConverter converter = new VideoFrameConverter(sourceSize, sourcePixelFormat, targetSize, targetPixelFormat))
                {
                    int frameNumber = 0;

                    while (decoder.TryDecodeNextFrame(out AVFrame sourceFrame) && isThreadRunning)
                    {
                        AVFrame targetFrame = converter.Convert(sourceFrame);

                        System.Drawing.Bitmap bitmap;

                        bitmap = new System.Drawing.Bitmap
                        (
                            targetFrame.width,
                            targetFrame.height,
                            targetFrame.linesize[0],
                            System.Drawing.Imaging.PixelFormat.Format24bppRgb,
                            (IntPtr)targetFrame.data[0]
                        );

                        SetImageSource(bitmap);

                        frameNumber++;
                        Thread.Sleep(100);
                    }
                }
            }
        }


        private void SetImageSource(System.Drawing.Bitmap bitmap)
        {
            this.dispatcher.BeginInvoke((Action)(() =>
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    if (this.thread.IsAlive)
                    {
                        playImg = bitmap;
                        pictureBox1.Image = playImg;
                        return;
                        bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);

                        memoryStream.Position = 0;

                        BitmapImage bitmapimage = new BitmapImage();

                        bitmapimage.BeginInit();

                        bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapimage.StreamSource = memoryStream;

                        bitmapimage.EndInit();

                    }
                }
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (this.thread.IsAlive)
            {
                this.isThreadRunning = false;

                this.thread.Join();
            }

        }
    }
}
