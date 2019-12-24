' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System

Namespace Microsoft.VisualBasic.CompilerServices

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Public Interface IVbHost
        Function GetParentWindow() As Windows.Forms.IWin32Window
        Function GetWindowTitle() As String
    End Interface

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Public NotInheritable Class HostServices

        Public Shared Property VBHost() As IVbHost

    End Class

End Namespace

