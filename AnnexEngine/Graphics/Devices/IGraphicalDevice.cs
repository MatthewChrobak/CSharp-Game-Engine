﻿using AnnexEngine.Graphics.Content.Contexts;

namespace AnnexEngine.Graphics.Devices
{
    /// <summary>
    /// A graphical object that is capable of drawing surfaces and text on itself.
    /// </summary>
    public interface IGraphicalDevice : IDrawable
    {
        /// <summary>
        /// Draws a surface with the given context on the graphical device.
        /// </summary>
        /// <param name="surfaceName">The name of the surface to be drawn.</param>
        /// <param name="context">The context to be applied to the surface.</param>
        void DrawSurface(string surfaceName, SurfaceContext context);

        /// <summary>
        /// Draws text with the given context on the graphical device.
        /// </summary>
        /// <param name="text">The text to be drawn.</param>
        /// <param name="context">The context to be applied to the text.</param>
        void DrawText(string text, TextContext context);

        /// <summary>
        /// Destroys the graphical device.
        /// </summary>
        void Destroy();
    }
}
