(function () {
    'use strict';

    function auth($http, $q, identity, authorization, baseServiceUrl,notifier) {
        var usersApi = baseServiceUrl + '/api/Account'

        return {
            signup: function (user) {
                var deferred = $q.defer();

                $http.post(usersApi + '/Register', user)
                    .then(function () {
                        deferred.resolve();
                    }, function (response) {
                        notifier.error(response.data['ModelState']['model.ConfirmPassword'][0]);
                        deferred.reject(response.message);
                    });

                return deferred.promise;
            },
            login: function (user) {
                var deferred = $q.defer();
                user['grant_type'] = 'password';
                $http.post(baseServiceUrl + '/Token', 'username=' + user.username + '&password=' + user.password + '&grant_type=password', { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                    .then(function (response) {
                        if (response.data["access_token"]) {
                            identity.setCurrentUser(response.data);
                            deferred.resolve(true);
                        }
                        else {
                            deferred.resolve(false);
                        }
                    }, function (error) {
                        notifier.error(error['data']['error_description']);
                    });

                return deferred.promise;
            },
            logout: function () {
                var deferred = $q.defer();

                var headers = authorization.getAuthorizationHeader();
                $http.post(usersApi + '/logout', {}, { headers: headers })
                    .then(function () {
                        identity.setCurrentUser(undefined);
                        deferred.resolve();
                    });

                return deferred.promise;
            },
            isAuthenticated: function () {
                if (identity.isAuthenticated()) {
                    return true;
                }
                else {
                    return $q.reject('not authorized');
                }
            }
        }
    }

    angular.module('myApp.services')
        .factory('auth', ['$http', '$q', 'identity', 'authorization', 'baseServiceUrl','notifier', auth]);
}());