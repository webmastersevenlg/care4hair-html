if (window.innerWidth < 1000) {
    document.querySelector('.patient-portal').innerHTML = "PORTAL";
}


const menuDoctor = document.querySelector('.menu-doctor');
const submenuDoctor = document.querySelector('.doctors-submenu');

const menuHairloss = document.querySelector('.menu-hairloss');
const submenuHairloss = document.querySelector('.hairloss-submenu');

const menuHairtransplant = document.querySelector('.menu-hairtransplant');
const submenuHairtransplant = document.querySelector('.hairtransplant-submenu');

const menuNonsurgical = document.querySelector('.menu-nonsurgical');
const submenuNonsurgical = document.querySelector('.nonsurgical-submenu');

const menuResources = document.querySelector('.menu-resources');
const submenuResources = document.querySelector('.resources-submenu');

if (menuDoctor) {
    menuDoctor.addEventListener('mouseover', activateMenuDoctor);
}

if (menuHairloss) {
    menuHairloss.addEventListener('mouseover', activateMenuHairloss);
}

if (menuHairtransplant) {
    menuHairtransplant.addEventListener('mouseover', activateMenuHairtransplant);
}

if (menuNonsurgical) {
    menuNonsurgical.addEventListener('mouseover', activateMenuNonsurgical); 
}

if (menuResources) {
    menuResources.addEventListener('mouseover', activateMenuResources);
}

function activateMenuDoctor() {
    submenuDoctor.classList.add('active');

    submenuHairloss.classList.remove('active');
    submenuHairtransplant.classList.remove('active');
    submenuNonsurgical.classList.remove('active');
    submenuResources.classList.remove('active');
}
function activateMenuHairloss() {
    submenuHairloss.classList.add('active');
    
    submenuDoctor.classList.remove('active');
    submenuHairtransplant.classList.remove('active');
    submenuNonsurgical.classList.remove('active');
    submenuResources.classList.remove('active');
}
function activateMenuHairtransplant() {
    submenuHairtransplant.classList.add('active');

    submenuHairloss.classList.remove('active');
    submenuDoctor.classList.remove('active');
    submenuNonsurgical.classList.remove('active');
    submenuResources.classList.remove('active');
}
function activateMenuNonsurgical() {
    submenuNonsurgical.classList.add('active');

    submenuHairloss.classList.remove('active');
    submenuHairtransplant.classList.remove('active');
    submenuDoctor.classList.remove('active');
    submenuResources.classList.remove('active');
}
function activateMenuResources() {
    submenuResources.classList.add('active');

    submenuHairloss.classList.remove('active');
    submenuHairtransplant.classList.remove('active');
    submenuNonsurgical.classList.remove('active');
    submenuDoctor.classList.remove('active');
}


const mobileDoctor = document.querySelector('.mobile-doctor');
const mobileHairloss = document.querySelector('.mobile-hairloss');
const mobileHairtransplant = document.querySelector('.mobile-hairtransplant');
const mobileNonsurgical = document.querySelector('.mobile-nonsurgical');
const mobileResources = document.querySelector('.mobile-resources');

const mobileDoctorArrow = document.querySelector('.mobile-doctor-arrow');
const mobileHairlossArrow = document.querySelector('.mobile-hairloss-arrow');
const mobileHairtransplantArrow = document.querySelector('.mobile-hairtransplant-arrow');
const mobileNonsurgicalArrow = document.querySelector('.mobile-nonsurgical-arrow');
const mobileResourcesArrow = document.querySelector('.mobile-resources-arrow');

