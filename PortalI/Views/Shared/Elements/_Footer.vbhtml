<!-- FOOTER -->
        <div id="footer" class="container">
            <div class="float-left">
                <p class="muted credit">
                    &copy; @DateTime.Now.Year - @ConfigurationManager.AppSettings("App.Copyright")
                </p>
            </div>
            <div class="float-right">
                @If (User.IsInRole("Admin")) Then
                    @Html.ActionLink("Error Log", "Index", "Elmah", Nothing, New With {.target = "_blank"}) @<text>|</text>
                End If
                @Html.ActionLink("About", "About", "Home") |
                @Html.ActionLink("Contact", "Contact", "Home")
            </div>
        </div>
<!-- END FOOTER -->