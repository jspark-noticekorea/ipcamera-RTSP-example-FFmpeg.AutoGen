# ipcamera-RTSP-example-FFmpeg.AutoGen

This is a sample code for streaming ip-camera image with [FFmpeg.AutoGen](https://github.com/Ruslan-B/FFmpeg.AutoGen)



1. Download `ffmpeg-4.4-full_build-shared.7z` of proper version (I used 4.4) from [here](https://www.gyan.dev/ffmpeg/builds/) 
2. Extract .dll files from `ffmpeg-4.4-full_build-shared/bin/`
3. Copy and paste those .dll files into `./rtsp_test/FFmpeg/bin/x64/` (in the directory, there is only one file named `ffmpeg_dll_HERE.keep`)
4. Get NuGet pacakge 'FFmpeg.Autogen' of proper version. This version must be same with ffmpeg version you downloaded in the first step.
5. uncheck **Prefer 32-bit** at your project property!

# For 32-bit Environment
2021.06.09
1. Get 32-bit shared build of proper version (ex. `ffmpeg-4.3.1-win32-shared.zip`)
2. Extract .dll files and copy&paste those .dll into `./rtsp_test/FFmpeg/bin/x64/` (in the directory, there is only one file named `ffmpeg_dll_HERE.keep`)
3. Get Nuget package 'FFmpeg.AutoGen' of proper version. This viersion must be same with ffmpeg version you downloaded int the first step. (ex. ver.4.3.1)
4. check **Prefer 32-bit** at your project property! (For Any CPU)



# Fast open stream

2021.06.07
I'm developing this test project to stream real-time image(video) with ffmpeg.
Opening streaming device functions had required about 6~8seconds (too slow!).
I found a nice tip to open device quicly.
I refered [tCancel changeshis](https://www.programmersought.com/article/430134736/).
There are several tips to reduce delay during `avformat_find_stream_info(_pFormatContext, null)`.
I only tried the first one, but the effect was great!
