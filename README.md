# How to change the expander icon in TreeGrid(SfTreeGrid)?

## About the sample
This example illustrates how to change the expander icon in TreeGrid(SfTreeGrid)?

The default symbol of expander is +/- in [WPF TreeGrid](https://www.syncfusion.com/wpf-controls/treegrid) (SfTreeGrid). You can be able to change the tree grid expander by customizing the [TreeGridExpander](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeGrid.TreeGridExpander.html) style.

```XAML
<Window.Resources>
    <Style TargetType="syncfusion:TreeGridExpander" >
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="syncfusion:TreeGridExpander">
                    <Grid Background="{TemplateBinding Background}"
                        SnapsToDevicePixels="True">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="ExpansionStates">
                                <VisualState x:Name="Collapsed"/>

                                <VisualState x:Name="Expanded">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames BeginTime="00:00:00"
                                                                    Duration="00:00:00"
                                                                    Storyboard.TargetName="PART_GridExpanderCellPath"
                                                                    Storyboard.TargetProperty="RenderTransform">
                                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <RotateTransform Angle="0" />
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Path x:Name="PART_GridExpanderCellPath"
                            Width="10"
                            Height="10"
                                Margin="2,0,0,0"
                            HorizontalAlignment="Center"
                            VerticalAlignment="Center" 
                            Data="F1M1464.78,374.21C1466.31,374.21,1466.94,375.538,1466.17,376.861L1435.89,429.439C1435.12,430.759,1433.87,430.823,1433.11,429.5L1402.82,376.827C1402.06,375.507,1402.69,374.21,1404.21,374.21L1464.78,374.21"
                            Fill="{TemplateBinding Foreground}"
                            SnapsToDevicePixels="True"
                            Stretch="Fill"
                            Stroke="{TemplateBinding Foreground}"
                            UseLayoutRounding="False">
                            <Path.RenderTransform>
                                <TransformGroup>
                                    <TransformGroup.Children>
                                        <RotateTransform Angle="270" CenterX="4" CenterY="4" />
                                    </TransformGroup.Children>
                                </TransformGroup>
                            </Path.RenderTransform>
                        </Path>
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</Window.Resources>
```

KB article - [How to change the expander icon in TreeGrid(SfTreeGrid)?](https://www.syncfusion.com/kb/11240/how-to-change-the-expander-icon-in-wpf-treegrid-sftreegrid)

## Requirements to run the demo
Visual Studio 2015 and above versions
