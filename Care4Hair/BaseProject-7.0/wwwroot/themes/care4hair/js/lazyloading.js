if (document.readyState !== "loading") {
    lazyLoading();
}
else {
    document.addEventListener("DOMContentLoaded", lazyLoading());
}


function lazyLoading() {
    var lazyBackgrounds = [].slice.call(document.querySelectorAll(".lazy-background"));
    var lazyImages = [].slice.call(document.querySelectorAll(".lazy img, .lazy source"));

    if ("IntersectionObserver" in window) {

        if (lazyBackgrounds.length > 0) {
            let lazyBackgroundObserver = new IntersectionObserver(function (entries, observer) {
                entries.forEach(function (entry) {
                    if (entry.isIntersecting) {
                        entry.target.classList.add("visible");
                        lazyBackgroundObserver.unobserve(entry.target);
                    }
                });
            });

            lazyBackgrounds.forEach(function (lazyBackground) {
                lazyBackgroundObserver.observe(lazyBackground);
            });
        }
        //////////////////////////////////////////////////////////////
        if (lazyImages.length > 0) {
            let lazyImageObserver = new IntersectionObserver(function (entries, observer) {
                entries.forEach(function (entry) {
                    if (entry.isIntersecting) {
                        let lazyImage = entry.target;
                        if (typeof lazyImage.dataset.src !== 'undefined') {
                            lazyImage.src = lazyImage.dataset.src;
                        }
                        if (typeof lazyImage.dataset.srcset !== 'undefined') {
                            lazyImage.srcset = lazyImage.dataset.srcset;
                        }
                        lazyImage.classList.remove("lazy");
                        lazyImageObserver.unobserve(lazyImage);
                    }
                });
            });

            lazyImages.forEach(function (lazyImage) {
                lazyImageObserver.observe(lazyImage);
            });
        }
        //////////////////////////////////////////////////////////////

        var lazyCarouselImages = [].slice.call(document.querySelectorAll(".lazy-carousel img, .lazy-carousel source"));

        if (lazyCarouselImages.length > 0) {
            let lazyCarouselObserver = new IntersectionObserver(function (entries, observer) {
                entries.forEach(function (entry) {
                    if (entry.isIntersecting) {
                        lazyCarouselImages.forEach(function (lazyImage) {
                            if (typeof lazyImage.dataset.src !== 'undefined') {
                                lazyImage.src = lazyImage.dataset.src;
                            }
                            if (typeof lazyImage.dataset.srcset !== 'undefined') {
                                lazyImage.srcset = lazyImage.dataset.srcset;
                            }
                            lazyImage.classList.remove("lazy");
                            lazyCarouselObserver.unobserve(lazyImage);
                        });
                    }
                });
            });

            let instagram_posts_div = document.querySelector('#take_a_look_carousel');
            lazyCarouselObserver.observe(instagram_posts_div);
        }
    }
    else {
        lazyBackgrounds.forEach(function (lazyBackground) {
            lazyBackground.classList.add("visible");
        });

        lazyImages.forEach(function (lazyImage) {
            if (typeof lazyImage.dataset.src !== 'undefined') {
                lazyImage.src = lazyImage.dataset.src;
            }
            if (typeof lazyImage.dataset.srcset !== 'undefined') {
                lazyImage.srcset = lazyImage.dataset.srcset;

            }
        });

        var lazyCarouselImages = [].slice.call(document.querySelectorAll(".lazy.carousel img, .lazy.carousel source"));

        lazyCarouselImages.forEach(function (lazyImage) {
            if (typeof lazyImage.dataset.src !== 'undefined') {
                lazyImage.src = lazyImage.dataset.src;
            }
            if (typeof lazyImage.dataset.srcset !== 'undefined') {
                lazyImage.srcset = lazyImage.dataset.srcset;
            }
            lazyImage.classList.remove("lazy");
        });
    }
}
