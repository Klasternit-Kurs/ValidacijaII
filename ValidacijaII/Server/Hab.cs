using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ValidacijaII.Shared;

namespace ValidacijaII.Server
{
	public class Hab : Hub
	{
		public void ZaOsobu(ValidacijaII.Shared.Osoba o)
		{
			Console.WriteLine($"{o.Ime} -- {o.Prezime}");
			var os = new ValidacijaII.Shared.Osoba();
			os.Ime = "Neko";
			os.Prezime = "Nekic";
			Clients.Caller.SendAsync("Test", os);
		}
	}
}
