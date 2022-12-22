# How-to-customize-the-appearance-of-axis-labels-in-WPF-Chart
This sample demonstrate how to customize the appearance of axis labels in WPF Chart.

[WPF SfChart](https://help.syncfusion.com/wpf/charts/getting-started) supports customizing the appearance of the axis labels using the [LabelTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAxis.html#Syncfusion_UI_Xaml_Charts_ChartAxis_LabelTemplate) property of the Chart axis with the following steps:

Step 1: Initialize a data model that represents a data point for the Chart.

**[C#]**

```
public class ChartModel
{
	public string XValue { get; set; }
	public double YValue { get; set; }
}

```

Step 2: Create a `ViewModel` class with a data collection property to render chart.

**[ViewModel]**

```
public class ViewModel
{
	public ObservableCollection<ChartModel> Data { get; set; }

	public ViewModel()
	{
		Data = new ObservableCollection<ChartModel>()
		{
			new ChartModel(){XValue = "Jewelry", YValue = 2000},
			new ChartModel(){XValue = "Electronics", YValue = 1500},
			new ChartModel(){XValue = "Research", YValue = 1300},
			new ChartModel(){XValue = "Investment", YValue = 1700 },
			new ChartModel(){XValue = "Purchases", YValue = 1000},
		};
	}
}

```
Step 3: Customize the axis labels using `LabelTemplate` property of the Chart axis.

**[XAML]**

  ```
<chart:SfChart>

    <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis ShowGridLines="False">
             <chart:CategoryAxis.LabelTemplate>
                <DataTemplate>
                    <Border Padding="3" Background="LightGreen" CornerRadius="4" >
                        <TextBlock Text="{Binding LabelContent}"
                                    FontWeight="Bold" Foreground="Black"/>
                    </Border>
                </DataTemplate>
            </chart:CategoryAxis.LabelTemplate>
        </chart:CategoryAxis>
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis Maximum="2500">
                <chart:NumericalAxis.LabelTemplate>
                <DataTemplate>
                    <Border Padding="3" Background="LightGreen" CornerRadius="4" >
                        <TextBlock Text="{Binding LabelContent}"
                                    FontWeight="Bold" Foreground="Black"/>
                    </Border>
                </DataTemplate>
            </chart:NumericalAxis.LabelTemplate>
        </chart:NumericalAxis>
    </chart:SfChart.SecondaryAxis>

    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="XValue" 
                        YBindingPath="YValue"
                        Palette="Metro">
        <chart:ColumnSeries.AdornmentsInfo>
            <chart:ChartAdornmentInfo ShowLabel="True" />
        </chart:ColumnSeries.AdornmentsInfo>
    </chart:ColumnSeries>
</chart:SfChart>

  ```

## Output:

![Binding CSV data to the WPF Charts](https://user-images.githubusercontent.com/61832185/209123493-97c5a17e-db8a-47cd-a652-1aefe36faf87.png)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

