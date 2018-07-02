// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Lottie.Animation.Content
{
    internal interface IContent
    {
        string Name { get; }

        void SetContents(List<IContent> contentsBefore, List<IContent> contentsAfter);
    }
}