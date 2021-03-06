﻿namespace WopiHost.Models
{
	/// <summary>
	/// Implemented in accordance with http://wopi.readthedocs.io/projects/wopirest/en/latest/ecosystem/GetRootContainer.html#required-response-properties
	/// </summary>
	public class RootContainerInfo
	{
		public ChildContainer ContainerPointer { get; set; }

		public CheckContainerInfo ContainerInfo { get; set; }
	}
}
