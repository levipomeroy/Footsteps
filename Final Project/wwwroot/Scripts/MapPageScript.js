﻿src = "https://code.jquery.com/jquery-3.3.1.slim.min.js";

function InsertOrUpdateTheme(Theme) {
    $.ajax({
        url: '../Home/InsertOrUpdateTheme',
        type: 'POST',
        data: {
            Theme: Theme
        }
    });
}

//if (ThemeChoice === "Midnight") {
//    //MidNightTheme();
//    ChangeThemeToMidnight();    
//}
//else if (ThemeChoice === "Dark") {
//    //DarkTheme();
//    ChangeThemeToDark();
//}
//else if (ThemeChoice === "Light") {
//    //LightTheme();
//    ChangeThemeToLight();
//}
//else {
//    ChangeThemeToDefault();
//    //DefaultTheme();
//}

/**********************************************************************
 * Purpose: This function creates the initial map object and sets the
 *          properties.
 **********************************************************************/
var map;
var marker;
var centerOfTheWorld;
var infowindow = null;
var MarkerList = [];
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 32.854980, lng: 0 }, //centerish of the world
        zoom: 2,
        minZoom: 2,
        streetViewControl: false,   //removes streetview button
        mapTypeControl: false    //remove map/salelite toggle option buttons
    });
    centerOfTheWorld = map.getCenter();

    //Auto-complete search bar on map page stuff
    var input = document.getElementById('SearchBar');
    var autocomplete = new google.maps.places.Autocomplete(input);
    autocomplete.setFields(['address_components', 'geometry', 'icon', 'name']);

    AssignTheme();

    marker = new google.maps.Marker({
        map: map,
        icon: {
            url: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        },
        anchorPoint: new google.maps.Point(0, -29)
    });

    /***************************************************************
    * Purpose: Allows user to search for a location and has the option
    * to save the location the thier locations if desired.
    ***************************************************************/
    autocomplete.addListener('place_changed', function () {
        marker.setVisible(false);
        var place = autocomplete.getPlace();
        //Couldnt find location 
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

        var lat = place.geometry.location.lat();
        var lon = place.geometry.location.lng();
        //get country of location
        var filtered_array = place.address_components.filter(function (address_component) {
            return address_component.types.includes("country");
        });
        var country = filtered_array[0].long_name;
        //info window for searched place
        var SearchedLocationOptions = '<button type="button" onclick="AddMarkerFromLatLon(' + "'" + lat + "'" + "," + "'" + lon + "'" + "," + "'" + country + "'" + ')" class="btn btn-default">' + '<i class="fas fa-save"></i>' + '</button>';
        var infowindow = new google.maps.InfoWindow({
            content: SearchedLocationOptions
        });
        marker.addListener('click', function () {
            infowindow.open(map, marker);
        });
    });

    /***************************************************************
     * Purpose: Allows user to right click on map and add marker wherever
     * they clicked. This is usefult because it doenst have to be an address,
     * it can be in the middle of no where. 
     ***************************************************************/
    var geocoder = new google.maps.Geocoder();
    map.addListener('rightclick', function (e) {
        var lat = e.latLng.lat();
        var lon = e.latLng.lng();
        var filtered_array;
        var country = "something";

        geocoder.geocode({
            'latLng': e.latLng
        },
            function (results, status) { //Get country name
            if (status === google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    filtered_array = results[0].address_components.filter(function (address_component) {
                        return address_component.types.includes("country");
                    });
                    country = filtered_array[0].long_name;

                    //New content string 
                    var contentString = '<button type="button" onclick="AddMarkerFromLatLon(' + "'" + lat + "'" + "," + "'" + lon + "'" + "," + "'" + country + "'" + ')" id="AddRightClickMarkerButton" class="btn btn-default">' + '<i class="fas fa-save"></i>' + '</button>';

                    var marker200 = new google.maps.Marker({
                        position: { lat: lat, lng: lon },
                        map: map,
                        icon: {
                            url: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png" //maybe change to https
                        }
                    });
                    var NewLocationinfowindow = new google.maps.InfoWindow({
                        content: contentString
                    });
                    marker200.addListener('click', function () {
                        NewLocationinfowindow.open(map, marker200);
                    });
                }
            }
        });
    });

    //Add all locations from model to the map
    var i;
    for (i = 0; i < LocList.length; i++) {
        AddMarker(LocList[i].latitude, LocList[i].longitude, LocList[i].name, LocList[i].category, i);
    }

    function AddMarker(latitude, longitude, MarkerTitle, Category, index) {
        var InfoWindowContent = '<div id="InfoWindowDiv">' +
            '<div id="TitleLBL"> <strong>Title</strong> </div>' +
            '<div contentEditable="false" id="Title">...</div>' +
            '<div id="DescritptionLBL"> <strong>Descritption</strong> </div>' +
            '<div contentEditable="false" id="Description">...</div>' +
            '<div id="DateVisitedLBL"> <strong>Date</strong> </div>' +
            '<input contentEditable="false" type="date" id="DateVisited" readonly="true" style="border: none; outline: none"/>' +
            '<div id="CategoryLBL"> <strong>Category</strong> </div>' +
            '<select disabled="true" id="CategoryEditor">' +
            '<option value="Visited">Visited</option>' +
            '<option value="Want to go">Want to go</option>' +
            '<option value="Plan to go">Plan to go</option>' +
            '<option value="Lived">Lived</option>' +
            '</select>' +
            '</div>' +
            '<div id="ImageDiv"> </div>' +
            '<button style="background: none; outline: none; border: none" type="button" class="btn btn-default" id="EditBtn" onclick="EditMarkerClickHandle()"><i class="fas fa-edit"></i></button>' +
            '<button style="background: none" type="button" onclick="RemoveMarkerFromMap(' + "'" + index + "'" + ')" id="deleteButton" data-id="' + index + '" class="btn btn-default">' + '<i class="fas fa-trash-alt"></i>' + '</button>' +
            '<button style="background: none" type="button" onclick="OpenFileBrowser(' + "'" + index + "'" + ')" id="UploadImage" class="btn btn-default">' + '<i class="far fa-images"></i>' + '</button>' +
            '<button style="background: none; outline: none; border: none" type="button" class="btn btn-default" id="SaveUpdatesBtn" onclick="SaveUpdatesForMarker(' + "'" + index + "'" + ')"><i class="fas fa-save"></i></button>';
            
        var PinUrl;
        if (Category === "Visited") {
            PinUrl = "https://maps.google.com/mapfiles/ms/icons/red-dot.png";
        }
        else if (Category === "Want to go") {
            PinUrl = "https://maps.google.com/mapfiles/ms/icons/blue-dot.png";
        }
        else if (Category === "Plan to go") {
            PinUrl = "https://maps.google.com/mapfiles/ms/icons/yellow-dot.png";
        }
        else if (Category === "Lived") {
            PinUrl = "https://maps.google.com/mapfiles/ms/icons/green-dot.png";
        }
        else {
            PinUrl = "https://maps.google.com/mapfiles/ms/icons/purple-dot.png";
        }

        //create new marker
        var tempMarker = new google.maps.Marker({
            position: { lat: latitude, lng: longitude },
            map: map,
            icon: {
                url: PinUrl
            },
            title: MarkerTitle,
            id: index
        });

        google.maps.event.addListener(tempMarker, 'click', function () {
            //send lat and lon to get title and description
            GetTitleAndDescription(latitude, longitude);

            //Remove all other visible infowindows when this marker is clicked
            if (infowindow) {
                infowindow.close();
            }
            infowindow = new google.maps.InfoWindow({
                content: InfoWindowContent
            });
            //show infowindow
            infowindow.open(map, this);
        });

        MarkerList.push(tempMarker);
    }

}


