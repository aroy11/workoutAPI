using FSD.WorkoutTracker.Controllers;
using FSD.WorkoutTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FSD.WorkoutTracker.Tests.Controllers
{
    [TestClass]
    public class WorkoutsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            WorkoutsController controller = new WorkoutsController();

            // Act
            List<Workout> result = controller.Get() as List<Workout>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            WorkoutsController controller = new WorkoutsController();

            // Act
            Workout workout = controller.Get(5);

            // Assert
            Assert.AreEqual(5, workout.WorkoutId);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            WorkoutsController controller = new WorkoutsController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            WorkoutsController controller = new WorkoutsController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            WorkoutsController controller = new WorkoutsController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
