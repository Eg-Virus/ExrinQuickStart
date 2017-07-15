﻿using ExrinQuickStart.Model;

namespace ExrinQuickStart.ViewModel
{
	/// <summary>
	/// This is a standard ViewModel.
	/// </summary>
	public class AboutViewModel : Exrin.Framework.ViewModel
	{
		private readonly IAppModel _model;
		public AboutViewModel(IAppModel model)
		{
			_model = model;
		}
	}
}
