using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Content.Client.UserInterface.Screens;
using Robust.Client.Graphics;
using Robust.Shared.Timing;

namespace Content.Client.SS220.ScreenCapture;

public sealed class ScreenCaptureSystem : EntitySystem
{
    [Dependency] private readonly IClyde _clyde = default!;

    [Dependency] private readonly IGameTiming _gameTiming = default!;

    [Dependency] private readonly IRenderHandle _renderHandle = default!;

    InGameScreen _gameScreen;
    public async Task TakeScreenShot()
    {
        var screenSize = _clyde.ScreenSize;

        var screen = await _clyde.ScreenshotAsync(ScreenshotType.Final);



        var width = screenSize.X;
        int height = screenSize.Y;

        var pixelData = new byte[width * height * 4];

        var renderTarger = _clyde.CreateRenderTarget(new Vector2i(width, height),
            new RenderTargetFormatParameters(RenderTargetColorFormat.Rgba8));

      _gameScreen.Dra
        _renderHandle.RenderInRenderTarget(renderTarger, () =>
        {
            _renderHandle.Dr
        }, null);
    }
}
