$(document).ready(function () {
    var lng = 117.635111,
        lat = 24.529799,
        content =
        "<div class='contact-map-marker'>" +
        "<h4 style=''>漳州市艾睿普软件技术有限公司</h4>" +
        "<p>总机：0596-2968095</p>" +
        "<p>传真：0596-2968096</p>" +
        "<p>邮箱：service@irep.com.cn</p > " +
        "<p>地址：福建省漳州市芗城区大学西路翰城一品1幢</p>" +
        "</div>";

    var map = new BMap.Map("contact-map");
    var point = new BMap.Point(lng, lat); 
    map.centerAndZoom(point, 19);
    map.enableScrollWheelZoom(true);
    map.addControl(new BMap.NavigationControl());
    map.addControl(new BMap.ScaleControl());
    map.addControl(new BMap.OverviewMapControl());
    map.addControl(new BMap.MapTypeControl());   

    var marker = new BMap.Marker(point);
    map.addOverlay(marker);

    var infoWindow = new BMap.InfoWindow(content);
    marker.openInfoWindow(infoWindow);
    marker.addEventListener("click", function () {
        this.openInfoWindow(infoWindow);
    });
});