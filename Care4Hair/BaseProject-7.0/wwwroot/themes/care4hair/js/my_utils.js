
function GetEmailFromMessage(text) {
    if (checkIfEmailInString(text))
        return getEmailInString(text);
    return null;
}

function GetPhoneFromMessage(text) {
    if (checkIfTenDigitsPhoneInString(text))
        return getTenDigitsPhoneInString(text);
    return null;
}

function TextContainAnEmailOrTenDigitsPhone(text) {
    if (checkIfEmailInString(text))
        return true;
    if (checkIfTenDigitsPhoneInString(text))
        return true;
    return false;
}

function TextContainAnEmail(text) {
    if (checkIfEmailInString(text))
        return true;
    return false;
}


function TextContainATenDigitsPhone(text) {
    if (checkIfTenDigitsPhoneInString(text))
        return true;
    return false;
}

function checkIfEmailInString(text) {
    var re = /(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))/;
    return re.test(text);
}

function getEmailInString(text) {
    var re = /(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))/g;
    return text.match(re);
}

function checkIfTenDigitsPhoneInString(text) {
    var re = /(\d{3}[-\.\s]??\d{3}[-\.\s]??\d{4}|\(\d{3}\)\s*\d{3}[-\.\s]??\d{4})/;
    return re.test(text);
}

function getTenDigitsPhoneInString(text) {
    var re = /(\d{3}[-\.\s]??\d{3}[-\.\s]??\d{4}|\(\d{3}\)\s*\d{3}[-\.\s]??\d{4})/g;
    return text.match(re);
}


function IsJsonString(str) {
    try {
        JSON.parse(str);
    } catch (e) {
        return false;
    }
    return true;
}