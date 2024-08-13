using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceGame.Models
{
	public class Rotate
	{
		private IRotate _rotate;

        public Rotate(IRotate rotate)
        {
			_rotate = rotate;
        }

		public void Execute()
		{
			_rotate.SetAlpha(new Vector
			{
				X = _rotate.GetAlpha().X + _rotate.GetAlphaVelocity().X,
				Y = _rotate.GetAlpha().Y + _rotate.GetAlphaVelocity().Y
			});
		}
    }
}
