var CaptchaCallback = function () {


    if ($("#pageContactFormRecaptcha").length) {
        pageRecaptchaWasLoaded = true;
        grecaptcha.render('pageContactFormRecaptcha', {
            'sitekey': my_global_recaptcha_site_key,
            'callback': enablePageContactForm,
            'expired-callback': disablePageContactForm,
        });
    }


    if ($("#sliderContactFormRecaptcha").length) {
        sliderRecaptchaWasLoaded = true;
        grecaptcha.render('sliderContactFormRecaptcha', {
            'sitekey': my_global_recaptcha_site_key,
            'callback': enableSliderContactForm,
            'expired-callback': disableSliderContactForm,
            'theme': 'dark'
        });
    }
}

$(document).ready(function () {
    $('<script/>', { type: 'text/javascript', src: 'https://www.google.com/recaptcha/api.js?onload=CaptchaCallback&render=explicit' }).appendTo('head');
});

function enablePageContactForm() {
    if (grecaptcha.getResponse(0) != '') {
        pageContactFormReady = true;
        $('.pageContactForm .g-recaptcha').removeClass('error');
        $('.pageContactForm .recaptcha-error').text('');
    }
};


function enableSliderContactForm() {
    if (grecaptcha.getResponse(1) != '') {
        sliderContactFormReady = true;
        $('.sliderContactForm .g-recaptcha').removeClass('error');
        $('.sliderContactForm .recaptcha-error').text('');
    }
};

function disablePageContactForm() {
    pageContactFormReady = false;
};


function disableSliderContactForm() {
    sliderContactFormReady = false;
};
