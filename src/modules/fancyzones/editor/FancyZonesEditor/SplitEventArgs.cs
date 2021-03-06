// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows.Controls;

namespace FancyZonesEditor
{
    public class SplitEventArgs : EventArgs
    {
        public SplitEventArgs()
        {
        }

        public SplitEventArgs(Orientation orientation, int offset)
        {
            Orientation = orientation;
            Offset = offset;
        }

        public Orientation Orientation { get; }

        public int Offset { get; }
    }

#pragma warning disable CA1711 // Identifiers should not have incorrect suffix (Causes warning in another class if fixed)
    public delegate void SplitEventHandler(object sender, SplitEventArgs args);
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
}
