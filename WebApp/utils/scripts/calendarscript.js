var currentUpdateEvent;
var addStartDate;
var addEndDate;
var globalAllDay;

function updateEvent(event, element) {
    //alert(event.description);

    if ($(this).data("qtip")) $(this).qtip("destroy");

    currentUpdateEvent = event;

    $('#updatedialog').dialog('open');

    $("#eventName").val(event.title);
    $("#eventDesc").val(event.description);
    $("#eventId").val(event.id);
    $("#DropDownList2").val(event.sede);   //seleccionar al elegir nuevo evento
    $("#eventStart").text("" + event.start.format("HH:mm:ss tt"));

    if (event.end === null) {
        $("#eventEnd").text("");
    }
    else {
        //$("#eventEnd").text("" + event.end.toLocaleString());
        $("#eventEnd").text("" + event.end.format("HH:mm:ss tt"));
    }
}

function updateSuccess(updateResult) {
    //alert(updateResult);
}

function deleteSuccess(deleteResult) {
    //alert(deleteResult);
}

function addSuccess(addResult) {
    // if addresult is -1, means event was not added
    //    alert("added key: " + addResult);

    if (addResult != -1) {
        $('#calendar').fullCalendar('renderEvent',
						{
						    title: $("#addEventName").val(),
						    //start: "2015-11-13 16:00:00",// aqui verificar
						    //end: "2015-11-13 18:00:00",
						    start: addStartDate,// aqui verificar
						    end: addEndDate,
						    id: addResult,
						    description: $("#addEventDesc").val(),
						    sede: $("#DropDownList1").val(),
						    //sede: $("#DropDownList1 :selected").text(),
						    allDay: globalAllDay
						},
						true // make the event "stick"
					);


        $('#calendar').fullCalendar('unselect');
    }

}

function UpdateTimeSuccess(updateResult) {
    //alert(updateResult);
}


function selectDate(start, end, allDay) {

    $('#addDialog').dialog('open');   

    if (start.format("hh:mm:ss") == "12:00:00") {
        $("#addEventStartDate").text("16:00:00 PM");
        $("#addEventEndDate").text("18:00:00 PM");
        var objSelect = document.getElementById("DropDownList4");
        var objSelect1 = document.getElementById("DropDownList5");
        var objSelect2 = document.getElementById("DropDownList6");
        var objSelect3 = document.getElementById("DropDownList7");
        var startc1 = start.format("HH");
        var startc2 = end.format("HH");
        setSelectedValue(objSelect, "16");
        setSelectedValue(objSelect1, "00");
        setSelectedValue(objSelect2, "18");
        setSelectedValue(objSelect3, "00");
        function setSelectedValue(selectObj, valueToSet) {
            for (var i = 0; i < selectObj.options.length; i++) {
                if (selectObj.options[i].text == valueToSet) {
                    selectObj.options[i].selected = true;
                    return;
                }
            }
        }
        function setSelectedValue1(selectObj, valueToSet) {
            for (var i = 0; i < selectObj1.options.length; i++) {
                if (selectObj1.options[i].text == valueToSet) {
                    selectObj1.options[i].selected = true;
                    return;
                }
            }
        }
        function setSelectedValue2(selectObj, valueToSet) {
            for (var i = 0; i < selectObj2.options.length; i++) {
                if (selectObj2.options[i].text == valueToSet) {
                    selectObj2.options[i].selected = true;
                    return;
                }
            }
        }
        function setSelectedValue3(selectObj, valueToSet) {
            for (var i = 0; i < selectObj3.options.length; i++) {
                if (selectObj3.options[i].text == valueToSet) {
                    selectObj3.options[i].selected = true;
                    return;
                }
            }
        }
    } else {
        $("#addEventStartDate").text("" + start.format("HH:mm:ss tt"));
        $("#addEventEndDate").text("" + end.format("HH:mm:ss tt"));

        var objSelect = document.getElementById("DropDownList4");
        var objSelect1 = document.getElementById("DropDownList5");
        var objSelect2 = document.getElementById("DropDownList6");
        var objSelect3 = document.getElementById("DropDownList7");
        var startc1 = start.format("HH");
        var startc2 = end.format("HH");
        var startc3 = start.format("mm");
        var startc4 = end.format("mm");
        setSelectedValue(objSelect, startc1);
        setSelectedValue(objSelect1, startc3);
        setSelectedValue(objSelect2, startc2);
        setSelectedValue(objSelect3, startc4);
        function setSelectedValue(selectObj, valueToSet) {
            for (var i = 0; i < selectObj.options.length; i++) {
                if (selectObj.options[i].text == valueToSet) {
                    selectObj.options[i].selected = true;
                    return;
                }
            }
        }
        function setSelectedValue1(selectObj, valueToSet) {
            for (var i = 0; i < selectObj1.options.length; i++) {
                if (selectObj1.options[i].text == valueToSet) {
                    selectObj1.options[i].selected = true;
                    return;
                }
            }
        }
        function setSelectedValue2(selectObj, valueToSet) {
            for (var i = 0; i < selectObj2.options.length; i++) {
                if (selectObj2.options[i].text == valueToSet) {
                    selectObj2.options[i].selected = true;
                    return;
                }
            }
        }
        function setSelectedValue3(selectObj, valueToSet) {
            for (var i = 0; i < selectObj3.options.length; i++) {
                if (selectObj3.options[i].text == valueToSet) {
                    selectObj3.options[i].selected = true;
                    return;
                }
            }
        }
    }

    if (start.format("hh:mm:ss") == "12:00:00") {
        start = start.format("MMM dd yyyy");

        var e1 = document.getElementById("DropDownList4");
        var info1 = e1.options[e1.selectedIndex].value;
        var e11 = document.getElementById("DropDownList5");
        var info11 = e11.options[e11.selectedIndex].value;
        var e2 = document.getElementById("DropDownList6");
        var info2 = e2.options[e2.selectedIndex].value;
        var e22 = document.getElementById("DropDownList7");
        var info22 = e22.options[e22.selectedIndex].value;
        //alert(info1 + " - " + info11 + " - " + info2 + " - " + info22);

        addStartDate = new Date(start + " " + info1 + ":" + info11 + ":00 GMT -0500 (Hora est. Pacífico,Sudamérica)");
        addEndDate = new Date(start + " " + info2 + ":" + info22 + ":00 GMT -0500 (Hora est. Pacífico,Sudamérica)");

        globalAllDay = false;
    }
    else {
        addStartDate = start;
        addEndDate = end;
        globalAllDay = allDay;
    }
}

