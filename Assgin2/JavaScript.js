window.onload = load();

function load() {
    var a = new Date();
    $get("time").innerHTML = a;



}
var onClick = function () {
    //var a = new Date();
    //$get("time").innerHTML = a;

    var option = $get('option');
    //$get("postCode").innerHTML = option.options[option.selectedIndex].value;
    AJAX.GetPostCode(option.options[option.selectedIndex].value, onSuccess, onFailed);

}

var onSuccess = function (result) {
    $get("postCode").innerHTML = result;


}

var onFailed = function (result) {
    $get("postCode").innerHTML = "Wrong input";
}