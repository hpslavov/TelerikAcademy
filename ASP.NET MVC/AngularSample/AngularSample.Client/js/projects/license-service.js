(function(){
    'use strict';

    function licenses(data) {

        var CURRENT_URL = 'api/licenses'

        function getLicenses() {
            return data.get(CURRENT_URL);
        }

        return {
            getLicenses:getLicenses
        }
    }

    angular.module('myApp.services')
        .factory('licenses',['data',licenses]);
}());