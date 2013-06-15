Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports WebMatrix.WebData

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of PortalIDb)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As PortalIDb)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data. E.g.
            '
            '    context.People.AddOrUpdate(
            '       Function(c) c.FullName,
            '       New Customer() With {.FullName = "Andrew Peters"},
            '       New Customer() With {.FullName = "Brice Lambson"},
            '       New Customer() With {.FullName = "Rowan Miller"})

            Call SeedMembership()
            Call SeedAppTypes(context)
        End Sub

        Private Sub SeedMembership()
            If (Not WebSecurity.Initialized) Then
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables:=True)
            End If

            Dim myRoles As SimpleRoleProvider = Roles.Provider
            Dim myMembership As SimpleMembershipProvider = Membership.Provider

            If (Not myRoles.RoleExists("Admin")) Then
                myRoles.CreateRole("Admin")
            End If

            If (myMembership.GetUser("dmitry", False) Is Nothing) Then
                myMembership.CreateUserAndAccount("dmitry", "123456")
            End If

            If (Not myRoles.GetRolesForUser("dmitry").Contains("Admin")) Then
                myRoles.AddUsersToRoles(New String() {"dmitry"}, New String() {"Admin"})
            End If
        End Sub

        Private Sub SeedAppTypes(context As PortalIDb)
            context.AppTypes.AddOrUpdate(Function(x) x.AppTypeId,
                    New ApplicationType With {.AppTypeId = ApplicationType.AppTypes.Authority,
                                                .AppType = [Enum].GetName(GetType(ApplicationType.AppTypes), ApplicationType.AppTypes.Authority)},
                    New ApplicationType With {.AppTypeId = ApplicationType.AppTypes.Application,
                                                .AppType = [Enum].GetName(GetType(ApplicationType.AppTypes), ApplicationType.AppTypes.Application)},
                    New ApplicationType With {.AppTypeId = ApplicationType.AppTypes.Service,
                                                .AppType = [Enum].GetName(GetType(ApplicationType.AppTypes), ApplicationType.AppTypes.Service)}
            )

        End Sub

    End Class

End Namespace