function AssignTheme() {
    if (ThemeChoice === "Midnight") {
        MidNightTheme();
        //ChangeThemeToMidnight();    
    }
    else if (ThemeChoice === "Dark") {
        DarkTheme();
    }
    else if (ThemeChoice === "Light") {
        LightTheme();
    }
    else {
        DefaultTheme();
    }
}



//Makes fields in the infowindow editable
function EditMarkerClickHandle() {
    document.getElementById("Title").contentEditable = true;
    document.getElementById("Description").contentEditable = true;
    document.getElementById("DateVisited").readOnly = false;
    document.getElementById("CategoryEditor").disabled = false;
}

/**********************************************************************
 * Purpose: This function changes the map theme to a dark blue theme.
 **********************************************************************/
function MidNightTheme() {
    ChangeThemeToMidnight();
    InsertOrUpdateTheme("Midnight");
    if (map !== undefined) {
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
}

/**********************************************************************
 * Purpose: This function changes the map theme to the default theme
 **********************************************************************/
function DefaultTheme() {
    ChangeThemeToDefault();
    InsertOrUpdateTheme("Default");
    if (map !== undefined) {
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
}

/**********************************************************************
 * Purpose: This function changes the map theme to a dark theme
 **********************************************************************/
function DarkTheme() {
    ChangeThemeToDark();
    InsertOrUpdateTheme("Dark");
    if (map !== undefined) {
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
}

/**********************************************************************
 * Purpose: This function changes the map theme to a light theme
 **********************************************************************/
function LightTheme() {
    ChangeThemeToLight();
    InsertOrUpdateTheme("Light");
    if (map !== undefined) {
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
}

function ChangeThemeToMidnight() {
    ThemeOption = 1;
    document.getElementById("MapPageStyle").setAttribute("href", "../Styles/MidnightTheme.css");
}
function ChangeThemeToDark() {
    ThemeOption = 2;
    document.getElementById("MapPageStyle").setAttribute("href", "../Styles/DarkTheme.css");
}
function ChangeThemeToLight() {
    ThemeOption = 3;
    document.getElementById("MapPageStyle").setAttribute("href", "../Styles/LightTheme.css");
}
function ChangeThemeToDefault() {
    ThemeOption = 0;
    document.getElementById("MapPageStyle").setAttribute("href", "../Styles/MapPageStyle.css");
}


