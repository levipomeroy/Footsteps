var input = document.getElementById('LocationSearcherForForm');
var autocomplete = new google.maps.places.Autocomplete(input);
autocomplete.addListener('place_changed', function () {
    var place = autocomplete.getPlace();
    var address;
    document.getElementById('Latitude').value = place.geometry.location.lat();
    document.getElementById('Longitude').value = place.geometry.location.lng();
    for (var i = 0; i < place.address_components.length; i++) {
        for (var b = 0; b < place.address_components[i].types.length; b++) {
            if (place.address_components[i].types[b] === "country") {
                document.getElementById('Country').value = place.address_components[i].long_name;
            }
        }
    }
    //document.getElementById('Category').value = 0;

});