function openMobileDoctor() {
    mobileDoctor.classList.toggle('active');
    
    mobileHairloss.classList.remove('active');
    mobileHairtransplant.classList.remove('active');
    mobileNonsurgical.classList.remove('active');
    mobileResources.classList.remove('active');

    mobileDoctorArrow.classList.toggle('active');
    mobileHairlossArrow.classList.remove('active');
    mobileHairtransplantArrow.classList.remove('active');
    mobileNonsurgicalArrow.classList.remove('active');
    mobileResourcesArrow.classList.remove('active');
}
function openMobileHairloss() {
    mobileHairloss.classList.toggle('active');
    
    mobileDoctor.classList.remove('active');
    mobileHairtransplant.classList.remove('active');
    mobileNonsurgical.classList.remove('active');
    mobileResources.classList.remove('active');

    mobileDoctorArrow.classList.remove('active');
    mobileHairlossArrow.classList.toggle('active');
    mobileHairtransplantArrow.classList.remove('active');
    mobileNonsurgicalArrow.classList.remove('active');
    mobileResourcesArrow.classList.remove('active');
}
function openMobileHairtransplant() {
    mobileHairtransplant.classList.toggle('active');
    
    mobileHairloss.classList.remove('active');
    mobileDoctor.classList.remove('active');
    mobileNonsurgical.classList.remove('active');
    mobileResources.classList.remove('active');

    mobileDoctorArrow.classList.remove('active');
    mobileHairlossArrow.classList.remove('active');
    mobileHairtransplantArrow.classList.toggle('active');
    mobileNonsurgicalArrow.classList.remove('active');
    mobileResourcesArrow.classList.remove('active');
}
function openMobileNonsurgical() {
    mobileNonsurgical.classList.toggle('active');
    
    mobileHairloss.classList.remove('active');
    mobileHairtransplant.classList.remove('active');
    mobileDoctor.classList.remove('active');
    mobileResources.classList.remove('active');

    mobileDoctorArrow.classList.remove('active');
    mobileHairlossArrow.classList.remove('active');
    mobileHairtransplantArrow.classList.remove('active');
    mobileNonsurgicalArrow.classList.toggle('active');
    mobileResourcesArrow.classList.remove('active');
}
function openMobileResources() {
    mobileResources.classList.toggle('active');
    
    mobileHairloss.classList.remove('active');
    mobileHairtransplant.classList.remove('active');
    mobileNonsurgical.classList.remove('active');
    mobileDoctor.classList.remove('active');

    mobileDoctorArrow.classList.remove('active');
    mobileHairlossArrow.classList.remove('active');
    mobileHairtransplantArrow.classList.remove('active');
    mobileNonsurgicalArrow.classList.remove('active');
    mobileResourcesArrow.classList.toggle('active');
}

const menu = document.querySelector('.menu');
const mobileMenu = document.querySelector('.mobile-menu');

function toggleMenu() {
    menu.classList.toggle('active');
    mobileMenu.classList.toggle('active');
}

let technique1 = document.querySelector('.technique1');
let techniqueTab1 = document.querySelector('.technique-tab1');
let benefits1 = document.querySelector('.benefits1');
let benefitsTab1 = document.querySelector('.benefits-tab1');

let technique2 = document.querySelector('.technique2');
let techniqueTab2 = document.querySelector('.technique-tab2');
let benefits2 = document.querySelector('.benefits2');
let benefitsTab2 = document.querySelector('.benefits-tab2');

function openTechnique1() {
    technique1.classList.add('active');
    techniqueTab1.classList.add('active');
    benefits1.classList.remove('active');
    benefitsTab1.classList.remove('active');
} 
function openBenefits1() {
    technique1.classList.remove('active');
    techniqueTab1.classList.remove('active');
    benefits1.classList.add('active');
    benefitsTab1.classList.add('active');
} 

function openTechnique2() {
    technique2.classList.add('active');
    techniqueTab2.classList.add('active');
    benefits2.classList.remove('active');
    benefitsTab2.classList.remove('active');
} 
function openBenefits2() {
    technique2.classList.remove('active');
    techniqueTab2.classList.remove('active');
    benefits2.classList.add('active');
    benefitsTab2.classList.add('active');
} 

let imageCarousel = document.querySelector('.image-carousel');