function updateEventOnDropResize(event, allDay) {

    var eventToUpdate = {
        id: event.id,
        start: event.start

    };

    var dia = new Date();
    var hoy = dia.getDate() + "-" + (dia.getMonth() + 1) + "-" + dia.getFullYear();
    if (event.start.format("dd-MM-yyyy") >= hoy) {
        if (allDay) {
            eventToUpdate.start.setHours(0, 0, 0);
            eventToUpdate.end.setHours(0, 0, 0);

        }

        if (event.end === null) {
            eventToUpdate.end = eventToUpdate.start;

        }
        else {
            eventToUpdate.end = event.end;
            if (allDay) {
                eventToUpdate.end.setHours(0, 0, 0);
            }
        }

        eventToUpdate.start = eventToUpdate.start.format("dd-MM-yyyy hh:mm:ss tt");
        eventToUpdate.end = eventToUpdate.end.format("dd-MM-yyyy hh:mm:ss tt");

        PageMethods.UpdateEventTime(eventToUpdate, UpdateTimeSuccess);
    } else {
        alert("No esta Permitido grabar en esta Fecha Seleccionada");
        $(this).dialog("close");
        location.reload(true);
        //$('#calendar').fullCalendar('ddasdasd');

    }
}

function eventDropped(event, dayDelta, minuteDelta, allDay, revertFunc) {

    if ($(this).data("qtip")) $(this).qtip("destroy");

    updateEventOnDropResize(event, allDay);

}

function eventResized(event, dayDelta, minuteDelta, revertFunc) {

    if ($(this).data("qtip")) $(this).qtip("destroy");

    //alert(event.start);
    //alert(event.end);
    //alert(event.end.format("mm") - event.start.format("mm"));
    if (event.end.format("mm") - event.start.format("mm") == 0) {
        if (event.end.format("HH") - event.start.format("HH") == 2) {
            updateEventOnDropResize(event);
        } else {
            alert("Los Horarios de Entrenamiento deben de cumplir las 2 Horas");
            $(this).dialog("close");
            location.reload(true);// aqui para poner exception de 2 horas en actualizar
        }
    } else {
        alert("Los Horarios de Entrenamiento deben de cumplir las 2 Horas");
        $(this).dialog("close");
        location.reload(true);// aqui para poner exception de 2 horas en actualizar
    }

}

function checkForSpecialChars(stringToCheck) {
    var pattern = /[^A-Za-z0-9 ]/;
    return pattern.test(stringToCheck);
}

