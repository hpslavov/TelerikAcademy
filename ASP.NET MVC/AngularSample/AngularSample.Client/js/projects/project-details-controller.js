(function () {
    'use strict';

    function ProjectDetailsController($routeParams,projects, notifier, identity) {

        var vm = this;
        vm.identity = identity;
        vm.project;

        projects.getById($routeParams.id)
            .then(function (response) {
                console.log(response);
                vm.project = response;
            });

    }

    angular.module('myApp.controllers')
        .controller('ProjectDetailsController', ['$routeParams','projects', 'notifier', 'identity', ProjectDetailsController]);
}());