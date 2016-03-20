(function () {
    'use strict';

    function humanReadableDate() {

        return function (input) {

            var monthNames = [
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            ];

            var date = new Date(input);
            var day = date.getDate();
            var monthIndex = date.getMonth();
            var year = date.getFullYear();
            var hours = date.getHours();
            var minutes = date.getMinutes();
            var seconds = date.getSeconds();

            return day + ' ' + monthNames[monthIndex] + ' ' + year + '  ' + hours + ':' + minutes + ':' + seconds;
        }
    }

    angular.module('myApp.filters')
        .filter('humanReadableDate', [humanReadableDate]);
}());