$(document).ready(function () {

    $('#updatedialog').dialog({
        autoOpen: false,
        width: 470,
        buttons: {
            "Actualizar": function () {

                var eventToUpdate = {
                    id: currentUpdateEvent.id,
                    title: $("#eventName").val(),
                    description: $("#eventDesc").val(),
                    sede: $("#DropDownList2").val(),
                    //sede: $("#DropDownList1 :selected").text()
                };
                if (eventToUpdate.sede == "-- Seleccionar --") {
                    alert("Debe Seleccionar una Sede");
                } else if (eventToUpdate.title == "") {
                    alert("Ingrese Titulo de Entrenamiento");
                } else if (eventToUpdate.description == "") {
                    alert("Ingrese Descripcion");
                } else {
                    if (checkForSpecialChars(eventToUpdate.title) || checkForSpecialChars(eventToUpdate.description)) {
                        alert("Por favor Caracteres: A - Z, a - z, 0 - 9, espacios");
                    }
                    else {
                        PageMethods.UpdateEvent(eventToUpdate, updateSuccess);
                        $(this).dialog("close");

                        currentUpdateEvent.title = $("#eventName").val();
                        currentUpdateEvent.description = $("#eventDesc").val();
                        currentUpdateEvent.sede = $("#DropDownList2").val(),

                        $('#calendar').fullCalendar('updateEvent', currentUpdateEvent);
                    }
                }

            },
            "Eliminar": function () {

                if (confirm("¿Desea Eliminar este Horario?")) {

                    PageMethods.deleteEvent($("#eventId").val(), deleteSuccess);
                    $(this).dialog("close");
                    $('#calendar').fullCalendar('removeEvents', $("#eventId").val());
                }

            }

        }
    });

    //add dialog
    $('#addDialog').dialog({
        autoOpen: false,
        width: 470,

        buttons: {
            "Agregar": function () {
                start1 = addStartDate.format("MMMM dd yyyy");
                var e1 = document.getElementById("DropDownList4");
                var info1 = e1.options[e1.selectedIndex].value;
                var e11 = document.getElementById("DropDownList5");
                var info11 = e11.options[e11.selectedIndex].value;
                var e2 = document.getElementById("DropDownList6");
                var info2 = e2.options[e2.selectedIndex].value;
                var e22 = document.getElementById("DropDownList7");
                var info22 = e22.options[e22.selectedIndex].value;

                addStartDate = new Date(start1 + " " + info1 + ":" + info11 + ":00 GMT -0500 (Hora est. Pacífico,Sudamérica)");
                addEndDate = new Date(start1 + " " + info2 + ":" + info22 + ":00 GMT -0500 (Hora est. Pacífico,Sudamérica)");
                var eventToAdd = {
                    title: $("#addEventName").val(),
                    description: $("#addEventDesc").val(),
                    //start: "14-11-2015 04:00:00 PM",
                    //end: "14-11-2015 06:00:00 PM",
                    start: addStartDate.format("dd-MM-yyyy hh:mm:ss tt"),
                    end: addEndDate.format("dd-MM-yyyy hh:mm:ss tt"),
                    sede: $("#DropDownList1").val()

                };
                var dia = new Date();
                var hoy = dia.getDate() + "-" + (dia.getMonth() + 1) + "-" + dia.getFullYear();
                if (parseInt(info22 + "", 10) - parseInt(info11 + "", 10) == 0) {
                    if (parseInt(info2 + "", 10) - parseInt(info1 + "", 10) == 2) {
                        if (addStartDate.format("dd-MM-yyyy") >= hoy) {
                            //alert(eventToAdd.start + " -m " + eventToAdd.end);                                
                            if (eventToAdd.sede == "-- Seleccionar --") {
                                alert("Debe Seleccionar una Sede");
                            } else if (eventToAdd.title == "") {
                                alert("Ingrese Titulo de Entrenamiento");
                            } else if (eventToAdd.description == "") {
                                alert("Ingrese Descripcion");
                            } else {
                                if (checkForSpecialChars(eventToAdd.title) || checkForSpecialChars(eventToAdd.description)) {
                                    alert("Por favor Caracteres: A - Z, a - z, 0 - 9, espacios");
                                }
                                else {
                                    PageMethods.addEvent(eventToAdd, addSuccess);
                                    $(this).dialog("close");


                                }
                            }
                        } else {
                            alert("No esta Permitido grabar en esta Fecha Seleccionada");
                            $(this).dialog("close");
                        }
                    } else {
                        alert("Los Horarios de Entrenamiento deben de cumplir las 2 Horas");
                        $(this).dialog("close");
                    }
                } else {
                    alert("Los Horarios de Entrenamiento deben de cumplir las 2 Horas");
                    $(this).dialog("close");
                }
            }
        }
        //}
    });

    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getFullYear();

    var calendar = $('#calendar').fullCalendar({
        theme: true,
        header: {
            left: 'prev,next,today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        eventClick: updateEvent,
        selectable: true,
        selectHelper: true,
        select: selectDate,
        editable: true,
        events: "JsonResponse.ashx",
        eventDrop: eventDropped,
        eventResize: eventResized,
        eventRender: function (event, element) {
            //alert(event.title);
            element.qtip({
                content: event.description,
                position: { corner: { tooltip: 'bottomLeft', target: 'topRight' } },
                style: {
                    border: {
                        width: 1,
                        radius: 3,
                        color: '#2779AA'
                    },
                    padding: 10,
                    textAlign: 'center',
                    tip: true, // Give it a speech bubble tip with automatic corner detection
                    name: 'cream' // Style it according to the preset 'cream' style
                }
            });
        }
    });
});
