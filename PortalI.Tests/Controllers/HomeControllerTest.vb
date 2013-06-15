Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PortalI

<TestClass()> Public Class HomeControllerTest
    Private _db As FakePortalIDb

    <TestInitialize()> Public Sub Initialize()
        _db = New FakePortalIDb()
    End Sub

    <TestCleanup()> Public Sub Cleanup()
        _db.Dispose()
    End Sub

    <TestMethod()> Public Sub Index()
        ' Arrange
        _db.AddSet(TestData.MyApplications)
        Dim controller As New HomeController(_db)
        controller.ControllerContext = New FakeControllerContext()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Index(), ViewResult)

        ' Assert
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.AreEqual(String.Empty, viewData("Message"))
    End Sub

    <TestMethod()> Public Sub About()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.About(), ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod()> Public Sub Contact()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Contact(), ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

    <TestMethod()> Public Sub AppMenu()
        ' Arrange
        _db.AddSet(TestData.MyApplications)
        Dim controller As New HomeController(_db)
        controller.ControllerContext = New FakeControllerContext()

        ' Act
        Dim result As PartialViewResult = DirectCast(controller.AppMenu(), PartialViewResult)
        Dim model As IEnumerable(Of MyApplication) = DirectCast(result.Model, IEnumerable(Of MyApplication))

        ' Assert
        Assert.IsNotNull(result)
        Assert.AreEqual(3, model.Count)
    End Sub
End Class
