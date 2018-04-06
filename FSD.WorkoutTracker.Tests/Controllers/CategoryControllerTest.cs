using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FSD.WorkoutTracker.Controllers;
using FSD.WorkoutTracker.Core.Entities;
using System.Collections.Generic;
using Moq;
using FSD.WorkoutTracker.DataAccess;

namespace FSD.WorkoutTracker.Tests.Controllers
{
    [TestClass]
    public class CategoryControllerTest
    {
        private Mock<IRepository<Workout_Category>> categoryRepository = null;

        [TestInitialize]
        public void Init()
        {
            categoryRepository = new Mock<IRepository<Workout_Category>>();
        }

        [TestMethod]
        public void GetCategoriesTestSuccess()
        {
            // Arrange
            categoryRepository.Setup(x => x.GetAll()).Returns(new List<Workout_Category>() { new Workout_Category() { Category_Name = "Jogging" } });
            CategoriesController controller = new CategoriesController(categoryRepository.Object);

            // Act
            List<Workout_Category> result = controller.GetCategories() as List<Workout_Category>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }


        [TestMethod]
        public void PostCategoryTestSuccess()
        {
            // Arrange
            categoryRepository.Setup(x => x.Insert(It.IsAny<Workout_Category>()));
            CategoriesController controller = new CategoriesController(categoryRepository.Object);

            // Act
            controller.AddCategories(new Workout_Category());

            // Assert
        }

        [TestMethod]
        public void PutCategoryTestSuccess()
        {
            // Arrange
            categoryRepository.Setup(x => x.Update(It.IsAny<Workout_Category>()));
            CategoriesController controller = new CategoriesController(categoryRepository.Object);

            // Act
            controller.Put(new Workout_Category());

            // Assert
        }

        [TestMethod]
        public void DeleteCategoryTestSuccess()
        {
            // Arrange
            categoryRepository.Setup(x => x.Delete(It.IsAny<int>()));
            CategoriesController controller = new CategoriesController(categoryRepository.Object);

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
