using System;
using System.Collections.Generic;
using System.Linq;
using Realms;

// Minimal realm service to reproduce issue
namespace SharedPcl.Services
{
	public interface IRealmService
	{
		IQueryable<T> QueryAll<T>() where T : RealmObject;
		void AddOrUpdate<T>(IEnumerable<T> items) where T : RealmObject;
	}

	public class RealmService : IRealmService
	{
		private Realm _realm;

		public RealmService()
		{
			_realm = Realm.GetInstance();
		}

		public RealmService(string databasePath)
		{
			_realm = Realm.GetInstance(databasePath);
		}

		public RealmService(RealmConfiguration config)
		{
			_realm = Realm.GetInstance(config);
		}

		public IQueryable<T> QueryAll<T>() where T : RealmObject
		{
			return _realm.All<T>();
		}

		public void AddOrUpdate<T>(IEnumerable<T> items) where T : RealmObject
		{
			if (items.Count() == 0)
				return;

			_realm.Write(() =>
			{
				foreach (var item in items)
				{
					_realm.Add<T>(item, true);
				}
			});
		}
	}
}
