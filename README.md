# ipcamera-RTSP-example-FFmpeg.AutoGen

This is a sample code for streaming ip-camera image with [FFmpeg.AutoGen](https://github.com/Ruslan-B/FFmpeg.AutoGen)



1. Download `ffmpeg-4.4-full_build-shared.7z` of proper version (I used 4.4) from [here](https://www.gyan.dev/ffmpeg/builds/) 
2. Extract .dll files from `ffmpeg-4.4-full_build-shared/bin/`
3. Copy and paste those .dll files into `./rtsp_test/FFmpeg/bin/x64/` (in the directory, there is only one file named `ffmpeg_dll_HERE.keep`)
4. Get NuGet pacakge 'FFmpeg.Autogen' of proper version. This version must be same with ffmpeg version you downloaded in the first step.