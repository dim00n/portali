@Using mdl = Html.Bootstrap().Begin(New Modal() _
                                   .Fade _
                                   .Closeable _
                                   .Id("modalDialog") _
                                   .HtmlAttributes(New With {.role = "dialog", .aria_hidden = "true"}))
    @Using mdl.BeginHeader
        @<h3>@ViewData("modalDialogHeader")</h3>
    End Using
    
    @Using mdl.BeginBody
            @<p></p>
    End Using
    
    @Using mdl.BeginFooter
        @Using Html.Bootstrap().Begin(New Form(ViewData("modalDialogAction").ToString))
            @<input type="hidden" name="id" value="" />
               @Html.Bootstrap().SubmitButton().Value(ViewData("modalDialogAction")).Text(ViewData("modalDialogAction")).Style(ButtonStyle.Danger).Size(ButtonSize.Small)
               @Html.Bootstrap().Button().Text("Close").Style(ButtonStyle.Success).Size(ButtonSize.Small).HtmlAttributes(New With {.data_dismiss = "modal"})
        End Using
    End Using
End Using

@Html.Partial("Templates/" & ViewData("modalDialogMsgTemplate"))
