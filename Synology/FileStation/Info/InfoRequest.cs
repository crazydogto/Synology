﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Classes;

namespace Synology.FileStation.Info
{
	public class InfoRequest : SynologyRequest
	{
		public InfoRequest(SynologyConnection connection) : base(connection, "FileStation/info.cgi", "SYNO.FileStation.Info")
		{
		}

		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>("getinfo");
		}
	}
}