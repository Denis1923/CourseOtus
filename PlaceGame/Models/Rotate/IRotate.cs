using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceGame.Models
{
	public interface IRotate
	{
		Vector GetAlpha();
		Vector GetAlphaVelocity();
		void SetAlpha(Vector vector);
	}
}
