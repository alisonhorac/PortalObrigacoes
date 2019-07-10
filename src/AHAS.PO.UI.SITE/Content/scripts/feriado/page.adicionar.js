//$(function () {
//    $(".date-pt-br").datepicker({
//        closeText: 'Fechar',
//        prevText: '&#x3c;Anterior',
//        nextText: 'Pr&oacute;ximo&#x3e;',
//        currentText: 'Hoje',
//        monthNames: ['Janeiro', 'Fevereiro', 'Mar&ccedil;o', 'Abril', 'Maio', 'Junho',
//            'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
//        monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun',
//            'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
//        dayNames: ['Domingo', 'Segunda-feira', 'Ter&ccedil;a-feira', 'Quarta-feira', 'Quinta-feira', 'Sexta-feira', 'S&aacute;bado'],
//        dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'S&aacute;b'],
//        dayNamesMin: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'S&aacute;b'],
//        weekHeader: 'Sm',
//        dateFormat: 'dd/mm/yy',
//        firstDay: 0,
//        isRTL: false,
//        showMonthAfterYear: false,
//        yearSuffix: ''
//    });
//});

$(function () {
    $(".date-range").daterangepicker({
        opens: 'left',
        "locale": {
            "format": "DD/MM/YYYY",
            "separator": " - ",
            "applyLabel": "Aplicar",
            "cancelLabel": "Fechar",
            "daysOfWeek": ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'S&aacute;b'],
            "monthNames": ['Janeiro', 'Fevereiro', 'Mar&ccedil;o', 'Abril', 'Maio', 'Junho',
                'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro']
        }
    });
});

$('#calendar-datapicker').click(function () {
    $("#PeriodoDeAte").data("daterangepicker").show();
})

$(document).ready(function () {
    $(".select-hidden").change(function () {
        $("select option:selected").each(function () {
            if ($(this).attr("habilitaestado") == "1") {
                divEstado.style.visibility = 'visible';
                divEstado.style.display = 'block';
            }
            else if ($(this).attr("habilitaestado") == "0") {
                divEstado.style.visibility = 'hidden';
                divEstado.style.display = 'none';
            }
        });
    }).change();
});