$(function (element) {
    /*english*/
    $(".kuatroleap-contactForm").find("input,select,textarea").jqBootstrapValidation({
        preventSubmit: true,
        submitError: function ($form, event, errors) {
            /* additional error messages or events */
        },
        submitSuccess: function ($form, event) {
            event.preventDefault(); /* prevent default submit behaviour */
            /* get values from FORM */

            var isSliderContactForm = $form.hasClass('sliderContactForm');

            if (sliderRecaptchaWasLoaded && isSliderContactForm && (!sliderContactFormReady || grecaptcha.getResponse(1) == '')
                || pageRecaptchaWasLoaded && !isSliderContactForm && (!pageContactFormReady || grecaptcha.getResponse(0) == '')) {

                $form.find('.g-recaptcha').addClass('error');
                $form.find('.recaptcha-error').text('* Please check the captcha!');
            }
            else {
                var name = $form.find('input[name="name"]').val();
                var email = $form.find('input[name="email"]').val();
                var phone = $form.find('input[name="phone"]').val();
                var appointmentDate = $form.find("input[name='appointmentDate']").val();
                var subject = $form.find('input[name="subject"]').val() != null ? $form.find('input[name="subject"]').val() : $form.find($('select[name="subject"]')).val();
                var leadTypeId = $form.find('input[name="leadTypeId"]').val();
                var message = $form.find('textarea[name="message"]').val() != null ? $form.find('textarea[name="message"]').val() : $form.find('select[name="message"]').val();
                var acceptSms = $form.find('input[name="AcceptComunicationBySms"]').val();
                var acceptEmail = $form.find('input[name="AcceptComunicationByEmail"]').val();
                var token = $form.find('input[name="__RequestVerificationToken"]').val();
                var urlReferer = $form.find('input[name="urlReferer"]').val();
                var firstVisitId = my_global_first_visit_id;
                var lastVisitId = my_global_last_visit_id;
                var g_recaptcha_response = $form.find('textarea[name="g-recaptcha-response"]').val()


                /* if (firstName.indexOf(' ') >= 0) {
                    firstName = name.split(' ').slice(0, -1).join(' ');
                 }*/
                $form.hide();

                $form.parent().find('.success').html("");
                $form.parent().find('.loading').css("visibility", "visible");

                var actionUrl = "/contactform/leadsubmit";

                $.ajax({
                    url: actionUrl,
                    type: "POST",
                    data: {
                        name: name,
                        phone: phone,
                        email: email,
                        appointmentDate: appointmentDate,
                        subject: subject,
                        leadTypeId: leadTypeId,
                        message: message,
                        acceptComunicationByEmail: acceptEmail,
                        acceptComunicationBySms: acceptSms,
                        referrer: urlReferer,
                        __RequestVerificationToken: token,
                        firstVisitId: firstVisitId,
                        lastVisitId: lastVisitId,
                        'g-recaptcha-response': g_recaptcha_response
                    },
                    cache: false,
                    success: function () {
                        $form.parent().find(".loading").css("visibility", "hidden");
                        /* Success message */
                        if ($('#coupon').length > 0) {
                            $('#contact-form-h2').remove();
                            $form.parent().find('.success').html("<br><h2>Gracias!! Ahora imprime o toma una foto de este cupón y preséntalo el día de tu cita.</h2>");
                            $('#coupon').show();
                        }
                        else {
                            $form.parent().find('.success').html("<div id='contact-form-alert' class='fusion-alert alert success alert-dismissable alert-success alert-shadow'>");
                            $form.parent().find('.success > .alert.success').html("<button  onclick=\"document.getElementById('success').remove();\" type='button' class='close' data-dismiss='alert' aria-hidden='true'>×")
                                .append("</button>");
                            $form.parent().find('.success > .alert.success')
                                .append("Thank you for contacting us. We have received your information, and will get back to you shortly.");
                            $form.parent().find('.success > .alert.success')
                                .append('</div>');
                            $("body").scrollTop($("#contact-form-alert").offset().top - 60);
                        }
                        /* clear all fields*/
                        $form.trigger("reset");

                        gtag('event', 'Contact Form Submitted', {
                            'event_category': 'Contact Form' + my_global_traffick_type_label,
                            'event_label': my_global_event_label,
                            'value': 1
                        });
                        gtag_report_conversion(my_global_contact_form_conversion_id);

                    },
                    error: function (e) {

                        $form.parent().find(".loading").css("visibility", "hidden");
                        /* Fail message */
                        var errorMesage = "";
                        var responseText = e.responseText;
                        try {
                            var json = $.parseJSON(responseText);
                            errorMesage = json.responseText;
                        }
                        catch (e) {

                        }
                        window.location.href = "/error/contactformerror?name=" + name + "&phone=" + phone + "&email=" + email + "&error=" + errorMesage;
                    }
                });
            }

        },

        filter: function () {
            return $(this).is(":visible");
        },
    });

    $("#financing-contactform").find("input,select,textarea").jqBootstrapValidation({
        preventSubmit: true,
        submitError: function ($form, event, errors) {
            /*additional error messages or events*/
        },
        submitSuccess: function ($form, event) {
            event.preventDefault(); /* prevent default submit behaviour*/

            if (!pageContactFormReady) {
                $form.find('.g-recaptcha').addClass('error');
                $form.find('.recaptcha-error').text('* Please check the captcha!');
            }
            else {

                /*get values from FORM*/
                var firstname = $form.find('input[name="firstName"]').val();
                var lastname = $form.find('input[name="lastName"]').val();
                var email = $form.find('input[name="email"]').val();
                var phone = $form.find('input[name="phone"]').val();
                var appointmentDate = $form.find('input[name="appointmentDate"]').val();
                var subject = $form.find('input[name="subject"]').val();
                var leadTypeId = $form.find('input[name="leadTypeId"]').val();
                var providerUrl = $form.find('input[name="providerUrl"]').val();
                var providerName = $form.find('input[name="providerName"]').val();
                var token = $form.find('input[name="__RequestVerificationToken"]').val();
                var urlReferer = $form.find('input[name="urlReferer"]').val();
                var firstVisitId = my_global_first_visit_id;
                var lastVisitId = my_global_last_visit_id;
                var g_recaptcha_response = $form.find('textarea[name="g-recaptcha-response"]').val()


                /*if (firstName.indexOf(' ') >= 0) {
                    firstName = name.split(' ').slice(0, -1).join(' ');
                } */
                $form.hide();

                $form.parent().find('.success').html("");
                $form.parent().find('.loading').css("visibility", "visible");

                var actionUrl = "/contactform/financingleadsubmit";

                $.ajax({
                    url: actionUrl,
                    type: "POST",
                    data: {
                        firstName: firstname,
                        lastName: lastname,
                        phone: phone,
                        email: email,
                        appointmentDate: appointmentDate,
                        subject: subject,
                        leadTypeId: leadTypeId,
                        providerUrl: providerUrl,
                        providerName: providerName,
                        referrer: urlReferer,
                        __RequestVerificationToken: token,
                        firstVisitId: firstVisitId,
                        lastVisitId: lastVisitId,
                        'g-recaptcha-response': g_recaptcha_response

                    },
                    cache: false,
                    success: function (response) {
                        $form.parent().find(".loading").css("visibility", "hidden");

                        gtag('event', 'Financing Contact Form Submitted', {
                            'event_category': 'Financing Inquire' + my_global_traffick_type_label,
                            'event_label': my_global_event_label,
                            'value': 1
                        });

                        gtag_report_conversion(my_global_financing_inquire_conversion_id);

                        window.location.href = response.redirect;
                    },
                    error: function (e) {
                        $form.parent().find(".loading").hide();
                        /* Fail message */
                        var errorMesage = "";
                        var responseText = e.responseText;
                        try {
                            var json = $.parseJSON(responseText);
                            errorMesage = json.responseText;
                        }
                        catch (e) {

                        }
                        window.location.href = "/error/contactformerror?name=" + firstname + " " + lastname + "&phone=" + phone + "&email=" + email + "&error=" + errorMesage;
                    },
                })
            }
        },
        filter: function () {
            return $(this).is(":visible");
        },
    });


    $("a[data-toggle=\"tab\"]").click(function (e) {
        e.preventDefault();
        $(this).tab("show");
    });
});


/*When clicking on Full hide fail/success boxes */
$('#name').focus(function () {
    $('.success').html('');
});



