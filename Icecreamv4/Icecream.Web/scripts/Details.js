$(document).ready(function () {
    loadProduct();

});

function loadProduct() {
    var myProduct = FindMyProduct(getJsonFromUrl())
    buildMyProduct(myProduct);
}

function FindMyProduct(id) {
    var ProductDetails = "";
    $.each(MyCatalogData, function (element, object) {
        if (object.id == id)
            ProductDetails = object;
    });
    return ProductDetails;
}


//Dynamic build your collection
function buildMyProduct(myProduct) {
    var html = "";
    html += "<div class='Catalog ProductItem'>";
    html += "<div>" + myProduct.title + "</a></div>";
    html += "<div>" + myProduct.Model + "</a></div>";
    html += "<div>" + myProduct.Price + "</a></div>";
    html += "<div>" + myProduct.Description + "</a></div>";
    html += "<div><img class='Catalog MainImage' src='" + myProduct.imgUrl + "' /></div>";
    for (i in myProduct.img) {
        //x += myProduct.img[i];
        html += "<div><img class='Catalog img' src='" + myProduct.img[i] + "' /></div>";
    }
    html += "</div>";

    $("#MyDynamicProductDetail").append(html);
}

function getJsonFromUrl() {
    var query = location.search.substr(1);
    var result = {};
    query.split("&").forEach(function (part) {
        var item = part.split("=");

        //Decode to avoid errors due to blank spaces on the URL
        result[item[0]] = decodeURIComponent(item[1]);
    });
    //we need only the ID
    return result.id;
}
