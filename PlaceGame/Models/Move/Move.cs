
namespace PlaceGame.Models
{
	public class Move
	{
		IMove _move;

        public Move(IMove move)
		{
			_move = move;
		}

		public void Execute()
		{
			_move.SetLocation(new Vector
			{
				X = _move.GetLocation().X + _move.GetVelocity().X,
				Y = _move.GetLocation().Y + _move.GetVelocity().Y
			});
		}
	}
}
