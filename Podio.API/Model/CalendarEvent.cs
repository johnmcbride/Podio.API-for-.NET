using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class CalendarEvent 
	{


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "id", IsRequired=false)]
		public int Id { get; set; }


		[DataMember(Name = "group", IsRequired=false)]
		public string Group { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "description", IsRequired=false)]
		public string Description { get; set; }


		[DataMember(Name = "location", IsRequired=false)]
		public string Location { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "start", IsRequired=false)]
		public DateTime Start { get; set; }


		[DataMember(Name = "start_date", IsRequired=false)]
		public DateTime StartDate { get; set; }


		[DataMember(Name = "start_time", IsRequired=false)]
		public string StartTime { get; set; }


		[DataMember(Name = "end", IsRequired=false)]
        public DateTime End { get; set; }


		[DataMember(Name = "end_date", IsRequired=false)]
		public DateTime EndDate { get; set; }


		[DataMember(Name = "end_time", IsRequired=false)]
		public string EndTime { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


	}
}
