using System;
using Microsoft.Maui.Handlers;
using SkiaSharp.Views.Maui.Platform;
using SkiaSharp.Views.Windows;

namespace SkiaSharp.Views.Maui.Handlers
{
	public partial class SKGLViewHandler : ViewHandler<ISKGLView, FrameworkElement>
	{
		private SKSizeI lastCanvasSize;
		private SKTouchHandler? touchHandler;

		protected override FrameworkElement CreatePlatformView() => throw new PlatformNotSupportedException("SKGLView is not yet implemented for WinUI.");

		public static void MapIgnorePixelScaling(SKGLViewHandler handler, ISKGLView view) { }

		public static void MapHasRenderLoop(SKGLViewHandler handler, ISKGLView view) { }

		public static void MapEnableTouchEvents(SKGLViewHandler handler, ISKGLView view) { }

		public static void OnInvalidateSurface(SKGLViewHandler handler, ISKGLView view, object? args) { }
	}
}
