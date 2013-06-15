Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class Migration
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.MyApplications", "Implemented", Function(c) c.Boolean(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.MyApplications", "Implemented")
        End Sub
    End Class
End Namespace
