﻿// <copyright file="IColorMatrixFilter.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessorCore.Processors
{
    using System.Numerics;

    /// <summary>
    /// Encapsulates properties and methods for creating processors that utilize a matrix to
    /// alter the image pixels.
    /// </summary>
    public interface IColorMatrixFilter<TColor, TPacked> : IImageProcessor<TColor, TPacked>
        where TColor : IPackedVector<TPacked>
        where TPacked : struct
    {
        /// <summary>
        /// Gets the <see cref="Matrix4x4"/> used to alter the image.
        /// </summary>
        Matrix4x4 Matrix { get; }
    }
}
