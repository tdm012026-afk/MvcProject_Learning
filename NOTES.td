@model List<Product>

<h1>Product list</h1>

@* HTML table – creates the entire table *@
@*
   Bootstrap classes:
   table – applies the basic table styling
   table-striped – adds alternating row colors
   table-bordered – adds borders around table cells
   table-hover – highlights a row when the mouse hovers over it
*@
<table class="table table-striped table-bordered table-hover">

    @* thead – contains the table header *@
    <thead>
        <tr>
            @* tr – creates a table row *@

            @* th – defines a header cell *@
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
        </tr>
    </thead>

    @* tbody – contains the table data *@
    <tbody>
        @foreach (var product in Model)
        {
            @* Creates a separate row for each product *@
            <tr>
                <td>@product.Id</td>
                <td>@product.Name</td>
                <td>@product.Price</td>
            </tr>
        }
    </tbody>
</table>