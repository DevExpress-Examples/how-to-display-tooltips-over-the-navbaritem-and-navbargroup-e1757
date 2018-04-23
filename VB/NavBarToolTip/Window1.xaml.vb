Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.NavBar
Imports System.Windows.Controls.Primitives
Imports DevExpress.Wpf.Core

Namespace NavBarToolTip
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ExplorerBarView_ItemSelected(ByVal sender As Object, ByVal e As DevExpress.Wpf.NavBar.NavBarItemSelectedEventArgs)

		End Sub

		Private Sub NavBarControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim nb As NavBarControl = TryCast(sender, NavBarControl)
			tooltip.IsOpen = False
			Cursor = Cursors.Arrow

			Dim nbItem As NavBarItem = nb.View.GetNavBarItem(e)
			Dim nbGroup As NavBarGroup = nb.View.GetNavBarGroup(e)
			If nbItem Is Nothing AndAlso nbGroup IsNot Nothing Then
				tooltip_text.Text = String.Format("Header = {0}" & Constants.vbLf, nbGroup.Header)
				tooltip.Placement = PlacementMode.Mouse
				tooltip.IsOpen = True
				Cursor = Cursors.Hand
			End If
			If nbItem IsNot Nothing Then
				tooltip_text.Text = String.Format("Name = {0}" & Constants.vbLf, nbItem.Content)
				tooltip.Placement = PlacementMode.Mouse
				tooltip.IsOpen = True
				Cursor = Cursors.Hand
			End If

		End Sub

		Private Sub NavBarControl_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
			tooltip.IsOpen = False
		End Sub
	End Class
End Namespace
