using Models;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void SetName_ThrowsException_WhenNameIsNull()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => builder.SetName(null));
        }

        [Fact]
        public void SetTask_ThrowsException_WhenTaskIsNull()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => builder.SetTask(null));
        }

        [Fact]
        public void SetInterval_ThrowsException_WhenIntervalIsNull()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => builder.SetInterval(null));
        }

        [Fact]
        public void SetTeacher_ThrowsException_WhenTeacherIsNull()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => builder.SetTeacher(null));
        }

        [Fact]
        public void SetRoom_ThrowsException_WhenRoomIsNull()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => builder.SetRoom(null));
        }

        [Fact]
        public void SetDay_ThrowsException_WhenDayIsNull()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => builder.SetDay(null));
        }

        [Fact]
        public void Build_ReturnsLesson_WithNonNullProperties()
        {
            // Arrange
            LessonBuilder builder = Lesson.CreateBuilder()
                .SetName("Math")
                .SetTask("CompleteHW")
                .SetProgress(true)
                .SetInterval(new Interval(1,5,2,3))
                .SetTeacher(new Teacher("Vadim", "Voronkov", "Voronkov"))
                .SetRoom(new Room(150))
                .SetDay(new Day(DateTime.Today));

            // Act
            Lesson lesson = builder.Build();

            // Assert
            Assert.NotNull(lesson);
            Assert.NotNull(lesson.Name);
            Assert.NotNull(lesson.Task);
            Assert.NotNull(lesson.Interval);
            Assert.NotNull(lesson.Teacher);
            Assert.NotNull(lesson.Room);
            Assert.NotNull(lesson.Day);
        }
        [Fact]
        public void Constructor_ThrowsException_WhenFirstNameIsNull()
        {
            // Arrange
            string firstName = null;
            string secondName = "Voronkov";
            string surname = "Voronkov";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Teacher(firstName, secondName, surname));
        }

        [Fact]
        public void Constructor_ThrowsException_WhenSecondNameIsNull()
        {
            // Arrange
            string firstName = "Vadim";
            string secondName = null;
            string surname = "Voronkov";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Teacher(firstName, secondName, surname));
        }

        [Fact]
        public void Constructor_ThrowsException_WhenSurnameIsNull()
        {
            // Arrange
            string firstName = "Vadim";
            string secondName = "Voronkov";
            string surname = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Teacher(firstName, secondName, surname));
        }

        [Fact]
        public void Constructor_DoesNotThrowException_WhenAllParametersAreNonNull()
        {
            // Arrange
            string firstName = "Vadim";
            string secondName = "Voronkov";
            string surname = "Voronkov";

            // Act & Assert
            Assert.NotNull(new Teacher(firstName, secondName, surname));
        }

    }
}