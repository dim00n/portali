@Using Html.Bootstrap().Begin(New FormActions())
    @Html.Bootstrap().SubmitButton().Value("Save").Text("Save").Style(ButtonStyle.Success).Size(ButtonSize.Small) @<span>|</span>
    @Html.Bootstrap().ActionLinkButton("Back to List", "Index").Style(ButtonStyle.Primary).Size(ButtonSize.Small)
End Using