let dot1 = document.querySelector('.dot1');
let dot2 = document.querySelector('.dot2');
let dot3 = document.querySelector('.dot3');
let dot4 = document.querySelector('.dot4');
let dot5 = document.querySelector('.dot5');
let dot6 = document.querySelector('.dot6');

function activateDot1() {
    dot1.classList.add('active');
    dot2.classList.remove('active');
    dot3.classList.remove('active');
    dot4.classList.remove('active');
    dot5.classList.remove('active');
    dot6.classList.remove('active');
}

function activateDot2() {
    dot2.classList.add('active');
    dot1.classList.remove('active');
    dot3.classList.remove('active');
    dot4.classList.remove('active');
    dot5.classList.remove('active');
    dot6.classList.remove('active');
}

function activateDot3() {
    dot3.classList.add('active');
    dot2.classList.remove('active');
    dot1.classList.remove('active');
    dot4.classList.remove('active');
    dot5.classList.remove('active');
    dot6.classList.remove('active');
}

function activateDot4() {
    dot4.classList.add('active');
    dot2.classList.remove('active');
    dot3.classList.remove('active');
    dot1.classList.remove('active');
    dot5.classList.remove('active');
    dot6.classList.remove('active');
}

function activateDot5() {
    dot5.classList.add('active');
    dot2.classList.remove('active');
    dot3.classList.remove('active');
    dot4.classList.remove('active');
    dot1.classList.remove('active');
    dot6.classList.remove('active');
}

function activateDot6() {
    dot6.classList.add('active');
    dot2.classList.remove('active');
    dot3.classList.remove('active');
    dot4.classList.remove('active');
    dot5.classList.remove('active');
    dot1.classList.remove('active');
}

if (dot1) {
    dot1.addEventListener('click', () => {

        activateDot1();

        imageCarousel.classList.add('group-1');

        imageCarousel.classList.remove('group-2');
        imageCarousel.classList.remove('group-3');
        imageCarousel.classList.remove('group-4');
        imageCarousel.classList.remove('group-5');
        imageCarousel.classList.remove('group-6');
    });
}

if (dot2) {
    dot2.addEventListener('click', () => {
            
        activateDot2();

        imageCarousel.classList.add('group-2');

        imageCarousel.classList.remove('group-1');
        imageCarousel.classList.remove('group-3');
        imageCarousel.classList.remove('group-4');
        imageCarousel.classList.remove('group-5');
        imageCarousel.classList.remove('group-6');
    });
}

if (dot3) {
    dot3.addEventListener('click', () => {
            
        activateDot3();

        imageCarousel.classList.add('group-3');

        imageCarousel.classList.remove('group-2');
        imageCarousel.classList.remove('group-1');
        imageCarousel.classList.remove('group-4');
        imageCarousel.classList.remove('group-5');
        imageCarousel.classList.remove('group-6');
    });
}

if (dot4) {
    dot4.addEventListener('click', () => {
            
        activateDot4();

        imageCarousel.classList.add('group-4');

        imageCarousel.classList.remove('group-2');
        imageCarousel.classList.remove('group-3');
        imageCarousel.classList.remove('group-1');
        imageCarousel.classList.remove('group-5');
        imageCarousel.classList.remove('group-6');
    });
}

if (dot5) {
    dot5.addEventListener('click', () => {
            
        activateDot5();

        imageCarousel.classList.add('group-5');

        imageCarousel.classList.remove('group-2');
        imageCarousel.classList.remove('group-3');
        imageCarousel.classList.remove('group-4');
        imageCarousel.classList.remove('group-1');
        imageCarousel.classList.remove('group-6');
    });
}

if (dot6) {
    dot6.addEventListener('click', () => {
            
        activateDot6();

        imageCarousel.classList.add('group-6');

        imageCarousel.classList.remove('group-2');
        imageCarousel.classList.remove('group-3');
        imageCarousel.classList.remove('group-4');
        imageCarousel.classList.remove('group-5');
        imageCarousel.classList.remove('group-1');
    });
}

