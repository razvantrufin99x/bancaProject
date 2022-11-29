using System;
using System.Collections.Generic;
using System.Text;

namespace bancaProject.banca
{
	public interface Operatiuni
	{
		double getSumaTotala();

		double getDobanda();

		void depunere(double suma);

		void extragere(double suma);
	}
}
