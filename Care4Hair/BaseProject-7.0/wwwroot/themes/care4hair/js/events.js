$(document).ready(function () {
    var TelephoneLinks = $('a[href*="tel:"]');
    for (var i = 0; i < TelephoneLinks.length; i++) {
        TelephoneLinks[i].addEventListener('click', function () { gtag_report_conversion(my_global_call_conversion_id) }, false);
    }
});

function gtag_report_conversion(conversionId) {
    var callback = function () {
    };
    gtag('event', 'conversion', {
        'send_to': conversionId,
        'event_callback': callback
    });
    return false;
}

function gtag_report_event_action(action) {
    gtag('event', action, {
        'event_category': 'Chat' + my_global_traffick_type_label,
        'event_label': my_global_event_label,
        'value': 1
    });
}