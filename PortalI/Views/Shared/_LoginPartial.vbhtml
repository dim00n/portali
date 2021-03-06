﻿@If Request.IsAuthenticated Then
        @<i class="icon-user"></i>
        @Html.ActionLink(User.Identity.Name, "Manage", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.class = "username", .title = "Manage"})
        @Using Html.BeginForm("LogOff", "Account", New With {.area = ""}, FormMethod.Post, New With {.id = "logoutForm"})
            @Html.AntiForgeryToken()
            @<button type="submit" value="Log off" class="btn btn-mini btn-link">Log off</button>
        End Using
Else
     @<ul id="menu" class="nav nav-pills pull-right">
       <li>@Html.ActionLink("Register", "Register", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.id = "registerLink"})</li>
       <li>@Html.ActionLink("Log in", "Login", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.id = "loginLink"})</li>
   </ul>
End If
 