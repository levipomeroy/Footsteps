src = "https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js";

/**********************************************************************
 * Purpose: This function creates the initial map object and sets the 
 *          properties. 
 **********************************************************************/
var map;
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 32.854980, lng: 0 }, //centerish of the world
        zoom: 2,
        minZoom: 2,
        streetViewControl: false,   //removes streetview button
        mapTypeControl: false    //remove map/salelite toggle option buttons
    });
    var input = document.getElementById('SearchBar');

    var autocomplete = new google.maps.places.Autocomplete(input);
    autocomplete.setFields(['address_components', 'geometry', 'icon', 'name']);

    var marker = new google.maps.Marker({
        map: map,
        anchorPoint: new google.maps.Point(0, -29)
    });

    autocomplete.addListener('place_changed', function () {
        marker.setVisible(false);
        var place = autocomplete.getPlace();
        if (!place.geometry) {
            window.alert("No details available for input: '" + place.name + "'");
            return;
        }
        // If the place has a geometry, then present it on a map.
        if (place.geometry.viewport) {
            map.fitBounds(place.geometry.viewport);
        } else {
            map.setCenter(place.geometry.location);
            map.setZoom(17);  // Why 17? Because it looks good.
        }
        marker.setPosition(place.geometry.location);
        marker.setVisible(true);
    });

    map.addListener('rightclick', function (e) {
        var lat = e.latLng.lat();
        var lon = e.latLng.lng();

        var contentString = '<div id="content">' +
            '<p>Title</p>' +
            '<input type="text" />' +
            '<p>Description</p>' +
            '<textarea cols="50"></textarea>' +
            '<br />' +
            '<select>' +
            '    <option>Trip</option>' +
            '    <option>Lived</option>' +
            '    <option>Want to go</option>' +
            '</select>' +
            '<button type="button">' +
            '    <img src="https://image.flaticon.com/icons/svg/53/53407.svg" height="20px" width="20px" />' +
            '</button>' +
            '<button type="button">' +
            '    <img src="https://cdn3.iconfinder.com/data/icons/faticons/32/picture-01-512.png" height="20px" width="20px" />' +
            '</button>' +
            '</div>';

        var marker200 = new google.maps.Marker({
            position: { lat: lat, lng: lon },
            map: map,
            icon: {
                url: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
            }
        });
        marker200.addListener('click', function () {
            infowindow.open(map, marker200);
        });

        var infowindow = new google.maps.InfoWindow({
            content: contentString
        });
    });

    //Test Markers (no marker will be hardcoded when working properly)
    var marker5 = new google.maps.Marker({
        position: { lat: 42.216601, lng: -121.752205 },
        map: map,
        icon: {
            url: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        },
        title: 'Klamath Falls apartment'
    });

    var marker2 = new google.maps.Marker({
        position: { lat: 45.533467, lng: -122.650095 },
        map: map,
        icon: {
            url: "http://maps.google.com/mapfiles/ms/icons/red-dot.png"
        },
        title: 'Portland apartment'
    });
}

/**********************************************************************
 * Purpose: This function changes the map theme to a dark blue theme.
 **********************************************************************/
