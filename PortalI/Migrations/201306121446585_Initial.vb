Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class Initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.MyApplications",
                Function(c) New With
                    {
                        .MyApplicationID = c.Int(nullable:=False, identity:=True),
                        .AppTypeId = c.Int(nullable:=False),
                        .Name = c.String(nullable:=False, maxLength:=60),
                        .Description = c.String()
                    }) _
                .PrimaryKey(Function(t) t.MyApplicationID) _
                .ForeignKey("dbo.ApplicationTypes", Function(t) t.AppTypeId, cascadeDelete:=True) _
                .Index(Function(t) t.AppTypeId)

            'Foreign Key w/o data verification
            'ALTER TABLE [dbo].[MyApplications]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.MyApplications_dbo.ApplicationTypes_AppTypeId] FOREIGN KEY([AppTypeId])
            'REFERENCES([dbo].[ApplicationTypes]([AppTypeId]))
            'GO
            'ALTER TABLE [dbo].[MyApplications] CHECK CONSTRAINT [FK_dbo.MyApplications_dbo.ApplicationTypes_AppTypeId]

            CreateTable(
                "dbo.ApplicationTypes",
                Function(c) New With
                    {
                        .AppTypeId = c.Int(nullable:=False, identity:=True),
                        .AppType = c.String(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.AppTypeId)

            CreateTable(
                "dbo.AssigningBodies",
                Function(c) New With
                    {
                        .AssigningBodyCode = c.String(nullable:=False, maxLength:=2),
                        .AssigningBodyName = c.String(maxLength:=60),
                        .AssigningBodyAdjective = c.String(maxLength:=30)
                    }) _
                .PrimaryKey(Function(t) t.AssigningBodyCode)

            CreateTable(
                "dbo.Languages",
                Function(c) New With
                    {
                        .LCode = c.String(nullable:=False, maxLength:=2),
                        .LNameEnglish = c.String(nullable:=False, maxLength:=60),
                        .LNameOriginal = c.String(maxLength:=255)
                    }) _
                .PrimaryKey(Function(t) t.LCode)

            CreateTable(
                "dbo.UserProfile",
                Function(c) New With
                    {
                        .UserId = c.Int(nullable:=False, identity:=True),
                        .UserName = c.String(maxLength:=64),
                        .MainRole = c.String(maxLength:=64)
                    }) _
                .PrimaryKey(Function(t) t.UserId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.MyApplications", New String() { "AppTypeId" })
            DropForeignKey("dbo.MyApplications", "AppTypeId", "dbo.ApplicationTypes")
            DropTable("dbo.UserProfile")
            DropTable("dbo.Languages")
            DropTable("dbo.AssigningBodies")
            DropTable("dbo.ApplicationTypes")
            DropTable("dbo.MyApplications")
        End Sub
    End Class
End Namespace
