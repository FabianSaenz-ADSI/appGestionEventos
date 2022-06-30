
$(document).ready(function () {
    mostrarTablaReserva();


});


var tabla, datos;


function mostrarTablaReserva() {
    $.ajax({
        type: "POST",
        url: "frmMisReservas.aspx/mtdListarReservaBoleta",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (datos) {

            function agregarFilas(datos) {
                console.log(datos);
                tabla = $("#tblDatosReserva").dataTable();
                if (datos[0].nombreEmpresa != null) {
                    for (var i = 0; i < datos.length; i++) {

                        tabla.fnAddData([
                            datos[i].idBoleteria,
                            datos[i].nombreEmpresa,
                            datos[i].fechaReserva,
                            datos[i].nombreEvento,
                            datos[i].cantidadBoletas,
                            datos[i].totalReserva,
                            '<button type="button" title="Cancelar" id="btnCancelar"  idusuarioCancelar="' + datos[i].idBoleteria + '" class="btn btn-danger "><i style="font - size: 24px" class="fas">&#xf2ed;</i></button>',
                            '<button type="button" title="Comprar" id="btnComprar"  idusuarioComprar="' + datos[i].idBoleteria + '" class="btn btn-info"><i style="font - size: 24px" class="far">&#xf09d;</i></button>'

                        ]);
                    }

                } else {
                    for (var i = 0; i < datos.length; i++) {

                        tabla.fnAddData([
                            datos[i].idBoleteria,
                            datos[i].nombres,
                            datos[i].fechaReserva,
                            datos[i].nombreEvento,
                            datos[i].cantidadBoletas,
                            datos[i].totalReserva,
                            '<button type="button" title="Cancelar" id="btnCancelar"  idusuarioCancelar="' + datos[i].idBoleteria + '" class="btn btn-danger "><i style="font - size: 24px" class="fas">&#xf2ed;</i></button>',
                            '<button type="button" title="Comprar" id="btnComprar"  idusuarioComprar="' + datos[i].idBoleteria + '" class="btn btn-info"><i style="font - size: 24px" class="far">&#xf09d;</i></button>'


                        ]);
                    }

                }

            }
            agregarFilas(datos.d);


        },
        failure: function (response) {
            alert(response);
        },
        error: function (response) {
            alert(response.d);
        }


    })
};


$("#tblDatosReserva").on("click", "#btnCancelar", function (e) {

    e.preventDefault();
    var idBoleteria = $(this).attr("idusuarioCancelar");
    var tabla = $('#tblDatosReserva').DataTable();

    swal({
        title: "Advertencia!",
        text: "Estas seguro de cancelar esta Reserva?",
        icon: "warning",
        buttons: {
            cancel: "Cancelar",
            defeat: "Aceptar"
        },
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {

                var datosCancelar = {
                    objDatos: {
                        idBoleteria: idBoleteria
                    }
                }

                $.ajax({
                    method: "POST",
                    url: "frmMisReservas.aspx/mtdCancelarReserva",
                    data: JSON.stringify(datosCancelar),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",

                    success: function (respuesta) {


                        swal("Reserva cancelada con Exito!", {
                            icon: "success",

                        });
                        tabla.clear();
                        mostrarTablaReserva();

                    }

                });

            } else {
                swal("Esta accción ha sido Cancelada!");
            }
        });

});