function MidNightTheme() {

    map.setOptions({
        styles:
            [
                {
                    "featureType": "all",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "all",
                    "elementType": "labels.text.stroke",
                    "stylers": [
                        {
                            "color": "#000000"
                        },
                        {
                            "lightness": 13
                        }
                    ]
                },
                {
                    "featureType": "administrative",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#000000"
                        },
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "administrative",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#144b53"
                        },
                        {
                            "lightness": 14
                        },
                        {
                            "weight": 1.4
                        }
                    ]
                },
                {
                    "featureType": "landscape",
                    "elementType": "all",
                    "stylers": [
                        {
                            "color": "#08304b"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#0c4152"
                        },
                        {
                            "lightness": 5
                        },
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "poi.attraction",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "poi.attraction",
                    "elementType": "labels",
                    "stylers": [
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "poi.business",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "simplified"
                        }
                    ]
                },
                {
                    "featureType": "poi.business",
                    "elementType": "labels.text",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "poi.government",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "poi.place_of_worship",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "poi.school",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#000000"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#0b434f"
                        },
                        {
                            "lightness": 25
                        }
                    ]
                },
                {
                    "featureType": "road.highway.controlled_access",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#000000"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#0b3d51"
                        },
                        {
                            "lightness": 16
                        }
                    ]
                },
                {
                    "featureType": "road.local",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "road.local",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#000000"
                        }
                    ]
                },
                {
                    "featureType": "road.local",
                    "elementType": "labels.text",
                    "stylers": [
                        {
                            "weight": "1.19"
                        },
                        {
                            "visibility": "simplified"
                        }
                    ]
                },
                {
                    "featureType": "transit",
                    "elementType": "all",
                    "stylers": [
                        {
                            "color": "#146474"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "all",
                    "stylers": [
                        {
                            "color": "#021019"
                        }
                    ]
                }
            ]
    });
}

/**********************************************************************
 * Purpose: This function changes the map theme to the default theme
 **********************************************************************/
function DefaultTheme() {
    map.setOptions({
        styles:
            [
                {
                    "featureType": "administrative.country",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "saturation": "-35"
                        }
                    ]
                }
            ]
    });
}

/**********************************************************************
 * Purpose: This function changes the map theme to a dark theme
 **********************************************************************/
function DarkTheme() {
    map.setOptions({
        styles:
            [
                {
                    "stylers": [
                        {
                            "hue": "#ff1a00"
                        },
                        {
                            "invert_lightness": true
                        },
                        {
                            "saturation": -100
                        },
                        {
                            "lightness": 33
                        },
                        {
                            "gamma": 0.5
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#2D333C"
                        }
                    ]
                }
            ]
    });
}

/**********************************************************************
 * Purpose: This function changes the map theme to a light theme
 **********************************************************************/
function LightTheme() {
    map.setOptions({
        styles:
            [
                {
                    "featureType": "all",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "weight": "2.00"
                        }
                    ]
                },
                {
                    "featureType": "all",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#9c9c9c"
                        }
                    ]
                },
                {
                    "featureType": "all",
                    "elementType": "labels.text",
                    "stylers": [
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "landscape",
                    "elementType": "all",
                    "stylers": [
                        {
                            "color": "#f2f2f2"
                        }
                    ]
                },
                {
                    "featureType": "landscape",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "landscape.man_made",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "all",
                    "stylers": [
                        {
                            "saturation": -100
                        },
                        {
                            "lightness": 45
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#eeeeee"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#7b7b7b"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "labels.text.stroke",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "simplified"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "labels.icon",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "transit",
                    "elementType": "all",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "all",
                    "stylers": [
                        {
                            "color": "#46bcec"
                        },
                        {
                            "visibility": "on"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#c8d7d4"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#070707"
                        }
                    ]
                },
                {
                    "featureType": "water",
                    "elementType": "labels.text.stroke",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                }
            ]
    });
}

/**********************************************************************
 * Purpose: This function handles the click on the hamburger button lines
 *          and calls ToggleMenu() to toggle visibilty of the menu
 **********************************************************************/
function HamburgerSpanClick() {
    var checked = document.getElementById("HamburgerButtonInput").checked;
    if (!checked) {
        document.getElementById("HamburgerButtonInput").checked = true;
    }
    else {
        document.getElementById("HamburgerButtonInput").checked = false;
    }
    ToggleMenu();
}

/**********************************************************************
 * Purpose: This function toggles the visibility of the expandable 
 *          hamburger button menu.
 **********************************************************************/
function ToggleMenu() {
    var checked = document.getElementById("HamburgerButtonInput").checked;
    if (checked) {
        document.getElementById("menu").style.zIndex = 1;
        document.getElementById("menu").style.opacity = 1;
    }
    else {
        document.getElementById("menu").style.zIndex = 0;
        document.getElementById("menu").style.opacity = 0;
    }
}

