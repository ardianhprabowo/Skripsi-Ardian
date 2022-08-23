Imports DevExpress.XtraSplashScreen
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


Public Class OverlayFormShow
    Private Shared _defaultInstance As OverlayFormShow

    Public Shared Property Instance As OverlayFormShow
        Get

            If _defaultInstance Is Nothing Then
                _defaultInstance = New OverlayFormShow()
            End If

            Return _defaultInstance
        End Get
        Set(ByVal value As OverlayFormShow)
            _defaultInstance = value
        End Set
    End Property

    Public handle As IOverlaySplashScreenHandle = Nothing

    Public Sub ShowFormOverlay(ByVal control As Control)
        Dim img As Bitmap = New Bitmap(1, 1)
        Dim useFadeIn As Boolean = False
        Dim useFadeOut As Boolean = False
        Dim backColor As Color = Color.Black
        Dim foreColor As Color = Color.Black
        Dim opacity As Double = 0.5
        Dim waitImage As Image = img
        Dim options As OverlayWindowOptions = New OverlayWindowOptions(useFadeIn, useFadeOut, backColor, foreColor, opacity, waitImage)
        Me.handle = ShowProgressPanel(MainForm, options)
    End Sub

    Public Function ShowProgressPanel(ByVal control As MainForm, ByVal options As OverlayWindowOptions) As IOverlaySplashScreenHandle
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(MainForm, options)
        Return handle
        handle.QueueFocus(IntPtr.Zero)
        'Return CSharpImpl.__Assign(handle, SplashScreenManager.ShowOverlayForm(control, options))
    End Function
    Private Function ShowProgressPanel() As IOverlaySplashScreenHandle
        Dim mainForm As New Form '= CType(Application.MainWindow.Template, Form)
        Return SplashScreenManager.ShowOverlayForm(mainForm)
    End Function
    Public Sub CloseProgressPanel()

        If handle IsNot Nothing Then SplashScreenManager.CloseOverlayForm(Me.handle)
    End Sub


End Class
