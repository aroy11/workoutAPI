using FSD.WorkoutTracker.Controllers;
using FSD.WorkoutTracker.Core.Entities;
using FSD.WorkoutTracker.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace FSD.WorkoutTracker.Tests.Controllers
{
    [TestClass]
    public class WorkoutsControllerTest
    {
        private Mock<IRepository<Workout_Active>> activeWorkoutsRepository = null;
        private Mock<IRepository<Workout_Collection>> workoutRepository = null;

        [TestInitialize]
        public void Init()
        {
            activeWorkoutsRepository = new Mock<IRepository<Workout_Active>>();
            workoutRepository = new Mock<IRepository<Workout_Collection>>();
        }

        [TestMethod()]
        public void GetWorkoutsTest()
        {
            // Arrange
            workoutRepository.Setup(x => x.GetAll()).Returns(new List<Workout_Collection>() { new Workout_Collection() { Workout_Title = "Jogging for 10 min" } });
            WorkoutsController controller = new WorkoutsController(workoutRepository.Object);

            // Act
            List<Workout_Collection> result = controller.GetWorkouts() as List<Workout_Collection>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod()]
        public void GetTestSuccess()
        {
            // Arrange
            workoutRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(new Workout_Collection() { Workout_Id = 5 });
            WorkoutsController controller = new WorkoutsController(workoutRepository.Object);

            // Act
            Workout_Collection result = controller.Get(5) as Workout_Collection;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Workout_Id == 5);
        }

        [TestMethod()]
        public void AddWorkoutTestSuccess()
        {
            // Arrange
            workoutRepository.Setup(x => x.Insert(It.IsAny<Workout_Collection>()));
            WorkoutsController controller = new WorkoutsController(workoutRepository.Object);

            // Act
            controller.AddWorkout(new Workout_Collection());

            // Assert
        }

        [TestMethod()]
        public void EditWorkoutTest()
        {
            // Arrange
            workoutRepository.Setup(x => x.Update(It.IsAny<Workout_Collection>()));
            WorkoutsController controller = new WorkoutsController(workoutRepository.Object);

            // Act
            controller.EditWorkout(new Workout_Collection());

            // Assert
        }

        [TestMethod()]
        public void DeleteTest()
        {
            // Arrange
            workoutRepository.Setup(x => x.Delete(It.IsAny<int>()));
            WorkoutsController controller = new WorkoutsController(workoutRepository.Object);

            // Act
            controller.Delete(5);

            // Assert
        }

        [TestMethod()]
        public void StartWorkoutTest()
        {
            // Arrange
            activeWorkoutsRepository.Setup(x => x.Insert(new Workout_Active()));
            WorkoutsController controller = new WorkoutsController(activeWorkoutsRepository.Object);

            // Act
            controller.StartWorkout(new Workout_Active());

            // Assert
        }

        [TestMethod()]
        public void EndWorkoutTest()
        {
            // Arrange
            activeWorkoutsRepository.Setup(x => x.Insert(new Workout_Active()));
            WorkoutsController controller = new WorkoutsController(activeWorkoutsRepository.Object);

            // Act
            controller.EndWorkout(new Workout_Active());

            // Assert
        }
    }
}
