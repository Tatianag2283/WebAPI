using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHaven.WebApi.Models
{
	public class Message
	{
		public int? MessageID { get; set; }
		public User Sender { get; set; }
		public User Recipient { get; set; }
		public DateTime DateSent { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public string[] AcceptableResponses { get; set; }

		#region Received message properties

		public int? MessageRecipientID { get; set; }
		public string Response { get; set; }
		public DateTime? ResponseDate { get; set; }
		public bool? Unread { get; set; }

		#endregion

		#region Sent message properties

		public Dictionary<string, int> Responses { get; set; }
		public int? RecipientCount;
		public int? UndeliverableCount;
		public int? NoResponseCount;

		#endregion
	}
}
