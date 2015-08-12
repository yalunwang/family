<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="address.aspx.cs" Inherits="adressDEMO.address" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
    <div>
    <select id="S1" name="province" >
        
    </select>
         <select id="S2"    name="province">
      
    </select>
         <select id="S3" name="province">
        
   </select>
    </div>
    <script src="js/jquery.min.js" type="text/javascript"></script>
  <script>
      function select1() {
          $.ajax(
          {
              type: "post",
              url: "",
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
              url: "",
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
              url: "",
              data: { "operation": "cityZone", "cityID": $('#S2').val() },
              success: function (msg) {
                  for (var i = 0; i < msg.length; i++) {
                      $("#S3").append("<option value=" + msg[i].cityZoneID + ">" + msg[i].cityZoneName + "</option>");
                  }
              }
          })
      };
      $(function () {
          select1();
          $('#S1').bind("change", select2);
          $('#S2').bind("change", select3);
      });

  </script>
</body>
</html>
