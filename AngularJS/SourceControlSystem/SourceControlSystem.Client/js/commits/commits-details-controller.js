(function () {
    'use strict';

    function CommitsDetailsController($routeParams,commits, notifier, identity) {

        var vm = this;
        vm.identity = identity;
        vm.commit;

        commits.getById($routeParams.id)
            .then(function (response) {
                console.log(response);
                vm.commit = response;
            });

    }

    angular.module('myApp.controllers')
        .controller('CommitsDetailsController', ['$routeParams','commits', 'notifier', 'identity', CommitsDetailsController]);
}());