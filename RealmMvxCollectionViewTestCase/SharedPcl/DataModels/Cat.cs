using System;
using Realms;

namespace SharedPcl.DataModels
{
	public class Cat : RealmObject
	{
		[PrimaryKey]
		public string Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
	}
}
