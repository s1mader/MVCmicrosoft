🔹 Why the view (productview) uses Model instead of ViewData or ViewBag:
1. Controller to View - "Strongly Typed Models"
When you pass a model directly into the View() method, like this:


return View(products);
The data (products) is automatically set as the view’s Model.
When your controller returns View(products), 
the MVC framework sets the model property of the view to the passed data.


in index.cshtml,
in the view we set the model as 
@model IEnumerable<MVCmicrosoft.Models.ProductModel>
This makes your data strongly typed, allowing you to use it directly:
@foreach(var product in Model)
{
    <p>@product.Name</p>
}




ViewBag/ViewData:

Are loosely typed (dynamic or dictionary-based).
Can store simple values easily (messages, flags, titles).
Do not enforce type safety and are less clear about what they contain


