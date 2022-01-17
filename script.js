$(document).ready(function() {
    $("#txtCep").focusout(function(){
        var cep = $("#txtCep").val();
        cep = cep.replace("-", "");


        var urlStr = "https://viacep.com.br/ws/" + cep +"/json/";

        $.ajax({
            url : urlStr,
            type: "get", 
            dataType: "json",
            success : function(data){
                console.log(data);
                $("#txtCidade").val(data.localidade);
                $("#txtEstado").val(data.uf);
                $("#txtBairro").val(data.bairro);
                $("#txtRua").val(data.logradouro);
                $("#txtComplemento").val(data.complemento);
            },
            error : function(erro){
                console.log(erro);
            }
        });
    });
});


$(document).on('click', '.dropdown-menu', function (e) {
    e.stopPropagation();
    });

    // make it as accordion for smaller screens
    if ($(window).width() < 992) {
        $('.dropdown-menu a').click(function(e){
            e.preventDefault();
            if($(this).next('.submenu').length){
                $(this).next('.submenu').toggle();
                }
                $('.dropdown').on('hide.bs.dropdown', function () {
                $(this).find('.submenu').hide();
            })
        });
    };