function setTheme(theme) {
    var themes = ["black-theme", "gray-theme"];
    for (var i = 0; i < themes.length; i++) {

        var styleSheet = document.getElementById(themes[i]);
        if (themes[i] == theme) {
            styleSheet.removeAttribute("disabled");
        } else {
            styleSheet.setAttribute("disabled", "disabled");
        }
    }
}