(function () {
    'use strict'

    angular
        .module("app.main")
        .controller("MainController", MainController);

    MainController.$inject = ['$interval', 'DroneData'];

    function MainController($interval, DroneData) {
        var vm = this;
        vm.test = "test";

        vm.weatherStatus = {};

        vm.map = { center: { latitude: 50 ,longitude: -50}, zoom: 8 };

        vm.marker = { id: 1, coords: { latitude: 50, longitude: -50 }, options: { icon: "/Content/Images/Default/drone.png" } };
                                    

        getWeather();

        
        $interval(getWeather, 10000 * 60);

        function getWeather() {
            vm.weatherStatus = DroneData.getPlaceStatus();
            vm.marker.coords.latitude = vm.weatherStatus.Coordinate.latitude;
            vm.marker.coords.longitude = vm.weatherStatus.Coordinate.longitude;
            console.log(vm.weatherStatus);
        }
    }
})()