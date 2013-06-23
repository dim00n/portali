Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class Migration2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.MyApplications", "MyApplicationID", Function(c) c.Int(nullable := False, identity := True))
            DropPrimaryKey("dbo.MyApplications", New String() { "Name" })
            AddPrimaryKey("dbo.MyApplications", "MyApplicationID")
        End Sub
        
        Public Overrides Sub Down()
            DropPrimaryKey("dbo.MyApplications", New String() { "MyApplicationID" })
            AddPrimaryKey("dbo.MyApplications", "Name")
            AlterColumn("dbo.MyApplications", "MyApplicationID", Function(c) c.Int(nullable := False))
        End Sub
    End Class
End Namespace
