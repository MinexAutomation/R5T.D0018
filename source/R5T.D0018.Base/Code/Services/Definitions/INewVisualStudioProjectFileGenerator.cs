﻿using System;
using System.Threading.Tasks;

using R5T.T0002;


namespace R5T.D0018
{
    /// <summary>
    /// Service to create new <see cref="IVisualStudioProjectFile"/> instances.
    /// Hides the implementation type.
    /// </summary>
    public interface INewVisualStudioProjectFileGenerator
    {
        Task<IVisualStudioProjectFile> CreateNewVisualStudioProjectFile();
    }
}
