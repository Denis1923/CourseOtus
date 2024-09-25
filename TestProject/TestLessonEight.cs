using PlaceGame.Models;

namespace TestProject
{
	public class TestLessonEight
	{
		/// <summary>
		/// Для объекта, находящегося в точке (12, 5) и движущегося со скоростью (-7, 3) движение меняет положение объекта на (5, 8)
		/// </summary>
		[Fact]
		public void Test1()
		{
			// Arrange
			var location = new Vector { X = 12, Y = 5 };
			var velocity = new Vector { X = -7, Y = 3 };
			var alpha = new Vector { X = 12, Y = 5 };
			var alphaVelocity = new Vector { X = -7, Y = 3 };
			var spacecraft = new Spacecraft(location, velocity, alpha, alphaVelocity);

			// Act
			var moveSpacecraft = new Move(spacecraft);
			moveSpacecraft.Execute();

			// Assert
			Assert.Equal(5, location.X);
			Assert.Equal(8, location.Y);
		}

		/// <summary>
		/// Попытка сдвинуть объект, у которого невозможно прочитать положение в пространстве, приводит к ошибке
		/// </summary>
		[Fact]
		public void Test2()
		{

		}

		/// <summary>
		/// Попытка сдвинуть объект, у которого невозможно прочитать значение мгновенной скорости, приводит к ошибке
		/// </summary>
		[Fact]
		public void Test3()
		{

		}

		/// <summary>
		/// Попытка сдвинуть объект, у которого невозможно изменить положение в пространстве, приводит к ошибке
		/// </summary>
		[Fact]
		public void Test4()
		{

		}

		/// <summary>
		/// Для поворачивающегося объекта определен интерфейс, устойчивый к появлению новых видов движущихся объектов - 1 балл
		/// </summary>
		[Fact]
		public void Test5()
		{
			// Arrange
			var location = new Vector { X = 12, Y = 5 };
			var velocity = new Vector { X = -7, Y = 3 };
			var alpha = new Vector { X = 12, Y = 5 };
			var alphaVelocity = new Vector { X = -7, Y = 3 };
			var spacecraft = new Spacecraft(location, velocity, alpha, alphaVelocity);

			// Act
			var moveSpacecraft = new Rotate(spacecraft);
			moveSpacecraft.Execute();

			// Assert
			Assert.Equal(5, alpha.X);
			Assert.Equal(8, alpha.Y);
		}
	}
}