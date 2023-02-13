window.__lc = window.__lc || {};
window.__lc.license = my_global_livechat_id;
window.__lc.chat_between_groups = false;
window.__lc.ga_version = "gaq";
window.__lc.group = my_global_livechat_group;


(function () {
    var cookie_version = 3.1;
    var lead_obtainned_cookie_name = my_global_center_acronym + "_lead_obtained(phone_or_email)_" + cookie_version;
    var lead_obtainned_Label = "Lead Obtained(Phone or Email)";
    var visitor_sent_first_message_cookie_name = my_global_center_acronym + "_write_first_message_" + cookie_version;
    var last_chat_id_cookie_name = my_global_center_acronym + "_last_chat_id_" + cookie_version;
    var visitor_sent_first_message_label = "Visitor Sent First Message";
    var phone_obtained_cookie_name = my_global_center_acronym + "_phone_obtained_" + cookie_version;
    var phone_obtainned_label = "Phone Obtainned";
    var email_obtained_cookie_name = my_global_center_acronym + "_email_obtained_" + cookie_version;
    var email_obtained_label = "Email Obtainned";


    $(window).on('load', function () {
        setTimeout(function () {
            var lc = document.createElement('script'); lc.type = 'text/javascript'; lc.async = true; lc.id = 'livechat';
            lc.src = ('https:' === document.location.protocol ? 'https://' : 'http://') + 'cdn.livechatinc.com/tracking.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(lc, s);
            console.log('started livechat');

            var visit_id_setted;

            document.getElementById('livechat').addEventListener('load', function () {
                if (typeof LC_API !== 'undefined') {

                    /*insert a new visit_ticket on ticket created*/
                    LC_API.on_ticket_created = function (data) {
                        insertVisitTicket(data.ticket_id, my_global_last_visit_id);
                    };

                    /*send events to google analitics based on the on_message call back function*/
                    LC_API.on_message = function (data) {

                        /*set visit_id to the chat*/
                        /*if (!visit_id_setted) {
                            var custom_variables = [{ name: "visit_id", value: my_global_last_visit_id },];
                            LC_API.set_custom_variables(custom_variables);
                            visit_id_setted = true;
                        }* /

                        /*send an event when visitor send the first message to the agent*/
                        if (data.user_type === "visitor" && !getCookie(visitor_sent_first_message_cookie_name)) {
                            gtag_report_event_action(visitor_sent_first_message_label);
                            console.log(visitor_sent_first_message_label);
                        }

                        /*insert a visit_Chat when visitor send the first message to the agent*/
                        if (data.user_type === "visitor") {
                            var chatId = LC_API.get_chat_id();
                            if (chatId == null) {
                                console.log('chat_id_not_ready')
                            }
                            else {
                                /*setting the chatId to the custom variables*/
                                var custom_variables = [{name: "chat_id", value: chatId }];
                                LC_API.set_custom_variables(custom_variables);
                                /*inserting the visit*/
                                if (getCookie(last_chat_id_cookie_name) != chatId) {                                    
                                    insertVisitChat(chatId, my_global_last_visit_id);
                                    setCookie(last_chat_id_cookie_name, chatId, 1);
                                }
                                else {
                                    console.log('chat_id already saved')
                                }
                            }
                        }


                        /*send an event when visitor send his phone*/
                        if (data.user_type === "visitor" && TextContainATenDigitsPhone(data.text) && !getCookie(phone_obtained_cookie_name)) {
                            gtag_report_event_action(phone_obtainned_label);
                            console.log(phone_obtainned_label);
                            setCookie(phone_obtained_cookie_name, true, 7);
                            submitChatLead(data);
                        }

                        /*send an event when visitor send his email*/
                        if (data.user_type === "visitor" && TextContainAnEmail(data.text) && !getCookie(email_obtained_cookie_name)) {
                            gtag_report_event_action(email_obtained_label);
                            console.log(email_obtained_label);
                            setCookie(email_obtained_cookie_name, true, 7);
                            submitChatLead(data);
                        }

                        /*send an event when visitor send his phone or his email*/
                        if (data.user_type === "visitor" && TextContainAnEmailOrTenDigitsPhone(data.text)
                            && !getCookie(lead_obtainned_cookie_name)) {
                            gtag_report_event_action(lead_obtainned_Label);
                            gtag_report_conversion(my_global_chat_conversion_id);
                            console.log(lead_obtainned_Label);
                            setCookie(lead_obtainned_cookie_name, true, 7);
                        }
                    };
                }
            });
        }, 10000);
    });
})();

function submitChatLead(data) {
    var _chatId = LC_API.get_chat_id();
    var _clientEmail = GetEmailFromMessage(data.text);
    var _clientPhone = GetPhoneFromMessage(data.text);
    var _firstVisitId = my_global_first_visit_id;
    var _lastVisitId = my_global_last_visit_id;
    var _referrer = my_global_visit_source;
    var _visitorId = LC_API.get_visitor_id();
    var _centerId = my_global_center_id;
    var _url = window.location.pathname;
    var _ipAddress = data.IpAddress;
    var _userAgent = data.UserAgent;

    $.ajax({
        url: "/contactform/leadfromchatsubmit",
        type: "POST",
        data: {
            chatId: _chatId,
            clientEmail: _clientEmail,
            clientPhone: _clientPhone,
            firstVisitId: _firstVisitId,
            lastVisitId: _lastVisitId,
            referrer: _referrer,
            visitorId: _visitorId,
            centerId: _centerId,
            url: _url,
            ipAddress: _ipAddress,
            userAgent: _userAgent
        },
        cache: false,
        success: function () {
            console.log("Chat Lead Succefully Submitted");
        },
        error: function (e) {
            console.log("Chat Lead Failed To Submit");
        }
    });

    return false;
}


function insertVisitChat(id, visitId) {
    let result;
    try {
        result = $.ajax({
            url: '/contactform/insertvisitchat',
            type: "POST",
            data: {
                "id": id,
                "visitId": visitId
            },
            cache: false,
            success: function (response) {
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

function insertVisitTicket(id, visitId) {
    let result;
    try {
        result = $.ajax({
            url: '/contactform/insertvisitticket',
            type: "POST",
            data: {
                "ticketId": id,
                "visitId": visitId
            },
            cache: false,
            success: function (response) {
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