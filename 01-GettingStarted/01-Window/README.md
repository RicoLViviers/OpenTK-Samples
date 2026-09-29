# 01 - Hello Window

This sample demonstrates how to create a basic window using OpenTK and clear it with a color using OpenGL.

## What You'll Learn

* How to create a `GameWindow`
* How to set the initial window size and title
* How to run an OpenTK application
* How to clear the framebuffer
* How to swap the front and back buffers

## Key Concepts

### GameWindow

`GameWindow` provides a window with an OpenGL context and a game loop.

The window is created using two configuration objects:

* `GameWindowSettings` configures the game loop.
* `NativeWindowSettings` configures the native window.

### Load

The `Load` event runs after the window and OpenGL context have been created.

In this sample, it is used to set the clear color:

```csharp
GL.ClearColor(0.1f, 0.2f, 0.3f, 1.0f);
```

### RenderFrame

The `RenderFrame` event is called whenever OpenTK renders a new frame.

The framebuffer is cleared using:

```csharp
GL.Clear(ClearBufferMask.ColorBufferBit);
```

### Swapping Buffers

OpenTK windows use double buffering. Rendering happens to the back buffer while the front buffer is displayed.

After rendering a frame, the buffers are swapped:

```csharp
window.SwapBuffers();
```

### Window Main Loop

Run starts the window's main loop and continues running until the window is closed.

```csharp
window.Run();
```

## Running the Sample

From this directory, run:

```bash
dotnet run
```

A window should appear with a solid background color.

## Next

Continue to **02 - Window Configuration** to learn how to configure an OpenTK window and its OpenGL context.
