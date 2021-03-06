﻿<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ConfigurationManager.AppSettings("App.Name") - @ViewData("Title")</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
    </head>
    <body>
        @Html.Partial("Elements/_Header")

        <div id="body" class="container">
            <section class="main-content content-wrapper">
                @RenderBody()
            </section>
        </div>

        @Html.Partial("Elements/_Footer")

        @Scripts.Render("~/bundles/portali")
        @RenderSection("scripts", required:=False)
    </body>
</html>
