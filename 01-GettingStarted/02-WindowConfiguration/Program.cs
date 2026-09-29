using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

GameWindowSettings gameWindowSettings = new GameWindowSettings
{
    UpdateFrequency = 60.0f
};

NativeWindowSettings nativeWindowSettings = new NativeWindowSettings
{
    ClientSize = new(1280, 720),
    Title = "OpenTK - Window Configuration",
    WindowState = WindowState.Normal,
    WindowBorder = WindowBorder.Resizable,
    StartVisible = true,
    StartFocused = true,
    API = ContextAPI.OpenGL,
    APIVersion = new(4, 6),
    Profile = ContextProfile.Core
};

using GameWindow window = new(gameWindowSettings, nativeWindowSettings);

window.Load += () =>
{
    GL.ClearColor(0.1f, 0.2f, 0.3f, 1.0f);
    window.VSync = VSyncMode.On;
};

window.RenderFrame += (FrameEventArgs args) =>
{
    GL.Clear(ClearBufferMask.ColorBufferBit);
    window.SwapBuffers();
};

window.Run();