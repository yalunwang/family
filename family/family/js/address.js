$(function () {
    select1();
    $('#S1').bind("change", select2);
    $('#S2').bind("change", select3);
});
    function select1() {
        $.ajax(
        {
            type: "post",
            url: "../address.aspx",
            data: { "operation": "province" },
            success: function (msg) {
                for (var i = 0; i < msg.length; i++) {
                    $("#S1").append("<option value=" + msg[i].ProvinceID + ">" + msg[i].ProvinceName + "</option>");
                }
                
                select2();
            }
        })
    };
function select2() {
    $("#S2").html("");
    $.ajax(
    {
        type: "post",
        url: "../address.aspx",
        data: { "operation": "city", "provinceID": $('#S1').val() },
        success: function (msg) {
            for (var i = 0; i < msg.length; i++) {
                $("#S2").append("<option value=" + msg[i].CityID + ">" + msg[i].CityName + "</option>");
            }
            select3();
        }
    })
};
function select3() {
    $("#S3").html("");
    $.ajax(
    {
        type: "post",
        url: "../address.aspx",
        data: { "operation": "cityZone", "cityID": $('#S2').val() },
        success: function (msg) {
            for (var i = 0; i < msg.length; i++) {
                $("#S3").append("<option value=" + msg[i].cityZoneID + ">" + msg[i].cityZoneName + "</option>");
            }
        }
    })
};


