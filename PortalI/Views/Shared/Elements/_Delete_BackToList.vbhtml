@Using Html.Bootstrap().Begin(New Form())
    @<input type="hidden" name="id" value="@ViewData("id")" />
@Using Html.Bootstrap().Begin(New FormActions())
    @Html.Bootstrap().SubmitButton().Value("Delete").Text("Delete").Style(ButtonStyle.Danger).Size(ButtonSize.Small) @<span>|</span>
    @Html.Bootstrap().ActionLinkButton("Back to List", "Index").Style(ButtonStyle.Primary).Size(ButtonSize.Small)
End Using
End Using