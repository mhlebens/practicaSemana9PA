// wwwroot/js/registro-validate.js
(function ($) {

    // Solo letras/espacios y mínimo 3 letras reales (no cuenta espacios)
    $.validator.addMethod("nombreSoloLetras", function (value, element) {
        if (!value) return false;
        const v = value.trim();
        // Solo letras y espacios, sin dobles espacios ni espacios al inicio/fin
        const formatoOk = /^[A-Za-zÁÉÍÓÚáéíóúÑñ]+(?: [A-Za-zÁÉÍÓÚáéíóúÑñ]+)*$/.test(v);
        // Contar letras (sin espacios) y exigir >= 3
        const letras = v.replace(/[^A-Za-zÁÉÍÓÚáéíóúÑñ]/g, "");
        return formatoOk && letras.length >= 3;
    }, "Solo letras y espacios, mínimo 3 letras");

    // Contiene @ y .
    $.validator.addMethod("arrobaPunto", function (value, element) {
        if (!value) return false;
        const v = value.trim();
        return v.includes("@") && v.includes(".");
    }, "Debe contener '@' y '.'");

    // Solo dígitos, mínimo 9
    $.validator.addMethod("telefonoMin9", function (value, element) {
        if (!value) return false;
        return /^\d{9,}$/.test(value.trim());
    }, "Solo dígitos, mínimo 9");

    $(function () {
        $("#form-registro").validate({
            // No ignores (importante para selects ocultos por CSS, etc.)
            ignore: "",

            rules: {
                NombreCompleto: {
                    required: true,
                    nombreSoloLetras: true
                },
                Correo: {
                    required: true,
                    arrobaPunto: true
                },
                Telefono: {
                    required: true,
                    telefonoMin9: true
                },
                Carrera: {
                    required: true
                }
            },

            messages: {
                NombreCompleto: { required: "El nombre es obligatorio" },
                Correo: { required: "El correo es obligatorio" },
                Telefono: { required: "El teléfono es obligatorio" },
                Carrera: { required: "Seleccione su carrera" }
            },

            errorClass: "text-danger",
            highlight: function (el) { $(el).addClass("is-invalid"); },
            unhighlight: function (el) { $(el).removeClass("is-invalid"); }
        });
    });

})(jQuery);
