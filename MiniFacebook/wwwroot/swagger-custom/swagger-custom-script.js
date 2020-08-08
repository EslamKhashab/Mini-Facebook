(function () {
    window.addEventListener("load", function () {
        setTimeout(function () {
            var logo = document.getElementsByClassName('link');
            logo[0].children[0].src = window.location.protocol + '//' + window.location.hostname + ':' + window.location.port + '/1b7d65b.svg';
        });
    });

    var link = document.querySelector("link[rel*='icon']") || document.createElement('link');;
    document.head.removeChild(link);
    link = document.querySelector("link[rel*='icon']") || document.createElement('link');
    document.head.removeChild(link);
    link = document.createElement('link');
    link.type = 'image/x-icon';
    link.rel = 'shortcut icon';
    link.href = window.location.protocol + '//' + window.location.hostname + ':' + window.location.port + '/favicon.ico';
    document.getElementsByTagName('head')[0].appendChild(link);
})();