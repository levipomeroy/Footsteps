var SelectedListID = null;

function AddList() {
    //Get new list name
    var Name = prompt("Enter the list name", "i.e. Bucket List");
    //Store new list name in DB via service call
    if (Name !== null) {
        $.ajax({
            //url: '@Url.Action("AddList", "UserList")',
            url: '/UserList/AddList',
            type: 'POST',
            data: { Name: Name },
            success: function (data) {
                document.getElementById("ListOfLists").innerHTML += "<div><a onclick='ListClicked(" + data + ")'  href='#'>" + Name + "</a></div>"

            }
        });
        //update list of lists with new list name 
       // document.getElementById("ListOfLists").innerHTML += "<div><a href='#'>" + Name + "</a></div>"
    }
}

function ListClicked(ID) {
    if (ID !== null) {
        SelectedListID = ID;
        //send list id to server and get back list of items in that list
        $.ajax({
            //url: '@Url.Action("GetListItemsForList", "UserList")',
            url: '/UserList/GetListItemsForList',
            type: 'POST',
            data: { ID: ID },
            success: function (data) {
                var objList = JSON.parse(JSON.stringify(data)); //parse result into object
                //update html to contain the list items
                document.getElementById("ItemBody").innerHTML = '';
                for (var i = 0; i < objList.length; i++) {
                    document.getElementById("ItemBody").innerHTML += "<div>" + objList[i].item + "</div>";
                }
            }
        });
    }
}

function AddListItem() {
    var Item = prompt("Enter a new item", "i.e. Visit...");
    if (Item !== null && SelectedListID !== null) {
        $.ajax({
            //url: '@Url.Action("AddListItem", "UserList")',
            url: '/UserList/AddListItem',
            type: 'POST',
            data: { ID: SelectedListID, Item: Item }
        });

        document.getElementById("ItemBody").innerHTML += "<div>" + Item + "</div>";
    }
}