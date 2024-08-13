namespace PlaceGame.Models
{
	public class Spacecraft : IMove, IRotate
	{
		private Vector _location;
		private Vector _velocity;

		private Vector _alpha;
		private Vector _alphaVelocity;

		public Spacecraft(Vector location, Vector velocity, Vector alpha, Vector alphaVelocity)
		{
			_location = location;
			_velocity = velocity;
			_alpha = alpha;
			_alphaVelocity = alphaVelocity;
		}

		public Vector GetAlpha() => _alpha;

		public Vector GetAlphaVelocity() => _alphaVelocity;

		public Vector GetLocation() => _location;

		public Vector GetVelocity() => _velocity;

		public void SetAlpha(Vector vector)
		{
			_alpha.X = vector.X;
			_alpha.Y = vector.Y;
		}

		public void SetLocation(Vector vector)
		{
			_location.X = vector.X;
			_location.Y = vector.Y;
		}
	}
}
