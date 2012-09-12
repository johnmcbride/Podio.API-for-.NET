using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Tag 
	{


		[DataMember(Name = "count", IsRequired=false)]
		public int Count { get; set; }


		[DataMember(Name = "text", IsRequired=false)]
		public string Text { get; set; }


	}
}
