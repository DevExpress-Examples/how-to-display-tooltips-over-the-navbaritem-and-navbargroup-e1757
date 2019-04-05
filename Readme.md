<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/NavBarToolTip/Window1.xaml) (VB: [Window1.xaml](./VB/NavBarToolTip/Window1.xaml))
* [Window1.xaml.cs](./CS/NavBarToolTip/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/NavBarToolTip/Window1.xaml.vb))
<!-- default file list end -->
# How to display tooltips over the NavBarItem and NavBarGroup


<p>NavBarItem and NavBarGroup are not visual elements and setting the ToolTip property doesn't take any effect for them. To show a tooltip over items and groups in NavBarControl, use the ItemVisualStyle and GroupVisualStyle properties in the following manner: </p>


```xaml
<dxn:NavigationPaneView.ItemVisualStyle>
    <Style TargetType="{x:Type dxn:NavBarItemControl}">
        <Setter Property="ToolTip" Value="{Binding ToolTip}"/>
    </Style>
</dxn:NavigationPaneView.ItemVisualStyle>
<dxn:NavigationPaneView.GroupVisualStyle>
    <Style>
        <Setter Property="dx:DXFrameworkContentElement.ToolTip" Value="{Binding ToolTip}"/>
    </Style>
</dxn:NavigationPaneView.GroupVisualStyle>
```



<br/>