// setInterval(function(){

if (imageCarousel) {
    if (imageCarousel.classList.contains('group-1')) {
            
        activateDot1();
        imageCarousel.classList.remove('group-1');
        imageCarousel.classList.add('group-2');
    }
    else if (imageCarousel.classList.contains('group-2')) {
            
        activateDot2();
        imageCarousel.classList.remove('group-2');
        imageCarousel.classList.add('group-3');
    }
    else if (imageCarousel.classList.contains('group-3')) {
            
        activateDot3();
        imageCarousel.classList.remove('group-3');
        imageCarousel.classList.add('group-4');
    }
    else if (imageCarousel.classList.contains('group-4')) {
            
        activateDot4();
        imageCarousel.classList.remove('group-4');
        imageCarousel.classList.add('group-5');
    }
    else if (imageCarousel.classList.contains('group-5')) {
            
        activateDot5();
        imageCarousel.classList.remove('group-5');
        imageCarousel.classList.add('group-6');
    }
    else if (imageCarousel.classList.contains('group-6')) {
            
        activateDot6();
        imageCarousel.classList.remove('group-6');
        imageCarousel.classList.add('group-1');
    }
    else {
        activateDot1();
        imageCarousel.classList.add('group-1')
    }
}


// }, 4000);


let procedure1 = document.querySelector('.procedure1');
let procedure2 = document.querySelector('.procedure2');
let procedure3 = document.querySelector('.procedure3');
let procedure4 = document.querySelector('.procedure4');
let procedureText1 = document.querySelector('.procedure-text-1');
let procedureText2 = document.querySelector('.procedure-text-2');
let procedureText3 = document.querySelector('.procedure-text-3');
let procedureText4 = document.querySelector('.procedure-text-4');

function activateProcedure1() {
    procedure1.classList.add('active');
    procedure2.classList.remove('active');
    procedure3.classList.remove('active');
    procedure4.classList.remove('active');
    
    procedureText1.classList.add('active');
    procedureText2.classList.remove('active');
    procedureText3.classList.remove('active');
    procedureText4.classList.remove('active');
}
function activateProcedure2() {
    procedure2.classList.add('active');
    procedure1.classList.remove('active');
    procedure3.classList.remove('active');
    procedure4.classList.remove('active');

    procedureText2.classList.add('active');
    procedureText1.classList.remove('active');
    procedureText3.classList.remove('active');
    procedureText4.classList.remove('active');
}
function activateProcedure3() {
    procedure3.classList.add('active');
    procedure2.classList.remove('active');
    procedure1.classList.remove('active');
    procedure4.classList.remove('active');

    procedureText3.classList.add('active');
    procedureText2.classList.remove('active');
    procedureText1.classList.remove('active');
    procedureText4.classList.remove('active');
}
function activateProcedure4() {
    procedure4.classList.add('active');
    procedure2.classList.remove('active');
    procedure3.classList.remove('active');
    procedure1.classList.remove('active');

    procedureText4.classList.add('active');
    procedureText2.classList.remove('active');
    procedureText3.classList.remove('active');
    procedureText1.classList.remove('active');
}


// FAQ Accordion

var accordion = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < accordion.length; i++) {
  accordion[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var panel = this.nextElementSibling;
    if (panel.style.maxHeight) {
      panel.style.maxHeight = null;
    } else {
      panel.style.maxHeight = panel.scrollHeight + "px";
    } 
  });
}


// Gallery on about us page

let aboutUsGallery = document.querySelector('.about-us-gallery');
let galleryDots = document.querySelectorAll('.about-us-gallery-dots div');

