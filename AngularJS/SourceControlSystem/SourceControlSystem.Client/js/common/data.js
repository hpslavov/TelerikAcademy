(function () {
    'use strict';

    function data($http, $q, authorization, notifier, baseServiceUrl) {

        function get(url, queryParams) {
            var deferred = $q.defer();

            var authHeader = authorization.getAuthorizationHeader();

            $http.get(baseServiceUrl + '/' + url, { params: queryParams, headers: authHeader })
                .then(function (response) {
                    deferred.resolve(response.data);
                }, function (err) {
                    var error = getErrorMessage(err);
                    notifier.error(error);
                    deferred.reject(error);
                });


            return deferred.promise;
        }

        function post(url, postData) {
            var deferred = $q.defer();

            var authHeader = authorization.getAuthorizationHeader();

            $http.post(baseServiceUrl + '/' + url, postData, { headers: authHeader })
                .then(function (response) {
                    deferred.resolve(response.data);
                }, function (err) {
                    var error = getErrorMessage(err);
                    notifier.error(error);
                    deferred.reject(error);
                });


            return deferred.promise;
        }

        function put(url,postData) {
            var deferred = $q.defer();

            var authHeader = authorization.getAuthorizationHeader();

            $http.put(baseServiceUrl + '/' + url, postData, { headers: authHeader })
                .then(function (response) {
                    deferred.resolve(response.data);
                }, function (err) {
                    var error = getErrorMessage(err);
                    notifier.error(error);
                    deferred.reject(error);
                });


            return deferred.promise;
        }

        function getErrorMessage(response) {

               console.log(response);
               var error = response.data.Message;

           return error;
        }

        return {
            get: get,
            post: post,
            put: put
        }
    }

    angular.module('myApp.services')
        .factory('data', ['$http', '$q', 'authorization', 'notifier', 'baseServiceUrl', data]);
}());