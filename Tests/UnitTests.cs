using CourseWork2.Model;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void CanAddLessonToRepository()
        {
            //arrange
            IRepository repository = Repository.GetInstance();
            Lesson lesson = new();

            //act
            repository.AddLesson(lesson);

            //assert
            Assert.NotEmpty(repository.GetLessons());
        }
        [Fact]
        public void CanAddIntervalToRepository()
        {
            //arrange
            IRepository repository = Repository.GetInstance();
            Interval interval = new(10, 30, 12, 20);
            //act
            repository.AddInterval(interval);

            //assert
            Assert.NotEmpty(repository.GetIntervals());
        }
        [Fact]
        public void CanAddTeacherToRepository()
        {
            //arrange
            IRepository repository = Repository.GetInstance();
            Teacher teacher = new Teacher("Воронков", "Вадим", "Витальевич");

            //act
            repository.AddTeacher(teacher);

            //assert
            Assert.NotEmpty(repository.GetTeachers());
        }
        [Fact]
        public void CanAddDayToRepository()
        {
            //arrange
            IRepository repository = Repository.GetInstance();
            Day day = new Day(DateTime.Today);

            //act
            repository.AddDay(day);

            //assert
            Assert.NotEmpty(repository.GetDays());
        }
        [Fact]
       
        public void CanAddRoomToRepository()
        {
            //arrange
            IRepository repository = Repository.GetInstance();
            Room room = new(100);

            //act
            repository.AddRoom(room);

            //assert
            Assert.NotEmpty(repository.GetRooms());
        }
        
    }
}