﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Entities.Modules
{
    using System;

    /// Project  : DotNetNuke
    /// Namespace: DotNetNuke.Entities.Modules
    /// Class    : DesktopModuleSupportedFeature
    /// <summary>
    /// The DesktopModuleSupportedFeature enum provides an enumeration of Supported
    /// Features.
    /// </summary>
    [Flags]
    public enum DesktopModuleSupportedFeature
    {
        IsPortable = 1,
        IsSearchable = 2,
        IsUpgradeable = 4,
    }
}
