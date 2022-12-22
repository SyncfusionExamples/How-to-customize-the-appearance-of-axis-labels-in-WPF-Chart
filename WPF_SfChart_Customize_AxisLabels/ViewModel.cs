using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SfChart_Customize_AxisLabels
{
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
}
