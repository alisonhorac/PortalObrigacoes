﻿$(".module-body").on("click", ".btn-danger", null, (e) => {
    e.preventDefault();

    var model = {
        id: $('input[id="IDUnidade"]').val(),
        descricao: $('input[id="IDUnidade"]').attr("descricao")
    }

    swal({
        title: "Você confirma a exclusão?",
        text: "Você está prestes a excluir a unidade '" + model.descricao + "', se confirmar não será possível recuperá-lo.",
        icon: "warning",
        buttons: ["Cancelar", "Confirmar"],
        dangerMode: true,
    })
        .then((isConfirm) => {
            if (isConfirm) {
                $.post("/Unidade/Excluir/", model)
                    .done(function (resultado) {
                        if (resultado.Sucess) {
                            swal({
                                title: "Excluído!",
                                text: "Exclusão efetuada com sucesso.",
                                icon: "success",
                            }).then((result) => {
                                if (result) {
                                    window.location.href = '/Unidade/Index'; 
                                }
                            })
                        }
                        else {
                            var erros = "";
                            $(resultado.Error).each(function () {
                                erros += this.toString() + ". ";
                            });
                            swal("Atenção!", erros, "info");
                        }
                    });
            }
            else {
                swal("Cancelado!", "A exclusão da unidade foi cancelada com sucesso.", "error");
            }
        });
});