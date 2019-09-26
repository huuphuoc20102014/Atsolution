$(document).ready(function () {
    $(".btn-send").click(function () {
        $("#myform").validate({
            rules: {
                name: {
                    required: true,
                    maxlength: 50
                },
                email: {
                    required: true,
                    email: true,
                    maxlength: 50
                },
                phone: {
                    required: true,
                    maxlength: 20
                },
                title: {
                    required: true,
                    maxlength: 1000
                },
                body: {
                    required: true,
                },
            },
            messages: {
                name: {
                    required: "Vui lòng nhâp tên!",
                    maxlength: "Tên quá dài!"
                },
                email: {
                    required: 'Vui lòng nhập Email',
                    minlength: 'Email quá dài!'
                },
                title: {
                    required: 'Vui lòng nhập tiêu đề',
                    maxlength: 'Tiêu đề quá dài!'
                },
                phone: {
                    required: 'Vui lòng nhập số điện thoại',
                    maxlength: 'Số điện thoại quá dài!'
                },
                body: {
                    required: 'Vui lòng nhập nội dung!'
                },
            }
        });


        var form = $("#myform");
        form.validate();
        if (form.valid()) {
            $.alert({
                title: 'Thông báo!',
                content: 'Gửi thành công!',
            });
        }
    });



    $(".btn-reset").click(function () {
        $("#name").val('');
        $("#email").val('');
        $("#phone").val('');
        $("#Title").val('');
        $("#body").val('');
    });
});
