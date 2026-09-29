using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

GameWindowSettings gameWindowSettings = GameWindowSettings.Default;

NativeWindowSettings nativeWindowSettings = new NativeWindowSettings
{
    ClientSize = new(800, 600),
    Title = "OpenTK - Hello Window"
};

using GameWindow window = new(gameWindowSettings, nativeWindowSettings);

window.Load += () =>
{
    GL.ClearColor(0.1f, 0.2f, 0.3f, 1.0f);
};

window.RenderFrame += (FrameEventArgs args) =>
{
    GL.Clear(ClearBufferMask.ColorBufferBit);
    window.SwapBuffers();
};

window.Run();