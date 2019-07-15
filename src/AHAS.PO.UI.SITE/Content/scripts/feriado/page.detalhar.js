$(".module-body").on("click", ".btn-danger", null, (e) => {
    e.preventDefault();

    var model = {
        id: $('input[id="IDFeriado"]').val(),
        descricao: $('input[id="IDFeriado"]').attr("descricao")
    }

    swal({
        title: "Você confirma a exclusão?",
        text: "Você está prestes a excluir o feriado '" + model.descricao + "', se confirmar não será possível recuperá-lo.",
        icon: "warning",
        buttons: ["Cancelar", "Confirmar"],
        dangerMode: true,
    })
        .then((isConfirm) => {
            if (isConfirm) {
                $.post("/Feriado/Excluir/", model)
                    .done(function (resultado) {
                        if (resultado.Sucess) {
                            swal({
                                title: "Excluído!",
                                text: "Exclusão efetuada com sucesso.",
                                icon: "success",
                            }).then((result) => {
                                if (result) {
                                    window.location.href = '/Feriado/Index'; 
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
                swal("Cancelado!", "A exclusão do feriado foi cancelada com sucesso.", "error");
            }
        });
});