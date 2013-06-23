<!-- FOOTER -->
        <div id="footer" class="container">
            <div class="float-left">
                <p class="muted credit">
                    &copy; @DateTime.Now.Year - @ConfigurationManager.AppSettings("App.Copyright")
                </p>
            </div>
            <div class="float-right">
                @If (User.IsInRole("Admin") AndAlso Not Request.RawUrl.StartsWith("/Elmah")) Then
                    @Html.ActionLink("Error Log", "Index", "Elmah", New With {.area = ""}, New With {.target = "_blank"}) @<text>|</text>
                End If
                @If (User.IsInRole("Admin") AndAlso Not Request.RawUrl.StartsWith("/Admin")) Then
                    @Html.ActionLink("Admin", "Index", "Admin/Users") @<text>|</text>
                End If
                @Html.ActionLink("About", "About", New With {.area = "", .controller = "Home"}) |
                @Html.ActionLink("Contact", "Contact", New With {.area = "", .controller="Home"})
            </div>
        </div>
<!-- END FOOTER -->