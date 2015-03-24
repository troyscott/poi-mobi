using System;
using System.IO;

namespace POIApp
{
	public class POIJsonService : IPOIDataService
	{
		private string _storagePath;

		public POIJsonService (string storagePath)
		{

			_storagePath = storagePath;

			// create the storage path if it does not exist
			if (!Directory.Exists (_storagePath))
				Directory.CreateDirectory (_storagePath);

			RefreshCache ();



		}

		#region IPOIDataService implementation

		public void RefreshCache ()
		{
			throw new NotImplementedException ();
		}

		public PointOfInterest GetPOI (int id)
		{
			throw new NotImplementedException ();
		}

		public void SavePOI (PointOfInterest poi)
		{
			throw new NotImplementedException ();
		}

		public void DeletePOI (PointOfInterest poi)
		{
			throw new NotImplementedException ();
		}

		public System.Collections.Generic.IReadOnlyList<PointOfInterest> POIs {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion
	}
}

