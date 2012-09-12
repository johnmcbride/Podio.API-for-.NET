using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Embed 
	{


		[DataMember(Name = "embed_id", IsRequired=false)]
		public int EmbedId { get; set; }


		[DataMember(Name = "original_url", IsRequired=false)]
		public string OriginalUrl { get; set; }


		[DataMember(Name = "resolved_url", IsRequired=false)]
		public string ResolvedUrl { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "description", IsRequired=false)]
		public string Description { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "provider_name", IsRequired=false)]
		public string ProviderName { get; set; }


		[DataMember(Name = "embed_html", IsRequired=false)]
		public string EmbedHtml { get; set; }


		[DataMember(Name = "embed_height", IsRequired=false)]
		public bool EmbedHeight { get; set; }


		[DataMember(Name = "embed_width", IsRequired=false)]
		public int EmbedWidth { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


	}
}
