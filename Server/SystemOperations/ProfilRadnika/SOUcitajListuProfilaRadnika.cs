using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ProfilRadnika
{
	internal class SOUcitajListuProfilaRadnika : SOBase
	{
		private Common.Domain.ProfilRadnika profilRadnika;
		public List<IEntity> result;

		public SOUcitajListuProfilaRadnika(Common.Domain.ProfilRadnika profilRadnika)
		{
			this.profilRadnika = profilRadnika;
		}

		protected override async Task ExecuteConcreteOperationAsync()
		{
			result = await broker.ReadAllAsync(profilRadnika);
		}
	}
}