let galleryDot1 = document.querySelector('.gallery-dot-1');
let galleryDot2 = document.querySelector('.gallery-dot-2');
let galleryDot3 = document.querySelector('.gallery-dot-3');
let galleryDot4 = document.querySelector('.gallery-dot-4');
let galleryDot5 = document.querySelector('.gallery-dot-5');
let galleryDot6 = document.querySelector('.gallery-dot-6');
let galleryDot7 = document.querySelector('.gallery-dot-7');
let galleryDot8 = document.querySelector('.gallery-dot-8');
let galleryDot9 = document.querySelector('.gallery-dot-9');
let galleryDot10 = document.querySelector('.gallery-dot-10');
let galleryDot11 = document.querySelector('.gallery-dot-11');
let galleryDot12 = document.querySelector('.gallery-dot-12');
let galleryDot13 = document.querySelector('.gallery-dot-13');

function activateGalleryDot1() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-1');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot1.classList.add('active');
}
function activateGalleryDot2() {
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-2');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot2.classList.add('active');
}
function activateGalleryDot3() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-3');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot3.classList.add('active');
}
function activateGalleryDot4() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-4');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot4.classList.add('active');
}
function activateGalleryDot5() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-5');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot5.classList.add('active');
}
function activateGalleryDot6() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-6');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot6.classList.add('active');
}
function activateGalleryDot7() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-7');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot7.classList.add('active');
}
function activateGalleryDot8() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-8');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot8.classList.add('active');
}
function activateGalleryDot9() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-9');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot9.classList.add('active');
}
function activateGalleryDot10() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-10');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot10.classList.add('active');
}
function activateGalleryDot11() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-11');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot11.classList.add('active');
}
function activateGalleryDot12() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.remove('gallery-img-13');
    aboutUsGallery.classList.add('gallery-img-12');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot12.classList.add('active');
}
function activateGalleryDot13() {
    aboutUsGallery.classList.remove('gallery-img-2');
    aboutUsGallery.classList.remove('gallery-img-3');
    aboutUsGallery.classList.remove('gallery-img-4');
    aboutUsGallery.classList.remove('gallery-img-5');
    aboutUsGallery.classList.remove('gallery-img-6');
    aboutUsGallery.classList.remove('gallery-img-7');
    aboutUsGallery.classList.remove('gallery-img-8');
    aboutUsGallery.classList.remove('gallery-img-9');
    aboutUsGallery.classList.remove('gallery-img-10');
    aboutUsGallery.classList.remove('gallery-img-11');
    aboutUsGallery.classList.remove('gallery-img-12');
    aboutUsGallery.classList.remove('gallery-img-1');
    aboutUsGallery.classList.add('gallery-img-13');

    galleryDots.forEach(element => {
        element.classList.remove('active');
    });

    galleryDot13.classList.add('active');
}

setInterval(function(){

if (aboutUsGallery) {
    if (aboutUsGallery.classList.contains('gallery-img-1')) {
            
        activateGalleryDot2();
    }
    else if (aboutUsGallery.classList.contains('gallery-img-2')) {
            
        activateGalleryDot3();
    }
    else if (aboutUsGallery.classList.contains('gallery-img-3')) {
            
        activateGalleryDot4();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-4')) {
            
        activateGalleryDot5();
       
    }
    else if (aboutUsGallery.classList.contains('gallery-img-5')) {
            
        activateGalleryDot6();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-6')) {
            
        activateGalleryDot7();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-7')) {
            
        activateGalleryDot8();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-8')) {
            
        activateGalleryDot9();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-9')) {
            
        activateGalleryDot10();
       
    }
    else if (aboutUsGallery.classList.contains('gallery-img-10')) {
            
        activateGalleryDot11();
      
    }
    else if (aboutUsGallery.classList.contains('gallery-img-11')) {
            
        activateGalleryDot12();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-12')) {
            
        activateGalleryDot13();
        
    }
    else if (aboutUsGallery.classList.contains('gallery-img-13')) {
            
        activateGalleryDot1();

    }
}

}, 6000);


gsap.to("header", {
    scrollTrigger: {
        trigger: "body",
        start: "150 top",
        toggleClass: { targets: "header", className: "header-bg" }
    },
});