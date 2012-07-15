﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Coding4Fun.Phone.Controls.Converters
{
	public class ThemedImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ThemedImageConverterHelper.GetImage(parameter as string);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

}
