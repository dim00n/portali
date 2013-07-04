Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class Migration3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.AssigningBodies", "AssigningBodyName", Function(c) c.String(nullable := False, maxLength := 60))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.AssigningBodies", "AssigningBodyName", Function(c) c.String(maxLength := 60))
        End Sub
    End Class
End Namespace
