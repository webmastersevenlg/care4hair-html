(function () {
    var last_visit_cookie_cookie_version = 2;
    var first_visit_cookie_cookie_version = 2;

    var visitsCookieNames = {
        last_visit_cookie_name: my_global_center_acronym + "_last_visit_" + last_visit_cookie_cookie_version,
        first_visit_cookie_name: my_global_center_acronym + "_first_visit_" + first_visit_cookie_cookie_version
    };

    var date = new Date();
    var dateFormated = date.toISOString();
    var href = window.location.href

    try {
        var _urlData = JSON.parse('{"' + decodeURI(window.location.search.substring(1)).replace(/"/g, '\\"').replace(/&/g, '","').replace(/=/g, '":"') + '"}');
    }
    catch (e) {
        _urlData = "";
    }



    var visitData = {
        url: href,
        referrer: my_global_visit_source,
        fullReferrer: my_global_referrer_url,
        userHostAddress: my_global_user_host_address,
        urlData: _urlData
    }

    var first_visit_cookie_value = getCookie(visitsCookieNames.first_visit_cookie_name);
    if (first_visit_cookie_value === null) {
        insertVisit(visitData, setFirstAndLastVisitCookie, visitsCookieNames);
    } else {
        my_global_first_visit_id = first_visit_cookie_value;
        my_global_first_visit_label = '"first_visit":' + first_visit_cookie_value;


        var last_visit_cookie_value = getCookie(visitsCookieNames.last_visit_cookie_name);
        if (last_visit_cookie_value === null) {
            insertVisit(visitData, setLastVisitCookie, visitsCookieNames);
        } else {
            my_global_last_visit_id = last_visit_cookie_value;
            my_global_last_visit_label = ', "last_visit":' + last_visit_cookie_value;
        }
    }
})();

function setCookie(name, value, days) {
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + days * 24 * 60 * 60 * 1000);
        expires = "; expires=" + date.toUTCString();
    }
    document.cookie = name + "=" + (value || "") + expires + "; path=/";
}

function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}


function insertVisit(visitData, setVisitCookieFunction, visitsCookieNames,) {
    let result;
    try {
        result = $.ajax({
            url: '/contactform/insertvisit',
            type: "POST",
            data: visitData,
            cache: false,
            success: function (response) {
                setVisitCookieFunction(response.visitId, visitsCookieNames);
            },
            error: function (e) {
                console.error(e);
            },
        });
    }
    catch (e) {
        console.log(e);
    }
    return result;
}


function setFirstAndLastVisitCookie(visitId, visitsCookieNames) {
    var first_visit_cookie_duration_days = 360;
    var last_visit_cookie_duration_days = 15;
    if (visitId !== null) {
        var first_visit_cookie_value = visitId;
        setCookie(visitsCookieNames.first_visit_cookie_name, first_visit_cookie_value, first_visit_cookie_duration_days);
        my_global_first_visit_id = first_visit_cookie_value;
        my_global_first_visit_label = '"first_visit":' + first_visit_cookie_value;

        var last_visit_cookie_value = visitId;
        setCookie(visitsCookieNames.last_visit_cookie_name, last_visit_cookie_value, last_visit_cookie_duration_days);
        my_global_last_visit_id = last_visit_cookie_value;
        my_global_last_visit_label = ', "last_visit":' + last_visit_cookie_value;
    }
}


function setLastVisitCookie(visitId, visitsCookieNames) {
    var last_visit_cookie_duration_days = 3;
    if (visitId != null) {
        var last_visit_cookie_value = visitId;
        setCookie(visitsCookieNames.last_visit_cookie_name, last_visit_cookie_value, last_visit_cookie_duration_days);
        my_global_last_visit_id = last_visit_cookie_value;
        my_global_last_visit_label = ', "last_visit":' + last_visit_cookie_value;
    }
}

