﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;
using log4net;
using MSSQLServerAuditor.Gui;
using MSSQLServerAuditor.Model.Scheduling;
using MSSQLServerAuditor.Model.Settings;

namespace MSSQLServerAuditor.Model
{
	[Serializable]
	public class TemplateTreeTitle
	{
		private List<TemplateNodeLocaleInfo> _locales;

		TemplateTreeTitle()
		{
			this._locales = null;
		}

		/// <summary>
		/// Localization of the node
		/// </summary>
		[XmlElement(ElementName = "i18n")]
		public List<TemplateNodeLocaleInfo> Locales
		{
			get
			{
				return this._locales;
			}

			set
			{
				this._locales = value;
			}
		}
	}
}
