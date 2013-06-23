@ModelType IPagedList(Of PortalI.INISRecord)

@Code
    ViewData("Title") = "INIS Records"
End Code

@*<div class="dropdown">
<a class="btn btn-mini dropdown-toggle" id="drop4" role="button" data-toggle="dropdown" href="#"><b class="caret"></b></a>
<ul class="dropdown-menu" role="menu" aria-labelledby="dLabel">
                  <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
                  <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
                  <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                  <li role="presentation" class="divider"></li>
                  <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
</ul>
</div>
*@
<div class="dropdown">
<h2>@ViewData("Title")</h2>
<a class="dropdown-toggle pull-right" id="drop4" role="button" data-toggle="dropdown" href="#"><b class="caret"></b></a>
<ul id="menu1" class="dropdown-menu" role="menu" aria-labelledby="drop4">
    <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
    <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
    <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
    <li role="presentation" class="divider"></li>
    <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
</ul>
</div>

@*@Using dropDown = Html.Bootstrap().Begin(New DropDown(""))
    @dropDown.Link("Personality Match", "http://www.personalitymatch.net")
    @dropDown.ActionLink("Another Link", "Index")
    dropDown.Divider()
    @dropDown.ActionLink("Another Link2", "someAction2")
End Using
*@

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_INISRecords", Model)

