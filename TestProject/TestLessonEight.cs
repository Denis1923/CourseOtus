using PlaceGame.Models;

namespace TestProject
{
	public class TestLessonEight
	{
		/// <summary>
		/// ��� �������, ������������ � ����� (12, 5) � ����������� �� ��������� (-7, 3) �������� ������ ��������� ������� �� (5, 8)
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
		/// ������� �������� ������, � �������� ���������� ��������� ��������� � ������������, �������� � ������
		/// </summary>
		[Fact]
		public void Test2()
		{

		}

		/// <summary>
		/// ������� �������� ������, � �������� ���������� ��������� �������� ���������� ��������, �������� � ������
		/// </summary>
		[Fact]
		public void Test3()
		{

		}

		/// <summary>
		/// ������� �������� ������, � �������� ���������� �������� ��������� � ������������, �������� � ������
		/// </summary>
		[Fact]
		public void Test4()
		{

		}

		/// <summary>
		/// ��� ����������������� ������� ��������� ���������, ���������� � ��������� ����� ����� ���������� �������� - 1 ����
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