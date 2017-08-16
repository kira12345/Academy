//Create a JSON Object that contains my products information.

//Ready: After HTML loads
$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct(MyCatalogData));
});


//Dynamic build your collection
function buildMyProduct(obj){
    var html="";
    $.each(obj,function(element, object){
            //html += "<div class='Catalog ProducItem'>"
            html += "<div><a href='Detail.html?id=" + object.id + "'>" + object.title + "</a></div>";
            html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
            html += "<div>" + object.Description + "</div></div>";
    });
    return html;
}

//Ajax
function  GetAllProducts(){
    $.ajax({
        type: 'GET',
        url: 'http://localhost:51848/api/product',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
        },
        error: function (a, b, c) {
        }
    });
}
    

