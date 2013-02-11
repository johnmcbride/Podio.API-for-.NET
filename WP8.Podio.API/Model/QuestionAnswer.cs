using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class QuestionAnswer
	{


		[DataMember(Name = "question_option_id", IsRequired=false)]
		public int? QuestionOptionId { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public Contact User { get; set; }


	}
}
