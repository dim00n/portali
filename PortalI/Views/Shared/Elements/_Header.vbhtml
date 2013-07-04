<!-- HEADER -->
        <div id="header" class="container">
            <div class="float-left">
@*           <a href="@Url.Action("Index", "Home")">
                <img src="~/Content/images/product-name.gif" alt="INIS" />
            </a>
*@
                <p class="site-title muted">
                    <a href="@Url.Action("Index", "MyApplication")">
                        @ConfigurationManager.AppSettings("App.Name")
                    </a>
                </p>
            </div>
            <section id="login">
                @Html.Partial("_LoginPartial")
            </section>
        </div>
<!-- END HEADER -->