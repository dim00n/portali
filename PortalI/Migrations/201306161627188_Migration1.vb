Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class Migration1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.MyApplications", "MyApplicationID", Function(c) c.Int(nullable := False))
            DropPrimaryKey("dbo.MyApplications", New String() { "MyApplicationID" })
            AddPrimaryKey("dbo.MyApplications", "Name")
        End Sub
        
        Public Overrides Sub Down()
            DropPrimaryKey("dbo.MyApplications", New String() { "Name" })
            AddPrimaryKey("dbo.MyApplications", "MyApplicationID")
            AlterColumn("dbo.MyApplications", "MyApplicationID", Function(c) c.Int(nullable := False, identity := True))
        End Sub
    End Class
End Namespace
