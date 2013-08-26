using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FluentAssertions;
using Notes.Web.Controllers;
using NUnit.Framework;

namespace Notes.Specifications
{
    [TestFixture]
    public class Create_note_specifications
    {
        [Test]
        public void Can_create_a_note_specification()
        {
            // Arrange

            // Act
            var controllerUnderTest = new NoteController();
            var result = controllerUnderTest.CreateNote() as ViewResult;
            var model = result.Model as NoteModel;

            // Assert
            model.Should().BeOfType<NoteModel>();
        }
    }

    public class NoteModel
    {
    }
}
